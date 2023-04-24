using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace serial_datalogger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                cmb_comport.Items.Add(port);            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string port = cmb_comport.SelectedItem.ToString();
            
            serialPort1 = new SerialPort(port, int.Parse(cmb_baudrate.SelectedItem.ToString()));
            serialPort1.Open();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler((s, args) => DataReceivedHandler(s, args, rtxt_output, txt_co,
                txt_co2, txt_o2, txt_hc, txt_rpm, txt_ot, txt_propane, txt_nox, txt_coc, txt_lambda, txt_afr, txt_at, txt_st, txt_pef));
        }

        //private static double data(byte[] buffer, string type)
        //{
        //    double value = 0;
        //    int startIndex = Array.IndexOf(buffer, (byte)0x02);
        //    string result = "";
        //    int decimalValue;

        //    var typeInfo = new Dictionary<string, (int startIndex, int length, double divisor)>
        //    {
        //        { "CO", (startIndex: startIndex + 11, length: 4, divisor: 1000.0) },
        //        { "CO2", (startIndex: startIndex + 19, length: 4, divisor: 1000.0) },
        //        { "O2", (startIndex: startIndex + 24, length: 3, divisor: 100.0) },
        //        { "HC", (startIndex: startIndex + 15, length: 4, divisor: 1.0) },
        //        { "RPM", (startIndex: startIndex + 36, length: 4, divisor: 1.0) },
        //        { "OT", (startIndex: startIndex + 40, length: 2, divisor: 1.0) },
        //        { "PROPANE", (startIndex: startIndex + 27, length: 4, divisor: 1.0) },
        //        { "NOX", (startIndex: startIndex + 31, length: 4, divisor: 1.0) },
        //        { "COC", (startIndex: startIndex + 43, length: 4, divisor: 1000.0) },
        //        { "LAMBDA", (startIndex: startIndex + 47, length: 4, divisor: 1000.0) },
        //        { "AFR", (startIndex: startIndex + 51, length: 4, divisor: 1000.0) },
        //        { "AT", (startIndex: startIndex + 56, length: 4, divisor: 100.0) },
        //        { "ST", (startIndex: startIndex + 60, length: 2, divisor: 1.0) },
        //        { "PEF", (startIndex: startIndex + 62, length: 4, divisor: 1000.0) }
        //    };
        private static double data(byte[] buffer, string type)
        {
            double value = 0;
            int startIndex = Array.IndexOf(buffer, (byte)0x02);
            string result = "";
            int decimalValue;
            if (type == "CO")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 11, 4);
                decimalValue = Convert.ToInt32(result, 16);
                value = decimalValue / 1000.0;
            }
            else if (type == "CO2")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 19, 4);
                decimalValue = Convert.ToInt32(result, 16);
                value = decimalValue / 100.0;
            }
            else if (type == "O2")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 24, 3);
                decimalValue = Convert.ToInt32(result, 16);
                value = decimalValue / 100.0;
            }
            else if (type == "HC")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 15, 4);
                value = Convert.ToInt32(result, 16);
            }
            else if (type == "RPM")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 36, 4);
                value = Convert.ToInt32(result, 16);
            }
            else if (type == "OT")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 40, 2);
                value = Convert.ToInt32(result, 16);
            }
            else if (type == "PROPANE")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 27, 4);
                value = Convert.ToInt32(result, 16);
            }
            else if (type == "NOX")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 31, 4);
                value = Convert.ToInt32(result, 16);
            }
            else if (type == "COC")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 43, 4);
                decimalValue = Convert.ToInt32(result, 16);
                value = decimalValue / 1000.0;
            }
            else if (type == "LAMBDA")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 47, 4);
                decimalValue = Convert.ToInt32(result, 16);
                value = decimalValue / 10000.0;
            }
            else if (type == "AFR")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 51, 4);
                decimalValue = Convert.ToInt32(result, 16);
                value = decimalValue / 1000.0;
            }
            else if (type == "AT")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 56, 4);
                decimalValue = Convert.ToInt32(result, 16);
                value = decimalValue / 100.0;
            }
            else if (type == "ST")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 60, 2);
                value = Convert.ToInt32(result, 16);
            }
            else if (type == "PEF")
            {
                result = Encoding.ASCII.GetString(buffer, startIndex + 62, 4);
                decimalValue = Convert.ToInt32(result, 16);
                value = decimalValue / 1000.0;
            }
            return value;


            //if (typeInfo.TryGetValue(type, out var info))
            //{
            //    result = Encoding.ASCII.GetString(buffer, info.startIndex, info.length);
            //    decimalValue = Convert.ToInt32(result, 16);
            //    value = decimalValue / info.divisor;
            //}
            //return value;
        }
        
        

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs args, RichTextBox rtxt_output, TextBox txt_co,
            TextBox txt_co2, TextBox txt_o2, TextBox txt_hc, TextBox txt_rpm, TextBox txt_ot, TextBox txt_pro, TextBox txt_nox,
            TextBox txt_coc, TextBox txt_lambda, TextBox txt_afr, TextBox txt_at, TextBox txt_st, TextBox txt_pef)
        {
            //try
            //{
            SerialPort sp = (SerialPort)sender;
            Thread.Sleep(100);
            int bytesToRead = sp.BytesToRead;

            // If there are no bytes in the buffer, return
            if (bytesToRead == 0)
                return;
            byte[] buffer = new byte[sp.BytesToRead];
            Thread.Sleep(100);
            sp.Read(buffer, 0, buffer.Length);
            int startIndex = Array.IndexOf(buffer, (byte)0x02);
            int endIndex = Array.IndexOf(buffer, (byte)0x03);
            Thread.Sleep(100);
            while (startIndex != -1 && endIndex != -1)
            {
                int stringlength = Encoding.ASCII.GetString(buffer, startIndex, endIndex + 1).Length;
                if (stringlength == 68)
                {
                    string result = "CO=" + data(buffer, "CO")
                        + Environment.NewLine + "CO2=" + data(buffer, "CO2")
                        + Environment.NewLine + "O2=" + data(buffer, "O2")
                        + Environment.NewLine + "HC=" + data(buffer, "HC")
                        + Environment.NewLine + "RPM=" + data(buffer, "RPM")
                        + Environment.NewLine + "OT=" + data(buffer, "OT")
                        + Environment.NewLine + "PROPANE=" + data(buffer, "PROPANE")
                        + Environment.NewLine + "NOX=" + data(buffer, "NOX")
                        + Environment.NewLine + "COC=" + data(buffer, "COC")
                        + Environment.NewLine + "LAMBDA=" + data(buffer, "LAMBDA")
                        + Environment.NewLine + "AFR=" + data(buffer, "AFR")
                        + Environment.NewLine + "AT=" + data(buffer, "AT")
                        + Environment.NewLine + "ST=" + data(buffer, "ST")
                        + Environment.NewLine + "PEF=" + data(buffer, "PEF");

                    rtxt_output.Invoke((MethodInvoker)delegate
                    {
                        rtxt_output.Text = result;
                    });

                    txt_co.Invoke((MethodInvoker)delegate
                    {
                        txt_co.Text = data(buffer, "CO").ToString();
                    });

                    txt_co2.Invoke((MethodInvoker)delegate
                    {
                        txt_co2.Text = data(buffer, "CO2").ToString();
                    });

                    txt_o2.Invoke((MethodInvoker)delegate
                    {
                        txt_o2.Text = data(buffer, "O2").ToString();
                    });

                    txt_hc.Invoke((MethodInvoker)delegate
                    {
                        txt_hc.Text = data(buffer, "HC").ToString();
                    });

                    txt_rpm.Invoke((MethodInvoker)delegate
                    {
                        txt_rpm.Text = data(buffer, "RPM").ToString();
                    });

                    txt_ot.Invoke((MethodInvoker)delegate
                    {
                        txt_ot.Text = data(buffer, "OT").ToString();
                    });

                    txt_coc.Invoke((MethodInvoker)delegate
                    {
                        txt_coc.Text = data(buffer, "COC").ToString();
                    });

                    txt_afr.Invoke((MethodInvoker)delegate
                    {
                        txt_afr.Text = data(buffer, "AFR").ToString();
                    });

                    txt_at.Invoke((MethodInvoker)delegate
                    {
                        txt_at.Text = data(buffer, "AT").ToString();
                    });

                    txt_st.Invoke((MethodInvoker)delegate
                    {
                        txt_st.Text = data(buffer, "ST").ToString();
                    });

                    txt_pef.Invoke((MethodInvoker)delegate
                    {
                        txt_pef.Text = data(buffer, "PEF").ToString();
                    });
                    txt_pro.Invoke((MethodInvoker)delegate
                    {
                        txt_pro.Text = data(buffer, "PROPANE").ToString();
                    });
                    txt_nox.Invoke((MethodInvoker)delegate
                    {
                        txt_nox.Text = data(buffer, "NOX").ToString();
                    });
                    txt_lambda.Invoke((MethodInvoker)delegate
                    {
                        txt_lambda.Text = data(buffer, "LAMBDA").ToString();
                    });
                }
                startIndex = -1;
                endIndex = -1;
            }


        }
        public void generateWord()
        {
            Word._Application objApp;
            try
            {
                object objMiss = System.Reflection.Missing.Value;
                object objEndOfDocFlag = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

                //Start Word and create a new document.
                objApp = new Word.Application();
                objApp.Visible = true;
                objApp.Documents.Open(System.Windows.Forms.Application.StartupPath + @"\template.docx");
                
                var v = "";
                foreach (Word.ContentControl c in objApp.ActiveDocument.ContentControls)
                {
                    Console.WriteLine(c.Title);

                  
                    v = getValue(c.Title);
                    
                    c.Range.Text = v;
                }
                string name = getFileName();
                
                objApp.ActiveDocument.SaveAs(name);
                foreach (Control c in Controls)
                {
                    if (c is TextBox || c is MaskedTextBox || c is ComboBox)
                    {
                        c.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private string getFileName()
        {
            var dir = @"G:\myWorkspace\Ecoys\DesktopDev\";
            try
            {
                if (!Directory.Exists(dir))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(dir);
                }
            }
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message);
            }
            return dir + GetSafeFilename(txt_filename.Text);
        }

        public string GetSafeFilename(string filename)
        {
            return string.Join("_", filename.Split(System.IO.Path.GetInvalidFileNameChars()));
        }

        private string getValue(string p)
        {
            switch (p)
            {
                case "Co": return txt_co.Text;
                case "HC": return txt_hc.Text;
                case "CO2": return txt_co2.Text;
                case "SOx": return txt__sox.Text;
                case "NOx": return txt_nox.Text;
                case "OT": return txt_ot.Text;
                case "RPM": return txt_rpm.Text;
                case "LAMBDA": return txt_lambda.Text;
                case "O2": return txt_o2.Text;
                case "AFR": return txt_afr.Text;
                default: return "XXX";
            }
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_filename.Text))
            {
                MessageBox.Show("Please Enter file name");
                return;
            }
            generateWord();
            MessageBox.Show("Done");
        }
    }
}