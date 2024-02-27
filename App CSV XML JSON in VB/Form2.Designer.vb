<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        NombreColumnaTXT = New TextBox()
        AceptarBTM = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 21)
        Label1.TabIndex = 0
        Label1.Text = "Nombra la columna"
        ' 
        ' NombreColumnaTXT
        ' 
        NombreColumnaTXT.Location = New Point(16, 50)
        NombreColumnaTXT.Name = "NombreColumnaTXT"
        NombreColumnaTXT.Size = New Size(194, 23)
        NombreColumnaTXT.TabIndex = 1
        ' 
        ' AceptarBTM
        ' 
        AceptarBTM.Location = New Point(138, 90)
        AceptarBTM.Name = "AceptarBTM"
        AceptarBTM.Size = New Size(75, 23)
        AceptarBTM.TabIndex = 2
        AceptarBTM.Text = "Aceptar"
        AceptarBTM.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(222, 130)
        Controls.Add(AceptarBTM)
        Controls.Add(NombreColumnaTXT)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Añadir columna"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NombreColumnaTXT As TextBox
    Friend WithEvents AceptarBTM As Button
End Class
