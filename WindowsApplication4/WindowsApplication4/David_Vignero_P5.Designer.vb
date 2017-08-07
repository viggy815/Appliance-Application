<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P5
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
        Me.labelSelectAppliance = New System.Windows.Forms.Label()
        Me.comboBoxAppliances = New System.Windows.Forms.ComboBox()
        Me.labelCostPerKwh = New System.Windows.Forms.Label()
        Me.labelApplianceKwh = New System.Windows.Forms.Label()
        Me.labelHoursPerDay = New System.Windows.Forms.Label()
        Me.btnResetToDefault = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtAppliance = New System.Windows.Forms.TextBox()
        Me.txtDailyHours = New System.Windows.Forms.TextBox()
        Me.listOutput = New System.Windows.Forms.ListView()
        Me.columnApplianceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnDailyHours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnTotalCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnMonthlyCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnYearlyCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.groupEnterFields = New System.Windows.Forms.GroupBox()
        Me.txtCostPerGallon = New System.Windows.Forms.TextBox()
        Me.txtWaterPerGallon = New System.Windows.Forms.TextBox()
        Me.labelCostPerGallon = New System.Windows.Forms.Label()
        Me.labelWaterPerHour = New System.Windows.Forms.Label()
        Me.labelWaterBased = New System.Windows.Forms.Label()
        Me.groupSummary = New System.Windows.Forms.GroupBox()
        Me.txtAnnualCost = New System.Windows.Forms.TextBox()
        Me.txtMonthlycost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCostOutput = New System.Windows.Forms.TextBox()
        Me.txtApplianceOutput = New System.Windows.Forms.TextBox()
        Me.labelDailyCost = New System.Windows.Forms.Label()
        Me.labelSelectedAppliance = New System.Windows.Forms.Label()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.labelListHeading = New System.Windows.Forms.Label()
        Me.btnViewkWh = New System.Windows.Forms.Button()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.groupEnterFields.SuspendLayout()
        Me.groupSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelSelectAppliance
        '
        Me.labelSelectAppliance.AutoSize = True
        Me.labelSelectAppliance.Location = New System.Drawing.Point(-3, 11)
        Me.labelSelectAppliance.Name = "labelSelectAppliance"
        Me.labelSelectAppliance.Size = New System.Drawing.Size(90, 13)
        Me.labelSelectAppliance.TabIndex = 0
        Me.labelSelectAppliance.Text = "Select Appliance:"
        '
        'comboBoxAppliances
        '
        Me.comboBoxAppliances.BackColor = System.Drawing.SystemColors.ControlDark
        Me.comboBoxAppliances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxAppliances.FormattingEnabled = True
        Me.comboBoxAppliances.Items.AddRange(New Object() {"None", "Refrigerator", "TV", "Clothes Washer", "Space Heater", "Dishwasher", "Fan", "Dryer", "Ice Machine", "Oven"})
        Me.comboBoxAppliances.Location = New System.Drawing.Point(84, 8)
        Me.comboBoxAppliances.MaxDropDownItems = 10
        Me.comboBoxAppliances.Name = "comboBoxAppliances"
        Me.comboBoxAppliances.Size = New System.Drawing.Size(116, 21)
        Me.comboBoxAppliances.TabIndex = 1
        '
        'labelCostPerKwh
        '
        Me.labelCostPerKwh.AutoSize = True
        Me.labelCostPerKwh.Location = New System.Drawing.Point(-3, 43)
        Me.labelCostPerKwh.Name = "labelCostPerKwh"
        Me.labelCostPerKwh.Size = New System.Drawing.Size(80, 13)
        Me.labelCostPerKwh.TabIndex = 2
        Me.labelCostPerKwh.Text = "Cost per k/Wh:"
        '
        'labelApplianceKwh
        '
        Me.labelApplianceKwh.AutoSize = True
        Me.labelApplianceKwh.Location = New System.Drawing.Point(-3, 67)
        Me.labelApplianceKwh.Name = "labelApplianceKwh"
        Me.labelApplianceKwh.Size = New System.Drawing.Size(88, 13)
        Me.labelApplianceKwh.TabIndex = 3
        Me.labelApplianceKwh.Text = "Appliance k/Wh:"
        '
        'labelHoursPerDay
        '
        Me.labelHoursPerDay.AutoSize = True
        Me.labelHoursPerDay.Location = New System.Drawing.Point(-3, 93)
        Me.labelHoursPerDay.Name = "labelHoursPerDay"
        Me.labelHoursPerDay.Size = New System.Drawing.Size(78, 13)
        Me.labelHoursPerDay.TabIndex = 4
        Me.labelHoursPerDay.Text = "Hours per Day:"
        '
        'btnResetToDefault
        '
        Me.btnResetToDefault.Location = New System.Drawing.Point(235, 162)
        Me.btnResetToDefault.Name = "btnResetToDefault"
        Me.btnResetToDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnResetToDefault.TabIndex = 6
        Me.btnResetToDefault.Text = "Reset"
        Me.btnResetToDefault.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(84, 40)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(97, 20)
        Me.txtCost.TabIndex = 7
        Me.txtCost.Text = "0"
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAppliance
        '
        Me.txtAppliance.Location = New System.Drawing.Point(84, 64)
        Me.txtAppliance.Name = "txtAppliance"
        Me.txtAppliance.Size = New System.Drawing.Size(97, 20)
        Me.txtAppliance.TabIndex = 8
        Me.txtAppliance.Text = " 0"
        Me.txtAppliance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDailyHours
        '
        Me.txtDailyHours.Location = New System.Drawing.Point(84, 90)
        Me.txtDailyHours.Name = "txtDailyHours"
        Me.txtDailyHours.Size = New System.Drawing.Size(97, 20)
        Me.txtDailyHours.TabIndex = 9
        Me.txtDailyHours.Text = "0"
        Me.txtDailyHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'listOutput
        '
        Me.listOutput.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listOutput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnApplianceName, Me.columnDailyHours, Me.columnTotalCost, Me.columnMonthlyCost, Me.columnYearlyCost})
        Me.listOutput.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.listOutput.LabelWrap = False
        Me.listOutput.Location = New System.Drawing.Point(316, 28)
        Me.listOutput.Name = "listOutput"
        Me.listOutput.Size = New System.Drawing.Size(576, 343)
        Me.listOutput.TabIndex = 12
        Me.listOutput.UseCompatibleStateImageBehavior = False
        Me.listOutput.View = System.Windows.Forms.View.Details
        '
        'columnApplianceName
        '
        Me.columnApplianceName.Text = "Appliance Name"
        Me.columnApplianceName.Width = 105
        '
        'columnDailyHours
        '
        Me.columnDailyHours.Text = "Hrs Per Day"
        Me.columnDailyHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.columnDailyHours.Width = 105
        '
        'columnTotalCost
        '
        Me.columnTotalCost.Text = "Cost Per Day"
        Me.columnTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.columnTotalCost.Width = 105
        '
        'columnMonthlyCost
        '
        Me.columnMonthlyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.columnMonthlyCost.Width = 130
        '
        'columnYearlyCost
        '
        Me.columnYearlyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.columnYearlyCost.Width = 130
        '
        'groupEnterFields
        '
        Me.groupEnterFields.Controls.Add(Me.txtCostPerGallon)
        Me.groupEnterFields.Controls.Add(Me.txtWaterPerGallon)
        Me.groupEnterFields.Controls.Add(Me.labelCostPerGallon)
        Me.groupEnterFields.Controls.Add(Me.labelWaterPerHour)
        Me.groupEnterFields.Controls.Add(Me.labelWaterBased)
        Me.groupEnterFields.Controls.Add(Me.comboBoxAppliances)
        Me.groupEnterFields.Controls.Add(Me.labelSelectAppliance)
        Me.groupEnterFields.Controls.Add(Me.txtCost)
        Me.groupEnterFields.Controls.Add(Me.txtDailyHours)
        Me.groupEnterFields.Controls.Add(Me.txtAppliance)
        Me.groupEnterFields.Controls.Add(Me.labelHoursPerDay)
        Me.groupEnterFields.Controls.Add(Me.labelCostPerKwh)
        Me.groupEnterFields.Controls.Add(Me.labelApplianceKwh)
        Me.groupEnterFields.Location = New System.Drawing.Point(12, 12)
        Me.groupEnterFields.Name = "groupEnterFields"
        Me.groupEnterFields.Size = New System.Drawing.Size(217, 217)
        Me.groupEnterFields.TabIndex = 13
        Me.groupEnterFields.TabStop = False
        '
        'txtCostPerGallon
        '
        Me.txtCostPerGallon.Location = New System.Drawing.Point(84, 197)
        Me.txtCostPerGallon.Name = "txtCostPerGallon"
        Me.txtCostPerGallon.Size = New System.Drawing.Size(97, 20)
        Me.txtCostPerGallon.TabIndex = 14
        Me.txtCostPerGallon.Text = "0"
        Me.txtCostPerGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCostPerGallon.Visible = False
        '
        'txtWaterPerGallon
        '
        Me.txtWaterPerGallon.Location = New System.Drawing.Point(84, 171)
        Me.txtWaterPerGallon.Name = "txtWaterPerGallon"
        Me.txtWaterPerGallon.Size = New System.Drawing.Size(97, 20)
        Me.txtWaterPerGallon.TabIndex = 13
        Me.txtWaterPerGallon.Text = "0"
        Me.txtWaterPerGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtWaterPerGallon.Visible = False
        '
        'labelCostPerGallon
        '
        Me.labelCostPerGallon.AutoSize = True
        Me.labelCostPerGallon.Location = New System.Drawing.Point(-2, 200)
        Me.labelCostPerGallon.Name = "labelCostPerGallon"
        Me.labelCostPerGallon.Size = New System.Drawing.Size(80, 13)
        Me.labelCostPerGallon.TabIndex = 12
        Me.labelCostPerGallon.Text = "Cost Per Gallon"
        Me.labelCostPerGallon.Visible = False
        '
        'labelWaterPerHour
        '
        Me.labelWaterPerHour.AutoSize = True
        Me.labelWaterPerHour.Location = New System.Drawing.Point(-3, 171)
        Me.labelWaterPerHour.Name = "labelWaterPerHour"
        Me.labelWaterPerHour.Size = New System.Drawing.Size(81, 13)
        Me.labelWaterPerHour.TabIndex = 11
        Me.labelWaterPerHour.Text = "Water Per Hour"
        Me.labelWaterPerHour.Visible = False
        '
        'labelWaterBased
        '
        Me.labelWaterBased.AutoSize = True
        Me.labelWaterBased.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelWaterBased.Location = New System.Drawing.Point(-3, 137)
        Me.labelWaterBased.Name = "labelWaterBased"
        Me.labelWaterBased.Size = New System.Drawing.Size(152, 13)
        Me.labelWaterBased.TabIndex = 10
        Me.labelWaterBased.Text = "Water_Based Appliance Fields"
        Me.labelWaterBased.Visible = False
        '
        'groupSummary
        '
        Me.groupSummary.Controls.Add(Me.txtAnnualCost)
        Me.groupSummary.Controls.Add(Me.txtMonthlycost)
        Me.groupSummary.Controls.Add(Me.Label2)
        Me.groupSummary.Controls.Add(Me.Label1)
        Me.groupSummary.Controls.Add(Me.txtCostOutput)
        Me.groupSummary.Controls.Add(Me.txtApplianceOutput)
        Me.groupSummary.Controls.Add(Me.labelDailyCost)
        Me.groupSummary.Controls.Add(Me.labelSelectedAppliance)
        Me.groupSummary.Location = New System.Drawing.Point(12, 235)
        Me.groupSummary.Name = "groupSummary"
        Me.groupSummary.Size = New System.Drawing.Size(251, 136)
        Me.groupSummary.TabIndex = 14
        Me.groupSummary.TabStop = False
        Me.groupSummary.Text = "Summary"
        '
        'txtAnnualCost
        '
        Me.txtAnnualCost.Location = New System.Drawing.Point(139, 110)
        Me.txtAnnualCost.Name = "txtAnnualCost"
        Me.txtAnnualCost.ReadOnly = True
        Me.txtAnnualCost.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnualCost.TabIndex = 15
        Me.txtAnnualCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMonthlycost
        '
        Me.txtMonthlycost.Location = New System.Drawing.Point(139, 80)
        Me.txtMonthlycost.Name = "txtMonthlycost"
        Me.txtMonthlycost.ReadOnly = True
        Me.txtMonthlycost.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthlycost.TabIndex = 14
        Me.txtMonthlycost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-3, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Annual Cost"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Monthly Cost"
        '
        'txtCostOutput
        '
        Me.txtCostOutput.Location = New System.Drawing.Point(139, 48)
        Me.txtCostOutput.Name = "txtCostOutput"
        Me.txtCostOutput.ReadOnly = True
        Me.txtCostOutput.Size = New System.Drawing.Size(100, 20)
        Me.txtCostOutput.TabIndex = 11
        Me.txtCostOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtApplianceOutput
        '
        Me.txtApplianceOutput.Location = New System.Drawing.Point(106, 19)
        Me.txtApplianceOutput.Name = "txtApplianceOutput"
        Me.txtApplianceOutput.ReadOnly = True
        Me.txtApplianceOutput.Size = New System.Drawing.Size(133, 20)
        Me.txtApplianceOutput.TabIndex = 10
        Me.txtApplianceOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelDailyCost
        '
        Me.labelDailyCost.AutoSize = True
        Me.labelDailyCost.Location = New System.Drawing.Point(0, 51)
        Me.labelDailyCost.Name = "labelDailyCost"
        Me.labelDailyCost.Size = New System.Drawing.Size(57, 13)
        Me.labelDailyCost.TabIndex = 2
        Me.labelDailyCost.Text = "Daily Cost:"
        '
        'labelSelectedAppliance
        '
        Me.labelSelectedAppliance.AutoSize = True
        Me.labelSelectedAppliance.Location = New System.Drawing.Point(-2, 22)
        Me.labelSelectedAppliance.Name = "labelSelectedAppliance"
        Me.labelSelectedAppliance.Size = New System.Drawing.Size(102, 13)
        Me.labelSelectedAppliance.TabIndex = 1
        Me.labelSelectedAppliance.Text = "Selected Appliance:"
        '
        'btnAddToList
        '
        Me.btnAddToList.Location = New System.Drawing.Point(235, 55)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(75, 23)
        Me.btnAddToList.TabIndex = 15
        Me.btnAddToList.Text = "Add To List"
        Me.btnAddToList.UseVisualStyleBackColor = True
        '
        'labelListHeading
        '
        Me.labelListHeading.AutoSize = True
        Me.labelListHeading.Location = New System.Drawing.Point(313, 9)
        Me.labelListHeading.Name = "labelListHeading"
        Me.labelListHeading.Size = New System.Drawing.Size(568, 13)
        Me.labelListHeading.TabIndex = 16
        Me.labelListHeading.Text = "Appliance Name        -         Hours Per Day         -         Cost Per Day     " &
    "     -         Cost per Month         -         Cost per Yr"
        '
        'btnViewkWh
        '
        Me.btnViewkWh.Location = New System.Drawing.Point(235, 191)
        Me.btnViewkWh.Name = "btnViewkWh"
        Me.btnViewkWh.Size = New System.Drawing.Size(75, 23)
        Me.btnViewkWh.TabIndex = 17
        Me.btnViewkWh.Text = "View kWh"
        Me.btnViewkWh.UseVisualStyleBackColor = True
        '
        'btnSaveList
        '
        Me.btnSaveList.Location = New System.Drawing.Point(235, 84)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveList.TabIndex = 18
        Me.btnSaveList.Text = "Save List"
        Me.btnSaveList.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(460, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "*Drag and Drop Text Files anywhere on the Form to update kWh*"
        '
        'P5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 396)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSaveList)
        Me.Controls.Add(Me.btnViewkWh)
        Me.Controls.Add(Me.labelListHeading)
        Me.Controls.Add(Me.btnAddToList)
        Me.Controls.Add(Me.groupSummary)
        Me.Controls.Add(Me.groupEnterFields)
        Me.Controls.Add(Me.listOutput)
        Me.Controls.Add(Me.btnResetToDefault)
        Me.Name = "P5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "David_Vignero_P5"
        Me.groupEnterFields.ResumeLayout(False)
        Me.groupEnterFields.PerformLayout()
        Me.groupSummary.ResumeLayout(False)
        Me.groupSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelSelectAppliance As Label
    Friend WithEvents comboBoxAppliances As ComboBox
    Friend WithEvents labelCostPerKwh As Label
    Friend WithEvents labelApplianceKwh As Label
    Friend WithEvents labelHoursPerDay As Label
    Friend WithEvents btnResetToDefault As Button
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtAppliance As TextBox
    Friend WithEvents txtDailyHours As TextBox
    Friend WithEvents listOutput As ListView
    Friend WithEvents groupEnterFields As GroupBox
    Friend WithEvents groupSummary As GroupBox
    Friend WithEvents labelDailyCost As Label
    Friend WithEvents labelSelectedAppliance As Label
    Friend WithEvents btnAddToList As Button
    Friend WithEvents txtApplianceOutput As TextBox
    Friend WithEvents txtCostPerGallon As TextBox
    Friend WithEvents txtWaterPerGallon As TextBox
    Friend WithEvents labelCostPerGallon As Label
    Friend WithEvents labelWaterPerHour As Label
    Friend WithEvents labelWaterBased As Label
    Friend WithEvents txtCostOutput As TextBox
    Friend WithEvents columnApplianceName As ColumnHeader
    Friend WithEvents columnDailyHours As ColumnHeader
    Friend WithEvents columnTotalCost As ColumnHeader
    Friend WithEvents labelListHeading As Label
    Friend WithEvents btnViewkWh As Button
    Friend WithEvents btnSaveList As Button
    Friend WithEvents saveFile As SaveFileDialog
    Friend WithEvents columnMonthlyCost As ColumnHeader
    Friend WithEvents columnYearlyCost As ColumnHeader
    Friend WithEvents txtAnnualCost As TextBox
    Friend WithEvents txtMonthlycost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
