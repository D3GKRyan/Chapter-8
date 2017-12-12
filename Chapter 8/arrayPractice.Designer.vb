<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arrayPractice
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(30, 66)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(32, 23)
        Me.lbl1.TabIndex = 0
        '
        'lbl2
        '
        Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(83, 66)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(36, 23)
        Me.lbl2.TabIndex = 1
        '
        'lbl3
        '
        Me.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(145, 66)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(34, 23)
        Me.lbl3.TabIndex = 2
        '
        'lbl4
        '
        Me.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(205, 66)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(33, 23)
        Me.lbl4.TabIndex = 3
        '
        'lbl5
        '
        Me.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(258, 66)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(35, 23)
        Me.lbl5.TabIndex = 4
        '
        'btnGenerate
        '
        Me.btnGenerate.AutoSize = True
        Me.btnGenerate.Location = New System.Drawing.Point(30, 108)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(106, 36)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(187, 108)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 36)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'arrayPractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 200)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "arrayPractice"
        Me.Text = "arrayPractice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
