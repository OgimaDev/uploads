/*
 * Jacob 
 * Chapter 3
 * Case Problem 1
 * CIS 2620
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
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

        private void label2_Click(object sender, EventArgs e) // This Years Label
        {

        }

        private void label1_Click(object sender, EventArgs e) // Last Years Label
        {

        }

        private void label4_Click(object sender, EventArgs e) // Input data reveal area 
        {

        }

        private void button1_Click(object sender, EventArgs e) // The Button 
        {
            int numLastYear = Convert.ToInt32(textBox1.Text);
            int numThisYear = Convert.ToInt32(textBox2.Text);
            int theFee      = numLastYear + numThisYear;
            int theCost     = 25;
            int totalLast   = numLastYear * theCost;
            int totalNew    = numThisYear * theCost;
            
            // winner of most guests
            if (numLastYear > numThisYear) 
            { 
                 
                label4.Text =   "Last year raised:          $" + totalLast + "\n" +
                                "This Current year raised:  $" + totalNew + "\n" +
                                "Year with most people:     Last year with " + numLastYear + "guests.";
            }
            else
            {           
                label4.Text =   "Last year raised:          $" + totalLast + "\n" +
                                "This Current year raised:  $" + totalNew + "\n" +
                                "Year with most people:     This year with " + numThisYear + "guests.";
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label3_Click(object sender, EventArgs e) // A nice Label
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)// Last Years input box
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Current Year input box
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)// this year display output
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)// last year display output
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) // which year had most
        {

        }
    }
}
