Option Strict Off
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms

Namespace kotor_tool

    Public NotInheritable Class KotorThemeApplier

        Private Shared _installed As Boolean
        Private Shared _theme As KotorTheme
        Private Shared _themeName As String = "DarkSaber"
        Private Shared _themeStamp As DateTime = DateTime.MinValue
        Private Shared ReadOnly _appliedForms As Dictionary(Of Form, DateTime) = New Dictionary(Of Form, DateTime)()

        Private Sub New()
        End Sub

        Public Shared Sub InstallGlobalThemeHooks()
            If _installed Then
                Return
            End If

            _installed = True
            ReloadTheme()
            AddHandler Application.Idle, AddressOf Application_Idle
        End Sub

        Public Shared Sub ReloadAndApplyOpenForms()
            ReloadTheme()
            _appliedForms.Clear()
            ApplyOpenForms()
        End Sub

        Public Shared Sub ApplyToForm(ByVal form As Form)
            If form Is Nothing Then
                Return
            End If

            If _theme Is Nothing Then
                ReloadTheme()
            End If

            If TypeOf form Is frmProgressMeter Then
                CType(form, frmProgressMeter).ApplyActiveTheme()
                _appliedForms(form) = _themeStamp
                Return
            End If

            If TypeOf form Is frmErrorMessage Then
                ApplyErrorMessageForm(CType(form, frmErrorMessage), _theme)
                _appliedForms(form) = _themeStamp
                Return
            End If

            ApplyControl(form, _theme)
            _appliedForms(form) = _themeStamp
        End Sub

        Private Shared Sub ApplyErrorMessageForm(ByVal form As frmErrorMessage, ByVal theme As KotorTheme)
            If form Is Nothing OrElse theme Is Nothing Then
                Return
            End If

            ApplyControl(form, theme)

            form.lblTitle.ForeColor = theme.ErrorTitleText
            ApplyFont(form.lblTitle, New Font(theme.TitleFontName, theme.TitleFontSize, FontStyle.Bold, GraphicsUnit.Point))
            form.lblSubtitle.ForeColor = theme.ErrorSubtitleText
            form.lblSeparatorTop.BackColor = theme.ErrorAccent

            form.pnlSummary.BackColor = theme.ErrorSummaryBack
            form.pnlSummary.ForeColor = theme.ErrorSummaryText
            form.pnlSummary.BorderStyle = BorderStyle.None
            form.SetSummaryBorderColor(theme.ErrorSummaryBorder)
            form.lblSummaryAccent.BackColor = theme.ErrorAccent

            form.lblMsg.ForeColor = theme.ErrorSummaryText
            form.lblCategory.ForeColor = theme.ErrorFieldLabelText
            form.lblImpact.ForeColor = theme.ErrorFieldLabelText
            form.lblNextStep.ForeColor = theme.ErrorFieldLabelText
            form.lblTechnicalHeading.ForeColor = theme.ErrorFieldLabelText

            form.lblCategoryValue.ForeColor = theme.ErrorValueText
            form.lblImpactValue.ForeColor = theme.ErrorValueText
            form.lblNextStepValue.ForeColor = theme.ErrorValueText

            ApplyFont(form.lblCategory, New Font(theme.BodyFontName, theme.BodyFontSize, FontStyle.Bold, GraphicsUnit.Point))
            ApplyFont(form.lblImpact, New Font(theme.BodyFontName, theme.BodyFontSize, FontStyle.Bold, GraphicsUnit.Point))
            ApplyFont(form.lblNextStep, New Font(theme.BodyFontName, theme.BodyFontSize, FontStyle.Bold, GraphicsUnit.Point))
            ApplyFont(form.lblTechnicalHeading, New Font(theme.BodyFontName, theme.BodyFontSize, FontStyle.Bold, GraphicsUnit.Point))
        End Sub

        Private Shared Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
            ReloadThemeIfChanged()
            ApplyOpenForms()
        End Sub

        Private Shared Sub ApplyOpenForms()
            Dim staleForms As List(Of Form) = New List(Of Form)()

            For Each form As Form In _appliedForms.Keys
                If form Is Nothing OrElse form.IsDisposed Then
                    staleForms.Add(form)
                End If
            Next

            For Each form As Form In staleForms
                _appliedForms.Remove(form)
            Next

            For Each form As Form In Application.OpenForms
                If form Is Nothing OrElse form.IsDisposed Then
                    Continue For
                End If

                If _appliedForms.ContainsKey(form) = False OrElse _appliedForms(form) <> _themeStamp Then
                    ApplyToForm(form)
                End If
            Next
        End Sub

        Private Shared Sub ReloadThemeIfChanged()
            Dim currentThemeName As String = KotorThemeManager.GetActiveThemeName()
            Dim currentStamp As DateTime = GetThemeStamp()

            If String.Compare(currentThemeName, _themeName, True, CultureInfo.InvariantCulture) <> 0 OrElse currentStamp <> _themeStamp Then
                ReloadTheme()
                _appliedForms.Clear()
            End If
        End Sub

        Private Shared Sub ReloadTheme()
            _themeName = KotorThemeManager.GetActiveThemeName()
            _theme = KotorThemeManager.LoadTheme(_themeName)
            _themeStamp = GetThemeStamp()
        End Sub

        Private Shared Function GetThemeStamp() As DateTime
            Try
                Dim themePath As String = KotorThemeManager.FindThemeFilePath(KotorThemeManager.GetActiveThemeName())
                If File.Exists(themePath) Then
                    Return File.GetLastWriteTimeUtc(themePath)
                End If
            Catch ex As System.Exception
            End Try

            Return DateTime.MinValue
        End Function

        Private Shared Sub ApplyControl(ByVal control As Control, ByVal theme As KotorTheme)
            If control Is Nothing OrElse theme Is Nothing Then
                Return
            End If

            RemoveHandler control.ControlAdded, AddressOf Control_ControlAdded
            AddHandler control.ControlAdded, AddressOf Control_ControlAdded

            If TypeOf control Is Form Then
                control.BackColor = theme.WindowBack
                control.ForeColor = theme.TextPrimary
                ApplyFont(control, theme.CreateBodyFont())
            ElseIf TypeOf control Is CustomTabControl Then
                theme.ApplyToCustomTabControl(CType(control, CustomTabControl))
            ElseIf TypeOf control Is TabControl Then
                ApplyTabControl(CType(control, TabControl), theme)
            ElseIf TypeOf control Is TabPage Then
                control.BackColor = theme.TabPageBack
                control.ForeColor = theme.TextPrimary
                ApplyFont(control, theme.CreateBodyFont())
            ElseIf TypeOf control Is Panel OrElse TypeOf control Is SplitContainer OrElse TypeOf control Is GroupBox Then
                ApplyContainer(control, theme)
            ElseIf TypeOf control Is Label Then
                ApplyLabel(CType(control, Label), theme)
            ElseIf TypeOf control Is Button Then
                ApplyButton(CType(control, Button), theme)
            ElseIf TypeOf control Is TextBoxBase Then
                ApplyTextBox(CType(control, TextBoxBase), theme)
            ElseIf TypeOf control Is ComboBox Then
                ApplyComboBox(CType(control, ComboBox), theme)
            ElseIf TypeOf control Is ListBox Then
                ApplyListBox(CType(control, ListBox), theme)
            ElseIf TypeOf control Is ListView Then
                ApplyListView(CType(control, ListView), theme)
            ElseIf TypeOf control Is TreeView Then
                ApplyTreeView(CType(control, TreeView), theme)
            ElseIf TypeOf control Is DataGrid Then
                ApplyDataGrid(CType(control, DataGrid), theme)
            ElseIf TypeOf control Is DataGridView Then
                ApplyDataGridView(CType(control, DataGridView), theme)
            ElseIf TypeOf control Is NumericUpDown Then
                ApplyNumericUpDown(CType(control, NumericUpDown), theme)
            ElseIf TypeOf control Is ToolStrip Then
                ApplyToolStrip(CType(control, ToolStrip), theme)
            ElseIf TypeOf control Is CheckBox OrElse TypeOf control Is RadioButton Then
                control.BackColor = Color.Transparent
                control.ForeColor = theme.TextSecondary
                ApplyFont(control, theme.CreateBodyFont())
            ElseIf TypeOf control Is DarkPictureBox Then
                theme.ApplyToDarkPictureBox(CType(control, DarkPictureBox))
            ElseIf TypeOf control Is PictureBox Then
                control.BackColor = theme.LogoBack
                control.ForeColor = theme.TextPrimary
            ElseIf TypeOf control Is CustomProgressBar Then
                theme.ApplyToCustomProgressBar(CType(control, CustomProgressBar))
            ElseIf TypeOf control Is DarkByteViewerControl Then
                ApplyDarkByteViewer(CType(control, DarkByteViewerControl), theme)
            Else
                ApplyFont(control, theme.CreateBodyFont())
            End If

            For Each child As Control In control.Controls
                ApplyControl(child, theme)
            Next
        End Sub

        Private Shared Sub Control_ControlAdded(ByVal sender As Object, ByVal e As ControlEventArgs)
            If e Is Nothing OrElse e.Control Is Nothing Then
                Return
            End If

            If _theme Is Nothing Then
                ReloadTheme()
            End If

            ApplyControl(e.Control, _theme)
        End Sub

        Private Shared Sub ApplyContainer(ByVal control As Control, ByVal theme As KotorTheme)
            If TypeOf control Is GroupBox Then
                control.BackColor = Color.Transparent
                control.ForeColor = theme.GroupBorder
            ElseIf IsHeaderControl(control) Then
                control.BackColor = theme.PanelHeader
                control.ForeColor = theme.TextPrimary
            ElseIf IsFooterControl(control) Then
                control.BackColor = theme.PanelFooter
                control.ForeColor = theme.TextPrimary
            ElseIf IsSummaryControl(control) Then
                control.BackColor = theme.InputBackAlt
                control.ForeColor = theme.TextPrimary
            ElseIf IsRootControl(control) Then
                control.BackColor = theme.PanelRoot
                control.ForeColor = theme.TextPrimary
            Else
                control.BackColor = theme.PanelBody
                control.ForeColor = theme.TextPrimary
            End If

            ApplyFont(control, theme.CreateBodyFont())
        End Sub

        Private Shared Sub ApplyLabel(ByVal label As Label, ByVal theme As KotorTheme)
            If IsSeparatorControl(label) Then
                label.BackColor = If(IsFooterControl(label), theme.FooterSeparator, theme.HeaderSeparator)
                Return
            End If

            label.BackColor = Color.Transparent

            If IsSubtitleControl(label) Then
                label.ForeColor = theme.HeaderSubtitleText
                ApplyFont(label, theme.CreateBodyFont())
            ElseIf IsTitleControl(label) Then
                label.ForeColor = theme.HeaderTitleText
                ApplyFont(label, theme.CreateTitleFont())
            ElseIf IsAccentLabel(label) OrElse IsFieldLabel(label) Then
                label.ForeColor = theme.AccentGoldLight
                ApplyFont(label, New Font(theme.BodyFontName, theme.BodyFontSize, FontStyle.Bold, GraphicsUnit.Point))
            ElseIf IsValueLabel(label) Then
                label.ForeColor = theme.TextPrimary
                ApplyFont(label, theme.CreateBodyFont())
            ElseIf IsMutedControl(label) Then
                label.ForeColor = theme.TextMuted
                ApplyFont(label, theme.CreateBodyFont())
            Else
                label.ForeColor = theme.TextSecondary
                ApplyFont(label, theme.CreateBodyFont())
            End If
        End Sub

        Private Shared Sub ApplyButton(ByVal button As Button, ByVal theme As KotorTheme)
            button.UseVisualStyleBackColor = False
            button.BackColor = theme.ControlDark
            button.ForeColor = theme.TextPrimary
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderColor = theme.AccentGold
            button.FlatAppearance.MouseOverBackColor = theme.ControlHover
            button.FlatAppearance.MouseDownBackColor = theme.ControlDown
            ApplyFont(button, New Font(theme.BodyFontName, theme.BodyFontSize, FontStyle.Bold, GraphicsUnit.Point))
        End Sub

        Private Shared Sub ApplyTextBox(ByVal textBox As TextBoxBase, ByVal theme As KotorTheme)
            textBox.BackColor = If(IsMonoControl(textBox), theme.ByteViewerBack, theme.InputBack)
            textBox.ForeColor = theme.InputText
            textBox.BorderStyle = BorderStyle.FixedSingle

            If IsMonoControl(textBox) Then
                ApplyFont(textBox, theme.CreateMonoFont())
            Else
                ApplyFont(textBox, theme.CreateBodyFont())
            End If
        End Sub

        Private Shared Sub ApplyComboBox(ByVal comboBox As ComboBox, ByVal theme As KotorTheme)
            comboBox.BackColor = theme.InputBack
            comboBox.ForeColor = theme.InputText
            comboBox.FlatStyle = FlatStyle.Flat
            ApplyFont(comboBox, theme.CreateBodyFont())
        End Sub

        Private Shared Sub ApplyListBox(ByVal listBox As ListBox, ByVal theme As KotorTheme)
            listBox.BackColor = theme.InputBack
            listBox.ForeColor = theme.InputText
            ApplyFont(listBox, theme.CreateBodyFont())
        End Sub

        Private Shared Sub ApplyListView(ByVal listView As ListView, ByVal theme As KotorTheme)
            listView.BackColor = theme.InputBack
            listView.ForeColor = theme.InputText
            ApplyFont(listView, theme.CreateBodyFont())
        End Sub

        Private Shared Sub ApplyTreeView(ByVal treeView As TreeView, ByVal theme As KotorTheme)
            If String.Compare(treeView.Name, "tvConversation", True, CultureInfo.InvariantCulture) = 0 AndAlso _
               TypeOf treeView.FindForm() Is frmDialogEditor Then
                Return
            End If

            treeView.BackColor = theme.LogoBack
            treeView.ForeColor = theme.TextPrimary
            treeView.LineColor = theme.BorderDark
            ApplyFont(treeView, theme.CreateBodyFont())
        End Sub

        Private Shared Sub ApplyDataGrid(ByVal grid As DataGrid, ByVal theme As KotorTheme)
            grid.BackColor = theme.DataGridBack
            grid.BackgroundColor = theme.DataGridBackground
            grid.AlternatingBackColor = theme.DataGridAlternatingBack
            grid.ForeColor = theme.TextPrimary
            grid.GridLineColor = theme.DataGridGridLine
            grid.HeaderBackColor = theme.DataGridHeaderBack
            grid.HeaderForeColor = theme.DataGridHeaderText
            grid.CaptionBackColor = theme.DataGridHeaderBack
            grid.CaptionForeColor = theme.HeaderTitleText
            grid.ParentRowsBackColor = theme.PanelBody
            grid.ParentRowsForeColor = theme.TextSecondary
            grid.SelectionBackColor = theme.DataGridSelectionBack
            grid.SelectionForeColor = theme.DataGridSelectionText
            grid.LinkColor = theme.DataGridLink
            ApplyFont(grid, theme.CreateBodyFont())

            For Each tableStyle As DataGridTableStyle In grid.TableStyles
                ApplyDataGridTableStyle(tableStyle, theme)
            Next
        End Sub

        Public Shared Sub ApplyDataGridTableStyle(ByVal tableStyle As DataGridTableStyle, ByVal theme As KotorTheme)
            If tableStyle Is Nothing OrElse theme Is Nothing Then
                Return
            End If

            tableStyle.BackColor = theme.DataGridBack
            tableStyle.AlternatingBackColor = theme.DataGridAlternatingBack
            tableStyle.ForeColor = theme.TextPrimary
            tableStyle.GridLineColor = theme.DataGridGridLine
            tableStyle.HeaderBackColor = theme.DataGridHeaderBack
            tableStyle.HeaderForeColor = theme.DataGridHeaderText
            tableStyle.LinkColor = theme.DataGridLink
            tableStyle.SelectionBackColor = theme.DataGridSelectionBack
            tableStyle.SelectionForeColor = theme.DataGridSelectionText
        End Sub

        Private Shared Sub ApplyDataGridView(ByVal grid As DataGridView, ByVal theme As KotorTheme)
            grid.BackgroundColor = theme.DataGridBackground
            grid.GridColor = theme.DataGridGridLine
            grid.DefaultCellStyle.BackColor = theme.DataGridBack
            grid.DefaultCellStyle.ForeColor = theme.TextPrimary
            grid.DefaultCellStyle.SelectionBackColor = theme.DataGridSelectionBack
            grid.DefaultCellStyle.SelectionForeColor = theme.DataGridSelectionText
            grid.AlternatingRowsDefaultCellStyle.BackColor = theme.DataGridAlternatingBack
            grid.ColumnHeadersDefaultCellStyle.BackColor = theme.DataGridHeaderBack
            grid.ColumnHeadersDefaultCellStyle.ForeColor = theme.DataGridHeaderText
            grid.RowHeadersDefaultCellStyle.BackColor = theme.DataGridHeaderBack
            grid.RowHeadersDefaultCellStyle.ForeColor = theme.DataGridHeaderText
            grid.EnableHeadersVisualStyles = False
            ApplyFont(grid, theme.CreateBodyFont())
        End Sub

        Private Shared Sub ApplyNumericUpDown(ByVal numericUpDown As NumericUpDown, ByVal theme As KotorTheme)
            numericUpDown.BackColor = theme.InputBackAlt
            numericUpDown.ForeColor = theme.InputText
            ApplyFont(numericUpDown, theme.CreateBodyFont())
        End Sub

        Private Shared Sub ApplyToolStrip(ByVal toolStrip As ToolStrip, ByVal theme As KotorTheme)
            toolStrip.BackColor = theme.PanelFooter
            toolStrip.ForeColor = theme.TextSecondary
            ApplyFont(toolStrip, theme.CreateBodyFont())

            For Each item As ToolStripItem In toolStrip.Items
                item.BackColor = theme.PanelFooter
                item.ForeColor = theme.TextSecondary
                item.Font = theme.CreateBodyFont()
            Next
        End Sub

        Private Shared Sub ApplyTabControl(ByVal tabControl As TabControl, ByVal theme As KotorTheme)
            tabControl.BackColor = theme.TabControlBack
            tabControl.ForeColor = theme.TextPrimary
            ApplyFont(tabControl, theme.CreateBodyFont())

            For Each page As TabPage In tabControl.TabPages
                page.BackColor = theme.TabPageBack
                page.ForeColor = theme.TextPrimary
            Next
        End Sub

        Private Shared Sub ApplyDarkByteViewer(ByVal byteViewer As DarkByteViewerControl, ByVal theme As KotorTheme)
            byteViewer.BackColor = theme.ByteViewerBack
            byteViewer.ForeColor = theme.TextPrimary
            byteViewer.HeaderColor = theme.HeaderTitleText
            byteViewer.MutedTextColor = theme.TextSecondary
            byteViewer.AlternateRowColor = theme.ByteViewerAltRow
            byteViewer.SelectionBackColor = theme.ByteViewerSelectionBack
            byteViewer.CurrentBackColor = theme.ByteViewerCurrentBack
            byteViewer.NullBackColor = theme.ByteViewerNullBack
            byteViewer.ControlByteBackColor = theme.ByteViewerControlBack
            byteViewer.HighAsciiBackColor = theme.ByteViewerHighAsciiBack
            byteViewer.NonPrintableBackColor = theme.ByteViewerNonPrintableBack
            ApplyFont(byteViewer, theme.CreateMonoFont())
        End Sub

        Private Shared Sub ApplyFont(ByVal control As Control, ByVal font As Font)
            If control Is Nothing OrElse font Is Nothing Then
                Return
            End If

            Try
                control.Font = font
            Catch ex As System.Exception
            End Try
        End Sub

        Private Shared Function IsHeaderControl(ByVal control As Control) As Boolean
            Return ContainsName(control, "header")
        End Function

        Private Shared Function IsFooterControl(ByVal control As Control) As Boolean
            Return ContainsName(control, "footer") OrElse ContainsName(control, "bottom")
        End Function

        Private Shared Function IsRootControl(ByVal control As Control) As Boolean
            Return ContainsName(control, "root")
        End Function

        Private Shared Function IsSummaryControl(ByVal control As Control) As Boolean
            Return ContainsName(control, "summary")
        End Function

        Private Shared Function IsSeparatorControl(ByVal control As Control) As Boolean
            Return ContainsName(control, "separator") OrElse (TypeOf control Is Label AndAlso control.Height <= 3)
        End Function

        Private Shared Function IsTitleControl(ByVal control As Control) As Boolean
            Return ContainsName(control, "title") OrElse ContainsName(control, "projectname")
        End Function

        Private Shared Function IsSubtitleControl(ByVal control As Control) As Boolean
            Return ContainsName(control, "subtitle") OrElse ContainsName(control, "subTitle") OrElse ContainsName(control, "version")
        End Function

        Private Shared Function IsMutedControl(ByVal control As Control) As Boolean
            Return ContainsName(control, "credit") OrElse ContainsName(control, "note")
        End Function

        Private Shared Function IsAccentLabel(ByVal control As Control) As Boolean
            Return ContainsName(control, "accent")
        End Function

        Private Shared Function IsFieldLabel(ByVal control As Control) As Boolean
            Return ContainsName(control, "fieldlabel")
        End Function

        Private Shared Function IsValueLabel(ByVal control As Control) As Boolean
            Return ContainsName(control, "valuelabel")
        End Function

        Private Shared Function IsMonoControl(ByVal control As Control) As Boolean
            Return TypeOf control Is RichTextBox OrElse ContainsName(control, "hex") OrElse ContainsName(control, "byte") OrElse ContainsName(control, "code")
        End Function

        Private Shared Function ContainsName(ByVal control As Control, ByVal value As String) As Boolean
            If control Is Nothing OrElse control.Name Is Nothing OrElse value Is Nothing Then
                Return False
            End If

            Return control.Name.ToLowerInvariant().IndexOf(value.ToLowerInvariant()) >= 0
        End Function

    End Class

End Namespace
