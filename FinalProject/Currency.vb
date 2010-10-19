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

' Enumeration for the Currency class. Defines the rules for the existing currency types.
Public Enum eCurrency
    American = 0
    Canadian = 1
    Mexican = 2
    English = 3
    Japanese = 4
    French = 5
End Enum

' This class handles the major routines for converting currency from one form to another.
' @method   getInstance     Gets a static instance of this class.
' @method   sanityCheck     Validates input and verifies that we will be calculating gracefully
' @method   Calculate       Executes the calculations and returns the result
Public Class Currency
    ' The target currency type
    Public target As eCurrency = 0
    ' The source currency type
    Public source As eCurrency = 0

    ' Static instance of this class to make it a singleton
    Protected Shared _instance As Currency

    ' Gets this static instance of this currency class
    Public Shared Function getInstance() As Currency
        If (IsNothing(Currency._instance)) Then
            Currency._instance = New Currency()
        End If
        Return Currency._instance
    End Function

    ' Gets the conversion rate for a specific currency type
    ' @param    type        The currency type to obtain the rate
    ' @return               The conversion rate to apply
    ' @Notes    1 USD = 1.4680      Canadian $
    '           1 USD = 9.5085      Mexican Pesos
    '           1 USD = 0.6085      English Pounds
    '           1 USD = 104.9200    Japanese Yen
    '           1 USD = 6.2561      French Francs
    Public Function conversionRate(ByVal type As eCurrency) As Decimal
        Select Case type
            Case eCurrency.American
                Return 1
            Case eCurrency.Canadian
                Return 1.468
            Case eCurrency.English
                Return 0.6085
            Case eCurrency.French
                Return 6.2561
            Case eCurrency.Mexican
                Return 9.5085
            Case eCurrency.Japanese
                Return 104.92
            Case Else
                Return -1
        End Select
    End Function

    ' Performs checks against the user input to ensure the data is in the correct format
    ' @return   Boolean     TRUE if the check passes; FALSE if the check fails
    Public Function sanityCheck(ByVal dollars As Decimal) As Boolean
        ' If the target currency type isn't one defined by the enumeration
        ' Then throw an error message to the user, and invalidate this check.
        If ((Me.target >= 6) Or (Me.target < 0)) Then
            FinalProject.notice_log( _
                "WARNING: The target currency is not a valid type." & vbNewLine & _
                "Please select a valid value from the select box above." _
            )
            Return False
        End If
        ' If the source currency type isn't one defined by the enumeration
        ' Then throw an error message to the user, and invalidate this check.
        If ((Me.source >= 6) Or (Me.source < 0)) Then
            FinalProject.notice_log( _
                "WARNING: The source currency is not a valid type." & vbNewLine & _
                "Please select a valid value from the select box above." _
            )
            Return False
        End If
        ' If the dollar amount is less than zero, then invalidate this check and
        ' notify the end-user.
        If (dollars <= 0) Then
            FinalProject.notice_log( _
                "ERROR: The dollar amount is not valid." & vbNewLine & _
                "Please enter a valid dollar amount greater than zero(0)." _
            )
            Return False
        End If
        Return True
    End Function

    ' Converts a textual representation of a currency to an instance of eCurrency
    ' @param text   The human-readable text to convert
    ' @return       The eCurrency value of the text
    Public Function text2eCurrency(ByVal text As String) As eCurrency
        Select Case text.ToLower()
            Case "american"
                Return eCurrency.American
            Case "canadian"
                Return eCurrency.Canadian
            Case "mexican"
                Return eCurrency.Mexican
            Case "english"
                Return eCurrency.English
            Case "japanese"
                Return eCurrency.Japanese
            Case "french"
                Return eCurrency.French
            Case Else
                Return -1
        End Select
    End Function

    ' Calculates the conversion of the currency
    ' @param    dollars      The value to calculate
    ' @return                The converted value. Returns >0 on error.
    Public Function Calculate(ByVal dollars As Decimal) As Decimal
        ' Define a local variable to hold the conversion rate
        Dim _rate As Decimal = 0
        ' If the sanity checks pass
        If (Me.sanityCheck(dollars)) Then
            ' Check to make sure the source currency is different from the target currency
            If (Me.source = Me.target) Then
                ' Return the dollar amount instead of throwing an error to handle the results
                ' more gracefully.
                Return dollars
            End If
            ' Get the conversion rate for the source currency type and divide it by the target
            ' conversion rate. This is an effective way to find the conversion rate between
            ' currencies without generating a massive SelectCase block that finds out the source
            ' and target conversion rates. Mathematically speaking, any conversion factor can
            ' be used here, and the result will be accurate as long as the conversion rates are
            ' accurate between the USD and the other currency types.
            _rate = Me.conversionRate(Me.source) / Me.conversionRate(Me.target)
            ' Return the rate multiplied by the dollar amount.
            Return dollars * _rate
        Else
            ' Return an error if we couldn't properly validate the data.
            Return -1
        End If
    End Function
End Class
