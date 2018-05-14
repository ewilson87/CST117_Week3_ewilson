namespace Week3_Project3
{
    partial class TextFileProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextFileProcessor));
            this.directionsPanel = new System.Windows.Forms.Panel();
            this.directionsLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.directionsLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.directionsLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.directionsLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fileLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.mostVowelsTextBox = new System.Windows.Forms.RichTextBox();
            this.longestTextBox = new System.Windows.Forms.RichTextBox();
            this.firstAndLastTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lowerCaseTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveAsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.browseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.directionsPanel.SuspendLayout();
            this.resultsPanel.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directionsPanel
            // 
            this.directionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.directionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.directionsPanel.Controls.Add(this.directionsLabel4);
            this.directionsPanel.Controls.Add(this.directionsLabel3);
            this.directionsPanel.Controls.Add(this.directionsLabel2);
            this.directionsPanel.Controls.Add(this.directionsLabel1);
            this.directionsPanel.Controls.Add(this.fileLabel);
            this.directionsPanel.Location = new System.Drawing.Point(264, 14);
            this.directionsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.directionsPanel.Name = "directionsPanel";
            this.directionsPanel.Size = new System.Drawing.Size(548, 294);
            this.directionsPanel.TabIndex = 0;
            // 
            // directionsLabel4
            // 
            this.directionsLabel4.AutoSize = true;
            this.directionsLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.directionsLabel4.Location = new System.Drawing.Point(23, 216);
            this.directionsLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directionsLabel4.Name = "directionsLabel4";
            this.directionsLabel4.Size = new System.Drawing.Size(467, 31);
            this.directionsLabel4.TabIndex = 5;
            this.directionsLabel4.Text = "4) Find the word with the most vowels";
            // 
            // directionsLabel3
            // 
            this.directionsLabel3.AutoSize = true;
            this.directionsLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.directionsLabel3.Location = new System.Drawing.Point(22, 173);
            this.directionsLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directionsLabel3.Name = "directionsLabel3";
            this.directionsLabel3.Size = new System.Drawing.Size(304, 31);
            this.directionsLabel3.TabIndex = 4;
            this.directionsLabel3.Text = "3) Find the longest word";
            // 
            // directionsLabel2
            // 
            this.directionsLabel2.AutoSize = true;
            this.directionsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.directionsLabel2.Location = new System.Drawing.Point(22, 130);
            this.directionsLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directionsLabel2.Name = "directionsLabel2";
            this.directionsLabel2.Size = new System.Drawing.Size(490, 31);
            this.directionsLabel2.TabIndex = 3;
            this.directionsLabel2.Text = "2) Find first and last word alphabetically";
            // 
            // directionsLabel1
            // 
            this.directionsLabel1.AutoSize = true;
            this.directionsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.directionsLabel1.Location = new System.Drawing.Point(22, 89);
            this.directionsLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directionsLabel1.Name = "directionsLabel1";
            this.directionsLabel1.Size = new System.Drawing.Size(424, 31);
            this.directionsLabel1.TabIndex = 2;
            this.directionsLabel1.Text = "1) Convert all words to lower-case";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fileLabel.Location = new System.Drawing.Point(22, 32);
            this.fileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(516, 37);
            this.fileLabel.TabIndex = 1;
            this.fileLabel.Text = "Select a text file to do the following:";
            // 
            // resultsPanel
            // 
            this.resultsPanel.BackColor = System.Drawing.Color.Transparent;
            this.resultsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultsPanel.Controls.Add(this.mostVowelsTextBox);
            this.resultsPanel.Controls.Add(this.longestTextBox);
            this.resultsPanel.Controls.Add(this.firstAndLastTextBox);
            this.resultsPanel.Controls.Add(this.label4);
            this.resultsPanel.Controls.Add(this.label3);
            this.resultsPanel.Controls.Add(this.label2);
            this.resultsPanel.Controls.Add(this.lowerCaseTextBox);
            this.resultsPanel.Controls.Add(this.label1);
            this.resultsPanel.Location = new System.Drawing.Point(15, 332);
            this.resultsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(1045, 554);
            this.resultsPanel.TabIndex = 1;
            // 
            // mostVowelsTextBox
            // 
            this.mostVowelsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mostVowelsTextBox.Location = new System.Drawing.Point(48, 486);
            this.mostVowelsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mostVowelsTextBox.Name = "mostVowelsTextBox";
            this.mostVowelsTextBox.ReadOnly = true;
            this.mostVowelsTextBox.Size = new System.Drawing.Size(970, 52);
            this.mostVowelsTextBox.TabIndex = 7;
            this.mostVowelsTextBox.Text = "";
            // 
            // longestTextBox
            // 
            this.longestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.longestTextBox.Location = new System.Drawing.Point(48, 406);
            this.longestTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.longestTextBox.Name = "longestTextBox";
            this.longestTextBox.ReadOnly = true;
            this.longestTextBox.Size = new System.Drawing.Size(970, 52);
            this.longestTextBox.TabIndex = 6;
            this.longestTextBox.Text = "";
            // 
            // firstAndLastTextBox
            // 
            this.firstAndLastTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstAndLastTextBox.Location = new System.Drawing.Point(48, 262);
            this.firstAndLastTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstAndLastTextBox.Name = "firstAndLastTextBox";
            this.firstAndLastTextBox.ReadOnly = true;
            this.firstAndLastTextBox.Size = new System.Drawing.Size(970, 116);
            this.firstAndLastTextBox.TabIndex = 5;
            this.firstAndLastTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(9, 493);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "4)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(9, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "3)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(10, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "2)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lowerCaseTextBox
            // 
            this.lowerCaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lowerCaseTextBox.Location = new System.Drawing.Point(48, 12);
            this.lowerCaseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lowerCaseTextBox.Name = "lowerCaseTextBox";
            this.lowerCaseTextBox.ReadOnly = true;
            this.lowerCaseTextBox.Size = new System.Drawing.Size(970, 222);
            this.lowerCaseTextBox.TabIndex = 1;
            this.lowerCaseTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "1)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveAsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.saveAsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveAsButton.BorderRadius = 0;
            this.saveAsButton.ButtonText = "SAVE AS";
            this.saveAsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveAsButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveAsButton.Enabled = false;
            this.saveAsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveAsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveAsButton.Iconimage = global::Week3_Project3.Properties.Resources.save;
            this.saveAsButton.Iconimage_right = global::Week3_Project3.Properties.Resources.save;
            this.saveAsButton.Iconimage_right_Selected = null;
            this.saveAsButton.Iconimage_Selected = null;
            this.saveAsButton.IconMarginLeft = 0;
            this.saveAsButton.IconMarginRight = 0;
            this.saveAsButton.IconRightVisible = true;
            this.saveAsButton.IconRightZoom = 0D;
            this.saveAsButton.IconVisible = true;
            this.saveAsButton.IconZoom = 40D;
            this.saveAsButton.IsTab = false;
            this.saveAsButton.Location = new System.Drawing.Point(823, 135);
            this.saveAsButton.Margin = new System.Windows.Forms.Padding(9);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.saveAsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveAsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveAsButton.selected = false;
            this.saveAsButton.Size = new System.Drawing.Size(250, 55);
            this.saveAsButton.TabIndex = 7;
            this.saveAsButton.Text = "SAVE AS";
            this.saveAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveAsButton.Textcolor = System.Drawing.Color.White;
            this.saveAsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.browseButton);
            this.bunifuGradientPanel1.Controls.Add(this.saveAsButton);
            this.bunifuGradientPanel1.Controls.Add(this.resultsPanel);
            this.bunifuGradientPanel1.Controls.Add(this.directionsPanel);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.OliveDrab;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.MintCream;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1077, 907);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.browseButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browseButton.BorderRadius = 0;
            this.browseButton.ButtonText = "BROWSE";
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.browseButton.DisabledColor = System.Drawing.Color.Gray;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.browseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.browseButton.Iconimage = global::Week3_Project3.Properties.Resources.file;
            this.browseButton.Iconimage_right = global::Week3_Project3.Properties.Resources.file;
            this.browseButton.Iconimage_right_Selected = null;
            this.browseButton.Iconimage_Selected = null;
            this.browseButton.IconMarginLeft = 0;
            this.browseButton.IconMarginRight = 0;
            this.browseButton.IconRightVisible = true;
            this.browseButton.IconRightZoom = 0D;
            this.browseButton.IconVisible = true;
            this.browseButton.IconZoom = 40D;
            this.browseButton.IsTab = false;
            this.browseButton.Location = new System.Drawing.Point(9, 135);
            this.browseButton.Margin = new System.Windows.Forms.Padding(9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.browseButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.browseButton.OnHoverTextColor = System.Drawing.Color.White;
            this.browseButton.selected = false;
            this.browseButton.Size = new System.Drawing.Size(250, 55);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "BROWSE";
            this.browseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.browseButton.Textcolor = System.Drawing.Color.White;
            this.browseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click_1);
            // 
            // TextFileProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1077, 907);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TextFileProcessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Text File Processor";
            this.directionsPanel.ResumeLayout(false);
            this.directionsPanel.PerformLayout();
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel directionsPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel directionsLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel directionsLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel directionsLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel directionsLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel fileLabel;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.RichTextBox mostVowelsTextBox;
        private System.Windows.Forms.RichTextBox longestTextBox;
        private System.Windows.Forms.RichTextBox firstAndLastTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox lowerCaseTextBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton saveAsButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton browseButton;
    }
}

