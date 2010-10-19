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

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalProject
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
        Me.cmdCalc = New System.Windows.Forms.Button()
        Me.cboSource = New System.Windows.Forms.ComboBox()
        Me.cboTarget = New System.Windows.Forms.ComboBox()
        Me.lbSource = New System.Windows.Forms.Label()
        Me.lbTarget = New System.Windows.Forms.Label()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.lbNotice = New System.Windows.Forms.Label()
        Me.lbAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdCalc
        '
        Me.cmdCalc.Location = New System.Drawing.Point(339, 177)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalc.TabIndex = 0
        Me.cmdCalc.Text = "&Calculate"
        Me.cmdCalc.UseVisualStyleBackColor = True
        '
        'cboSource
        '
        Me.cboSource.FormattingEnabled = True
        Me.cboSource.Items.AddRange(New Object() {"American", "Canadian", "French", "English", "Japanese", "Mexican"})
        Me.cboSource.Location = New System.Drawing.Point(65, 75)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(164, 21)
        Me.cboSource.TabIndex = 1
        '
        'cboTarget
        '
        Me.cboTarget.FormattingEnabled = True
        Me.cboTarget.Items.AddRange(New Object() {"American", "Canadian", "French", "English", "Japanese", "Mexican"})
        Me.cboTarget.Location = New System.Drawing.Point(235, 75)
        Me.cboTarget.Name = "cboTarget"
        Me.cboTarget.Size = New System.Drawing.Size(179, 21)
        Me.cboTarget.TabIndex = 2
        '
        'lbSource
        '
        Me.lbSource.AutoSize = True
        Me.lbSource.Location = New System.Drawing.Point(62, 59)
        Me.lbSource.Name = "lbSource"
        Me.lbSource.Size = New System.Drawing.Size(86, 13)
        Me.lbSource.TabIndex = 3
        Me.lbSource.Text = "Source Currency"
        '
        'lbTarget
        '
        Me.lbTarget.AutoSize = True
        Me.lbTarget.Location = New System.Drawing.Point(232, 59)
        Me.lbTarget.Name = "lbTarget"
        Me.lbTarget.Size = New System.Drawing.Size(83, 13)
        Me.lbTarget.TabIndex = 4
        Me.lbTarget.Text = "Target Currency"
        '
        'lbInfo
        '
        Me.lbInfo.Location = New System.Drawing.Point(12, 9)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(402, 26)
        Me.lbInfo.TabIndex = 5
        Me.lbInfo.Text = "This is an application to convert currencies. Simply select a source and a target" & _
            " currency, and the application will output the result in the textbox below."
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(235, 132)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(179, 20)
        Me.txtResult.TabIndex = 6
        '
        'lbResult
        '
        Me.lbResult.AutoSize = True
        Me.lbResult.Location = New System.Drawing.Point(232, 116)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(37, 13)
        Me.lbResult.TabIndex = 7
        Me.lbResult.Text = "Result"
        '
        'lbNotice
        '
        Me.lbNotice.AutoSize = True
        Me.lbNotice.Location = New System.Drawing.Point(62, 187)
        Me.lbNotice.Name = "lbNotice"
        Me.lbNotice.Size = New System.Drawing.Size(16, 13)
        Me.lbNotice.TabIndex = 8
        Me.lbNotice.Text = "..."
        '
        'lbAmount
        '
        Me.lbAmount.AutoSize = True
        Me.lbAmount.Location = New System.Drawing.Point(62, 116)
        Me.lbAmount.Name = "lbAmount"
        Me.lbAmount.Size = New System.Drawing.Size(43, 13)
        Me.lbAmount.TabIndex = 10
        Me.lbAmount.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(65, 132)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(164, 20)
        Me.txtAmount.TabIndex = 9
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(333, 256)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(81, 21)
        Me.btnTest.TabIndex = 11
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(62, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Run internal tests to ensure all applicable conversions test correctly."
        '
        'FinalProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 307)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lbAmount)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lbNotice)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lbInfo)
        Me.Controls.Add(Me.lbTarget)
        Me.Controls.Add(Me.lbSource)
        Me.Controls.Add(Me.cboTarget)
        Me.Controls.Add(Me.cboSource)
        Me.Controls.Add(Me.cmdCalc)
        Me.Name = "FinalProject"
        Me.Text = "Currency Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCalc As System.Windows.Forms.Button
    Friend WithEvents cboSource As System.Windows.Forms.ComboBox
    Friend WithEvents cboTarget As System.Windows.Forms.ComboBox
    Friend WithEvents lbSource As System.Windows.Forms.Label
    Friend WithEvents lbTarget As System.Windows.Forms.Label
    Friend WithEvents lbInfo As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents lbResult As System.Windows.Forms.Label
    Friend WithEvents lbNotice As System.Windows.Forms.Label
    Friend WithEvents lbAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
