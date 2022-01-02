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
            this.Width = 829;
            txtDisplay.Width = 789;
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

        private void Sqrt_click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);
        }

        private void sin_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
            qSin = Math.Sin(qSin);
            txtDisplay.Text = System.Convert.ToString(qSin);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")");
            qCos = Math.Cos(qCos);
            txtDisplay.Text = System.Convert.ToString(qCos);
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")");
            qTan = Math.Tan(qTan);
            txtDisplay.Text = System.Convert.ToString(qTan);
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtDisplay.Text = System.Convert.ToString(qSinh);
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            txtDisplay.Text = System.Convert.ToString(qCosh);
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            txtDisplay.Text = System.Convert.ToString(qTanh);
        }

        private void bin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a,2);
        }

        private void dec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void oct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void hex_Click(object sender, EventArgs e)
        {

        }
    }
    }

