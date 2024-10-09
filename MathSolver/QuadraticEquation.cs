using System;
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
    public partial class QuadraticEquation : Form
    {
        public QuadraticEquation()
        {
            InitializeComponent();
        }
        public bool NotNullFields()
        {
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "")
            {
                MessageBox.Show("    Empty Fields!!!     ");
                return false;
            }
            return true;
        }
        private void btnQuadraticEquation_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                try
                {
                    // Parse the input coefficients
                    double a = double.Parse(txtA.Text);
                    double b = double.Parse(txtB.Text);
                    double c = double.Parse(txtC.Text);

                    // Calculate the discriminant
                    double discriminant = b * b - 4 * a * c;

                    if (discriminant < 0)
                    {
                        // Display the result for imaginary roots
                        double realPart = -b / (2 * a);
                        double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                        lblResult1.Text = "(+) x1 = " + string.Format("{0:0.##} + {1:0.##}i", realPart, imaginaryPart);
                        lblResult2.Text = "(-) x2 = " + string.Format("{0:0.##} - {1:0.##}i", realPart, imaginaryPart);
                    }
                    else if (discriminant == 0)
                    {
                        // Display the result for a single root
                        double root = -b / (2 * a);
                        lblResult1.Text = "(+) x1 = " + root.ToString();
                        lblResult2.Text = "(-) x21 = " + root.ToString();
                    }
                    else
                    {
                        // Display the result for two real roots
                        double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                        double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                        lblResult1.Text = "(+) x1 = " + root1.ToString();
                        lblResult2.Text = "(-) x2 = " + root2.ToString();
                    }
                }
                catch (FormatException)
                {
                    // Catch invalid input format errors
                    MessageBox.Show("Invalid input format");
                    MessageBox.Show("Invalid input format");
                }
            }
        }

        private void QuadraticEquation_Load(object sender, EventArgs e)
        {

        }

        private void lblResult1_Click(object sender, EventArgs e)
        {

        }
    }
}
