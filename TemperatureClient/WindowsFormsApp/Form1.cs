using ServiceReference1;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        WebService1SoapClient serviceClient;

        public Form1()
        {
            InitializeComponent();
            serviceClient = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);
        }

        private async void btnToCelsius_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtInput.Text, out double fahrenheit))
                {
                    MessageBox.Show("Please enter a valid number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double celsius = await serviceClient.FahrenheitToCelsiusAsync(fahrenheit);
                lblResult.Text = $"{fahrenheit}°F = {celsius:F2}°C";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnToFahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtInput.Text, out double celsius))
                {
                    MessageBox.Show("Please enter a valid number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double fahrenheit = await serviceClient.CelsiusToFahrenheitAsync(celsius);
                lblResult.Text = $"{celsius}°C = {fahrenheit:F2}°F";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
