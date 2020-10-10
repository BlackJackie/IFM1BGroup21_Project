<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadQuote
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
        Me.grdQuotes = New UJGrid.UJGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnBackToMenu = New System.Windows.Forms.Button()
        Me.btnCleanFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generated Quotes:"
        '
        'grdQuotes
        '
        Me.grdQuotes.Cols = 6
        Me.grdQuotes.FixedCols = 0
        Me.grdQuotes.FixedRows = 1
        Me.grdQuotes.Location = New System.Drawing.Point(40, 78)
        Me.grdQuotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdQuotes.Name = "grdQuotes"
        Me.grdQuotes.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdQuotes.Size = New System.Drawing.Size(758, 266)
        Me.grdQuotes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quote ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 381)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(479, 26)
        Me.TextBox1.TabIndex = 3
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(639, 378)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(159, 33)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "Load Quote"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnBackToMenu
        '
        Me.btnBackToMenu.Location = New System.Drawing.Point(639, 449)
        Me.btnBackToMenu.Name = "btnBackToMenu"
        Me.btnBackToMenu.Size = New System.Drawing.Size(159, 33)
        Me.btnBackToMenu.TabIndex = 5
        Me.btnBackToMenu.Text = "Back To Menu"
        Me.btnBackToMenu.UseVisualStyleBackColor = True
        '
        'btnCleanFile
        '
        Me.btnCleanFile.Location = New System.Drawing.Point(32, 449)
        Me.btnCleanFile.Name = "btnCleanFile"
        Me.btnCleanFile.Size = New System.Drawing.Size(159, 33)
        Me.btnCleanFile.TabIndex = 6
        Me.btnCleanFile.Text = "Clear Storage"
        Me.btnCleanFile.UseVisualStyleBackColor = True
        '
        'frmLoadQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 494)
        Me.Controls.Add(Me.btnCleanFile)
        Me.Controls.Add(Me.btnBackToMenu)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdQuotes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLoadQuote"
        Me.Text = "Load Quote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grdQuotes As UJGrid.UJGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnBackToMenu As Button
    Friend WithEvents btnCleanFile As Button
End Class
