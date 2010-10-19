'This file is part of CurrencyConversion. 
'
'CurrencyConversion is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'CurrencyConversion is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with CurrencyConversion.  If not, see <http://www.gnu.org/licenses/>.
'
'Copyright Markizano Draconus <markizano@markizano.net> http://markizano.net/
'

' Main window controller for handling events.
Public Class FinalProject
    Inherits Windows.Forms.Form
    Public Currency As Currency

    ' Handles intput/output to the label in the form.
    ' Notifies the user of changes in the application, error messages and
    ' results of the calculation
    Public Sub notice_log(ByVal message As String)
        Me.lbNotice.Text = message
    End Sub

    ' Handles the click even for when the calculate button is clicked.
    Private Sub cmdCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalc.Click
        Me.notice_log("")
        Me.Currency.source = Me.Currency.text2eCurrency(Me.cboSource.Text)
        Me.Currency.target = Me.Currency.text2eCurrency(Me.cboTarget.Text)
        If (Me.txtAmount.Text = "") Then
            Me.notice_log("Please enter an amount to convert!")
        Else
            Me.txtResult.Text = Math.Round(Me.Currency.Calculate(Convert.ToInt32(Me.txtAmount.Text)), 3).ToString()
        End If
    End Sub

    ' When the form loads, clear the three dots in the notice label.
    Private Sub FinalProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbNotice.Text = ""
        Me.Currency = New Currency()
    End Sub

    ' Attempts to test the input/output values of the conversion to
    ' ensure the application calculates the rates appropriately.
    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim myTest As ConvertTest
        myTest = New ConvertTest()
        myTest.CalculateTest()
    End Sub

    Private Sub txtAmount_keyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyUp
        e.Handled = False
        If (e.KeyCode = 10 Or e.KeyCode = 13) Then
            Me.cmdCalc_Click(sender, e)
            e.Handled = True
        End If
    End Sub
End Class
