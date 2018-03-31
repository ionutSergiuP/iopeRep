partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtCntHost = new System.Windows.Forms.ToolStripTextBox();
            this.txtCntPort = new System.Windows.Forms.ToolStripTextBox();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuTransfers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSendFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStopTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPauseTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClearComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressOverall = new System.Windows.Forms.ToolStripProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.brwTotalC = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brwBook = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.brwTaskbar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.brwDesktop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.brwLotusArc = new System.Windows.Forms.Button();
            this.brwLotusp = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsametime = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendFiles = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.menuTransfers.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtCntHost,
            this.txtCntPort,
            this.btnConnect,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 24);
            this.toolStripLabel1.Text = "Host:";
            // 
            // txtCntHost
            // 
            this.txtCntHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCntHost.Name = "txtCntHost";
            this.txtCntHost.Size = new System.Drawing.Size(133, 27);
            this.txtCntHost.Text = "10.198.96.99";
            this.txtCntHost.Click += new System.EventHandler(this.txtCntHost_Click);
            // 
            // txtCntPort
            // 
            this.txtCntPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCntPort.Name = "txtCntPort";
            this.txtCntPort.Size = new System.Drawing.Size(39, 27);
            this.txtCntPort.Text = "100";
            this.txtCntPort.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(67, 24);
            this.btnConnect.Text = "Connect";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // menuTransfers
            // 
            this.menuTransfers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTransfers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSendFile,
            this.btnStopTransfer,
            this.btnPauseTransfer,
            this.toolStripMenuItem1,
            this.btnClearComplete});
            this.menuTransfers.Name = "contextMenuStrip1";
            this.menuTransfers.Size = new System.Drawing.Size(182, 106);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(181, 24);
            this.btnSendFile.Text = "Send";
            // 
            // btnStopTransfer
            // 
            this.btnStopTransfer.Name = "btnStopTransfer";
            this.btnStopTransfer.Size = new System.Drawing.Size(181, 24);
            this.btnStopTransfer.Text = "Stop";
            // 
            // btnPauseTransfer
            // 
            this.btnPauseTransfer.Name = "btnPauseTransfer";
            this.btnPauseTransfer.Size = new System.Drawing.Size(181, 24);
            this.btnPauseTransfer.Text = "Pause";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // btnClearComplete
            // 
            this.btnClearComplete.Name = "btnClearComplete";
            this.btnClearComplete.Size = new System.Drawing.Size(181, 24);
            this.btnClearComplete.Text = "Clear Complete";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserName,
            this.lblConnected,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.progressOverall});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(645, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = false;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 21);
            this.lblUserName.Text = "User:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserName.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblConnected
            // 
            this.lblConnected.BackColor = System.Drawing.Color.Transparent;
            this.lblConnected.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(296, 21);
            this.lblConnected.Spring = true;
            this.lblConnected.Text = "Connection: -";
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 21);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(65, 21);
            this.toolStripStatusLabel3.Text = "Progress";
            // 
            // progressOverall
            // 
            this.progressOverall.AutoToolTip = true;
            this.progressOverall.Name = "progressOverall";
            this.progressOverall.Size = new System.Drawing.Size(149, 20);
            this.progressOverall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total commander shortcuts";
            // 
            // brwTotalC
            // 
            this.brwTotalC.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.brwTotalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwTotalC.Location = new System.Drawing.Point(387, 210);
            this.brwTotalC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brwTotalC.Name = "brwTotalC";
            this.brwTotalC.Size = new System.Drawing.Size(112, 34);
            this.brwTotalC.TabIndex = 12;
            this.brwTotalC.Text = "Browse";
            this.brwTotalC.UseVisualStyleBackColor = false;
            this.brwTotalC.Click += new System.EventHandler(this.brwTotalC_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(9, 218);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(349, 30);
            this.textBox7.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Browser Bookmarks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Taskbar Shortcuts";
            // 
            // brwBook
            // 
            this.brwBook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.brwBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwBook.Location = new System.Drawing.Point(387, 162);
            this.brwBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brwBook.Name = "brwBook";
            this.brwBook.Size = new System.Drawing.Size(112, 34);
            this.brwBook.TabIndex = 8;
            this.brwBook.Text = "Browse";
            this.brwBook.UseVisualStyleBackColor = false;
            this.brwBook.Click += new System.EventHandler(this.brwBook_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 166);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(349, 30);
            this.textBox3.TabIndex = 7;
            // 
            // brwTaskbar
            // 
            this.brwTaskbar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.brwTaskbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwTaskbar.Location = new System.Drawing.Point(387, 101);
            this.brwTaskbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brwTaskbar.Name = "brwTaskbar";
            this.brwTaskbar.Size = new System.Drawing.Size(112, 38);
            this.brwTaskbar.TabIndex = 6;
            this.brwTaskbar.Text = "Browse";
            this.brwTaskbar.UseVisualStyleBackColor = false;
            this.brwTaskbar.Click += new System.EventHandler(this.brwTaskbar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 107);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 30);
            this.textBox2.TabIndex = 5;
            // 
            // brwDesktop
            // 
            this.brwDesktop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.brwDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwDesktop.Location = new System.Drawing.Point(387, 41);
            this.brwDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brwDesktop.Name = "brwDesktop";
            this.brwDesktop.Size = new System.Drawing.Size(112, 38);
            this.brwDesktop.TabIndex = 4;
            this.brwDesktop.Text = "Browse";
            this.brwDesktop.UseVisualStyleBackColor = false;
            this.brwDesktop.Click += new System.EventHandler(this.brwDesktop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desktop Shortcuts";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 30);
            this.textBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "@\"c:\\\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lotus bookmark";
            // 
            // brwLotusArc
            // 
            this.brwLotusArc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.brwLotusArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwLotusArc.Location = new System.Drawing.Point(377, 101);
            this.brwLotusArc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brwLotusArc.Name = "brwLotusArc";
            this.brwLotusArc.Size = new System.Drawing.Size(112, 34);
            this.brwLotusArc.TabIndex = 13;
            this.brwLotusArc.Text = "Browse";
            this.brwLotusArc.UseVisualStyleBackColor = false;
            this.brwLotusArc.Click += new System.EventHandler(this.brwLotusArc_Click);
            // 
            // brwLotusp
            // 
            this.brwLotusp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.brwLotusp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwLotusp.Location = new System.Drawing.Point(377, 46);
            this.brwLotusp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brwLotusp.Name = "brwLotusp";
            this.brwLotusp.Size = new System.Drawing.Size(112, 36);
            this.brwLotusp.TabIndex = 11;
            this.brwLotusp.Text = "Browse";
            this.brwLotusp.UseVisualStyleBackColor = false;
            this.brwLotusp.Click += new System.EventHandler(this.brwLotusp_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 110);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(335, 30);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 46);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(335, 30);
            this.textBox4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lotus Mail Archive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lotus profile";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnsametime);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.brwLotusArc);
            this.groupBox2.Controls.Add(this.brwLotusp);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 340);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(536, 241);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lotus Settings and Archives";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lotus Sametime Transcripts";
            // 
            // btnsametime
            // 
            this.btnsametime.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsametime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsametime.Location = new System.Drawing.Point(377, 177);
            this.btnsametime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsametime.Name = "btnsametime";
            this.btnsametime.Size = new System.Drawing.Size(112, 34);
            this.btnsametime.TabIndex = 16;
            this.btnsametime.Text = "Browse";
            this.btnsametime.UseVisualStyleBackColor = false;
            this.btnsametime.Click += new System.EventHandler(this.btnsametime_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(13, 180);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(335, 30);
            this.textBox6.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.brwTotalC);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.brwBook);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.brwTaskbar);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.brwDesktop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(25, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(536, 287);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile and Shortcuts";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSendFiles
            // 
            this.btnSendFiles.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSendFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFiles.Location = new System.Drawing.Point(235, 597);
            this.btnSendFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendFiles.Name = "btnSendFiles";
            this.btnSendFiles.Size = new System.Drawing.Size(140, 34);
            this.btnSendFiles.TabIndex = 14;
            this.btnSendFiles.Text = "Send Files";
            this.btnSendFiles.UseVisualStyleBackColor = false;
            this.btnSendFiles.Click += new System.EventHandler(this.btnSendFiles_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 672);
            this.Controls.Add(this.btnSendFiles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Settings Transfer Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuTransfers.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripTextBox txtCntHost;
    private System.Windows.Forms.ToolStripTextBox txtCntPort;
    private System.Windows.Forms.ToolStripButton btnConnect;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ContextMenuStrip menuTransfers;
    private System.Windows.Forms.ToolStripMenuItem btnSendFile;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem btnClearComplete;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblConnected;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    private System.Windows.Forms.ToolStripProgressBar progressOverall;
    private System.Windows.Forms.ToolStripMenuItem btnStopTransfer;
    private System.Windows.Forms.ToolStripMenuItem btnPauseTransfer;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button brwTotalC;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button brwBook;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button brwTaskbar;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button brwDesktop;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button brwLotusArc;
    private System.Windows.Forms.Button brwLotusp;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSendFiles;
    private System.Windows.Forms.ToolStripStatusLabel lblUserName;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnsametime;
    private System.Windows.Forms.TextBox textBox6;
}

