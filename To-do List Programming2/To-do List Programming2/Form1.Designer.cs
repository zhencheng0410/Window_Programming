namespace To_do_List_Programming2
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.todelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tocomplete = new System.Windows.Forms.ToolStripMenuItem();
            this.addtodo = new System.Windows.Forms.ToolStripMenuItem();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidefinish = new System.Windows.Forms.ToolStripMenuItem();
            this.showfinish = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsize = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.save_as_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.savefile = new System.Windows.Forms.ToolStripMenuItem();
            this.openfile = new System.Windows.Forms.ToolStripMenuItem();
            this.newform = new System.Windows.Forms.ToolStripMenuItem();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(684, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "關閉搜尋";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "新增事項";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "完成事項";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(13, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(775, 407);
            this.textBox1.TabIndex = 7;
            // 
            // todelete
            // 
            this.todelete.Name = "todelete";
            this.todelete.Size = new System.Drawing.Size(216, 26);
            this.todelete.Text = "刪除事項";
            this.todelete.Click += new System.EventHandler(this.todelete_Click);
            // 
            // tocomplete
            // 
            this.tocomplete.Name = "tocomplete";
            this.tocomplete.Size = new System.Drawing.Size(216, 26);
            this.tocomplete.Text = "完成事項";
            this.tocomplete.Click += new System.EventHandler(this.tocomplete_Click);
            // 
            // addtodo
            // 
            this.addtodo.Name = "addtodo";
            this.addtodo.Size = new System.Drawing.Size(216, 26);
            this.addtodo.Text = "新增事項";
            this.addtodo.Click += new System.EventHandler(this.addtodo_Click);
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(216, 26);
            this.find.Text = "尋找";
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.find,
            this.addtodo,
            this.tocomplete,
            this.todelete});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // hidefinish
            // 
            this.hidefinish.Name = "hidefinish";
            this.hidefinish.Size = new System.Drawing.Size(216, 26);
            this.hidefinish.Text = "隱藏完成事項";
            this.hidefinish.Click += new System.EventHandler(this.hidefinish_Click);
            // 
            // showfinish
            // 
            this.showfinish.Name = "showfinish";
            this.showfinish.Size = new System.Drawing.Size(216, 26);
            this.showfinish.Text = "顯示完成事項";
            this.showfinish.Click += new System.EventHandler(this.showfinish_Click);
            // 
            // fontsize
            // 
            this.fontsize.Name = "fontsize";
            this.fontsize.Size = new System.Drawing.Size(216, 26);
            this.fontsize.Text = "字型大小";
            this.fontsize.Click += new System.EventHandler(this.fontsize_Click);
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontsize,
            this.showfinish,
            this.hidefinish});
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(216, 26);
            this.exit.Text = "離開";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save_as_new_file
            // 
            this.save_as_new_file.Name = "save_as_new_file";
            this.save_as_new_file.Size = new System.Drawing.Size(216, 26);
            this.save_as_new_file.Text = "另存新檔";
            this.save_as_new_file.Click += new System.EventHandler(this.save_as_new_file_Click);
            // 
            // savefile
            // 
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(216, 26);
            this.savefile.Text = "儲存";
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // openfile
            // 
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(216, 26);
            this.openfile.Text = "開啟";
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // newform
            // 
            this.newform.Name = "newform";
            this.newform.Size = new System.Drawing.Size(216, 26);
            this.newform.Text = "新增";
            this.newform.Click += new System.EventHandler(this.newform_Click);
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newform,
            this.openfile,
            this.savefile,
            this.save_as_new_file,
            this.exit});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.檢視ToolStripMenuItem,
            this.編輯ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(12, 67);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(775, 407);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem todelete;
        private System.Windows.Forms.ToolStripMenuItem tocomplete;
        private System.Windows.Forms.ToolStripMenuItem addtodo;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidefinish;
        private System.Windows.Forms.ToolStripMenuItem showfinish;
        private System.Windows.Forms.ToolStripMenuItem fontsize;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem save_as_new_file;
        private System.Windows.Forms.ToolStripMenuItem savefile;
        private System.Windows.Forms.ToolStripMenuItem openfile;
        private System.Windows.Forms.ToolStripMenuItem newform;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox textBox2;
    }
}

