Imports System
Imports System.Threading
Imports System.IO
Imports System.IO.Ports
Imports System.ComponentModel




Public Class Form1


    Dim myPort As Array
    Delegate Sub SetTextCallBack(ByVal [text] As String)
    Private Const EM_SCROLL = &HB5
    Private Const SB_BOTTOM = 7
    Private Const SB_Top = 6

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Analog Robots Assignment", vbOKOnly, "Design Project EPM")
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)
        SerialPort1.Close()
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button14.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.WriteLine("G91")
        SerialPort1.WriteLine(RichTextBox1.Text)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.ReadTimeout = ComboBox3.Text
        SerialPort1.DataBits = ComboBox6.Text
        SerialPort1.Open()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        Button14.Enabled = True
        Button16.Enabled = True
        Button17.Enabled = True
        Button18.Enabled = True
        Button19.Enabled = True
        Button13.Enabled = True
        Button15.Enabled = True

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SerialPort1.Close()
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button14.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button13.Enabled = False
        Button15.Enabled = False
    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub


    'G-CODE axis control-------------------------------------------------------------------------------------



    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        SerialPort1.WriteLine("G90")
        SerialPort1.WriteLine("G01 X" + ComboBox4.Text)
        RichTextBox3.AppendText("G01 X" + ComboBox4.Text & vbNewLine)
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        SerialPort1.WriteLine("G90")
        SerialPort1.WriteLine("G01 X-" + ComboBox4.Text)
        RichTextBox3.AppendText("G01 X-" + ComboBox4.Text & vbNewLine)
    End Sub




    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        SerialPort1.WriteLine("G90")
        SerialPort1.WriteLine("G01 Y" + ComboBox4.Text)
        RichTextBox3.AppendText("G01 Y" + ComboBox4.Text & vbNewLine)
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        SerialPort1.WriteLine("G90")
        SerialPort1.WriteLine("G01 Y-" + ComboBox4.Text)
        RichTextBox3.AppendText("G01 Y-" + ComboBox4.Text & vbNewLine)
    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SerialPort1.WriteLine("G91")
        SerialPort1.WriteLine("G01 Y" + ComboBox4.Text)
        RichTextBox3.AppendText("G01 Y" + ComboBox4.Text & vbNewLine)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SerialPort1.WriteLine("G91")
        SerialPort1.WriteLine("G01 Y-" + ComboBox4.Text)
        RichTextBox3.AppendText("G01 Y-" + ComboBox4.Text & vbNewLine)
    End Sub




    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SerialPort1.WriteLine("G91")
        SerialPort1.WriteLine("G01 X" + ComboBox4.Text)
        RichTextBox3.AppendText("G01 X" + ComboBox4.Text & vbNewLine)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        SerialPort1.WriteLine("G91")
        SerialPort1.WriteLine("G01 X-" + ComboBox4.Text)
        RichTextBox3.AppendText("G01 X-" + ComboBox4.Text & vbNewLine)
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SerialPort1.WriteLine("G01 Z-1")
        RichTextBox3.AppendText("G01 Z-1" & vbNewLine)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SerialPort1.WriteLine("G01 Z1")
        RichTextBox3.AppendText("G01 Z1" & vbNewLine)
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SerialPort1.WriteLine("G90")
        SerialPort1.WriteLine("G01 X0 Y0")
        RichTextBox3.AppendText("G01 X0 Y0" & vbNewLine)
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        SerialPort1.WriteLine("G92 x0 y0 z0")
        RichTextBox3.AppendText("G92 x0 y0 z0" & vbNewLine)
    End Sub

    '---------------------------------------------------------------------------------------------------------

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        For i = 0 To RichTextBox4.Lines.Count - 1
            RichTextBox3.AppendText(RichTextBox4.Lines(i) & vbNewLine)
            SerialPort1.WriteLine("G90")
            RichTextBox3.AppendText("G90" & vbNewLine)
            SerialPort1.WriteLine(RichTextBox4.Lines(i))
            wait(500)
        Next

    End Sub
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub RichTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox4.TextChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim strtext As String
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Title = "Choose G-code file"
        OpenFileDialog1.ShowDialog()
        strtext = OpenFileDialog1.FileName
        TextBox1.Text = Path.GetDirectoryName(OpenFileDialog1.FileName)
        RichTextBox4.Text = My.Computer.FileSystem.ReadAllText(strtext)

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        RecievedText(SerialPort1.ReadExisting())
    End Sub

    Private Sub RecievedText(ByVal [text] As String)
        If Me.RichTextBox3.InvokeRequired Then
            Dim x As New SetTextCallBack(AddressOf RecievedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.RichTextBox3.Text &= text

        End If
    End Sub

    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox3.TextChanged

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        SerialPort1.WriteLine("G90")
        SerialPort1.WriteLine(RichTextBox1.Text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        SerialPort1.WriteLine(RichTextBox1.Text)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        SerialPort1.WriteLine("0,0")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        SerialPort1.WriteLine("90,90")
    End Sub
End Class
