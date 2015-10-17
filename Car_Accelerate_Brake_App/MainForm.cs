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
                this.Close();
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter year and make into textbox and then click start. Accelerate to go fast, brake to go slow.");
        }
    }
}
