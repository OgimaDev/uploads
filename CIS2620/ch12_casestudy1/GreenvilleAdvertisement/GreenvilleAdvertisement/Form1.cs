using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleAdvertisement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void creadAdButton_Click(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Test" + locationListBox.SelectedItem;

            var theName = textBox1.Text;
            var theLocation = locationListBox.SelectedItem;

            if (redRadio.Checked == true) 
            {
                welcomeLabel.Text = "Welcome To Greenville " + theName;
                secondLabel.Text = "How was " + theLocation + "?";
                welcomeLabel.ForeColor = Color.Red;
                welcomeLabel.Font = new Font("Times New Roman", 14);
                secondLabel.BackColor = Color.Red;
                secondLabel.Font = new Font("MS Gothic", 16);


            } else if (greenRadio.Checked == true)
            {
                welcomeLabel.Text = "Welcome To Greenville " + theName;
                secondLabel.Text = "How was " + theLocation + "?";
                welcomeLabel.ForeColor = Color.Green;
                welcomeLabel.Font = new Font("Times New Roman", 14);
                secondLabel.BackColor = Color.Green;
                secondLabel.Font = new Font("MS Gothic", 16);

            } else
            {
                welcomeLabel.Text = "Welcome To Greenville " + theName;
                secondLabel.Text = "How was " + theLocation + "?";
                welcomeLabel.ForeColor = Color.Blue;
                welcomeLabel.Font = new Font("Times New Roman", 14);
                secondLabel.BackColor = Color.Blue;
                secondLabel.Font = new Font("MS Gothic", 16);
            }
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void colorPickLabel_Click(object sender, EventArgs e)
        {

        }

        private void redRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void greenRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void blueRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
