namespace Week3_Exercise5
{
    partial class ApproximatePi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproximatePi));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.calculateButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.piPanel = new System.Windows.Forms.Panel();
            this.piAnswerLabel = new System.Windows.Forms.Label();
            this.piLabel = new System.Windows.Forms.Label();
            this.termsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.termsLabel = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.piPanel.SuspendLayout();
            this.termsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.calculateButton);
            this.bunifuGradientPanel1.Controls.Add(this.piPanel);
            this.bunifuGradientPanel1.Controls.Add(this.termsPanel);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Pink;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(426, 266);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.calculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calculateButton.BorderRadius = 0;
            this.calculateButton.ButtonText = "CALCULATE";
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.DisabledColor = System.Drawing.Color.Gray;
            this.calculateButton.Iconcolor = System.Drawing.Color.Transparent;
            this.calculateButton.Iconimage = global::Week3_Exercise5.Properties.Resources.pi;
            this.calculateButton.Iconimage_right = null;
            this.calculateButton.Iconimage_right_Selected = null;
            this.calculateButton.Iconimage_Selected = null;
            this.calculateButton.IconMarginLeft = 0;
            this.calculateButton.IconMarginRight = 0;
            this.calculateButton.IconRightVisible = true;
            this.calculateButton.IconRightZoom = 0D;
            this.calculateButton.IconVisible = true;
            this.calculateButton.IconZoom = 90D;
            this.calculateButton.IsTab = false;
            this.calculateButton.Location = new System.Drawing.Point(132, 99);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.calculateButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.calculateButton.OnHoverTextColor = System.Drawing.Color.White;
            this.calculateButton.selected = false;
            this.calculateButton.Size = new System.Drawing.Size(162, 50);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calculateButton.Textcolor = System.Drawing.Color.White;
            this.calculateButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // piPanel
            // 
            this.piPanel.BackColor = System.Drawing.Color.Transparent;
            this.piPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.piPanel.Controls.Add(this.piAnswerLabel);
            this.piPanel.Controls.Add(this.piLabel);
            this.piPanel.Location = new System.Drawing.Point(13, 170);
            this.piPanel.Name = "piPanel";
            this.piPanel.Size = new System.Drawing.Size(405, 83);
            this.piPanel.TabIndex = 2;
            // 
            // piAnswerLabel
            // 
            this.piAnswerLabel.AutoSize = true;
            this.piAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.piAnswerLabel.Location = new System.Drawing.Point(15, 51);
            this.piAnswerLabel.Name = "piAnswerLabel";
            this.piAnswerLabel.Size = new System.Drawing.Size(0, 20);
            this.piAnswerLabel.TabIndex = 1;
            // 
            // piLabel
            // 
            this.piLabel.AutoSize = true;
            this.piLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.piLabel.Location = new System.Drawing.Point(18, 14);
            this.piLabel.Name = "piLabel";
            this.piLabel.Size = new System.Drawing.Size(0, 20);
            this.piLabel.TabIndex = 0;
            // 
            // termsPanel
            // 
            this.termsPanel.BackColor = System.Drawing.Color.Transparent;
            this.termsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.termsPanel.Controls.Add(this.label1);
            this.termsPanel.Controls.Add(this.termsTextBox);
            this.termsPanel.Controls.Add(this.termsLabel);
            this.termsPanel.Location = new System.Drawing.Point(13, 13);
            this.termsPanel.Name = "termsPanel";
            this.termsPanel.Size = new System.Drawing.Size(405, 68);
            this.termsPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Note: Larger values are more accurate.                             Max = 9,999,99" +
    "9";
            // 
            // termsTextBox
            // 
            this.termsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.termsTextBox.Location = new System.Drawing.Point(292, 14);
            this.termsTextBox.MaxLength = 7;
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(102, 26);
            this.termsTextBox.TabIndex = 1;
            this.termsTextBox.TextChanged += new System.EventHandler(this.termsTextBox_TextChanged);
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.termsLabel.Location = new System.Drawing.Point(14, 17);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(280, 20);
            this.termsLabel.TabIndex = 0;
            this.termsLabel.Text = "Enter the # of terms to approximate Pi:";
            // 
            // ApproximatePi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 266);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ApproximatePi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approximate Pi";
            this.Load += new System.EventHandler(this.ApproximatePi_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.piPanel.ResumeLayout(false);
            this.piPanel.PerformLayout();
            this.termsPanel.ResumeLayout(false);
            this.termsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel piPanel;
        private System.Windows.Forms.Label piAnswerLabel;
        private System.Windows.Forms.Label piLabel;
        private System.Windows.Forms.Panel termsPanel;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.Label termsLabel;
        private Bunifu.Framework.UI.BunifuFlatButton calculateButton;
        private System.Windows.Forms.Label label1;
    }
}

