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
    public partial class NewLinearEquation : Form
    {
        public NewLinearEquation()
        {
            InitializeComponent();
        }

        public bool NotNullFields()
        {
            if (cmbUnknown.SelectedIndex == 1)
            {
                //numUnknowns = 3;

                if (txtCE1A.Text == "" || txtCE1B.Text == "" || txtCE1C.Text == "" || txtConst1.Text == "")
                {
                    MessageBox.Show("Empty Fields!!!");
                    return false;
                }
                else if (txtCE2A.Text == "" || txtCE2B.Text == "" || txtCE2C.Text == "" || txtConst2.Text == "")
                {
                    MessageBox.Show("Empty Fields!!!");
                    return false;
                }
                else if (txtCE3A.Text == "" || txtCE3B.Text == "" || txtCE3C.Text == "" || txtConst3.Text == "")
                {
                    MessageBox.Show("Empty Fields!!!");
                    return false;
                }
            }
            else
            {
                if (txtCE1A.Text == "" || txtCE1B.Text == "" || txtConst1.Text == "")
                {
                    MessageBox.Show("Empty Fields!!!");
                    return false;
                }
                else if (txtCE2A.Text == "" || txtCE2B.Text == "" || txtConst2.Text == "")
                {
                    MessageBox.Show("Empty Fields!!!");
                    return false;
                }
            }
            return true;
        }
        public bool ValidInput()
        {
            try
            {
                if (cmbUnknown.SelectedIndex == 1)
                {
                    double inputInteger1 = Convert.ToDouble(txtCE1A.Text);
                    double inputInteger2 = Convert.ToDouble(txtCE1B.Text);
                    double inputInteger3 = Convert.ToDouble(txtCE1C.Text);
                    double inputInteger4 = Convert.ToDouble(txtConst1.Text);
                    double inputInteger5 = Convert.ToDouble(txtCE2A.Text);
                    double inputInteger6 = Convert.ToDouble(txtCE2B.Text);
                    double inputInteger7 = Convert.ToDouble(txtCE2C.Text);
                    double inputInteger8 = Convert.ToDouble(txtConst2.Text);
                    double inputInteger9 = Convert.ToDouble(txtCE3A.Text);
                    double inputInteger10 = Convert.ToDouble(txtCE3B.Text);
                    double inputInteger12 = Convert.ToDouble(txtCE3C.Text);
                    double inputInteger13 = Convert.ToDouble(txtConst3.Text);
                    return true;
                }
                else
                {
                    double inputInteger1 = Convert.ToDouble(txtCE1A.Text);
                    double inputInteger2 = Convert.ToDouble(txtCE1B.Text);
                    double inputInteger3 = Convert.ToDouble(txtConst1.Text);
                    double inputInteger4 = Convert.ToDouble(txtCE2A.Text);
                    double inputInteger5 = Convert.ToDouble(txtCE2B.Text);
                    double inputInteger6 = Convert.ToDouble(txtConst2.Text);
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input\nEnter Only Integer/Double Value!!!");
                return false;
            }
        }

        private void NewLinearEquation_Load(object sender, EventArgs e)
        {
            lblCE1C.Visible = false;
            txtCE1C.Visible = false;
            lblCE2C.Visible = false;
            txtCE2C.Visible = false;
            EqBox3.Visible = false;
            EqShowBox.Visible = false;

            this.Height = 500;
            lblE1C.Location = new Point(lblE1C.Location.X, lblE1C.Location.Y - 46);
            txtConst1.Location = new Point(txtConst1.Location.X, txtConst1.Location.Y - 46);
        
            lblE2C.Location = new Point(lblE2C.Location.X, lblE2C.Location.Y - 46);
            txtConst2.Location = new Point(txtConst2.Location.X, txtConst2.Location.Y - 46);

            EqBox1.Height = 150; 
            EqBox2.Height = 150;

            btnLinearEquation.Location = new Point(btnLinearEquation.Location.X, btnLinearEquation.Location.Y - 175);
            lblResult.Location = new Point(lblResult.Location.X, lblResult.Location.Y - 175);

        }

        private void btnLinearEquation_Click(object sender, EventArgs e)
        {
            if(NotNullFields())
            {
                if(ValidInput())
                {
                    // Check if it's a 2 or 3 unknown system
                    bool isTwoUnknowns = true;
                    if (!string.IsNullOrEmpty(txtCE3A.Text) || !string.IsNullOrEmpty(txtCE3B.Text) || !string.IsNullOrEmpty(txtCE3C.Text) || !string.IsNullOrEmpty(txtConst3.Text))
                    {
                        isTwoUnknowns = false;
                    }
                    if (isTwoUnknowns)
                    {
                        // 2 unknowns
                        double a1 = double.Parse(txtCE1A.Text);
                        double b1 = double.Parse(txtCE1B.Text);
                        double c1 = double.Parse(txtConst1.Text);

                        double a2 = double.Parse(txtCE2A.Text);
                        double b2 = double.Parse(txtCE2B.Text);
                        double c2 = double.Parse(txtConst2.Text);

                        // Calculate determinants
                        double det2x2 = a1 * b2 - a2 * b1;
                        double detX2 = c1 * b2 - c2 * b1;
                        double detY2 = a1 * c2 - a2 * c1;

                        // Check if system has a unique solution
                        if (det2x2 != 0)
                        {
                            lblEqShow1.Text = a1 + "x" + " + " + b1 + "y" + " = " + c1;
                            lblEqShow2.Text = a2 + "x" + " + " + b2 + "y" + " = " + c2;
                            lblEqShow3.Visible = false;
                            EqShowBox.Visible = true;
                            // Calculate solutions for x and y
                            double x = (double)detX2 / det2x2;
                            double y = (double)detY2 / det2x2;

                            // Output solutions
                            lblResult.Text = "Solution for x: " + x + "\n" + "Solution for y: " + y;
                        }
                        else
                        {
                            // System has no unique solution
                            lblResult.Text = "System has no unique solution.";
                        }
                    }
                    else
                    {
                        // 3 unknowns
                        double a1 = double.Parse(txtCE1A.Text);
                        double b1 = double.Parse(txtCE1B.Text);
                        double c1 = double.Parse(txtCE1C.Text);
                        double d1 = double.Parse(txtConst1.Text);

                        double a2 = double.Parse(txtCE2A.Text);
                        double b2 = double.Parse(txtCE2B.Text);
                        double c2 = double.Parse(txtCE2C.Text);
                        double d2 = double.Parse(txtConst2.Text);

                        double a3 = double.Parse(txtCE3A.Text);
                        double b3 = double.Parse(txtCE3B.Text);
                        double c3 = double.Parse(txtCE3C.Text);
                        double d3 = double.Parse(txtConst3.Text);

                        // Calculate determinants
                        double det3x3 = a1 * (b2 * c3 - b3 * c2) - b1 * (a2 * c3 - a3 * c2) + c1 * (a2 * b3 - a3 * b2);
                        double detX3 = d1 * (b2 * c3 - b3 * c2) - b1 * (d2 * c3 - d3 * c2) + c1 * (d2 * b3 - d3 * b2);
                        double detY3 = a1 * (d2 * c3 - d3 * c2) - d1 * (a2 * c3 - a3 * c2) + c1 * (a2 * d3 - a3 * d2);
                        double detZ3 = a1 * (b2 * d3 - b3 * d2) - b1 * (a2 * d3 - a3 * d2) + d1 * (a2 * b3 - a3 * b2);

                        // Check if system has a unique solution
                        if (det3x3 != 0)
                        {
                            lblEqShow1.Text = a1 + "x" + " + " + b1 + "y" + " + " + c1 + "z" + " = " + d1;
                            lblEqShow2.Text = a2 + "x" + " + " + b2 + "y" + " + " + c2 + "z" + " = " + d2;
                            lblEqShow3.Text = a1 + "x" + " + " + b1 + "y" + " + " + c3 + "z" + " = " + d3;
                            lblEqShow3.Visible = true;
                            EqShowBox.Visible = true;
                            // Calculate solutions for x, y and z
                            double x = (double)detX3 / det3x3;
                            double y = (double)detY3 / det3x3;
                            double z = (double)detZ3 / det3x3;    // Output solutions
                            lblResult.Text = "Solution for x: " + x + "\n" + "Solution for y: " + y + "\n" + "Solution for z: " + z;
                        }
                        else
                        {
                            // System has no unique solution
                            lblResult.Text = "System has no unique solution.";
                        }
                    }
                }
                
            }

        }

        private void cmbUnknown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Point dllblE1C = new Point(50, 100);//lblE1C.Location;
                Point dltxtConst1 = new Point(130, 100);// txtConst1.Location;
                Point dllblE2C = new Point(50, 100);//lblE2C.Location;
                Point dltxtConst2 = new Point(130, 100);//txtConst2.Location;
                int dlEqBox1 = 150;// EqBox1.Height;
                int dlEqBox2 = 150;//EqBox2.Height;
                Point dlbtnLinearEquation = new Point(250, 320);// btnLinearEquation.Location;
                Point dllblResult = new Point(320, 360);// lblResult.Location;

                // Determine the number of unknowns to solve for
                int numUnknowns = 0;// = 2;
                if (cmbUnknown.SelectedIndex == 0)
                {
                    numUnknowns = 2;
                }
                else if (cmbUnknown.SelectedIndex == 1)
                    numUnknowns = 3;

                // Hide or show the appropriate input fields
                switch (numUnknowns)
                {
                    case 2:
                        lblCE1C.Visible = false;
                        txtCE1C.Visible = false;
                        lblCE2C.Visible = false;
                        txtCE2C.Visible = false;
                        EqBox3.Visible = false;

                        this.Height = 500;
                        lblE1C.Location = dllblE1C;
                        txtConst1.Location = dltxtConst1;

                        lblE2C.Location = dllblE2C;
                        txtConst2.Location = dltxtConst2;

                        EqBox1.Height = dlEqBox1;
                        EqBox2.Height = dlEqBox2;

                        btnLinearEquation.Location = dlbtnLinearEquation;
                        lblResult.Location = dllblResult;

                        break;
                    case 3:
                        lblCE1C.Visible = true;
                        txtCE1C.Visible = true;
                        lblCE2C.Visible = true;
                        txtCE2C.Visible = true;
                        EqBox3.Visible = true;

                        this.Height = 660;
                        lblE1C.Location = new Point(lblE1C.Location.X, lblE1C.Location.Y + 46);
                        txtConst1.Location = new Point(txtConst1.Location.X, txtConst1.Location.Y + 46);

                        lblE2C.Location = new Point(lblE2C.Location.X, lblE2C.Location.Y + 46);
                        txtConst2.Location = new Point(txtConst2.Location.X, txtConst2.Location.Y + 46);

                        EqBox1.Height = 190;
                        EqBox2.Height = 190;

                        btnLinearEquation.Location = new Point(btnLinearEquation.Location.X, btnLinearEquation.Location.Y + 200);
                        lblResult.Location = new Point(lblResult.Location.X + 220, lblResult.Location.Y - 20);

                        break;
                }
            }
            catch (FormatException)
            {
                lblResult.Text = "Invalid input format";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlEq1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCE1B_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCE1B_Click(object sender, EventArgs e)
        {

        }

        private void lblE1C_Click(object sender, EventArgs e)
        {

        }

        private void txtConst1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblE3C_Click(object sender, EventArgs e)
        {

        }

        private void EqBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblEqShow1_Click(object sender, EventArgs e)
        {

        }
    }
}