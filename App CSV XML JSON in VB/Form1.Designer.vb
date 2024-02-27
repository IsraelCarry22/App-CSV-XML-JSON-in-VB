<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        AddColumnBTM = New Button()
        ActuallyFileLBL = New Label()
        MenuStrip1 = New MenuStrip()
        CVSMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveHowToolStripMenuItem = New ToolStripMenuItem()
        XMLMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem1 = New ToolStripMenuItem()
        SaveToolStripMenuItem1 = New ToolStripMenuItem()
        SaveHowToolStripMenuItem1 = New ToolStripMenuItem()
        JSONMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem2 = New ToolStripMenuItem()
        SaveToolStripMenuItem2 = New ToolStripMenuItem()
        SaveHowToolStripMenuItem2 = New ToolStripMenuItem()
        ListDataFileDGV = New DataGridView()
        AddRowBTM = New Button()
        DeleteColumnBTM = New Button()
        DeleteRowBTM = New Button()
        MenuStrip1.SuspendLayout()
        CType(ListDataFileDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AddColumnBTM
        ' 
        AddColumnBTM.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddColumnBTM.Location = New Point(620, 74)
        AddColumnBTM.Name = "AddColumnBTM"
        AddColumnBTM.Size = New Size(143, 31)
        AddColumnBTM.TabIndex = 0
        AddColumnBTM.Text = "Agregar columna"
        AddColumnBTM.UseVisualStyleBackColor = True
        ' 
        ' ActuallyFileLBL
        ' 
        ActuallyFileLBL.AutoSize = True
        ActuallyFileLBL.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ActuallyFileLBL.Location = New Point(12, 46)
        ActuallyFileLBL.Name = "ActuallyFileLBL"
        ActuallyFileLBL.Size = New Size(80, 25)
        ActuallyFileLBL.TabIndex = 1
        ActuallyFileLBL.Text = "Archivo:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {CVSMenuItem, XMLMenuItem, JSONMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(775, 29)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CVSMenuItem
        ' 
        CVSMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenToolStripMenuItem, SaveToolStripMenuItem, SaveHowToolStripMenuItem})
        CVSMenuItem.Font = New Font("Segoe UI", 12F)
        CVSMenuItem.Name = "CVSMenuItem"
        CVSMenuItem.Size = New Size(51, 25)
        CVSMenuItem.Text = "CVS"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(147, 26)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(147, 26)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' SaveHowToolStripMenuItem
        ' 
        SaveHowToolStripMenuItem.Name = "SaveHowToolStripMenuItem"
        SaveHowToolStripMenuItem.Size = New Size(147, 26)
        SaveHowToolStripMenuItem.Text = "Save how"
        ' 
        ' XMLMenuItem
        ' 
        XMLMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenToolStripMenuItem1, SaveToolStripMenuItem1, SaveHowToolStripMenuItem1})
        XMLMenuItem.Font = New Font("Segoe UI", 12F)
        XMLMenuItem.Name = "XMLMenuItem"
        XMLMenuItem.Size = New Size(53, 25)
        XMLMenuItem.Text = "XML"
        ' 
        ' OpenToolStripMenuItem1
        ' 
        OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        OpenToolStripMenuItem1.Size = New Size(147, 26)
        OpenToolStripMenuItem1.Text = "Open"
        ' 
        ' SaveToolStripMenuItem1
        ' 
        SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        SaveToolStripMenuItem1.Size = New Size(147, 26)
        SaveToolStripMenuItem1.Text = "Save"
        ' 
        ' SaveHowToolStripMenuItem1
        ' 
        SaveHowToolStripMenuItem1.Name = "SaveHowToolStripMenuItem1"
        SaveHowToolStripMenuItem1.Size = New Size(147, 26)
        SaveHowToolStripMenuItem1.Text = "Save how"
        ' 
        ' JSONMenuItem
        ' 
        JSONMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenToolStripMenuItem2, SaveToolStripMenuItem2, SaveHowToolStripMenuItem2})
        JSONMenuItem.Font = New Font("Segoe UI", 12F)
        JSONMenuItem.Name = "JSONMenuItem"
        JSONMenuItem.Size = New Size(61, 25)
        JSONMenuItem.Text = "JSON"
        ' 
        ' OpenToolStripMenuItem2
        ' 
        OpenToolStripMenuItem2.Name = "OpenToolStripMenuItem2"
        OpenToolStripMenuItem2.Size = New Size(180, 26)
        OpenToolStripMenuItem2.Text = "Open"
        ' 
        ' SaveToolStripMenuItem2
        ' 
        SaveToolStripMenuItem2.Name = "SaveToolStripMenuItem2"
        SaveToolStripMenuItem2.Size = New Size(180, 26)
        SaveToolStripMenuItem2.Text = "Save"
        ' 
        ' SaveHowToolStripMenuItem2
        ' 
        SaveHowToolStripMenuItem2.Name = "SaveHowToolStripMenuItem2"
        SaveHowToolStripMenuItem2.Size = New Size(180, 26)
        SaveHowToolStripMenuItem2.Text = "Save how"
        ' 
        ' ListDataFileDGV
        ' 
        ListDataFileDGV.AllowUserToAddRows = False
        ListDataFileDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ListDataFileDGV.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        ListDataFileDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        ListDataFileDGV.DefaultCellStyle = DataGridViewCellStyle8
        ListDataFileDGV.Location = New Point(12, 74)
        ListDataFileDGV.Name = "ListDataFileDGV"
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListDataFileDGV.RowsDefaultCellStyle = DataGridViewCellStyle9
        ListDataFileDGV.Size = New Size(602, 433)
        ListDataFileDGV.TabIndex = 3
        ' 
        ' AddRowBTM
        ' 
        AddRowBTM.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddRowBTM.Location = New Point(620, 111)
        AddRowBTM.Name = "AddRowBTM"
        AddRowBTM.Size = New Size(143, 31)
        AddRowBTM.TabIndex = 4
        AddRowBTM.Text = "Agregar fila"
        AddRowBTM.UseVisualStyleBackColor = True
        ' 
        ' DeleteColumnBTM
        ' 
        DeleteColumnBTM.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DeleteColumnBTM.Location = New Point(620, 148)
        DeleteColumnBTM.Name = "DeleteColumnBTM"
        DeleteColumnBTM.Size = New Size(143, 31)
        DeleteColumnBTM.TabIndex = 5
        DeleteColumnBTM.Text = "Eliminar columna"
        DeleteColumnBTM.UseVisualStyleBackColor = True
        ' 
        ' DeleteRowBTM
        ' 
        DeleteRowBTM.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DeleteRowBTM.Location = New Point(620, 185)
        DeleteRowBTM.Name = "DeleteRowBTM"
        DeleteRowBTM.Size = New Size(143, 31)
        DeleteRowBTM.TabIndex = 6
        DeleteRowBTM.Text = "Eliminar fila"
        DeleteRowBTM.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(775, 519)
        Controls.Add(DeleteRowBTM)
        Controls.Add(DeleteColumnBTM)
        Controls.Add(AddRowBTM)
        Controls.Add(ListDataFileDGV)
        Controls.Add(ActuallyFileLBL)
        Controls.Add(AddColumnBTM)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(ListDataFileDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddColumnBTM As Button
    Friend WithEvents ActuallyFileLBL As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CVSMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveHowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XMLMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveHowToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents JSONMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SaveHowToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListDataFileDGV As DataGridView
    Friend WithEvents AddRowBTM As Button
    Friend WithEvents DeleteColumnBTM As Button
    Friend WithEvents DeleteRowBTM As Button

End Class
