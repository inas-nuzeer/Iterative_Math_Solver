using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace MathSolver
{
    public partial class Determinant : Form
    {
        public Determinant()
        {
            InitializeComponent();
        }
        public bool NotNullFields()
        {
            if (txtrow1.Text == "" || txtrow2.Text == "" || txtrow3.Text == "" || txtrow4.Text == "")
            {
                MessageBox.Show("Empty Fields!!!");
                return false;
            }
            return true;
        }
        public bool ValidInput()
        {
            int count1 = txtrow1.Text.Count(c => c == ',');
            int count2 = txtrow2.Text.Count(c => c == ',');
            int count3 = txtrow3.Text.Count(c => c == ',');
            int count4 = txtrow4.Text.Count(c => c == ',');

            if (count1 == 3 && count2 == 3 && count3 == 3 && count4 == 3)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Input must contains Values for 4 columns (4X4 Matrics)!!!");
                return false;
            }
            
        }
        private void lblarray_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLCM_Click(object sender, EventArgs e)
        {

        }

        private void txtArray_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void Determinant_Load(object sender, EventArgs e)
        {

        }

        private void btnDeterminant_Click(object sender, EventArgs e)
        {

            if (NotNullFields())
            {
                if (ValidInput())
                {
                    try
                    {
                        // Parse the input string into a 2D array of integers
                        string arr = txtrow1.Text + ';' + txtrow2.Text + ';' + txtrow3.Text + ';' + txtrow4.Text;
                        string[] rows = arr.Split(';');
                        int[,] matrix = new int[4, 4];
                        for (int i = 0; i < rows.Length; i++)
                        {
                            string[] cols = rows[i].Split(',');
                            for (int j = 0; j < cols.Length; j++)
                            {
                                matrix[i, j] = int.Parse(cols[j]);
                            }
                        }

                        // Calculate the determinant of the matrix
                        int determinant = CalculateDeterminant(matrix);

                        // Display the result
                        lblResult.Text = "The determinant of the matrix is: " + determinant;
                    }
                    catch (FormatException)
                    {
                        // Catch invalid input format errors
                        MessageBox.Show("Invalid input format");
                    }
                    catch (IndexOutOfRangeException)
                    {
                        // Catch invalid matrix size errors
                        MessageBox.Show("Invalid matrix size");
                    }
                }
            }
        }
        static int CalculateDeterminant(int[,] matrix)
        {
            if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
            {
                // Base case for 2x2 matrix
                return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            }
            else
            {
                // Recursive case for larger matrices
                int determinant = 0;
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    int[,] submatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
                    for (int j = 1; j < matrix.GetLength(0); j++)
                    {
                        for (int k = 0; k < matrix.GetLength(1); k++)
                        {
                            if (k < i)
                            {
                                submatrix[j - 1, k] = matrix[j, k];
                            }
                            else if (k > i)
                            {
                                submatrix[j - 1, k - 1] = matrix[j, k];
                            }
                        }
                    }
                    determinant += (int)Math.Pow(-1, i) * matrix[0, i] * CalculateDeterminant(submatrix);
                }
                return determinant;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
