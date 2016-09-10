namespace AlienFX {
    partial class MainForm {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.LabelStatus = new System.Windows.Forms.Label();
            this.buttonStartAmbilight = new System.Windows.Forms.Button();
            this.buttonStopAmbilight = new System.Windows.Forms.Button();
            this.labelTopLeft = new System.Windows.Forms.Label();
            this.labelBottomRight = new System.Windows.Forms.Label();
            this.NumericUpDownTopLeftX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownTopLeftY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownBottomRightX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownBottomRightY = new System.Windows.Forms.NumericUpDown();
            this.Y = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericUpDownQuality = new System.Windows.Forms.NumericUpDown();
            this.labelQuality = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioButtonFullscreen = new System.Windows.Forms.RadioButton();
            this.RadioButtonCustomResolution = new System.Windows.Forms.RadioButton();
            this.NumericUpDownRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelRefreshRateNote = new System.Windows.Forms.Label();
            this.CheckBox_startAutomatically = new System.Windows.Forms.CheckBox();
            this.CheckBox_startMinimized = new System.Windows.Forms.CheckBox();
            this.RadioButton_235_100_ratio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTopLeftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTopLeftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBottomRightX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBottomRightY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRefreshRate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(108, 299);
            this.LabelStatus.Name = "labelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(202, 16);
            this.LabelStatus.TabIndex = 6;
            this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStartAmbilight
            // 
            this.buttonStartAmbilight.Location = new System.Drawing.Point(12, 296);
            this.buttonStartAmbilight.Name = "buttonStartAmbilight";
            this.buttonStartAmbilight.Size = new System.Drawing.Size(88, 23);
            this.buttonStartAmbilight.TabIndex = 14;
            this.buttonStartAmbilight.Text = "Start Ambilight";
            this.buttonStartAmbilight.UseVisualStyleBackColor = true;
            this.buttonStartAmbilight.Click += new System.EventHandler(this.ButtonStartAmbilight_Click);
            // 
            // buttonStopAmbilight
            // 
            this.buttonStopAmbilight.Location = new System.Drawing.Point(316, 296);
            this.buttonStopAmbilight.Name = "buttonStopAmbilight";
            this.buttonStopAmbilight.Size = new System.Drawing.Size(94, 23);
            this.buttonStopAmbilight.TabIndex = 15;
            this.buttonStopAmbilight.Text = "Stop Ambilight";
            this.buttonStopAmbilight.UseVisualStyleBackColor = true;
            this.buttonStopAmbilight.Click += new System.EventHandler(this.ButtonStopAmbilight_Click);
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
            this.NumericUpDownTopLeftX.Location = new System.Drawing.Point(109, 81);
            this.NumericUpDownTopLeftX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDownTopLeftX.Name = "numericUpDownTopLeftX";
            this.NumericUpDownTopLeftX.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownTopLeftX.TabIndex = 22;
            this.NumericUpDownTopLeftX.ValueChanged += new System.EventHandler(this.numericUpDownTopLeftX_ValueChanged);
            // 
            // numericUpDownTopLeftY
            // 
            this.NumericUpDownTopLeftY.Location = new System.Drawing.Point(258, 81);
            this.NumericUpDownTopLeftY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDownTopLeftY.Name = "numericUpDownTopLeftY";
            this.NumericUpDownTopLeftY.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownTopLeftY.TabIndex = 23;
            this.NumericUpDownTopLeftY.ValueChanged += new System.EventHandler(this.numericUpDownTopLeftY_ValueChanged);
            // 
            // numericUpDownBottomRightX
            // 
            this.NumericUpDownBottomRightX.Location = new System.Drawing.Point(109, 107);
            this.NumericUpDownBottomRightX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDownBottomRightX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownBottomRightX.Name = "numericUpDownBottomRightX";
            this.NumericUpDownBottomRightX.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownBottomRightX.TabIndex = 24;
            this.NumericUpDownBottomRightX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownBottomRightX.ValueChanged += new System.EventHandler(this.numericUpDownBottomRightX_ValueChanged);
            // 
            // numericUpDownBottomRightY
            // 
            this.NumericUpDownBottomRightY.Location = new System.Drawing.Point(258, 107);
            this.NumericUpDownBottomRightY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDownBottomRightY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownBottomRightY.Name = "numericUpDownBottomRightY";
            this.NumericUpDownBottomRightY.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownBottomRightY.TabIndex = 25;
            this.NumericUpDownBottomRightY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownBottomRightY.ValueChanged += new System.EventHandler(this.numericUpDownBottomRightY_ValueChanged);
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
            this.NumericUpDownQuality.Location = new System.Drawing.Point(109, 149);
            this.NumericUpDownQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownQuality.Name = "numericUpDownQuality";
            this.NumericUpDownQuality.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownQuality.TabIndex = 29;
            this.NumericUpDownQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownQuality.ValueChanged += new System.EventHandler(this.numericUpDownQuality_ValueChanged);
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
            this.RadioButtonFullscreen.AutoSize = true;
            this.RadioButtonFullscreen.Location = new System.Drawing.Point(12, 34);
            this.RadioButtonFullscreen.Name = "radioButtonFullscreen";
            this.RadioButtonFullscreen.Size = new System.Drawing.Size(73, 17);
            this.RadioButtonFullscreen.TabIndex = 32;
            this.RadioButtonFullscreen.TabStop = true;
            this.RadioButtonFullscreen.Text = "Fullscreen";
            this.RadioButtonFullscreen.UseVisualStyleBackColor = true;
            this.RadioButtonFullscreen.CheckedChanged += new System.EventHandler(this.radioButtonFullscreen_CheckedChanged);
            // 
            // radioButtonCustomResolution
            // 
            this.RadioButtonCustomResolution.AutoSize = true;
            this.RadioButtonCustomResolution.Location = new System.Drawing.Point(12, 58);
            this.RadioButtonCustomResolution.Name = "radioButtonCustomResolution";
            this.RadioButtonCustomResolution.Size = new System.Drawing.Size(113, 17);
            this.RadioButtonCustomResolution.TabIndex = 33;
            this.RadioButtonCustomResolution.TabStop = true;
            this.RadioButtonCustomResolution.Text = "Custom Resolution";
            this.RadioButtonCustomResolution.UseVisualStyleBackColor = true;
            this.RadioButtonCustomResolution.CheckedChanged += new System.EventHandler(this.radioButtonCustomResolution_CheckedChanged);
            // 
            // numericUpDownRefreshRate
            // 
            this.NumericUpDownRefreshRate.Location = new System.Drawing.Point(109, 226);
            this.NumericUpDownRefreshRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDownRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownRefreshRate.Name = "numericUpDownRefreshRate";
            this.NumericUpDownRefreshRate.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownRefreshRate.TabIndex = 34;
            this.NumericUpDownRefreshRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownRefreshRate.ValueChanged += new System.EventHandler(this.numericUpDownRefreshRate_ValueChanged);
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
            this.CheckBox_startAutomatically.AutoSize = true;
            this.CheckBox_startAutomatically.Location = new System.Drawing.Point(13, 11);
            this.CheckBox_startAutomatically.Name = "checkBox_startAutomatically";
            this.CheckBox_startAutomatically.Size = new System.Drawing.Size(158, 17);
            this.CheckBox_startAutomatically.TabIndex = 37;
            this.CheckBox_startAutomatically.Text = "Start Ambilight Automatically";
            this.CheckBox_startAutomatically.UseVisualStyleBackColor = true;
            this.CheckBox_startAutomatically.CheckedChanged += new System.EventHandler(this.checkBox_startAutomatically_CheckedChanged);
            // 
            // checkBox_startMinimized
            // 
            this.CheckBox_startMinimized.AutoSize = true;
            this.CheckBox_startMinimized.Location = new System.Drawing.Point(177, 11);
            this.CheckBox_startMinimized.Name = "checkBox_startMinimized";
            this.CheckBox_startMinimized.Size = new System.Drawing.Size(97, 17);
            this.CheckBox_startMinimized.TabIndex = 38;
            this.CheckBox_startMinimized.Text = "Start Minimized";
            this.CheckBox_startMinimized.UseVisualStyleBackColor = true;
            this.CheckBox_startMinimized.CheckedChanged += new System.EventHandler(this.CheckBox_startMinimized_CheckedChanged);
            // 
            // radioButton_235_100_ratio
            // 
            this.RadioButton_235_100_ratio.AutoSize = true;
            this.RadioButton_235_100_ratio.Location = new System.Drawing.Point(177, 34);
            this.RadioButton_235_100_ratio.Name = "radioButton_235_100_ratio";
            this.RadioButton_235_100_ratio.Size = new System.Drawing.Size(119, 17);
            this.RadioButton_235_100_ratio.TabIndex = 39;
            this.RadioButton_235_100_ratio.TabStop = true;
            this.RadioButton_235_100_ratio.Text = "2,35:1 Aspect Ratio";
            this.RadioButton_235_100_ratio.UseVisualStyleBackColor = true;
            this.RadioButton_235_100_ratio.CheckedChanged += new System.EventHandler(this.RadioButton_235_100_ratio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 327);
            this.Controls.Add(this.RadioButton_235_100_ratio);
            this.Controls.Add(this.CheckBox_startMinimized);
            this.Controls.Add(this.CheckBox_startAutomatically);
            this.Controls.Add(this.labelRefreshRateNote);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.NumericUpDownRefreshRate);
            this.Controls.Add(this.RadioButtonCustomResolution);
            this.Controls.Add(this.RadioButtonFullscreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelQuality);
            this.Controls.Add(this.NumericUpDownQuality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.NumericUpDownBottomRightY);
            this.Controls.Add(this.NumericUpDownBottomRightX);
            this.Controls.Add(this.NumericUpDownTopLeftY);
            this.Controls.Add(this.NumericUpDownTopLeftX);
            this.Controls.Add(this.labelBottomRight);
            this.Controls.Add(this.labelTopLeft);
            this.Controls.Add(this.buttonStopAmbilight);
            this.Controls.Add(this.buttonStartAmbilight);
            this.Controls.Add(this.LabelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "AlienFX Ambilight by Markus Ressel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTopLeftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTopLeftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBottomRightX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBottomRightY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRefreshRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Button buttonStartAmbilight;
        private System.Windows.Forms.Button buttonStopAmbilight;
        private System.Windows.Forms.Label labelTopLeft;
        private System.Windows.Forms.Label labelBottomRight;
        private System.Windows.Forms.NumericUpDown NumericUpDownTopLeftX;
        private System.Windows.Forms.NumericUpDown NumericUpDownTopLeftY;
        private System.Windows.Forms.NumericUpDown NumericUpDownBottomRightX;
        private System.Windows.Forms.NumericUpDown NumericUpDownBottomRightY;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericUpDownQuality;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioButtonFullscreen;
        private System.Windows.Forms.RadioButton RadioButtonCustomResolution;
        private System.Windows.Forms.NumericUpDown NumericUpDownRefreshRate;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelRefreshRateNote;
        private System.Windows.Forms.CheckBox CheckBox_startAutomatically;
        private System.Windows.Forms.CheckBox CheckBox_startMinimized;
        private System.Windows.Forms.RadioButton RadioButton_235_100_ratio;
    }
}

