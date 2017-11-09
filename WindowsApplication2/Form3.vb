Imports System.Data.SqlClient

Public Class Form3
    Inherits System.Windows.Forms.Form
    Dim con As SqlConnection
    Dim cmd, cmd1 As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr, dr1 As SqlDataReader
    Dim ds As DataSet

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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lb4 As System.Windows.Forms.ListBox
    Friend WithEvents lb3 As System.Windows.Forms.ListBox
    Friend WithEvents lb2 As System.Windows.Forms.ListBox
    Friend WithEvents Lb1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lb4 = New System.Windows.Forms.ListBox
        Me.lb3 = New System.Windows.Forms.ListBox
        Me.lb2 = New System.Windows.Forms.ListBox
        Me.Lb1 = New System.Windows.Forms.ListBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(112, 80)
        Me.ComboBox1.MaxDropDownItems = 35
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Medicine"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Entry/Emp no."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(288, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Doctor's Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(400, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(568, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 144)
        Me.Panel1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(48, 40)
        Me.ComboBox2.MaxDropDownItems = 35
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(48, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(64, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Availability"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(288, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Quantity"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(400, 80)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = "1"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "MEDICAL AID CENTER - Billing"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(112, 120)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.TabIndex = 12
        Me.TextBox5.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Rate"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Nothing
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lb4)
        Me.Panel2.Controls.Add(Me.lb3)
        Me.Panel2.Controls.Add(Me.lb2)
        Me.Panel2.Controls.Add(Me.Lb1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(32, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 280)
        Me.Panel2.TabIndex = 14
        '
        'lb4
        '
        Me.lb4.Location = New System.Drawing.Point(240, 32)
        Me.lb4.Name = "lb4"
        Me.lb4.Size = New System.Drawing.Size(120, 212)
        Me.lb4.TabIndex = 18
        '
        'lb3
        '
        Me.lb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb3.Location = New System.Drawing.Point(184, 32)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(56, 212)
        Me.lb3.TabIndex = 17
        '
        'lb2
        '
        Me.lb2.Location = New System.Drawing.Point(120, 32)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(64, 212)
        Me.lb2.TabIndex = 16
        '
        'Lb1
        '
        Me.Lb1.Location = New System.Drawing.Point(0, 32)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(120, 212)
        Me.Lb1.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(344, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = " Medicine                       Quantity     Rate         Total"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(440, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Add"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(448, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Total"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label10.Location = New System.Drawing.Point(416, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 48)
        Me.Label10.TabIndex = 19
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(440, 224)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Remove"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(288, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Company"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(400, 120)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.TabIndex = 22
        Me.TextBox6.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(312, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 23)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Bill no. "
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(400, 8)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.TabIndex = 24
        Me.TextBox7.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(576, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(192, 23)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Label13"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(448, 408)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "New Bill"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(632, 360)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "Log Out"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(632, 296)
        Me.Button6.Name = "Button6"
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "View Bills"
        '
        'Form3
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(792, 446)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form3"
        Me.Text = "BILL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim table As New DataTable

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label13.Text = DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss")
        'DateTime.Today.ToString("MMM")
        con = New SqlConnection
        con.ConnectionString() = "Data Source=vb;initial catalog=project;user id=me2;pwd=me2"
        con.Open()
        cmd = New SqlCommand("Select med_name from medicine", con)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr.GetString(0))
            ComboBox2.Items.Add(dr.GetString(0))
        End While
        con.Close()
        con.Open()
        Dim b As Integer
        cmd = New SqlCommand("Select max(billno) from bill", con)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            b = dr.GetInt32(0) + 1
        Else
            b = 1
        End If
        TextBox7.Text() = b
        con.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb3.SelectedIndexChanged

    End Sub

    Private Sub Total_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb4.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.ConnectionString() = "Data Source=vb;initial catalog=project;user id=me2;pwd=me2"
        con.Open()
        Lb1.Items.Add(ComboBox1.SelectedItem)
        cmd1 = New SqlCommand("Select rate,company from medicine where med_name='" + ComboBox1.SelectedItem + "'", con)
        dr1 = cmd1.ExecuteReader
        While dr1.Read()
            TextBox5.Text() = dr1.GetDouble(0).ToString
            TextBox6.Text() = dr1.GetString(1)
        End While

        lb2.Items.Add(TextBox4.Text)
        lb3.Items.Add(TextBox5.Text)
        lb4.Items.Add(TextBox4.Text * TextBox5.Text)
        con.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub
    Dim count, c, c1 As Integer
    Dim sum As Double = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        count = lb4.Items.Count
        For c = 0 To count - 1
            sum = sum + lb4.Items(c)
            Label10.Text = sum
        Next
        con = New SqlConnection
        cmd = New SqlCommand
        con.ConnectionString() = "Data Source=vb;initial catalog=project;user id=me2;pwd=me2"
        con.Open()
        cmd.Connection() = con
        'cmd.CommandText = "insert into bill values(2,'suresh',null,'cipla',87.30) "
        cmd.CommandText() = "insert into bill values(" + TextBox7.Text + ",'" + TextBox1.Text + "','" + DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss") + "','" + TextBox2.Text + "'," + Label10.Text + ")"
        cmd.ExecuteNonQuery()
        MsgBox("Record Inserted")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Lb1.Items.Remove(Lb1.SelectedItem)
        lb2.Items.Remove(lb2.SelectedItem)
        lb3.Items.Remove(lb3.SelectedItem)
        lb4.Items.Remove(lb4.SelectedItem)
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        con.ConnectionString() = "Data Source=vb;initial catalog=project;user id=me2;pwd=me2"
        con.Open()
        cmd1 = New SqlCommand("Select qty from medicine where med_name='" + ComboBox2.SelectedItem + "'", con)
        dr1 = cmd1.ExecuteReader
        While dr1.Read()
            Label5.Text() = dr1.GetInt32(0).ToString
        End While
        con.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Dim a1 As New Form3
        a1.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Dim a1 As New Bill
        a1.Show()
    End Sub
End Class
