'Home Utility Auditing Program
'David Vignero
'POS/408
'January 16, 2016
'Andrew Gluvna

'main formm
Imports System.IO

Public Class P5

    ' Dim arraySaveList As New ArrayList()
    Private myFile As FileInfo

    'array to hold kwh values
    Dim listArray As New ArrayList()
    'Dim listArray(9)
    ' Dim FILE_NAME As String = "Test-2.txt"

    'declaring variables to use through the applicaiton
    Public cost As Double
    Public watts As Double
    Public hours As Double
    Public Total As Double
    Public selected As String
    Public waterPlustotal As Double
    Public waterCost As Double
    Public waterPerHour As Double
    Public waterTotal As Double
    Public month As Integer
    Public annual As Integer
    Public monthlyCost As Double
    Public annualcost As Double


    Dim item As New ListViewItem()





    'assigns a kwh for the selected appliances using an array
    Private Sub checkAppliancekWh()
        If comboBoxAppliances.Text = "None" Then
            txtAppliance.Text = listArray(0)
        End If
        If comboBoxAppliances.Text = "Refrigerator" Then
            txtAppliance.Text = listArray(1)
        End If
        If comboBoxAppliances.Text = "TV" Then
            txtAppliance.Text = listArray(2)
        End If
        If comboBoxAppliances.Text = "Clothes Washer" Then
            txtAppliance.Text = listArray(3)
        End If
        If comboBoxAppliances.Text = "Space Heater" Then
            txtAppliance.Text = listArray(4)
        End If
        If comboBoxAppliances.Text = "Dishwasher" Then
            txtAppliance.Text = listArray(5)
        End If
        If comboBoxAppliances.Text = "Fan" Then
            txtAppliance.Text = listArray(6)
        End If
        If comboBoxAppliances.Text = "Dryer" Then
            txtAppliance.Text = listArray(7)
        End If
        If comboBoxAppliances.Text = "Ice Machine" Then
            txtAppliance.Text = listArray(8)
        End If
        If comboBoxAppliances.Text = "Oven" Then
            txtAppliance.Text = listArray(9)
        End If
    End Sub

    'method for checking if hours entered is in the correct range
    Private Sub checkHours()
        'try/catch statement
        Try
            'statement to check if the hours entered are in the range of 0-24
            If hours >= 0 And hours <= 24 Then



                'if the value entered is within the range, the performCalc() method is called
                performCalc()


            Else
                'returns message if not in the accepted range
                MessageBox.Show("Hours used per day must be 0 - 24.")
                txtDailyHours.Text = "0"
            End If
            'catches exceptions and outputs messages if an exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'method to handle the calculation
    Private Sub performCalc()

        'try/catch statement
        Try
            If comboBoxAppliances.Text = "Refrigerator" Or comboBoxAppliances.Text = "TV" Or comboBoxAppliances.Text = "Space Heater" Or comboBoxAppliances.Text = "Fan" Or comboBoxAppliances.Text = "Dryer" Or comboBoxAppliances.Text = "Oven" Or comboBoxAppliances.Text = "Dishwasher" Or comboBoxAppliances.Text = "Ice Machine" Then
                'variables used To Get the values entered And calculate the total
                cost = CDbl(txtCost.Text)
                hours = CDbl(txtDailyHours.Text)
                watts = CDbl(txtAppliance.Text)
                'total calculation
                month = 30
                annual = 365
                Total = watts * hours * cost
                annualcost = Total * annual
                monthlyCost = Total * month



                ' Formats the calculated total as Currency

                txtCostOutput.Text = Total.ToString("C2")
                txtMonthlycost.Text = monthlyCost.ToString("C2")
                txtAnnualCost.Text = annualcost.ToString("C2")
                txtApplianceOutput.Text = comboBoxAppliances.Text
            End If
            'water based appliances with calculations
            If comboBoxAppliances.Text = "Clothes Washer" Or comboBoxAppliances.Text = "Dishwasher" Or comboBoxAppliances.Text = "Ice Machine" Then

                cost = CDbl(txtCost.Text)
                hours = CDbl(txtDailyHours.Text)
                watts = CDbl(txtAppliance.Text)
                waterPerHour = CDbl(txtWaterPerGallon.Text)
                waterCost = CDbl(txtCostPerGallon.Text)
                month = 30
                annual = 365
                'total calculation

                Total = watts * hours * cost
                'water based calculation
                waterTotal = waterPerHour * waterCost
                waterPlustotal = Total + waterTotal
                annualcost = waterPlustotal * annual
                monthlyCost = waterPlustotal * month




                ' Formats the calculated total as Currency

                txtCostOutput.Text = waterPlustotal.ToString("C2")
                txtMonthlycost.Text = monthlyCost.ToString("C2")
                txtAnnualCost.Text = annualcost.ToString("C2")
                txtApplianceOutput.Text = comboBoxAppliances.Text

            End If


            'catches exceptions and outputs messages if an exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'method to check if the value is numeric
    Private Sub checkNumeric()
        Try
            'if the value is not numeric these are the messages that will be displayed
            'if it is no numeric the value will be set to default
            If Not IsNumeric(txtCost.Text) Then
                MessageBox.Show("Cost Per kWh must be numeric.")
                txtCost.Text = "0.00"
            End If

            If Not IsNumeric(txtAppliance.Text) Then
                MessageBox.Show("Kilowatts must be numeric.")
                txtAppliance.Text = "0"
            End If
            If Not IsNumeric(txtDailyHours.Text) Then
                MessageBox.Show("Hours used per day must be numeric.")
                txtDailyHours.Text = "0"
            End If
            If Not IsNumeric(txtWaterPerGallon.Text) Then
                MessageBox.Show("Water Per Hour must be numeric")
                txtWaterPerGallon.Text = "0"


            End If
            If Not IsNumeric(txtCostPerGallon.Text) Then
                MessageBox.Show("Cost Per Gallon of Water must be numeric")
                txtCostPerGallon.Text = "0"
            End If
            'catches exceptions and outputs messages if an exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    'method for handling the appliance drop down list
    Private Sub appliances_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxAppliances.SelectedIndexChanged
        'try/catch statement
        Try


            'water based appliances
            If comboBoxAppliances.Text = "Clothes Washer" Or comboBoxAppliances.Text = "Dishwasher" Or comboBoxAppliances.Text = "Ice Machine" Then
                'if a water based appliance is selected the section of the form becomes visible
                labelWaterBased.Visible = True
                labelWaterPerHour.Visible = True
                labelCostPerGallon.Visible = True
                txtWaterPerGallon.Visible = True
                txtCostPerGallon.Visible = True

            Else
                'if a water based appliance is not selected the water bbased section is not visible
                labelWaterBased.Visible = False
                labelWaterPerHour.Visible = False
                labelCostPerGallon.Visible = False
                txtWaterPerGallon.Visible = False
                txtCostPerGallon.Visible = False
                txtWaterPerGallon.Text = 0
                txtCostPerGallon.Text = 0.00
            End If
            checkAppliancekWh()
            'calls the checkNumeric() method
            checkNumeric()
            'assigning the selected appliance to a variable
            selected = comboBoxAppliances.Text.ToString
            'if all numbers are numeric call checkHours() method
            If IsNumeric(txtCost.Text) And IsNumeric(txtAppliance.Text) And IsNumeric(txtDailyHours.Text) And IsNumeric(txtCostPerGallon.Text) And IsNumeric(txtWaterPerGallon.Text) Then
                checkHours()

            End If
            'catches exceptions and outputs messages if an exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    'method for handling the cost text box
    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged


        'try/catch statement
        Try


            'makes sure there is an appliance selected before calculating
            If comboBoxAppliances.Text = "Refrigerator" Or comboBoxAppliances.Text = "TV" Or comboBoxAppliances.Text = "Space Heater" Or comboBoxAppliances.Text = "Fan" Or comboBoxAppliances.Text = "Dryer" Or comboBoxAppliances.Text = "Oven" Or comboBoxAppliances.Text = "Clothes Washer" Or comboBoxAppliances.Text = "Dishwasher" Or comboBoxAppliances.Text = "Ice Machine" Or comboBoxAppliances.Text = "None" Then

                'checks for the number to be numeric, is it is calls the checkHours() method, if not calls the checkNumeric() method
                If IsNumeric(txtCost.Text) And IsNumeric(txtAppliance.Text) And IsNumeric(txtDailyHours.Text) Then
                    'nested if statement to check if value is greater then 0
                    If txtCost.Text >= 0 Then
                        cost = Double.Parse(txtCost.Text)
                        checkHours()
                    Else
                        'displays message if it is not greater then 0 and then sets value to default
                        MessageBox.Show("The Cost must be 0 or greater")
                        txtCost.Text = "0.00"
                    End If


                Else
                    checkNumeric()
                End If
            End If
            'catches exceptions and outputs messages if an exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'method for handling the Appliance k/Wh text box
    Private Sub appliancekWh_TextChanged(sender As Object, e As EventArgs) Handles txtAppliance.TextChanged


        'try/catch statement
        Try

            'makes sure there is an appliance selected before calculating
            If comboBoxAppliances.Text = "Refrigerator" Or comboBoxAppliances.Text = "TV" Or comboBoxAppliances.Text = "Space Heater" Or comboBoxAppliances.Text = "Fan" Or comboBoxAppliances.Text = "Dryer" Or comboBoxAppliances.Text = "Oven" Or comboBoxAppliances.Text = "Clothes Washer" Or comboBoxAppliances.Text = "Dishwasher" Or comboBoxAppliances.Text = "Ice Machine" Or comboBoxAppliances.Text = "None" Then

                'checks for the number to be numeric, is it is calls the checkHours() method, if not calls the checkNumeric() method
                If IsNumeric(txtCost.Text) And IsNumeric(txtAppliance.Text) And IsNumeric(txtDailyHours.Text) Then
                    'nested if statement to check if the value is greater then 0
                    If txtAppliance.Text >= 0 Then
                        watts = Double.Parse(txtAppliance.Text)
                        checkHours()
                    Else
                        'dipslays message if not greater then 0 and then sets value to default
                        MessageBox.Show("The k/Wh must be 0 or greater")
                        txtAppliance.Text = "0"
                    End If

                Else
                    checkNumeric()

                End If
            End If
            'catches exceptions and outputs messages if an exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'method for handling the daily hours text box
    Private Sub dailyHours_TextChanged(sender As Object, e As EventArgs) Handles txtDailyHours.TextChanged


        'try/catch statement
        Try
            'makes sure there is an appliance selected before calculating
            If comboBoxAppliances.Text = "Refrigerator" Or comboBoxAppliances.Text = "TV" Or comboBoxAppliances.Text = "Space Heater" Or comboBoxAppliances.Text = "Fan" Or comboBoxAppliances.Text = "Dryer" Or comboBoxAppliances.Text = "Oven" Or comboBoxAppliances.Text = "Clothes Washer" Or comboBoxAppliances.Text = "Dishwasher" Or comboBoxAppliances.Text = "Ice Machine" Or comboBoxAppliances.Text = "None" Then

                'checks for the number to be numeric, is it is calls the checkHours() method, if not calls the checkNumeric() method
                If IsNumeric(txtCost.Text) And IsNumeric(txtAppliance.Text) And IsNumeric(txtDailyHours.Text) Then

                    hours = Double.Parse(txtDailyHours.Text)
                    checkHours()



                Else
                    checkNumeric()
                End If
            End If
            'catches exceptions and outputs messages if an exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    'handles the reset button click
    Private Sub resetToDefault_Click(sender As Object, e As EventArgs) Handles btnResetToDefault.Click
        Dim totalReset As Double = 0.00
        'resets the kwh to default
        listArray.Clear()

        listArray.Add(0)
        listArray.Add(1.1)
        listArray.Add(1.2)
        listArray.Add(1.3)
        listArray.Add(1.4)
        listArray.Add(1.5)
        listArray.Add(1.6)
        listArray.Add(1.6)
        listArray.Add(1.7)
        listArray.Add(1.8)
        'resets the combox box back to default
        comboBoxAppliances.Text = "None"
        'sets the text box values and the return text to its default values
        txtCost.Text = "0.00"
        txtAppliance.Text = "0"
        txtDailyHours.Text = "0"


        txtCostPerGallon.Text = "0.00"
        txtWaterPerGallon.Text = "0"
        txtApplianceOutput.Text = "None"
        txtCostOutput.Text = totalReset.ToString("C2")
        txtAnnualCost.Text = totalReset.ToString("C2")
        txtMonthlycost.Text = totalReset.ToString("C2")
        'clearing the list items
        listOutput.Items.Clear()



    End Sub
    'method to add items to list
    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click

        Try

            'display message if item is None
            If comboBoxAppliances.Text = "None" Then

                MessageBox.Show("An Appliance must be selected to Add it to the List")
            ElseIf Not comboBoxAppliances.Text = "None" Then
                'verifying the input is correct before adding to the list
                If IsNumeric(txtCost.Text) And IsNumeric(txtAppliance.Text) And IsNumeric(txtDailyHours.Text) And IsNumeric(txtWaterPerGallon.Text) And IsNumeric(txtCostPerGallon.Text) Then
                    hours = Double.Parse(txtDailyHours.Text)
                    checkHours()
                    'if not numeric calls the checkNumeric method
                ElseIf Not IsNumeric(txtCost.Text) And IsNumeric(txtAppliance.Text) And IsNumeric(txtDailyHours.Text) And IsNumeric(txtWaterPerGallon.Text) And IsNumeric(txtCostPerGallon.Text) Then
                    checkNumeric()



                End If
                'adds items to list
                item = listOutput.Items.Add(txtApplianceOutput.Text)


                item.SubItems.Add(txtDailyHours.Text)
                item.SubItems.Add(txtCostOutput.Text)
                item.SubItems.Add(txtMonthlycost.Text)
                item.SubItems.Add(txtAnnualCost.Text)



            End If
            'dipslays exception message if exception is thrown

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try







    End Sub

    'method to handle gallons of water
    Private Sub txtWaterPerGallon_TextChanged(sender As Object, e As EventArgs) Handles txtWaterPerGallon.TextChanged
        Try
            'conditions that validate user input
            If comboBoxAppliances.Text = "Clothes Washer" Or comboBoxAppliances.Text = "Dishwasher" Or comboBoxAppliances.Text = "Ice Machine" Then
                If IsNumeric(txtCostPerGallon.Text) And IsNumeric(txtWaterPerGallon.Text) Then
                    If txtWaterPerGallon.Text >= 0 Then
                        waterPerHour = Double.Parse(txtWaterPerGallon.Text)
                        checkHours()
                    Else
                        'message displays if value is not greater then 0
                        MessageBox.Show("The amount water must be 0 or greater")
                        txtWaterPerGallon.Text = "0"
                    End If

                Else
                    checkNumeric()

                End If
            End If
            'message displays if exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'method to handle cost per gallon
    Private Sub txtCostPerGallon_TextChanged(sender As Object, e As EventArgs) Handles txtCostPerGallon.TextChanged
        Try
            'conditions to validate user input
            If comboBoxAppliances.Text = "Clothes Washer" Or comboBoxAppliances.Text = "Dishwasher" Or comboBoxAppliances.Text = "Ice Machine" Then
                If IsNumeric(txtWaterPerGallon.Text) And IsNumeric(txtCostPerGallon.Text) Then
                    If txtCostPerGallon.Text >= 0 Then
                        waterCost = Double.Parse(txtCostPerGallon.Text)
                        checkHours()
                    Else
                        'Message displays if value is not greater then 0
                        MessageBox.Show("The Cost Per Gallon must be 0 or greater")
                        txtCostPerGallon.Text = "0.00"
                    End If


                Else
                    checkNumeric()

                End If
            End If
            'message displays if exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'method to handle the default values of the form upon loading
    Private Sub P3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TextLine As String = ""
        Dim i As Integer = 0
        Dim totalReset As Double = 0.00
        Try
            'assigning default values to form controls
            listArray.Clear()

            listArray.Add(0)
            listArray.Add(1.1)
            listArray.Add(1.2)
            listArray.Add(1.3)
            listArray.Add(1.4)
            listArray.Add(1.5)
            listArray.Add(1.6)
            listArray.Add(1.6)
            listArray.Add(1.7)
            listArray.Add(1.8)

            comboBoxAppliances.Text = "None"

            txtCost.Text = "0.00"

            txtDailyHours.Text = "0"

            listOutput.Items.Clear()
            txtCostPerGallon.Text = "0.00"
            txtWaterPerGallon.Text = "0"
            txtApplianceOutput.Text = "None"
            txtCostOutput.Text = totalReset.ToString("C2")
            txtAnnualCost.Text = totalReset.ToString("C2")
            txtMonthlycost.Text = totalReset.ToString("C2")
            Me.AllowDrop = True

            'message displays if exception is thrown
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    'methods to handle selecting the text when the user selects tab to go to the next text box
    Private Sub txtCost_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.Enter
        If (Not String.IsNullOrEmpty(txtCost.Text)) Then
            txtCost.SelectionStart = 0
            txtCost.SelectionLength = txtCost.Text.Length
        End If
    End Sub
    Private Sub txtappliance_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAppliance.Enter
        If (Not String.IsNullOrEmpty(txtAppliance.Text)) Then
            txtAppliance.SelectionStart = 0
            txtAppliance.SelectionLength = txtAppliance.Text.Length
        End If
    End Sub
    Private Sub txtWaterPerGallon_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWaterPerGallon.Enter
        If (Not String.IsNullOrEmpty(txtWaterPerGallon.Text)) Then
            txtWaterPerGallon.SelectionStart = 0
            txtWaterPerGallon.SelectionLength = txtWaterPerGallon.Text.Length
        End If
    End Sub
    Private Sub txtCostPerGallon_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostPerGallon.Enter
        If (Not String.IsNullOrEmpty(txtCostPerGallon.Text)) Then
            txtCostPerGallon.SelectionStart = 0
            txtCostPerGallon.SelectionLength = txtCostPerGallon.Text.Length
        End If
    End Sub
    Private Sub dailyHours_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDailyHours.Enter
        If (Not String.IsNullOrEmpty(txtDailyHours.Text)) Then
            txtDailyHours.SelectionStart = 0
            txtDailyHours.SelectionLength = txtDailyHours.Text.Length
        End If
    End Sub
    'displays the current kwh for each appliance
    Private Sub btnViewkWh_Click(sender As Object, e As EventArgs) Handles btnViewkWh.Click

        Try


            MessageBox.Show("None: " & listArray(0) & Environment.NewLine & "Refrigerator: " & listArray(1) & Environment.NewLine & "TV: " & listArray(2) & Environment.NewLine & "Clothes Washer" & listArray(3) & Environment.NewLine & "Space Heater: " & listArray(4) & Environment.NewLine & "Dishwasher: " & listArray(5) & Environment.NewLine & "Fan: " & listArray(6) & Environment.NewLine & "Dryer: " & listArray(7) & Environment.NewLine & "Ice Machine: " & listArray(8) & Environment.NewLine & "Oven: " & listArray(9) & Environment.NewLine)





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'button to save the list vieww to text file
    Private Sub btnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        Try
            Dim myFile As String = "Vignero_David.txt"
            Dim i As Integer

            Dim sub1 As String = ""
            'defining the save dialog and specifing certain characteristics
            With saveFile
                .Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"

                .InitialDirectory = "C:\Desktop"
                .Title = "Save File As"
                .FileName = "Vignero_David.txt"

            End With
            'opens the save dialog
            saveFile.ShowDialog()
            'this executes if the file name is not empty
            If myFile <> "" Then
                'defining StreamWriter object
                Dim myWriter As New StreamWriter(myFile)
                'looping through the list view items
                For Each myItem As ListViewItem In listOutput.Items
                    'this is used to write to the text file with the applicaiton folder
                    myWriter.WriteLine(myItem.Text & "  -  " & myItem.SubItems(1).Text & "  -  " & myItem.SubItems(2).Text & "  -  " & myItem.SubItems(3).Text & "  -  " & myItem.SubItems(4).Text)

                    listOutput.Items(i).Selected = True
                    'this is used to save each listview item to the txt file on the system using the save dialog
                    sub1 += listOutput.SelectedItems(i).Text + "  -  " + listOutput.SelectedItems(i).SubItems(1).Text + "  -  " + listOutput.SelectedItems(i).SubItems(2).Text + "  -  " + listOutput.SelectedItems(i).SubItems(3).Text + "  -  " + listOutput.SelectedItems(i).SubItems(4).Text + Environment.NewLine

                    File.WriteAllText(saveFile.FileName, sub1)
                    'incrementing the value used for the listview index
                    i += 1


                Next
                myWriter.Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'handles the drag and drop event
    Private Sub P4_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop


        Dim TextLine As String = ""
        Dim i As Integer = 0
        'this code takes the path of the file and reads the file that is dropped on the form

        Try
            'clearing arraylist
            listArray.Clear()
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each path In files

                Dim sr As New System.IO.StreamReader(path)
                Do While sr.Peek() >= 0
                    'adding items to arraylist
                    listArray.Add(sr.ReadLine())
                    i += 1
                Loop

            Next
            'calling this method after the file is read
            checkAppliancekWh()


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    'handle drag and drop effect
    Private Sub P4_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy

        End If
    End Sub


End Class

