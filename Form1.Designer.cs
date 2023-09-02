namespace WindowsFormsApp3
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
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblDisplay1 = new System.Windows.Forms.Label();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInput_a = new System.Windows.Forms.TextBox();
            this.txtInput_c = new System.Windows.Forms.TextBox();
            this.txtInput_b = new System.Windows.Forms.TextBox();
            this.txtInput_d = new System.Windows.Forms.TextBox();
            this.txtInput_m = new System.Windows.Forms.TextBox();
            this.txtInput_n = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(67, 317);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluate.TabIndex = 0;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(245, 317);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblDisplay1
            // 
            this.lblDisplay1.AutoSize = true;
            this.lblDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay1.Location = new System.Drawing.Point(199, 47);
            this.lblDisplay1.Name = "lblDisplay1";
            this.lblDisplay1.Size = new System.Drawing.Size(106, 25);
            this.lblDisplay1.TabIndex = 3;
            this.lblDisplay1.Text = "ax+by=m";
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.AutoSize = true;
            this.lblDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay2.Location = new System.Drawing.Point(199, 98);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(100, 25);
            this.lblDisplay2.TabIndex = 4;
            this.lblDisplay2.Text = "cx+dy=n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "a=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "c=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "b=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "d=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "m=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "n=";
            // 
            // txtInput_a
            // 
            this.txtInput_a.Location = new System.Drawing.Point(56, 194);
            this.txtInput_a.Name = "txtInput_a";
            this.txtInput_a.Size = new System.Drawing.Size(100, 20);
            this.txtInput_a.TabIndex = 11;
            // 
            // txtInput_c
            // 
            this.txtInput_c.Location = new System.Drawing.Point(55, 248);
            this.txtInput_c.Name = "txtInput_c";
            this.txtInput_c.Size = new System.Drawing.Size(100, 20);
            this.txtInput_c.TabIndex = 12;
            // 
            // txtInput_b
            // 
            this.txtInput_b.Location = new System.Drawing.Point(232, 194);
            this.txtInput_b.Name = "txtInput_b";
            this.txtInput_b.Size = new System.Drawing.Size(100, 20);
            this.txtInput_b.TabIndex = 13;
            // 
            // txtInput_d
            // 
            this.txtInput_d.Location = new System.Drawing.Point(232, 245);
            this.txtInput_d.Name = "txtInput_d";
            this.txtInput_d.Size = new System.Drawing.Size(100, 20);
            this.txtInput_d.TabIndex = 14;
            // 
            // txtInput_m
            // 
            this.txtInput_m.Location = new System.Drawing.Point(407, 193);
            this.txtInput_m.Name = "txtInput_m";
            this.txtInput_m.Size = new System.Drawing.Size(100, 20);
            this.txtInput_m.TabIndex = 15;
            // 
            // txtInput_n
            // 
            this.txtInput_n.Location = new System.Drawing.Point(407, 243);
            this.txtInput_n.Name = "txtInput_n";
            this.txtInput_n.Size = new System.Drawing.Size(100, 20);
            this.txtInput_n.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(407, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 371);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtInput_n);
            this.Controls.Add(this.txtInput_m);
            this.Controls.Add(this.txtInput_d);
            this.Controls.Add(this.txtInput_b);
            this.Controls.Add(this.txtInput_c);
            this.Controls.Add(this.txtInput_a);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.lblDisplay1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEvaluate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblDisplay1;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInput_a;
        private System.Windows.Forms.TextBox txtInput_c;
        private System.Windows.Forms.TextBox txtInput_b;
        private System.Windows.Forms.TextBox txtInput_d;
        private System.Windows.Forms.TextBox txtInput_m;
        private System.Windows.Forms.TextBox txtInput_n;
        private System.Windows.Forms.Button btnExit;
    }
}

