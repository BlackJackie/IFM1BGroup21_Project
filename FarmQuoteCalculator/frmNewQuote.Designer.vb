<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewQuote
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtRegionDescription = New System.Windows.Forms.TextBox()
        Me.txtPovertyPopulation = New System.Windows.Forms.TextBox()
        Me.lblNumPeople = New System.Windows.Forms.Label()
        Me.txtWorkingPopulation = New System.Windows.Forms.TextBox()
        Me.lblWorkPeople = New System.Windows.Forms.Label()
        Me.txtBudget = New System.Windows.Forms.TextBox()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddRegion = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grdPlots = New UJGrid.UJGrid()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.btnNewPlotToggle = New System.Windows.Forms.Button()
        Me.txtPlotSize = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.txtPlotDescription = New System.Windows.Forms.TextBox()
        Me.lblPlotDesc = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblRatings = New System.Windows.Forms.Label()
        Me.rbtnFertilityGood = New System.Windows.Forms.RadioButton()
        Me.rbtnFertilityBad = New System.Windows.Forms.RadioButton()
        Me.rbtnWaterBad = New System.Windows.Forms.RadioButton()
        Me.rbtnWaterGood = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAddPlot = New System.Windows.Forms.Button()
        Me.btnGenerateQuote = New System.Windows.Forms.Button()
        Me.btnBackToMenu = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Quote"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAddRegion)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtBudget)
        Me.Panel1.Controls.Add(Me.lblBudget)
        Me.Panel1.Controls.Add(Me.txtWorkingPopulation)
        Me.Panel1.Controls.Add(Me.lblWorkPeople)
        Me.Panel1.Controls.Add(Me.txtPovertyPopulation)
        Me.Panel1.Controls.Add(Me.lblNumPeople)
        Me.Panel1.Controls.Add(Me.txtRegionDescription)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(32, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 315)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Region"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(42, 67)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(93, 20)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "Description:"
        '
        'txtRegionDescription
        '
        Me.txtRegionDescription.Location = New System.Drawing.Point(177, 64)
        Me.txtRegionDescription.Name = "txtRegionDescription"
        Me.txtRegionDescription.Size = New System.Drawing.Size(589, 26)
        Me.txtRegionDescription.TabIndex = 2
        '
        'txtPovertyPopulation
        '
        Me.txtPovertyPopulation.Location = New System.Drawing.Point(317, 109)
        Me.txtPovertyPopulation.Name = "txtPovertyPopulation"
        Me.txtPovertyPopulation.Size = New System.Drawing.Size(449, 26)
        Me.txtPovertyPopulation.TabIndex = 4
        '
        'lblNumPeople
        '
        Me.lblNumPeople.AutoSize = True
        Me.lblNumPeople.Location = New System.Drawing.Point(42, 112)
        Me.lblNumPeople.Name = "lblNumPeople"
        Me.lblNumPeople.Size = New System.Drawing.Size(236, 20)
        Me.lblNumPeople.TabIndex = 3
        Me.lblNumPeople.Text = "Number of impoverished people:"
        '
        'txtWorkingPopulation
        '
        Me.txtWorkingPopulation.Location = New System.Drawing.Point(317, 154)
        Me.txtWorkingPopulation.Name = "txtWorkingPopulation"
        Me.txtWorkingPopulation.Size = New System.Drawing.Size(449, 26)
        Me.txtWorkingPopulation.TabIndex = 6
        '
        'lblWorkPeople
        '
        Me.lblWorkPeople.AutoSize = True
        Me.lblWorkPeople.Location = New System.Drawing.Point(42, 157)
        Me.lblWorkPeople.Name = "lblWorkPeople"
        Me.lblWorkPeople.Size = New System.Drawing.Size(229, 20)
        Me.lblWorkPeople.TabIndex = 5
        Me.lblWorkPeople.Text = "Number within the working age:"
        '
        'txtBudget
        '
        Me.txtBudget.Location = New System.Drawing.Point(317, 200)
        Me.txtBudget.Name = "txtBudget"
        Me.txtBudget.Size = New System.Drawing.Size(449, 26)
        Me.txtBudget.TabIndex = 8
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.Location = New System.Drawing.Point(42, 203)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(133, 20)
        Me.lblBudget.TabIndex = 7
        Me.lblBudget.Text = "Allocated budget:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "R"
        '
        'btnAddRegion
        '
        Me.btnAddRegion.Location = New System.Drawing.Point(642, 249)
        Me.btnAddRegion.Name = "btnAddRegion"
        Me.btnAddRegion.Size = New System.Drawing.Size(123, 35)
        Me.btnAddRegion.TabIndex = 10
        Me.btnAddRegion.Text = "Add Region"
        Me.btnAddRegion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAddPlot)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.lblRatings)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.txtPlotSize)
        Me.Panel2.Controls.Add(Me.btnNewPlotToggle)
        Me.Panel2.Controls.Add(Me.lblSize)
        Me.Panel2.Controls.Add(Me.lblDetails)
        Me.Panel2.Controls.Add(Me.txtPlotDescription)
        Me.Panel2.Controls.Add(Me.lblPlotDesc)
        Me.Panel2.Controls.Add(Me.grdPlots)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(32, 421)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 706)
        Me.Panel2.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 29)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Plots"
        '
        'grdPlots
        '
        Me.grdPlots.FixedCols = 1
        Me.grdPlots.FixedRows = 1
        Me.grdPlots.Location = New System.Drawing.Point(58, 71)
        Me.grdPlots.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdPlots.Name = "grdPlots"
        Me.grdPlots.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdPlots.Size = New System.Drawing.Size(707, 231)
        Me.grdPlots.TabIndex = 12
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(24, 356)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(147, 29)
        Me.lblDetails.TabIndex = 13
        Me.lblDetails.Text = "Plot Details"
        '
        'btnNewPlotToggle
        '
        Me.btnNewPlotToggle.Location = New System.Drawing.Point(642, 341)
        Me.btnNewPlotToggle.Name = "btnNewPlotToggle"
        Me.btnNewPlotToggle.Size = New System.Drawing.Size(123, 35)
        Me.btnNewPlotToggle.TabIndex = 11
        Me.btnNewPlotToggle.Text = "Start New Plot"
        Me.btnNewPlotToggle.UseVisualStyleBackColor = True
        '
        'txtPlotSize
        '
        Me.txtPlotSize.Location = New System.Drawing.Point(177, 456)
        Me.txtPlotSize.Name = "txtPlotSize"
        Me.txtPlotSize.Size = New System.Drawing.Size(589, 26)
        Me.txtPlotSize.TabIndex = 14
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(42, 459)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(87, 20)
        Me.lblSize.TabIndex = 13
        Me.lblSize.Text = "Size (m^2):"
        '
        'txtPlotDescription
        '
        Me.txtPlotDescription.Location = New System.Drawing.Point(177, 411)
        Me.txtPlotDescription.Name = "txtPlotDescription"
        Me.txtPlotDescription.Size = New System.Drawing.Size(589, 26)
        Me.txtPlotDescription.TabIndex = 12
        '
        'lblPlotDesc
        '
        Me.lblPlotDesc.AutoSize = True
        Me.lblPlotDesc.Location = New System.Drawing.Point(42, 414)
        Me.lblPlotDesc.Name = "lblPlotDesc"
        Me.lblPlotDesc.Size = New System.Drawing.Size(93, 20)
        Me.lblPlotDesc.TabIndex = 11
        Me.lblPlotDesc.Text = "Description:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbtnFertilityBad)
        Me.Panel3.Controls.Add(Me.rbtnFertilityGood)
        Me.Panel3.Location = New System.Drawing.Point(177, 519)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(271, 99)
        Me.Panel3.TabIndex = 15
        '
        'lblRatings
        '
        Me.lblRatings.AutoSize = True
        Me.lblRatings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatings.Location = New System.Drawing.Point(42, 519)
        Me.lblRatings.Name = "lblRatings"
        Me.lblRatings.Size = New System.Drawing.Size(120, 20)
        Me.lblRatings.TabIndex = 16
        Me.lblRatings.Text = "Quailty Ratings:"
        '
        'rbtnFertilityGood
        '
        Me.rbtnFertilityGood.AutoSize = True
        Me.rbtnFertilityGood.Location = New System.Drawing.Point(37, 14)
        Me.rbtnFertilityGood.Name = "rbtnFertilityGood"
        Me.rbtnFertilityGood.Size = New System.Drawing.Size(128, 24)
        Me.rbtnFertilityGood.TabIndex = 0
        Me.rbtnFertilityGood.TabStop = True
        Me.rbtnFertilityGood.Text = "Good Fertility"
        Me.rbtnFertilityGood.UseVisualStyleBackColor = True
        '
        'rbtnFertilityBad
        '
        Me.rbtnFertilityBad.AutoSize = True
        Me.rbtnFertilityBad.Location = New System.Drawing.Point(37, 57)
        Me.rbtnFertilityBad.Name = "rbtnFertilityBad"
        Me.rbtnFertilityBad.Size = New System.Drawing.Size(117, 24)
        Me.rbtnFertilityBad.TabIndex = 1
        Me.rbtnFertilityBad.TabStop = True
        Me.rbtnFertilityBad.Text = "Bad Fertility"
        Me.rbtnFertilityBad.UseVisualStyleBackColor = True
        '
        'rbtnWaterBad
        '
        Me.rbtnWaterBad.AutoSize = True
        Me.rbtnWaterBad.Location = New System.Drawing.Point(37, 57)
        Me.rbtnWaterBad.Name = "rbtnWaterBad"
        Me.rbtnWaterBad.Size = New System.Drawing.Size(162, 24)
        Me.rbtnWaterBad.TabIndex = 1
        Me.rbtnWaterBad.TabStop = True
        Me.rbtnWaterBad.Text = "Bad Water Supply"
        Me.rbtnWaterBad.UseVisualStyleBackColor = True
        '
        'rbtnWaterGood
        '
        Me.rbtnWaterGood.AutoSize = True
        Me.rbtnWaterGood.Location = New System.Drawing.Point(37, 14)
        Me.rbtnWaterGood.Name = "rbtnWaterGood"
        Me.rbtnWaterGood.Size = New System.Drawing.Size(173, 24)
        Me.rbtnWaterGood.TabIndex = 0
        Me.rbtnWaterGood.TabStop = True
        Me.rbtnWaterGood.Text = "Good Water Supply"
        Me.rbtnWaterGood.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbtnWaterBad)
        Me.Panel4.Controls.Add(Me.rbtnWaterGood)
        Me.Panel4.Location = New System.Drawing.Point(470, 519)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(295, 99)
        Me.Panel4.TabIndex = 16
        '
        'btnAddPlot
        '
        Me.btnAddPlot.Location = New System.Drawing.Point(642, 650)
        Me.btnAddPlot.Name = "btnAddPlot"
        Me.btnAddPlot.Size = New System.Drawing.Size(123, 35)
        Me.btnAddPlot.TabIndex = 17
        Me.btnAddPlot.Text = "Add Plot"
        Me.btnAddPlot.UseVisualStyleBackColor = True
        '
        'btnGenerateQuote
        '
        Me.btnGenerateQuote.Location = New System.Drawing.Point(674, 1174)
        Me.btnGenerateQuote.Name = "btnGenerateQuote"
        Me.btnGenerateQuote.Size = New System.Drawing.Size(185, 35)
        Me.btnGenerateQuote.TabIndex = 18
        Me.btnGenerateQuote.Text = "Generate Quote"
        Me.btnGenerateQuote.UseVisualStyleBackColor = True
        '
        'btnBackToMenu
        '
        Me.btnBackToMenu.Location = New System.Drawing.Point(32, 1174)
        Me.btnBackToMenu.Name = "btnBackToMenu"
        Me.btnBackToMenu.Size = New System.Drawing.Size(185, 35)
        Me.btnBackToMenu.TabIndex = 19
        Me.btnBackToMenu.Text = "Back To Menu"
        Me.btnBackToMenu.UseVisualStyleBackColor = True
        '
        'frmNewQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 1235)
        Me.Controls.Add(Me.btnBackToMenu)
        Me.Controls.Add(Me.btnGenerateQuote)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNewQuote"
        Me.Text = "New Quote Parameters"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddRegion As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBudget As TextBox
    Friend WithEvents lblBudget As Label
    Friend WithEvents txtWorkingPopulation As TextBox
    Friend WithEvents lblWorkPeople As Label
    Friend WithEvents txtPovertyPopulation As TextBox
    Friend WithEvents lblNumPeople As Label
    Friend WithEvents txtRegionDescription As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAddPlot As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rbtnWaterBad As RadioButton
    Friend WithEvents rbtnWaterGood As RadioButton
    Friend WithEvents lblRatings As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rbtnFertilityBad As RadioButton
    Friend WithEvents rbtnFertilityGood As RadioButton
    Friend WithEvents txtPlotSize As TextBox
    Friend WithEvents btnNewPlotToggle As Button
    Friend WithEvents lblSize As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents txtPlotDescription As TextBox
    Friend WithEvents lblPlotDesc As Label
    Friend WithEvents grdPlots As UJGrid.UJGrid
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGenerateQuote As Button
    Friend WithEvents btnBackToMenu As Button
End Class
