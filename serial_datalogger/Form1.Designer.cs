
namespace serial_datalogger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_comport = new System.Windows.Forms.Label();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.cmb_comport = new System.Windows.Forms.ComboBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.rtxt_output = new System.Windows.Forms.RichTextBox();
            this.label_co = new System.Windows.Forms.Label();
            this.txt_co = new System.Windows.Forms.TextBox();
            this.txt_co2 = new System.Windows.Forms.TextBox();
            this.label_co2 = new System.Windows.Forms.Label();
            this.txt_o2 = new System.Windows.Forms.TextBox();
            this.label_o2 = new System.Windows.Forms.Label();
            this.txt_hc = new System.Windows.Forms.TextBox();
            this.label_hc = new System.Windows.Forms.Label();
            this.txt_rpm = new System.Windows.Forms.TextBox();
            this.label_rpm = new System.Windows.Forms.Label();
            this.txt_ot = new System.Windows.Forms.TextBox();
            this.label_ot = new System.Windows.Forms.Label();
            this.txt_coc = new System.Windows.Forms.TextBox();
            this.label_coc = new System.Windows.Forms.Label();
            this.txt_afr = new System.Windows.Forms.TextBox();
            this.label_afr = new System.Windows.Forms.Label();
            this.txt_at = new System.Windows.Forms.TextBox();
            this.label_at = new System.Windows.Forms.Label();
            this.txt_st = new System.Windows.Forms.TextBox();
            this.label_st = new System.Windows.Forms.Label();
            this.txt_pef = new System.Windows.Forms.TextBox();
            this.label_pef = new System.Windows.Forms.Label();
            this.txt_propane = new System.Windows.Forms.TextBox();
            this.label_propane = new System.Windows.Forms.Label();
            this.txt_nox = new System.Windows.Forms.TextBox();
            this.label_nox = new System.Windows.Forms.Label();
            this.txt__sox = new System.Windows.Forms.TextBox();
            this.txt_sox = new System.Windows.Forms.Label();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.label_lambda = new System.Windows.Forms.Label();
            this.cmb_baudrate = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_generate = new System.Windows.Forms.Button();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_comport
            // 
            this.label_comport.AutoSize = true;
            this.label_comport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_comport.Location = new System.Drawing.Point(217, 60);
            this.label_comport.Name = "label_comport";
            this.label_comport.Size = new System.Drawing.Size(131, 20);
            this.label_comport.TabIndex = 0;
            this.label_comport.Text = "Select COMPort";
            // 
            // label_baudrate
            // 
            this.label_baudrate.AutoSize = true;
            this.label_baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_baudrate.Location = new System.Drawing.Point(346, 104);
            this.label_baudrate.Name = "label_baudrate";
            this.label_baudrate.Size = new System.Drawing.Size(77, 20);
            this.label_baudrate.TabIndex = 1;
            this.label_baudrate.Text = "Baudrate";
            // 
            // cmb_comport
            // 
            this.cmb_comport.FormattingEnabled = true;
            this.cmb_comport.Location = new System.Drawing.Point(452, 56);
            this.cmb_comport.Name = "cmb_comport";
            this.cmb_comport.Size = new System.Drawing.Size(121, 24);
            this.cmb_comport.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(321, 148);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 37);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(498, 146);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 39);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // rtxt_output
            // 
            this.rtxt_output.Location = new System.Drawing.Point(309, 207);
            this.rtxt_output.Name = "rtxt_output";
            this.rtxt_output.Size = new System.Drawing.Size(299, 355);
            this.rtxt_output.TabIndex = 6;
            this.rtxt_output.Text = "";
            // 
            // label_co
            // 
            this.label_co.AutoSize = true;
            this.label_co.Location = new System.Drawing.Point(702, 56);
            this.label_co.Name = "label_co";
            this.label_co.Size = new System.Drawing.Size(28, 17);
            this.label_co.TabIndex = 7;
            this.label_co.Text = "CO";
            // 
            // txt_co
            // 
            this.txt_co.Location = new System.Drawing.Point(787, 51);
            this.txt_co.Name = "txt_co";
            this.txt_co.Size = new System.Drawing.Size(100, 22);
            this.txt_co.TabIndex = 8;
            // 
            // txt_co2
            // 
            this.txt_co2.Location = new System.Drawing.Point(787, 79);
            this.txt_co2.Name = "txt_co2";
            this.txt_co2.Size = new System.Drawing.Size(100, 22);
            this.txt_co2.TabIndex = 10;
            // 
            // label_co2
            // 
            this.label_co2.AutoSize = true;
            this.label_co2.Location = new System.Drawing.Point(702, 84);
            this.label_co2.Name = "label_co2";
            this.label_co2.Size = new System.Drawing.Size(36, 17);
            this.label_co2.TabIndex = 9;
            this.label_co2.Text = "CO2";
            // 
            // txt_o2
            // 
            this.txt_o2.Location = new System.Drawing.Point(787, 107);
            this.txt_o2.Name = "txt_o2";
            this.txt_o2.Size = new System.Drawing.Size(100, 22);
            this.txt_o2.TabIndex = 12;
            // 
            // label_o2
            // 
            this.label_o2.AutoSize = true;
            this.label_o2.Location = new System.Drawing.Point(702, 112);
            this.label_o2.Name = "label_o2";
            this.label_o2.Size = new System.Drawing.Size(27, 17);
            this.label_o2.TabIndex = 11;
            this.label_o2.Text = "O2";
            // 
            // txt_hc
            // 
            this.txt_hc.Location = new System.Drawing.Point(787, 135);
            this.txt_hc.Name = "txt_hc";
            this.txt_hc.Size = new System.Drawing.Size(100, 22);
            this.txt_hc.TabIndex = 14;
            // 
            // label_hc
            // 
            this.label_hc.AutoSize = true;
            this.label_hc.Location = new System.Drawing.Point(702, 140);
            this.label_hc.Name = "label_hc";
            this.label_hc.Size = new System.Drawing.Size(27, 17);
            this.label_hc.TabIndex = 13;
            this.label_hc.Text = "HC";
            // 
            // txt_rpm
            // 
            this.txt_rpm.Location = new System.Drawing.Point(787, 163);
            this.txt_rpm.Name = "txt_rpm";
            this.txt_rpm.Size = new System.Drawing.Size(100, 22);
            this.txt_rpm.TabIndex = 16;
            // 
            // label_rpm
            // 
            this.label_rpm.AutoSize = true;
            this.label_rpm.Location = new System.Drawing.Point(702, 168);
            this.label_rpm.Name = "label_rpm";
            this.label_rpm.Size = new System.Drawing.Size(38, 17);
            this.label_rpm.TabIndex = 15;
            this.label_rpm.Text = "RPM";
            // 
            // txt_ot
            // 
            this.txt_ot.Location = new System.Drawing.Point(787, 191);
            this.txt_ot.Name = "txt_ot";
            this.txt_ot.Size = new System.Drawing.Size(100, 22);
            this.txt_ot.TabIndex = 18;
            // 
            // label_ot
            // 
            this.label_ot.AutoSize = true;
            this.label_ot.Location = new System.Drawing.Point(702, 196);
            this.label_ot.Name = "label_ot";
            this.label_ot.Size = new System.Drawing.Size(28, 17);
            this.label_ot.TabIndex = 17;
            this.label_ot.Text = "OT";
            // 
            // txt_coc
            // 
            this.txt_coc.Location = new System.Drawing.Point(787, 219);
            this.txt_coc.Name = "txt_coc";
            this.txt_coc.Size = new System.Drawing.Size(100, 22);
            this.txt_coc.TabIndex = 20;
            // 
            // label_coc
            // 
            this.label_coc.AutoSize = true;
            this.label_coc.Location = new System.Drawing.Point(702, 224);
            this.label_coc.Name = "label_coc";
            this.label_coc.Size = new System.Drawing.Size(37, 17);
            this.label_coc.TabIndex = 19;
            this.label_coc.Text = "COC";
            // 
            // txt_afr
            // 
            this.txt_afr.Location = new System.Drawing.Point(787, 247);
            this.txt_afr.Name = "txt_afr";
            this.txt_afr.Size = new System.Drawing.Size(100, 22);
            this.txt_afr.TabIndex = 22;
            // 
            // label_afr
            // 
            this.label_afr.AutoSize = true;
            this.label_afr.Location = new System.Drawing.Point(702, 252);
            this.label_afr.Name = "label_afr";
            this.label_afr.Size = new System.Drawing.Size(35, 17);
            this.label_afr.TabIndex = 21;
            this.label_afr.Text = "AFR";
            // 
            // txt_at
            // 
            this.txt_at.Location = new System.Drawing.Point(787, 275);
            this.txt_at.Name = "txt_at";
            this.txt_at.Size = new System.Drawing.Size(100, 22);
            this.txt_at.TabIndex = 24;
            // 
            // label_at
            // 
            this.label_at.AutoSize = true;
            this.label_at.Location = new System.Drawing.Point(702, 280);
            this.label_at.Name = "label_at";
            this.label_at.Size = new System.Drawing.Size(26, 17);
            this.label_at.TabIndex = 23;
            this.label_at.Text = "AT";
            // 
            // txt_st
            // 
            this.txt_st.Location = new System.Drawing.Point(787, 303);
            this.txt_st.Name = "txt_st";
            this.txt_st.Size = new System.Drawing.Size(100, 22);
            this.txt_st.TabIndex = 26;
            // 
            // label_st
            // 
            this.label_st.AutoSize = true;
            this.label_st.Location = new System.Drawing.Point(702, 308);
            this.label_st.Name = "label_st";
            this.label_st.Size = new System.Drawing.Size(26, 17);
            this.label_st.TabIndex = 25;
            this.label_st.Text = "ST";
            // 
            // txt_pef
            // 
            this.txt_pef.Location = new System.Drawing.Point(787, 331);
            this.txt_pef.Name = "txt_pef";
            this.txt_pef.Size = new System.Drawing.Size(100, 22);
            this.txt_pef.TabIndex = 28;
            // 
            // label_pef
            // 
            this.label_pef.AutoSize = true;
            this.label_pef.Location = new System.Drawing.Point(702, 336);
            this.label_pef.Name = "label_pef";
            this.label_pef.Size = new System.Drawing.Size(34, 17);
            this.label_pef.TabIndex = 27;
            this.label_pef.Text = "PEF";
            // 
            // txt_propane
            // 
            this.txt_propane.Location = new System.Drawing.Point(787, 359);
            this.txt_propane.Name = "txt_propane";
            this.txt_propane.Size = new System.Drawing.Size(100, 22);
            this.txt_propane.TabIndex = 30;
            // 
            // label_propane
            // 
            this.label_propane.AutoSize = true;
            this.label_propane.Location = new System.Drawing.Point(702, 364);
            this.label_propane.Name = "label_propane";
            this.label_propane.Size = new System.Drawing.Size(75, 17);
            this.label_propane.TabIndex = 29;
            this.label_propane.Text = "PROPANE";
            // 
            // txt_nox
            // 
            this.txt_nox.Location = new System.Drawing.Point(787, 387);
            this.txt_nox.Name = "txt_nox";
            this.txt_nox.Size = new System.Drawing.Size(100, 22);
            this.txt_nox.TabIndex = 32;
            // 
            // label_nox
            // 
            this.label_nox.AutoSize = true;
            this.label_nox.Location = new System.Drawing.Point(702, 392);
            this.label_nox.Name = "label_nox";
            this.label_nox.Size = new System.Drawing.Size(35, 17);
            this.label_nox.TabIndex = 31;
            this.label_nox.Text = "NOx";
            // 
            // txt__sox
            // 
            this.txt__sox.Location = new System.Drawing.Point(787, 415);
            this.txt__sox.Name = "txt__sox";
            this.txt__sox.Size = new System.Drawing.Size(100, 22);
            this.txt__sox.TabIndex = 34;
            // 
            // txt_sox
            // 
            this.txt_sox.AutoSize = true;
            this.txt_sox.Location = new System.Drawing.Point(702, 420);
            this.txt_sox.Name = "txt_sox";
            this.txt_sox.Size = new System.Drawing.Size(34, 17);
            this.txt_sox.TabIndex = 33;
            this.txt_sox.Text = "SOx";
            // 
            // txt_lambda
            // 
            this.txt_lambda.Location = new System.Drawing.Point(787, 443);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(100, 22);
            this.txt_lambda.TabIndex = 36;
            // 
            // label_lambda
            // 
            this.label_lambda.AutoSize = true;
            this.label_lambda.Location = new System.Drawing.Point(702, 448);
            this.label_lambda.Name = "label_lambda";
            this.label_lambda.Size = new System.Drawing.Size(64, 17);
            this.label_lambda.TabIndex = 35;
            this.label_lambda.Text = "LAMBDA";
            // 
            // cmb_baudrate
            // 
            this.cmb_baudrate.FormattingEnabled = true;
            this.cmb_baudrate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cmb_baudrate.Location = new System.Drawing.Point(452, 100);
            this.cmb_baudrate.Name = "cmb_baudrate";
            this.cmb_baudrate.Size = new System.Drawing.Size(121, 24);
            this.cmb_baudrate.TabIndex = 37;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(997, 207);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(98, 34);
            this.btn_generate.TabIndex = 38;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(995, 165);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(100, 22);
            this.txt_filename.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 609);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.cmb_baudrate);
            this.Controls.Add(this.txt_lambda);
            this.Controls.Add(this.label_lambda);
            this.Controls.Add(this.txt__sox);
            this.Controls.Add(this.txt_sox);
            this.Controls.Add(this.txt_nox);
            this.Controls.Add(this.label_nox);
            this.Controls.Add(this.txt_propane);
            this.Controls.Add(this.label_propane);
            this.Controls.Add(this.txt_pef);
            this.Controls.Add(this.label_pef);
            this.Controls.Add(this.txt_st);
            this.Controls.Add(this.label_st);
            this.Controls.Add(this.txt_at);
            this.Controls.Add(this.label_at);
            this.Controls.Add(this.txt_afr);
            this.Controls.Add(this.label_afr);
            this.Controls.Add(this.txt_coc);
            this.Controls.Add(this.label_coc);
            this.Controls.Add(this.txt_ot);
            this.Controls.Add(this.label_ot);
            this.Controls.Add(this.txt_rpm);
            this.Controls.Add(this.label_rpm);
            this.Controls.Add(this.txt_hc);
            this.Controls.Add(this.label_hc);
            this.Controls.Add(this.txt_o2);
            this.Controls.Add(this.label_o2);
            this.Controls.Add(this.txt_co2);
            this.Controls.Add(this.label_co2);
            this.Controls.Add(this.txt_co);
            this.Controls.Add(this.label_co);
            this.Controls.Add(this.rtxt_output);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.cmb_comport);
            this.Controls.Add(this.label_baudrate);
            this.Controls.Add(this.label_comport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_comport;
        private System.Windows.Forms.Label label_baudrate;
        private System.Windows.Forms.ComboBox cmb_comport;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.RichTextBox rtxt_output;
        private System.Windows.Forms.Label label_co;
        private System.Windows.Forms.TextBox txt_co;
        private System.Windows.Forms.TextBox txt_co2;
        private System.Windows.Forms.Label label_co2;
        private System.Windows.Forms.TextBox txt_o2;
        private System.Windows.Forms.Label label_o2;
        private System.Windows.Forms.TextBox txt_hc;
        private System.Windows.Forms.Label label_hc;
        private System.Windows.Forms.TextBox txt_rpm;
        private System.Windows.Forms.Label label_rpm;
        private System.Windows.Forms.TextBox txt_ot;
        private System.Windows.Forms.Label label_ot;
        private System.Windows.Forms.TextBox txt_coc;
        private System.Windows.Forms.Label label_coc;
        private System.Windows.Forms.TextBox txt_afr;
        private System.Windows.Forms.Label label_afr;
        private System.Windows.Forms.TextBox txt_at;
        private System.Windows.Forms.Label label_at;
        private System.Windows.Forms.TextBox txt_st;
        private System.Windows.Forms.Label label_st;
        private System.Windows.Forms.TextBox txt_pef;
        private System.Windows.Forms.Label label_pef;
        private System.Windows.Forms.TextBox txt_propane;
        private System.Windows.Forms.Label label_propane;
        private System.Windows.Forms.TextBox txt_nox;
        private System.Windows.Forms.Label label_nox;
        private System.Windows.Forms.TextBox txt__sox;
        private System.Windows.Forms.Label txt_sox;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.Label label_lambda;
        private System.Windows.Forms.ComboBox cmb_baudrate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txt_filename;
    }
}

