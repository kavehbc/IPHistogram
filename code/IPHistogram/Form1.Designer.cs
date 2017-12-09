namespace IPHistogram
{
    partial class frmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdExpShape = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLanda = new System.Windows.Forms.TextBox();
            this.cmdGaussian = new System.Windows.Forms.Button();
            this.tbLanda = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdEqualization = new System.Windows.Forms.Button();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.tbAlfa = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboColors = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.picHistogram = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.picCDF = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.picRef = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.picPreCDF = new System.Windows.Forms.PictureBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.picPreHistogram = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlfa)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistogram)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCDF)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRef)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreCDF)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.editToolStripMenuItem,
            this.heToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.SaveStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveStripMenuItem
            // 
            this.SaveStripMenuItem.Name = "SaveStripMenuItem";
            this.SaveStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SaveStripMenuItem.Text = "Save Preview as...";
            this.SaveStripMenuItem.Click += new System.EventHandler(this.SaveStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt +X";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistogramToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearHistogramToolStripMenuItem
            // 
            this.clearHistogramToolStripMenuItem.Name = "clearHistogramToolStripMenuItem";
            this.clearHistogramToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.clearHistogramToolStripMenuItem.Text = "Clear histogram";
            this.clearHistogramToolStripMenuItem.Click += new System.EventHandler(this.clearHistogramToolStripMenuItem_Click);
            // 
            // heToolStripMenuItem
            // 
            this.heToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.heToolStripMenuItem.Name = "heToolStripMenuItem";
            this.heToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.heToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-3, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1130, 3);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // cmdExpShape
            // 
            this.cmdExpShape.Enabled = false;
            this.cmdExpShape.Location = new System.Drawing.Point(15, 133);
            this.cmdExpShape.Name = "cmdExpShape";
            this.cmdExpShape.Size = new System.Drawing.Size(236, 23);
            this.cmdExpShape.TabIndex = 13;
            this.cmdExpShape.Text = "Exponential Shape Based on Landa";
            this.cmdExpShape.UseVisualStyleBackColor = true;
            this.cmdExpShape.Click += new System.EventHandler(this.cmdExpShape_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 312);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Picture";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(6, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(253, 287);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picturePreview);
            this.groupBox2.Location = new System.Drawing.Point(283, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 311);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // picturePreview
            // 
            this.picturePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturePreview.Location = new System.Drawing.Point(6, 19);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(253, 286);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.TabIndex = 4;
            this.picturePreview.TabStop = false;
            this.picturePreview.Click += new System.EventHandler(this.picturePreview_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLanda);
            this.groupBox3.Controls.Add(this.cmdGaussian);
            this.groupBox3.Controls.Add(this.tbLanda);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmdEqualization);
            this.groupBox3.Controls.Add(this.txtAlfa);
            this.groupBox3.Controls.Add(this.tbAlfa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmdExpShape);
            this.groupBox3.Location = new System.Drawing.Point(562, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 198);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controlers";
            // 
            // txtLanda
            // 
            this.txtLanda.Location = new System.Drawing.Point(228, 90);
            this.txtLanda.Name = "txtLanda";
            this.txtLanda.Size = new System.Drawing.Size(33, 20);
            this.txtLanda.TabIndex = 24;
            this.txtLanda.Text = "0.01";
            this.txtLanda.TextChanged += new System.EventHandler(this.txtLanda_TextChanged);
            // 
            // cmdGaussian
            // 
            this.cmdGaussian.Enabled = false;
            this.cmdGaussian.Location = new System.Drawing.Point(15, 56);
            this.cmdGaussian.Name = "cmdGaussian";
            this.cmdGaussian.Size = new System.Drawing.Size(236, 23);
            this.cmdGaussian.TabIndex = 17;
            this.cmdGaussian.Text = "Gaussian Distribution Based on Sigma";
            this.cmdGaussian.UseVisualStyleBackColor = true;
            this.cmdGaussian.Click += new System.EventHandler(this.cmdGaussian_Click);
            // 
            // tbLanda
            // 
            this.tbLanda.Location = new System.Drawing.Point(51, 89);
            this.tbLanda.Maximum = 100;
            this.tbLanda.Minimum = 1;
            this.tbLanda.Name = "tbLanda";
            this.tbLanda.Size = new System.Drawing.Size(171, 45);
            this.tbLanda.TabIndex = 23;
            this.tbLanda.Value = 10;
            this.tbLanda.Scroll += new System.EventHandler(this.tbLanda_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Landa";
            // 
            // cmdEqualization
            // 
            this.cmdEqualization.Enabled = false;
            this.cmdEqualization.Location = new System.Drawing.Point(15, 165);
            this.cmdEqualization.Name = "cmdEqualization";
            this.cmdEqualization.Size = new System.Drawing.Size(236, 23);
            this.cmdEqualization.TabIndex = 21;
            this.cmdEqualization.Text = "Histogram Equalization";
            this.cmdEqualization.UseVisualStyleBackColor = true;
            this.cmdEqualization.Click += new System.EventHandler(this.cmdEqualization_Click);
            // 
            // txtAlfa
            // 
            this.txtAlfa.Location = new System.Drawing.Point(229, 20);
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.Size = new System.Drawing.Size(33, 20);
            this.txtAlfa.TabIndex = 20;
            this.txtAlfa.Text = "100";
            this.txtAlfa.TextChanged += new System.EventHandler(this.txtAlfa_TextChanged);
            // 
            // tbAlfa
            // 
            this.tbAlfa.Location = new System.Drawing.Point(52, 15);
            this.tbAlfa.Maximum = 500;
            this.tbAlfa.Minimum = 1;
            this.tbAlfa.Name = "tbAlfa";
            this.tbAlfa.Size = new System.Drawing.Size(171, 45);
            this.tbAlfa.TabIndex = 19;
            this.tbAlfa.Value = 100;
            this.tbAlfa.Scroll += new System.EventHandler(this.tbAlfa_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sigma";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblWidth);
            this.groupBox4.Controls.Add(this.lblHeight);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblColor);
            this.groupBox4.Controls.Add(this.lblValue);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboColors);
            this.groupBox4.Location = new System.Drawing.Point(563, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 108);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Histogram";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(205, 57);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(13, 13);
            this.lblWidth.TabIndex = 22;
            this.lblWidth.Text = "--";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(205, 75);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(13, 13);
            this.lblHeight.TabIndex = 21;
            this.lblHeight.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Maximum Value:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(104, 57);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(13, 13);
            this.lblColor.TabIndex = 18;
            this.lblColor.Text = "--";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(104, 75);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(13, 13);
            this.lblValue.TabIndex = 17;
            this.lblValue.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Maximum Color:";
            // 
            // comboColors
            // 
            this.comboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColors.Enabled = false;
            this.comboColors.FormattingEnabled = true;
            this.comboColors.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboColors.Location = new System.Drawing.Point(14, 19);
            this.comboColors.Name = "comboColors";
            this.comboColors.Size = new System.Drawing.Size(234, 21);
            this.comboColors.TabIndex = 11;
            this.comboColors.SelectedIndexChanged += new System.EventHandler(this.comboColors_SelectedIndexChanged_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 652);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(350, 17);
            this.lblStatus.Text = "Done";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.picHistogram);
            this.groupBox5.Location = new System.Drawing.Point(12, 360);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 286);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Histogram";
            // 
            // picHistogram
            // 
            this.picHistogram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHistogram.Location = new System.Drawing.Point(6, 19);
            this.picHistogram.Name = "picHistogram";
            this.picHistogram.Size = new System.Drawing.Size(256, 256);
            this.picHistogram.TabIndex = 4;
            this.picHistogram.TabStop = false;
            this.picHistogram.Click += new System.EventHandler(this.picHistogram_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picCDF);
            this.groupBox6.Location = new System.Drawing.Point(287, 360);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(269, 286);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CDF";
            // 
            // picCDF
            // 
            this.picCDF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCDF.Location = new System.Drawing.Point(6, 19);
            this.picCDF.Name = "picCDF";
            this.picCDF.Size = new System.Drawing.Size(256, 256);
            this.picCDF.TabIndex = 4;
            this.picCDF.TabStop = false;
            this.picCDF.Click += new System.EventHandler(this.picCDF_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.picRef);
            this.groupBox7.Location = new System.Drawing.Point(838, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(269, 286);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Reference";
            // 
            // picRef
            // 
            this.picRef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picRef.Location = new System.Drawing.Point(6, 19);
            this.picRef.Name = "picRef";
            this.picRef.Size = new System.Drawing.Size(256, 256);
            this.picRef.TabIndex = 4;
            this.picRef.TabStop = false;
            this.picRef.Click += new System.EventHandler(this.picRef_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.picPreCDF);
            this.groupBox8.Location = new System.Drawing.Point(837, 360);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(269, 286);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Preview CDF";
            // 
            // picPreCDF
            // 
            this.picPreCDF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPreCDF.Location = new System.Drawing.Point(6, 19);
            this.picPreCDF.Name = "picPreCDF";
            this.picPreCDF.Size = new System.Drawing.Size(256, 256);
            this.picPreCDF.TabIndex = 4;
            this.picPreCDF.TabStop = false;
            this.picPreCDF.Click += new System.EventHandler(this.picPreCDF_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.picPreHistogram);
            this.groupBox9.Location = new System.Drawing.Point(562, 360);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(269, 286);
            this.groupBox9.TabIndex = 24;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Preview Histogram";
            // 
            // picPreHistogram
            // 
            this.picPreHistogram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPreHistogram.Location = new System.Drawing.Point(6, 19);
            this.picPreHistogram.Name = "picPreHistogram";
            this.picPreHistogram.Size = new System.Drawing.Size(256, 256);
            this.picPreHistogram.TabIndex = 4;
            this.picPreHistogram.TabStop = false;
            this.picPreHistogram.Click += new System.EventHandler(this.picPreHistogram_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 674);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlfa)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHistogram)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCDF)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRef)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreCDF)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistogramToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdExpShape;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tbAlfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGaussian;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboColors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem SaveStripMenuItem;
        private System.Windows.Forms.TextBox txtAlfa;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem heToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox picHistogram;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox picCDF;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox picRef;
        private System.Windows.Forms.Button cmdEqualization;
        private System.Windows.Forms.TextBox txtLanda;
        private System.Windows.Forms.TrackBar tbLanda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox picPreCDF;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.PictureBox picPreHistogram;
    }
}

