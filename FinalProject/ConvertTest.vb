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

' Handles the tests necessary to ensure the values of the test class execute appropriately.
Public Class ConvertTest

    ' Keep a local currency object for easier manipulation across the class.
    Protected _currency As Currency

    ' USD -> CAN test values
    Private USD2CAN(9) As Decimal
    ' CAN -> USD test values
    Private CAN2USD(9) As Decimal

    ' USD -> MEX test values
    Private USD2MEX(9) As Decimal
    ' MEX -> USD test values
    Private MEX2USD(9) As Decimal

    ' USD -> ENG test values
    Private USD2ENG(9) As Decimal
    ' ENG -> USD test values
    Private ENG2USD(9) As Decimal

    ' USD -> JAP test values
    Private USD2JAP(9) As Decimal
    ' JAP -> USD test values
    Private JAP2USD(9) As Decimal

    ' USD -> FRC test values
    Private USD2FRC(9) As Decimal
    ' FRC -> USD test values
    Private FRC2USD(9) As Decimal

    ' When this class is instantiated, assign a static instance of the currency class,
    ' Assign the test values to the associated arrays, and instantiate the class
    Public Sub New()
        Me._currency = Currency.getInstance()
        Me.CAN2USD(0) = 1.47
        Me.CAN2USD(1) = 2.94
        Me.CAN2USD(2) = 4.4
        Me.CAN2USD(3) = 5.87
        Me.CAN2USD(4) = 7.34
        Me.CAN2USD(5) = 8.81
        Me.CAN2USD(6) = 10.28
        Me.CAN2USD(7) = 11.74
        Me.CAN2USD(8) = 13.21
        Me.CAN2USD(9) = 14.68
        Me.USD2CAN(0) = 0.68
        Me.USD2CAN(1) = 1.36
        Me.USD2CAN(2) = 2.04
        Me.USD2CAN(3) = 2.72
        Me.USD2CAN(4) = 3.41
        Me.USD2CAN(5) = 4.09
        Me.USD2CAN(6) = 4.77
        Me.USD2CAN(7) = 5.45
        Me.USD2CAN(8) = 6.13
        Me.USD2CAN(9) = 6.81

        Me.MEX2USD(0) = 9.51
        Me.MEX2USD(1) = 19.02
        Me.MEX2USD(2) = 28.53
        Me.MEX2USD(3) = 38.03
        Me.MEX2USD(4) = 47.54
        Me.MEX2USD(5) = 57.05
        Me.MEX2USD(6) = 66.56
        Me.MEX2USD(7) = 76.07
        Me.MEX2USD(8) = 85.58
        Me.MEX2USD(9) = 95.08
        Me.USD2MEX(0) = 0.11
        Me.USD2MEX(1) = 0.21
        Me.USD2MEX(2) = 0.32
        Me.USD2MEX(3) = 0.42
        Me.USD2MEX(4) = 0.53
        Me.USD2MEX(5) = 0.63
        Me.USD2MEX(6) = 0.74
        Me.USD2MEX(7) = 0.84
        Me.USD2MEX(8) = 0.95
        Me.USD2MEX(9) = 1.05

        Me.ENG2USD(0) = 0.61
        Me.ENG2USD(1) = 1.22
        Me.ENG2USD(2) = 1.83
        Me.ENG2USD(3) = 2.43
        Me.ENG2USD(4) = 3.04
        Me.ENG2USD(5) = 3.65
        Me.ENG2USD(6) = 4.26
        Me.ENG2USD(7) = 4.87
        Me.ENG2USD(8) = 5.48
        Me.ENG2USD(9) = 6.08
        Me.USD2ENG(0) = 1.64
        Me.USD2ENG(1) = 3.29
        Me.USD2ENG(2) = 4.93
        Me.USD2ENG(3) = 6.57
        Me.USD2ENG(4) = 8.22
        Me.USD2ENG(5) = 9.86
        Me.USD2ENG(6) = 11.5
        Me.USD2ENG(7) = 13.15
        Me.USD2ENG(8) = 14.79
        Me.USD2ENG(9) = 16.43

        Me.JAP2USD(0) = 104.92
        Me.JAP2USD(1) = 209.84
        Me.JAP2USD(2) = 314.76
        Me.JAP2USD(3) = 419.68
        Me.JAP2USD(4) = 524.6
        Me.JAP2USD(5) = 629.52
        Me.JAP2USD(6) = 734.44
        Me.JAP2USD(7) = 839.36
        Me.JAP2USD(8) = 944.28
        Me.JAP2USD(9) = 1049.2
        Me.USD2JAP(0) = 0.01
        Me.USD2JAP(1) = 0.02
        Me.USD2JAP(2) = 0.03
        Me.USD2JAP(3) = 0.04
        Me.USD2JAP(4) = 0.05
        Me.USD2JAP(5) = 0.06
        Me.USD2JAP(6) = 0.07
        Me.USD2JAP(7) = 0.08
        Me.USD2JAP(8) = 0.09
        Me.USD2JAP(9) = 0.1

        Me.FRC2USD(0) = 6.26
        Me.FRC2USD(1) = 12.51
        Me.FRC2USD(2) = 18.77
        Me.FRC2USD(3) = 25.02
        Me.FRC2USD(4) = 31.28
        Me.FRC2USD(5) = 37.54
        Me.FRC2USD(6) = 43.79
        Me.FRC2USD(7) = 50.05
        Me.FRC2USD(8) = 56.3
        Me.FRC2USD(9) = 62.56
        Me.USD2FRC(0) = 0.16
        Me.USD2FRC(1) = 0.32
        Me.USD2FRC(2) = 0.48
        Me.USD2FRC(3) = 0.64
        Me.USD2FRC(4) = 0.8
        Me.USD2FRC(5) = 0.96
        Me.USD2FRC(6) = 1.12
        Me.USD2FRC(7) = 1.28
        Me.USD2FRC(8) = 1.44
        Me.USD2FRC(9) = 1.6
    End Sub

    ' Conversion table for the Canadian currency
    ' @return   Boolean     TRUE if the tests pass; FALSE if they fail
    Public Function CanadianTests() As Boolean
        Dim result As Decimal
        ' Test the conversions from USD to CAN
        Me._currency.source = eCurrency.American
        Me._currency.target = eCurrency.Canadian
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.USD2CAN(i), _
                "Warning: Expected Result(" & Me.USD2CAN(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For USD2CAN" _
            )
        Next
        ' Test the convesion from CAN to USD
        Me._currency.source = eCurrency.Canadian
        Me._currency.target = eCurrency.American
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.CAN2USD(i), _
                "Warning: Expected Result(" & Me.CAN2USD(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For CAN2USD" _
            )
        Next

        ' If all checks pass, then return true
        Return True
    End Function

    ' Conversion table for the Mexican currency
    ' @return   Boolean     TRUE if the tests pass; FALSE if they fail
    Public Function MexicanTests() As Boolean
        Dim result As Decimal
        ' Test the conversions from USD to MEX
        Me._currency.source = eCurrency.American
        Me._currency.target = eCurrency.Mexican
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.USD2MEX(i), _
                "Warning: Expected Result(" & Me.USD2MEX(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For USD2MEX" _
            )
        Next
        ' Test the convesion from MEX to USD
        Me._currency.source = eCurrency.Mexican
        Me._currency.target = eCurrency.American
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.MEX2USD(i), _
                "Warning: Expected Result(" & Me.MEX2USD(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For MEX2USD" _
            )
        Next

        ' If all checks pass, then return true
        Return True
    End Function

    ' Conversion table for the English conversions
    ' @return   Boolean     TRUE if the tests pass; FALSE if they fail
    Public Function EnglishTests() As Boolean
        Dim result As Decimal
        ' Test the conversions from USD to ENG
        Me._currency.source = eCurrency.American
        Me._currency.target = eCurrency.English
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.USD2ENG(i), _
                "Warning: Expected Result(" & Me.USD2ENG(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For USD2ENG" _
            )
        Next
        ' Test the convesion from ENG to USD
        Me._currency.source = eCurrency.English
        Me._currency.target = eCurrency.American
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.ENG2USD(i), _
                "Warning: Expected Result(" & Me.ENG2USD(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For ENG2USD" _
            )
        Next

        ' If all checks pass, then return true
        Return True
    End Function

    ' Conversion table for the Japanese conversions
    ' @return   Boolean     TRUE if the tests pass; FALSE if they fail
    Public Function JapaneseTests() As Boolean
        Dim result As Decimal
        ' Test the conversions from USD to JAP
        Me._currency.source = eCurrency.American
        Me._currency.target = eCurrency.Japanese
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.USD2JAP(i), _
                "Warning: Expected Result(" & Me.USD2JAP(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For USD2JAP" _
            )
        Next
        ' Test the convesion from JAP to USD
        Me._currency.source = eCurrency.Japanese
        Me._currency.target = eCurrency.American
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.JAP2USD(i), _
                "Warning: Expected Result(" & Me.JAP2USD(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For JAP2USD" _
            )
        Next

        ' If all checks pass, then return true
        Return True
    End Function

    ' Conversion table for the French conversions
    ' @return   Boolean     TRUE if the tests pass; FALSE if they fail
    Public Function FrenchTests() As Boolean
        Dim result As Decimal
        ' Test the conversions from USD to FRC
        Me._currency.source = eCurrency.American
        Me._currency.target = eCurrency.French
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.USD2FRC(i), _
                "Warning: Expected Result(" & Me.USD2FRC(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For USD2FRC" _
            )
        Next
        ' Test the convesion from FRC to USD
        Me._currency.source = eCurrency.French
        Me._currency.target = eCurrency.American
        For i As Short = 0 To 9 Step 1
            result = Math.Round(Me._currency.Calculate(i + 1), 2)
            System.Diagnostics.Debug.Assert( _
                result = Me.FRC2USD(i), _
                "Warning: Expected Result(" & Me.FRC2USD(i).ToString() & _
                "); Output Result(" & result.ToString() & "); Calculate(" & _
                (i + 1).ToString() & "); For FRC2USD" _
            )
        Next

        ' If all checks pass, then return true
        Return True
    End Function

    ' Tests the operation of the calculate method in the conversion class.
    ' @return   Boolean     TRUE if the tests pass; FALSE if the tests fail
    Public Function CalculateTest() As Boolean
        Me.CanadianTests()
        Me.MexicanTests()
        Me.EnglishTests()
        Me.JapaneseTests()
        Me.FrenchTests()
        MessageBox.Show("All tests pass! :D", "Testing...", 0)
        Return True
    End Function
End Class
