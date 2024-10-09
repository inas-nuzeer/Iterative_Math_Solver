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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGCM_Click(object sender, EventArgs e)
        {
            GCM gcm = new GCM();
            gcm.Show();
        }

        private void btnLCM_Click(object sender, EventArgs e)
        {
            LCM lcm = new LCM();
            lcm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            //lblUserName.Text = frmLogin.Username;
        }

        private void btnDeterminant_Click(object sender, EventArgs e)
        {
            Determinant dtm = new Determinant();
            dtm.Show();
        }

        private void btnLE_Click(object sender, EventArgs e)
        {
            LinearEquation linearEquation = new LinearEquation();
            linearEquation.Show();
        }

        private void btnQE_Click(object sender, EventArgs e)
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            quadraticEquation.Show();
        }

        private void btnLEU_Click(object sender, EventArgs e)
        {
            NewLinearEquation newLinearEquation = new NewLinearEquation();
            newLinearEquation.Show();
        }

        private void btnLE3_Click(object sender, EventArgs e)
        {
            //LinearEquation3 linearEquation3 = new LinearEquation3();
            //linearEquation3.Show();
        }
    }
}
