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
        ICalc Calc;
        public Form1(ICalc calc)
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
            if (results != 0 && !value)
            {
                eqBtn.PerformClick();
                operations = op.Text;
                //results = Double.Parse(screen.Text);
                //screen.Text = "";
                show.Text = results + " " + operations;
                value = true;
            }
            
            operations = op.Text;
            double dou;
            if (Double.TryParse(screen.Text, out dou))
            {
                results = Double.Parse(screen.Text);
            }
            //screen.Text = "";
            show.Text = results + " " + operations;
                value = true;
            
        }

        private void eqBtn_Click(object sender, EventArgs e)
        {
            double d;
            double newFeed;
            
            if (Double.TryParse(screen.Text, out d))
            {
                Double.Parse(screen.Text);
            }
            //double newFeed = Double.Parse(screen.Text);
            newFeed = d;
            screen.Text = Calc.Equall(results, newFeed, operations);
            /* if (operations == "+")
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
             }*/
            double doe;
            if (Double.TryParse(screen.Text, out doe)) {
                results = Double.Parse(screen.Text);
            }
            
            operations = "";
            show.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            results = 0;
            show.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num = Double.Parse(screen.Text);
            num *= -1;
            screen.Text = num.ToString();
        }
    }
}
