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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MathSolver
{
    public partial class LinearEquation : Form
    {
        public LinearEquation()
        {
            InitializeComponent();
        }
        public bool NotNullFields()
        {
            if (txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("    Empty Fields!!!     ");
                return false;
            }
            return true;
        }
        private void btnLinearEquation_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                try
                {
                    // Parse input values
                    double a = double.Parse(txtA.Text);
                    double b = double.Parse(txtB.Text);

                    // Solve equation
                    double x = -b / a;

                    // Display result
                    lblResult.Text = "x = " + x.ToString();
                }
                catch (FormatException)
                {
                    // Catch invalid input format errors
                    MessageBox.Show("Invalid input format");
                }
                catch (DivideByZeroException)
                {
                    // Catch division by zero errors
                    MessageBox.Show("The coefficient a cannot be zero");
                }
            }
        }

        private void LinearEquation_Load(object sender, EventArgs e)
        {
            
        }
    }
}
