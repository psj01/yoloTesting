using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetYo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Current time : " + DateTime.Now.ToShortTimeString();

            label3.Text = " ";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            RadioButton rb = null;

            if ( radioButton1.Checked == true)
            {
                rb = radioButton1;
            }
            else if (radioButton2.Checked == true)
            {
                rb = radioButton2;
            }
            else
            {
                rb = radioButton1;
            }
            
            label3.Text = "Alarm set for : " + comboBox1.Text + ":"+ comboBox2.Text + " " + rb.Text;
                   

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label2.Text = "Current time : " + DateTime.Now.ToShortTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            label3.Text = " ";
        }

        
    }
}
