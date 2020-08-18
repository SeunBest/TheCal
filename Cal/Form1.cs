using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libraries;

namespace Cal
{
    public partial class Form1 : Form
    {
        public Double results = 0;
        public String operations = "";
        bool value = false;
        AllMethods Calc;
        public Form1(AllMethods calc)
        {
            InitializeComponent();
            Calc = calc;
        }

        private void btnClick(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (value))
                screen.Clear();

            value = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!screen.Text.Contains("."))
                    screen.Text += button.Text;
            }
            else
                screen.Text += button.Text;
        }

        private void arithmetics(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            if (results != 0)
            {
                eqBtn.PerformClick();
                operations = op.Text;
                //results = Double.Parse(screen.Text);
                // screen.Text = "";
                show.Text = results + " " + operations;
                value = true;
            }
            else
            {
                operations = op.Text;
                results = Double.Parse(screen.Text);
                //screen.Text = "";
                show.Text = results + " " + operations;
                value = true;
            }
        }

        private void eqBtn_Click(object sender, EventArgs e)
        {
            double newFeed = Double.Parse(screen.Text);
            if (operations == "+")
            {
                screen.Text = Calc.Addition(results, newFeed).ToString();
            }
            else if (operations == "-")
            {
                screen.Text = Calc.Subtraction(results, newFeed).ToString();
            }
            else if (operations == "X")
            {
                screen.Text = Calc.Multiplication(results, newFeed).ToString();
            }
            else if (operations == "/")
            {
                screen.Text = Calc.Division(results, newFeed).ToString();
            }

            results = Double.Parse(screen.Text);
            show.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            results = 0;
            show.Text = "";
        }
    }
}
