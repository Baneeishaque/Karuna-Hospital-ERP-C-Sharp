' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'
' This sample application demonstrates the use of the PrintForm
' component to print a simple report with the need for a 
' PrintDocument component.


Public Class Rprint

    Public Sub New(ByVal no As String, ByVal t20 As String, ByVal t30 As String, ByVal t27 As String, ByVal t29 As String, ByVal t28 As String,
                   ByVal t45 As String, ByVal t31 As String, ByVal t71 As String,
                   ByVal t62 As String, ByVal t70 As String, ByVal t61 As String, ByVal t69 As String, ByVal t80 As String,
                   ByVal t68 As String, ByVal t79 As String, ByVal t67 As String, ByVal t78 As String, ByVal t66 As String,
                   ByVal t77 As String, ByVal t65 As String, ByVal t76 As String, ByVal t64 As String, ByVal t75 As String,
                   ByVal t63 As String, ByVal t73 As String)
        InitializeComponent()
        label20.Text = t20
        label30.Text = t30

        label27.Text = t27
        label29.Text = t29
        label28.Text = t28
        label45.Text = t45
        label31.Text = t31
        label71.Text = t71
        label62.Text = t62
        label70.Text = t70
        label61.Text = t61
        label69.Text = t69
        label80.Text = t80
        label68.Text = t68
        label79.Text = t79
        label67.Text = t67
        label78.Text = t78
        label66.Text = t66
        label77.Text = t77
        label65.Text = t65
        label76.Text = t76
        label64.Text = t64
        label75.Text = t75
        label63.Text = t63
        label73.Text = t73
        label72.Text = no


    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint



    End Sub






    Private Sub Report_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
       
    End Sub

    Private Sub panel1_Click(sender As Object, e As EventArgs) Handles panel1.Click, MyBase.Enter, MyBase.Click, panel3.Enter, panel3.Click, Label1.Click
       
    End Sub

    Private Sub label13_Click(sender As Object, e As EventArgs) Handles label13.Click

    End Sub

    Private Sub Report_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDoubleClick

    End Sub

    Private Sub Report_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, panel3.MouseClick, panel1.MouseClick, Label1.MouseClick
        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Set the PrintAction to display a Print Preview dialog
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        ' Print a copy of the form
        PrintForm1.Print()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
