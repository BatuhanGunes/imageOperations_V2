namespace imageOperations
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.labelResolution = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBitmap = new System.Windows.Forms.Button();
            this.buttonGrayScale = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NumericBlue = new System.Windows.Forms.NumericUpDown();
            this.NumericGreen = new System.Windows.Forms.NumericUpDown();
            this.NumericRed = new System.Windows.Forms.NumericUpDown();
            this.NumericGetY = new System.Windows.Forms.NumericUpDown();
            this.NumericGetX = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSetPiksel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.textBoxHexa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericTreshold = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPanel.Controls.Add(this.labelResolution);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.pictureBox);
            this.leftPanel.Location = new System.Drawing.Point(12, 12);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1104, 744);
            this.leftPanel.TabIndex = 0;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(73, 10);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(32, 13);
            this.labelResolution.TabIndex = 2;
            this.labelResolution.Text = "0 X 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Resolution :";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxFileName);
            this.panel1.Controls.Add(this.buttonUploadImage);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1122, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 139);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(0, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "File Location :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Enabled = false;
            this.textBoxFileName.Location = new System.Drawing.Point(3, 82);
            this.textBoxFileName.Multiline = true;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(222, 41);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(44, 29);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(138, 23);
            this.buttonUploadImage.TabIndex = 1;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Image Upload Operations";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.numericTreshold);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.buttonBitmap);
            this.panel2.Controls.Add(this.buttonGrayScale);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(1122, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 174);
            this.panel2.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(13, 131);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(200, 24);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonBitmap
            // 
            this.buttonBitmap.Location = new System.Drawing.Point(13, 101);
            this.buttonBitmap.Name = "buttonBitmap";
            this.buttonBitmap.Size = new System.Drawing.Size(200, 24);
            this.buttonBitmap.TabIndex = 12;
            this.buttonBitmap.Text = "Bitmap";
            this.buttonBitmap.UseVisualStyleBackColor = true;
            this.buttonBitmap.Click += new System.EventHandler(this.buttonBitmap_Click);
            // 
            // buttonGrayScale
            // 
            this.buttonGrayScale.Location = new System.Drawing.Point(13, 45);
            this.buttonGrayScale.Name = "buttonGrayScale";
            this.buttonGrayScale.Size = new System.Drawing.Size(200, 24);
            this.buttonGrayScale.TabIndex = 11;
            this.buttonGrayScale.Text = "Gray Scale";
            this.buttonGrayScale.UseVisualStyleBackColor = true;
            this.buttonGrayScale.Click += new System.EventHandler(this.buttonGrayScale_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Gray Scale/Bitmap Operations";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Location = new System.Drawing.Point(1122, 611);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 145);
            this.panel3.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(3, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(222, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Information";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(14, 29);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(199, 67);
            this.panel8.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Batuhan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Güneş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "201513171055";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(14, 102);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(199, 34);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.NumericBlue);
            this.panel4.Controls.Add(this.NumericGreen);
            this.panel4.Controls.Add(this.NumericRed);
            this.panel4.Controls.Add(this.NumericGetY);
            this.panel4.Controls.Add(this.NumericGetX);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.buttonSetPiksel);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.ColorPanel);
            this.panel4.Controls.Add(this.textBoxHexa);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Location = new System.Drawing.Point(1122, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 273);
            this.panel4.TabIndex = 4;
            // 
            // NumericBlue
            // 
            this.NumericBlue.Location = new System.Drawing.Point(157, 150);
            this.NumericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericBlue.Name = "NumericBlue";
            this.NumericBlue.Size = new System.Drawing.Size(61, 20);
            this.NumericBlue.TabIndex = 21;
            this.NumericBlue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericBlue.ValueChanged += new System.EventHandler(this.NumericBlue_ValueChanged);
            // 
            // NumericGreen
            // 
            this.NumericGreen.Location = new System.Drawing.Point(85, 150);
            this.NumericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericGreen.Name = "NumericGreen";
            this.NumericGreen.Size = new System.Drawing.Size(61, 20);
            this.NumericGreen.TabIndex = 20;
            this.NumericGreen.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericGreen.ValueChanged += new System.EventHandler(this.NumericGreen_ValueChanged);
            // 
            // NumericRed
            // 
            this.NumericRed.Location = new System.Drawing.Point(14, 151);
            this.NumericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericRed.Name = "NumericRed";
            this.NumericRed.Size = new System.Drawing.Size(61, 20);
            this.NumericRed.TabIndex = 19;
            this.NumericRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericRed.ValueChanged += new System.EventHandler(this.NumericRed_ValueChanged);
            // 
            // NumericGetY
            // 
            this.NumericGetY.Location = new System.Drawing.Point(132, 65);
            this.NumericGetY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericGetY.Name = "NumericGetY";
            this.NumericGetY.Size = new System.Drawing.Size(82, 20);
            this.NumericGetY.TabIndex = 18;
            this.NumericGetY.ValueChanged += new System.EventHandler(this.NumericGetY_ValueChanged);
            // 
            // NumericGetX
            // 
            this.NumericGetX.Location = new System.Drawing.Point(17, 65);
            this.NumericGetX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericGetX.Name = "NumericGetX";
            this.NumericGetX.Size = new System.Drawing.Size(82, 20);
            this.NumericGetX.TabIndex = 17;
            this.NumericGetX.ValueChanged += new System.EventHandler(this.NumericGetX_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(153, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Blue :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(81, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Green :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(13, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Red :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(13, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Hexa :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSetPiksel
            // 
            this.buttonSetPiksel.Location = new System.Drawing.Point(16, 235);
            this.buttonSetPiksel.Name = "buttonSetPiksel";
            this.buttonSetPiksel.Size = new System.Drawing.Size(200, 24);
            this.buttonSetPiksel.TabIndex = 10;
            this.buttonSetPiksel.Text = "Set Piksel";
            this.buttonSetPiksel.UseVisualStyleBackColor = true;
            this.buttonSetPiksel.Click += new System.EventHandler(this.buttonSetPiksel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(13, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Color :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPanel
            // 
            this.ColorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel.Location = new System.Drawing.Point(86, 190);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(130, 32);
            this.ColorPanel.TabIndex = 8;
            this.ColorPanel.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // textBoxHexa
            // 
            this.textBoxHexa.Location = new System.Drawing.Point(84, 101);
            this.textBoxHexa.Name = "textBoxHexa";
            this.textBoxHexa.ReadOnly = true;
            this.textBoxHexa.Size = new System.Drawing.Size(131, 20);
            this.textBoxHexa.TabIndex = 6;
            this.textBoxHexa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(128, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Y :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "X :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(222, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Get/Set Piksel Operations";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericTreshold
            // 
            this.numericTreshold.Location = new System.Drawing.Point(113, 75);
            this.numericTreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericTreshold.Name = "numericTreshold";
            this.numericTreshold.Size = new System.Drawing.Size(85, 20);
            this.numericTreshold.TabIndex = 20;
            this.numericTreshold.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(25, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Treshold :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSetPiksel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.TextBox textBoxHexa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonBitmap;
        private System.Windows.Forms.Button buttonGrayScale;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.NumericUpDown NumericGetX;
        private System.Windows.Forms.NumericUpDown NumericBlue;
        private System.Windows.Forms.NumericUpDown NumericGreen;
        private System.Windows.Forms.NumericUpDown NumericRed;
        private System.Windows.Forms.NumericUpDown NumericGetY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericTreshold;
    }
}

