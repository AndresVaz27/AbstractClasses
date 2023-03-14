<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.btnBycicle = New System.Windows.Forms.Button()
        Me.btnBoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCar
        '
        Me.btnCar.Location = New System.Drawing.Point(181, 58)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Size = New System.Drawing.Size(92, 58)
        Me.btnCar.TabIndex = 0
        Me.btnCar.Text = "Car"
        Me.btnCar.UseVisualStyleBackColor = True
        '
        'btnBycicle
        '
        Me.btnBycicle.Location = New System.Drawing.Point(180, 175)
        Me.btnBycicle.Name = "btnBycicle"
        Me.btnBycicle.Size = New System.Drawing.Size(93, 55)
        Me.btnBycicle.TabIndex = 1
        Me.btnBycicle.Text = "Bycicle"
        Me.btnBycicle.UseVisualStyleBackColor = True
        '
        'btnBoat
        '
        Me.btnBoat.Location = New System.Drawing.Point(181, 293)
        Me.btnBoat.Name = "btnBoat"
        Me.btnBoat.Size = New System.Drawing.Size(93, 55)
        Me.btnBoat.TabIndex = 2
        Me.btnBoat.Text = "Boat"
        Me.btnBoat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 438)
        Me.Controls.Add(Me.btnBoat)
        Me.Controls.Add(Me.btnBycicle)
        Me.Controls.Add(Me.btnCar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCar As Button
    Friend WithEvents btnBycicle As Button
    Friend WithEvents btnBoat As Button
End Class
