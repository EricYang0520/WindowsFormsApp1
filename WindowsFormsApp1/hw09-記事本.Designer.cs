﻿namespace WindowsFormsApp1
{
    partial class hw09
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hw09));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.結束XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全選AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋取代ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.內容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.關於AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.說明HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripMenuItem,
            this.開啟OToolStripMenuItem,
            this.儲存SToolStripMenuItem,
            this.另存新檔AToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.結束XToolStripMenuItem});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.檔案FToolStripMenuItem.Text = "檔案(&F)";
            // 
            // 新增NToolStripMenuItem
            // 
            this.新增NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripMenuItem.Image")));
            this.新增NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripMenuItem.Name = "新增NToolStripMenuItem";
            this.新增NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新增NToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.新增NToolStripMenuItem.Text = "新增(&N)";
            this.新增NToolStripMenuItem.Click += new System.EventHandler(this.新增NToolStripMenuItem_Click);
            // 
            // 開啟OToolStripMenuItem
            // 
            this.開啟OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripMenuItem.Image")));
            this.開啟OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripMenuItem.Name = "開啟OToolStripMenuItem";
            this.開啟OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開啟OToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.開啟OToolStripMenuItem.Text = "開啟(&O)";
            this.開啟OToolStripMenuItem.Click += new System.EventHandler(this.開啟OToolStripMenuItem_Click);
            // 
            // 儲存SToolStripMenuItem
            // 
            this.儲存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripMenuItem.Image")));
            this.儲存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripMenuItem.Name = "儲存SToolStripMenuItem";
            this.儲存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.儲存SToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.儲存SToolStripMenuItem.Text = "儲存(&S)";
            // 
            // 另存新檔AToolStripMenuItem
            // 
            this.另存新檔AToolStripMenuItem.Name = "另存新檔AToolStripMenuItem";
            this.另存新檔AToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.另存新檔AToolStripMenuItem.Text = "另存新檔(&A)";
            this.另存新檔AToolStripMenuItem.Click += new System.EventHandler(this.另存新檔AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // 結束XToolStripMenuItem
            // 
            this.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
            this.結束XToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.結束XToolStripMenuItem.Text = "結束(&X)";
            this.結束XToolStripMenuItem.Click += new System.EventHandler(this.結束XToolStripMenuItem_Click);
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.剪下TToolStripMenuItem,
            this.複製CToolStripMenuItem,
            this.貼上PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全選AToolStripMenuItem,
            this.搜尋取代ToolStripMenuItem});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.編輯EToolStripMenuItem.Text = "編輯(&E)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // 剪下TToolStripMenuItem
            // 
            this.剪下TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪下TToolStripMenuItem.Image")));
            this.剪下TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪下TToolStripMenuItem.Name = "剪下TToolStripMenuItem";
            this.剪下TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪下TToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.剪下TToolStripMenuItem.Text = "剪下(&T)";
            this.剪下TToolStripMenuItem.Click += new System.EventHandler(this.剪下TToolStripMenuItem_Click);
            // 
            // 複製CToolStripMenuItem
            // 
            this.複製CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("複製CToolStripMenuItem.Image")));
            this.複製CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
            this.複製CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.複製CToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.複製CToolStripMenuItem.Text = "複製(&C)";
            this.複製CToolStripMenuItem.Click += new System.EventHandler(this.複製CToolStripMenuItem_Click);
            // 
            // 貼上PToolStripMenuItem
            // 
            this.貼上PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("貼上PToolStripMenuItem.Image")));
            this.貼上PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
            this.貼上PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼上PToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.貼上PToolStripMenuItem.Text = "貼上(&P)";
            this.貼上PToolStripMenuItem.Click += new System.EventHandler(this.貼上PToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(154, 6);
            // 
            // 全選AToolStripMenuItem
            // 
            this.全選AToolStripMenuItem.Name = "全選AToolStripMenuItem";
            this.全選AToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.全選AToolStripMenuItem.Text = "全選(&A)";
            this.全選AToolStripMenuItem.Click += new System.EventHandler(this.全選AToolStripMenuItem_Click);
            // 
            // 搜尋取代ToolStripMenuItem
            // 
            this.搜尋取代ToolStripMenuItem.Name = "搜尋取代ToolStripMenuItem";
            this.搜尋取代ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.搜尋取代ToolStripMenuItem.Text = "搜尋取代";
            this.搜尋取代ToolStripMenuItem.Click += new System.EventHandler(this.搜尋取代ToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂CToolStripMenuItem,
            this.選項OToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 自訂CToolStripMenuItem
            // 
            this.自訂CToolStripMenuItem.Name = "自訂CToolStripMenuItem";
            this.自訂CToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.自訂CToolStripMenuItem.Text = "字型(&W)";
            this.自訂CToolStripMenuItem.Click += new System.EventHandler(this.自訂CToolStripMenuItem_Click);
            // 
            // 選項OToolStripMenuItem
            // 
            this.選項OToolStripMenuItem.Name = "選項OToolStripMenuItem";
            this.選項OToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.選項OToolStripMenuItem.Text = "顏色(&C)";
            this.選項OToolStripMenuItem.Click += new System.EventHandler(this.選項OToolStripMenuItem_Click);
            // 
            // 說明HToolStripMenuItem
            // 
            this.說明HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜尋SToolStripMenuItem,
            this.toolStripSeparator5,
            this.關於AToolStripMenuItem});
            this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            this.說明HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.說明HToolStripMenuItem.Text = "說明(&H)";
            // 
            // 內容CToolStripMenuItem
            // 
            this.內容CToolStripMenuItem.Name = "內容CToolStripMenuItem";
            this.內容CToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.內容CToolStripMenuItem.Text = "內容(&C)";
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.索引IToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜尋SToolStripMenuItem
            // 
            this.搜尋SToolStripMenuItem.Name = "搜尋SToolStripMenuItem";
            this.搜尋SToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.搜尋SToolStripMenuItem.Text = "搜尋(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(120, 6);
            // 
            // 關於AToolStripMenuItem
            // 
            this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            this.關於AToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.關於AToolStripMenuItem.Text = "關於(&A)...";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(800, 426);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "純文字檔案|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "純文字檔案|*.txt";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(386, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 108);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 20);
            this.button3.TabIndex = 4;
            this.button3.Text = "關閉";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "取代";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "搜尋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 22);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 22);
            this.textBox2.TabIndex = 0;
            // 
            // hw09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "hw09";
            this.Text = "hw09";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 結束XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪下TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全選AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選項OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 內容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜尋SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 搜尋取代ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}