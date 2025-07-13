//Tecumseh McMullin Calculator 1.0
//MS529 assignment 1.2

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation
{
    public partial class Home : Form
    {
        //main function that initiallizes the beginning.
        public Home()
        {
            //inistiallizing the starting positions and clearing the empty boxes
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label15.Text = string.Empty;
            label14.Text = string.Empty;
            label13.Text = string.Empty;
            label12.Text = string.Empty;
            label11.Text = string.Empty;
            label10.Text = string.Empty;
            label9.Text = string.Empty;
            label8.Text = string.Empty;
            label7.Text = string.Empty;
            label6.Text = string.Empty;
            label5.Text = string.Empty;
            label4.Text = string.Empty;
            label19.Text = string.Empty;
            label20.Text = string.Empty;
            label21.Text = string.Empty;
            label22.Text = string.Empty;
            label23.Text = string.Empty;
            label24.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Pressing this calculate button starts this function.
        private void Calculate_Click_1(object sender, EventArgs e)
        {
            //Initiallizing strings for input from the user
            string name1 = textBox13.Text;
            string name2 = textBox14.Text;
            string name3 = textBox15.Text;
            string name4 = textBox16.Text;
            string name5 = textBox17.Text;
            string name6 = textBox18.Text;

            //Initiallizing variables for use for the if/else statement, then doing the conversion math for the calculator. clearing if no input.
            int stack1;
            int totalA1;

            if (int.TryParse(textBox1.Text, out stack1) && int.TryParse(textBox2.Text, out totalA1))
            {
                label15.Text = Convert.ToString(totalA1 / stack1);
                label19.Text = Convert.ToString(totalA1 % stack1);
            }
            else
            {
                label15.Text = string.Empty;
                label19.Text = string.Empty;
            }

            //Initiallizing variables for use for the if/else statement, then doing the conversion math for the calculator. clearing if no input.
            int stack2;
            int totalA2;

            if (int.TryParse(textBox4.Text, out stack2) && int.TryParse(textBox3.Text, out totalA2))
            {
                label14.Text = Convert.ToString(totalA2 / stack2);
                label20.Text = Convert.ToString(totalA2 % stack2);
            }
            else
            {
                label14.Text = string.Empty;
                label20.Text = string.Empty;
            }

            //Initiallizing variables for use for the if/else statement, then doing the conversion math for the calculator. clearing if no input.
            int stack3;
            int totalA3;

            if (int.TryParse(textBox6.Text, out stack3) && int.TryParse(textBox5.Text, out totalA3))
            {
                label13.Text = Convert.ToString(totalA3 / stack3);
                label21.Text = Convert.ToString(totalA3 % stack3);
            }
            else
            {
                label13.Text = string.Empty;
                label21.Text = string.Empty;
            }

            //Initiallizing variables for use for the if/else statement, then doing the conversion math for the calculator. clearing if no input.
            int stack4;
            int totalA4;

            if (int.TryParse(textBox8.Text, out stack4) && int.TryParse(textBox7.Text, out totalA4))
            {
                label12.Text = Convert.ToString(totalA4 / stack4);
                label22.Text = Convert.ToString(totalA4 % stack4);
            }
            else
            {
                label12.Text = string.Empty;
                label22.Text = string.Empty;
            }

            //Initiallizing variables for use for the if/else statement, then doing the conversion math for the calculator. clearing if no input.
            int stack5;
            int totalA5;

            if (int.TryParse(textBox10.Text, out stack5) && int.TryParse(textBox9.Text, out totalA5))
            {
                label11.Text = Convert.ToString(totalA5 / stack5);
                label23.Text = Convert.ToString(totalA5 % stack5);
            }
            else
            {
                label11.Text = string.Empty;
                label23.Text = string.Empty;
            }

            //Initiallizing variables for use for the if/else statement, then doing the conversion math for the calculator. clearing if no input.
            int stack6;
            int totalA6;

            if (int.TryParse(textBox12.Text, out stack6) && int.TryParse(textBox11.Text, out totalA6))
            {
                label10.Text = Convert.ToString(totalA6 / stack6);
                label24.Text = Convert.ToString(totalA6 % stack6);
            }
            else
            {
                label10.Text = string.Empty;
                label24.Text = string.Empty;
            }

            //making the inputed names move to the labels.
            label4.Text = name1;
            label5.Text = name2;
            label6.Text = name3;
            label7.Text = name4;
            label8.Text = name5;
            label9.Text = name6;

         
        }
    }
}
