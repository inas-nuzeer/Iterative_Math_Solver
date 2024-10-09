namespace MathSolver
{
    partial class Determinant
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
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrow1 = new System.Windows.Forms.TextBox();
            this.lblrow1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrow3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrow4 = new System.Windows.Forms.TextBox();
            this.lblrow2 = new System.Windows.Forms.Label();
            this.txtrow2 = new System.Windows.Forms.TextBox();
            this.btnDeterminant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(198, 466);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(63, 24);
            this.lblResult.TabIndex = 119;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(198, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 19);
            this.label1.TabIndex = 118;
            this.label1.Text = "Separate the Numbers Using Only Comma(,)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtrow1
            // 
            this.txtrow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrow1.ForeColor = System.Drawing.Color.Blue;
            this.txtrow1.Location = new System.Drawing.Point(193, 145);
            this.txtrow1.Name = "txtrow1";
            this.txtrow1.Size = new System.Drawing.Size(390, 27);
            this.txtrow1.TabIndex = 115;
            this.txtrow1.TextChanged += new System.EventHandler(this.txtArray_TextChanged);
            // 
            // lblrow1
            // 
            this.lblrow1.AutoSize = true;
            this.lblrow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblrow1.ForeColor = System.Drawing.Color.Blue;
            this.lblrow1.Location = new System.Drawing.Point(121, 146);
            this.lblrow1.Name = "lblrow1";
            this.lblrow1.Size = new System.Drawing.Size(66, 22);
            this.lblrow1.TabIndex = 120;
            this.lblrow1.Text = "Row 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(121, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 122;
            this.label3.Text = "Row 3:";
            // 
            // txtrow3
            // 
            this.txtrow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrow3.ForeColor = System.Drawing.Color.Blue;
            this.txtrow3.Location = new System.Drawing.Point(193, 272);
            this.txtrow3.Name = "txtrow3";
            this.txtrow3.Size = new System.Drawing.Size(390, 27);
            this.txtrow3.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(121, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 126;
            this.label5.Text = "Row 4:";
            // 
            // txtrow4
            // 
            this.txtrow4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrow4.ForeColor = System.Drawing.Color.Blue;
            this.txtrow4.Location = new System.Drawing.Point(193, 333);
            this.txtrow4.Name = "txtrow4";
            this.txtrow4.Size = new System.Drawing.Size(390, 27);
            this.txtrow4.TabIndex = 125;
            // 
            // lblrow2
            // 
            this.lblrow2.AutoSize = true;
            this.lblrow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblrow2.ForeColor = System.Drawing.Color.Blue;
            this.lblrow2.Location = new System.Drawing.Point(121, 206);
            this.lblrow2.Name = "lblrow2";
            this.lblrow2.Size = new System.Drawing.Size(66, 22);
            this.lblrow2.TabIndex = 128;
            this.lblrow2.Text = "Row 2:";
            // 
            // txtrow2
            // 
            this.txtrow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrow2.ForeColor = System.Drawing.Color.Blue;
            this.txtrow2.Location = new System.Drawing.Point(193, 213);
            this.txtrow2.Name = "txtrow2";
            this.txtrow2.Size = new System.Drawing.Size(390, 27);
            this.txtrow2.TabIndex = 127;
            // 
            // btnDeterminant
            // 
            this.btnDeterminant.BackColor = System.Drawing.Color.Blue;
            this.btnDeterminant.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeterminant.ForeColor = System.Drawing.Color.White;
            this.btnDeterminant.Location = new System.Drawing.Point(248, 409);
            this.btnDeterminant.Name = "btnDeterminant";
            this.btnDeterminant.Size = new System.Drawing.Size(196, 40);
            this.btnDeterminant.TabIndex = 130;
            this.btnDeterminant.Text = "Find Detarminant";
            this.btnDeterminant.UseVisualStyleBackColor = false;
            this.btnDeterminant.Click += new System.EventHandler(this.btnDeterminant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(198, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 19);
            this.label2.TabIndex = 131;
            this.label2.Text = "Separate the Numbers Using Only Comma(,)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(198, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 19);
            this.label4.TabIndex = 132;
            this.label4.Text = "Separate the Numbers Using Only Comma(,)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(198, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 19);
            this.label6.TabIndex = 133;
            this.label6.Text = "Separate the Numbers Using Only Comma(,)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 28);
            this.panel2.TabIndex = 135;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 100);
            this.panel1.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(188, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "INTERACTIVE MATH SOLVER";
            // 
            // Determinant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeterminant);
            this.Controls.Add(this.lblrow2);
            this.Controls.Add(this.txtrow2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtrow4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrow3);
            this.Controls.Add(this.lblrow1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrow1);
            this.MaximizeBox = false;
            this.Name = "Determinant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Determinant";
            this.Load += new System.EventHandler(this.Determinant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrow1;
        private System.Windows.Forms.Label lblrow1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrow3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrow4;
        private System.Windows.Forms.Label lblrow2;
        private System.Windows.Forms.TextBox txtrow2;
        private System.Windows.Forms.Button btnDeterminant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}