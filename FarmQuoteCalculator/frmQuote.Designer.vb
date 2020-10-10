<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuote
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
        Me.lblQuoteID = New System.Windows.Forms.Label()
        Me.lblRestriction = New System.Windows.Forms.Label()
        Me.grdQuote = New UJGrid.UJGrid()
        Me.lblFarms = New System.Windows.Forms.Label()
        Me.grdFarms = New UJGrid.UJGrid()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnGenerateFoodRestrictedQuote = New System.Windows.Forms.Button()
        Me.btnGenerateBudgetRestrictedQuote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quote:"
        '
        'lblQuoteID
        '
        Me.lblQuoteID.AutoSize = True
        Me.lblQuoteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuoteID.Location = New System.Drawing.Point(157, 26)
        Me.lblQuoteID.Name = "lblQuoteID"
        Me.lblQuoteID.Size = New System.Drawing.Size(141, 37)
        Me.lblQuoteID.TabIndex = 1
        Me.lblQuoteID.Text = "#123456"
        '
        'lblRestriction
        '
        Me.lblRestriction.AutoSize = True
        Me.lblRestriction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestriction.Location = New System.Drawing.Point(58, 88)
        Me.lblRestriction.Name = "lblRestriction"
        Me.lblRestriction.Size = New System.Drawing.Size(300, 29)
        Me.lblRestriction.TabIndex = 2
        Me.lblRestriction.Text = "Budget Restricted Quote"
        '
        'grdQuote
        '
        Me.grdQuote.FixedCols = 1
        Me.grdQuote.FixedRows = 1
        Me.grdQuote.Location = New System.Drawing.Point(63, 139)
        Me.grdQuote.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdQuote.Name = "grdQuote"
        Me.grdQuote.Rows = 21
        Me.grdQuote.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdQuote.Size = New System.Drawing.Size(924, 445)
        Me.grdQuote.TabIndex = 3
        '
        'lblFarms
        '
        Me.lblFarms.AutoSize = True
        Me.lblFarms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFarms.Location = New System.Drawing.Point(62, 626)
        Me.lblFarms.Name = "lblFarms"
        Me.lblFarms.Size = New System.Drawing.Size(236, 29)
        Me.lblFarms.TabIndex = 4
        Me.lblFarms.Text = "Farms To Develop:"
        '
        'grdFarms
        '
        Me.grdFarms.Cols = 6
        Me.grdFarms.FixedCols = 1
        Me.grdFarms.FixedRows = 1
        Me.grdFarms.Location = New System.Drawing.Point(62, 684)
        Me.grdFarms.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdFarms.Name = "grdFarms"
        Me.grdFarms.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdFarms.Size = New System.Drawing.Size(929, 233)
        Me.grdFarms.TabIndex = 5
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(806, 958)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(185, 35)
        Me.btnDone.TabIndex = 19
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnGenerateFoodRestrictedQuote
        '
        Me.btnGenerateFoodRestrictedQuote.Location = New System.Drawing.Point(62, 958)
        Me.btnGenerateFoodRestrictedQuote.Name = "btnGenerateFoodRestrictedQuote"
        Me.btnGenerateFoodRestrictedQuote.Size = New System.Drawing.Size(296, 35)
        Me.btnGenerateFoodRestrictedQuote.TabIndex = 20
        Me.btnGenerateFoodRestrictedQuote.Text = "Generate Food Restricted Quote"
        Me.btnGenerateFoodRestrictedQuote.UseVisualStyleBackColor = True
        '
        'btnGenerateBudgetRestrictedQuote
        '
        Me.btnGenerateBudgetRestrictedQuote.Location = New System.Drawing.Point(385, 958)
        Me.btnGenerateBudgetRestrictedQuote.Name = "btnGenerateBudgetRestrictedQuote"
        Me.btnGenerateBudgetRestrictedQuote.Size = New System.Drawing.Size(296, 35)
        Me.btnGenerateBudgetRestrictedQuote.TabIndex = 21
        Me.btnGenerateBudgetRestrictedQuote.Text = "Generate Budget Restricted Quote"
        Me.btnGenerateBudgetRestrictedQuote.UseVisualStyleBackColor = True
        '
        'frmQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 1026)
        Me.Controls.Add(Me.btnGenerateBudgetRestrictedQuote)
        Me.Controls.Add(Me.btnGenerateFoodRestrictedQuote)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.grdFarms)
        Me.Controls.Add(Me.lblFarms)
        Me.Controls.Add(Me.grdQuote)
        Me.Controls.Add(Me.lblRestriction)
        Me.Controls.Add(Me.lblQuoteID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuote"
        Me.Text = "Development Quote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblQuoteID As Label
    Friend WithEvents lblRestriction As Label
    Friend WithEvents grdQuote As UJGrid.UJGrid
    Friend WithEvents lblFarms As Label
    Friend WithEvents grdFarms As UJGrid.UJGrid
    Friend WithEvents btnDone As Button
    Friend WithEvents btnGenerateFoodRestrictedQuote As Button
    Friend WithEvents btnGenerateBudgetRestrictedQuote As Button
End Class
