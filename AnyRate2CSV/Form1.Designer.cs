namespace AnyRate2CSV
{
  partial class AnyRate2CSV
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnyRate2CSV));
      this.btnSettings = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnPYSnapQueue = new System.Windows.Forms.Button();
      this.btnClearV2Queue = new System.Windows.Forms.Button();
      this.btnStartExtractRates = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPYRCreateQSpreeNum = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPYRCreateQRetries = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtPYRCreateQFreshFactor = new System.Windows.Forms.TextBox();
      this.grpboxPYRCreateQ = new System.Windows.Forms.GroupBox();
      this.numUpDnPYRCreateQDaysBack = new System.Windows.Forms.NumericUpDown();
      this.btnStartPYRQueue = new System.Windows.Forms.Button();
      this.grpboxPYRSoldOutPlusOne = new System.Windows.Forms.GroupBox();
      this.btnStartPYRSoldOutPlusOne = new System.Windows.Forms.Button();
      this.txtPYRSoldOutPlusOneSessionID = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
      this.grpboxExtractCreateCSV = new System.Windows.Forms.GroupBox();
      this.lblReportDateExtractCSV = new System.Windows.Forms.Label();
      this.dateTimeExtractCSV = new System.Windows.Forms.DateTimePicker();
      this.radbtnOtherFormat = new System.Windows.Forms.RadioButton();
      this.txtCSVOutputFile = new System.Windows.Forms.TextBox();
      this.btnCSVFileOutput = new System.Windows.Forms.Button();
      this.radbtnHSDSFormat = new System.Windows.Forms.RadioButton();
      this.numUpDnExtractCSVDaysBack = new System.Windows.Forms.NumericUpDown();
      this.txtFileNameFormat = new System.Windows.Forms.TextBox();
      this.btnStartExtractReviews = new System.Windows.Forms.Button();
      this.lblExtractCSVDaysBack = new System.Windows.Forms.Label();
      this.radbtnPYRFormat = new System.Windows.Forms.RadioButton();
      this.txtExtractCSVLoginCode = new System.Windows.Forms.TextBox();
      this.lblExtractCSVLoginCode = new System.Windows.Forms.Label();
      this.picARLogo = new System.Windows.Forms.PictureBox();
      this.txtStatusWindow = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.folderCSVOutput = new System.Windows.Forms.FolderBrowserDialog();
      this.groupBox1.SuspendLayout();
      this.grpboxPYRCreateQ.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDnPYRCreateQDaysBack)).BeginInit();
      this.grpboxPYRSoldOutPlusOne.SuspendLayout();
      this.grpboxExtractCreateCSV.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtractCSVDaysBack)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picARLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSettings
      // 
      this.btnSettings.ForeColor = System.Drawing.Color.DarkBlue;
      this.btnSettings.Location = new System.Drawing.Point(13, 19);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Size = new System.Drawing.Size(126, 25);
      this.btnSettings.TabIndex = 2;
      this.btnSettings.Text = "Settings";
      this.btnSettings.UseVisualStyleBackColor = true;
      this.btnSettings.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnPYSnapQueue);
      this.groupBox1.Controls.Add(this.btnClearV2Queue);
      this.groupBox1.Controls.Add(this.btnSettings);
      this.groupBox1.Location = new System.Drawing.Point(214, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(165, 138);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
      // 
      // btnPYSnapQueue
      // 
      this.btnPYSnapQueue.ForeColor = System.Drawing.Color.DarkBlue;
      this.btnPYSnapQueue.Location = new System.Drawing.Point(13, 100);
      this.btnPYSnapQueue.Name = "btnPYSnapQueue";
      this.btnPYSnapQueue.Size = new System.Drawing.Size(126, 25);
      this.btnPYSnapQueue.TabIndex = 6;
      this.btnPYSnapQueue.Text = "PYR Snap Queue";
      this.btnPYSnapQueue.UseVisualStyleBackColor = true;
      this.btnPYSnapQueue.Click += new System.EventHandler(this.btnPYSnapQueue_Click);
      // 
      // btnClearV2Queue
      // 
      this.btnClearV2Queue.ForeColor = System.Drawing.Color.DarkBlue;
      this.btnClearV2Queue.Location = new System.Drawing.Point(13, 59);
      this.btnClearV2Queue.Name = "btnClearV2Queue";
      this.btnClearV2Queue.Size = new System.Drawing.Size(126, 25);
      this.btnClearV2Queue.TabIndex = 5;
      this.btnClearV2Queue.Text = "Clear V2 Queue";
      this.btnClearV2Queue.UseVisualStyleBackColor = true;
      this.btnClearV2Queue.Click += new System.EventHandler(this.btnClearV2Queue_Click);
      // 
      // btnStartExtractRates
      // 
      this.btnStartExtractRates.ForeColor = System.Drawing.Color.DarkBlue;
      this.btnStartExtractRates.Location = new System.Drawing.Point(20, 261);
      this.btnStartExtractRates.Name = "btnStartExtractRates";
      this.btnStartExtractRates.Size = new System.Drawing.Size(126, 25);
      this.btnStartExtractRates.TabIndex = 4;
      this.btnStartExtractRates.Text = "Start Extract - Rates";
      this.btnStartExtractRates.UseVisualStyleBackColor = true;
      this.btnStartExtractRates.Click += new System.EventHandler(this.btnStartExtractRates_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
      this.label2.Location = new System.Drawing.Point(110, 26);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Days Back";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
      this.label3.Location = new System.Drawing.Point(15, 26);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(75, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Spree Number";
      // 
      // txtPYRCreateQSpreeNum
      // 
      this.txtPYRCreateQSpreeNum.BackColor = System.Drawing.SystemColors.Window;
      this.txtPYRCreateQSpreeNum.Location = new System.Drawing.Point(15, 45);
      this.txtPYRCreateQSpreeNum.Name = "txtPYRCreateQSpreeNum";
      this.txtPYRCreateQSpreeNum.Size = new System.Drawing.Size(75, 20);
      this.txtPYRCreateQSpreeNum.TabIndex = 7;
      this.txtPYRCreateQSpreeNum.TextChanged += new System.EventHandler(this.txtPYRCreateQSpreeNum_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
      this.label4.Location = new System.Drawing.Point(188, 26);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Retries";
      // 
      // txtPYRCreateQRetries
      // 
      this.txtPYRCreateQRetries.Location = new System.Drawing.Point(196, 45);
      this.txtPYRCreateQRetries.Name = "txtPYRCreateQRetries";
      this.txtPYRCreateQRetries.Size = new System.Drawing.Size(21, 20);
      this.txtPYRCreateQRetries.TabIndex = 9;
      this.txtPYRCreateQRetries.Text = "2";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
      this.label5.Location = new System.Drawing.Point(246, 26);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(66, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Fresh Factor";
      // 
      // txtPYRCreateQFreshFactor
      // 
      this.txtPYRCreateQFreshFactor.Location = new System.Drawing.Point(249, 45);
      this.txtPYRCreateQFreshFactor.Name = "txtPYRCreateQFreshFactor";
      this.txtPYRCreateQFreshFactor.Size = new System.Drawing.Size(40, 20);
      this.txtPYRCreateQFreshFactor.TabIndex = 11;
      this.txtPYRCreateQFreshFactor.Text = "0";
      // 
      // grpboxPYRCreateQ
      // 
      this.grpboxPYRCreateQ.Controls.Add(this.numUpDnPYRCreateQDaysBack);
      this.grpboxPYRCreateQ.Controls.Add(this.btnStartPYRQueue);
      this.grpboxPYRCreateQ.Controls.Add(this.label2);
      this.grpboxPYRCreateQ.Controls.Add(this.label5);
      this.grpboxPYRCreateQ.Controls.Add(this.txtPYRCreateQFreshFactor);
      this.grpboxPYRCreateQ.Controls.Add(this.txtPYRCreateQSpreeNum);
      this.grpboxPYRCreateQ.Controls.Add(this.label4);
      this.grpboxPYRCreateQ.Controls.Add(this.label3);
      this.grpboxPYRCreateQ.Controls.Add(this.txtPYRCreateQRetries);
      this.grpboxPYRCreateQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(209)))), ((int)(((byte)(44)))));
      this.grpboxPYRCreateQ.Location = new System.Drawing.Point(18, 188);
      this.grpboxPYRCreateQ.Name = "grpboxPYRCreateQ";
      this.grpboxPYRCreateQ.Size = new System.Drawing.Size(322, 123);
      this.grpboxPYRCreateQ.TabIndex = 13;
      this.grpboxPYRCreateQ.TabStop = false;
      this.grpboxPYRCreateQ.Text = "PYR Create Queue";
      // 
      // numUpDnPYRCreateQDaysBack
      // 
      this.numUpDnPYRCreateQDaysBack.Location = new System.Drawing.Point(122, 45);
      this.numUpDnPYRCreateQDaysBack.Name = "numUpDnPYRCreateQDaysBack";
      this.numUpDnPYRCreateQDaysBack.Size = new System.Drawing.Size(36, 20);
      this.numUpDnPYRCreateQDaysBack.TabIndex = 15;
      // 
      // btnStartPYRQueue
      // 
      this.btnStartPYRQueue.ForeColor = System.Drawing.Color.DarkBlue;
      this.btnStartPYRQueue.Location = new System.Drawing.Point(96, 81);
      this.btnStartPYRQueue.Name = "btnStartPYRQueue";
      this.btnStartPYRQueue.Size = new System.Drawing.Size(132, 23);
      this.btnStartPYRQueue.TabIndex = 13;
      this.btnStartPYRQueue.Text = "Start PYR Queue";
      this.btnStartPYRQueue.UseVisualStyleBackColor = true;
      this.btnStartPYRQueue.Click += new System.EventHandler(this.button2_Click);
      // 
      // grpboxPYRSoldOutPlusOne
      // 
      this.grpboxPYRSoldOutPlusOne.Controls.Add(this.btnStartPYRSoldOutPlusOne);
      this.grpboxPYRSoldOutPlusOne.Controls.Add(this.txtPYRSoldOutPlusOneSessionID);
      this.grpboxPYRSoldOutPlusOne.Controls.Add(this.label6);
      this.grpboxPYRSoldOutPlusOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(209)))), ((int)(((byte)(44)))));
      this.grpboxPYRSoldOutPlusOne.Location = new System.Drawing.Point(18, 349);
      this.grpboxPYRSoldOutPlusOne.Name = "grpboxPYRSoldOutPlusOne";
      this.grpboxPYRSoldOutPlusOne.Size = new System.Drawing.Size(217, 130);
      this.grpboxPYRSoldOutPlusOne.TabIndex = 14;
      this.grpboxPYRSoldOutPlusOne.TabStop = false;
      this.grpboxPYRSoldOutPlusOne.Text = "PYR Sold Out Plus One";
      this.grpboxPYRSoldOutPlusOne.Enter += new System.EventHandler(this.groupBox3_Enter);
      // 
      // btnStartPYRSoldOutPlusOne
      // 
      this.btnStartPYRSoldOutPlusOne.ForeColor = System.Drawing.Color.DarkBlue;
      this.btnStartPYRSoldOutPlusOne.Location = new System.Drawing.Point(15, 82);
      this.btnStartPYRSoldOutPlusOne.Name = "btnStartPYRSoldOutPlusOne";
      this.btnStartPYRSoldOutPlusOne.Size = new System.Drawing.Size(154, 28);
      this.btnStartPYRSoldOutPlusOne.TabIndex = 11;
      this.btnStartPYRSoldOutPlusOne.Text = "Start PYR Sold Out Plus One";
      this.btnStartPYRSoldOutPlusOne.UseVisualStyleBackColor = true;
      // 
      // txtPYRSoldOutPlusOneSessionID
      // 
      this.txtPYRSoldOutPlusOneSessionID.BackColor = System.Drawing.SystemColors.Window;
      this.txtPYRSoldOutPlusOneSessionID.Location = new System.Drawing.Point(15, 44);
      this.txtPYRSoldOutPlusOneSessionID.Name = "txtPYRSoldOutPlusOneSessionID";
      this.txtPYRSoldOutPlusOneSessionID.Size = new System.Drawing.Size(186, 20);
      this.txtPYRSoldOutPlusOneSessionID.TabIndex = 9;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
      this.label6.Location = new System.Drawing.Point(15, 25);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(58, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "Session ID";
      // 
      // monthCalendar1
      // 
      this.monthCalendar1.Location = new System.Drawing.Point(18, 493);
      this.monthCalendar1.Name = "monthCalendar1";
      this.monthCalendar1.TabIndex = 4;
      // 
      // grpboxExtractCreateCSV
      // 
      this.grpboxExtractCreateCSV.Controls.Add(this.lblReportDateExtractCSV);
      this.grpboxExtractCreateCSV.Controls.Add(this.dateTimeExtractCSV);
      this.grpboxExtractCreateCSV.Controls.Add(this.radbtnOtherFormat);
      this.grpboxExtractCreateCSV.Controls.Add(this.txtCSVOutputFile);
      this.grpboxExtractCreateCSV.Controls.Add(this.btnCSVFileOutput);
      this.grpboxExtractCreateCSV.Controls.Add(this.radbtnHSDSFormat);
      this.grpboxExtractCreateCSV.Controls.Add(this.numUpDnExtractCSVDaysBack);
      this.grpboxExtractCreateCSV.Controls.Add(this.txtFileNameFormat);
      this.grpboxExtractCreateCSV.Controls.Add(this.btnStartExtractReviews);
      this.grpboxExtractCreateCSV.Controls.Add(this.lblExtractCSVDaysBack);
      this.grpboxExtractCreateCSV.Controls.Add(this.radbtnPYRFormat);
      this.grpboxExtractCreateCSV.Controls.Add(this.txtExtractCSVLoginCode);
      this.grpboxExtractCreateCSV.Controls.Add(this.lblExtractCSVLoginCode);
      this.grpboxExtractCreateCSV.Controls.Add(this.btnStartExtractRates);
      this.grpboxExtractCreateCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
      this.grpboxExtractCreateCSV.Location = new System.Drawing.Point(279, 344);
      this.grpboxExtractCreateCSV.Name = "grpboxExtractCreateCSV";
      this.grpboxExtractCreateCSV.Size = new System.Drawing.Size(410, 311);
      this.grpboxExtractCreateCSV.TabIndex = 17;
      this.grpboxExtractCreateCSV.TabStop = false;
      this.grpboxExtractCreateCSV.Text = "Extract and Create CSV";
      // 
      // lblReportDateExtractCSV
      // 
      this.lblReportDateExtractCSV.AutoSize = true;
      this.lblReportDateExtractCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
      this.lblReportDateExtractCSV.Location = new System.Drawing.Point(20, 79);
      this.lblReportDateExtractCSV.Name = "lblReportDateExtractCSV";
      this.lblReportDateExtractCSV.Size = new System.Drawing.Size(65, 13);
      this.lblReportDateExtractCSV.TabIndex = 23;
      this.lblReportDateExtractCSV.Text = "Report Date";
      // 
      // dateTimeExtractCSV
      // 
      this.dateTimeExtractCSV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimeExtractCSV.Location = new System.Drawing.Point(20, 95);
      this.dateTimeExtractCSV.Name = "dateTimeExtractCSV";
      this.dateTimeExtractCSV.Size = new System.Drawing.Size(200, 20);
      this.dateTimeExtractCSV.TabIndex = 22;
      this.dateTimeExtractCSV.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // radbtnOtherFormat
      // 
      this.radbtnOtherFormat.AutoSize = true;
      this.radbtnOtherFormat.Location = new System.Drawing.Point(213, 126);
      this.radbtnOtherFormat.Name = "radbtnOtherFormat";
      this.radbtnOtherFormat.Size = new System.Drawing.Size(86, 17);
      this.radbtnOtherFormat.TabIndex = 21;
      this.radbtnOtherFormat.TabStop = true;
      this.radbtnOtherFormat.Text = "Other Format";
      this.radbtnOtherFormat.UseVisualStyleBackColor = true;
      this.radbtnOtherFormat.CheckedChanged += new System.EventHandler(this.radbtnOtherFormat_CheckedChanged);
      // 
      // txtCSVOutputFile
      // 
      this.txtCSVOutputFile.Location = new System.Drawing.Point(20, 212);
      this.txtCSVOutputFile.Name = "txtCSVOutputFile";
      this.txtCSVOutputFile.Size = new System.Drawing.Size(363, 20);
      this.txtCSVOutputFile.TabIndex = 17;
      // 
      // btnCSVFileOutput
      // 
      this.btnCSVFileOutput.ForeColor = System.Drawing.Color.DarkBlue;
      this.btnCSVFileOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnCSVFileOutput.Image")));
      this.btnCSVFileOutput.Location = new System.Drawing.Point(20, 181);
      this.btnCSVFileOutput.Name = "btnCSVFileOutput";
      this.btnCSVFileOutput.Size = new System.Drawing.Size(173, 25);
      this.btnCSVFileOutput.TabIndex = 16;
      this.btnCSVFileOutput.Text = "CSV Output File Location";
      this.btnCSVFileOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnCSVFileOutput.UseVisualStyleBackColor = true;
      this.btnCSVFileOutput.Click += new System.EventHandler(this.button7_Click);
      // 
      // radbtnHSDSFormat
      // 
      this.radbtnHSDSFormat.AutoSize = true;
      this.radbtnHSDSFormat.Location = new System.Drawing.Point(117, 126);
      this.radbtnHSDSFormat.Name = "radbtnHSDSFormat";
      this.radbtnHSDSFormat.Size = new System.Drawing.Size(90, 17);
      this.radbtnHSDSFormat.TabIndex = 20;
      this.radbtnHSDSFormat.TabStop = true;
      this.radbtnHSDSFormat.Text = "HSDS Format";
      this.radbtnHSDSFormat.UseVisualStyleBackColor = true;
      this.radbtnHSDSFormat.CheckedChanged += new System.EventHandler(this.radbtnHSDSFormat_CheckedChanged);
      // 
      // numUpDnExtractCSVDaysBack
      // 
      this.numUpDnExtractCSVDaysBack.Location = new System.Drawing.Point(264, 44);
      this.numUpDnExtractCSVDaysBack.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.numUpDnExtractCSVDaysBack.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            -2147483648});
      this.numUpDnExtractCSVDaysBack.Name = "numUpDnExtractCSVDaysBack";
      this.numUpDnExtractCSVDaysBack.Size = new System.Drawing.Size(36, 20);
      this.numUpDnExtractCSVDaysBack.TabIndex = 14;
      // 
      // txtFileNameFormat
      // 
      this.txtFileNameFormat.Location = new System.Drawing.Point(20, 149);
      this.txtFileNameFormat.Name = "txtFileNameFormat";
      this.txtFileNameFormat.Size = new System.Drawing.Size(363, 20);
      this.txtFileNameFormat.TabIndex = 19;
      // 
      // btnStartExtractReviews
      // 
      this.btnStartExtractReviews.ForeColor = System.Drawing.Color.DarkBlue;
      this.btnStartExtractReviews.Location = new System.Drawing.Point(238, 261);
      this.btnStartExtractReviews.Name = "btnStartExtractReviews";
      this.btnStartExtractReviews.Size = new System.Drawing.Size(126, 25);
      this.btnStartExtractReviews.TabIndex = 13;
      this.btnStartExtractReviews.Text = "Start Extract - Reviews";
      this.btnStartExtractReviews.UseVisualStyleBackColor = true;
      // 
      // lblExtractCSVDaysBack
      // 
      this.lblExtractCSVDaysBack.AutoSize = true;
      this.lblExtractCSVDaysBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
      this.lblExtractCSVDaysBack.Location = new System.Drawing.Point(257, 25);
      this.lblExtractCSVDaysBack.Name = "lblExtractCSVDaysBack";
      this.lblExtractCSVDaysBack.Size = new System.Drawing.Size(59, 13);
      this.lblExtractCSVDaysBack.TabIndex = 12;
      this.lblExtractCSVDaysBack.Text = "Days Back";
      // 
      // radbtnPYRFormat
      // 
      this.radbtnPYRFormat.AutoSize = true;
      this.radbtnPYRFormat.Location = new System.Drawing.Point(26, 126);
      this.radbtnPYRFormat.Name = "radbtnPYRFormat";
      this.radbtnPYRFormat.Size = new System.Drawing.Size(82, 17);
      this.radbtnPYRFormat.TabIndex = 18;
      this.radbtnPYRFormat.TabStop = true;
      this.radbtnPYRFormat.Text = "PYR Format";
      this.radbtnPYRFormat.UseVisualStyleBackColor = true;
      this.radbtnPYRFormat.CheckedChanged += new System.EventHandler(this.radbtnPYRFormat_CheckedChanged);
      // 
      // txtExtractCSVLoginCode
      // 
      this.txtExtractCSVLoginCode.BackColor = System.Drawing.SystemColors.Window;
      this.txtExtractCSVLoginCode.Location = new System.Drawing.Point(20, 44);
      this.txtExtractCSVLoginCode.Name = "txtExtractCSVLoginCode";
      this.txtExtractCSVLoginCode.Size = new System.Drawing.Size(176, 20);
      this.txtExtractCSVLoginCode.TabIndex = 9;
      this.txtExtractCSVLoginCode.TextChanged += new System.EventHandler(this.txtExtractCSVLoginCode_TextChanged);
      // 
      // lblExtractCSVLoginCode
      // 
      this.lblExtractCSVLoginCode.AutoSize = true;
      this.lblExtractCSVLoginCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
      this.lblExtractCSVLoginCode.Location = new System.Drawing.Point(20, 25);
      this.lblExtractCSVLoginCode.Name = "lblExtractCSVLoginCode";
      this.lblExtractCSVLoginCode.Size = new System.Drawing.Size(61, 13);
      this.lblExtractCSVLoginCode.TabIndex = 10;
      this.lblExtractCSVLoginCode.Text = "Login Code";
      // 
      // picARLogo
      // 
      this.picARLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picARLogo.BackgroundImage")));
      this.picARLogo.Location = new System.Drawing.Point(18, 12);
      this.picARLogo.Name = "picARLogo";
      this.picARLogo.Size = new System.Drawing.Size(169, 93);
      this.picARLogo.TabIndex = 16;
      this.picARLogo.TabStop = false;
      this.picARLogo.Click += new System.EventHandler(this.pictureBox1_Click_1);
      // 
      // txtStatusWindow
      // 
      this.txtStatusWindow.Location = new System.Drawing.Point(746, 34);
      this.txtStatusWindow.Multiline = true;
      this.txtStatusWindow.Name = "txtStatusWindow";
      this.txtStatusWindow.Size = new System.Drawing.Size(412, 677);
      this.txtStatusWindow.TabIndex = 22;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
      this.label1.Location = new System.Drawing.Point(743, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 13);
      this.label1.TabIndex = 23;
      this.label1.Text = "Status Window";
      // 
      // folderCSVOutput
      // 
      this.folderCSVOutput.HelpRequest += new System.EventHandler(this.folderCSVOutput_HelpRequest);
      // 
      // AnyRate2CSV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkGreen;
      this.ClientSize = new System.Drawing.Size(1183, 735);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.grpboxExtractCreateCSV);
      this.Controls.Add(this.txtStatusWindow);
      this.Controls.Add(this.picARLogo);
      this.Controls.Add(this.grpboxPYRSoldOutPlusOne);
      this.Controls.Add(this.grpboxPYRCreateQ);
      this.Controls.Add(this.monthCalendar1);
      this.Controls.Add(this.groupBox1);
      this.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "AnyRate2CSV";
      this.Text = "AnyRate 2 CSV";
      this.Load += new System.EventHandler(this.AnyRate2CSV_Load);
      this.groupBox1.ResumeLayout(false);
      this.grpboxPYRCreateQ.ResumeLayout(false);
      this.grpboxPYRCreateQ.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDnPYRCreateQDaysBack)).EndInit();
      this.grpboxPYRSoldOutPlusOne.ResumeLayout(false);
      this.grpboxPYRSoldOutPlusOne.PerformLayout();
      this.grpboxExtractCreateCSV.ResumeLayout(false);
      this.grpboxExtractCreateCSV.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtractCSVDaysBack)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picARLogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSettings;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnStartExtractRates;
    private System.Windows.Forms.Button btnClearV2Queue;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPYRCreateQSpreeNum;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPYRCreateQRetries;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtPYRCreateQFreshFactor;
    private System.Windows.Forms.GroupBox grpboxPYRCreateQ;
    private System.Windows.Forms.Button btnStartPYRQueue;
    private System.Windows.Forms.GroupBox grpboxPYRSoldOutPlusOne;
    private System.Windows.Forms.TextBox txtPYRSoldOutPlusOneSessionID;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnStartPYRSoldOutPlusOne;
    private System.Windows.Forms.MonthCalendar monthCalendar1;
    private System.Windows.Forms.PictureBox picARLogo;
    private System.Windows.Forms.Button btnPYSnapQueue;
    private System.Windows.Forms.NumericUpDown numUpDnPYRCreateQDaysBack;
    private System.Windows.Forms.GroupBox grpboxExtractCreateCSV;
    private System.Windows.Forms.NumericUpDown numUpDnExtractCSVDaysBack;
    private System.Windows.Forms.Button btnStartExtractReviews;
    private System.Windows.Forms.Label lblExtractCSVDaysBack;
    private System.Windows.Forms.TextBox txtExtractCSVLoginCode;
    private System.Windows.Forms.Label lblExtractCSVLoginCode;
    private System.Windows.Forms.Button btnCSVFileOutput;
    private System.Windows.Forms.TextBox txtCSVOutputFile;
    private System.Windows.Forms.RadioButton radbtnOtherFormat;
    private System.Windows.Forms.RadioButton radbtnHSDSFormat;
    private System.Windows.Forms.TextBox txtFileNameFormat;
    private System.Windows.Forms.RadioButton radbtnPYRFormat;
    private System.Windows.Forms.TextBox txtStatusWindow;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dateTimeExtractCSV;
    private System.Windows.Forms.FolderBrowserDialog folderCSVOutput;
    private System.Windows.Forms.Label lblReportDateExtractCSV;
  }
}

