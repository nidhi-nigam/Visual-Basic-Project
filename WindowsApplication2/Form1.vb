Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Imports System.Data.SqlClient

Public Class Login
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(392, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login Id"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(392, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.Location = New System.Drawing.Point(576, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(576, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(496, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Reset"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(32, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.Text = "Admin"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(384, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 48)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login As"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(168, 16)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(384, 208)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 64)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(616, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Close"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(592, 288)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(408, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Enter Captcha"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(608, 232)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Recaptcha"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(64, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(264, 288)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(240, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "+ Medical Aid Centre +"
        '
        'Login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 390)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "Login"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim con As SqlConnection
    Dim cmd, cmd1 As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr, dr1 As SqlDataReader
    Dim ds As DataSet
    Private rand As New Random
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con = New SqlConnection
        con.ConnectionString() = "Data Source=vb;initial catalog=project;user id=me2;pwd=me2"
        con.Open()
        cmd1 = New SqlCommand("Select Password from login where userid='" + TextBox1.Text + "'", con)
        dr1 = cmd1.ExecuteReader
        Dim s As String = TextBox2.Text
        'Dim s1 As String = dr1.GetString(0)
        If dr1.Read Then
            If String.Equals(dr1.GetString(0).ToString, TextBox2.Text) Then

                If RadioButton1.Checked And TextBox1.Text = "admin" Then
                    If TextBox3.Text = code.ToString() Then
                        Dim a As New Admin2
                        MsgBox(" You Have been logged in ")
                        a.Show()
                    Else
                        MessageBox.Show("Incorrect entry")
                    End If
                ElseIf RadioButton1.Checked And TextBox1.Text <> "admin" Then
                    MsgBox("No Permission")
                ElseIf (RadioButton2.Checked Or RadioButton1.Checked) And TextBox1.Text <> "admin" Then
                    If TextBox3.Text = code.ToString() Then
                        Dim aq As New Form3
                        MsgBox(" You Have been logged in ")
                        aq.Show()
                    Else
                        MessageBox.Show("Incorrect entry")
                    End If
                End If
            Else
                MsgBox("Wrong Password")
            End If
        Else
            MsgBox("Wrong Username")
        End If


        ' If TextBox3.Text = code.ToString() Then
        'Dim aq As New Form3
        'MsgBox(" You Have been logged in ")
        ' aq.Show()
        'Else
        '   MessageBox.Show("Incorrect entry")
        '  End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        PictureBox1.Image.Dispose()
        code = ""
        TextBox3.Text = ""
        CreateImage()
    End Sub
    Private Sub CreateImage()
        Dim code As String = GetRandomText()
        Dim bitmap As New Bitmap(200, 50, PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(bitmap)
        Dim pen As New Pen(Color.Yellow)
        Dim rect As New Rectangle(0, 0, 200, 50)
        Dim b As New SolidBrush(Color.Black)
        Dim White As New SolidBrush(Color.White)
        Dim counter As Integer = 0
        g.DrawRectangle(pen, rect)
        g.FillRectangle(b, rect)
        For i As Integer = 0 To code.Length - 1
            Dim c As Char
            c = code.Chars(i)
            g.DrawString(c.ToString(), New Font("Georgia", 10 + rand.[Next](14, 18)), White, New PointF(10 + counter, 10))
            counter += 20
        Next
        DrawRandomLines(g)
        If File.Exists("C:\Documents and Settings\VB Students\My Documents\Captcha for Windows Application\VB\Captcha_vb\tempimage.bmp") Then
            Try
                File.Delete("C:\Documents and Settings\VB Students\My Documents\Captcha for Windows Application\VB\Captcha_vb\tempimage.bmp")
                bitmap.Save("C:\Documents and Settings\VB Students\My Documents\Captcha for Windows Application\VB\Captcha_vb\tempimage.bmp")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            bitmap.Save("C:\Documents and Settings\VB Students\My Documents\Captcha for Windows Application\VB\Captcha_vb\tempimage.bmp")
        End If
        g.Dispose()
        bitmap.Dispose()
        PictureBox1.Image = Image.FromFile("C:\Documents and Settings\VB Students\My Documents\Captcha for Windows Application\VB\Captcha_vb\tempimage.bmp")
    End Sub
    Private Function GetRandomPoints() As Point()
        Dim points As Point() = {New Point(rand.[Next](10, 150), rand.[Next](10, 150)), New Point(rand.[Next](10, 100), rand.[Next](10, 100))}
        Return points
    End Function
    Private code As String
    Private Function GetRandomText() As String
        Dim randomText As New StringBuilder
        If code Is Nothing OrElse code = String.Empty Then
            Dim alphabets As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            Dim r As New Random
            For j As Integer = 0 To 5
                Dim c As Char
                c = alphabets.Chars(r.[Next](alphabets.Length))
                randomText.Append(c)
            Next
            code = randomText.ToString()
        End If
        Return code
    End Function

    Private Sub DrawRandomLines(ByVal g As Graphics)
        Dim green As New SolidBrush(Color.Green)
        'For Creating Lines on The Captcha
        For i As Integer = 0 To 19
            g.DrawLines(New Pen(green, 2), GetRandomPoints())
        Next
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateImage()
    End Sub



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox1.Image.Dispose()
        code = ""
        TextBox3.Text = ""
        CreateImage()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class
