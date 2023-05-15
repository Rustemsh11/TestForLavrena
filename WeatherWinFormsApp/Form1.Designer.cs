namespace WeatherWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.GetWeatherButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.WindSeedLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(53, 66);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(213, 27);
            this.CityTextBox.TabIndex = 0;
            // 
            // GetWeatherButton
            // 
            this.GetWeatherButton.Location = new System.Drawing.Point(290, 66);
            this.GetWeatherButton.Name = "GetWeatherButton";
            this.GetWeatherButton.Size = new System.Drawing.Size(118, 27);
            this.GetWeatherButton.TabIndex = 1;
            this.GetWeatherButton.Text = "Узнать";
            this.GetWeatherButton.UseVisualStyleBackColor = true;
            this.GetWeatherButton.Click += new System.EventHandler(this.GetWeatherButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(53, 222);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(136, 32);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Описание: ";
            
            // 
            // WindSeedLabel
            // 
            this.WindSeedLabel.AutoSize = true;
            this.WindSeedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WindSeedLabel.Location = new System.Drawing.Point(53, 283);
            this.WindSeedLabel.Name = "WindSeedLabel";
            this.WindSeedLabel.Size = new System.Drawing.Size(190, 32);
            this.WindSeedLabel.TabIndex = 4;
            this.WindSeedLabel.Text = "Скорость ветра:";
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TempLabel.Location = new System.Drawing.Point(53, 163);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(163, 32);
            this.TempLabel.TabIndex = 5;
            this.TempLabel.Text = "Температура:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.WindSeedLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.GetWeatherButton);
            this.Controls.Add(this.CityTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CityTextBox;
        private Button GetWeatherButton;
        private Label DescriptionLabel;
        private Label WindSeedLabel;
        private Label TempLabel;
    }
}