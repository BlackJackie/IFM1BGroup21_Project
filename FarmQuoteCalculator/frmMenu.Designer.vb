<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewQuote = New System.Windows.Forms.Button()
        Me.btnLoadQuote = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(636, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Farm Development Quote Calculator"
        '
        'btnNewQuote
        '
        Me.btnNewQuote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewQuote.Location = New System.Drawing.Point(143, 139)
        Me.btnNewQuote.Name = "btnNewQuote"
        Me.btnNewQuote.Size = New System.Drawing.Size(404, 67)
        Me.btnNewQuote.TabIndex = 1
        Me.btnNewQuote.Text = "Start New Quote"
        Me.btnNewQuote.UseVisualStyleBackColor = True
        '
        'btnLoadQuote
        '
        Me.btnLoadQuote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadQuote.Location = New System.Drawing.Point(143, 244)
        Me.btnLoadQuote.Name = "btnLoadQuote"
        Me.btnLoadQuote.Size = New System.Drawing.Size(404, 67)
        Me.btnLoadQuote.TabIndex = 2
        Me.btnLoadQuote.Text = "Load Previous Quote"
        Me.btnLoadQuote.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(143, 348)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(404, 67)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 483)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadQuote)
        Me.Controls.Add(Me.btnNewQuote)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewQuote As Button
    Friend WithEvents btnLoadQuote As Button
    Friend WithEvents btnExit As Button
End Class
