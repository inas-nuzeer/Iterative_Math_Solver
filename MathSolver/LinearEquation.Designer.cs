namespace MathSolver
{
    partial class LinearEquation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLinearEquation = new System.Windows.Forms.Button();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLinearEquation
            // 
            this.btnLinearEquation.BackColor = System.Drawing.Color.Blue;
            this.btnLinearEquation.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinearEquation.ForeColor = System.Drawing.Color.White;
            this.btnLinearEquation.Location = new System.Drawing.Point(155, 271);
            this.btnLinearEquation.Name = "btnLinearEquation";
            this.btnLinearEquation.Size = new System.Drawing.Size(258, 40);
            this.btnLinearEquation.TabIndex = 2;
            this.btnLinearEquation.Text = "Solve Linear Equation";
            this.btnLinearEquation.UseVisualStyleBackColor = false;
            this.btnLinearEquation.Click += new System.EventHandler(this.btnLinearEquation_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblB.ForeColor = System.Drawing.Color.Blue;
            this.lblB.Location = new System.Drawing.Point(53, 195);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(138, 22);
            this.lblB.TabIndex = 136;
            this.lblB.Text = "Co-efficient (b): ";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.Color.Blue;
            this.txtB.Location = new System.Drawing.Point(209, 195);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(306, 27);
            this.txtB.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblA.ForeColor = System.Drawing.Color.Blue;
            this.lblA.Location = new System.Drawing.Point(53, 148);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(138, 22);
            this.lblA.TabIndex = 134;
            this.lblA.Text = "Co-efficient (a): ";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.Blue;
            this.txtA.Location = new System.Drawing.Point(209, 148);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(306, 27);
            this.txtA.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(250, 337);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(63, 24);
            this.lblResult.TabIndex = 132;
            this.lblResult.Text = "Result";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 37);
            this.panel2.TabIndex = 138;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 100);
            this.panel1.TabIndex = 137;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(126, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "INTERACTIVE MATH SOLVER";
            // 
            // LinearEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLinearEquation);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblResult);
            this.MaximizeBox = false;
            this.Name = "LinearEquation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinearEquation";
            this.Load += new System.EventHandler(this.LinearEquation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLinearEquation;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}