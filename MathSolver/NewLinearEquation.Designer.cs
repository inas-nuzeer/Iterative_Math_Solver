namespace MathSolver
{
    partial class NewLinearEquation
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
            this.cmbUnknown = new System.Windows.Forms.ComboBox();
            this.btnLinearEquation = new System.Windows.Forms.Button();
            this.lblB = new System.Windows.Forms.Label();
            this.txtCE2B = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtCE2A = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCE3A = new System.Windows.Forms.Label();
            this.txtCE3A = new System.Windows.Forms.TextBox();
            this.lblE3C = new System.Windows.Forms.Label();
            this.txtConst3 = new System.Windows.Forms.TextBox();
            this.lblCE3B = new System.Windows.Forms.Label();
            this.txtCE3B = new System.Windows.Forms.TextBox();
            this.lblCE3C = new System.Windows.Forms.Label();
            this.txtCE3C = new System.Windows.Forms.TextBox();
            this.EqBox3 = new System.Windows.Forms.GroupBox();
            this.EqBox1 = new System.Windows.Forms.GroupBox();
            this.lblCE1C = new System.Windows.Forms.Label();
            this.lblCE1B = new System.Windows.Forms.Label();
            this.txtCE1C = new System.Windows.Forms.TextBox();
            this.txtCE1B = new System.Windows.Forms.TextBox();
            this.lblE1C = new System.Windows.Forms.Label();
            this.lblCE1A = new System.Windows.Forms.Label();
            this.txtConst1 = new System.Windows.Forms.TextBox();
            this.txtCE1A = new System.Windows.Forms.TextBox();
            this.EqBox2 = new System.Windows.Forms.GroupBox();
            this.lblCE2C = new System.Windows.Forms.Label();
            this.txtCE2C = new System.Windows.Forms.TextBox();
            this.lblE2C = new System.Windows.Forms.Label();
            this.txtConst2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.EqShowBox = new System.Windows.Forms.GroupBox();
            this.lblEqShow3 = new System.Windows.Forms.Label();
            this.lblEqShow2 = new System.Windows.Forms.Label();
            this.lblEqShow1 = new System.Windows.Forms.Label();
            this.EqBox3.SuspendLayout();
            this.EqBox1.SuspendLayout();
            this.EqBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EqShowBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUnknown
            // 
            this.cmbUnknown.FormattingEnabled = true;
            this.cmbUnknown.Items.AddRange(new object[] {
            "2 Unknowns",
            "3 Unknowns"});
            this.cmbUnknown.Location = new System.Drawing.Point(56, 115);
            this.cmbUnknown.MaxDropDownItems = 3;
            this.cmbUnknown.Name = "cmbUnknown";
            this.cmbUnknown.Size = new System.Drawing.Size(283, 24);
            this.cmbUnknown.TabIndex = 0;
            this.cmbUnknown.Text = "Select Number of Unknowns ";
            this.cmbUnknown.SelectedIndexChanged += new System.EventHandler(this.cmbUnknown_SelectedIndexChanged);
            // 
            // btnLinearEquation
            // 
            this.btnLinearEquation.BackColor = System.Drawing.Color.Blue;
            this.btnLinearEquation.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinearEquation.ForeColor = System.Drawing.Color.White;
            this.btnLinearEquation.Location = new System.Drawing.Point(324, 640);
            this.btnLinearEquation.Name = "btnLinearEquation";
            this.btnLinearEquation.Size = new System.Drawing.Size(258, 40);
            this.btnLinearEquation.TabIndex = 3;
            this.btnLinearEquation.Text = "Solve Linear Equation";
            this.btnLinearEquation.UseVisualStyleBackColor = false;
            this.btnLinearEquation.Click += new System.EventHandler(this.btnLinearEquation_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblB.ForeColor = System.Drawing.Color.Blue;
            this.lblB.Location = new System.Drawing.Point(14, 82);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(138, 22);
            this.lblB.TabIndex = 142;
            this.lblB.Text = "Co-efficient (b): ";
            // 
            // txtCE2B
            // 
            this.txtCE2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE2B.ForeColor = System.Drawing.Color.Blue;
            this.txtCE2B.Location = new System.Drawing.Point(170, 82);
            this.txtCE2B.Name = "txtCE2B";
            this.txtCE2B.Size = new System.Drawing.Size(152, 27);
            this.txtCE2B.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblA.ForeColor = System.Drawing.Color.Blue;
            this.lblA.Location = new System.Drawing.Point(14, 35);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(138, 22);
            this.lblA.TabIndex = 140;
            this.lblA.Text = "Co-efficient (a): ";
            // 
            // txtCE2A
            // 
            this.txtCE2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE2A.ForeColor = System.Drawing.Color.Blue;
            this.txtCE2A.Location = new System.Drawing.Point(170, 35);
            this.txtCE2A.Name = "txtCE2A";
            this.txtCE2A.Size = new System.Drawing.Size(152, 27);
            this.txtCE2A.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(345, 696);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(63, 20);
            this.lblResult.TabIndex = 138;
            this.lblResult.Text = "Result";
            // 
            // lblCE3A
            // 
            this.lblCE3A.AutoSize = true;
            this.lblCE3A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCE3A.ForeColor = System.Drawing.Color.Blue;
            this.lblCE3A.Location = new System.Drawing.Point(21, 34);
            this.lblCE3A.Name = "lblCE3A";
            this.lblCE3A.Size = new System.Drawing.Size(138, 22);
            this.lblCE3A.TabIndex = 146;
            this.lblCE3A.Text = "Co-efficient (a): ";
            // 
            // txtCE3A
            // 
            this.txtCE3A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE3A.ForeColor = System.Drawing.Color.Blue;
            this.txtCE3A.Location = new System.Drawing.Point(177, 34);
            this.txtCE3A.Name = "txtCE3A";
            this.txtCE3A.Size = new System.Drawing.Size(152, 27);
            this.txtCE3A.TabIndex = 1;
            // 
            // lblE3C
            // 
            this.lblE3C.AutoSize = true;
            this.lblE3C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblE3C.ForeColor = System.Drawing.Color.Blue;
            this.lblE3C.Location = new System.Drawing.Point(71, 183);
            this.lblE3C.Name = "lblE3C";
            this.lblE3C.Size = new System.Drawing.Size(87, 22);
            this.lblE3C.TabIndex = 146;
            this.lblE3C.Text = "Constant:";
            this.lblE3C.Click += new System.EventHandler(this.lblE3C_Click);
            // 
            // txtConst3
            // 
            this.txtConst3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConst3.ForeColor = System.Drawing.Color.Blue;
            this.txtConst3.Location = new System.Drawing.Point(178, 182);
            this.txtConst3.Name = "txtConst3";
            this.txtConst3.Size = new System.Drawing.Size(152, 27);
            this.txtConst3.TabIndex = 4;
            // 
            // lblCE3B
            // 
            this.lblCE3B.AutoSize = true;
            this.lblCE3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCE3B.ForeColor = System.Drawing.Color.Blue;
            this.lblCE3B.Location = new System.Drawing.Point(22, 82);
            this.lblCE3B.Name = "lblCE3B";
            this.lblCE3B.Size = new System.Drawing.Size(138, 22);
            this.lblCE3B.TabIndex = 142;
            this.lblCE3B.Text = "Co-efficient (b): ";
            // 
            // txtCE3B
            // 
            this.txtCE3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE3B.ForeColor = System.Drawing.Color.Blue;
            this.txtCE3B.Location = new System.Drawing.Point(178, 82);
            this.txtCE3B.Name = "txtCE3B";
            this.txtCE3B.Size = new System.Drawing.Size(152, 27);
            this.txtCE3B.TabIndex = 2;
            // 
            // lblCE3C
            // 
            this.lblCE3C.AutoSize = true;
            this.lblCE3C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCE3C.ForeColor = System.Drawing.Color.Blue;
            this.lblCE3C.Location = new System.Drawing.Point(23, 131);
            this.lblCE3C.Name = "lblCE3C";
            this.lblCE3C.Size = new System.Drawing.Size(137, 22);
            this.lblCE3C.TabIndex = 158;
            this.lblCE3C.Text = "Co-efficient (c): ";
            // 
            // txtCE3C
            // 
            this.txtCE3C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE3C.ForeColor = System.Drawing.Color.Blue;
            this.txtCE3C.Location = new System.Drawing.Point(179, 131);
            this.txtCE3C.Name = "txtCE3C";
            this.txtCE3C.Size = new System.Drawing.Size(152, 27);
            this.txtCE3C.TabIndex = 3;
            // 
            // EqBox3
            // 
            this.EqBox3.Controls.Add(this.lblCE3C);
            this.EqBox3.Controls.Add(this.txtConst3);
            this.EqBox3.Controls.Add(this.txtCE3C);
            this.EqBox3.Controls.Add(this.txtCE3B);
            this.EqBox3.Controls.Add(this.lblCE3A);
            this.EqBox3.Controls.Add(this.lblCE3B);
            this.EqBox3.Controls.Add(this.txtCE3A);
            this.EqBox3.Controls.Add(this.lblE3C);
            this.EqBox3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqBox3.Location = new System.Drawing.Point(270, 404);
            this.EqBox3.Name = "EqBox3";
            this.EqBox3.Size = new System.Drawing.Size(347, 230);
            this.EqBox3.TabIndex = 2;
            this.EqBox3.TabStop = false;
            this.EqBox3.Text = "Equation 3";
            // 
            // EqBox1
            // 
            this.EqBox1.Controls.Add(this.lblCE1C);
            this.EqBox1.Controls.Add(this.lblCE1B);
            this.EqBox1.Controls.Add(this.txtCE1C);
            this.EqBox1.Controls.Add(this.txtCE1B);
            this.EqBox1.Controls.Add(this.lblE1C);
            this.EqBox1.Controls.Add(this.lblCE1A);
            this.EqBox1.Controls.Add(this.txtConst1);
            this.EqBox1.Controls.Add(this.txtCE1A);
            this.EqBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqBox1.Location = new System.Drawing.Point(56, 157);
            this.EqBox1.Name = "EqBox1";
            this.EqBox1.Size = new System.Drawing.Size(353, 228);
            this.EqBox1.TabIndex = 0;
            this.EqBox1.TabStop = false;
            this.EqBox1.Text = "Equation 1";
            this.EqBox1.Enter += new System.EventHandler(this.EqBox1_Enter);
            // 
            // lblCE1C
            // 
            this.lblCE1C.AutoSize = true;
            this.lblCE1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCE1C.ForeColor = System.Drawing.Color.Blue;
            this.lblCE1C.Location = new System.Drawing.Point(21, 132);
            this.lblCE1C.Name = "lblCE1C";
            this.lblCE1C.Size = new System.Drawing.Size(137, 22);
            this.lblCE1C.TabIndex = 154;
            this.lblCE1C.Text = "Co-efficient (c): ";
            // 
            // lblCE1B
            // 
            this.lblCE1B.AutoSize = true;
            this.lblCE1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCE1B.ForeColor = System.Drawing.Color.Blue;
            this.lblCE1B.Location = new System.Drawing.Point(21, 83);
            this.lblCE1B.Name = "lblCE1B";
            this.lblCE1B.Size = new System.Drawing.Size(138, 22);
            this.lblCE1B.TabIndex = 142;
            this.lblCE1B.Text = "Co-efficient (b): ";
            this.lblCE1B.Click += new System.EventHandler(this.lblCE1B_Click);
            // 
            // txtCE1C
            // 
            this.txtCE1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE1C.ForeColor = System.Drawing.Color.Blue;
            this.txtCE1C.Location = new System.Drawing.Point(177, 132);
            this.txtCE1C.Name = "txtCE1C";
            this.txtCE1C.Size = new System.Drawing.Size(152, 27);
            this.txtCE1C.TabIndex = 2;
            // 
            // txtCE1B
            // 
            this.txtCE1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE1B.ForeColor = System.Drawing.Color.Blue;
            this.txtCE1B.Location = new System.Drawing.Point(177, 83);
            this.txtCE1B.Name = "txtCE1B";
            this.txtCE1B.Size = new System.Drawing.Size(152, 27);
            this.txtCE1B.TabIndex = 1;
            this.txtCE1B.TextChanged += new System.EventHandler(this.txtCE1B_TextChanged);
            // 
            // lblE1C
            // 
            this.lblE1C.AutoSize = true;
            this.lblE1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblE1C.ForeColor = System.Drawing.Color.Blue;
            this.lblE1C.Location = new System.Drawing.Point(67, 179);
            this.lblE1C.Name = "lblE1C";
            this.lblE1C.Size = new System.Drawing.Size(87, 22);
            this.lblE1C.TabIndex = 152;
            this.lblE1C.Text = "Constant:";
            this.lblE1C.Click += new System.EventHandler(this.lblE1C_Click);
            // 
            // lblCE1A
            // 
            this.lblCE1A.AutoSize = true;
            this.lblCE1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCE1A.ForeColor = System.Drawing.Color.Blue;
            this.lblCE1A.Location = new System.Drawing.Point(21, 37);
            this.lblCE1A.Name = "lblCE1A";
            this.lblCE1A.Size = new System.Drawing.Size(138, 22);
            this.lblCE1A.TabIndex = 140;
            this.lblCE1A.Text = "Co-efficient (a): ";
            // 
            // txtConst1
            // 
            this.txtConst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConst1.ForeColor = System.Drawing.Color.Blue;
            this.txtConst1.Location = new System.Drawing.Point(177, 178);
            this.txtConst1.Name = "txtConst1";
            this.txtConst1.Size = new System.Drawing.Size(152, 27);
            this.txtConst1.TabIndex = 3;
            this.txtConst1.TextChanged += new System.EventHandler(this.txtConst1_TextChanged);
            // 
            // txtCE1A
            // 
            this.txtCE1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE1A.ForeColor = System.Drawing.Color.Blue;
            this.txtCE1A.Location = new System.Drawing.Point(177, 37);
            this.txtCE1A.Name = "txtCE1A";
            this.txtCE1A.Size = new System.Drawing.Size(152, 27);
            this.txtCE1A.TabIndex = 0;
            // 
            // EqBox2
            // 
            this.EqBox2.Controls.Add(this.lblCE2C);
            this.EqBox2.Controls.Add(this.txtCE2C);
            this.EqBox2.Controls.Add(this.lblE2C);
            this.EqBox2.Controls.Add(this.txtConst2);
            this.EqBox2.Controls.Add(this.lblA);
            this.EqBox2.Controls.Add(this.txtCE2A);
            this.EqBox2.Controls.Add(this.lblB);
            this.EqBox2.Controls.Add(this.txtCE2B);
            this.EqBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqBox2.Location = new System.Drawing.Point(474, 157);
            this.EqBox2.Name = "EqBox2";
            this.EqBox2.Size = new System.Drawing.Size(359, 228);
            this.EqBox2.TabIndex = 1;
            this.EqBox2.TabStop = false;
            this.EqBox2.Text = "Equation 2";
            // 
            // lblCE2C
            // 
            this.lblCE2C.AutoSize = true;
            this.lblCE2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCE2C.ForeColor = System.Drawing.Color.Blue;
            this.lblCE2C.Location = new System.Drawing.Point(14, 131);
            this.lblCE2C.Name = "lblCE2C";
            this.lblCE2C.Size = new System.Drawing.Size(137, 22);
            this.lblCE2C.TabIndex = 156;
            this.lblCE2C.Text = "Co-efficient (c): ";
            // 
            // txtCE2C
            // 
            this.txtCE2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE2C.ForeColor = System.Drawing.Color.Blue;
            this.txtCE2C.Location = new System.Drawing.Point(170, 131);
            this.txtCE2C.Name = "txtCE2C";
            this.txtCE2C.Size = new System.Drawing.Size(152, 27);
            this.txtCE2C.TabIndex = 2;
            // 
            // lblE2C
            // 
            this.lblE2C.AutoSize = true;
            this.lblE2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblE2C.ForeColor = System.Drawing.Color.Blue;
            this.lblE2C.Location = new System.Drawing.Point(59, 183);
            this.lblE2C.Name = "lblE2C";
            this.lblE2C.Size = new System.Drawing.Size(87, 22);
            this.lblE2C.TabIndex = 142;
            this.lblE2C.Text = "Constant:";
            // 
            // txtConst2
            // 
            this.txtConst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConst2.ForeColor = System.Drawing.Color.Blue;
            this.txtConst2.Location = new System.Drawing.Point(170, 182);
            this.txtConst2.Name = "txtConst2";
            this.txtConst2.Size = new System.Drawing.Size(152, 27);
            this.txtConst2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 719);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 37);
            this.panel2.TabIndex = 156;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 92);
            this.panel1.TabIndex = 155;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(286, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "INTERACTIVE MATH SOLVER";
            // 
            // EqShowBox
            // 
            this.EqShowBox.Controls.Add(this.lblEqShow3);
            this.EqShowBox.Controls.Add(this.lblEqShow2);
            this.EqShowBox.Controls.Add(this.lblEqShow1);
            this.EqShowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqShowBox.Location = new System.Drawing.Point(49, 387);
            this.EqShowBox.Name = "EqShowBox";
            this.EqShowBox.Size = new System.Drawing.Size(216, 128);
            this.EqShowBox.TabIndex = 157;
            this.EqShowBox.TabStop = false;
            this.EqShowBox.Text = "Equations";
            // 
            // lblEqShow3
            // 
            this.lblEqShow3.AutoSize = true;
            this.lblEqShow3.Location = new System.Drawing.Point(14, 83);
            this.lblEqShow3.Name = "lblEqShow3";
            this.lblEqShow3.Size = new System.Drawing.Size(34, 16);
            this.lblEqShow3.TabIndex = 2;
            this.lblEqShow3.Text = "Eq3";
            // 
            // lblEqShow2
            // 
            this.lblEqShow2.AutoSize = true;
            this.lblEqShow2.Location = new System.Drawing.Point(14, 58);
            this.lblEqShow2.Name = "lblEqShow2";
            this.lblEqShow2.Size = new System.Drawing.Size(34, 16);
            this.lblEqShow2.TabIndex = 1;
            this.lblEqShow2.Text = "Eq2";
            // 
            // lblEqShow1
            // 
            this.lblEqShow1.AutoSize = true;
            this.lblEqShow1.Location = new System.Drawing.Point(14, 33);
            this.lblEqShow1.Name = "lblEqShow1";
            this.lblEqShow1.Size = new System.Drawing.Size(34, 16);
            this.lblEqShow1.TabIndex = 0;
            this.lblEqShow1.Text = "Eq1";
            this.lblEqShow1.Click += new System.EventHandler(this.lblEqShow1_Click);
            // 
            // NewLinearEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 756);
            this.Controls.Add(this.EqShowBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EqBox2);
            this.Controls.Add(this.EqBox1);
            this.Controls.Add(this.EqBox3);
            this.Controls.Add(this.btnLinearEquation);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbUnknown);
            this.MaximizeBox = false;
            this.Name = "NewLinearEquation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linear Equation";
            this.Load += new System.EventHandler(this.NewLinearEquation_Load);
            this.EqBox3.ResumeLayout(false);
            this.EqBox3.PerformLayout();
            this.EqBox1.ResumeLayout(false);
            this.EqBox1.PerformLayout();
            this.EqBox2.ResumeLayout(false);
            this.EqBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EqShowBox.ResumeLayout(false);
            this.EqShowBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnknown;
        private System.Windows.Forms.Button btnLinearEquation;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtCE2B;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtCE2A;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCE3A;
        private System.Windows.Forms.TextBox txtCE3A;
        private System.Windows.Forms.Label lblE3C;
        private System.Windows.Forms.TextBox txtConst3;
        private System.Windows.Forms.Label lblCE3B;
        private System.Windows.Forms.TextBox txtCE3B;
        private System.Windows.Forms.Label lblCE3C;
        private System.Windows.Forms.TextBox txtCE3C;
        private System.Windows.Forms.GroupBox EqBox3;
        private System.Windows.Forms.GroupBox EqBox1;
        private System.Windows.Forms.Label lblCE1C;
        private System.Windows.Forms.Label lblCE1B;
        private System.Windows.Forms.TextBox txtCE1C;
        private System.Windows.Forms.TextBox txtCE1B;
        private System.Windows.Forms.Label lblE1C;
        private System.Windows.Forms.Label lblCE1A;
        private System.Windows.Forms.TextBox txtConst1;
        private System.Windows.Forms.TextBox txtCE1A;
        private System.Windows.Forms.GroupBox EqBox2;
        private System.Windows.Forms.Label lblCE2C;
        private System.Windows.Forms.TextBox txtCE2C;
        private System.Windows.Forms.Label lblE2C;
        private System.Windows.Forms.TextBox txtConst2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox EqShowBox;
        private System.Windows.Forms.Label lblEqShow1;
        private System.Windows.Forms.Label lblEqShow3;
        private System.Windows.Forms.Label lblEqShow2;
    }
}