namespace AlienFX
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonStartAmbilight = new System.Windows.Forms.Button();
            this.buttonStopAmbilight = new System.Windows.Forms.Button();
            this.labelTopLeft = new System.Windows.Forms.Label();
            this.labelBottomRight = new System.Windows.Forms.Label();
            this.numericUpDownTopLeftX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTopLeftY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBottomRightX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBottomRightY = new System.Windows.Forms.NumericUpDown();
            this.Y = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownQuality = new System.Windows.Forms.NumericUpDown();
            this.labelQuality = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonFullscreen = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomResolution = new System.Windows.Forms.RadioButton();
            this.numericUpDownRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelRefreshRateNote = new System.Windows.Forms.Label();
            this.checkBox_startAutomatically = new System.Windows.Forms.CheckBox();
            this.checkBox_startMinimized = new System.Windows.Forms.CheckBox();
            this.radioButton_235_100_ratio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopLeftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopLeftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomRightX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomRightY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshRate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(108, 299);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(202, 16);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStartAmbilight
            // 
            this.buttonStartAmbilight.Location = new System.Drawing.Point(12, 296);
            this.buttonStartAmbilight.Name = "buttonStartAmbilight";
            this.buttonStartAmbilight.Size = new System.Drawing.Size(88, 23);
            this.buttonStartAmbilight.TabIndex = 14;
            this.buttonStartAmbilight.Text = "Start Ambilight";
            this.buttonStartAmbilight.UseVisualStyleBackColor = true;
            this.buttonStartAmbilight.Click += new System.EventHandler(this.buttonStartAmbilight_Click);
            // 
            // buttonStopAmbilight
            // 
            this.buttonStopAmbilight.Location = new System.Drawing.Point(316, 296);
            this.buttonStopAmbilight.Name = "buttonStopAmbilight";
            this.buttonStopAmbilight.Size = new System.Drawing.Size(94, 23);
            this.buttonStopAmbilight.TabIndex = 15;
            this.buttonStopAmbilight.Text = "Stop Ambilight";
            this.buttonStopAmbilight.UseVisualStyleBackColor = true;
            this.buttonStopAmbilight.Click += new System.EventHandler(this.buttonStopAmbilight_Click);
            // 
            // labelTopLeft
            // 
            this.labelTopLeft.AutoSize = true;
            this.labelTopLeft.Location = new System.Drawing.Point(30, 83);
            this.labelTopLeft.Name = "labelTopLeft";
            this.labelTopLeft.Size = new System.Drawing.Size(50, 13);
            this.labelTopLeft.TabIndex = 16;
            this.labelTopLeft.Text = "Top Left:";
            // 
            // labelBottomRight
            // 
            this.labelBottomRight.AutoSize = true;
            this.labelBottomRight.Location = new System.Drawing.Point(9, 109);
            this.labelBottomRight.Name = "labelBottomRight";
            this.labelBottomRight.Size = new System.Drawing.Size(71, 13);
            this.labelBottomRight.TabIndex = 19;
            this.labelBottomRight.Text = "Bottom Right:";
            // 
            // numericUpDownTopLeftX
            // 
            this.numericUpDownTopLeftX.Location = new System.Drawing.Point(109, 81);
            this.numericUpDownTopLeftX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTopLeftX.Name = "numericUpDownTopLeftX";
            this.numericUpDownTopLeftX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTopLeftX.TabIndex = 22;
            this.numericUpDownTopLeftX.ValueChanged += new System.EventHandler(this.numericUpDownTopLeftX_ValueChanged);
            // 
            // numericUpDownTopLeftY
            // 
            this.numericUpDownTopLeftY.Location = new System.Drawing.Point(258, 81);
            this.numericUpDownTopLeftY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTopLeftY.Name = "numericUpDownTopLeftY";
            this.numericUpDownTopLeftY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTopLeftY.TabIndex = 23;
            this.numericUpDownTopLeftY.ValueChanged += new System.EventHandler(this.numericUpDownTopLeftY_ValueChanged);
            // 
            // numericUpDownBottomRightX
            // 
            this.numericUpDownBottomRightX.Location = new System.Drawing.Point(109, 107);
            this.numericUpDownBottomRightX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownBottomRightX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBottomRightX.Name = "numericUpDownBottomRightX";
            this.numericUpDownBottomRightX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBottomRightX.TabIndex = 24;
            this.numericUpDownBottomRightX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBottomRightX.ValueChanged += new System.EventHandler(this.numericUpDownBottomRightX_ValueChanged);
            // 
            // numericUpDownBottomRightY
            // 
            this.numericUpDownBottomRightY.Location = new System.Drawing.Point(258, 107);
            this.numericUpDownBottomRightY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownBottomRightY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBottomRightY.Name = "numericUpDownBottomRightY";
            this.numericUpDownBottomRightY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBottomRightY.TabIndex = 25;
            this.numericUpDownBottomRightY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBottomRightY.ValueChanged += new System.EventHandler(this.numericUpDownBottomRightY_ValueChanged);
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(235, 83);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(17, 13);
            this.Y.TabIndex = 27;
            this.Y.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Y:";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(86, 83);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(17, 13);
            this.X.TabIndex = 28;
            this.X.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "X:";
            // 
            // numericUpDownQuality
            // 
            this.numericUpDownQuality.Location = new System.Drawing.Point(109, 149);
            this.numericUpDownQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuality.Name = "numericUpDownQuality";
            this.numericUpDownQuality.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuality.TabIndex = 29;
            this.numericUpDownQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuality.ValueChanged += new System.EventHandler(this.numericUpDownQuality_ValueChanged);
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(38, 151);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(42, 13);
            this.labelQuality.TabIndex = 30;
            this.labelQuality.Text = "Quality:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 51);
            this.label3.TabIndex = 31;
            this.label3.Text = "Note: \"1\" means: analyze every single pixel, \"2\" every second pixel and so on... " +
                " \"1\" is usually very cpu intense whereas \"3\" is a good compromise between qualit" +
                "y and speed.";
            // 
            // radioButtonFullscreen
            // 
            this.radioButtonFullscreen.AutoSize = true;
            this.radioButtonFullscreen.Location = new System.Drawing.Point(12, 34);
            this.radioButtonFullscreen.Name = "radioButtonFullscreen";
            this.radioButtonFullscreen.Size = new System.Drawing.Size(73, 17);
            this.radioButtonFullscreen.TabIndex = 32;
            this.radioButtonFullscreen.TabStop = true;
            this.radioButtonFullscreen.Text = "Fullscreen";
            this.radioButtonFullscreen.UseVisualStyleBackColor = true;
            this.radioButtonFullscreen.CheckedChanged += new System.EventHandler(this.radioButtonFullscreen_CheckedChanged);
            // 
            // radioButtonCustomResolution
            // 
            this.radioButtonCustomResolution.AutoSize = true;
            this.radioButtonCustomResolution.Location = new System.Drawing.Point(12, 58);
            this.radioButtonCustomResolution.Name = "radioButtonCustomResolution";
            this.radioButtonCustomResolution.Size = new System.Drawing.Size(113, 17);
            this.radioButtonCustomResolution.TabIndex = 33;
            this.radioButtonCustomResolution.TabStop = true;
            this.radioButtonCustomResolution.Text = "Custom Resolution";
            this.radioButtonCustomResolution.UseVisualStyleBackColor = true;
            this.radioButtonCustomResolution.CheckedChanged += new System.EventHandler(this.radioButtonCustomResolution_CheckedChanged);
            // 
            // numericUpDownRefreshRate
            // 
            this.numericUpDownRefreshRate.Location = new System.Drawing.Point(109, 226);
            this.numericUpDownRefreshRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRefreshRate.Name = "numericUpDownRefreshRate";
            this.numericUpDownRefreshRate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRefreshRate.TabIndex = 34;
            this.numericUpDownRefreshRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRefreshRate.ValueChanged += new System.EventHandler(this.numericUpDownRefreshRate_ValueChanged);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Location = new System.Drawing.Point(9, 228);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(95, 13);
            this.labelUpdate.TabIndex = 35;
            this.labelUpdate.Text = "Refresh rate in ms:";
            // 
            // labelRefreshRateNote
            // 
            this.labelRefreshRateNote.Location = new System.Drawing.Point(9, 249);
            this.labelRefreshRateNote.Name = "labelRefreshRateNote";
            this.labelRefreshRateNote.Size = new System.Drawing.Size(395, 43);
            this.labelRefreshRateNote.TabIndex = 36;
            this.labelRefreshRateNote.Text = "Note: Will be automatically increased if your pc cant handle it. Because the appl" +
                "ication has to take a screenshot every refresh there will be some noticable stut" +
                "ter when refresh rate is very short.";
            // 
            // checkBox_startAutomatically
            // 
            this.checkBox_startAutomatically.AutoSize = true;
            this.checkBox_startAutomatically.Location = new System.Drawing.Point(13, 11);
            this.checkBox_startAutomatically.Name = "checkBox_startAutomatically";
            this.checkBox_startAutomatically.Size = new System.Drawing.Size(158, 17);
            this.checkBox_startAutomatically.TabIndex = 37;
            this.checkBox_startAutomatically.Text = "Start Ambilight Automatically";
            this.checkBox_startAutomatically.UseVisualStyleBackColor = true;
            this.checkBox_startAutomatically.CheckedChanged += new System.EventHandler(this.checkBox_startAutomatically_CheckedChanged);
            // 
            // checkBox_startMinimized
            // 
            this.checkBox_startMinimized.AutoSize = true;
            this.checkBox_startMinimized.Location = new System.Drawing.Point(177, 11);
            this.checkBox_startMinimized.Name = "checkBox_startMinimized";
            this.checkBox_startMinimized.Size = new System.Drawing.Size(97, 17);
            this.checkBox_startMinimized.TabIndex = 38;
            this.checkBox_startMinimized.Text = "Start Minimized";
            this.checkBox_startMinimized.UseVisualStyleBackColor = true;
            this.checkBox_startMinimized.CheckedChanged += new System.EventHandler(this.checkBox_startMinimized_CheckedChanged);
            // 
            // radioButton_235_100_ratio
            // 
            this.radioButton_235_100_ratio.AutoSize = true;
            this.radioButton_235_100_ratio.Location = new System.Drawing.Point(177, 34);
            this.radioButton_235_100_ratio.Name = "radioButton_235_100_ratio";
            this.radioButton_235_100_ratio.Size = new System.Drawing.Size(119, 17);
            this.radioButton_235_100_ratio.TabIndex = 39;
            this.radioButton_235_100_ratio.TabStop = true;
            this.radioButton_235_100_ratio.Text = "2,35:1 Aspect Ratio";
            this.radioButton_235_100_ratio.UseVisualStyleBackColor = true;
            this.radioButton_235_100_ratio.CheckedChanged += new System.EventHandler(this.radioButton_235_100_ratio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 327);
            this.Controls.Add(this.radioButton_235_100_ratio);
            this.Controls.Add(this.checkBox_startMinimized);
            this.Controls.Add(this.checkBox_startAutomatically);
            this.Controls.Add(this.labelRefreshRateNote);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.numericUpDownRefreshRate);
            this.Controls.Add(this.radioButtonCustomResolution);
            this.Controls.Add(this.radioButtonFullscreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelQuality);
            this.Controls.Add(this.numericUpDownQuality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.numericUpDownBottomRightY);
            this.Controls.Add(this.numericUpDownBottomRightX);
            this.Controls.Add(this.numericUpDownTopLeftY);
            this.Controls.Add(this.numericUpDownTopLeftX);
            this.Controls.Add(this.labelBottomRight);
            this.Controls.Add(this.labelTopLeft);
            this.Controls.Add(this.buttonStopAmbilight);
            this.Controls.Add(this.buttonStartAmbilight);
            this.Controls.Add(this.labelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "AlienFX Ambilight by Markus Ressel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopLeftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopLeftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomRightX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomRightY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonStartAmbilight;
        private System.Windows.Forms.Button buttonStopAmbilight;
        private System.Windows.Forms.Label labelTopLeft;
        private System.Windows.Forms.Label labelBottomRight;
        private System.Windows.Forms.NumericUpDown numericUpDownTopLeftX;
        private System.Windows.Forms.NumericUpDown numericUpDownTopLeftY;
        private System.Windows.Forms.NumericUpDown numericUpDownBottomRightX;
        private System.Windows.Forms.NumericUpDown numericUpDownBottomRightY;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownQuality;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonFullscreen;
        private System.Windows.Forms.RadioButton radioButtonCustomResolution;
        private System.Windows.Forms.NumericUpDown numericUpDownRefreshRate;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelRefreshRateNote;
        private System.Windows.Forms.CheckBox checkBox_startAutomatically;
        private System.Windows.Forms.CheckBox checkBox_startMinimized;
        private System.Windows.Forms.RadioButton radioButton_235_100_ratio;
    }
}

