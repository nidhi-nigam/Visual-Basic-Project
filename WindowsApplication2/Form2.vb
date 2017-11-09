Imports System.Data.SqlClient

Public Class Admin
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents T5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.b1 = New System.Windows.Forms.Button
        Me.T5 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(80, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(80, 96)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(80, 8)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.TabIndex = 6
        Me.TextBox4.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(56, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Insert"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(264, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(424, 272)
        Me.DataGrid1.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(432, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Refresh"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "UserId"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(32, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(200, 232)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.b1)
        Me.TabPage2.Controls.Add(Me.T5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(192, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Delete"
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(48, 120)
        Me.b1.Name = "b1"
        Me.b1.TabIndex = 2
        Me.b1.Text = "Delete"
        '
        'T5
        '
        Me.T5.Location = New System.Drawing.Point(72, 48)
        Me.T5.Name = "T5"
        Me.T5.TabIndex = 1
        Me.T5.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "UserId"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(192, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Insert"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Admin"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(552, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Back"
        '
        'Admin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 366)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Admin"
        Me.Text = "Form2"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim con As SqlConnection
    Dim cmd, cmd1 As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' dr = cmd.ExecuteReader
        'If dr.Read() Then
        ' TextBox4.Text() = dr.GetString(0)
        'TextBox2.Text() = dr.GetString(1)
        'TextBox3.Text() = dr.GetString(2)
        'Else
        '   MsgBox("No more record")
        'End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection
        cmd = New SqlCommand
        cmd1 = New SqlCommand
        con.ConnectionString() = "Data Source=vb;initial catalog=project;user id=me2;pwd=me2"
        con.Open()
        cmd.Connection() = con
        cmd1.Connection() = con
        cmd.CommandText() = "Select * from login"
        da = New SqlDataAdapter
        da.SelectCommand() = cmd
        ds = New DataSet
        da.Fill(ds, "login")
        DataGrid1.DataSource() = ds

        'cmd.CommandText() = "Select name,userid,password from login"
        'dr = cmd.ExecuteReader

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmd.CommandText() = "insert into login values('" + TextBox4.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"
        cmd.ExecuteNonQuery()
        MsgBox("Record Inserted")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmd.CommandText() = "Select * from login"
        da = New SqlDataAdapter
        da.SelectCommand() = cmd
        ds = New DataSet
        da.Fill(ds, "login")
        DataGrid1.DataSource() = ds
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        'cmd.CommandText() = "Select userid from login where userid='" + T5.Text + "'"
        ' dr = cmd.ExecuteReader
        'If dr.Read() Then
            cmd1.CommandText() = "Delete from login where userid='" + T5.Text + "'"
            cmd1.ExecuteNonQuery()
            MsgBox("Data Deleted Successfully")
        'End If
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Dim a1 As New Admin2
        a1.Show()
    End Sub
End Class
