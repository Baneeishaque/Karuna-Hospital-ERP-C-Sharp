Public Class Wprint

    Public Sub New(ByVal no As String, ByVal ip1 As String, ByVal name1 As String, ByVal date1 As String, ByVal doctor1 As String,
                   ByVal room1 As String, ByVal dis As String, ByVal days As String, ByVal t31 As String,
                   ByVal t30 As String, ByVal t3 As String, ByVal t2 As String, ByVal t29 As String,
                   ByVal t27 As String, ByVal t28 As String, ByVal t5 As String, ByVal t26 As String,
                   ByVal t25 As String, ByVal t24 As String, ByVal t6 As String, ByVal t4 As String,
                   ByVal total As String)
        InitializeComponent()
        label20.Text = ip1
        label30.Text = name1

        label27.Text = date1
        label29.Text = doctor1
        label28.Text = room1
        label45.Text = dis
        label31.Text = days
        label57.Text = t31
        label50.Text = t30
        label56.Text = t3
        label49.Text = t2
        label55.Text = t29
        label48.Text = t27
        label54.Text = t28
        label47.Text = t5
        label53.Text = t26
        label46.Text = t25
        label52.Text = t24
        label58.Text = t6
        label51.Text = t4
        label60.Text = total
        label72.Text = no


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, PictureBox1.MouseClick, panel3.MouseClick, panel1.MouseClick, Label1.MouseClick

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        
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