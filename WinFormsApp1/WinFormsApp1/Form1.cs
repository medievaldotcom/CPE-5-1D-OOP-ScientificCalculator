using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{


    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 424;
            txtDisplay.Width = 386;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 629;
            txtDisplay.Width = 589;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == " 0" || enter_value))
                txtDisplay.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;

            }
        }
    }

