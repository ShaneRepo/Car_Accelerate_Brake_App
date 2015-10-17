using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Accelerate_Brake_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelShowMPH.Text = "0";
        }
        // Exit the app 
        private void buttonExit_Click(object sender, EventArgs e)
        {
            int mph = int.Parse(labelShowMPH.Text);
            if (mph > 75)
            {
                MessageBox.Show("Slow down next time citizen :)");
                this.Close();
            }
            else
            {
                MessageBox.Show("Drive safe citizen :)");
                this.Close();
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter year and make into textbox and then click start. Accelerate to go fast, brake to go slow.");
        }
        // Start the app and initialize the constuctor with user input
        private void buttonStart_Click(object sender, EventArgs e)
        {
            int y;
            string m;
            bool checkY = false;
            bool checkM = false;
            if (string.IsNullOrWhiteSpace(textBoxYear.Text))
            {
                MessageBox.Show("Enter year please.");
            }
            else
            {
                checkY = true;
            }
            if (string.IsNullOrWhiteSpace(textBoxMake.Text))
            {
                MessageBox.Show("Enter make please.");
            }
            else
            {
                checkM = true;
            }
            if (checkY == true && checkM == true)
            {
                y = int.Parse(textBoxYear.Text);
                m = textBoxMake.Text;
                Car aCar = new Car(y, m);
            }
           
        }
        // Allow only numbers and backspace in textbox = user proof
        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
