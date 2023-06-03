Imports System.Data
Imports System.Data.SqlServerCe
Imports System.IO

Public Class Loading


    'ClientAreaMove Handling'----------------------------------------

    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
    '------------------------------------------------------------------------'


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity <= 1.0 Then
            Me.Opacity = Me.Opacity - 0.1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity <= 0 Then
            Petugas.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity = Me.Opacity + 0.1
        End If
    End Sub


    Private Sub FORM1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = (Me.Width - Label1.Width) / 2
        Label2.Left = (Me.Width - Label2.Width) / 2
        Label3.Left = (Me.Width - Label3.Width) / 2
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Start()
    End Sub

    Private Sub Timer_loading_Tick(sender As Object, e As EventArgs) Handles Timer_loading.Tick
        Timer1.Start()
        Timer2.Start()
        Timer3.Stop()
    End Sub

    Private Sub Loading_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim simbolTakHingga As Char = ChrW(&H221E)
        Dim jenisTulisan As New Font("Arial", 600)
        Dim kuas As New SolidBrush(Color.DarkGray)
        Dim g As Graphics = e.Graphics
        g.DrawString(simbolTakHingga, jenisTulisan, kuas, -80, -300)
    End Sub
End Class