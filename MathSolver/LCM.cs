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
    public partial class LCM : Form
    {
        public LCM()
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

        private void btnLCM_Click(object sender, EventArgs e)
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

                    // Calculate the LCM of the numbers
                    int lcm = numbers[0];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        lcm = LCMF(lcm, numbers[i]);
                    }

                    // Display the result
                    lblResult.Text = "The LCM of the numbers is: " + lcm;
                }
                catch (FormatException)
                {
                    // Catch invalid input format errors
                    MessageBox.Show("Invalid input format");
                }
            }
        }

        static int LCMF(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
        static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
    }
}
