namespace WindowsFormsApp1
{
    partial class hw03
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
            this.btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt04 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt03 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(58, 222);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(99, 40);
            this.btn.TabIndex = 8;
            this.btn.Text = "PMT(月付)";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "總付款";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt04
            // 
            this.txt04.Location = new System.Drawing.Point(98, 147);
            this.txt04.Name = "txt04";
            this.txt04.Size = new System.Drawing.Size(99, 22);
            this.txt04.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "頭期款:";
            // 
            // txt03
            // 
            this.txt03.Location = new System.Drawing.Point(98, 106);
            this.txt03.Name = "txt03";
            this.txt03.Size = new System.Drawing.Size(99, 22);
            this.txt03.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "利率(%):";
            // 
            // txt02
            // 
            this.txt02.Location = new System.Drawing.Point(98, 67);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(99, 22);
            this.txt02.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "期限(年):";
            // 
            // txt01
            // 
            this.txt01.Location = new System.Drawing.Point(98, 27);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(99, 22);
            this.txt01.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "貸款金額:";
            // 
            // hw03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 295);
            this.Controls.Add(this.txt04);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt03);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn);
            this.Name = "hw03";
            this.Text = "hw03-貸款";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt04;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt03;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt01;
    }
}