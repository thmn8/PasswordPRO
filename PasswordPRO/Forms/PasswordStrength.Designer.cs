namespace PasswordPRO.Forms
{
    partial class PasswordStrength
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordStrength));
            this.PassText = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.DigitLabel = new System.Windows.Forms.Label();
            this.UpperLabel = new System.Windows.Forms.Label();
            this.LowerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PassText
            // 
            this.PassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassText.ForeColor = System.Drawing.Color.Red;
            this.PassText.Location = new System.Drawing.Point(12, 22);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(402, 30);
            this.PassText.TabIndex = 4;
            this.PassText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassText.TextChanged += new System.EventHandler(this.PassText_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 205);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(426, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(91, 85);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(192, 16);
            this.LengthLabel.TabIndex = 22;
            this.LengthLabel.Text = "Длина пароля > 12 символов";
            // 
            // DigitLabel
            // 
            this.DigitLabel.AutoSize = true;
            this.DigitLabel.Location = new System.Drawing.Point(91, 112);
            this.DigitLabel.Name = "DigitLabel";
            this.DigitLabel.Size = new System.Drawing.Size(112, 16);
            this.DigitLabel.TabIndex = 23;
            this.DigitLabel.Text = "Наличие цифры";
            // 
            // UpperLabel
            // 
            this.UpperLabel.AutoSize = true;
            this.UpperLabel.Location = new System.Drawing.Point(91, 140);
            this.UpperLabel.Name = "UpperLabel";
            this.UpperLabel.Size = new System.Drawing.Size(240, 16);
            this.UpperLabel.TabIndex = 24;
            this.UpperLabel.Text = "Наличие буквы в верхнем регистре";
            // 
            // LowerLabel
            // 
            this.LowerLabel.AutoSize = true;
            this.LowerLabel.Location = new System.Drawing.Point(91, 165);
            this.LowerLabel.Name = "LowerLabel";
            this.LowerLabel.Size = new System.Drawing.Size(235, 16);
            this.LowerLabel.TabIndex = 25;
            this.LowerLabel.Text = "Наличие буквы в нижнем регистре";
            // 
            // PasswordStrength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 229);
            this.Controls.Add(this.LowerLabel);
            this.Controls.Add(this.UpperLabel);
            this.Controls.Add(this.DigitLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PassText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(444, 271);
            this.MinimumSize = new System.Drawing.Size(444, 271);
            this.Name = "PasswordStrength";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Надежность пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label DigitLabel;
        private System.Windows.Forms.Label UpperLabel;
        private System.Windows.Forms.Label LowerLabel;
    }
}