Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200006A RID: 106
	Public Partial Class frmProjectManager
		Inherits frmParent

		' Token: 0x06000D28 RID: 3368 RVA: 0x00285B8C File Offset: 0x00284B8C
		Public Sub New()
			AddHandler MyBase.Closing, AddressOf Me.frmProjectManager_Closing
			AddHandler MyBase.Load, AddressOf Me.frmProjectManager_Load
			Me.InitialBrowsePath = "c:\"
			Me.BuildMode = "debug"
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000D29 RID: 3369 RVA: 0x00285BE4 File Offset: 0x00284BE4
		Public Sub New(parentForm As frmMain)
			Me.New()
			Me.MyParentForm = parentForm
		End Sub

		' Token: 0x17000493 RID: 1171
		' (get) Token: 0x06000D2C RID: 3372 RVA: 0x00285D60 File Offset: 0x00284D60
		' (set) Token: 0x06000D2B RID: 3371 RVA: 0x00285C14 File Offset: 0x00284C14
		Friend Overridable Property TreeView As TreeView
			Get
				Return Me._TreeView
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TreeView)
                If Me._TreeView IsNot Nothing Then
                    RemoveHandler Me._TreeView.DoubleClick, AddressOf Me.TreeView_DoubleClick
                    RemoveHandler Me._TreeView.MouseLeave, AddressOf Me.TreeView_MouseLeave
                    RemoveHandler Me._TreeView.MouseMove, AddressOf Me.TreeView_MouseMove
                    RemoveHandler Me._TreeView.DragOver, AddressOf Me.TreeView_DragOver
                    RemoveHandler Me._TreeView.DragDrop, AddressOf Me.TreeView_DragDrop
                    RemoveHandler Me._TreeView.MouseDown, AddressOf Me.TreeView_MouseDown
                End If
                Me._TreeView = value
                If Me._TreeView IsNot Nothing Then
                    AddHandler Me._TreeView.DoubleClick, AddressOf Me.TreeView_DoubleClick
                    AddHandler Me._TreeView.MouseLeave, AddressOf Me.TreeView_MouseLeave
                    AddHandler Me._TreeView.MouseMove, AddressOf Me.TreeView_MouseMove
                    AddHandler Me._TreeView.DragOver, AddressOf Me.TreeView_DragOver
                    AddHandler Me._TreeView.DragDrop, AddressOf Me.TreeView_DragDrop
                    AddHandler Me._TreeView.MouseDown, AddressOf Me.TreeView_MouseDown
                End If
            End Set
        End Property

        ' Token: 0x17000494 RID: 1172
        ' (get) Token: 0x06000D2E RID: 3374 RVA: 0x00285D74 File Offset: 0x00284D74
        ' (set) Token: 0x06000D2D RID: 3373 RVA: 0x00285D88 File Offset: 0x00284D88
        Friend Overridable Property MainMenu1() As MainMenu
            Get
                Return Me._MainMenu1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MainMenu)
                If Me._MainMenu1 IsNot Nothing Then
                End If
                Me._MainMenu1 = value
                If Me._MainMenu1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000495 RID: 1173
        ' (get) Token: 0x06000D2F RID: 3375 RVA: 0x00285DC0 File Offset: 0x00284DC0
        ' (set) Token: 0x06000D30 RID: 3376 RVA: 0x00285DA4 File Offset: 0x00284DA4
        Friend Overridable Property MenuItem1() As MenuItem
            Get
                Return Me._MenuItem1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem1 IsNot Nothing Then
                End If
                Me._MenuItem1 = value
                If Me._MenuItem1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000496 RID: 1174
        ' (get) Token: 0x06000D32 RID: 3378 RVA: 0x00285DD4 File Offset: 0x00284DD4
        ' (set) Token: 0x06000D31 RID: 3377 RVA: 0x00285DE8 File Offset: 0x00284DE8
        Friend Overridable Property MenuItem4() As MenuItem
            Get
                Return Me._MenuItem4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem4 IsNot Nothing Then
                End If
                Me._MenuItem4 = value
                If Me._MenuItem4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000497 RID: 1175
        ' (get) Token: 0x06000D33 RID: 3379 RVA: 0x00285E20 File Offset: 0x00284E20
        ' (set) Token: 0x06000D34 RID: 3380 RVA: 0x00285E04 File Offset: 0x00284E04
        Friend Overridable Property MenuItem7() As MenuItem
            Get
                Return Me._MenuItem7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem7 IsNot Nothing Then
                End If
                Me._MenuItem7 = value
                If Me._MenuItem7 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000498 RID: 1176
        ' (get) Token: 0x06000D36 RID: 3382 RVA: 0x00285E34 File Offset: 0x00284E34
        ' (set) Token: 0x06000D35 RID: 3381 RVA: 0x00285E48 File Offset: 0x00284E48
        Friend Overridable Property tvcmOverrideRoot() As ContextMenu
            Get
                Return Me._tvcmOverrideRoot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmOverrideRoot IsNot Nothing Then
                End If
                Me._tvcmOverrideRoot = value
                If Me._tvcmOverrideRoot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000499 RID: 1177
        ' (get) Token: 0x06000D38 RID: 3384 RVA: 0x00285E64 File Offset: 0x00284E64
        ' (set) Token: 0x06000D37 RID: 3383 RVA: 0x00285E78 File Offset: 0x00284E78
        Friend Overridable Property tvcmOverrideChild() As ContextMenu
            Get
                Return Me._tvcmOverrideChild
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmOverrideChild IsNot Nothing Then
                End If
                Me._tvcmOverrideChild = value
                If Me._tvcmOverrideChild IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700049A RID: 1178
        ' (get) Token: 0x06000D39 RID: 3385 RVA: 0x00285EB0 File Offset: 0x00284EB0
        ' (set) Token: 0x06000D3A RID: 3386 RVA: 0x00285E94 File Offset: 0x00284E94
        Friend Overridable Property tvcmModulesRoot() As ContextMenu
            Get
                Return Me._tvcmModulesRoot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmModulesRoot IsNot Nothing Then
                End If
                Me._tvcmModulesRoot = value
                If Me._tvcmModulesRoot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700049B RID: 1179
        ' (get) Token: 0x06000D3B RID: 3387 RVA: 0x00285EC4 File Offset: 0x00284EC4
        ' (set) Token: 0x06000D3C RID: 3388 RVA: 0x00285ED8 File Offset: 0x00284ED8
        Friend Overridable Property tvcmModulesParent() As ContextMenu
            Get
                Return Me._tvcmModulesParent
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmModulesParent IsNot Nothing Then
                End If
                Me._tvcmModulesParent = value
                If Me._tvcmModulesParent IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700049C RID: 1180
        ' (get) Token: 0x06000D3D RID: 3389 RVA: 0x00285EF4 File Offset: 0x00284EF4
        ' (set) Token: 0x06000D3E RID: 3390 RVA: 0x00285F08 File Offset: 0x00284F08
        Friend Overridable Property tvcmModulesChild() As ContextMenu
            Get
                Return Me._tvcmModulesChild
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmModulesChild IsNot Nothing Then
                End If
                Me._tvcmModulesChild = value
                If Me._tvcmModulesChild IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700049D RID: 1181
        ' (get) Token: 0x06000D3F RID: 3391 RVA: 0x00285F24 File Offset: 0x00284F24
        ' (set) Token: 0x06000D40 RID: 3392 RVA: 0x00285F38 File Offset: 0x00284F38
        Friend Overridable Property tvcmLipsModulesRoot() As ContextMenu
            Get
                Return Me._tvcmLipsModulesRoot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmLipsModulesRoot IsNot Nothing Then
                End If
                Me._tvcmLipsModulesRoot = value
                If Me._tvcmLipsModulesRoot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700049E RID: 1182
        ' (get) Token: 0x06000D42 RID: 3394 RVA: 0x00285F54 File Offset: 0x00284F54
        ' (set) Token: 0x06000D41 RID: 3393 RVA: 0x00285F68 File Offset: 0x00284F68
        Friend Overridable Property tvcmLipsModulesParent() As ContextMenu
            Get
                Return Me._tvcmLipsModulesParent
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmLipsModulesParent IsNot Nothing Then
                End If
                Me._tvcmLipsModulesParent = value
                If Me._tvcmLipsModulesParent IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700049F RID: 1183
        ' (get) Token: 0x06000D44 RID: 3396 RVA: 0x00285F84 File Offset: 0x00284F84
        ' (set) Token: 0x06000D43 RID: 3395 RVA: 0x00285F98 File Offset: 0x00284F98
        Friend Overridable Property tvcmLipsModulesChild() As ContextMenu
            Get
                Return Me._tvcmLipsModulesChild
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmLipsModulesChild IsNot Nothing Then
                End If
                Me._tvcmLipsModulesChild = value
                If Me._tvcmLipsModulesChild IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004A0 RID: 1184
        ' (get) Token: 0x06000D45 RID: 3397 RVA: 0x00286008 File Offset: 0x00285008
        ' (set) Token: 0x06000D46 RID: 3398 RVA: 0x00285FB4 File Offset: 0x00284FB4
        Friend Overridable Property tvcmiOverrideRoot_Add() As MenuItem
            Get
                Return Me._tvcmiOverrideRoot_Add
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiOverrideRoot_Add IsNot Nothing Then
                    RemoveHandler Me._tvcmiOverrideRoot_Add.Click, AddressOf Me.tvcmiOverrideRoot_Add_Click
                End If
                Me._tvcmiOverrideRoot_Add = value
                If Me._tvcmiOverrideRoot_Add IsNot Nothing Then
                    AddHandler Me._tvcmiOverrideRoot_Add.Click, AddressOf Me.tvcmiOverrideRoot_Add_Click
                End If
            End Set
        End Property

        ' Token: 0x170004A1 RID: 1185
        ' (get) Token: 0x06000D48 RID: 3400 RVA: 0x00286070 File Offset: 0x00285070
        ' (set) Token: 0x06000D47 RID: 3399 RVA: 0x0028601C File Offset: 0x0028501C
        Friend Overridable Property tvcmiOverrideChild_Exclude() As MenuItem
            Get
                Return Me._tvcmiOverrideChild_Exclude
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiOverrideChild_Exclude IsNot Nothing Then
                    RemoveHandler Me._tvcmiOverrideChild_Exclude.Click, AddressOf Me.tvcmiOverrideChild_Exclude_Click
                End If
                Me._tvcmiOverrideChild_Exclude = value
                If Me._tvcmiOverrideChild_Exclude IsNot Nothing Then
                    AddHandler Me._tvcmiOverrideChild_Exclude.Click, AddressOf Me.tvcmiOverrideChild_Exclude_Click
                End If
            End Set
        End Property

        ' Token: 0x170004A2 RID: 1186
        ' (get) Token: 0x06000D4A RID: 3402 RVA: 0x002860D8 File Offset: 0x002850D8
        ' (set) Token: 0x06000D49 RID: 3401 RVA: 0x00286084 File Offset: 0x00285084
        Friend Overridable Property tvcmiModulesRoot_Add() As MenuItem
            Get
                Return Me._tvcmiModulesRoot_Add
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiModulesRoot_Add IsNot Nothing Then
                    RemoveHandler Me._tvcmiModulesRoot_Add.Click, AddressOf Me.tvcmiModulesRoot_Add_Click
                End If
                Me._tvcmiModulesRoot_Add = value
                If Me._tvcmiModulesRoot_Add IsNot Nothing Then
                    AddHandler Me._tvcmiModulesRoot_Add.Click, AddressOf Me.tvcmiModulesRoot_Add_Click
                End If
            End Set
        End Property

        ' Token: 0x170004A3 RID: 1187
        ' (get) Token: 0x06000D4B RID: 3403 RVA: 0x00286140 File Offset: 0x00285140
        ' (set) Token: 0x06000D4C RID: 3404 RVA: 0x002860EC File Offset: 0x002850EC
        Friend Overridable Property tvcmiModulesParent_Add() As MenuItem
            Get
                Return Me._tvcmiModulesParent_Add
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiModulesParent_Add IsNot Nothing Then
                    RemoveHandler Me._tvcmiModulesParent_Add.Click, AddressOf Me.tvcmiModulesParent_Add_Click
                End If
                Me._tvcmiModulesParent_Add = value
                If Me._tvcmiModulesParent_Add IsNot Nothing Then
                    AddHandler Me._tvcmiModulesParent_Add.Click, AddressOf Me.tvcmiModulesParent_Add_Click
                End If
            End Set
        End Property

        ' Token: 0x170004A4 RID: 1188
        ' (get) Token: 0x06000D4D RID: 3405 RVA: 0x002861A8 File Offset: 0x002851A8
        ' (set) Token: 0x06000D4E RID: 3406 RVA: 0x00286154 File Offset: 0x00285154
        Friend Overridable Property tvcmiModulesChild_Exclude() As MenuItem
            Get
                Return Me._tvcmiModulesChild_Exclude
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiModulesChild_Exclude IsNot Nothing Then
                    RemoveHandler Me._tvcmiModulesChild_Exclude.Click, AddressOf Me.tvcmiModulesChild_Exclude_Click
                End If
                Me._tvcmiModulesChild_Exclude = value
                If Me._tvcmiModulesChild_Exclude IsNot Nothing Then
                    AddHandler Me._tvcmiModulesChild_Exclude.Click, AddressOf Me.tvcmiModulesChild_Exclude_Click
                End If
            End Set
        End Property

        ' Token: 0x170004A5 RID: 1189
        ' (get) Token: 0x06000D4F RID: 3407 RVA: 0x00286210 File Offset: 0x00285210
        ' (set) Token: 0x06000D50 RID: 3408 RVA: 0x002861BC File Offset: 0x002851BC
        Friend Overridable Property tvcmiLipsModulesRoot_Add() As MenuItem
            Get
                Return Me._tvcmiLipsModulesRoot_Add
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiLipsModulesRoot_Add IsNot Nothing Then
                    RemoveHandler Me._tvcmiLipsModulesRoot_Add.Click, AddressOf Me.tvcmiLipsModulesRoot_Add_Click
                End If
                Me._tvcmiLipsModulesRoot_Add = value
                If Me._tvcmiLipsModulesRoot_Add IsNot Nothing Then
                    AddHandler Me._tvcmiLipsModulesRoot_Add.Click, AddressOf Me.tvcmiLipsModulesRoot_Add_Click
                End If
            End Set
        End Property

        ' Token: 0x170004A6 RID: 1190
        ' (get) Token: 0x06000D51 RID: 3409 RVA: 0x00286224 File Offset: 0x00285224
        ' (set) Token: 0x06000D52 RID: 3410 RVA: 0x00286238 File Offset: 0x00285238
        Friend Overridable Property tvcmiLipsModulesParent_Add() As MenuItem
            Get
                Return Me._tvcmiLipsModulesParent_Add
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiLipsModulesParent_Add IsNot Nothing Then
                    RemoveHandler Me._tvcmiLipsModulesParent_Add.Click, AddressOf Me.tvcmiLipsModulesParent_Add_Click
                End If
                Me._tvcmiLipsModulesParent_Add = value
                If Me._tvcmiLipsModulesParent_Add IsNot Nothing Then
                    AddHandler Me._tvcmiLipsModulesParent_Add.Click, AddressOf Me.tvcmiLipsModulesParent_Add_Click
                End If
            End Set
        End Property

        ' Token: 0x170004A7 RID: 1191
        ' (get) Token: 0x06000D54 RID: 3412 RVA: 0x0028628C File Offset: 0x0028528C
        ' (set) Token: 0x06000D53 RID: 3411 RVA: 0x002862A0 File Offset: 0x002852A0
        Friend Overridable Property tvcmiLipsModulesChild_Exclude() As MenuItem
            Get
                Return Me._tvcmiLipsModulesChild_Exclude
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiLipsModulesChild_Exclude IsNot Nothing Then
                    RemoveHandler Me._tvcmiLipsModulesChild_Exclude.Click, AddressOf Me.tvcmiLipsModulesChild_Exclude_Click
                End If
                Me._tvcmiLipsModulesChild_Exclude = value
                If Me._tvcmiLipsModulesChild_Exclude IsNot Nothing Then
                    AddHandler Me._tvcmiLipsModulesChild_Exclude.Click, AddressOf Me.tvcmiLipsModulesChild_Exclude_Click
                End If
            End Set
        End Property

        ' Token: 0x170004A8 RID: 1192
        ' (get) Token: 0x06000D55 RID: 3413 RVA: 0x00286348 File Offset: 0x00285348
        ' (set) Token: 0x06000D56 RID: 3414 RVA: 0x002862F4 File Offset: 0x002852F4
        Friend Overridable Property miProjectProperties() As MenuItem
            Get
                Return Me._miProjectProperties
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miProjectProperties IsNot Nothing Then
                    RemoveHandler Me._miProjectProperties.Click, AddressOf Me.miProjectProperties_Click
                End If
                Me._miProjectProperties = value
                If Me._miProjectProperties IsNot Nothing Then
                    AddHandler Me._miProjectProperties.Click, AddressOf Me.miProjectProperties_Click
                End If
            End Set
        End Property

        ' Token: 0x170004A9 RID: 1193
        ' (get) Token: 0x06000D57 RID: 3415 RVA: 0x0028635C File Offset: 0x0028535C
        ' (set) Token: 0x06000D58 RID: 3416 RVA: 0x00286370 File Offset: 0x00285370
        Friend Overridable Property miNewPoject() As MenuItem
            Get
                Return Me._miNewPoject
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miNewPoject IsNot Nothing Then
                    RemoveHandler Me._miNewPoject.Click, AddressOf Me.miNewPoject_Click
                End If
                Me._miNewPoject = value
                If Me._miNewPoject IsNot Nothing Then
                    AddHandler Me._miNewPoject.Click, AddressOf Me.miNewPoject_Click
                End If
            End Set
        End Property

        ' Token: 0x170004AA RID: 1194
        ' (get) Token: 0x06000D59 RID: 3417 RVA: 0x002863E0 File Offset: 0x002853E0
        ' (set) Token: 0x06000D5A RID: 3418 RVA: 0x002863C4 File Offset: 0x002853C4
        Friend Overridable Property MenuItem6() As MenuItem
            Get
                Return Me._MenuItem6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem6 IsNot Nothing Then
                End If
                Me._MenuItem6 = value
                If Me._MenuItem6 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004AB RID: 1195
        ' (get) Token: 0x06000D5B RID: 3419 RVA: 0x00286448 File Offset: 0x00285448
        ' (set) Token: 0x06000D5C RID: 3420 RVA: 0x002863F4 File Offset: 0x002853F4
        Friend Overridable Property miDebug() As MenuItem
            Get
                Return Me._miDebug
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miDebug IsNot Nothing Then
                    RemoveHandler Me._miDebug.Click, AddressOf Me.miDebug_Click
                End If
                Me._miDebug = value
                If Me._miDebug IsNot Nothing Then
                    AddHandler Me._miDebug.Click, AddressOf Me.miDebug_Click
                End If
            End Set
        End Property

        ' Token: 0x170004AC RID: 1196
        ' (get) Token: 0x06000D5D RID: 3421 RVA: 0x002864B0 File Offset: 0x002854B0
        ' (set) Token: 0x06000D5E RID: 3422 RVA: 0x0028645C File Offset: 0x0028545C
        Friend Overridable Property miRelease() As MenuItem
            Get
                Return Me._miRelease
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miRelease IsNot Nothing Then
                    RemoveHandler Me._miRelease.Click, AddressOf Me.miRelease_Click
                End If
                Me._miRelease = value
                If Me._miRelease IsNot Nothing Then
                    AddHandler Me._miRelease.Click, AddressOf Me.miRelease_Click
                End If
            End Set
        End Property

        ' Token: 0x170004AD RID: 1197
        ' (get) Token: 0x06000D5F RID: 3423 RVA: 0x002864C4 File Offset: 0x002854C4
        ' (set) Token: 0x06000D60 RID: 3424 RVA: 0x002864D8 File Offset: 0x002854D8
        Friend Overridable Property miOpenProject() As MenuItem
            Get
                Return Me._miOpenProject
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miOpenProject IsNot Nothing Then
                    RemoveHandler Me._miOpenProject.Click, AddressOf Me.miOpenProject_Click
                End If
                Me._miOpenProject = value
                If Me._miOpenProject IsNot Nothing Then
                    AddHandler Me._miOpenProject.Click, AddressOf Me.miOpenProject_Click
                End If
            End Set
        End Property

        ' Token: 0x170004AE RID: 1198
        ' (get) Token: 0x06000D62 RID: 3426 RVA: 0x0028652C File Offset: 0x0028552C
        ' (set) Token: 0x06000D61 RID: 3425 RVA: 0x00286540 File Offset: 0x00285540
        Friend Overridable Property miSaveProject() As MenuItem
            Get
                Return Me._miSaveProject
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miSaveProject IsNot Nothing Then
                    RemoveHandler Me._miSaveProject.Click, AddressOf Me.miSaveProject_Click
                End If
                Me._miSaveProject = value
                If Me._miSaveProject IsNot Nothing Then
                    AddHandler Me._miSaveProject.Click, AddressOf Me.miSaveProject_Click
                End If
            End Set
        End Property

        ' Token: 0x170004AF RID: 1199
        ' (get) Token: 0x06000D63 RID: 3427 RVA: 0x002865E8 File Offset: 0x002855E8
        ' (set) Token: 0x06000D64 RID: 3428 RVA: 0x00286594 File Offset: 0x00285594
        Friend Overridable Property miQuit() As MenuItem
            Get
                Return Me._miQuit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miQuit IsNot Nothing Then
                    RemoveHandler Me._miQuit.Click, AddressOf Me.miQuit_Click
                End If
                Me._miQuit = value
                If Me._miQuit IsNot Nothing Then
                    AddHandler Me._miQuit.Click, AddressOf Me.miQuit_Click
                End If
            End Set
        End Property

        ' Token: 0x170004B0 RID: 1200
        ' (get) Token: 0x06000D65 RID: 3429 RVA: 0x002865FC File Offset: 0x002855FC
        ' (set) Token: 0x06000D66 RID: 3430 RVA: 0x00286610 File Offset: 0x00285610
        Friend Overridable Property miBuildProject() As MenuItem
            Get
                Return Me._miBuildProject
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miBuildProject IsNot Nothing Then
                    RemoveHandler Me._miBuildProject.Click, AddressOf Me.miBuildProject_Click
                End If
                Me._miBuildProject = value
                If Me._miBuildProject IsNot Nothing Then
                    AddHandler Me._miBuildProject.Click, AddressOf Me.miBuildProject_Click
                End If
            End Set
        End Property

        ' Token: 0x170004B1 RID: 1201
        ' (get) Token: 0x06000D67 RID: 3431 RVA: 0x00286680 File Offset: 0x00285680
        ' (set) Token: 0x06000D68 RID: 3432 RVA: 0x00286664 File Offset: 0x00285664
        Friend Overridable Property MenuItem3() As MenuItem
            Get
                Return Me._MenuItem3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem3 IsNot Nothing Then
                End If
                Me._MenuItem3 = value
                If Me._MenuItem3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004B2 RID: 1202
        ' (get) Token: 0x06000D6A RID: 3434 RVA: 0x002866E8 File Offset: 0x002856E8
        ' (set) Token: 0x06000D69 RID: 3433 RVA: 0x00286694 File Offset: 0x00285694
        Friend Overridable Property tvcmiOverrideRoot_RemoveAll() As MenuItem
            Get
                Return Me._tvcmiOverrideRoot_RemoveAll
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiOverrideRoot_RemoveAll IsNot Nothing Then
                    RemoveHandler Me._tvcmiOverrideRoot_RemoveAll.Click, AddressOf Me.tvcmiOverrideRoot_RemoveAll_Click
                End If
                Me._tvcmiOverrideRoot_RemoveAll = value
                If Me._tvcmiOverrideRoot_RemoveAll IsNot Nothing Then
                    AddHandler Me._tvcmiOverrideRoot_RemoveAll.Click, AddressOf Me.tvcmiOverrideRoot_RemoveAll_Click
                End If
            End Set
        End Property

        ' Token: 0x170004B3 RID: 1203
        ' (get) Token: 0x06000D6B RID: 3435 RVA: 0x002866FC File Offset: 0x002856FC
        ' (set) Token: 0x06000D6C RID: 3436 RVA: 0x00286710 File Offset: 0x00285710
        Friend Overridable Property tvcmiModulesParent_RemoveAll() As MenuItem
            Get
                Return Me._tvcmiModulesParent_RemoveAll
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiModulesParent_RemoveAll IsNot Nothing Then
                    RemoveHandler Me._tvcmiModulesParent_RemoveAll.Click, AddressOf Me.tvcmiModulesParent_RemoveAll_Click
                End If
                Me._tvcmiModulesParent_RemoveAll = value
                If Me._tvcmiModulesParent_RemoveAll IsNot Nothing Then
                    AddHandler Me._tvcmiModulesParent_RemoveAll.Click, AddressOf Me.tvcmiModulesParent_RemoveAll_Click
                End If
            End Set
        End Property

        ' Token: 0x170004B4 RID: 1204
        ' (get) Token: 0x06000D6E RID: 3438 RVA: 0x00286764 File Offset: 0x00285764
        ' (set) Token: 0x06000D6D RID: 3437 RVA: 0x00286778 File Offset: 0x00285778
        Friend Overridable Property tvcmiLipsModulesParent_RemoveAll() As MenuItem
            Get
                Return Me._tvcmiLipsModulesParent_RemoveAll
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiLipsModulesParent_RemoveAll IsNot Nothing Then
                    RemoveHandler Me._tvcmiLipsModulesParent_RemoveAll.Click, AddressOf Me.tvcmiLipsModulesParent_RemoveAll_Click
                End If
                Me._tvcmiLipsModulesParent_RemoveAll = value
                If Me._tvcmiLipsModulesParent_RemoveAll IsNot Nothing Then
                    AddHandler Me._tvcmiLipsModulesParent_RemoveAll.Click, AddressOf Me.tvcmiLipsModulesParent_RemoveAll_Click
                End If
            End Set
        End Property

        ' Token: 0x170004B5 RID: 1205
        ' (get) Token: 0x06000D6F RID: 3439 RVA: 0x002867CC File Offset: 0x002857CC
        ' (set) Token: 0x06000D70 RID: 3440 RVA: 0x002867E0 File Offset: 0x002857E0
        Friend Overridable Property MenuItem2() As MenuItem
            Get
                Return Me._MenuItem2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem2 IsNot Nothing Then
                End If
                Me._MenuItem2 = value
                If Me._MenuItem2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004B6 RID: 1206
        ' (get) Token: 0x06000D72 RID: 3442 RVA: 0x00286818 File Offset: 0x00285818
        ' (set) Token: 0x06000D71 RID: 3441 RVA: 0x002867FC File Offset: 0x002857FC
        Friend Overridable Property MenuItem5() As MenuItem
            Get
                Return Me._MenuItem5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem5 IsNot Nothing Then
                End If
                Me._MenuItem5 = value
                If Me._MenuItem5 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004B7 RID: 1207
        ' (get) Token: 0x06000D74 RID: 3444 RVA: 0x0028682C File Offset: 0x0028582C
        ' (set) Token: 0x06000D73 RID: 3443 RVA: 0x00286840 File Offset: 0x00285840
        Friend Overridable Property tvcmiModulesRoot_RemoveAllModules() As MenuItem
            Get
                Return Me._tvcmiModulesRoot_RemoveAllModules
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiModulesRoot_RemoveAllModules IsNot Nothing Then
                    RemoveHandler Me._tvcmiModulesRoot_RemoveAllModules.Click, AddressOf Me.tvcmModulesRoot_RemoveAllModules_Click
                End If
                Me._tvcmiModulesRoot_RemoveAllModules = value
                If Me._tvcmiModulesRoot_RemoveAllModules IsNot Nothing Then
                    AddHandler Me._tvcmiModulesRoot_RemoveAllModules.Click, AddressOf Me.tvcmModulesRoot_RemoveAllModules_Click
                End If
            End Set
        End Property

        ' Token: 0x170004B8 RID: 1208
        ' (get) Token: 0x06000D76 RID: 3446 RVA: 0x002868E8 File Offset: 0x002858E8
        ' (set) Token: 0x06000D75 RID: 3445 RVA: 0x00286894 File Offset: 0x00285894
        Friend Overridable Property tvcmiLipsModulesRoot_RemoveAllModules() As MenuItem
            Get
                Return Me._tvcmiLipsModulesRoot_RemoveAllModules
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiLipsModulesRoot_RemoveAllModules IsNot Nothing Then
                    RemoveHandler Me._tvcmiLipsModulesRoot_RemoveAllModules.Click, AddressOf Me.tvcmLipsModulesRoot_RemoveAllModules_Click
                End If
                Me._tvcmiLipsModulesRoot_RemoveAllModules = value
                If Me._tvcmiLipsModulesRoot_RemoveAllModules IsNot Nothing Then
                    AddHandler Me._tvcmiLipsModulesRoot_RemoveAllModules.Click, AddressOf Me.tvcmLipsModulesRoot_RemoveAllModules_Click
                End If
            End Set
        End Property

        ' Token: 0x170004B9 RID: 1209
        ' (get) Token: 0x06000D77 RID: 3447 RVA: 0x002868FC File Offset: 0x002858FC
        ' (set) Token: 0x06000D78 RID: 3448 RVA: 0x00286910 File Offset: 0x00285910
        Friend Overridable Property tvcmiModulesParent_RemoveSelf() As MenuItem
            Get
                Return Me._tvcmiModulesParent_RemoveSelf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiModulesParent_RemoveSelf IsNot Nothing Then
                    RemoveHandler Me._tvcmiModulesParent_RemoveSelf.Click, AddressOf Me.tvcmiModulesParent_RemoveSelf_Click
                End If
                Me._tvcmiModulesParent_RemoveSelf = value
                If Me._tvcmiModulesParent_RemoveSelf IsNot Nothing Then
                    AddHandler Me._tvcmiModulesParent_RemoveSelf.Click, AddressOf Me.tvcmiModulesParent_RemoveSelf_Click
                End If
            End Set
        End Property

        ' Token: 0x170004BA RID: 1210
        ' (get) Token: 0x06000D79 RID: 3449 RVA: 0x00286964 File Offset: 0x00285964
        ' (set) Token: 0x06000D7A RID: 3450 RVA: 0x00286978 File Offset: 0x00285978
        Friend Overridable Property tvcmiLipsModulesParent_RemoveSelf() As MenuItem
            Get
                Return Me._tvcmiLipsModulesParent_RemoveSelf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiLipsModulesParent_RemoveSelf IsNot Nothing Then
                    RemoveHandler Me._tvcmiLipsModulesParent_RemoveSelf.Click, AddressOf Me.tvcmiLipsModulesParent_RemoveSelf_Click
                End If
                Me._tvcmiLipsModulesParent_RemoveSelf = value
                If Me._tvcmiLipsModulesParent_RemoveSelf IsNot Nothing Then
                    AddHandler Me._tvcmiLipsModulesParent_RemoveSelf.Click, AddressOf Me.tvcmiLipsModulesParent_RemoveSelf_Click
                End If
            End Set
        End Property

        ' Token: 0x170004BB RID: 1211
        ' (get) Token: 0x06000D7B RID: 3451 RVA: 0x002869CC File Offset: 0x002859CC
        ' (set) Token: 0x06000D7C RID: 3452 RVA: 0x002869E0 File Offset: 0x002859E0
        Friend Overridable Property tvcmProjectRoot() As ContextMenu
            Get
                Return Me._tvcmProjectRoot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmProjectRoot IsNot Nothing Then
                End If
                Me._tvcmProjectRoot = value
                If Me._tvcmProjectRoot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004BC RID: 1212
        ' (get) Token: 0x06000D7E RID: 3454 RVA: 0x002869FC File Offset: 0x002859FC
        ' (set) Token: 0x06000D7D RID: 3453 RVA: 0x00286A10 File Offset: 0x00285A10
        Friend Overridable Property tvcmiProperties() As MenuItem
            Get
                Return Me._tvcmiProperties
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiProperties IsNot Nothing Then
                    RemoveHandler Me._tvcmiProperties.Click, AddressOf Me.tvcmiProperties_Click
                End If
                Me._tvcmiProperties = value
                If Me._tvcmiProperties IsNot Nothing Then
                    AddHandler Me._tvcmiProperties.Click, AddressOf Me.tvcmiProperties_Click
                End If
            End Set
        End Property

        ' Token: 0x170004BD RID: 1213
        ' (get) Token: 0x06000D7F RID: 3455 RVA: 0x00286AB8 File Offset: 0x00285AB8
        ' (set) Token: 0x06000D80 RID: 3456 RVA: 0x00286A64 File Offset: 0x00285A64
        Friend Overridable Property miExploreReleaseFolder() As MenuItem
            Get
                Return Me._miExploreReleaseFolder
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miExploreReleaseFolder IsNot Nothing Then
                    RemoveHandler Me._miExploreReleaseFolder.Click, AddressOf Me.miExploreReleaseFolder_Click
                End If
                Me._miExploreReleaseFolder = value
                If Me._miExploreReleaseFolder IsNot Nothing Then
                    AddHandler Me._miExploreReleaseFolder.Click, AddressOf Me.miExploreReleaseFolder_Click
                End If
            End Set
        End Property

        ' Token: 0x170004BE RID: 1214
        ' (get) Token: 0x06000D82 RID: 3458 RVA: 0x00286ACC File Offset: 0x00285ACC
        ' (set) Token: 0x06000D81 RID: 3457 RVA: 0x00286AE0 File Offset: 0x00285AE0
        Friend Overridable Property miExploreDebugFolder() As MenuItem
            Get
                Return Me._miExploreDebugFolder
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miExploreDebugFolder IsNot Nothing Then
                    RemoveHandler Me._miExploreDebugFolder.Click, AddressOf Me.miExploreDebugFolder_Click
                End If
                Me._miExploreDebugFolder = value
                If Me._miExploreDebugFolder IsNot Nothing Then
                    AddHandler Me._miExploreDebugFolder.Click, AddressOf Me.miExploreDebugFolder_Click
                End If
            End Set
        End Property

        ' Token: 0x170004BF RID: 1215
        ' (get) Token: 0x06000D83 RID: 3459 RVA: 0x00286B50 File Offset: 0x00285B50
        ' (set) Token: 0x06000D84 RID: 3460 RVA: 0x00286B34 File Offset: 0x00285B34
        Friend Overridable Property MenuItem10() As MenuItem
            Get
                Return Me._MenuItem10
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem10 IsNot Nothing Then
                End If
                Me._MenuItem10 = value
                If Me._MenuItem10 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004C0 RID: 1216
        ' (get) Token: 0x06000D85 RID: 3461 RVA: 0x00286B64 File Offset: 0x00285B64
        ' (set) Token: 0x06000D86 RID: 3462 RVA: 0x00286B78 File Offset: 0x00285B78
        Friend Overridable Property tvcmiModulesParent_RenameSelf() As MenuItem
            Get
                Return Me._tvcmiModulesParent_RenameSelf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiModulesParent_RenameSelf IsNot Nothing Then
                    RemoveHandler Me._tvcmiModulesParent_RenameSelf.Click, AddressOf Me.tvcmiModulesParent_RenameSelf_Click
                End If
                Me._tvcmiModulesParent_RenameSelf = value
                If Me._tvcmiModulesParent_RenameSelf IsNot Nothing Then
                    AddHandler Me._tvcmiModulesParent_RenameSelf.Click, AddressOf Me.tvcmiModulesParent_RenameSelf_Click
                End If
            End Set
        End Property

        ' Token: 0x170004C1 RID: 1217
        ' (get) Token: 0x06000D88 RID: 3464 RVA: 0x00286BCC File Offset: 0x00285BCC
        ' (set) Token: 0x06000D87 RID: 3463 RVA: 0x00286BE0 File Offset: 0x00285BE0
        Friend Overridable Property tvcmiLipsModulesParent_RenameSelf() As MenuItem
            Get
                Return Me._tvcmiLipsModulesParent_RenameSelf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiLipsModulesParent_RenameSelf IsNot Nothing Then
                    RemoveHandler Me._tvcmiLipsModulesParent_RenameSelf.Click, AddressOf Me.tvcmiLipsModulesParent_RenameSelf_Click
                End If
                Me._tvcmiLipsModulesParent_RenameSelf = value
                If Me._tvcmiLipsModulesParent_RenameSelf IsNot Nothing Then
                    AddHandler Me._tvcmiLipsModulesParent_RenameSelf.Click, AddressOf Me.tvcmiLipsModulesParent_RenameSelf_Click
                End If
            End Set
        End Property

        ' Token: 0x170004C2 RID: 1218
        ' (get) Token: 0x06000D8A RID: 3466 RVA: 0x00286C34 File Offset: 0x00285C34
        ' (set) Token: 0x06000D89 RID: 3465 RVA: 0x00286C48 File Offset: 0x00285C48
        Friend Overridable Property MenuItem9() As MenuItem
            Get
                Return Me._MenuItem9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem9 IsNot Nothing Then
                End If
                Me._MenuItem9 = value
                If Me._MenuItem9 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004C3 RID: 1219
        ' (get) Token: 0x06000D8C RID: 3468 RVA: 0x00286C64 File Offset: 0x00285C64
        ' (set) Token: 0x06000D8B RID: 3467 RVA: 0x00286C78 File Offset: 0x00285C78
        Friend Overridable Property MenuItem8() As MenuItem
            Get
                Return Me._MenuItem8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem8 IsNot Nothing Then
                End If
                Me._MenuItem8 = value
                If Me._MenuItem8 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004C4 RID: 1220
        ' (get) Token: 0x06000D8D RID: 3469 RVA: 0x00286CE8 File Offset: 0x00285CE8
        ' (set) Token: 0x06000D8E RID: 3470 RVA: 0x00286C94 File Offset: 0x00285C94
        Friend Overridable Property miCleanDebugPrjFilesOnly() As MenuItem
            Get
                Return Me._miCleanDebugPrjFilesOnly
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miCleanDebugPrjFilesOnly IsNot Nothing Then
                    RemoveHandler Me._miCleanDebugPrjFilesOnly.Click, AddressOf Me.miCleanDebugPrjFilesOnly_Click
                End If
                Me._miCleanDebugPrjFilesOnly = value
                If Me._miCleanDebugPrjFilesOnly IsNot Nothing Then
                    AddHandler Me._miCleanDebugPrjFilesOnly.Click, AddressOf Me.miCleanDebugPrjFilesOnly_Click
                End If
            End Set
        End Property

        ' Token: 0x170004C5 RID: 1221
        ' (get) Token: 0x06000D90 RID: 3472 RVA: 0x00286CFC File Offset: 0x00285CFC
        ' (set) Token: 0x06000D8F RID: 3471 RVA: 0x00286D10 File Offset: 0x00285D10
        Friend Overridable Property miCleanReleasePrjFilesOnly() As MenuItem
            Get
                Return Me._miCleanReleasePrjFilesOnly
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._miCleanReleasePrjFilesOnly IsNot Nothing Then
                    RemoveHandler Me._miCleanReleasePrjFilesOnly.Click, AddressOf Me.miCleanReleasePrjFilesOnly_Click
                End If
                Me._miCleanReleasePrjFilesOnly = value
                If Me._miCleanReleasePrjFilesOnly IsNot Nothing Then
                    AddHandler Me._miCleanReleasePrjFilesOnly.Click, AddressOf Me.miCleanReleasePrjFilesOnly_Click
                End If
            End Set
        End Property

        ' Token: 0x170004C6 RID: 1222
        ' (get) Token: 0x06000D91 RID: 3473 RVA: 0x00286D80 File Offset: 0x00285D80
        ' (set) Token: 0x06000D92 RID: 3474 RVA: 0x00286D64 File Offset: 0x00285D64
        Friend Overridable Property MenuItem11() As MenuItem
            Get
                Return Me._MenuItem11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem11 IsNot Nothing Then
                End If
                Me._MenuItem11 = value
                If Me._MenuItem11 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004C7 RID: 1223
        ' (get) Token: 0x06000D94 RID: 3476 RVA: 0x00286DB0 File Offset: 0x00285DB0
        ' (set) Token: 0x06000D93 RID: 3475 RVA: 0x00286D94 File Offset: 0x00285D94
        Friend Overridable Property MenuItem12() As MenuItem
            Get
                Return Me._MenuItem12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem12 IsNot Nothing Then
                End If
                Me._MenuItem12 = value
                If Me._MenuItem12 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004C8 RID: 1224
        ' (get) Token: 0x06000D96 RID: 3478 RVA: 0x00286DE0 File Offset: 0x00285DE0
        ' (set) Token: 0x06000D95 RID: 3477 RVA: 0x00286DC4 File Offset: 0x00285DC4
        Friend Overridable Property tvcmStreamWavesRoot() As ContextMenu
            Get
                Return Me._tvcmStreamWavesRoot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmStreamWavesRoot IsNot Nothing Then
                End If
                Me._tvcmStreamWavesRoot = value
                If Me._tvcmStreamWavesRoot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004C9 RID: 1225
        ' (get) Token: 0x06000D98 RID: 3480 RVA: 0x00286DF4 File Offset: 0x00285DF4
        ' (set) Token: 0x06000D97 RID: 3479 RVA: 0x00286E08 File Offset: 0x00285E08
        Friend Overridable Property tvcmStreamWavesModulesParent() As ContextMenu
            Get
                Return Me._tvcmStreamWavesModulesParent
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmStreamWavesModulesParent IsNot Nothing Then
                End If
                Me._tvcmStreamWavesModulesParent = value
                If Me._tvcmStreamWavesModulesParent IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004CA RID: 1226
        ' (get) Token: 0x06000D99 RID: 3481 RVA: 0x00286E24 File Offset: 0x00285E24
        ' (set) Token: 0x06000D9A RID: 3482 RVA: 0x00286E38 File Offset: 0x00285E38
        Friend Overridable Property tvcmStreamWavesModulesChild() As ContextMenu
            Get
                Return Me._tvcmStreamWavesModulesChild
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmStreamWavesModulesChild IsNot Nothing Then
                End If
                Me._tvcmStreamWavesModulesChild = value
                If Me._tvcmStreamWavesModulesChild IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004CB RID: 1227
        ' (get) Token: 0x06000D9C RID: 3484 RVA: 0x00286E70 File Offset: 0x00285E70
        ' (set) Token: 0x06000D9B RID: 3483 RVA: 0x00286E54 File Offset: 0x00285E54
        Friend Overridable Property tvcmStreamWavesFileChild() As ContextMenu
            Get
                Return Me._tvcmStreamWavesFileChild
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._tvcmStreamWavesFileChild IsNot Nothing Then
                End If
                Me._tvcmStreamWavesFileChild = value
                If Me._tvcmStreamWavesFileChild IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004CC RID: 1228
        ' (get) Token: 0x06000D9E RID: 3486 RVA: 0x00286E84 File Offset: 0x00285E84
        ' (set) Token: 0x06000D9D RID: 3485 RVA: 0x00286E98 File Offset: 0x00285E98
        Friend Overridable Property tvcmiStreamWavesRoot_AddFile() As MenuItem
            Get
                Return Me._tvcmiStreamWavesRoot_AddFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesRoot_AddFile IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesRoot_AddFile.Click, AddressOf Me.tvcmiStreamWavesRoot_AddFile_Click
                End If
                Me._tvcmiStreamWavesRoot_AddFile = value
                If Me._tvcmiStreamWavesRoot_AddFile IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesRoot_AddFile.Click, AddressOf Me.tvcmiStreamWavesRoot_AddFile_Click
                End If
            End Set
        End Property

        ' Token: 0x170004CD RID: 1229
        ' (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00286F40 File Offset: 0x00285F40
        ' (set) Token: 0x06000D9F RID: 3487 RVA: 0x00286EEC File Offset: 0x00285EEC
        Friend Overridable Property tvcmiStreamWavesRoot_AddModule() As MenuItem
            Get
                Return Me._tvcmiStreamWavesRoot_AddModule
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesRoot_AddModule IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesRoot_AddModule.Click, AddressOf Me.tvcmiStreamWavesRoot_AddModule_Click
                End If
                Me._tvcmiStreamWavesRoot_AddModule = value
                If Me._tvcmiStreamWavesRoot_AddModule IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesRoot_AddModule.Click, AddressOf Me.tvcmiStreamWavesRoot_AddModule_Click
                End If
            End Set
        End Property

        ' Token: 0x170004CE RID: 1230
        ' (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00286F70 File Offset: 0x00285F70
        ' (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00286F54 File Offset: 0x00285F54
        Friend Overridable Property MenuItem13() As MenuItem
            Get
                Return Me._MenuItem13
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem13 IsNot Nothing Then
                End If
                Me._MenuItem13 = value
                If Me._MenuItem13 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004CF RID: 1231
        ' (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00286FD8 File Offset: 0x00285FD8
        ' (set) Token: 0x06000DA4 RID: 3492 RVA: 0x00286F84 File Offset: 0x00285F84
        Friend Overridable Property tvcmiStreamWavesRoot_RemoveAllFiles() As MenuItem
            Get
                Return Me._tvcmiStreamWavesRoot_RemoveAllFiles
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesRoot_RemoveAllFiles IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesRoot_RemoveAllFiles.Click, AddressOf Me.tvcmiStreamWavesRoot_RemoveAllFiles_Click
                End If
                Me._tvcmiStreamWavesRoot_RemoveAllFiles = value
                If Me._tvcmiStreamWavesRoot_RemoveAllFiles IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesRoot_RemoveAllFiles.Click, AddressOf Me.tvcmiStreamWavesRoot_RemoveAllFiles_Click
                End If
            End Set
        End Property

        ' Token: 0x170004D0 RID: 1232
        ' (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00287040 File Offset: 0x00286040
        ' (set) Token: 0x06000DA6 RID: 3494 RVA: 0x00286FEC File Offset: 0x00285FEC
        Friend Overridable Property tvcmiStreamWavesRoot_RemoveAllModules() As MenuItem
            Get
                Return Me._tvcmiStreamWavesRoot_RemoveAllModules
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesRoot_RemoveAllModules IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesRoot_RemoveAllModules.Click, AddressOf Me.tvcmiStreamWavesRoot_RemoveAllModules_Click
                End If
                Me._tvcmiStreamWavesRoot_RemoveAllModules = value
                If Me._tvcmiStreamWavesRoot_RemoveAllModules IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesRoot_RemoveAllModules.Click, AddressOf Me.tvcmiStreamWavesRoot_RemoveAllModules_Click
                End If
            End Set
        End Property

        ' Token: 0x170004D1 RID: 1233
        ' (get) Token: 0x06000DA8 RID: 3496 RVA: 0x002870A8 File Offset: 0x002860A8
        ' (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00287054 File Offset: 0x00286054
        Friend Overridable Property tvcmiStreamWavesRoot_RemoveEverything() As MenuItem
            Get
                Return Me._tvcmiStreamWavesRoot_RemoveEverything
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesRoot_RemoveEverything IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesRoot_RemoveEverything.Click, AddressOf Me.tvcmiStreamWavesRoot_RemoveEverything_Click
                End If
                Me._tvcmiStreamWavesRoot_RemoveEverything = value
                If Me._tvcmiStreamWavesRoot_RemoveEverything IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesRoot_RemoveEverything.Click, AddressOf Me.tvcmiStreamWavesRoot_RemoveEverything_Click
                End If
            End Set
        End Property

        ' Token: 0x170004D2 RID: 1234
        ' (get) Token: 0x06000DAA RID: 3498 RVA: 0x002870BC File Offset: 0x002860BC
        ' (set) Token: 0x06000DA9 RID: 3497 RVA: 0x002870D0 File Offset: 0x002860D0
        Friend Overridable Property tvcmiStreamWavesModuleParent_AddFiles() As MenuItem
            Get
                Return Me._tvcmiStreamWavesModuleParent_AddFiles
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesModuleParent_AddFiles IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesModuleParent_AddFiles.Click, AddressOf Me.tvcmiStreamWavesModuleParent_AddFiles_Click
                End If
                Me._tvcmiStreamWavesModuleParent_AddFiles = value
                If Me._tvcmiStreamWavesModuleParent_AddFiles IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesModuleParent_AddFiles.Click, AddressOf Me.tvcmiStreamWavesModuleParent_AddFiles_Click
                End If
            End Set
        End Property

        ' Token: 0x170004D3 RID: 1235
        ' (get) Token: 0x06000DAB RID: 3499 RVA: 0x00287178 File Offset: 0x00286178
        ' (set) Token: 0x06000DAC RID: 3500 RVA: 0x00287124 File Offset: 0x00286124
        Friend Overridable Property tvcmiStreamWavesModuleParent_ExcludeAllFiles() As MenuItem
            Get
                Return Me._tvcmiStreamWavesModuleParent_ExcludeAllFiles
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesModuleParent_ExcludeAllFiles IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesModuleParent_ExcludeAllFiles.Click, AddressOf Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click
                End If
                Me._tvcmiStreamWavesModuleParent_ExcludeAllFiles = value
                If Me._tvcmiStreamWavesModuleParent_ExcludeAllFiles IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesModuleParent_ExcludeAllFiles.Click, AddressOf Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click
                End If
            End Set
        End Property

        ' Token: 0x170004D4 RID: 1236
        ' (get) Token: 0x06000DAE RID: 3502 RVA: 0x0028718C File Offset: 0x0028618C
        ' (set) Token: 0x06000DAD RID: 3501 RVA: 0x002871A0 File Offset: 0x002861A0
        Friend Overridable Property MenuItem14() As MenuItem
            Get
                Return Me._MenuItem14
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem14 IsNot Nothing Then
                End If
                Me._MenuItem14 = value
                If Me._MenuItem14 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004D5 RID: 1237
        ' (get) Token: 0x06000DB0 RID: 3504 RVA: 0x002871BC File Offset: 0x002861BC
        ' (set) Token: 0x06000DAF RID: 3503 RVA: 0x002871D0 File Offset: 0x002861D0
        Friend Overridable Property tvcmiStreamWavesModuleParent_RenameSelf() As MenuItem
            Get
                Return Me._tvcmiStreamWavesModuleParent_RenameSelf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesModuleParent_RenameSelf IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesModuleParent_RenameSelf.Click, AddressOf Me.tvcmiStreamWavesModuleParent_RenameSelf_Click
                End If
                Me._tvcmiStreamWavesModuleParent_RenameSelf = value
                If Me._tvcmiStreamWavesModuleParent_RenameSelf IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesModuleParent_RenameSelf.Click, AddressOf Me.tvcmiStreamWavesModuleParent_RenameSelf_Click
                End If
            End Set
        End Property

        ' Token: 0x170004D6 RID: 1238
        ' (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00287240 File Offset: 0x00286240
        ' (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00287224 File Offset: 0x00286224
        Friend Overridable Property MenuItem15() As MenuItem
            Get
                Return Me._MenuItem15
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem15 IsNot Nothing Then
                End If
                Me._MenuItem15 = value
                If Me._MenuItem15 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004D7 RID: 1239
        ' (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00287254 File Offset: 0x00286254
        ' (set) Token: 0x06000DB3 RID: 3507 RVA: 0x00287268 File Offset: 0x00286268
        Friend Overridable Property tvcmiStreamWavesModulesParent_RemoveSelf() As MenuItem
            Get
                Return Me._tvcmiStreamWavesModulesParent_RemoveSelf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesModulesParent_RemoveSelf IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesModulesParent_RemoveSelf.Click, AddressOf Me.tvcmiStreamWavesModulesParent_RemoveSelf_Click
                End If
                Me._tvcmiStreamWavesModulesParent_RemoveSelf = value
                If Me._tvcmiStreamWavesModulesParent_RemoveSelf IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesModulesParent_RemoveSelf.Click, AddressOf Me.tvcmiStreamWavesModulesParent_RemoveSelf_Click
                End If
            End Set
        End Property

        ' Token: 0x170004D8 RID: 1240
        ' (get) Token: 0x06000DB6 RID: 3510 RVA: 0x002872BC File Offset: 0x002862BC
        ' (set) Token: 0x06000DB5 RID: 3509 RVA: 0x002872D0 File Offset: 0x002862D0
        Friend Overridable Property tvcmiStreamWavesModulesChild_ExcludeSelf() As MenuItem
            Get
                Return Me._tvcmiStreamWavesModulesChild_ExcludeSelf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesModulesChild_ExcludeSelf IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesModulesChild_ExcludeSelf.Click, AddressOf Me.tvcmiStreamWavesModulesChild_ExcludeSelf_Click
                End If
                Me._tvcmiStreamWavesModulesChild_ExcludeSelf = value
                If Me._tvcmiStreamWavesModulesChild_ExcludeSelf IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesModulesChild_ExcludeSelf.Click, AddressOf Me.tvcmiStreamWavesModulesChild_ExcludeSelf_Click
                End If
            End Set
        End Property

        ' Token: 0x170004D9 RID: 1241
        ' (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00287378 File Offset: 0x00286378
        ' (set) Token: 0x06000DB8 RID: 3512 RVA: 0x00287324 File Offset: 0x00286324
        Friend Overridable Property tvcmiStreamWavesFileChild_ExcludeSelf() As MenuItem
            Get
                Return Me._tvcmiStreamWavesFileChild_ExcludeSelf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiStreamWavesFileChild_ExcludeSelf IsNot Nothing Then
                    RemoveHandler Me._tvcmiStreamWavesFileChild_ExcludeSelf.Click, AddressOf Me.tvcmiStreamWavesFileChild_ExcludeSelf_Click
                End If
                Me._tvcmiStreamWavesFileChild_ExcludeSelf = value
                If Me._tvcmiStreamWavesFileChild_ExcludeSelf IsNot Nothing Then
                    AddHandler Me._tvcmiStreamWavesFileChild_ExcludeSelf.Click, AddressOf Me.tvcmiStreamWavesFileChild_ExcludeSelf_Click
                End If
            End Set
        End Property

        ' Token: 0x170004DA RID: 1242
        ' (get) Token: 0x06000DBA RID: 3514 RVA: 0x002873A8 File Offset: 0x002863A8
        ' (set) Token: 0x06000DB9 RID: 3513 RVA: 0x0028738C File Offset: 0x0028638C
        Friend Overridable Property ilistTree() As ImageList
            Get
                Return Me._ilistTree
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ImageList)
                If Me._ilistTree IsNot Nothing Then
                End If
                Me._ilistTree = value
                If Me._ilistTree IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004DB RID: 1243
        ' (get) Token: 0x06000DBB RID: 3515 RVA: 0x002873D8 File Offset: 0x002863D8
        ' (set) Token: 0x06000DBC RID: 3516 RVA: 0x002873BC File Offset: 0x002863BC
        Friend Overridable Property lblStatus() As Label
            Get
                Return Me._lblStatus
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._lblStatus IsNot Nothing Then
                End If
                Me._lblStatus = value
                If Me._lblStatus IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004DC RID: 1244
        ' (get) Token: 0x06000DBD RID: 3517 RVA: 0x00287440 File Offset: 0x00286440
        ' (set) Token: 0x06000DBE RID: 3518 RVA: 0x002873EC File Offset: 0x002863EC
        Friend Overridable Property tvcmiModulesParent_Properties() As MenuItem
            Get
                Return Me._tvcmiModulesParent_Properties
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._tvcmiModulesParent_Properties IsNot Nothing Then
                    RemoveHandler Me._tvcmiModulesParent_Properties.Click, AddressOf Me.tvcmiModulesParent_Properties_Click
                End If
                Me._tvcmiModulesParent_Properties = value
                If Me._tvcmiModulesParent_Properties IsNot Nothing Then
                    AddHandler Me._tvcmiModulesParent_Properties.Click, AddressOf Me.tvcmiModulesParent_Properties_Click
                End If
            End Set
        End Property

        ' Token: 0x170004DD RID: 1245
        ' (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00287470 File Offset: 0x00286470
        ' (set) Token: 0x06000DBF RID: 3519 RVA: 0x00287454 File Offset: 0x00286454
        Friend Overridable Property MenuItem16() As MenuItem
            Get
                Return Me._MenuItem16
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._MenuItem16 IsNot Nothing Then
                End If
                Me._MenuItem16 = value
                If Me._MenuItem16 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x06000DC2 RID: 3522 RVA: 0x002884BC File Offset: 0x002874BC
        Private Sub frmProjectManager_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.AskIfSaveProject()
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x06000DC3 RID: 3523 RVA: 0x002884D8 File Offset: 0x002874D8
        Private Sub TreeView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim point As Point = New Point(e.X, e.Y)
            Dim point2 As Point = point
            Me.LastClickedTVNode = Me.TreeView.GetNodeAt(point2)
            Me.TreeView.SelectedNode = Me.LastClickedTVNode
            If e.Button = MouseButtons.Right Then
                Dim tag As Object = Me.LastClickedTVNode.Tag
                If ObjectType.ObjTst(tag, "projectroot", False) = 0 Then
                    Me.tvcmProjectRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "overrideroot", False) = 0 Then
                    Me.tvcmiOverrideRoot_RemoveAll.Enabled = Me.Project.OverrideFiles.Count > 0
                    Me.tvcmOverrideRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "overridechild", False) = 0 Then
                    Me.tvcmOverrideChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "moduleroot", False) = 0 Then
                    Me.tvcmiModulesRoot_RemoveAllModules.Enabled = Me.Project.Modules.Count > 0
                    Me.tvcmModulesRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "moduleparent", False) = 0 Then
                    Me.tvcmiModulesParent_RemoveAll.Enabled = Me.Project.GetModuleFiles(Me.LastClickedTVNode.Text).Count > 0
                    Me.tvcmModulesParent.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "modulechild", False) = 0 Then
                    Me.tvcmModulesChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "lipsmoduleroot", False) = 0 Then
                    Me.tvcmiLipsModulesRoot_RemoveAllModules.Enabled = Me.Project.LipsModules.Count > 0
                    Me.tvcmLipsModulesRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "lipsmoduleparent", False) = 0 Then
                    Me.tvcmiLipsModulesParent_RemoveAll.Enabled = Me.Project.GetLipsModuleFiles(Me.LastClickedTVNode.Text).Count > 0
                    Me.tvcmLipsModulesParent.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "lipsmodulechild", False) = 0 Then
                    Me.tvcmLipsModulesChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "streamwavesroot", False) = 0 Then
                    Me.tvcmiStreamWavesRoot_RemoveAllFiles.Enabled = Me.Project.StreamWavesFiles.Count > 0
                    Me.tvcmiStreamWavesRoot_RemoveAllModules.Enabled = Me.Project.StreamWavesModules.Count > 0
                    Me.tvcmiStreamWavesRoot_RemoveEverything.Enabled = Me.Project.StreamWavesFiles.Count > 0 OrElse Me.Project.StreamWavesModules.Count > 0
                    Me.tvcmStreamWavesRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "streamwavesmoduleparent", False) = 0 Then
                    Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles.Enabled = Me.Project.GetStreamWavesModuleFiles(Me.LastClickedTVNode.Text).Count > 0
                    Me.tvcmStreamWavesModulesParent.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "streamwavesmodulechild", False) = 0 Then
                    Me.tvcmStreamWavesModulesChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "streamwavesfilechild", False) = 0 Then
                    Me.tvcmStreamWavesFileChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                End If
            End If
        End Sub

        ' Token: 0x06000DC4 RID: 3524 RVA: 0x00288928 File Offset: 0x00287928
        Private Sub TreeView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim projectFileItemTreeNode As ProjectFileItemTreeNode = CType(Me.TreeView.SelectedNode, ProjectFileItemTreeNode)
            If ObjectType.ObjTst(projectFileItemTreeNode.Tag, "overridechild", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "modulechild", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "streamwavesfilechild", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "streamwavesmodulechild", False) = 0 Then
                Dim text As String = Path.GetExtension(projectFileItemTreeNode.FilePath).ToLower()
                If StringType.StrCmp(text, ".nss", False) = 0 OrElse StringType.StrCmp(text, ".txt", False) = 0 Then
                    Dim settings As Options = UserSettings.GetSettings()
                    If settings.bProjMgrUseExternTxtEditor Then
                        'New Process() With { .StartInfo = { .FileName = settings.ProjMgrTxtEditorPath + " ", .Arguments = projectFileItemTreeNode.FilePath } }.Start()
                        Dim process As Process = New Process()
                        process.StartInfo.FileName = settings.ProjMgrTxtEditorPath
                        process.StartInfo.Arguments = """" & projectFileItemTreeNode.FilePath & """"
                        process.Start()
                    Else
                        Dim fileStream As FileStream = New FileStream(projectFileItemTreeNode.FilePath, FileMode.Open)
                        Dim frmTextEditor As frmTextEditor = New frmTextEditor(projectFileItemTreeNode.Filename, False, "")
                        Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
                        Dim array As Byte() = New Byte(CInt((fileStream.Length - 1L)) + 1 - 1) {}
                        fileStream.Read(array, 0, CInt(fileStream.Length))
                        frmTextEditor.tbGeneric.Text = asciiencoding.GetString(array)
                        frmTextEditor.tbGeneric.SelectionLength = 0
                        fileStream.Close()
                        frmTextEditor.Show()
                    End If
                ElseIf StringType.StrCmp(text, ".utc", False) = 0 OrElse StringType.StrCmp(text, ".utd", False) = 0 OrElse StringType.StrCmp(text, ".uti", False) = 0 OrElse StringType.StrCmp(text, ".utm", False) = 0 OrElse StringType.StrCmp(text, ".utp", False) = 0 OrElse StringType.StrCmp(text, ".utt", False) = 0 Then
                    Me.MyParentForm.OpenGFFFileInEditor(projectFileItemTreeNode.FilePath, -1)
                ElseIf StringType.StrCmp(text, ".dlg", False) = 0 Then
                    Dim settings2 As Options = UserSettings.GetSettings()
                    If settings2.bProjMgrUseExternDLGEditor Then
                        '#New Process() With { .StartInfo = { .FileName = settings2.ProjMgrDLGEditorPath + " ", .Arguments = projectFileItemTreeNode.FilePath } }.Start()
                        Dim process2 As Process = New Process()
                        process2.StartInfo.FileName = settings2.ProjMgrDLGEditorPath
                        process2.StartInfo.Arguments = """" & projectFileItemTreeNode.FilePath & """"
                        process2.Start()
                    Else
                        Dim fileStream2 As FileStream = New FileStream(projectFileItemTreeNode.FilePath, FileMode.Open)
                        Dim frmDialogEditor As frmDialogEditor = New frmDialogEditor(fileStream2, Me.KotorVersionIndex)
                        frmDialogEditor.Show()
                    End If
                End If
            End If
        End Sub

        ' Token: 0x06000DC5 RID: 3525 RVA: 0x00288BA0 File Offset: 0x00287BA0
        Private Sub TreeView_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            Dim treeView As TreeView = Me.TreeView
            Dim treeView2 As Control = Me.TreeView
            Dim point As Point = New Point(e.X, e.Y)
            Dim projectFileItemTreeNode As ProjectFileItemTreeNode = CType(treeView.GetNodeAt(treeView2.PointToClient(point)), ProjectFileItemTreeNode)
            Dim fullPath As String = projectFileItemTreeNode.FullPath
            Dim array As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Dim tag As Object = projectFileItemTreeNode.Tag
            If ObjectType.ObjTst(tag, "moduleparent", False) = 0 Then
                Dim hashtable As Hashtable = CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
                Dim num As Integer = 0
                Dim num2 As Integer = array.Length - 1
                For i As Integer = num To num2
                    If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                        Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                    ElseIf Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.AddModuleFile(projectFileItemTreeNode.Text, array(i))
                        Me.ProjectMgr.SaveProject()
                    End If
                Next
            ElseIf ObjectType.ObjTst(tag, "lipsmoduleparent", False) = 0 Then
                Dim hashtable As Hashtable = CType(Me.Project.LipsModules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
                Dim num3 As Integer = 0
                Dim num4 As Integer = array.Length - 1
                For i As Integer = num3 To num4
                    If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                        Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                    ElseIf Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.AddLipsModuleFile(projectFileItemTreeNode.Text, array(i))
                        Me.ProjectMgr.SaveProject()
                    End If
                Next
            ElseIf ObjectType.ObjTst(tag, "streamwavesmoduleparent", False) = 0 Then
                Dim hashtable As Hashtable = CType(Me.Project.StreamWavesModules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
                Dim num5 As Integer = 0
                Dim num6 As Integer = array.Length - 1
                For i As Integer = num5 To num6
                    If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                        Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                    ElseIf Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.AddStreamWavesModuleFile(projectFileItemTreeNode.Text, array(i))
                        Me.ProjectMgr.SaveProject()
                    End If
                Next
            ElseIf ObjectType.ObjTst(tag, "overrideroot", False) = 0 Then
                Dim hashtable As Hashtable = Me.Project.OverrideFilesHashTable
                Dim num7 As Integer = 0
                Dim num8 As Integer = array.Length - 1
                For i As Integer = num7 To num8
                    If Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.OverrideFiles.Add(array(i))
                    End If
                Next
                Me.ProjectMgr.SaveProject()
            ElseIf ObjectType.ObjTst(tag, "streamwavesroot", False) = 0 Then
                Dim hashtable As Hashtable = Me.Project.StreamWavesFilesHashTable
                Dim num9 As Integer = 0
                Dim num10 As Integer = array.Length - 1
                For i As Integer = num9 To num10
                    If Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.StreamWavesFiles.Add(array(i))
                    End If
                Next
                Me.ProjectMgr.SaveProject()
            End If
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DC6 RID: 3526 RVA: 0x00288F1C File Offset: 0x00287F1C
        Private Sub TreeView_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim treeView As TreeView = Me.TreeView
                Dim treeView2 As Control = Me.TreeView
                Dim point As Point = New Point(e.X, e.Y)
                Dim projectFileItemTreeNode As ProjectFileItemTreeNode = CType(treeView.GetNodeAt(treeView2.PointToClient(point)), ProjectFileItemTreeNode)
                If projectFileItemTreeNode IsNot Nothing Then
                    If ObjectType.ObjTst(projectFileItemTreeNode.Tag, "overrideroot", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "moduleparent", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "lipsmoduleparent", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "streamwavesroot", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "streamwavesmoduleparent", False) = 0 Then
                        e.Effect = DragDropEffects.All
                        Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Match: ", projectFileItemTreeNode.Tag), " "), DateAndTime.Now))
                    Else
                        e.Effect = DragDropEffects.None
                        Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("No match: ", projectFileItemTreeNode.Tag), " "), DateAndTime.Now))
                    End If
                End If
            End If
        End Sub

        ' Token: 0x06000DC7 RID: 3527 RVA: 0x00289048 File Offset: 0x00288048
        Private Sub tvcmiProperties_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.EditProjectProperties()
        End Sub

        ' Token: 0x06000DC8 RID: 3528 RVA: 0x00289050 File Offset: 0x00288050
        Private Sub tvcmiOverrideRoot_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Override folder", "all", True, True))
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim overrideFilesHashTable As Hashtable = Me.Project.OverrideFilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Not overrideFilesHashTable.ContainsKey(array(i)) Then
                    Me.Project.OverrideFiles.Add(array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DC9 RID: 3529 RVA: 0x0028911C File Offset: 0x0028811C
        Private Sub tvcmiOverrideChild_Exclude_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveOverrideFile(filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DCA RID: 3530 RVA: 0x00289180 File Offset: 0x00288180
        Private Sub tvcmiOverrideRoot_RemoveAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to exclude all of the files from Override?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllOverrideFiles()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DCB RID: 3531 RVA: 0x002891B8 File Offset: 0x002881B8
        Private Sub tvcmiModulesRoot_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter name for new module"
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                Me.Project.AddModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()))
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
                Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
            End If
        End Sub

        ' Token: 0x06000DCC RID: 3532 RVA: 0x0028923C File Offset: 0x0028823C
        Private Sub tvcmModulesRoot_RemoveAllModules_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to remove all of the Packages from the Project?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.ProjectMgr.SaveProject()
                Me.Project.RemoveAllModules()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DCD RID: 3533 RVA: 0x00289274 File Offset: 0x00288274
        Private Sub tvcmiModulesParent_RemoveSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to remove the module '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveModule(Me.LastClickedTVNode.Text.Trim())
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DCE RID: 3534 RVA: 0x002892FC File Offset: 0x002882FC
        Private Sub tvcmiModulesParent_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", True, True))
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim filesHashTable As Hashtable = CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                    Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                ElseIf Not filesHashTable.ContainsKey(array(i)) Then
                    Me.Project.AddModuleFile(Me.LastClickedTVNode.Text, array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DCF RID: 3535 RVA: 0x00289424 File Offset: 0x00288424
        Private Sub tvcmiModulesParent_RenameSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter new name for package"
            frmPromptForString.tbValue.Text = Me.LastClickedTVNode.Text
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).ModuleName = frmPromptForString.tbValue.Text.Trim()
                Me.LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim()
            End If
        End Sub

        ' Token: 0x06000DD0 RID: 3536 RVA: 0x002894C4 File Offset: 0x002884C4
        Private Sub tvcmiModulesParent_RemoveAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to exclude all of the files from '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton3, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllModuleFiles(Me.LastClickedTVNode.Text)
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DD1 RID: 3537 RVA: 0x00289548 File Offset: 0x00288548
        Private Sub tvcmiModulesParent_Properties_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmPackageTypeSelector As frmPackageTypeSelector = New frmPackageTypeSelector(CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).PackageType)
            If frmPackageTypeSelector.ShowDialog(Me) = DialogResult.OK Then
                CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).PackageType = frmPackageTypeSelector.PackageType
            End If
        End Sub

        ' Token: 0x06000DD2 RID: 3538 RVA: 0x002895CC File Offset: 0x002885CC
        Private Sub tvcmiModulesChild_Exclude_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim text As String = Me.LastClickedTVNode.Parent.Text
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveModuleFile(text, filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DD3 RID: 3539 RVA: 0x00289640 File Offset: 0x00288640
        Private Sub tvcmiLipsModulesRoot_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter name for new module"
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                Me.Project.AddLipsModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()))
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
                Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
            End If
        End Sub

        ' Token: 0x06000DD4 RID: 3540 RVA: 0x002896C4 File Offset: 0x002886C4
        Private Sub tvcmLipsModulesRoot_RemoveAllModules_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to remove all of the Modules from the Project?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllLipsModules()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DD5 RID: 3541 RVA: 0x002896FC File Offset: 0x002886FC
        Private Sub tvcmiLipsModulesParent_RemoveSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to remove the module '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveLipsModule(Me.LastClickedTVNode.Text.Trim())
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DD6 RID: 3542 RVA: 0x00289784 File Offset: 0x00288784
        Private Sub tvcmiLipsModulesParent_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", True, True))
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim filesHashTable As Hashtable = CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                    Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                ElseIf Not filesHashTable.ContainsKey(array(i)) Then
                    Me.Project.AddLipsModuleFile(Me.LastClickedTVNode.Text, array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DD7 RID: 3543 RVA: 0x002898AC File Offset: 0x002888AC
        Private Sub tvcmiLipsModulesParent_RenameSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter new name for module"
            frmPromptForString.tbValue.Text = Me.LastClickedTVNode.Text
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                CType(Me.Project.LipsModules(Me.Project.GetLipsModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).ModuleName = frmPromptForString.tbValue.Text.Trim()
                Me.LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim()
            End If
        End Sub

        ' Token: 0x06000DD8 RID: 3544 RVA: 0x0028994C File Offset: 0x0028894C
        Private Sub tvcmiLipsModulesParent_RemoveAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to exclude all of the files from '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton3, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllLipsModuleFiles(Me.LastClickedTVNode.Text)
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DD9 RID: 3545 RVA: 0x002899D0 File Offset: 0x002889D0
        Private Sub tvcmiLipsModulesChild_Exclude_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim text As String = Me.LastClickedTVNode.Parent.Text
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveLipsModuleFile(text, filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DDA RID: 3546 RVA: 0x00289A44 File Offset: 0x00288A44
        Private Sub tvcmiStreamWavesRoot_AddFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Override folder", "all", True, True))
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim streamWavesFilesHashTable As Hashtable = Me.Project.StreamWavesFilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Not streamWavesFilesHashTable.ContainsKey(array(i)) Then
                    Me.Project.StreamWavesFiles.Add(array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DDB RID: 3547 RVA: 0x00289B10 File Offset: 0x00288B10
        Private Sub tvcmiStreamWavesRoot_AddModule_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter name for new module"
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                Me.Project.AddStreamWavesModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()))
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
                Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
            End If
        End Sub

        ' Token: 0x06000DDC RID: 3548 RVA: 0x00289B94 File Offset: 0x00288B94
        Private Sub tvcmiStreamWavesRoot_RemoveAllFiles_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to exclude all of the files?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton3, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllStreamWavesFiles()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DDD RID: 3549 RVA: 0x00289BCC File Offset: 0x00288BCC
        Private Sub tvcmiStreamWavesRoot_RemoveAllModules_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to remove all of the StreamWaves Modules from the Project?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllStreamWavesModules()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DDE RID: 3550 RVA: 0x00289C04 File Offset: 0x00288C04
        Private Sub tvcmiStreamWavesRoot_RemoveEverything_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to remove everything (StreamWaves Modules and files) from the Project?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllStreamWavesModules()
                Me.Project.RemoveAllStreamWavesFiles()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DDF RID: 3551 RVA: 0x00289C44 File Offset: 0x00288C44
        Private Sub tvcmiStreamWavesModuleParent_AddFiles_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", True, True))
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim filesHashTable As Hashtable = CType(Me.Project.StreamWavesModules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                    Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                ElseIf Not filesHashTable.ContainsKey(array(i)) Then
                    Me.Project.AddStreamWavesModuleFile(Me.LastClickedTVNode.Text, array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DE0 RID: 3552 RVA: 0x00289D6C File Offset: 0x00288D6C
        Private Sub tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to exclude all of the files from '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton3, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllStreamWavesModuleFiles(Me.LastClickedTVNode.Text)
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DE1 RID: 3553 RVA: 0x00289DF0 File Offset: 0x00288DF0
        Private Sub tvcmiStreamWavesModuleParent_RenameSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter new name for module"
            frmPromptForString.tbValue.Text = Me.LastClickedTVNode.Text
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                CType(Me.Project.StreamWavesModules(Me.Project.GetStreamWavesModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).ModuleName = frmPromptForString.tbValue.Text.Trim()
                Me.LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim()
            End If
        End Sub

        ' Token: 0x06000DE2 RID: 3554 RVA: 0x00289E90 File Offset: 0x00288E90
        Private Sub tvcmiStreamWavesModulesParent_RemoveSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to remove the module '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveStreamWavesModule(Me.LastClickedTVNode.Text.Trim())
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DE3 RID: 3555 RVA: 0x00289F18 File Offset: 0x00288F18
        Private Sub tvcmiStreamWavesModulesChild_ExcludeSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim text As String = Me.LastClickedTVNode.Parent.Text
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveStreamWavesModuleFile(text, filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DE4 RID: 3556 RVA: 0x00289F8C File Offset: 0x00288F8C
        Private Sub tvcmiStreamWavesFileChild_ExcludeSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim text As String = Me.LastClickedTVNode.Parent.Text
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveStreamWavesFile(filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DE5 RID: 3557 RVA: 0x0028A000 File Offset: 0x00289000
        Private Sub miNewPoject_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AskIfSaveProject()
            Dim frmProjectManagerProperties As frmProjectManagerProperties = New frmProjectManagerProperties()
            If frmProjectManagerProperties.ShowDialog(Me) = DialogResult.OK Then
                Me.InitialBrowsePath = "C:\"
                Me.ProjectFilePath = frmProjectManagerProperties.tbProjectPath.Text.Trim()
                Me.ProjectMgr = New clsProjectManager(Me.ProjectFilePath, frmProjectManagerProperties.tbProjectName.Text.Trim())
                Me.Project = Me.ProjectMgr.Project
                Me.Project.DebugFilePath = frmProjectManagerProperties.tbReleasePath.Text
                Me.Project.ReleaseFilePath = frmProjectManagerProperties.tbReleasePath.Text.Trim()
                If frmProjectManagerProperties.rbKotor1.Checked Then
                    Me.Project.KotorVersionIndex = 0
                End If
                If frmProjectManagerProperties.rbKotor2.Checked Then
                    Me.Project.KotorVersionIndex = 1
                End If
                If Not Me.Project.DebugFilePath.EndsWith("\") Then
                    Dim clsProject As clsProject = Me.Project
                    clsProject.DebugFilePath += "\"
                End If
                If Not Me.Project.ReleaseFilePath.EndsWith("\") Then
                    Dim clsProject As clsProject = Me.Project
                    clsProject.ReleaseFilePath += "\"
                End If
                Me.EnableMenus()
                Me.BuildTreeRoots()
                Me.RefreshTreeView()
                Me.Text = "Project Manager - " + Path.GetFileName(Me.ProjectMgr.ProjectFilePath)
            End If
        End Sub

        ' Token: 0x06000DE6 RID: 3558 RVA: 0x0028A178 File Offset: 0x00289178
        Private Sub miOpenProject_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AskIfSaveProject()
            Dim text As String = Me.BrowseForProjectFile()
            If File.Exists(text) Then
                Dim clsProjectManager As clsProjectManager = New clsProjectManager(text)
                If clsProjectManager.Project IsNot Nothing Then
                    Me.ProjectMgr = clsProjectManager
                    Me.Project = Me.ProjectMgr.Project
                    Me.BuildTreeRoots()
                    Me.RefreshTreeView()
                    Me.Text = "Project Manager - " + Path.GetFileName(Me.ProjectMgr.ProjectFilePath)
                    Me.miProjectProperties.Enabled = True
                    If Not Me.Project.DebugFilePath.EndsWith("\") Then
                        Dim clsProject As clsProject = Me.Project
                        clsProject.DebugFilePath += "\"
                    End If
                    If Not Me.Project.ReleaseFilePath.EndsWith("\") Then
                        Dim clsProject As clsProject = Me.Project
                        clsProject.ReleaseFilePath += "\"
                    End If
                    Me.EnableMenus()
                End If
            End If
        End Sub

        ' Token: 0x06000DE7 RID: 3559 RVA: 0x0028A270 File Offset: 0x00289270
        Private Sub miSaveProject_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.Project IsNot Nothing Then
                Me.ProjectMgr.SaveProject()
            End If
        End Sub

        ' Token: 0x06000DE8 RID: 3560 RVA: 0x0028A288 File Offset: 0x00289288
        Private Sub miProjectProperties_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.EditProjectProperties()
        End Sub

        ' Token: 0x06000DE9 RID: 3561 RVA: 0x0028A290 File Offset: 0x00289290
        Private Sub miExploreDebugFolder_Click(ByVal sender As Object, ByVal e As EventArgs)
            'New Process() With { .StartInfo = { .FileName = "explorer.exe ", .Arguments = Me.Project.DebugFilePath } }.Start()
            Dim process As Process = New Process()
            process.StartInfo.FileName = "explorer.exe"
            process.StartInfo.Arguments = """" & Me.Project.DebugFilePath & """"
            process.Start()
        End Sub

        ' Token: 0x06000DEA RID: 3562 RVA: 0x0028A2D0 File Offset: 0x002892D0
        Private Sub miExploreReleaseFolder_Click(ByVal sender As Object, ByVal e As EventArgs)
            'New Process() With { .StartInfo = { .FileName = "explorer.exe ", .Arguments = Me.Project.ReleaseFilePath } }.Start()
            Dim process As Process = New Process()
            process.StartInfo.FileName = "explorer.exe"
            process.StartInfo.Arguments = """" & Me.Project.ReleaseFilePath & """"
            process.Start()
        End Sub

        ' Token: 0x06000DEB RID: 3563 RVA: 0x0028A310 File Offset: 0x00289310
        Private Sub miDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.miDebug.Checked = True
            Me.miRelease.Checked = False
            Me.BuildMode = "debug"
        End Sub

        ' Token: 0x06000DEC RID: 3564 RVA: 0x0028A338 File Offset: 0x00289338
        Private Sub miRelease_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.miDebug.Checked = False
            Me.miRelease.Checked = True
            Me.BuildMode = "build"
        End Sub

        ' Token: 0x06000DED RID: 3565 RVA: 0x0028A360 File Offset: 0x00289360
        Private Sub miBuildProject_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmProgressMeter As frmProgressMeter = New frmProgressMeter()
            Dim utilWindowRelativePositioner As utilWindowRelativePositioner = New utilWindowRelativePositioner(Me, frmProgressMeter)
            Me.WorkingPath = Path.Combine(Me.Project.DebugFilePath, "working")
            Dim text As String
            If StringType.StrCmp(Me.BuildMode, "debug", False) = 0 Then
                text = Me.Project.DebugFilePath
            Else
                text = Me.Project.ReleaseFilePath
            End If
            frmProgressMeter.Location = utilWindowRelativePositioner.getConcentric()
            frmProgressMeter.Show()
            If Me.Project.OverrideFiles.Count > 0 Then
                Me.EnsureDirectoryExists(text + "Override\")
                frmProgressMeter.message = "Copying Override files"
                frmProgressMeter.stepAmount = 100 / Me.Project.OverrideFiles.Count
                Try
                    For Each obj As Object In Me.Project.OverrideFiles
                        Dim text2 As String = StringType.FromObject(obj)
                        If Not text2.ToLower().EndsWith("nss") Then
                            frmProgressMeter.status = "Copying " + Path.GetFileName(text2)
                            File.Copy(text2, text + "override\" + Path.GetFileName(text2), True)
                        Else
                            frmProgressMeter.status = "Compiling Script: " + Path.GetFileName(text2)
                            Dim text3 As String = Nothing
                            Try
                                text3 = Me.CompileNSS(text2)
                            Catch ex As System.Exception
                                If Interaction.MsgBox(String.Concat(New String() {"Override Script ", text2, " failed to compile.", vbLf, "Error message:", vbLf, ex.Message, vbLf, "Do you wish to continue compiling scripts?"}), MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, "Script compile failure") = MsgBoxResult.No Then
                                    frmProgressMeter.Close()
                                    Return
                                End If
                            End Try
                            If StringType.StrCmp(text3, "", False) <> 0 Then
                                File.Copy(text3, text + "override\" + Path.GetFileName(text3), True)
                                frmProgressMeter.stepUp()
                            End If
                        End If
                        frmProgressMeter.stepUp()
                    Next
                Finally
                    Dim enumerator As IEnumerator = Nothing
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
            Dim arrayList As ArrayList = Me.Project.Modules
            If arrayList.Count > 0 Then
                Me.EnsureDirectoryExists(text + "Modules\")
                Me.EnsureDirectoryExists(Me.WorkingPath)
                Try
                    For Each obj2 As Object In arrayList
                        Dim moduleFileEntry As ModuleFileEntry = CType(obj2, ModuleFileEntry)
                        If moduleFileEntry.ModuleFiles.Count > 0 Then
                            frmProgressMeter.progress = 0
                            frmProgressMeter.message = "Compiling Package: " + moduleFileEntry.ModuleName
                            frmProgressMeter.stepAmount = 100 / moduleFileEntry.ModuleFiles.Count
                            Dim array As String() = New String(moduleFileEntry.ModuleFiles.Count - 1 + 1 - 1) {}
                            Dim num As Integer = 0
                            Dim num2 As Integer = moduleFileEntry.ModuleFiles.Count - 1
                            For i As Integer = num To num2
                                If Not moduleFileEntry.ModuleFiles(i).ToString().ToLower().EndsWith("nss") Then
                                    frmProgressMeter.status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles(i)))
                                    array(i) = StringType.FromObject(moduleFileEntry.ModuleFiles(i))
                                    frmProgressMeter.stepUp()
                                Else
                                    frmProgressMeter.status = "Compiling Script: " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles(i)))
                                    Dim text3 As String = Me.CompileNSS(StringType.FromObject(moduleFileEntry.ModuleFiles(i)))
                                    If StringType.StrCmp(text3, "", False) = 0 Then
                                        Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Module Script " + moduleFileEntry.ModuleName + ":", moduleFileEntry.ModuleFiles(i)), " failed to compile."), vbLf), "Aborting build"), MsgBoxStyle.Exclamation, "Script compile failure")
                                        Return
                                    End If
                                    array(i) = text3
                                    frmProgressMeter.stepUp()
                                End If
                            Next
                            Dim clsERF As clsERF = New clsERF(String.Concat(New String() {text, "Modules\", moduleFileEntry.ModuleName, ".", moduleFileEntry.PackageType.ToLower()}), moduleFileEntry.PackageType.ToUpper(), Convert.ToUInt32(0), Nothing, array)
                        End If
                    Next
                Finally
                    Dim enumerator2 As IEnumerator = Nothing
                    If TypeOf enumerator2 Is IDisposable Then
                        CType(enumerator2, IDisposable).Dispose()
                    End If
                End Try
            End If
            arrayList = Me.Project.LipsModules
            If arrayList.Count > 0 Then
                Me.EnsureDirectoryExists(text + "Lips\")
                Me.EnsureDirectoryExists(Me.WorkingPath)
                Try
                    For Each obj3 As Object In arrayList
                        Dim moduleFileEntry2 As ModuleFileEntry = CType(obj3, ModuleFileEntry)
                        If moduleFileEntry2.ModuleFiles.Count > 0 Then
                            frmProgressMeter.progress = 0
                            frmProgressMeter.message = "Compiling Module: " + moduleFileEntry2.ModuleName
                            frmProgressMeter.stepAmount = 100 / moduleFileEntry2.ModuleFiles.Count
                            Dim array2 As String() = New String(moduleFileEntry2.ModuleFiles.Count - 1 + 1 - 1) {}
                            Dim num3 As Integer = 0
                            Dim num4 As Integer = moduleFileEntry2.ModuleFiles.Count - 1
                            For j As Integer = num3 To num4
                                If Not moduleFileEntry2.ModuleFiles(j).ToString().ToLower().EndsWith("nss") Then
                                    frmProgressMeter.status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry2.ModuleFiles(j)))
                                    array2(j) = StringType.FromObject(moduleFileEntry2.ModuleFiles(j))
                                    frmProgressMeter.stepUp()
                                Else
                                    frmProgressMeter.status = "Compiling Script: " + Path.GetFileName(StringType.FromObject(moduleFileEntry2.ModuleFiles(j)))
                                    Dim text3 As String = Me.CompileNSS(StringType.FromObject(moduleFileEntry2.ModuleFiles(j)))
                                    If StringType.StrCmp(text3, "", False) = 0 Then
                                        Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Module Script " + moduleFileEntry2.ModuleName + ":", moduleFileEntry2.ModuleFiles(j)), " failed to compile."), vbLf), "Aborting build"), MsgBoxStyle.Exclamation, "Script compile failure")
                                        Return
                                    End If
                                    array2(j) = text3
                                    frmProgressMeter.stepUp()
                                End If
                            Next
                            Dim clsERF2 As clsERF = New clsERF(text + "Lips\" + moduleFileEntry2.ModuleName + ".mod", "MOD", Convert.ToUInt32(0), Nothing, array2)
                        End If
                    Next
                Finally
                    Dim enumerator3 As IEnumerator = Nothing
                    If TypeOf enumerator3 Is IDisposable Then
                        CType(enumerator3, IDisposable).Dispose()
                    End If
                End Try
            End If
            arrayList = Me.Project.StreamWavesModules
            If arrayList.Count > 0 Then
                Me.EnsureDirectoryExists(text + "StreamWaves\")
                Try
                    For Each obj4 As Object In arrayList
                        Dim moduleFileEntry3 As ModuleFileEntry = CType(obj4, ModuleFileEntry)
                        If moduleFileEntry3.ModuleFiles.Count > 0 Then
                            Me.EnsureDirectoryExists(text + "StreamWaves\" + moduleFileEntry3.ModuleName + "\")
                            frmProgressMeter.progress = 0
                            frmProgressMeter.message = "Copying Module: " + moduleFileEntry3.ModuleName
                            frmProgressMeter.stepAmount = 100 / moduleFileEntry3.ModuleFiles.Count
                            Dim num5 As Integer = 0
                            Dim num6 As Integer = moduleFileEntry3.ModuleFiles.Count - 1
                            For k As Integer = num5 To num6
                                frmProgressMeter.status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry3.ModuleFiles(k)))
                                File.Copy(StringType.FromObject(moduleFileEntry3.ModuleFiles(k)), String.Concat(New String() {text, "StreamWaves\", moduleFileEntry3.ModuleName, "\", Path.GetFileName(StringType.FromObject(moduleFileEntry3.ModuleFiles(k)))}), True)
                            Next
                        End If
                    Next
                Finally
                    Dim enumerator4 As IEnumerator = Nothing
                    If TypeOf enumerator4 Is IDisposable Then
                        CType(enumerator4, IDisposable).Dispose()
                    End If
                End Try
            End If
            If Me.Project.StreamWavesFiles.Count > 0 Then
                frmProgressMeter.message = "Copying StreamWaves files"
                frmProgressMeter.stepAmount = 100 / Me.Project.StreamWavesFiles.Count
                Try
                    For Each obj5 As Object In Me.Project.StreamWavesFiles
                        Dim text4 As String = StringType.FromObject(obj5)
                        frmProgressMeter.status = "Copying " + Path.GetFileName(text4)
                        File.Copy(text4, text + "StreamWaves\" + Path.GetFileName(text4), True)
                        frmProgressMeter.stepUp()
                    Next
                Finally
                    Dim enumerator5 As IEnumerator = Nothing
                    If TypeOf enumerator5 Is IDisposable Then
                        CType(enumerator5, IDisposable).Dispose()
                    End If
                End Try
            End If
            frmProgressMeter.Close()
        End Sub

        ' Token: 0x06000DEE RID: 3566 RVA: 0x0028AD3C File Offset: 0x00289D3C
        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x06000DEF RID: 3567 RVA: 0x0028AD44 File Offset: 0x00289D44
        Private Sub miCleanDebugPrjFilesOnly_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.CleanProjectFilesFromDir(Me.Project.DebugFilePath)
        End Sub

        ' Token: 0x06000DF0 RID: 3568 RVA: 0x0028AD58 File Offset: 0x00289D58
        Private Sub miCleanReleasePrjFilesOnly_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.CleanProjectFilesFromDir(Me.Project.ReleaseFilePath)
        End Sub

        ' Token: 0x06000DF1 RID: 3569 RVA: 0x0028AD6C File Offset: 0x00289D6C
        Private Sub AskIfSaveProject()
            If Me.Project IsNot Nothing AndAlso Interaction.MsgBox("Save Project before closing?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Me.ProjectMgr.SaveProject()
            End If
        End Sub

        ' Token: 0x06000DF2 RID: 3570 RVA: 0x0028AD94 File Offset: 0x00289D94
        Private Sub EnableMenus()
            Me.miProjectProperties.Enabled = True
            Me.miExploreDebugFolder.Enabled = True
            Me.miExploreReleaseFolder.Enabled = True
            Me.miSaveProject.Enabled = True
            Me.miBuildProject.Enabled = True
            Me.miCleanDebugPrjFilesOnly.Enabled = True
            Me.miCleanReleasePrjFilesOnly.Enabled = True
        End Sub

        ' Token: 0x06000DF3 RID: 3571 RVA: 0x0028ADF8 File Offset: 0x00289DF8
        Private Sub BuildTreeRoots()
            Me.TreeView.Nodes.Clear()
            Me.TreeView.Nodes.AddRange(New ProjectFileItemTreeNode() {New ProjectFileItemTreeNode("Project", New ProjectFileItemTreeNode() {New ProjectFileItemTreeNode("Overrides"), New ProjectFileItemTreeNode("Packages"), New ProjectFileItemTreeNode("Lips Modules"), New ProjectFileItemTreeNode("StreamWaves")})})
            Me.TreeView.Nodes(0).Nodes(0).Tag = "overrideroot"
            Me.TreeView.Nodes(0).Nodes(1).Tag = "moduleroot"
            Me.TreeView.Nodes(0).Nodes(2).Tag = "lipsmoduleroot"
            Me.TreeView.Nodes(0).Nodes(3).Tag = "streamwavesroot"
            Me.TreeView.Nodes(0).Nodes(0).ImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(1).ImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(2).ImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(3).ImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(0).SelectedImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(1).SelectedImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(2).SelectedImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(3).SelectedImageIndex = 2
            Me.TreeView.Nodes(0).Text = "projectroot"
            Me.TreeView.Nodes(0).Expand()
        End Sub

        ' Token: 0x06000DF4 RID: 3572 RVA: 0x0028B050 File Offset: 0x0028A050
        Private Sub RefreshTreeView()
            Me.TreeView.BeginUpdate()
            Me.TreeView.Nodes(0).Nodes(0).Nodes.Clear()
            Me.TreeView.Nodes(0).Nodes(1).Nodes.Clear()
            Me.TreeView.Nodes(0).Nodes(2).Nodes.Clear()
            Me.TreeView.Nodes(0).Nodes(3).Nodes.Clear()
            Me.TreeView.Nodes(0).Text = Me.Project.Name
            Me.TreeView.Nodes(0).Tag = "projectroot"
            Me.TreeView.Nodes(0).ImageIndex = 0
            Me.TreeView.Nodes(0).SelectedImageIndex = Me.TreeView.Nodes(0).ImageIndex
            Me.Project.OverrideFiles.Sort()
            Try
                For Each obj As Object In Me.Project.OverrideFiles
                    Dim text As String = StringType.FromObject(obj)
                    Dim projectFileItemTreeNode As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text))
                    projectFileItemTreeNode.Tag = "overridechild"
                    projectFileItemTreeNode.ImageIndex = 1
                    projectFileItemTreeNode.SelectedImageIndex = projectFileItemTreeNode.ImageIndex
                    projectFileItemTreeNode.FilePath = text
                    Me.TreeView.Nodes(0).Nodes(0).Nodes.Add(projectFileItemTreeNode)
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Dim arrayList As ArrayList = Me.Project.Modules
            Try
                For Each obj2 As Object In arrayList
                    Dim moduleFileEntry As ModuleFileEntry = CType(obj2, ModuleFileEntry)
                    Dim projectFileItemTreeNode2 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(moduleFileEntry.ModuleName)
                    projectFileItemTreeNode2.Tag = "moduleparent"
                    projectFileItemTreeNode2.ImageIndex = 2
                    projectFileItemTreeNode2.SelectedImageIndex = projectFileItemTreeNode2.ImageIndex
                    moduleFileEntry.ModuleFiles.Sort()
                    Try
                        For Each obj3 As Object In moduleFileEntry.ModuleFiles
                            Dim text2 As String = StringType.FromObject(obj3)
                            Dim projectFileItemTreeNode3 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text2))
                            projectFileItemTreeNode3.Tag = "modulechild"
                            projectFileItemTreeNode3.ImageIndex = 1
                            projectFileItemTreeNode3.SelectedImageIndex = projectFileItemTreeNode3.ImageIndex
                            projectFileItemTreeNode3.FilePath = text2
                            projectFileItemTreeNode2.Nodes.Add(projectFileItemTreeNode3)
                        Next
                    Finally
                        Dim enumerator3 As IEnumerator = Nothing
                        If TypeOf enumerator3 Is IDisposable Then
                            CType(enumerator3, IDisposable).Dispose()
                        End If
                    End Try
                    Me.TreeView.Nodes(0).Nodes(1).Nodes.Add(projectFileItemTreeNode2)
                Next
            Finally
                Dim enumerator2 As IEnumerator = Nothing
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            arrayList = Me.Project.LipsModules
            Try
                For Each obj4 As Object In arrayList
                    Dim moduleFileEntry2 As ModuleFileEntry = CType(obj4, ModuleFileEntry)
                    Dim projectFileItemTreeNode4 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(moduleFileEntry2.ModuleName)
                    projectFileItemTreeNode4.Tag = "lipsmoduleparent"
                    projectFileItemTreeNode4.ImageIndex = 2
                    projectFileItemTreeNode4.SelectedImageIndex = projectFileItemTreeNode4.ImageIndex
                    moduleFileEntry2.ModuleFiles.Sort()
                    Try
                        For Each obj5 As Object In moduleFileEntry2.ModuleFiles
                            Dim text3 As String = StringType.FromObject(obj5)
                            Dim projectFileItemTreeNode5 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text3))
                            projectFileItemTreeNode5.Tag = "lipsmodulechild"
                            projectFileItemTreeNode5.ImageIndex = 1
                            projectFileItemTreeNode5.SelectedImageIndex = projectFileItemTreeNode5.ImageIndex
                            projectFileItemTreeNode5.FilePath = text3
                            projectFileItemTreeNode4.Nodes.Add(projectFileItemTreeNode5)
                        Next
                    Finally
                        Dim enumerator5 As IEnumerator = Nothing
                        If TypeOf enumerator5 Is IDisposable Then
                            CType(enumerator5, IDisposable).Dispose()
                        End If
                    End Try
                    Me.TreeView.Nodes(0).Nodes(2).Nodes.Add(projectFileItemTreeNode4)
                Next
            Finally
                Dim enumerator4 As IEnumerator = Nothing
                If TypeOf enumerator4 Is IDisposable Then
                    CType(enumerator4, IDisposable).Dispose()
                End If
            End Try
            arrayList = Me.Project.StreamWavesModules
            Try
                For Each obj6 As Object In arrayList
                    Dim moduleFileEntry3 As ModuleFileEntry = CType(obj6, ModuleFileEntry)
                    Dim projectFileItemTreeNode6 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(moduleFileEntry3.ModuleName)
                    projectFileItemTreeNode6.Tag = "streamwavesmoduleparent"
                    projectFileItemTreeNode6.ImageIndex = 2
                    projectFileItemTreeNode6.SelectedImageIndex = projectFileItemTreeNode6.ImageIndex
                    moduleFileEntry3.ModuleFiles.Sort()
                    Try
                        For Each obj7 As Object In moduleFileEntry3.ModuleFiles
                            Dim text4 As String = StringType.FromObject(obj7)
                            Dim projectFileItemTreeNode7 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text4))
                            projectFileItemTreeNode7.Tag = "streamwavesmodulechild"
                            projectFileItemTreeNode7.ImageIndex = 1
                            projectFileItemTreeNode7.SelectedImageIndex = projectFileItemTreeNode7.ImageIndex
                            projectFileItemTreeNode7.FilePath = text4
                            projectFileItemTreeNode6.Nodes.Add(projectFileItemTreeNode7)
                        Next
                    Finally
                        Dim enumerator7 As IEnumerator = Nothing
                        If TypeOf enumerator7 Is IDisposable Then
                            CType(enumerator7, IDisposable).Dispose()
                        End If
                    End Try
                    Me.TreeView.Nodes(0).Nodes(3).Nodes.Add(projectFileItemTreeNode6)
                Next
            Finally
                Dim enumerator6 As IEnumerator = Nothing
                If TypeOf enumerator6 Is IDisposable Then
                    CType(enumerator6, IDisposable).Dispose()
                End If
            End Try
            Me.Project.StreamWavesFiles.Sort()
            Try
                For Each obj8 As Object In Me.Project.StreamWavesFiles
                    Dim text5 As String = StringType.FromObject(obj8)
                    Dim projectFileItemTreeNode8 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text5))
                    projectFileItemTreeNode8.Tag = "streamwavesfilechild"
                    projectFileItemTreeNode8.ImageIndex = 1
                    projectFileItemTreeNode8.SelectedImageIndex = projectFileItemTreeNode8.ImageIndex
                    projectFileItemTreeNode8.FilePath = text5
                    Me.TreeView.Nodes(0).Nodes(3).Nodes.Add(projectFileItemTreeNode8)
                Next
            Finally
                Dim enumerator8 As IEnumerator = Nothing
                If TypeOf enumerator8 Is IDisposable Then
                    CType(enumerator8, IDisposable).Dispose()
                End If
            End Try
            Me.TreeView.EndUpdate()
        End Sub

        ' Token: 0x06000DF5 RID: 3573 RVA: 0x0028B750 File Offset: 0x0028A750
        Private Sub EditProjectProperties()
            Dim frmProjectManagerProperties As frmProjectManagerProperties = New frmProjectManagerProperties("edit")
            frmProjectManagerProperties.tbProjectName.Text = Me.Project.Name
            frmProjectManagerProperties.tbProjectPath.Text = Me.ProjectMgr.ProjectFilePath
            frmProjectManagerProperties.tbDebugPath.Text = Me.Project.DebugFilePath
            frmProjectManagerProperties.tbReleasePath.Text = Me.Project.ReleaseFilePath
            frmProjectManagerProperties.rbKotor1.Checked = Me.Project.KotorVersionIndex = 0
            frmProjectManagerProperties.rbKotor2.Checked = Me.Project.KotorVersionIndex = 1
            If frmProjectManagerProperties.ShowDialog(Me) = DialogResult.OK Then
                If StringType.StrCmp(frmProjectManagerProperties.tbProjectName.Text.Trim(), Me.Project.Name, False) <> 0 Then
                    Me.Project.Name = frmProjectManagerProperties.tbProjectName.Text.Trim()
                    Me.TreeView.Nodes(0).Text = frmProjectManagerProperties.tbProjectName.Text.Trim()
                End If
                Me.ProjectMgr.ProjectFilePath = frmProjectManagerProperties.tbProjectPath.Text.Trim()
                Me.Text = "Project Manager - " + Path.GetFileName(frmProjectManagerProperties.tbProjectPath.Text.Trim())
                Me.Project.DebugFilePath = frmProjectManagerProperties.tbDebugPath.Text.Trim()
                Me.Project.ReleaseFilePath = frmProjectManagerProperties.tbReleasePath.Text.Trim()
                If Not Me.Project.DebugFilePath.EndsWith("\") Then
                    Dim clsProject As clsProject = Me.Project
                    clsProject.DebugFilePath += "\"
                End If
                If Not Me.Project.ReleaseFilePath.EndsWith("\") Then
                    Dim clsProject As clsProject = Me.Project
                    clsProject.ReleaseFilePath += "\"
                End If
                If frmProjectManagerProperties.rbKotor1.Checked Then
                    Me.Project.KotorVersionIndex = 0
                End If
                If frmProjectManagerProperties.rbKotor2.Checked Then
                    Me.Project.KotorVersionIndex = 1
                End If
            End If
        End Sub

        ' Token: 0x06000DF6 RID: 3574 RVA: 0x0028B974 File Offset: 0x0028A974
        Public Sub OpenTreeViewToPath(ByVal treepath As String, ByVal currNode As TreeNode, ByVal currLevel As Integer)
            Dim array As String() = Strings.Split(treepath, "\", -1, CompareMethod.Binary)
            If currLevel = array.Length Then
                Return
            End If
            Try
                For Each obj As Object In currNode.Nodes
                    Dim treeNode As TreeNode = CType(obj, TreeNode)
                    If StringType.StrCmp(treeNode.Text, array(currLevel), False) = 0 Then
                        treeNode.Expand()
                        Me.OpenTreeViewToPath(treepath, treeNode, currLevel + 1)
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000DF7 RID: 3575 RVA: 0x0028BA04 File Offset: 0x0028AA04
        Private Function BrowseForProjectFile() As String
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Title = "Select project file..."
            openFileDialog.Filter = "Kotor Tool Project (*.ktp)|*.ktp"
            openFileDialog.CheckFileExists = True
            openFileDialog.FilterIndex = 1
            openFileDialog.Multiselect = False
            openFileDialog.RestoreDirectory = True
            openFileDialog.FileName = "*.ktp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Return openFileDialog.FileName
            End If
            Dim text As String = Nothing
            Return text
        End Function

        ' Token: 0x06000DF8 RID: 3576 RVA: 0x0028BA68 File Offset: 0x0028AA68
        Public Sub EnsureDirectoryExists(ByVal dirPath As Object)
            If Not Directory.Exists(StringType.FromObject(dirPath)) Then
                Directory.CreateDirectory(StringType.FromObject(dirPath))
            End If
        End Sub

        ' Token: 0x06000DF9 RID: 3577 RVA: 0x0028BA84 File Offset: 0x0028AA84
        Private Function CompileNSS(ByVal sourcefilepath As String) As String
            ' The following expression was wrapped in a checked-expression
            Dim text As String = "-g " + Convert.ToString(Me.Project.KotorVersionIndex + 1)
            Dim text2 As String = Me.WorkingPath + "\" + Path.GetFileNameWithoutExtension(sourcefilepath) + ".ncs"
            Me.EnsureDirectoryExists(Me.WorkingPath)
            If File.Exists(text2) Then
                File.Delete(text2)
            End If
            Dim process As Process = New Process()
            process.StartInfo.FileName = frmMain.gRootPath + "nwnnsscomp.exe"
            process.StartInfo.UseShellExecute = False
            process.StartInfo.CreateNoWindow = True
            process.StartInfo.Arguments = String.Concat(New String() {"-c ", text, " -o ", """", text2, """", " ", """", sourcefilepath, """"})
            process.StartInfo.RedirectStandardOutput = True
            process.Start()
            Dim text3 As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit(4000)
            If text3.IndexOf("Error") = -1 Then
                Return text2
            End If
            Throw New frmProjectManager.NSSCompilerException(text3)
        End Function

        ' Token: 0x06000DFA RID: 3578 RVA: 0x0028BBCC File Offset: 0x0028ABCC
        Private Sub CleanProjectFilesFromDir(ByVal dirname As String)
            Try
                For Each obj As Object In Me.Project.OverrideFiles
                    Dim text As String = StringType.FromObject(obj)
                    Try
                        File.Delete(dirname + "override\" + Path.GetFileName(text))
                    Catch ex As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj2 As Object In Me.Project.Modules
                    Dim moduleFileEntry As ModuleFileEntry = CType(obj2, ModuleFileEntry)
                    Try
                        File.Delete(dirname + "modules\" + moduleFileEntry.ModuleName + ".mod")
                    Catch ex2 As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator2 As IEnumerator = Nothing
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj3 As Object In Me.Project.LipsModules
                    Dim moduleFileEntry2 As ModuleFileEntry = CType(obj3, ModuleFileEntry)
                    Try
                        File.Delete(dirname + "lips\" + moduleFileEntry2.ModuleName + ".mod")
                    Catch ex3 As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator3 As IEnumerator = Nothing
                If TypeOf enumerator3 Is IDisposable Then
                    CType(enumerator3, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj4 As Object In Me.Project.StreamWavesModules
                    Dim moduleFileEntry3 As ModuleFileEntry = CType(obj4, ModuleFileEntry)
                    Try
                        For Each obj5 As Object In moduleFileEntry3.ModuleFiles
                            Dim text2 As String = StringType.FromObject(obj5)
                            Try
                                File.Delete(String.Concat(New String() {dirname, "StreamWaves\", moduleFileEntry3.ModuleName, "\", Path.GetFileName(text2)}))
                            Catch ex4 As System.Exception
                            End Try
                        Next
                    Finally
                        Dim enumerator5 As IEnumerator = Nothing
                        If TypeOf enumerator5 Is IDisposable Then
                            CType(enumerator5, IDisposable).Dispose()
                        End If
                    End Try
                    Try
                        Directory.Delete(dirname + "StreamWaves\" + moduleFileEntry3.ModuleName + "\")
                    Catch ex5 As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator4 As IEnumerator = Nothing
                If TypeOf enumerator4 Is IDisposable Then
                    CType(enumerator4, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj6 As Object In Me.Project.StreamWavesFiles
                    Dim text3 As String = StringType.FromObject(obj6)
                    Try
                        File.Delete(dirname + "StreamWaves\" + Path.GetFileName(text3))
                    Catch ex6 As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator6 As IEnumerator = Nothing
                If TypeOf enumerator6 Is IDisposable Then
                    CType(enumerator6, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000DFB RID: 3579 RVA: 0x0028BF24 File Offset: 0x0028AF24
        Private Sub TreeView_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim point As Point = Me.TreeView.PointToClient(Control.MousePosition)
            Dim projectFileItemTreeNode As ProjectFileItemTreeNode = CType(Me.TreeView.GetNodeAt(point), ProjectFileItemTreeNode)
            If projectFileItemTreeNode IsNot Nothing Then
                Me.lblStatus.Text = projectFileItemTreeNode.FilePath
            End If
        End Sub

        ' Token: 0x06000DFC RID: 3580 RVA: 0x0028BF68 File Offset: 0x0028AF68
        Private Sub TreeView_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            Me.lblStatus.Text = ""
        End Sub

        ' Token: 0x06000DFD RID: 3581 RVA: 0x0028BF7C File Offset: 0x0028AF7C
        Private Sub frmProjectManager_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x04000682 RID: 1666
        <AccessedThroughProperty("tvcmiStreamWavesModulesParent_RemoveSelf")> _
        Private _tvcmiStreamWavesModulesParent_RemoveSelf As MenuItem

        ' Token: 0x04000683 RID: 1667
        <AccessedThroughProperty("MenuItem15")> _
        Private _MenuItem15 As MenuItem

        ' Token: 0x04000684 RID: 1668
        <AccessedThroughProperty("tvcmiStreamWavesModuleParent_RenameSelf")> _
        Private _tvcmiStreamWavesModuleParent_RenameSelf As MenuItem

        ' Token: 0x04000685 RID: 1669
        <AccessedThroughProperty("MenuItem14")> _
        Private _MenuItem14 As MenuItem

        ' Token: 0x04000686 RID: 1670
        <AccessedThroughProperty("tvcmiStreamWavesModuleParent_ExcludeAllFiles")> _
        Private _tvcmiStreamWavesModuleParent_ExcludeAllFiles As MenuItem

        ' Token: 0x04000687 RID: 1671
        <AccessedThroughProperty("miOpenProject")> _
        Private _miOpenProject As MenuItem

        ' Token: 0x04000688 RID: 1672
        <AccessedThroughProperty("MenuItem9")> _
        Private _MenuItem9 As MenuItem

        ' Token: 0x04000689 RID: 1673
        <AccessedThroughProperty("tvcmiStreamWavesModuleParent_AddFiles")> _
        Private _tvcmiStreamWavesModuleParent_AddFiles As MenuItem

        ' Token: 0x0400068A RID: 1674
        <AccessedThroughProperty("tvcmiStreamWavesRoot_RemoveEverything")> _
        Private _tvcmiStreamWavesRoot_RemoveEverything As MenuItem

        ' Token: 0x0400068B RID: 1675
        <AccessedThroughProperty("tvcmiStreamWavesRoot_RemoveAllModules")> _
        Private _tvcmiStreamWavesRoot_RemoveAllModules As MenuItem

        ' Token: 0x0400068C RID: 1676
        <AccessedThroughProperty("tvcmiStreamWavesRoot_RemoveAllFiles")> _
        Private _tvcmiStreamWavesRoot_RemoveAllFiles As MenuItem

        ' Token: 0x0400068D RID: 1677
        <AccessedThroughProperty("tvcmiStreamWavesRoot_AddModule")> _
        Private _tvcmiStreamWavesRoot_AddModule As MenuItem

        ' Token: 0x0400068E RID: 1678
        <AccessedThroughProperty("tvcmiStreamWavesRoot_AddFile")> _
        Private _tvcmiStreamWavesRoot_AddFile As MenuItem

        ' Token: 0x0400068F RID: 1679
        <AccessedThroughProperty("tvcmiStreamWavesFileChild_ExcludeSelf")> _
        Private _tvcmiStreamWavesFileChild_ExcludeSelf As MenuItem

        ' Token: 0x04000690 RID: 1680
        <AccessedThroughProperty("ilistTree")> _
        Private _ilistTree As ImageList

        ' Token: 0x04000691 RID: 1681
        <AccessedThroughProperty("tvcmiModulesParent_Properties")> _
        Private _tvcmiModulesParent_Properties As MenuItem

        ' Token: 0x04000692 RID: 1682
        <AccessedThroughProperty("MenuItem16")> _
        Private _MenuItem16 As MenuItem

        ' Token: 0x04000693 RID: 1683
        <AccessedThroughProperty("tvcmStreamWavesFileChild")> _
        Private _tvcmStreamWavesFileChild As ContextMenu

        ' Token: 0x04000694 RID: 1684
        <AccessedThroughProperty("tvcmStreamWavesModulesChild")> _
        Private _tvcmStreamWavesModulesChild As ContextMenu

        ' Token: 0x04000695 RID: 1685
        <AccessedThroughProperty("tvcmStreamWavesModulesParent")> _
        Private _tvcmStreamWavesModulesParent As ContextMenu

        ' Token: 0x04000696 RID: 1686
        <AccessedThroughProperty("MenuItem11")> _
        Private _MenuItem11 As MenuItem

        ' Token: 0x04000697 RID: 1687
        <AccessedThroughProperty("MainMenu1")> _
        Private _MainMenu1 As MainMenu

        ' Token: 0x04000698 RID: 1688
        <AccessedThroughProperty("tvcmStreamWavesRoot")> _
        Private _tvcmStreamWavesRoot As ContextMenu

        ' Token: 0x04000699 RID: 1689
        <AccessedThroughProperty("MenuItem12")> _
        Private _MenuItem12 As MenuItem

        ' Token: 0x0400069A RID: 1690
        <AccessedThroughProperty("MenuItem1")> _
        Private _MenuItem1 As MenuItem

        ' Token: 0x0400069B RID: 1691
        <AccessedThroughProperty("miCleanReleasePrjFilesOnly")> _
        Private _miCleanReleasePrjFilesOnly As MenuItem

        ' Token: 0x0400069C RID: 1692
        <AccessedThroughProperty("miCleanDebugPrjFilesOnly")> _
        Private _miCleanDebugPrjFilesOnly As MenuItem

        ' Token: 0x0400069D RID: 1693
        <AccessedThroughProperty("tvcmiLipsModulesParent_RenameSelf")> _
        Private _tvcmiLipsModulesParent_RenameSelf As MenuItem

        ' Token: 0x0400069E RID: 1694
        <AccessedThroughProperty("TreeView")> _
        Private _TreeView As TreeView

        ' Token: 0x0400069F RID: 1695
        <AccessedThroughProperty("tvcmiModulesParent_RenameSelf")> _
        Private _tvcmiModulesParent_RenameSelf As MenuItem

        ' Token: 0x040006A0 RID: 1696
        <AccessedThroughProperty("miExploreDebugFolder")> _
        Private _miExploreDebugFolder As MenuItem

        ' Token: 0x040006A1 RID: 1697
        <AccessedThroughProperty("miExploreReleaseFolder")> _
        Private _miExploreReleaseFolder As MenuItem

        ' Token: 0x040006A2 RID: 1698
        <AccessedThroughProperty("tvcmiProperties")> _
        Private _tvcmiProperties As MenuItem

        ' Token: 0x040006A3 RID: 1699
        <AccessedThroughProperty("tvcmProjectRoot")> _
        Private _tvcmProjectRoot As ContextMenu

        ' Token: 0x040006A4 RID: 1700
        <AccessedThroughProperty("tvcmiLipsModulesParent_RemoveSelf")> _
        Private _tvcmiLipsModulesParent_RemoveSelf As MenuItem

        ' Token: 0x040006A5 RID: 1701
        <AccessedThroughProperty("MenuItem13")> _
        Private _MenuItem13 As MenuItem

        ' Token: 0x040006A6 RID: 1702
        <AccessedThroughProperty("MenuItem5")> _
        Private _MenuItem5 As MenuItem

        ' Token: 0x040006A7 RID: 1703
        <AccessedThroughProperty("miQuit")> _
        Private _miQuit As MenuItem

        ' Token: 0x040006A8 RID: 1704
        <AccessedThroughProperty("MenuItem8")> _
        Private _MenuItem8 As MenuItem

        ' Token: 0x040006A9 RID: 1705
        <AccessedThroughProperty("tvcmiModulesParent_RemoveSelf")> _
        Private _tvcmiModulesParent_RemoveSelf As MenuItem

        ' Token: 0x040006AA RID: 1706
        <AccessedThroughProperty("tvcmiLipsModulesRoot_RemoveAllModules")> _
        Private _tvcmiLipsModulesRoot_RemoveAllModules As MenuItem

        ' Token: 0x040006AB RID: 1707
        <AccessedThroughProperty("tvcmiModulesRoot_RemoveAllModules")> _
        Private _tvcmiModulesRoot_RemoveAllModules As MenuItem

        ' Token: 0x040006AC RID: 1708
        <AccessedThroughProperty("lblStatus")> _
        Private _lblStatus As Label

        ' Token: 0x040006AD RID: 1709
        <AccessedThroughProperty("tvcmiLipsModulesParent_RemoveAll")> _
        Private _tvcmiLipsModulesParent_RemoveAll As MenuItem

        ' Token: 0x040006AE RID: 1710
        <AccessedThroughProperty("MenuItem2")> _
        Private _MenuItem2 As MenuItem

        ' Token: 0x040006AF RID: 1711
        <AccessedThroughProperty("tvcmiModulesParent_RemoveAll")> _
        Private _tvcmiModulesParent_RemoveAll As MenuItem

        ' Token: 0x040006B0 RID: 1712
        <AccessedThroughProperty("MenuItem4")> _
        Private _MenuItem4 As MenuItem

        ' Token: 0x040006B1 RID: 1713
        <AccessedThroughProperty("tvcmiOverrideRoot_RemoveAll")> _
        Private _tvcmiOverrideRoot_RemoveAll As MenuItem

        ' Token: 0x040006B2 RID: 1714
        <AccessedThroughProperty("MenuItem7")> _
        Private _MenuItem7 As MenuItem

        ' Token: 0x040006B3 RID: 1715
        <AccessedThroughProperty("MenuItem6")> _
        Private _MenuItem6 As MenuItem

        ' Token: 0x040006B4 RID: 1716
        <AccessedThroughProperty("MenuItem3")> _
        Private _MenuItem3 As MenuItem

        ' Token: 0x040006B5 RID: 1717
        <AccessedThroughProperty("miBuildProject")> _
        Private _miBuildProject As MenuItem

        ' Token: 0x040006B6 RID: 1718
        <AccessedThroughProperty("MenuItem10")> _
        Private _MenuItem10 As MenuItem

        ' Token: 0x040006B7 RID: 1719
        <AccessedThroughProperty("tvcmOverrideRoot")> _
        Private _tvcmOverrideRoot As ContextMenu

        ' Token: 0x040006B8 RID: 1720
        <AccessedThroughProperty("tvcmOverrideChild")> _
        Private _tvcmOverrideChild As ContextMenu

        ' Token: 0x040006B9 RID: 1721
        <AccessedThroughProperty("miSaveProject")> _
        Private _miSaveProject As MenuItem

        ' Token: 0x040006BA RID: 1722
        <AccessedThroughProperty("tvcmModulesRoot")> _
        Private _tvcmModulesRoot As ContextMenu

        ' Token: 0x040006BB RID: 1723
        <AccessedThroughProperty("tvcmModulesParent")> _
        Private _tvcmModulesParent As ContextMenu

        ' Token: 0x040006BC RID: 1724
        <AccessedThroughProperty("tvcmModulesChild")> _
        Private _tvcmModulesChild As ContextMenu

        ' Token: 0x040006BD RID: 1725
        <AccessedThroughProperty("tvcmLipsModulesRoot")> _
        Private _tvcmLipsModulesRoot As ContextMenu

        ' Token: 0x040006BE RID: 1726
        <AccessedThroughProperty("tvcmLipsModulesParent")> _
        Private _tvcmLipsModulesParent As ContextMenu

        ' Token: 0x040006BF RID: 1727
        <AccessedThroughProperty("tvcmLipsModulesChild")> _
        Private _tvcmLipsModulesChild As ContextMenu

        ' Token: 0x040006C0 RID: 1728
        <AccessedThroughProperty("tvcmiStreamWavesModulesChild_ExcludeSelf")> _
        Private _tvcmiStreamWavesModulesChild_ExcludeSelf As MenuItem

        ' Token: 0x040006C1 RID: 1729
        <AccessedThroughProperty("tvcmiOverrideRoot_Add")> _
        Private _tvcmiOverrideRoot_Add As MenuItem

        ' Token: 0x040006C2 RID: 1730
        <AccessedThroughProperty("tvcmiOverrideChild_Exclude")> _
        Private _tvcmiOverrideChild_Exclude As MenuItem

        ' Token: 0x040006C3 RID: 1731
        <AccessedThroughProperty("miRelease")> _
        Private _miRelease As MenuItem

        ' Token: 0x040006C4 RID: 1732
        <AccessedThroughProperty("tvcmiModulesRoot_Add")> _
        Private _tvcmiModulesRoot_Add As MenuItem

        ' Token: 0x040006C5 RID: 1733
        <AccessedThroughProperty("tvcmiModulesParent_Add")> _
        Private _tvcmiModulesParent_Add As MenuItem

        ' Token: 0x040006C6 RID: 1734
        <AccessedThroughProperty("tvcmiModulesChild_Exclude")> _
        Private _tvcmiModulesChild_Exclude As MenuItem

        ' Token: 0x040006C7 RID: 1735
        <AccessedThroughProperty("tvcmiLipsModulesRoot_Add")> _
        Private _tvcmiLipsModulesRoot_Add As MenuItem

        ' Token: 0x040006C8 RID: 1736
        <AccessedThroughProperty("tvcmiLipsModulesParent_Add")> _
        Private _tvcmiLipsModulesParent_Add As MenuItem

        ' Token: 0x040006C9 RID: 1737
        <AccessedThroughProperty("tvcmiLipsModulesChild_Exclude")> _
        Private _tvcmiLipsModulesChild_Exclude As MenuItem

        ' Token: 0x040006CA RID: 1738
        <AccessedThroughProperty("miProjectProperties")> _
        Private _miProjectProperties As MenuItem

        ' Token: 0x040006CB RID: 1739
        <AccessedThroughProperty("miNewPoject")> _
        Private _miNewPoject As MenuItem

        ' Token: 0x040006CC RID: 1740
        <AccessedThroughProperty("miDebug")> _
        Private _miDebug As MenuItem

        ' Token: 0x040006CD RID: 1741
        Private InitialBrowsePath As String

        ' Token: 0x040006CE RID: 1742
        Private ProjectFilePath As String

        ' Token: 0x040006CF RID: 1743
        Private WorkingPath As String

        ' Token: 0x040006D0 RID: 1744
        Private ProjectMgr As clsProjectManager

        ' Token: 0x040006D1 RID: 1745
        Private Project As clsProject

        ' Token: 0x040006D2 RID: 1746
        Private LastClickedTVNode As TreeNode

        ' Token: 0x040006D3 RID: 1747
        Private MyParentForm As frmMain

        ' Token: 0x040006D4 RID: 1748
        Private BuildMode As String

        ' Token: 0x040006D5 RID: 1749
        Private Const ilFileIcon As Integer = 1

        ' Token: 0x040006D6 RID: 1750
        Private Const ilFolderIcon As Integer = 2

        ' Token: 0x0200006B RID: 107
        Private Class NSSCompilerException
            Inherits System.Exception

            ' Token: 0x06000DFE RID: 3582 RVA: 0x0028BF90 File Offset: 0x0028AF90
            Public Sub New(ByVal Message As Object)
                MyBase.New(StringType.FromObject(Message))
            End Sub
        End Class
    End Class
End Namespace
