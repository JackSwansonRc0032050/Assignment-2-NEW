using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
            //The following code works out the total resistance or a series circuit//
        {
            double r1, r2, r3, r4, r5;

            try
            {
                r1 = double.Parse(textBox6.Text);
            }
            catch
            {
                r1 = 0;
            }

            try
            {
                r2 = double.Parse(textBox7.Text);
            }
            catch
            {
                r2 = 0;
            }

            try
            {
                r3 = double.Parse(textBox8.Text);
            }
            catch
            {
                r3 = 0;
            }

            try
            {
                r4 = double.Parse(textBox9.Text);
            }
            catch
            {
                r4 = 0;
            }

            try
            {
                r5 = double.Parse(textBox10.Text);
            }
            catch
            {
                r5 = 0;
            }
            double rt = r1 + r2 + r3 + r4 + r5;
            label2.Text = "Total resistance =" + rt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            //The next stage of coding works out the resistance od a parallel circuit//
        {
            double r1, r2, r3, r4, r5;

            double rrt = 0;

            try
            {
                r1 = double.Parse(textBox1.Text);
                rrt = rrt + 1 / r1;
            }
            catch
            {

            }
            try
            {
                r2 = double.Parse(textBox2.Text);
                rrt = rrt + 1 / r2;
            }
            catch
            {

            }
            try
            {
                r3 = double.Parse(textBox3.Text);
                rrt = rrt + 1 / r3;
            }
            catch
            {

            }
            try
            {
                r4 = double.Parse(textBox4.Text);
                rrt = rrt + 1 / r4;
            }
            catch
            {

            }
            try
            {
                r5 = double.Parse(textBox5.Text);
                rrt = rrt + 1 / r5;
            }
            catch
            {

            }
            //The last lines allow an answer to appear when asking the code to work out the resistance of the numbers entered//
            double rt = 1 / rrt;
            label1.Text = "total resistance =" + rt;
            
               
        }
    }
}
