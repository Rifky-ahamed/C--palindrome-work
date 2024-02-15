namespace palindrome_work
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnmth2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmth1 = new System.Windows.Forms.Button();
            this.txtword = new System.Windows.Forms.TextBox();
            this.btnmth1_2 = new System.Windows.Forms.Button();
            this.btnmth2_2 = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(228, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(244, 31);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "PALINDROME";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(259, 210);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(121, 34);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnmth2
            // 
            this.btnmth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmth2.Location = new System.Drawing.Point(533, 209);
            this.btnmth2.Name = "btnmth2";
            this.btnmth2.Size = new System.Drawing.Size(151, 34);
            this.btnmth2.TabIndex = 4;
            this.btnmth2.Text = "METHOD2";
            this.btnmth2.UseVisualStyleBackColor = true;
            this.btnmth2.Click += new System.EventHandler(this.btnmth2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ENTER A WORD :";
            // 
            // btnmth1
            // 
            this.btnmth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmth1.Location = new System.Drawing.Point(386, 210);
            this.btnmth1.Name = "btnmth1";
            this.btnmth1.Size = new System.Drawing.Size(141, 33);
            this.btnmth1.TabIndex = 6;
            this.btnmth1.Text = "METHOD1";
            this.btnmth1.UseVisualStyleBackColor = true;
            this.btnmth1.Click += new System.EventHandler(this.btnmth1_Click);
            // 
            // txtword
            // 
            this.txtword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtword.Location = new System.Drawing.Point(259, 117);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(391, 30);
            this.txtword.TabIndex = 7;
            // 
            // btnmth1_2
            // 
            this.btnmth1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmth1_2.Location = new System.Drawing.Point(337, 249);
            this.btnmth1_2.Name = "btnmth1_2";
            this.btnmth1_2.Size = new System.Drawing.Size(178, 44);
            this.btnmth1_2.TabIndex = 8;
            this.btnmth1_2.Text = "METHOD1(2)";
            this.btnmth1_2.UseVisualStyleBackColor = true;
            this.btnmth1_2.Click += new System.EventHandler(this.btnmth1_2_Click);
            // 
            // btnmth2_2
            // 
            this.btnmth2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmth2_2.Location = new System.Drawing.Point(521, 249);
            this.btnmth2_2.Name = "btnmth2_2";
            this.btnmth2_2.Size = new System.Drawing.Size(178, 44);
            this.btnmth2_2.TabIndex = 9;
            this.btnmth2_2.Text = "METHOD2(2)";
            this.btnmth2_2.UseVisualStyleBackColor = true;
            this.btnmth2_2.Click += new System.EventHandler(this.btnmth2_2_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(12, 249);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 44);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(783, 300);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnmth2_2);
            this.Controls.Add(this.btnmth1_2);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.btnmth1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmth2);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnmth2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmth1;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Button btnmth1_2;
        private System.Windows.Forms.Button btnmth2_2;
        private System.Windows.Forms.Button btnexit;
    }
}

