namespace WindowsFormsApp1
{
    partial class hw01
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hw01));
            this.hw02 = new System.Windows.Forms.Button();
            this.hw03 = new System.Windows.Forms.Button();
            this.hw04 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hw06 = new System.Windows.Forms.Button();
            this.hw07 = new System.Windows.Forms.Button();
            this.hw08 = new System.Windows.Forms.Button();
            this.hw09 = new System.Windows.Forms.Button();
            this.hw10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hw02
            // 
            this.hw02.Location = new System.Drawing.Point(30, 45);
            this.hw02.Name = "hw02";
            this.hw02.Size = new System.Drawing.Size(156, 43);
            this.hw02.TabIndex = 0;
            this.hw02.Text = "hw02-Hello";
            this.hw02.UseVisualStyleBackColor = true;
            this.hw02.Click += new System.EventHandler(this.homework02_Click);
            // 
            // hw03
            // 
            this.hw03.Location = new System.Drawing.Point(30, 110);
            this.hw03.Name = "hw03";
            this.hw03.Size = new System.Drawing.Size(156, 47);
            this.hw03.TabIndex = 1;
            this.hw03.Text = "hw03-貸款";
            this.hw03.UseVisualStyleBackColor = true;
            this.hw03.Click += new System.EventHandler(this.button2_Click);
            // 
            // hw04
            // 
            this.hw04.Location = new System.Drawing.Point(30, 177);
            this.hw04.Name = "hw04";
            this.hw04.Size = new System.Drawing.Size(156, 49);
            this.hw04.TabIndex = 2;
            this.hw04.Text = "hw04-計算機";
            this.hw04.UseVisualStyleBackColor = true;
            this.hw04.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "hw05-pos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hw06
            // 
            this.hw06.Location = new System.Drawing.Point(30, 305);
            this.hw06.Name = "hw06";
            this.hw06.Size = new System.Drawing.Size(156, 42);
            this.hw06.TabIndex = 4;
            this.hw06.Text = "hw06-學生成績";
            this.hw06.UseVisualStyleBackColor = true;
            this.hw06.Click += new System.EventHandler(this.button4_Click);
            // 
            // hw07
            // 
            this.hw07.Location = new System.Drawing.Point(30, 367);
            this.hw07.Name = "hw07";
            this.hw07.Size = new System.Drawing.Size(156, 47);
            this.hw07.TabIndex = 6;
            this.hw07.Text = "hw07-螢幕保護程式";
            this.hw07.UseVisualStyleBackColor = true;
            this.hw07.Click += new System.EventHandler(this.button6_Click);
            // 
            // hw08
            // 
            this.hw08.Location = new System.Drawing.Point(30, 433);
            this.hw08.Name = "hw08";
            this.hw08.Size = new System.Drawing.Size(156, 43);
            this.hw08.TabIndex = 7;
            this.hw08.Text = "hw08-OX遊戲";
            this.hw08.UseVisualStyleBackColor = true;
            this.hw08.Click += new System.EventHandler(this.button7_Click);
            // 
            // hw09
            // 
            this.hw09.Location = new System.Drawing.Point(30, 501);
            this.hw09.Name = "hw09";
            this.hw09.Size = new System.Drawing.Size(156, 47);
            this.hw09.TabIndex = 8;
            this.hw09.Text = "hw09-記事本";
            this.hw09.UseVisualStyleBackColor = true;
            this.hw09.Click += new System.EventHandler(this.button8_Click);
            // 
            // hw10
            // 
            this.hw10.Location = new System.Drawing.Point(30, 569);
            this.hw10.Name = "hw10";
            this.hw10.Size = new System.Drawing.Size(156, 45);
            this.hw10.TabIndex = 9;
            this.hw10.Text = "hw10-小畫家";
            this.hw10.UseVisualStyleBackColor = true;
            this.hw10.Click += new System.EventHandler(this.button9_Click);
            // 
            // hw01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 626);
            this.Controls.Add(this.hw10);
            this.Controls.Add(this.hw09);
            this.Controls.Add(this.hw08);
            this.Controls.Add(this.hw07);
            this.Controls.Add(this.hw06);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hw04);
            this.Controls.Add(this.hw03);
            this.Controls.Add(this.hw02);
            this.Name = "hw01";
            this.Text = "hw01-主介面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hw02;
        private System.Windows.Forms.Button hw03;
        private System.Windows.Forms.Button hw04;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button hw06;
        private System.Windows.Forms.Button hw07;
        private System.Windows.Forms.Button hw08;
        private System.Windows.Forms.Button hw09;
        private System.Windows.Forms.Button hw10;
    }
}

