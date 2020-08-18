using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        public Double results = 0;
        public String operations = "";
        bool value = false;
       // AllMethods Calc;
        public Form1()
        {
            InitializeComponent();
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
    }
}
