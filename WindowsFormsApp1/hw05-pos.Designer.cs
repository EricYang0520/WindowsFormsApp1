namespace WindowsFormsApp1
{
    partial class hw05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hw05));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndrink4 = new System.Windows.Forms.Button();
            this.btndrink3 = new System.Windows.Forms.Button();
            this.btndrink2 = new System.Windows.Forms.Button();
            this.btndrink1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCredict = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndrink4);
            this.groupBox1.Controls.Add(this.btndrink3);
            this.groupBox1.Controls.Add(this.btndrink2);
            this.groupBox1.Controls.Add(this.btndrink1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單";
            // 
            // btndrink4
            // 
            this.btndrink4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndrink4.BackgroundImage")));
            this.btndrink4.Location = new System.Drawing.Point(91, 116);
            this.btndrink4.Name = "btndrink4";
            this.btndrink4.Size = new System.Drawing.Size(77, 64);
            this.btndrink4.TabIndex = 3;
            this.btndrink4.Text = "綠酒 NT2000";
            this.btndrink4.UseVisualStyleBackColor = true;
            this.btndrink4.Click += new System.EventHandler(this.btnjuice4_Click);
            // 
            // btndrink3
            // 
            this.btndrink3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndrink3.BackgroundImage")));
            this.btndrink3.Location = new System.Drawing.Point(6, 116);
            this.btndrink3.Name = "btndrink3";
            this.btndrink3.Size = new System.Drawing.Size(79, 64);
            this.btndrink3.TabIndex = 2;
            this.btndrink3.Text = "黃酒 NT1500";
            this.btndrink3.UseVisualStyleBackColor = true;
            this.btndrink3.Click += new System.EventHandler(this.btnjuice3_Click);
            // 
            // btndrink2
            // 
            this.btndrink2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndrink2.BackgroundImage")));
            this.btndrink2.Location = new System.Drawing.Point(91, 37);
            this.btndrink2.Name = "btndrink2";
            this.btndrink2.Size = new System.Drawing.Size(77, 64);
            this.btndrink2.TabIndex = 1;
            this.btndrink2.Text = "藍酒 NT1000";
            this.btndrink2.UseVisualStyleBackColor = true;
            this.btndrink2.Click += new System.EventHandler(this.btndrink2_Click);
            // 
            // btndrink1
            // 
            this.btndrink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndrink1.BackgroundImage")));
            this.btndrink1.Location = new System.Drawing.Point(6, 36);
            this.btndrink1.Name = "btndrink1";
            this.btndrink1.Size = new System.Drawing.Size(79, 65);
            this.btndrink1.TabIndex = 0;
            this.btndrink1.Text = "紅酒 NT500";
            this.btndrink1.UseVisualStyleBackColor = true;
            this.btndrink1.Click += new System.EventHandler(this.btndrink1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalAmount);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(217, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(30, 25);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(188, 27);
            this.txtTotalAmount.TabIndex = 0;
            this.txtTotalAmount.Text = "NTD 0";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtList);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(470, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "購物清單";
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(18, 25);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtList.Size = new System.Drawing.Size(206, 157);
            this.txtList.TabIndex = 7;
            this.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(125, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnCredict);
            this.groupBox4.Controls.Add(this.btnCash);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(217, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 90);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "使用信用卡打九折";
            // 
            // btnCredict
            // 
            this.btnCredict.Location = new System.Drawing.Point(119, 25);
            this.btnCredict.Name = "btnCredict";
            this.btnCredict.Size = new System.Drawing.Size(99, 40);
            this.btnCredict.TabIndex = 5;
            this.btnCredict.Text = "信用卡";
            this.btnCredict.UseVisualStyleBackColor = true;
            this.btnCredict.Click += new System.EventHandler(this.btnCredict_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(6, 25);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(99, 40);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // hw05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 299);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "hw05";
            this.Text = "hw05-pos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndrink2;
        private System.Windows.Forms.Button btndrink1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCash;
        public System.Windows.Forms.TextBox txtList;
        public System.Windows.Forms.TextBox txtTotalAmount;
        public System.Windows.Forms.Button btndrink3;
        public System.Windows.Forms.Button btndrink4;
        public System.Windows.Forms.Button btnCredict;
        public System.Windows.Forms.Button btnClear;
    }
}