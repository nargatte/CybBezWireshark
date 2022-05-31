namespace CybBezWireshark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ldapServerPort = new System.Windows.Forms.NumericUpDown();
            this.reverseShellListenerPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payloadCodeBaseServerPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DoS = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EmailCaptureTab = new System.Windows.Forms.TabPage();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.recipientTextBox = new System.Windows.Forms.TextBox();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.senderLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ldapServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reverseShellListenerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payloadCodeBaseServerPort)).BeginInit();
            this.DoS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.EmailCaptureTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.DoS);
            this.tabControl1.Controls.Add(this.EmailCaptureTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by:\nGrzegorz Krzysiak\nIgor Szołucha\nMikołaj Pohorecki\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log4Shell";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(786, 412);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.19084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.80916F));
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ldapServerPort, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.reverseShellListenerPort, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.payloadCodeBaseServerPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(260, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 41);
            this.button5.TabIndex = 10;
            this.button5.Text = "copy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(6, 164);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(245, 27);
            this.textBox4.TabIndex = 9;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.radioButton2, 2);
            this.radioButton2.Location = new System.Drawing.Point(10, 102);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "show terminals";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ldapServerPort
            // 
            this.ldapServerPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldapServerPort.Location = new System.Drawing.Point(260, 69);
            this.ldapServerPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ldapServerPort.Name = "ldapServerPort";
            this.ldapServerPort.Size = new System.Drawing.Size(79, 27);
            this.ldapServerPort.TabIndex = 5;
            // 
            // reverseShellListenerPort
            // 
            this.reverseShellListenerPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reverseShellListenerPort.Location = new System.Drawing.Point(260, 36);
            this.reverseShellListenerPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.reverseShellListenerPort.Name = "reverseShellListenerPort";
            this.reverseShellListenerPort.Size = new System.Drawing.Size(79, 27);
            this.reverseShellListenerPort.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "reverse shell server port:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "payload code base server port:";
            // 
            // payloadCodeBaseServerPort
            // 
            this.payloadCodeBaseServerPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payloadCodeBaseServerPort.Location = new System.Drawing.Point(260, 3);
            this.payloadCodeBaseServerPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.payloadCodeBaseServerPort.Name = "payloadCodeBaseServerPort";
            this.payloadCodeBaseServerPort.Size = new System.Drawing.Size(79, 27);
            this.payloadCodeBaseServerPort.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "LDAP server port:";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.radioButton1, 2);
            this.radioButton1.Location = new System.Drawing.Point(10, 132);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "hide terminals";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button4, 2);
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(336, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox3.MaxLength = 2147483647;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(439, 385);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(0, 385);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(439, 27);
            this.textBox2.TabIndex = 0;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // DoS
            // 
            this.DoS.Controls.Add(this.label5);
            this.DoS.Controls.Add(this.button3);
            this.DoS.Controls.Add(this.button2);
            this.DoS.Controls.Add(this.trackBar1);
            this.DoS.Controls.Add(this.textBox1);
            this.DoS.Controls.Add(this.button1);
            this.DoS.Location = new System.Drawing.Point(4, 29);
            this.DoS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoS.Name = "DoS";
            this.DoS.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoS.Size = new System.Drawing.Size(792, 418);
            this.DoS.TabIndex = 2;
            this.DoS.Text = "DoS";
            this.DoS.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Set frequency of requests:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 293);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 293);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(250, 225);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(229, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "URL";
            this.textBox1.Size = new System.Drawing.Size(227, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send single request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailCaptureTab
            // 
            this.EmailCaptureTab.Controls.Add(this.portNumericUpDown);
            this.EmailCaptureTab.Controls.Add(this.bodyTextBox);
            this.EmailCaptureTab.Controls.Add(this.subjectTextBox);
            this.EmailCaptureTab.Controls.Add(this.recipientTextBox);
            this.EmailCaptureTab.Controls.Add(this.senderTextBox);
            this.EmailCaptureTab.Controls.Add(this.bodyLabel);
            this.EmailCaptureTab.Controls.Add(this.subjectLabel);
            this.EmailCaptureTab.Controls.Add(this.recipientLabel);
            this.EmailCaptureTab.Controls.Add(this.senderLabel);
            this.EmailCaptureTab.Controls.Add(this.label6);
            this.EmailCaptureTab.Controls.Add(this.label7);
            this.EmailCaptureTab.Controls.Add(this.passwordTextBox);
            this.EmailCaptureTab.Controls.Add(this.loginTextBox);
            this.EmailCaptureTab.Controls.Add(this.label8);
            this.EmailCaptureTab.Controls.Add(this.label9);
            this.EmailCaptureTab.Controls.Add(this.sendEmailButton);
            this.EmailCaptureTab.Controls.Add(this.serverTextBox);
            this.EmailCaptureTab.Location = new System.Drawing.Point(4, 29);
            this.EmailCaptureTab.Name = "EmailCaptureTab";
            this.EmailCaptureTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmailCaptureTab.Size = new System.Drawing.Size(792, 418);
            this.EmailCaptureTab.TabIndex = 3;
            this.EmailCaptureTab.Text = "EmailCapture";
            this.EmailCaptureTab.UseVisualStyleBackColor = true;
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Location = new System.Drawing.Point(361, 14);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(64, 27);
            this.portNumericUpDown.TabIndex = 34;
            this.portNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Location = new System.Drawing.Point(104, 257);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(269, 111);
            this.bodyTextBox.TabIndex = 33;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(104, 215);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(269, 27);
            this.subjectTextBox.TabIndex = 32;
            // 
            // recipientTextBox
            // 
            this.recipientTextBox.Location = new System.Drawing.Point(104, 174);
            this.recipientTextBox.Name = "recipientTextBox";
            this.recipientTextBox.Size = new System.Drawing.Size(269, 27);
            this.recipientTextBox.TabIndex = 31;
            // 
            // senderTextBox
            // 
            this.senderTextBox.Location = new System.Drawing.Point(104, 135);
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(269, 27);
            this.senderTextBox.TabIndex = 30;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(24, 260);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(45, 20);
            this.bodyLabel.TabIndex = 29;
            this.bodyLabel.Text = "Treść:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(24, 218);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(53, 20);
            this.subjectLabel.TabIndex = 28;
            this.subjectLabel.Text = "Temat:";
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Location = new System.Drawing.Point(24, 177);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(74, 20);
            this.recipientLabel.TabIndex = 27;
            this.recipientLabel.Text = "Odbiorca:";
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Location = new System.Drawing.Point(24, 135);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(74, 20);
            this.senderLabel.TabIndex = 26;
            this.senderLabel.Text = "Nadawca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hasło:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Login:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(87, 80);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(125, 27);
            this.passwordTextBox.TabIndex = 23;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(87, 47);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(125, 27);
            this.loginTextBox.TabIndex = 22;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Port:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Serwer:";
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Location = new System.Drawing.Point(24, 374);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(401, 29);
            this.sendEmailButton.TabIndex = 19;
            this.sendEmailButton.Text = "Wyślij";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(87, 14);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(224, 27);
            this.serverTextBox.TabIndex = 18;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Wireshark, scenario simulator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ldapServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reverseShellListenerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payloadCodeBaseServerPort)).EndInit();
            this.DoS.ResumeLayout(false);
            this.DoS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.EmailCaptureTab.ResumeLayout(false);
            this.EmailCaptureTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private TabPage DoS;
        private Button button1;
        private Button button2;
        private TrackBar trackBar1;
        private TextBox textBox1;
        private Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown reverseShellListenerPort;
        private Label label4;
        private Label label3;
        private NumericUpDown payloadCodeBaseServerPort;
        private NumericUpDown ldapServerPort;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button5;
        private Label label5;
        private TabPage EmailCaptureTab;
        private NumericUpDown portNumericUpDown;
        private TextBox bodyTextBox;
        private TextBox subjectTextBox;
        private TextBox recipientTextBox;
        private TextBox senderTextBox;
        private Label bodyLabel;
        private Label subjectLabel;
        private Label recipientLabel;
        private Label senderLabel;
        private Label label6;
        private Label label7;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private Label label8;
        private Label label9;
        private Button sendEmailButton;
        private TextBox serverTextBox;
    }
}