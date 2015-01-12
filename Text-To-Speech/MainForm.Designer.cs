namespace Text_To_Speech
{
    partial class MainForm
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
            this.panelControls = new System.Windows.Forms.Panel();
            this.checkBoxChangeFontStyle = new System.Windows.Forms.CheckBox();
            this.buttonCopyRead = new System.Windows.Forms.Button();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.comboBoxFontFamily = new System.Windows.Forms.ComboBox();
            this.checkBoxColorText = new System.Windows.Forms.CheckBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelVoice = new System.Windows.Forms.Label();
            this.comboBoxVoice = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.trackBarRate = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.labelCopyRead = new System.Windows.Forms.Label();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.checkBoxChangeFontStyle);
            this.panelControls.Controls.Add(this.buttonCopyRead);
            this.panelControls.Controls.Add(this.checkBoxTopMost);
            this.panelControls.Controls.Add(this.comboBoxFontSize);
            this.panelControls.Controls.Add(this.comboBoxFontFamily);
            this.panelControls.Controls.Add(this.checkBoxColorText);
            this.panelControls.Controls.Add(this.buttonPause);
            this.panelControls.Controls.Add(this.buttonStop);
            this.panelControls.Controls.Add(this.labelRate);
            this.panelControls.Controls.Add(this.labelVolume);
            this.panelControls.Controls.Add(this.labelVoice);
            this.panelControls.Controls.Add(this.comboBoxVoice);
            this.panelControls.Controls.Add(this.buttonReset);
            this.panelControls.Controls.Add(this.buttonRead);
            this.panelControls.Controls.Add(this.trackBarRate);
            this.panelControls.Controls.Add(this.trackBarVolume);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 427);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(742, 96);
            this.panelControls.TabIndex = 0;
            // 
            // checkBoxChangeFontStyle
            // 
            this.checkBoxChangeFontStyle.AutoSize = true;
            this.checkBoxChangeFontStyle.Location = new System.Drawing.Point(278, 67);
            this.checkBoxChangeFontStyle.Name = "checkBoxChangeFontStyle";
            this.checkBoxChangeFontStyle.Size = new System.Drawing.Size(113, 17);
            this.checkBoxChangeFontStyle.TabIndex = 15;
            this.checkBoxChangeFontStyle.Text = "Change Font Style";
            this.checkBoxChangeFontStyle.UseVisualStyleBackColor = true;
            // 
            // buttonCopyRead
            // 
            this.buttonCopyRead.Location = new System.Drawing.Point(395, 67);
            this.buttonCopyRead.Name = "buttonCopyRead";
            this.buttonCopyRead.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyRead.TabIndex = 14;
            this.buttonCopyRead.Text = "Copy Read";
            this.buttonCopyRead.UseVisualStyleBackColor = true;
            this.buttonCopyRead.Click += new System.EventHandler(this.buttonCopyRead_Click);
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Location = new System.Drawing.Point(554, 12);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(68, 17);
            this.checkBoxTopMost.TabIndex = 13;
            this.checkBoxTopMost.Text = "TopMost";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.Location = new System.Drawing.Point(636, 38);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(94, 21);
            this.comboBoxFontSize.TabIndex = 12;
            this.comboBoxFontSize.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFontSize_SelectionChangeCommitted);
            // 
            // comboBoxFontFamily
            // 
            this.comboBoxFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontFamily.FormattingEnabled = true;
            this.comboBoxFontFamily.Location = new System.Drawing.Point(358, 38);
            this.comboBoxFontFamily.Name = "comboBoxFontFamily";
            this.comboBoxFontFamily.Size = new System.Drawing.Size(259, 21);
            this.comboBoxFontFamily.TabIndex = 11;
            this.comboBoxFontFamily.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFontFamily_SelectionChangeCommitted);
            // 
            // checkBoxColorText
            // 
            this.checkBoxColorText.AutoSize = true;
            this.checkBoxColorText.Location = new System.Drawing.Point(278, 40);
            this.checkBoxColorText.Name = "checkBoxColorText";
            this.checkBoxColorText.Size = new System.Drawing.Size(74, 17);
            this.checkBoxColorText.TabIndex = 10;
            this.checkBoxColorText.Text = "Color Text";
            this.checkBoxColorText.UseVisualStyleBackColor = true;
            this.checkBoxColorText.CheckedChanged += new System.EventHandler(this.checkBoxColorText_CheckedChanged);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(570, 66);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(657, 66);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(9, 50);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(30, 13);
            this.labelRate.TabIndex = 7;
            this.labelRate.Text = "Rate";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(9, 11);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(42, 13);
            this.labelVolume.TabIndex = 6;
            this.labelVolume.Text = "Volume";
            // 
            // labelVoice
            // 
            this.labelVoice.AutoSize = true;
            this.labelVoice.Location = new System.Drawing.Point(275, 15);
            this.labelVoice.Name = "labelVoice";
            this.labelVoice.Size = new System.Drawing.Size(34, 13);
            this.labelVoice.TabIndex = 5;
            this.labelVoice.Text = "Voice";
            // 
            // comboBoxVoice
            // 
            this.comboBoxVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoice.FormattingEnabled = true;
            this.comboBoxVoice.Location = new System.Drawing.Point(313, 8);
            this.comboBoxVoice.Name = "comboBoxVoice";
            this.comboBoxVoice.Size = new System.Drawing.Size(235, 21);
            this.comboBoxVoice.TabIndex = 4;
            this.comboBoxVoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxVoice_SelectedIndexChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(655, 7);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(481, 67);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // trackBarRate
            // 
            this.trackBarRate.Location = new System.Drawing.Point(57, 50);
            this.trackBarRate.Minimum = -10;
            this.trackBarRate.Name = "trackBarRate";
            this.trackBarRate.Size = new System.Drawing.Size(210, 45);
            this.trackBarRate.TabIndex = 1;
            this.trackBarRate.Scroll += new System.EventHandler(this.trackBarRate_Scroll);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(57, 6);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(210, 45);
            this.trackBarVolume.TabIndex = 0;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(742, 427);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // labelCopyRead
            // 
            this.labelCopyRead.AutoSize = true;
            this.labelCopyRead.BackColor = System.Drawing.Color.Red;
            this.labelCopyRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyRead.ForeColor = System.Drawing.Color.White;
            this.labelCopyRead.Location = new System.Drawing.Point(4, 6);
            this.labelCopyRead.Name = "labelCopyRead";
            this.labelCopyRead.Size = new System.Drawing.Size(82, 20);
            this.labelCopyRead.TabIndex = 2;
            this.labelCopyRead.Text = "Copying ...";
            this.labelCopyRead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCopyRead.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 523);
            this.Controls.Add(this.labelCopyRead);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panelControls);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "MainForm";
            this.Text = "Text-To-Speech";
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.ComboBox comboBoxVoice;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TrackBar trackBarRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelVoice;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.CheckBox checkBoxColorText;
        private System.Windows.Forms.ComboBox comboBoxFontFamily;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.Windows.Forms.Button buttonCopyRead;
        private System.Windows.Forms.Label labelCopyRead;
        private System.Windows.Forms.CheckBox checkBoxChangeFontStyle;
    }
}

