namespace MathSolver
{
    partial class LCM
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
            this.btnLCM = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.lblarray = new System.Windows.Forms.Label();
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
            this.lblResult.Location = new System.Drawing.Point(151, 337);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(63, 24);
            this.lblResult.TabIndex = 114;
            this.lblResult.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(45, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "Separate the Numbers Using Only Comma(,)";
            // 
            // btnLCM
            // 
            this.btnLCM.BackColor = System.Drawing.Color.Blue;
            this.btnLCM.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLCM.ForeColor = System.Drawing.Color.White;
            this.btnLCM.Location = new System.Drawing.Point(214, 273);
            this.btnLCM.Name = "btnLCM";
            this.btnLCM.Size = new System.Drawing.Size(141, 40);
            this.btnLCM.TabIndex = 1;
            this.btnLCM.Text = "Find LCM";
            this.btnLCM.UseVisualStyleBackColor = false;
            this.btnLCM.Click += new System.EventHandler(this.btnLCM_Click);
            // 
            // txtArray
            // 
            this.txtArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArray.ForeColor = System.Drawing.Color.Blue;
            this.txtArray.Location = new System.Drawing.Point(42, 199);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(484, 27);
            this.txtArray.TabIndex = 0;
            // 
            // lblarray
            // 
            this.lblarray.AutoSize = true;
            this.lblarray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblarray.ForeColor = System.Drawing.Color.Blue;
            this.lblarray.Location = new System.Drawing.Point(45, 153);
            this.lblarray.Name = "lblarray";
            this.lblarray.Size = new System.Drawing.Size(201, 22);
            this.lblarray.TabIndex = 111;
            this.lblarray.Text = "Enter Multiple Numbers:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 37);
            this.panel2.TabIndex = 137;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 100);
            this.panel1.TabIndex = 136;
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
            // LCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLCM);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.lblarray);
            this.MaximizeBox = false;
            this.Name = "LCM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLCM;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label lblarray;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}