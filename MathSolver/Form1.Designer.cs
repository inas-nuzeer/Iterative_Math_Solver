namespace MathSolver
{
    partial class Form1
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
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnQE = new System.Windows.Forms.Button();
            this.btnDeterminant = new System.Windows.Forms.Button();
            this.btnLEU = new System.Windows.Forms.Button();
            this.btnLE = new System.Windows.Forms.Button();
            this.btnLCM = new System.Windows.Forms.Button();
            this.btnGCM = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Blue;
            this.lblTime.Location = new System.Drawing.Point(55, 30);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(108, 22);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Date & Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(80, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "INTERACTIVE MATH SOLVER";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnQE);
            this.panel3.Controls.Add(this.btnDeterminant);
            this.panel3.Controls.Add(this.btnLEU);
            this.panel3.Controls.Add(this.btnLE);
            this.panel3.Controls.Add(this.btnLCM);
            this.panel3.Controls.Add(this.btnGCM);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 422);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnQE
            // 
            this.btnQE.BackColor = System.Drawing.Color.Blue;
            this.btnQE.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQE.ForeColor = System.Drawing.Color.White;
            this.btnQE.Location = new System.Drawing.Point(76, 207);
            this.btnQE.Name = "btnQE";
            this.btnQE.Size = new System.Drawing.Size(225, 40);
            this.btnQE.TabIndex = 3;
            this.btnQE.Text = "Quadratic Equation";
            this.btnQE.UseVisualStyleBackColor = false;
            this.btnQE.Click += new System.EventHandler(this.btnQE_Click);
            // 
            // btnDeterminant
            // 
            this.btnDeterminant.BackColor = System.Drawing.Color.Blue;
            this.btnDeterminant.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeterminant.ForeColor = System.Drawing.Color.White;
            this.btnDeterminant.Location = new System.Drawing.Point(347, 118);
            this.btnDeterminant.Name = "btnDeterminant";
            this.btnDeterminant.Size = new System.Drawing.Size(169, 40);
            this.btnDeterminant.TabIndex = 2;
            this.btnDeterminant.Text = "Determinant";
            this.btnDeterminant.UseVisualStyleBackColor = false;
            this.btnDeterminant.Click += new System.EventHandler(this.btnDeterminant_Click);
            // 
            // btnLEU
            // 
            this.btnLEU.BackColor = System.Drawing.Color.Blue;
            this.btnLEU.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLEU.ForeColor = System.Drawing.Color.White;
            this.btnLEU.Location = new System.Drawing.Point(76, 296);
            this.btnLEU.Name = "btnLEU";
            this.btnLEU.Size = new System.Drawing.Size(440, 40);
            this.btnLEU.TabIndex = 5;
            this.btnLEU.Text = "Linear Equation of 2 or 3 Unknowns";
            this.btnLEU.UseVisualStyleBackColor = false;
            this.btnLEU.Click += new System.EventHandler(this.btnLEU_Click);
            // 
            // btnLE
            // 
            this.btnLE.BackColor = System.Drawing.Color.Blue;
            this.btnLE.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLE.ForeColor = System.Drawing.Color.White;
            this.btnLE.Location = new System.Drawing.Point(307, 207);
            this.btnLE.Name = "btnLE";
            this.btnLE.Size = new System.Drawing.Size(209, 40);
            this.btnLE.TabIndex = 4;
            this.btnLE.Text = "Linear Equation";
            this.btnLE.UseVisualStyleBackColor = false;
            this.btnLE.Click += new System.EventHandler(this.btnLE_Click);
            // 
            // btnLCM
            // 
            this.btnLCM.BackColor = System.Drawing.Color.Blue;
            this.btnLCM.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLCM.ForeColor = System.Drawing.Color.White;
            this.btnLCM.Location = new System.Drawing.Point(220, 118);
            this.btnLCM.Name = "btnLCM";
            this.btnLCM.Size = new System.Drawing.Size(109, 40);
            this.btnLCM.TabIndex = 1;
            this.btnLCM.Text = "LCM";
            this.btnLCM.UseVisualStyleBackColor = false;
            this.btnLCM.Click += new System.EventHandler(this.btnLCM_Click);
            // 
            // btnGCM
            // 
            this.btnGCM.BackColor = System.Drawing.Color.Blue;
            this.btnGCM.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGCM.ForeColor = System.Drawing.Color.White;
            this.btnGCM.Location = new System.Drawing.Point(76, 118);
            this.btnGCM.Name = "btnGCM";
            this.btnGCM.Size = new System.Drawing.Size(121, 40);
            this.btnGCM.TabIndex = 0;
            this.btnGCM.Text = "GCD";
            this.btnGCM.UseVisualStyleBackColor = false;
            this.btnGCM.Click += new System.EventHandler(this.btnGCM_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 37);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 100);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 559);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGCM;
        private System.Windows.Forms.Button btnQE;
        private System.Windows.Forms.Button btnDeterminant;
        private System.Windows.Forms.Button btnLEU;
        private System.Windows.Forms.Button btnLE;
        private System.Windows.Forms.Button btnLCM;
    }
}