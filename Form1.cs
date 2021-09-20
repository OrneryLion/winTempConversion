using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winTempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Fahrenheit_Click(object sender, EventArgs e)
        {
            fahrenheit_conversion();

        }
        private void fahrenheit_conversion()
        {
            float f = 0;

            f = float.Parse(txt_Fahrenheit.Text);

            float c = (f - 32f) / 1.8f;
            txt_Celsius.Text = c.ToString();

            float k = c + 273.15f;
            txt_Kelvin.Text = k.ToString();
        }

        private void btn_Celsius_Click(object sender, EventArgs e)
        {
            celcius_conversion();
        }

        private void celcius_conversion()
        {
            float c = 0;

            c = float.Parse(txt_Celsius.Text);

            float f = 9f / 5f * c + 32f;
            txt_Fahrenheit.Text = f.ToString();

            float k = c + 273.15f;
            txt_Kelvin.Text = k.ToString();

        }

        private void btn_Kelvin_Click(object sender, EventArgs e)
        {
            kelvin_conversion();
        }

        private void kelvin_conversion()
        {
            float k = 0;

            k = float.Parse(txt_Kelvin.Text);

            float f = k - 459.67f;
            txt_Fahrenheit.Text = f.ToString();

            float c = k - 273.15f;
            txt_Celsius.Text = c.ToString();
        }

        private void onChange(object sender, EventArgs e)
        {
            try
            {
                fahrenheit_conversion();
            }
            catch
            {
                MessageBox.Show("Enter numbers only");
            }
        }
    }
}
