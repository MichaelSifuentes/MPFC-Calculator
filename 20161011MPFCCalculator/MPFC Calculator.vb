Imports System.IO

Public Class FrmMPFC

    Private testsTotal As Integer = 0
    Private vehiclesTotal As Integer = 0
    Private milesTotal As Integer = 0
    Private cellsTotal As Integer = 0
    Private costsTotal As Double = 0
    Private FuelCellCost As Integer = 22.0
    Private mileageMultiplier As Double = 0
    Private EM1 As Integer = 0
    Private EM2 As Integer = 0
    Private EM3 As Integer = 0
    Private EM4 As Integer = 0


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is TextBox Then
                TryCast(ctrl, TextBox).Clear()
            ElseIf TypeOf (ctrl) Is ComboBox Then
                TryCast(ctrl, ComboBox).SelectedIndex = -1
            End If
            txtTest.Clear()
            txtDate.Clear()
            txtInventorFirst.Clear()
            txtInventorLast.Clear()
            cmoDriverID.SelectedIndex = -1
        Next
    End Sub

    Private Sub btnAllTests_Click(sender As Object, e As EventArgs) Handles btnAllTests.Click
        Dim strMessage As String = "Number of Tests: " & FormatNumber(testsTotal, 0) & vbCrLf
        strMessage &= "Vehicles Tested: " & FormatNumber(vehiclesTotal, 0) & vbCrLf & vbCrLf
        strMessage &= "Total Miles Traveled: " & FormatNumber(milesTotal, 0) & vbCrLf
        strMessage &= "Total Fuel Cells Used: " & FormatNumber(cellsTotal, 0) & vbCrLf
        strMessage &= "Total Costs: " & FormatCurrency(costsTotal) & vbCrLf
        frmSummary.rtxtSummary.Text = strMessage
        frmSummary.Show()
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim errorFound As Boolean = False
        Dim MPFC1, MPFC2, MPFC3, MPFC4 As Double
        Dim M1, M2, M3, M4 As Integer
        Dim FU1, FU2, FU3, FU4 As Integer
        Dim FC1, FC2, FC3, FC4 As Integer
        Dim errMessage As String = "We found the following errors: " & vbCrLf

        'validation for test number
        If Not IsNumeric(txtTest.Text) Then
            errMessage &= "Test Number must be numeric" & vbCrLf
            errorFound = True
        ElseIf String.IsNullOrEmpty(txtTest.Text) Then
            errMessage &= "Enter A Test Number" & vbCrLf
            errorFound = True
        ElseIf txtTest.Text <= 0 Then
            errMessage &= "Test Number must be a positive integer" & vbCrLf
            errorFound = True
        ElseIf txtTest.Text <> Int(txtTest.Text) Then
            errMessage &= "Test Number cannot be a decimal" & vbCrLf
            errorFound = True
        ElseIf txtTest.Text > 4 Then
            errMessage &= "Test Number cannot be greater than 4" & vbCrLf
            errorFound = True
        End If
        'validation for date
        If String.IsNullOrEmpty(txtDate.Text) Then
            errMessage &= "Date field is empty" & vbCrLf
            errorFound = True
        ElseIf Not IsDate(txtDate.Text) Then
            errMessage &= "Wrong Date Format" & vbCrLf
            errorFound = True
        ElseIf txtDate.Text <> Date.Today Then
            errMessage &= "Enter today's Date" & vbCrLf
            errorFound = True
        End If
        'validation for inventor's first name
        If String.IsNullOrEmpty(txtInventorFirst.Text) Then
            errMessage &= "Inventor's first name field is empty" & vbCrLf
            errorFound = True
        ElseIf IsNumeric(txtInventorFirst.Text) Then
            errMessage &= "First name must not contain numbers" & vbCrLf
            errorFound = True
        End If
        'validation for inventor's last name
        If String.IsNullOrEmpty(txtInventorLast.Text) Then
            errMessage &= "Inventor's last name field is empty" & vbCrLf
            errorFound = True
        ElseIf IsNumeric(txtInventorLast.Text) Then
            errMessage &= "Inventor's last name must not contain numberes" & vbCrLf
            errorFound = True
        End If
        'validation for Driver's ID
        If String.IsNullOrEmpty(cmoDriverID.Text) Then
            errMessage &= "Select a Drivers ID" & vbCrLf
            errorFound = True
        End If
        'validation for tested Vehicles
        If String.IsNullOrEmpty(cmoDV1.Text) Then
            errMessage &= "Select vehicle 1 to test" & vbCrLf
            errorFound = True
        End If
        If String.IsNullOrEmpty(cmoDV2.Text) Then
            errMessage &= "Select vehicle 2 to test" & vbCrLf
            errorFound = True
        End If
        If String.IsNullOrEmpty(cmoDV3.Text) Then
            errMessage &= "Select vehicle 3 to test" & vbCrLf
            errorFound = True
        End If
        If String.IsNullOrEmpty(cmoDV4.Text) Then
            errMessage &= "Select vehicle 4 to test" & vbCrLf
            errorFound = True
        End If

        'Validates data
        If String.IsNullOrEmpty(txtDSM1.Text) Then
            errMessage &= "Invalid Start Mileage For Data row 1" & vbCrLf
            errorFound = True
        ElseIf txtDSM1.Text <= 0 Then
            errMessage &= "Start Mileage for row 1 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDSM1.Text) Then
            errMessage &= "Start Mileage for row 1 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDSM1.Text <> Int(txtDSM1.Text) Then
            errMessage &= "Start Mileage for row 1 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDSM2.Text) Then
            errMessage &= "Invalid Start Mileage For Data row 2" & vbCrLf
            errorFound = True
        ElseIf txtDSM2.Text <= 0 Then
            errMessage &= "Start Mileage for row 2 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDSM2.Text) Then
            errMessage &= "Start Mileage for row 2 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDSM2.Text <> Int(txtDSM2.Text) Then
            errMessage &= "Start Mileage for row 2 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDSM3.Text) Then
            errMessage &= "Invalid Start Mileage For Data row 3" & vbCrLf
            errorFound = True
        ElseIf txtDSM3.Text <= 0 Then
            errMessage &= "Start Mileage for row 3 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDSM3.Text) Then
            errMessage &= "Start Mileage for row 3 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDSM3.Text <> Int(txtDSM3.Text) Then
            errMessage &= "Start Mileage for row 3 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDSM4.Text) Then
            errMessage &= "Invalid Start Mileage For Data row 4" & vbCrLf
            errorFound = True
        ElseIf txtDSM4.Text <= 0 Then
            errMessage &= "Start Mileage for row 4 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDSM4.Text) Then
            errMessage &= "Start Mileage for row 4 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDSM4.Text <> Int(txtDSM4.Text) Then
            errMessage &= "Start Mileage for row 4 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDEM1.Text) Then
            errMessage &= "Invalid End Mileage For Data row 1" & vbCrLf
            errorFound = True
        ElseIf txtDEM1.Text <= 0 Then
            errMessage &= "End Mileage for row 1 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDEM1.Text) Then
            errMessage &= "End Mileage for row 1 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDEM1.Text <> Int(txtDEM1.Text) Then
            errMessage &= "End Mileage for row 1 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDEM2.Text) Then
            errMessage &= "Invalid End Mileage For Data row 2" & vbCrLf
            errorFound = True
        ElseIf txtDEM2.Text <= 0 Then
            errMessage &= "End Mileage for row 2 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDEM2.Text) Then
            errMessage &= "End Mileage for row 2 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDEM2.Text <> Int(txtDEM2.Text) Then
            errMessage &= "End Mileage for row 2 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDEM3.Text) Then
            errMessage &= "Invalid End Mileage For Data row 3" & vbCrLf
            errorFound = True
        ElseIf txtDEM3.Text <= 0 Then
            errMessage &= "End Mileage for row 3 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDEM3.Text) Then
            errMessage &= "End Mileage for row 3 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDEM3.Text <> Int(txtDEM3.Text) Then
            errMessage &= "End Mileage for row 3 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDEM4.Text) Then
            errMessage &= "Invalid End Mileage For Data row 4" & vbCrLf
            errorFound = True
        ElseIf txtDEM4.Text <= 0 Then
            errMessage &= "End Mileage for row 4 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDEM4.Text) Then
            errMessage &= "End Mileage for row 4 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDEM4.Text <> Int(txtDEM4.Text) Then
            errMessage &= "End Mileage for row 4 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDSF1.Text) Then
            errMessage &= "Invalid Start Fuel For Data row 1" & vbCrLf
            errorFound = True
        ElseIf txtDSF1.Text <= 0 Then
            errMessage &= "Start Fuel for row 1 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDSF1.Text) Then
            errMessage &= "Start Fuel for row 1 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDSF1.Text <> Int(txtDSF1.Text) Then
            errMessage &= "Start fuel for row 1 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDSF2.Text) Then
            errMessage &= "Invalid Start Fuel For Data row 2" & vbCrLf
            errorFound = True
        ElseIf txtDSF2.Text <= 0 Then
            errMessage &= "Start Fuel for row 2 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDSF2.Text) Then
            errMessage &= "Start Fuel for row 2 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDSF2.Text <> Int(txtDSF2.Text) Then
            errMessage &= "Start fuel for row 2 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDSF3.Text) Then
            errMessage &= "Invalid Start Fuel For Data row 3" & vbCrLf
            errorFound = True
        ElseIf txtDSF3.Text <= 0 Then
            errMessage &= "Start Fuel for row 3 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDSF3.Text) Then
            errMessage &= "Start Fuel for row 3 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDSF3.Text <> Int(txtDSF3.Text) Then
            errMessage &= "Start fuel for row 3 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDSF4.Text) Then
            errMessage &= "Invalid Start Fuel For Data row 4" & vbCrLf
            errorFound = True
        ElseIf txtDSF4.Text <= 0 Then
            errMessage &= "Start Fuel for row 4 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDSF4.Text) Then
            errMessage &= "Start Fuel for row 4 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDSF4.Text <> Int(txtDSF4.Text) Then
            errMessage &= "Start fuel for row 4 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDEF1.Text) Then
            errMessage &= "Invalid End Fuel For Data Row 1" & vbCrLf
            errorFound = True
        ElseIf txtDEF1.Text <= 0 Then
            errMessage &= "End Fuel for row 1 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDEF1.Text) Then
            errMessage &= "End Fuel for row 1 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDEF1.Text <> Int(txtDEF1.Text) Then
            errMessage &= "End fuel for row 1 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDEF2.Text) Then
            errMessage &= "Invalid End Fuel For Data Row 2" & vbCrLf
            errorFound = True
        ElseIf txtDEF2.Text <= 0 Then
            errMessage &= "End Fuel for row 2 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDEF2.Text) Then
            errMessage &= "End Fuel for row 2 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDEF2.Text <> Int(txtDEF2.Text) Then
            errMessage &= "End fuel for row 2 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDEF3.Text) Then
            errMessage &= "Invalid End Fuel For Data row 3" & vbCrLf
            errorFound = True
        ElseIf txtDEF3.Text <= 0 Then
            errMessage &= "End Fuel for row 3 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDEF3.Text) Then
            errMessage &= "End Fuel for row 3 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDEF3.Text <> Int(txtDEF3.Text) Then
            errMessage &= "End fuel for row 3 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If String.IsNullOrEmpty(txtDEF4.Text) Then
            errMessage &= "Invalid End Fuel For Data row 4" & vbCrLf
            errorFound = True
        ElseIf txtDEF4.Text <= 0 Then
            errMessage &= "End Fuel for row 4 must be greater than 0" & vbCrLf
            errorFound = True
        ElseIf Not IsNumeric(txtDEF4.Text) Then
            errMessage &= "End Fuel for row 4 must only contain numbers" & vbCrLf
            errorFound = True
        ElseIf txtDEF4.Text <> Int(txtDEF4.Text) Then
            errMessage &= "End fuel for row 4 must not contain a decimal" & vbCrLf
            errorFound = True
        End If

        If errorFound = True Then
            MessageBox.Show(errMessage, "Errors")
            Exit Sub
        End If

        'Displays results for vehicles
        txtRV1.Text = cmoDV1.SelectedItem
        txtRV2.Text = cmoDV2.SelectedItem
        txtRV3.Text = cmoDV3.SelectedItem
        txtRV4.Text = cmoDV4.SelectedItem

        'Displays results for vehicle family
        If cmoDV1.SelectedItem = "Banshee" Or cmoDV1.SelectedItem = "Ghost" Or cmoDV1.SelectedItem = "Chopper" Then
            txtRF1.Text = "Covenant"
        ElseIf cmoDV1.SelectedItem = "Hornet" Then
            txtRF1.Text = "U.N.S.C."
        End If
        If cmoDV2.SelectedItem = "Banshee" Or cmoDV2.SelectedItem = "Ghost" Or cmoDV2.SelectedItem = "Chopper" Then
            txtRF2.Text = "Covenant"
        ElseIf cmoDV2.SelectedItem = "Hornet" Then
            txtRF2.Text = "U.N.S.C."
        End If
        If cmoDV3.SelectedItem = "Banshee" Or cmoDV3.SelectedItem = "Ghost" Or cmoDV3.SelectedItem = "Chopper" Then
            txtRF3.Text = "Covenant"
        ElseIf cmoDV3.SelectedItem = "Hornet" Then
            txtRF3.Text = "U.N.S.C."
        End If
        If cmoDV4.SelectedItem = "Banshee" Or cmoDV4.SelectedItem = "Ghost" Or cmoDV4.SelectedItem = "Chopper" Then
            txtRF4.Text = "Covenant"
        ElseIf cmoDV4.SelectedItem = "Hornet" Then
            txtRF4.Text = "U.N.S.C."
        End If

        'Calculates and displays results for Mileage
        M1 = txtDEM1.Text - txtDSM1.Text
        txtRM1.Text = M1
        M2 = txtDEM2.Text - txtDSM2.Text
        txtRM2.Text = M2
        M3 = txtDEM3.Text - txtDSM3.Text
        txtRM3.Text = M3
        M4 = txtDEM4.Text - txtDSM4.Text
        txtRM4.Text = M4

        'Calculates and displays Results for Fuel Used
        FU1 = txtDSF1.Text - txtDEF1.Text
        txtRFU1.Text = FU1
        FU2 = txtDSF2.Text - txtDEF2.Text
        txtRFU2.Text = FU2
        FU3 = txtDSF3.Text - txtDEF3.Text
        txtRFU3.Text = FU3
        FU4 = txtDSF4.Text - txtDEF4.Text
        txtRFU4.Text = FU4

        'Calculates and displays Results for Fuel Cost 
        '(Fuel Cells Consumed * Cost Per Fuel Cell)
        FC1 = txtRFU1.Text * FuelCellCost
        txtRFC1.Text = FormatCurrency(FC1)
        FC2 = txtRFU2.Text * FuelCellCost
        txtRFC2.Text = FormatCurrency(FC2)
        FC3 = txtRFU3.Text * FuelCellCost
        txtRFC3.Text = FormatCurrency(FC3)
        FC4 = txtRFU4.Text * FuelCellCost
        txtRFC4.Text = FormatCurrency(FC4)

        'Calculates MPFC = (Number of Miles Traveled / Fuel Cells Consumed)
        MPFC1 = txtRM1.Text / txtRFU1.Text
        MPFC2 = txtRM2.Text / txtRFU2.Text
        MPFC3 = txtRM3.Text / txtRFU3.Text
        MPFC4 = txtRM4.Text / txtRFU4.Text
        'Determines and displays MPFC Rating
        'MPFC is less than 200 then the rating is “Guzzler”
        'MPFC is Between 200 and 300 then the rating is “Economical”
        'MPFC is More than 300 MPFC then the rating is “Amazing!!”
        If MPFC1 < 200 Then
            txtRMPFCR1.Text = "Guzzler"
        ElseIf MPFC1 > 200 And MPFC1 < 300 Then
            txtRMPFCR1.Text = "Economical"
        ElseIf MPFC1 > 300 Then
            txtRMPFCR1.Text = "Amazing!!"
        End If
        If MPFC2 < 200 Then
            txtRMPFCR2.Text = "Guzzler"
        ElseIf MPFC2 > 200 And MPFC2 < 300 Then
            txtRMPFCR2.Text = "Economical"
        ElseIf MPFC2 > 300 Then
            txtRMPFCR2.Text = "Amazing!!"
        End If
        If MPFC3 < 200 Then
            txtRMPFCR3.Text = "Guzzler"
        ElseIf MPFC3 > 200 And MPFC3 < 300 Then
            txtRMPFCR3.Text = "Economical"
        ElseIf MPFC3 > 300 Then
            txtRMPFCR3.Text = "Amazing!!"
        End If
        If MPFC4 < 200 Then
            txtRMPFCR4.Text = "Guzzler"
        ElseIf MPFC4 > 200 And MPFC4 < 300 Then
            txtRMPFCR4.Text = "Economical"
        ElseIf MPFC4 > 300 Then
            txtRMPFCR4.Text = "Amazing!!"
        End If

        'Calcualates for summary
        testsTotal += 1
        vehiclesTotal += 4
        milesTotal = M1 + M2 + M3 + M4
        cellsTotal = FU1 + FU2 + FU3 + FU4
        costsTotal = FC1 + FC2 + FC3 + FC4
    End Sub

    Private Sub cmoDriverID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmoDriverID.SelectedIndexChanged
        Select Case cmoDriverID.SelectedItem
            Case "100"
                txtDriverFirst.Text = "Bart"
                txtDriverLast.Text = "Simpson"
                txtDriverPhone.Text = "909-888-7777"
                picDriver.Image = Image.FromFile(Directory.GetCurrentDirectory() & "\images\" & txtDriverFirst.Text & ".png")
            Case "200"
                txtDriverFirst.Text = "Homer"
                txtDriverLast.Text = "Simpson"
                txtDriverPhone.Text = "909-666-5555"
                picDriver.Image = Image.FromFile(Directory.GetCurrentDirectory() & "\images\" & txtDriverFirst.Text & ".png")
            Case "300"
                txtDriverFirst.Text = "Marge"
                txtDriverLast.Text = "Simpson"
                txtDriverPhone.Text = "909-111-3333"
                picDriver.Image = Image.FromFile(Directory.GetCurrentDirectory() & "\images\" & txtDriverFirst.Text & ".png")
            Case "400"
                txtDriverFirst.Text = "Lisa"
                txtDriverLast.Text = "Simpson"
                txtDriverPhone.Text = "909-333-6666"
                picDriver.Image = Image.FromFile(Directory.GetCurrentDirectory() & "\images\" & txtDriverFirst.Text & ".png")
            Case Else
                txtDriverFirst.Clear()
                txtDriverLast.Clear()
                txtDriverPhone.Clear()
                picDriver.Image = Nothing
        End Select
    End Sub

    Private Sub cmoDV1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmoDV1.SelectedIndexChanged
        Select Case cmoDriverID.SelectedItem
            Case "100"
                mileageMultiplier = 0
            Case "200"
                mileageMultiplier = 0.1
            Case "300"
                mileageMultiplier = 0.2
            Case "400"
                mileageMultiplier = 0.3
        End Select
        Select Case cmoDV1.SelectedItem
            Case "Banshee"
                txtDSM1.Text = "12537"
                EM1 = 302512 + (302512 * mileageMultiplier)
                txtDEM1.Text = EM1
                txtDSF1.Text = "5000"
                txtDEF1.Text = "1000"
            Case "Ghost"
                txtDSM1.Text = "12537"
                EM1 = 502500 + (502500 * mileageMultiplier)
                txtDEM1.Text = EM1
                txtDSF1.Text = "4000"
                txtDEF1.Text = "2200"
            Case "Chopper"
                txtDSM1.Text = "12537"
                EM1 = 499937 + (49937 * mileageMultiplier)
                txtDEM1.Text = EM1
                txtDSF1.Text = "4000"
                txtDEF1.Text = "2000"
            Case "Hornet"
                txtDSM1.Text = "12537"
                EM1 = 2092537 + (2092537 * mileageMultiplier)
                txtDEM1.Text = EM1
                txtDSF1.Text = "6000"
                txtDEF1.Text = "1000"
        End Select
    End Sub

    Private Sub cmoDV2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmoDV2.SelectedIndexChanged
        Select Case cmoDriverID.SelectedItem
            Case "100"
                mileageMultiplier = 0
            Case "200"
                mileageMultiplier = 0.1
            Case "300"
                mileageMultiplier = 0.2
            Case "400"
                mileageMultiplier = 0.3
        End Select
        Select Case cmoDV2.SelectedItem
            Case "Banshee"
                txtDSM2.Text = "12537"
                EM2 = 302512 + (302512 * mileageMultiplier)
                txtDEM2.Text = EM2
                txtDSF2.Text = "5000"
                txtDEF2.Text = "1000"
            Case "Ghost"
                txtDSM2.Text = "12537"
                EM2 = 502500 + (502500 * mileageMultiplier)
                txtDEM2.Text = EM2
                txtDSF2.Text = "4000"
                txtDEF2.Text = "2200"
            Case "Chopper"
                txtDSM2.Text = "12537"
                EM2 = 499937 + (499937 * mileageMultiplier)
                txtDEM2.Text = EM2
                txtDSF2.Text = "4000"
                txtDEF2.Text = "2000"
            Case "Hornet"
                txtDSM2.Text = "12537"
                EM2 = 2092537 + (2092537 * mileageMultiplier)
                txtDEM2.Text = EM2
                txtDSF2.Text = "6000"
                txtDEF2.Text = "1000"
        End Select
    End Sub

    Private Sub cmoDV3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmoDV3.SelectedIndexChanged
        Select Case cmoDriverID.SelectedItem
            Case "100"
                mileageMultiplier = 0
            Case "200"
                mileageMultiplier = 0.1
            Case "300"
                mileageMultiplier = 0.2
            Case "400"
                mileageMultiplier = 0.3
        End Select
        Select Case cmoDV3.SelectedItem
            Case "Banshee"
                txtDSM3.Text = "12537"
                EM3 = 302512 + (302512 * mileageMultiplier)
                txtDEM3.Text = EM3
                txtDSF3.Text = "5000"
                txtDEF3.Text = "1000"
            Case "Ghost"
                txtDSM3.Text = "12537"
                EM3 = 502500 + (502500 * mileageMultiplier)
                txtDEM3.Text = EM3
                txtDSF3.Text = "4000"
                txtDEF3.Text = "2200"
            Case "Chopper"
                txtDSM3.Text = "12537"
                EM3 = 499937 + (499937 * mileageMultiplier)
                txtDEM3.Text = EM3
                txtDSF3.Text = "4000"
                txtDEF3.Text = "2000"
            Case "Hornet"
                txtDSM3.Text = "12537"
                EM3 = 2092537 + (2092537 * mileageMultiplier)
                txtDEM3.Text = EM3
                txtDSF3.Text = "6000"
                txtDEF3.Text = "1000"
        End Select
    End Sub

    Private Sub cmoDV4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmoDV4.SelectedIndexChanged
        Select Case cmoDriverID.SelectedItem
            Case "100"
                mileageMultiplier = 0
            Case "200"
                mileageMultiplier = 0.1
            Case "300"
                mileageMultiplier = 0.2
            Case "400"
                mileageMultiplier = 0.3
        End Select
        Select Case cmoDV4.SelectedItem
            Case "Banshee"
                txtDSM4.Text = "12537"
                EM4 = 302512 + (302512 * mileageMultiplier)
                txtDEM4.Text = EM4
                txtDSF4.Text = "5000"
                txtDEF4.Text = "1000"
            Case "Ghost"
                txtDSM4.Text = "12537"
                EM4 = 502500 + (502500 * mileageMultiplier)
                txtDEM4.Text = EM4
                txtDSF4.Text = "4000"
                txtDEF4.Text = "2200"
            Case "Chopper"
                txtDSM4.Text = "12537"
                EM4 = 499937 + (499937 * mileageMultiplier)
                txtDEM4.Text = EM4
                txtDSF4.Text = "4000"
                txtDEF4.Text = "2000"
            Case "Hornet"
                txtDSM4.Text = "12537"
                EM4 = 2092537 + (2092537 * mileageMultiplier)
                txtDEM4.Text = EM4
                txtDSF4.Text = "6000"
                txtDEF4.Text = "1000"
        End Select
    End Sub

    Private Sub FrmMPFC_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtDate.Text = Date.Today
        txtTest.Focus()
    End Sub
End Class
