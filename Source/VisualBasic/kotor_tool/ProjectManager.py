#!/usr/bin/env python3
# -*- coding: utf-8 -*-

r"""
ProjectManager.py

KoTOR Tool Restoration Project - VB.NET Project File Organiser
Author: LordVaderCW / James Stuart

Description:
    A safe Tkinter GUI utility for inspecting, organising, and updating
    Visual Basic .vbproj files, especially restored/decompiled WinForms
    projects such as Fred Tetra's KoTOR Tool.

    This version is designed to be run from inside the project directory.
    On startup it auto-detects the first .vbproj file in the current folder
    and loads it automatically.

Features:
    - Auto-loads [projectname].vbproj from the current working directory.
    - Uses a grouped tree layout instead of a flat list.
    - Groups entries by References, Application Designer, Compile groups,
      Embedded Resources, Content, None, Folders, and Bootstrapper Packages.
    - Adds a second file-system panel for quick project-folder awareness.
    - Detects missing files referenced by the project.
    - Detects untracked files on disk.
    - Adds existing files to the project.
    - Removes entries from the project without deleting files.
    - Moves selected file entries into a folder and optionally moves files on disk.
    - Repairs DependentUpon metadata for .Designer.vb and .resx entries.
    - Repairs WinForms .resources / .resx paths after forms are moved to WinForms.
    - Creates timestamped .bak backup before saving.

Requirements:
    Python 3.10+
    Standard library only.

Usage:
    cd "path\\to\\kotor_tool"
    python ProjectManager.py
"""

from __future__ import annotations

import os
import shutil
import sys
import traceback
import xml.etree.ElementTree as ET
from dataclasses import dataclass
from datetime import datetime
from pathlib import Path
from typing import Dict, List, Optional, Set, Tuple

import tkinter as tk
from tkinter import filedialog, messagebox, simpledialog, ttk


MSBUILD_NS = "http://schemas.microsoft.com/developer/msbuild/2003"
ET.register_namespace("", MSBUILD_NS)

PROJECT_ITEM_TYPES = {
    "Compile",
    "EmbeddedResource",
    "None",
    "Content",
    "Folder",
    "Reference",
    "AppDesigner",
    "BootstrapperPackage",
}

FILE_ITEM_TYPES = {
    "Compile",
    "EmbeddedResource",
    "None",
    "Content",
}

VB_EXTENSIONS = {
    ".vb": "Compile",
    ".resx": "EmbeddedResource",
    ".resources": "EmbeddedResource",
    ".ico": "Content",
    ".txt": "Content",
    ".xml": "None",
    ".ini": "None",
    ".config": "None",
    ".manifest": "None",
}

IGNORED_SCAN_DIRS = {
    ".git",
    ".vs",
    "bin",
    "obj",
    "backup",
    "backups",
    "packages",
    "publish",
    "__pycache__",
}

GROUP_ORDER = [
    "References",
    "Application Designer",
    "Compile - Classes",
    "Compile - WinForms",
    "Compile - Root / Other",
    "Embedded Resources - ResX",
    "Embedded Resources - Compiled",
    "Content",
    "None / Configuration",
    "Folders",
    "Bootstrapper Packages",
    "Other",
]

AUTO_ORGANISE_FOLDERS = {
    "classes": "Classes",
    "themes": "Themes",
    "winforms": "WinForms",
    "configurationfiles": "ConfigurationFiles",
    "my project": "My Project",
}


@dataclass
class ProjectEntry:
    item_type: str
    include: str
    item_group: ET.Element
    element: ET.Element

    @property
    def include_path(self) -> str:
        return self.include.replace("/", "\\")

    @property
    def display_name(self) -> str:
        if self.include_path:
            return self.include_path
        return self.item_type

    def child_text(self, child_name: str) -> str:
        child = self.element.find(qname(child_name))
        if child is None or child.text is None:
            return ""
        return child.text.strip()

    @property
    def dependent_upon(self) -> str:
        return self.child_text("DependentUpon")

    @property
    def subtype(self) -> str:
        return self.child_text("SubType")

    @property
    def logical_name(self) -> str:
        return self.child_text("LogicalName")

    @property
    def copy_to_output(self) -> str:
        return self.child_text("CopyToOutputDirectory")


def qname(local_name: str) -> str:
    return "{%s}%s" % (MSBUILD_NS, local_name)


def local_name(tag: str) -> str:
    if tag.startswith("{"):
        return tag.split("}", 1)[1]
    return tag


def normalise_project_path(path_text: str) -> str:
    return path_text.replace("/", "\\").strip()


def project_path_to_disk(project_dir: Path, include_path: str) -> Path:
    return project_dir / include_path.replace("\\", os.sep)


def disk_path_to_project(project_dir: Path, file_path: Path) -> str:
    relative = file_path.resolve().relative_to(project_dir.resolve())
    return str(relative).replace(os.sep, "\\")


def indent_xml(element: ET.Element, level: int = 0) -> None:
    spacing = "\n" + ("  " * level)
    child_spacing = "\n" + ("  " * (level + 1))

    children = list(element)
    if children:
        if not element.text or not element.text.strip():
            element.text = child_spacing
        for child in children:
            indent_xml(child, level + 1)
        if not children[-1].tail or not children[-1].tail.strip():
            children[-1].tail = spacing

    if level and (not element.tail or not element.tail.strip()):
        element.tail = spacing


def find_vbproj_in_current_directory() -> Optional[Path]:
    current_dir = Path.cwd()
    candidates = sorted(current_dir.glob("*.vbproj"), key=lambda p: p.name.lower())

    if not candidates:
        return None

    if len(candidates) == 1:
        return candidates[0]

    preferred_names = {
        current_dir.name.lower() + ".vbproj",
        "kotor_tool.vbproj",
        "kotor tool.vbproj",
    }

    for candidate in candidates:
        if candidate.name.lower() in preferred_names:
            return candidate

    return candidates[0]


def get_child_text(element: ET.Element, child_name: str) -> str:
    child = element.find(qname(child_name))
    if child is None or child.text is None:
        return ""
    return child.text.strip()


def set_child_text(element: ET.Element, child_name: str, text_value: str) -> None:
    child = element.find(qname(child_name))
    if child is None:
        child = ET.SubElement(element, qname(child_name))
    child.text = text_value


def guess_item_type(include_path: str) -> str:
    lower_path = include_path.lower()
    suffix = Path(lower_path).suffix

    if lower_path.endswith(".designer.vb") or suffix == ".vb":
        return "Compile"

    if suffix in {".resx", ".resources"}:
        return "EmbeddedResource"

    if suffix in {".txt", ".ico", ".png", ".jpg", ".jpeg", ".bmp", ".gif"}:
        return "Content"

    return VB_EXTENSIONS.get(suffix, "None")


def group_for_entry(entry: ProjectEntry) -> str:
    include_lower = entry.include_path.lower()
    include_name = Path(entry.include_path).name.lower()

    if entry.item_type == "Reference":
        return "References"

    if entry.item_type == "AppDesigner":
        return "Application Designer"

    if entry.item_type == "Folder":
        return "Folders"

    if entry.item_type == "BootstrapperPackage":
        return "Bootstrapper Packages"

    if entry.item_type == "Compile":
        if include_lower.startswith("classes\\"):
            return "Compile - Classes"

        if include_lower.startswith("winforms\\"):
            return "Compile - WinForms"

        if include_name.startswith("frm") or include_name.startswith("regreminder"):
            return "Compile - WinForms"

        return "Compile - Root / Other"

    if entry.item_type == "EmbeddedResource":
        if include_name.endswith(".resx"):
            return "Embedded Resources - ResX"
        return "Embedded Resources - Compiled"

    if entry.item_type == "Content":
        return "Content"

    if entry.item_type == "None":
        return "None / Configuration"

    return "Other"


def sort_key_for_entry(entry: ProjectEntry) -> Tuple[int, str, str]:
    group_name = group_for_entry(entry)

    try:
        group_index = GROUP_ORDER.index(group_name)
    except ValueError:
        group_index = 999

    return group_index, entry.item_type.lower(), entry.include_path.lower()


class VbProjDocument:
    def __init__(self) -> None:
        self.project_file: Optional[Path] = None
        self.project_dir: Optional[Path] = None
        self.tree: Optional[ET.ElementTree] = None
        self.root: Optional[ET.Element] = None

    def load(self, project_file: Path) -> None:
        project_file = project_file.resolve()

        if not project_file.exists():
            raise FileNotFoundError(str(project_file))

        if project_file.suffix.lower() != ".vbproj":
            raise ValueError("Selected file is not a .vbproj file.")

        parser = ET.XMLParser(target=ET.TreeBuilder(insert_comments=True))
        self.tree = ET.parse(str(project_file), parser=parser)
        self.root = self.tree.getroot()
        self.project_file = project_file
        self.project_dir = project_file.parent

        if self.root.tag != qname("Project"):
            raise ValueError("This does not appear to be an MSBuild VB project file.")

    def assert_loaded(self) -> None:
        if self.project_file is None or self.project_dir is None or self.tree is None or self.root is None:
            raise RuntimeError("No project loaded.")

    def property_groups(self) -> List[ET.Element]:
        self.assert_loaded()
        assert self.root is not None
        return [node for node in self.root.findall(qname("PropertyGroup"))]

    def item_groups(self) -> List[ET.Element]:
        self.assert_loaded()
        assert self.root is not None
        return [node for node in self.root.findall(qname("ItemGroup"))]

    def entries(self) -> List[ProjectEntry]:
        result: List[ProjectEntry] = []

        for group in self.item_groups():
            for child in list(group):
                tag = local_name(child.tag)

                if tag not in PROJECT_ITEM_TYPES:
                    continue

                include = child.attrib.get("Include", "")
                result.append(ProjectEntry(tag, include, group, child))

        return result

    def file_entries(self) -> List[ProjectEntry]:
        return [
            entry
            for entry in self.entries()
            if entry.item_type in FILE_ITEM_TYPES and entry.include
        ]

    def project_summary(self) -> Dict[str, str]:
        self.assert_loaded()
        assert self.root is not None
        assert self.project_file is not None

        summary: Dict[str, str] = {
            "Project File": str(self.project_file),
            "ToolsVersion": self.root.attrib.get("ToolsVersion", ""),
            "DefaultTargets": self.root.attrib.get("DefaultTargets", ""),
        }

        wanted = {
            "AssemblyName",
            "RootNamespace",
            "TargetFrameworkVersion",
            "StartupObject",
            "OutputType",
            "ProjectGuid",
            "ApplicationIcon",
            "OptionStrict",
            "OptionExplicit",
        }

        for group in self.property_groups():
            condition = group.attrib.get("Condition", "")

            if condition:
                continue

            for child in list(group):
                name = local_name(child.tag)
                text = "" if child.text is None else child.text.strip()

                if name in wanted:
                    summary[name] = text

        return summary

    def find_entry(self, item_type: str, include_path: str) -> Optional[ProjectEntry]:
        include_path_norm = normalise_project_path(include_path).lower()

        for entry in self.entries():
            if entry.item_type == item_type and normalise_project_path(entry.include).lower() == include_path_norm:
                return entry

        return None

    def includes_set(self) -> Set[str]:
        return {
            normalise_project_path(entry.include).lower()
            for entry in self.file_entries()
        }

    def first_item_group_for_type(self, item_type: str) -> ET.Element:
        self.assert_loaded()
        assert self.root is not None

        for group in self.item_groups():
            for child in list(group):
                if local_name(child.tag) == item_type:
                    return group

        new_group = ET.Element(qname("ItemGroup"))
        import_node = self.root.find(qname("Import"))

        if import_node is not None:
            children = list(self.root)
            insert_index = children.index(import_node)
            self.root.insert(insert_index, new_group)
        else:
            self.root.append(new_group)

        return new_group

    def add_file_entry(self, include_path: str, item_type: Optional[str] = None) -> ProjectEntry:
        self.assert_loaded()
        include_path = normalise_project_path(include_path)

        if item_type is None:
            item_type = guess_item_type(include_path)

        existing = self.find_entry(item_type, include_path)

        if existing is not None:
            return existing

        group = self.first_item_group_for_type(item_type)
        element = ET.Element(qname(item_type), {"Include": include_path})

        base_name = Path(include_path).name
        lower_name = base_name.lower()

        if item_type == "Compile" and lower_name.endswith(".designer.vb"):
            dependent = base_name[:-len(".Designer.vb")] + ".vb"
            dependent_node = ET.SubElement(element, qname("DependentUpon"))
            dependent_node.text = dependent

        if item_type == "Compile" and lower_name.startswith("frm") and lower_name.endswith(".vb") and not lower_name.endswith(".designer.vb"):
            subtype_node = ET.SubElement(element, qname("SubType"))
            subtype_node.text = "Form"

        if item_type == "EmbeddedResource" and lower_name.endswith(".resx"):
            dependent_node = ET.SubElement(element, qname("DependentUpon"))
            dependent_node.text = base_name[:-len(".resx")] + ".vb"

            subtype_node = ET.SubElement(element, qname("SubType"))
            subtype_node.text = "Designer"

        group.append(element)
        return ProjectEntry(item_type, include_path, group, element)

    def remove_entry(self, entry: ProjectEntry) -> None:
        entry.item_group.remove(entry.element)

    def update_entry_include(self, entry: ProjectEntry, new_include: str) -> None:
        new_include = normalise_project_path(new_include)
        entry.element.set("Include", new_include)
        entry.include = new_include

    def move_entry_to_folder(self, entry: ProjectEntry, destination_folder: str, move_disk_file: bool = True) -> str:
        self.assert_loaded()
        assert self.project_dir is not None

        if entry.item_type not in FILE_ITEM_TYPES:
            raise ValueError("Only file-based project entries can be moved.")

        destination_folder = destination_folder.strip().strip("\\/")

        if not destination_folder:
            raise ValueError("Destination folder cannot be empty.")

        old_include = normalise_project_path(entry.include)
        old_disk = project_path_to_disk(self.project_dir, old_include)

        new_include = normalise_project_path(str(Path(destination_folder) / Path(old_include).name))
        new_disk = project_path_to_disk(self.project_dir, new_include)

        if old_include.lower() == new_include.lower():
            return new_include

        if move_disk_file:
            if not old_disk.exists():
                raise FileNotFoundError("Cannot move missing file: %s" % old_disk)

            new_disk.parent.mkdir(parents=True, exist_ok=True)

            if new_disk.exists():
                raise FileExistsError("Destination file already exists: %s" % new_disk)

            shutil.move(str(old_disk), str(new_disk))

        self.update_entry_include(entry, new_include)
        self.repair_dependent_upon_for_entry(entry)

        return new_include

    def repair_dependent_upon_for_entry(self, entry: ProjectEntry) -> None:
        include_name = Path(normalise_project_path(entry.element.attrib.get("Include", ""))).name
        lower_name = include_name.lower()

        if entry.item_type == "Compile" and lower_name.endswith(".designer.vb"):
            dependent_name = include_name[:-len(".Designer.vb")] + ".vb"
            set_child_text(entry.element, "DependentUpon", dependent_name)

        if entry.item_type == "EmbeddedResource" and lower_name.endswith(".resx"):
            dependent_name = include_name[:-len(".resx")] + ".vb"
            set_child_text(entry.element, "DependentUpon", dependent_name)

            if not get_child_text(entry.element, "SubType"):
                set_child_text(entry.element, "SubType", "Designer")

    def repair_winforms_resource_entries(self) -> Tuple[int, List[str]]:
        self.assert_loaded()
        assert self.project_dir is not None

        changed = 0
        missing_after_repair: List[str] = []
        project_dir = self.project_dir

        for entry in self.entries():
            if entry.item_type != "EmbeddedResource":
                continue

            include_path = normalise_project_path(entry.include_path)
            include_name = Path(include_path).name
            include_name_lower = include_name.lower()

            if not include_name_lower.startswith(("frm", "regreminder")):
                continue

            if not include_name_lower.endswith((".resources", ".resx")):
                continue

            current_disk = project_path_to_disk(project_dir, include_path)
            winforms_include = normalise_project_path(str(Path("WinForms") / include_name))
            winforms_disk = project_path_to_disk(project_dir, winforms_include)

            if current_disk.exists():
                self.repair_dependent_upon_for_entry(entry)
                continue

            if winforms_disk.exists():
                self.update_entry_include(entry, winforms_include)
                self.repair_dependent_upon_for_entry(entry)
                changed += 1
            else:
                missing_after_repair.append(include_path)

        self.reorganise_item_groups()
        return changed, missing_after_repair

    def scan_missing_files(self) -> List[ProjectEntry]:
        self.assert_loaded()
        assert self.project_dir is not None

        missing: List[ProjectEntry] = []

        for entry in self.file_entries():
            disk_path = project_path_to_disk(self.project_dir, entry.include)

            if not disk_path.exists():
                missing.append(entry)

        return missing

    def scan_untracked_files(self) -> List[Path]:
        self.assert_loaded()
        assert self.project_dir is not None

        tracked = self.includes_set()
        untracked: List[Path] = []

        for root_dir, dir_names, file_names in os.walk(str(self.project_dir)):
            dir_names[:] = [
                d for d in dir_names
                if d.lower() not in IGNORED_SCAN_DIRS
            ]

            root_path = Path(root_dir)

            for file_name in file_names:
                file_path = root_path / file_name

                if file_path.suffix.lower() not in VB_EXTENSIONS:
                    continue

                if file_path.name.lower().endswith(".vbproj"):
                    continue

                try:
                    include_path = disk_path_to_project(self.project_dir, file_path)
                except ValueError:
                    continue

                if include_path.lower() not in tracked:
                    untracked.append(file_path)

        return sorted(untracked, key=lambda p: str(p).lower())

    def reorganise_item_groups(self) -> None:
        self.assert_loaded()
        assert self.root is not None

        old_item_groups = self.item_groups()
        existing_entries = self.entries()

        for group in old_item_groups:
            self.root.remove(group)

        entries_by_group: Dict[str, List[ProjectEntry]] = {
            group_name: []
            for group_name in GROUP_ORDER
        }

        for entry in existing_entries:
            entries_by_group.setdefault(group_for_entry(entry), []).append(entry)

        new_groups: List[ET.Element] = []

        for group_name in GROUP_ORDER:
            group_entries = sorted(
                entries_by_group.get(group_name, []),
                key=lambda e: (e.item_type.lower(), e.include_path.lower()),
            )

            if not group_entries:
                continue

            new_group = ET.Element(qname("ItemGroup"))

            for entry in group_entries:
                new_group.append(entry.element)
                entry.item_group = new_group

            new_groups.append(new_group)

        import_node = self.root.find(qname("Import"))

        if import_node is not None:
            children = list(self.root)
            insert_index = children.index(import_node)

            for offset, group in enumerate(new_groups):
                self.root.insert(insert_index + offset, group)
        else:
            for group in new_groups:
                self.root.append(group)

    def auto_organise_kotor_layout(self, move_disk_files: bool) -> Tuple[int, List[str]]:
        self.assert_loaded()
        assert self.project_dir is not None

        moved = 0
        failures: List[str] = []
        entries = list(self.file_entries())

        for entry in entries:
            include = entry.include_path
            include_lower = include.lower()
            name = Path(include).name
            name_lower = name.lower()
            current_parent = str(Path(include).parent).replace("/", "\\")
            current_parent_lower = current_parent.lower()

            destination: Optional[str] = None

            if current_parent_lower in AUTO_ORGANISE_FOLDERS:
                continue

            if entry.item_type == "Compile":
                if name_lower.startswith("frm") or name_lower.startswith("regreminder"):
                    destination = "WinForms"
                elif name_lower.startswith("cls"):
                    destination = "Classes"
                elif name_lower in {
                    "kotortheme.vb",
                    "thememanager.vb",
                    "animlistentry.vb",
                    "columnentry.vb",
                    "columnentrylist.vb",
                    "columnsortentry.vb",
                    "columnsortentrylist.vb",
                    "columnvoentry.vb",
                    "columnvoentrylist.vb",
                    "comboboxlistitem.vb",
                    "crypt.vb",
                    "dialogtlkstrdataelement.vb",
                    "dlgconvlistnode.vb",
                    "erfkeyentry.vb",
                    "erflocalizedstring.vb",
                    "inventoryitem.vb",
                    "inventorypanel.vb",
                    "keyentry.vb",
                    "kotortreenode.vb",
                    "ktsoundinfo.vb",
                    "mapinfo.vb",
                    "moditem.vb",
                    "moditemtvnode.vb",
                    "moduleeditorprojectoptions.vb",
                    "moduleeditorprojectsettings.vb",
                    "modulefileentry.vb",
                    "mymapinfosurrogate.vb",
                    "options.vb",
                    "projectfileitemtreenode.vb",
                    "repeatbutton.vb",
                    "rimkeyentry.vb",
                    "rowfilter.vb",
                    "rowfilterpart.vb",
                    "treebaseitem.vb",
                    "usersettings.vb",
                    "utilfilevalidator.vb",
                    "utils.vb",
                    "utilwindowrelativepositioner.vb",
                }:
                    destination = "Classes"

            elif entry.item_type == "EmbeddedResource":
                if name_lower.startswith("frm") or name_lower.startswith("regreminder"):
                    destination = "WinForms"

            elif entry.item_type == "None":
                if name_lower.endswith(".ini"):
                    destination = "Themes"
                elif name_lower in {"app.config", "settings.xml"} and not include_lower.startswith("my project\\"):
                    destination = "ConfigurationFiles"

            if destination is None:
                continue

            try:
                self.move_entry_to_folder(entry, destination, move_disk_file=move_disk_files)
                moved += 1
            except Exception as exc:
                failures.append("%s -> %s" % (entry.include_path, exc))

        self.reorganise_item_groups()
        return moved, failures

    def save(self) -> Path:
        self.assert_loaded()
        assert self.tree is not None
        assert self.root is not None
        assert self.project_file is not None

        backup_file = self.create_backup()
        indent_xml(self.root)
        self.tree.write(str(self.project_file), encoding="utf-8", xml_declaration=True)

        return backup_file

    def create_backup(self) -> Path:
        self.assert_loaded()
        assert self.project_file is not None

        timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
        backup_file = self.project_file.with_suffix(
            self.project_file.suffix + ".%s.bak" % timestamp
        )

        shutil.copy2(str(self.project_file), str(backup_file))
        return backup_file


class VbProjOrganiserApp(tk.Tk):
    def __init__(self) -> None:
        super().__init__()

        self.title("VBProj Organiser - KoTOR Tool Restoration")
        self.geometry("1320x780")
        self.minsize(1120, 640)

        self.document = VbProjDocument()
        self.entries_by_iid: Dict[str, ProjectEntry] = {}
        self.group_iids: Dict[str, str] = {}

        self.current_filter = tk.StringVar(value="All")
        self.status_text = tk.StringVar(value="Auto-detecting .vbproj in current project directory...")
        self.search_text = tk.StringVar(value="")
        self.project_title_text = tk.StringVar(value="No project loaded")
        self.project_meta_text = tk.StringVar(
            value="Run this script from inside the folder that contains the .vbproj file."
        )

        self._configure_style()
        self._build_layout()
        self._bind_events()

        self.after(150, self.auto_load_project_from_cwd)

    def _configure_style(self) -> None:
        style = ttk.Style(self)

        try:
            style.theme_use("clam")
        except tk.TclError:
            pass

        self.configure(bg="#15181d")

        style.configure("TFrame", background="#15181d")
        style.configure("Header.TFrame", background="#11151b")
        style.configure("Toolbar.TFrame", background="#20242b")
        style.configure("Panel.TFrame", background="#15181d")

        style.configure("TLabel", background="#15181d", foreground="#e6e6e6")
        style.configure(
            "HeaderTitle.TLabel",
            background="#11151b",
            foreground="#ffffff",
            font=("Segoe UI", 12, "bold"),
        )
        style.configure(
            "HeaderMeta.TLabel",
            background="#11151b",
            foreground="#aeb7c4",
            font=("Segoe UI", 9),
        )
        style.configure("Status.TLabel", background="#101216", foreground="#b9c0cc")

        style.configure("TButton", padding=(8, 4))
        style.configure("TCombobox", padding=(4, 2))

        style.configure(
            "Treeview",
            rowheight=23,
            fieldbackground="#111318",
            background="#111318",
            foreground="#e6e6e6",
            borderwidth=0,
        )
        style.configure(
            "Treeview.Heading",
            background="#252b34",
            foreground="#ffffff",
            relief=tk.FLAT,
        )
        style.map(
            "Treeview",
            background=[("selected", "#2f5f88")],
            foreground=[("selected", "#ffffff")],
        )

        style.configure("TLabelframe", background="#15181d", foreground="#e6e6e6")
        style.configure("TLabelframe.Label", background="#15181d", foreground="#e6e6e6")

    def _build_layout(self) -> None:
        root = ttk.Frame(self)
        root.pack(fill=tk.BOTH, expand=True)

        header = ttk.Frame(root, style="Header.TFrame")
        header.pack(fill=tk.X)

        title_area = ttk.Frame(header, style="Header.TFrame")
        title_area.pack(side=tk.LEFT, fill=tk.X, expand=True, padx=12, pady=8)

        ttk.Label(
            title_area,
            textvariable=self.project_title_text,
            style="HeaderTitle.TLabel",
        ).pack(anchor=tk.W)

        ttk.Label(
            title_area,
            textvariable=self.project_meta_text,
            style="HeaderMeta.TLabel",
        ).pack(anchor=tk.W, pady=(2, 0))

        quick_area = ttk.Frame(header, style="Header.TFrame")
        quick_area.pack(side=tk.RIGHT, padx=8, pady=8)

        ttk.Button(quick_area, text="Open", command=self.open_project).pack(side=tk.LEFT, padx=3)
        ttk.Button(quick_area, text="Save", command=self.save_project).pack(side=tk.LEFT, padx=3)
        ttk.Button(quick_area, text="Reload", command=self.reload_project).pack(side=tk.LEFT, padx=3)

        toolbar = ttk.Frame(root, style="Toolbar.TFrame")
        toolbar.pack(fill=tk.X, padx=0, pady=0)

        ttk.Button(toolbar, text="Auto Organise KoTOR Layout", command=self.auto_organise_kotor_layout).pack(side=tk.LEFT, padx=6, pady=6)
        ttk.Button(toolbar, text="Rebuild Item Groups", command=self.rebuild_item_groups).pack(side=tk.LEFT, padx=3, pady=6)
        ttk.Button(toolbar, text="Add Existing File", command=self.add_existing_file).pack(side=tk.LEFT, padx=3, pady=6)
        ttk.Button(toolbar, text="Remove Entry", command=self.remove_selected_entry).pack(side=tk.LEFT, padx=3, pady=6)
        ttk.Button(toolbar, text="Move To Folder", command=self.move_selected_to_folder).pack(side=tk.LEFT, padx=3, pady=6)
        ttk.Button(toolbar, text="Repair DependentUpon", command=self.repair_selected_dependent).pack(side=tk.LEFT, padx=3, pady=6)
        ttk.Button(toolbar, text="Repair WinForms Resources", command=self.repair_winforms_resources).pack(side=tk.LEFT, padx=3, pady=6)

        actionbar = ttk.Frame(root, style="Toolbar.TFrame")
        actionbar.pack(fill=tk.X, padx=0, pady=(1, 0))

        ttk.Label(actionbar, text="Filter:").pack(side=tk.LEFT, padx=(8, 4))

        filter_box = ttk.Combobox(
            actionbar,
            textvariable=self.current_filter,
            values=["All"] + GROUP_ORDER + [
                "Compile",
                "EmbeddedResource",
                "None",
                "Content",
                "Folder",
                "Reference",
                "AppDesigner",
                "BootstrapperPackage",
            ],
            state="readonly",
            width=28,
        )
        filter_box.pack(side=tk.LEFT, padx=3, pady=6)

        ttk.Label(actionbar, text="Search:").pack(side=tk.LEFT, padx=(12, 4))

        search_entry = ttk.Entry(actionbar, textvariable=self.search_text, width=38)
        search_entry.pack(side=tk.LEFT, padx=3, pady=6)

        ttk.Button(actionbar, text="Clear", command=self.clear_search).pack(side=tk.LEFT, padx=3, pady=6)

        ttk.Separator(actionbar, orient=tk.VERTICAL).pack(side=tk.LEFT, fill=tk.Y, padx=8, pady=6)

        ttk.Button(actionbar, text="Scan Missing", command=self.scan_missing).pack(side=tk.LEFT, padx=3, pady=6)
        ttk.Button(actionbar, text="Scan Untracked", command=self.scan_untracked).pack(side=tk.LEFT, padx=3, pady=6)
        ttk.Button(actionbar, text="Add All Untracked", command=self.add_all_untracked).pack(side=tk.LEFT, padx=3, pady=6)
        ttk.Button(actionbar, text="Expand All", command=self.expand_all).pack(side=tk.LEFT, padx=3, pady=6)
        ttk.Button(actionbar, text="Collapse All", command=self.collapse_all).pack(side=tk.LEFT, padx=3, pady=6)

        main = ttk.PanedWindow(root, orient=tk.HORIZONTAL)
        main.pack(fill=tk.BOTH, expand=True, padx=8, pady=8)

        left_panel = ttk.Labelframe(main, text="Project Entries")
        right_panel = ttk.PanedWindow(main, orient=tk.VERTICAL)

        main.add(left_panel, weight=4)
        main.add(right_panel, weight=1)

        columns = ("include", "item_type", "dependent", "subtype", "logical", "copy")

        self.treeview = ttk.Treeview(
            left_panel,
            columns=columns,
            show="tree headings",
            selectmode="extended",
        )

        self.treeview.heading("#0", text="Group / File")
        self.treeview.heading("include", text="Include")
        self.treeview.heading("item_type", text="Type")
        self.treeview.heading("dependent", text="DependentUpon")
        self.treeview.heading("subtype", text="SubType")
        self.treeview.heading("logical", text="LogicalName")
        self.treeview.heading("copy", text="Copy")

        self.treeview.column("#0", width=250, minwidth=180, anchor=tk.W)
        self.treeview.column("include", width=420, minwidth=220, anchor=tk.W)
        self.treeview.column("item_type", width=110, minwidth=80, anchor=tk.W)
        self.treeview.column("dependent", width=165, minwidth=120, anchor=tk.W)
        self.treeview.column("subtype", width=100, minwidth=80, anchor=tk.W)
        self.treeview.column("logical", width=220, minwidth=120, anchor=tk.W)
        self.treeview.column("copy", width=120, minwidth=90, anchor=tk.W)

        yscroll = ttk.Scrollbar(left_panel, orient=tk.VERTICAL, command=self.treeview.yview)
        xscroll = ttk.Scrollbar(left_panel, orient=tk.HORIZONTAL, command=self.treeview.xview)

        self.treeview.configure(yscrollcommand=yscroll.set, xscrollcommand=xscroll.set)

        self.treeview.grid(row=0, column=0, sticky="nsew")
        yscroll.grid(row=0, column=1, sticky="ns")
        xscroll.grid(row=1, column=0, sticky="ew")

        left_panel.rowconfigure(0, weight=1)
        left_panel.columnconfigure(0, weight=1)

        summary_frame = ttk.Labelframe(right_panel, text="Project Summary")
        file_frame = ttk.Labelframe(right_panel, text="Project Folders")

        right_panel.add(summary_frame, weight=1)
        right_panel.add(file_frame, weight=2)

        self.summary_box = tk.Text(
            summary_frame,
            height=10,
            wrap=tk.WORD,
            bg="#111318",
            fg="#e6e6e6",
            insertbackground="#ffffff",
            relief=tk.FLAT,
            padx=8,
            pady=8,
        )
        self.summary_box.pack(fill=tk.BOTH, expand=True, padx=4, pady=4)
        self.summary_box.configure(state=tk.DISABLED)

        self.folder_tree = ttk.Treeview(
            file_frame,
            columns=("status",),
            show="tree headings",
            selectmode="browse",
        )

        self.folder_tree.heading("#0", text="Folder / File")
        self.folder_tree.heading("status", text="Status")
        self.folder_tree.column("#0", width=260, minwidth=180, anchor=tk.W)
        self.folder_tree.column("status", width=90, minwidth=70, anchor=tk.W)

        folder_scroll = ttk.Scrollbar(file_frame, orient=tk.VERTICAL, command=self.folder_tree.yview)
        self.folder_tree.configure(yscrollcommand=folder_scroll.set)

        self.folder_tree.grid(row=0, column=0, sticky="nsew")
        folder_scroll.grid(row=0, column=1, sticky="ns")

        file_frame.rowconfigure(0, weight=1)
        file_frame.columnconfigure(0, weight=1)

        status = ttk.Label(
            root,
            textvariable=self.status_text,
            style="Status.TLabel",
            anchor=tk.W,
        )
        status.pack(fill=tk.X, side=tk.BOTTOM, padx=0, pady=0, ipady=5)

    def _bind_events(self) -> None:
        self.current_filter.trace_add("write", lambda *_: self.refresh_entries())
        self.search_text.trace_add("write", lambda *_: self.refresh_entries())
        self.treeview.bind("<Double-1>", self.edit_selected_include)

    def set_status(self, text: str) -> None:
        self.status_text.set(text)
        self.update_idletasks()

    def auto_load_project_from_cwd(self) -> None:
        project_file = find_vbproj_in_current_directory()

        if project_file is None:
            self.set_status("No .vbproj found in current directory: %s" % Path.cwd())
            return

        try:
            self.document.load(project_file)
            self.update_project_header()
            self.refresh_entries()
            self.refresh_project_folders()
            self.set_status("Auto-loaded project: %s" % project_file)
        except Exception as exc:
            self.show_error("Auto-load Failed", exc)

    def update_project_header(self) -> None:
        try:
            self.document.assert_loaded()
            assert self.document.project_file is not None

            summary = self.document.project_summary()
            assembly = summary.get("AssemblyName", self.document.project_file.stem)
            framework = summary.get("TargetFrameworkVersion", "")
            output_type = summary.get("OutputType", "")

            self.project_title_text.set("%s  —  %s" % (assembly, self.document.project_file.name))
            self.project_meta_text.set("%s | %s | %s" % (self.document.project_file.parent, framework, output_type))
            self.populate_summary_box(summary)
        except Exception:
            self.project_title_text.set("No project loaded")
            self.project_meta_text.set("Run this script from inside the folder that contains the .vbproj file.")

    def populate_summary_box(self, summary: Dict[str, str]) -> None:
        self.summary_box.configure(state=tk.NORMAL)
        self.summary_box.delete("1.0", tk.END)

        for key in sorted(summary.keys()):
            self.summary_box.insert(tk.END, "%s: %s\n" % (key, summary[key]))

        self.summary_box.configure(state=tk.DISABLED)

    def open_project(self) -> None:
        initial_dir = str(Path.cwd())

        if self.document.project_dir is not None:
            initial_dir = str(self.document.project_dir)

        file_name = filedialog.askopenfilename(
            title="Open VB Project",
            initialdir=initial_dir,
            filetypes=[("VB Project", "*.vbproj"), ("All Files", "*.*")],
        )

        if not file_name:
            return

        try:
            self.document.load(Path(file_name))
            self.update_project_header()
            self.refresh_entries()
            self.refresh_project_folders()
            self.set_status("Loaded: %s" % file_name)
        except Exception as exc:
            self.show_error("Open Project Failed", exc)

    def reload_project(self) -> None:
        try:
            self.document.assert_loaded()
            assert self.document.project_file is not None

            project_file = self.document.project_file

            self.document.load(project_file)
            self.update_project_header()
            self.refresh_entries()
            self.refresh_project_folders()
            self.set_status("Reloaded: %s" % project_file)
        except Exception as exc:
            self.show_error("Reload Failed", exc)

    def save_project(self) -> None:
        try:
            backup = self.document.save()
            project_file = self.document.project_file

            if project_file is not None:
                self.document.load(project_file)

            self.update_project_header()
            self.refresh_entries()
            self.refresh_project_folders()

            self.set_status("Saved project. Backup created: %s" % backup.name)

            messagebox.showinfo(
                "Saved",
                "Project saved successfully.\n\nBackup created:\n%s" % backup,
            )
        except Exception as exc:
            self.show_error("Save Failed", exc)

    def clear_search(self) -> None:
        self.search_text.set("")

    def refresh_entries(self) -> None:
        self.entries_by_iid.clear()
        self.group_iids.clear()

        for iid in self.treeview.get_children():
            self.treeview.delete(iid)

        try:
            entries = sorted(self.document.entries(), key=sort_key_for_entry)
        except Exception:
            return

        selected_filter = self.current_filter.get()
        search_value = self.search_text.get().strip().lower()

        grouped: Dict[str, List[ProjectEntry]] = {
            group_name: []
            for group_name in GROUP_ORDER
        }

        for entry in entries:
            group_name = group_for_entry(entry)

            if selected_filter in PROJECT_ITEM_TYPES and entry.item_type != selected_filter:
                continue

            if selected_filter in GROUP_ORDER and group_name != selected_filter:
                continue

            searchable = " ".join([
                group_name,
                entry.item_type,
                entry.include,
                entry.dependent_upon,
                entry.subtype,
                entry.logical_name,
                entry.copy_to_output,
            ]).lower()

            if search_value and search_value not in searchable:
                continue

            grouped.setdefault(group_name, []).append(entry)

        visible_count = 0

        for group_name in GROUP_ORDER:
            group_entries = grouped.get(group_name, [])

            if not group_entries:
                continue

            group_iid = "group_%s" % group_name.replace(" ", "_").replace("/", "_")

            self.treeview.insert(
                "",
                tk.END,
                iid=group_iid,
                text="%s (%d)" % (group_name, len(group_entries)),
                open=True,
                values=("", "", "", "", "", ""),
            )

            self.group_iids[group_name] = group_iid

            for entry_index, entry in enumerate(group_entries):
                iid = "entry_%s_%d" % (group_iid, entry_index)
                display_name = Path(entry.include_path).name if entry.include_path else entry.item_type

                self.treeview.insert(
                    group_iid,
                    tk.END,
                    iid=iid,
                    text=display_name,
                    values=(
                        entry.include_path,
                        entry.item_type,
                        entry.dependent_upon,
                        entry.subtype,
                        entry.logical_name,
                        entry.copy_to_output,
                    ),
                )

                self.entries_by_iid[iid] = entry
                visible_count += 1

        self.set_status("Entries visible: %d / total: %d" % (visible_count, len(entries)))

    def refresh_project_folders(self) -> None:
        for iid in self.folder_tree.get_children():
            self.folder_tree.delete(iid)

        try:
            self.document.assert_loaded()
            assert self.document.project_dir is not None

            tracked = self.document.includes_set()
            project_dir = self.document.project_dir
        except Exception:
            return

        def insert_directory(parent_iid: str, directory: Path, depth: int) -> None:
            if depth > 2:
                return

            try:
                children = sorted(
                    directory.iterdir(),
                    key=lambda p: (not p.is_dir(), p.name.lower()),
                )
            except OSError:
                return

            for child in children:
                if child.name.lower() in IGNORED_SCAN_DIRS:
                    continue

                if child.name == Path(__file__).name:
                    continue

                rel_name = child.name

                if child.is_dir():
                    iid = self.folder_tree.insert(
                        parent_iid,
                        tk.END,
                        text=rel_name,
                        values=("Folder",),
                        open=(depth == 0),
                    )
                    insert_directory(iid, child, depth + 1)
                else:
                    if child.suffix.lower() not in VB_EXTENSIONS and child.suffix.lower() != ".vbproj":
                        continue

                    try:
                        include_path = disk_path_to_project(project_dir, child).lower()
                    except ValueError:
                        include_path = ""

                    status = "Tracked" if include_path in tracked else "Untracked"

                    if child.suffix.lower() == ".vbproj":
                        status = "Project"

                    self.folder_tree.insert(
                        parent_iid,
                        tk.END,
                        text=rel_name,
                        values=(status,),
                    )

        root_iid = self.folder_tree.insert(
            "",
            tk.END,
            text=project_dir.name,
            values=("Root",),
            open=True,
        )

        insert_directory(root_iid, project_dir, 0)

    def expand_all(self) -> None:
        for iid in self.treeview.get_children(""):
            self.treeview.item(iid, open=True)

    def collapse_all(self) -> None:
        for iid in self.treeview.get_children(""):
            self.treeview.item(iid, open=False)

    def selected_entries(self) -> List[ProjectEntry]:
        entries: List[ProjectEntry] = []

        for iid in self.treeview.selection():
            entry = self.entries_by_iid.get(iid)

            if entry is not None:
                entries.append(entry)

        return entries

    def selected_entry(self) -> Optional[ProjectEntry]:
        entries = self.selected_entries()

        if not entries:
            messagebox.showwarning("No Selection", "Select a project entry first.")
            return None

        return entries[0]

    def add_existing_file(self) -> None:
        try:
            self.document.assert_loaded()
            assert self.document.project_dir is not None
        except Exception as exc:
            self.show_error("No Project Loaded", exc)
            return

        file_names = filedialog.askopenfilenames(
            title="Add Existing Files",
            initialdir=str(self.document.project_dir),
            filetypes=[
                ("Supported Files", "*.vb *.resx *.resources *.txt *.xml *.ini *.config *.manifest *.ico"),
                ("All Files", "*.*"),
            ],
        )

        if not file_names:
            return

        added = 0
        failed: List[str] = []

        for file_name in file_names:
            try:
                include_path = disk_path_to_project(self.document.project_dir, Path(file_name))
                self.document.add_file_entry(include_path)
                added += 1
            except Exception as exc:
                failed.append("%s -> %s" % (file_name, exc))

        self.document.reorganise_item_groups()
        self.refresh_entries()
        self.refresh_project_folders()

        self.set_status("Added %d file entries." % added)

        if failed:
            messagebox.showwarning("Some Files Failed", "\n".join(failed[:20]))

    def add_all_untracked(self) -> None:
        try:
            untracked = self.document.scan_untracked_files()

            if not untracked:
                messagebox.showinfo("Untracked Files", "No untracked supported files were found.")
                return

            proceed = messagebox.askyesno(
                "Add All Untracked",
                "Add %d untracked supported files to the project?" % len(untracked),
            )

            if not proceed:
                return

            assert self.document.project_dir is not None

            for file_path in untracked:
                include_path = disk_path_to_project(self.document.project_dir, file_path)
                self.document.add_file_entry(include_path)

            self.document.reorganise_item_groups()
            self.refresh_entries()
            self.refresh_project_folders()

            self.set_status("Added %d untracked files." % len(untracked))
        except Exception as exc:
            self.show_error("Add All Untracked Failed", exc)

    def remove_selected_entry(self) -> None:
        entries = self.selected_entries()

        if not entries:
            messagebox.showwarning("No Selection", "Select one or more project entries first.")
            return

        proceed = messagebox.askyesno(
            "Remove Entry",
            "Remove %d selected project entry/entries?\n\nFiles on disk will not be deleted." % len(entries),
        )

        if not proceed:
            return

        try:
            for entry in entries:
                self.document.remove_entry(entry)

            self.document.reorganise_item_groups()
            self.refresh_entries()
            self.refresh_project_folders()

            self.set_status("Removed %d project entry/entries." % len(entries))
        except Exception as exc:
            self.show_error("Remove Failed", exc)

    def move_selected_to_folder(self) -> None:
        entries = self.selected_entries()

        if not entries:
            messagebox.showwarning("No Selection", "Select one or more file entries first.")
            return

        destination = simpledialog.askstring(
            "Move To Folder",
            "Destination folder relative to the project root, e.g. Classes, WinForms, Themes:",
            parent=self,
        )

        if destination is None:
            return

        destination = destination.strip()

        if not destination:
            messagebox.showwarning("Invalid Folder", "Destination folder cannot be empty.")
            return

        move_files = messagebox.askyesno(
            "Move Files On Disk",
            "Also move the selected files on disk?\n\n"
            "Yes = move files and update Include paths.\n"
            "No = only update Include paths in the project file.",
        )

        moved = 0
        failures: List[str] = []

        for entry in entries:
            try:
                self.document.move_entry_to_folder(
                    entry,
                    destination,
                    move_disk_file=move_files,
                )
                moved += 1
            except Exception as exc:
                failures.append("%s -> %s" % (entry.include, exc))

        self.document.reorganise_item_groups()
        self.refresh_entries()
        self.refresh_project_folders()

        self.set_status("Moved %d entry/entries to %s." % (moved, destination))

        if failures:
            messagebox.showwarning("Some Moves Failed", "\n".join(failures[:20]))

    def repair_selected_dependent(self) -> None:
        entries = self.selected_entries()

        if not entries:
            messagebox.showwarning("No Selection", "Select one or more entries first.")
            return

        try:
            for entry in entries:
                self.document.repair_dependent_upon_for_entry(entry)

            self.refresh_entries()
            self.set_status("Repaired DependentUpon metadata for selected entries where applicable.")
        except Exception as exc:
            self.show_error("Repair Failed", exc)

    def repair_winforms_resources(self) -> None:
        try:
            changed, missing_after_repair = self.document.repair_winforms_resource_entries()

            self.refresh_entries()
            self.refresh_project_folders()

            if missing_after_repair:
                messagebox.showwarning(
                    "Repair Complete With Missing Files",
                    "Updated %d WinForms resource entries.\n\nStill missing:\n%s"
                    % (
                        changed,
                        "\n".join(missing_after_repair[:40]),
                    ),
                )
            else:
                messagebox.showinfo(
                    "Repair Complete",
                    "Updated %d WinForms resource entries.\n\nReview the entries, then press Save."
                    % changed,
                )

            self.set_status(
                "WinForms resource repair complete. Entries updated: %d. Save when ready."
                % changed
            )
        except Exception as exc:
            self.show_error("Repair WinForms Resources Failed", exc)

    def rebuild_item_groups(self) -> None:
        try:
            self.document.reorganise_item_groups()
            self.refresh_entries()
            self.set_status("Item groups rebuilt into organised KoTOR restoration order. Save when ready.")
        except Exception as exc:
            self.show_error("Rebuild Item Groups Failed", exc)

    def auto_organise_kotor_layout(self) -> None:
        try:
            self.document.assert_loaded()
        except Exception as exc:
            self.show_error("No Project Loaded", exc)
            return

        move_files = messagebox.askyesno(
            "Auto Organise KoTOR Layout",
            "Auto-organise obvious files into Classes, WinForms, Themes and ConfigurationFiles?\n\n"
            "Yes = move files on disk and update the .vbproj.\n"
            "No = only update the .vbproj Include paths.\n\n"
            "A backup is only created when you press Save.",
        )

        try:
            moved, failures = self.document.auto_organise_kotor_layout(move_disk_files=move_files)

            self.refresh_entries()
            self.refresh_project_folders()

            self.set_status("Auto-organise complete. Entries moved: %d. Save when ready." % moved)

            if failures:
                messagebox.showwarning("Some Auto Moves Failed", "\n".join(failures[:30]))
            else:
                messagebox.showinfo(
                    "Auto Organise Complete",
                    "Entries moved: %d\n\nReview the tree, then press Save." % moved,
                )
        except Exception as exc:
            self.show_error("Auto Organise Failed", exc)

    def edit_selected_include(self, _event: object = None) -> None:
        entry = self.selected_entry()

        if entry is None:
            return

        new_include = simpledialog.askstring(
            "Edit Include Path",
            "Project Include path:",
            initialvalue=entry.include_path,
            parent=self,
        )

        if new_include is None:
            return

        new_include = normalise_project_path(new_include)

        if not new_include:
            messagebox.showwarning("Invalid Include", "Include path cannot be empty.")
            return

        try:
            self.document.update_entry_include(entry, new_include)
            self.document.repair_dependent_upon_for_entry(entry)
            self.document.reorganise_item_groups()

            self.refresh_entries()
            self.refresh_project_folders()

            self.set_status("Updated Include path.")
        except Exception as exc:
            self.show_error("Edit Include Failed", exc)

    def scan_missing(self) -> None:
        try:
            missing = self.document.scan_missing_files()

            if not missing:
                messagebox.showinfo("Missing Files", "No missing referenced files were found.")
                self.set_status("Missing file scan complete. No problems found.")
                return

            lines = ["Missing file entries:", ""]

            for entry in missing[:80]:
                lines.append("%s: %s" % (entry.item_type, entry.include_path))

            if len(missing) > 80:
                lines.append("...")
                lines.append("%d more missing entries not shown." % (len(missing) - 80))

            messagebox.showwarning("Missing Files", "\n".join(lines))
            self.set_status("Missing file scan complete. Missing entries: %d" % len(missing))
        except Exception as exc:
            self.show_error("Scan Missing Failed", exc)

    def scan_untracked(self) -> None:
        try:
            untracked = self.document.scan_untracked_files()

            if not untracked:
                messagebox.showinfo("Untracked Files", "No untracked supported files were found.")
                self.set_status("Untracked scan complete. No untracked supported files found.")
                return

            assert self.document.project_dir is not None

            lines = ["Untracked supported files:", ""]

            for file_path in untracked[:80]:
                lines.append(disk_path_to_project(self.document.project_dir, file_path))

            if len(untracked) > 80:
                lines.append("...")
                lines.append("%d more untracked files not shown." % (len(untracked) - 80))

            messagebox.showinfo("Untracked Files", "\n".join(lines))
            self.set_status("Untracked scan complete. Untracked supported files: %d" % len(untracked))
        except Exception as exc:
            self.show_error("Scan Untracked Failed", exc)

    def show_error(self, title: str, exc: Exception) -> None:
        details = "".join(traceback.format_exception(type(exc), exc, exc.__traceback__))

        print(details, file=sys.stderr)

        messagebox.showerror(
            title,
            "%s\n\n%s" % (exc, details[-2500:]),
        )

        self.set_status("Error: %s" % exc)


def main() -> int:
    app = VbProjOrganiserApp()
    app.mainloop()
    return 0


if __name__ == "__main__":
    raise SystemExit(main())