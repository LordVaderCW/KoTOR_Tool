Imports Microsoft.VisualBasic

Namespace kotor_tool
    ' Token: 0x02000041 RID: 65
    Partial Public Class frmBasicHelp
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents TextBox1 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label


        ' Token: 0x06000275 RID: 629 RVA: 0x0022CCC8 File Offset: 0x0022BCC8
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x0600027C RID: 636 RVA: 0x0022CD78 File Offset: 0x0022BD78
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmBasicHelp))
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.Button1.Location = New Global.System.Drawing.Point(171, 344)
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "OK"
            Me.TextBox1.Location = New Global.System.Drawing.Point(8, 40)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.TextBox1.Size = New Global.System.Drawing.Size(400, 296)
            Me.TextBox1.TabIndex = 3
            Me.TextBox1.Text = "The first time you run the program, it will attempt to detect where you have installed KotOR and configure some of the directory paths it needs to work. It will then bring up the path management screen so you can verify them." & vbCrLf & vbCrLf & "You can specify whether or not you want the BIF tree built at program startup or not from the Tools | Options... menu. If you leave the checkbox unchecked, the BIF portion of the tree view will only be built when you attempt to expand it." & vbCrLf & vbCrLf & "Once the program is running, you can:" & vbCrLf & vbCrLf & "- Select any *.bif or *.rim  file from the tree view, then click Extact to extract every file in it to a directory" & vbCrLf & vbCrLf & "- Select any file in a bif, rim, or erf, then click Extact to extract it to a directory" & vbCrLf & vbCrLf & "- Double-click on any 2da file to bring up the editor for it.  You can then edit the values and write the file to a directory. (Most likely the override folder in yout KotOR folder)  Clicking on the column header in the editor grid will sort it based on the values in that column.  Repeated clicking will change the sort direction." & vbCrLf & vbCrLf & "- Double-clicking on most other file types will bring up and editor/viewer for them, if one it available" & vbCrLf & vbCrLf & "- You can also directly open a 2da v2.b file from the File menu for editing. NOTE: You do not have to open the chitin.key file first." & vbCrLf & vbCrLf & "Notes:" & vbCrLf & "* If you want to edit files contained in RIM files, install Bioware's Gff Editor in the same directory as kotor_tool." & vbCrLf & vbCrLf & "* If you want to extract texture pack .tpc files, you will need the tpc2tga program installed in the same directory at kotor tool." & vbCrLf & vbCrLf & "* You can specify whether or not you want to automatically convert extracted .tpc files to TGA format from the Tools | Options... menu" & vbCrLf & vbCrLf & "* If you also want to be able to view the .tpc files, you must install a TGA file viewer and specify the path to it in the Path Manager." & vbCrLf & "You can download a free TGA viewer at http://www.creabit.com/viewer/"
            Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.Location = New Global.System.Drawing.Point(158, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Basic Help"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(416, 381)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Button1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmBasicHelp"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Basic Help"
            Me.ResumeLayout(False)
        End Sub

    End Class
End Namespace
