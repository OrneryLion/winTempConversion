
namespace winTempConversion
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
            this.lbl_Fahrenheit = new System.Windows.Forms.Label();
            this.lbl_Celsius = new System.Windows.Forms.Label();
            this.lbl_Kelvin = new System.Windows.Forms.Label();
            this.txt_Fahrenheit = new System.Windows.Forms.TextBox();
            this.txt_Celsius = new System.Windows.Forms.TextBox();
            this.txt_Kelvin = new System.Windows.Forms.TextBox();
            this.btn_Fahrenheit = new System.Windows.Forms.Button();
            this.btn_Celsius = new System.Windows.Forms.Button();
            this.btn_Kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Fahrenheit
            // 
            this.lbl_Fahrenheit.AutoSize = true;
            this.lbl_Fahrenheit.Location = new System.Drawing.Point(27, 25);
            this.lbl_Fahrenheit.Name = "lbl_Fahrenheit";
            this.lbl_Fahrenheit.Size = new System.Drawing.Size(63, 15);
            this.lbl_Fahrenheit.TabIndex = 0;
            this.lbl_Fahrenheit.Text = "Fahrenheit";
            // 
            // lbl_Celsius
            // 
            this.lbl_Celsius.AutoSize = true;
            this.lbl_Celsius.Location = new System.Drawing.Point(44, 74);
            this.lbl_Celsius.Name = "lbl_Celsius";
            this.lbl_Celsius.Size = new System.Drawing.Size(39, 15);
            this.lbl_Celsius.TabIndex = 1;
            this.lbl_Celsius.Text = "Celius";
            // 
            // lbl_Kelvin
            // 
            this.lbl_Kelvin.AutoSize = true;
            this.lbl_Kelvin.Location = new System.Drawing.Point(44, 131);
            this.lbl_Kelvin.Name = "lbl_Kelvin";
            this.lbl_Kelvin.Size = new System.Drawing.Size(39, 15);
            this.lbl_Kelvin.TabIndex = 2;
            this.lbl_Kelvin.Text = "Kelvin";
            // 
            // txt_Fahrenheit
            // 
            this.txt_Fahrenheit.Location = new System.Drawing.Point(139, 17);
            this.txt_Fahrenheit.Name = "txt_Fahrenheit";
            this.txt_Fahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txt_Fahrenheit.TabIndex = 3;
            this.txt_Fahrenheit.TextChanged += new System.EventHandler(this.onChange);
            // 
            // txt_Celsius
            // 
            this.txt_Celsius.Location = new System.Drawing.Point(139, 66);
            this.txt_Celsius.Name = "txt_Celsius";
            this.txt_Celsius.Size = new System.Drawing.Size(100, 23);
            this.txt_Celsius.TabIndex = 4;
            // 
            // txt_Kelvin
            // 
            this.txt_Kelvin.Location = new System.Drawing.Point(139, 123);
            this.txt_Kelvin.Name = "txt_Kelvin";
            this.txt_Kelvin.Size = new System.Drawing.Size(100, 23);
            this.txt_Kelvin.TabIndex = 5;
            // 
            // btn_Fahrenheit
            // 
            this.btn_Fahrenheit.Location = new System.Drawing.Point(291, 16);
            this.btn_Fahrenheit.Name = "btn_Fahrenheit";
            this.btn_Fahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btn_Fahrenheit.TabIndex = 6;
            this.btn_Fahrenheit.Text = "Convert";
            this.btn_Fahrenheit.UseVisualStyleBackColor = true;
            this.btn_Fahrenheit.Click += new System.EventHandler(this.btn_Fahrenheit_Click);
            // 
            // btn_Celsius
            // 
            this.btn_Celsius.Location = new System.Drawing.Point(290, 65);
            this.btn_Celsius.Name = "btn_Celsius";
            this.btn_Celsius.Size = new System.Drawing.Size(75, 23);
            this.btn_Celsius.TabIndex = 7;
            this.btn_Celsius.Text = "Convert";
            this.btn_Celsius.UseVisualStyleBackColor = true;
            this.btn_Celsius.Click += new System.EventHandler(this.btn_Celsius_Click);
            // 
            // btn_Kelvin
            // 
            this.btn_Kelvin.Location = new System.Drawing.Point(289, 123);
            this.btn_Kelvin.Name = "btn_Kelvin";
            this.btn_Kelvin.Size = new System.Drawing.Size(75, 23);
            this.btn_Kelvin.TabIndex = 8;
            this.btn_Kelvin.Text = "Convert";
            this.btn_Kelvin.UseVisualStyleBackColor = true;
            this.btn_Kelvin.Click += new System.EventHandler(this.btn_Kelvin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 208);
            this.Controls.Add(this.btn_Kelvin);
            this.Controls.Add(this.btn_Celsius);
            this.Controls.Add(this.btn_Fahrenheit);
            this.Controls.Add(this.txt_Kelvin);
            this.Controls.Add(this.txt_Celsius);
            this.Controls.Add(this.txt_Fahrenheit);
            this.Controls.Add(this.lbl_Kelvin);
            this.Controls.Add(this.lbl_Celsius);
            this.Controls.Add(this.lbl_Fahrenheit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Fahrenheit;
        private System.Windows.Forms.Label lbl_Celsius;
        private System.Windows.Forms.Label lbl_Kelvin;
        private System.Windows.Forms.TextBox txt_Fahrenheit;
        private System.Windows.Forms.TextBox txt_Celsius;
        private System.Windows.Forms.TextBox txt_Kelvin;
        private System.Windows.Forms.Button btn_Fahrenheit;
        private System.Windows.Forms.Button btn_Celsius;
        private System.Windows.Forms.Button btn_Kelvin;
    }
}

