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

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 629;
            txtDisplay.Width = 589;
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0" || enter_value))
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

        private void clear_entry(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void clear_text(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void bckspce(object sender, EventArgs e)
        {
            if (txtDisplay.Text .Length  >0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);

            }
            if(txtDisplay.Text== "")
                {
                txtDisplay.Text = "0";
            }
        
        }

        private void operators_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void equals_click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text =( results + Double.Parse (txtDisplay.Text )).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                   txtDisplay.Text = Math.Exp (i * Math.Log(q*4)).ToString();
                    break;
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.14159265";

        }

        private void log_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
            lblShowOp.Text = System.Convert.ToString("log"+ "(" + Double.Parse(txtDisplay.Text)+ ")");
        }

        private void pi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.14159265";
        }
    }
    }

