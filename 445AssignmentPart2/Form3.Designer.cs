namespace _445AssignmentPart2
{
    partial class Form3
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
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.citySearchButton = new System.Windows.Forms.Button();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.sunriseNumLabel = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.sunsetNumLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.windSpeedNumLabel = new System.Windows.Forms.Label();
            this.pressureNumLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tempLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(155, 58);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 0;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(114, 58);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 1;
            this.cityLabel.Text = "City:";
            // 
            // citySearchButton
            // 
            this.citySearchButton.Location = new System.Drawing.Point(261, 56);
            this.citySearchButton.Name = "citySearchButton";
            this.citySearchButton.Size = new System.Drawing.Size(75, 23);
            this.citySearchButton.TabIndex = 2;
            this.citySearchButton.Text = "Search";
            this.citySearchButton.UseVisualStyleBackColor = true;
            this.citySearchButton.Click += new System.EventHandler(this.citySearchButton_Click);
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(114, 159);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(39, 13);
            this.detailsLabel.TabIndex = 3;
            this.detailsLabel.Text = "Details";
            this.detailsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(114, 136);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(51, 13);
            this.conditionLabel.TabIndex = 4;
            this.conditionLabel.Text = "Condition";
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.AutoSize = true;
            this.sunriseLabel.Location = new System.Drawing.Point(114, 223);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(45, 13);
            this.sunriseLabel.TabIndex = 5;
            this.sunriseLabel.Text = "Sunrise:";
            // 
            // sunriseNumLabel
            // 
            this.sunriseNumLabel.AutoSize = true;
            this.sunriseNumLabel.Location = new System.Drawing.Point(176, 223);
            this.sunriseNumLabel.Name = "sunriseNumLabel";
            this.sunriseNumLabel.Size = new System.Drawing.Size(27, 13);
            this.sunriseNumLabel.TabIndex = 6;
            this.sunriseNumLabel.Text = "N/A";
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.AutoSize = true;
            this.sunsetLabel.Location = new System.Drawing.Point(114, 262);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(43, 13);
            this.sunsetLabel.TabIndex = 7;
            this.sunsetLabel.Text = "Sunset:";
            // 
            // sunsetNumLabel
            // 
            this.sunsetNumLabel.AutoSize = true;
            this.sunsetNumLabel.Location = new System.Drawing.Point(176, 262);
            this.sunsetNumLabel.Name = "sunsetNumLabel";
            this.sunsetNumLabel.Size = new System.Drawing.Size(27, 13);
            this.sunsetNumLabel.TabIndex = 8;
            this.sunsetNumLabel.Text = "N/A";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.Location = new System.Drawing.Point(258, 148);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(69, 13);
            this.windSpeedLabel.TabIndex = 9;
            this.windSpeedLabel.Text = "Wind Speed:";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(258, 183);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(51, 13);
            this.pressureLabel.TabIndex = 10;
            this.pressureLabel.Text = "Pressure:";
            // 
            // windSpeedNumLabel
            // 
            this.windSpeedNumLabel.AutoSize = true;
            this.windSpeedNumLabel.Location = new System.Drawing.Point(333, 148);
            this.windSpeedNumLabel.Name = "windSpeedNumLabel";
            this.windSpeedNumLabel.Size = new System.Drawing.Size(27, 13);
            this.windSpeedNumLabel.TabIndex = 11;
            this.windSpeedNumLabel.Text = "N/A";
            // 
            // pressureNumLabel
            // 
            this.pressureNumLabel.AutoSize = true;
            this.pressureNumLabel.Location = new System.Drawing.Point(309, 183);
            this.pressureNumLabel.Name = "pressureNumLabel";
            this.pressureNumLabel.Size = new System.Drawing.Size(27, 13);
            this.pressureNumLabel.TabIndex = 12;
            this.pressureNumLabel.Text = "N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(103, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(418, 56);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(227, 39);
            this.tempLabel.TabIndex = 14;
            this.tempLabel.Text = "Temperature";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pressureNumLabel);
            this.Controls.Add(this.windSpeedNumLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.sunsetNumLabel);
            this.Controls.Add(this.sunsetLabel);
            this.Controls.Add(this.sunriseNumLabel);
            this.Controls.Add(this.sunriseLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.citySearchButton);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.textBoxCity);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Button citySearchButton;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.Label sunriseNumLabel;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.Label sunsetNumLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label windSpeedNumLabel;
        private System.Windows.Forms.Label pressureNumLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tempLabel;
    }
}