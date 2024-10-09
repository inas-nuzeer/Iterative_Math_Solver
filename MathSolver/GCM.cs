using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSolver
{
    public partial class GCM : Form
    {
        public GCM()
        {
            InitializeComponent();
        }
        public bool NotNullField()
        {
            if (txtArray.Text == "")
            {
                MessageBox.Show("Field is Empty!!!");
                return false;
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGCM_Click(object sender, EventArgs e)
        {
            if (NotNullField())
            {
                try
                {
                    // Parse the input string into an array of integers
                    string[] inputNumbers = txtArray.Text.Split(',');
                    int[] numbers = new int[inputNumbers.Length];
                    for (int i = 0; i < inputNumbers.Length; i++)
                    {
                        numbers[i] = int.Parse(inputNumbers[i]);
                    }

                    // Calculate the GCD of the numbers
                    int gcd = numbers[0];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        gcd = GCD(gcd, numbers[i]);
                    }

                    // Display the result
                    lblResult.Text = "The GCD of the numbers is: " + gcd;
                }
                catch (FormatException)
                {
                    // Catch invalid input format errors
                    lblResult.Text = "Invalid input format";
                }
            }
        }
        static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }

        private void GCM_Load(object sender, EventArgs e)
        {

        }
    }
}
