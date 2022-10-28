namespace To_do_List_Programming
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newform = new System.Windows.Forms.ToolStripMenuItem();
            this.openfile = new System.Windows.Forms.ToolStripMenuItem();
            this.savefile = new System.Windows.Forms.ToolStripMenuItem();
            this.save_as_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsize = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.檢視ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            // newform
            // 
            this.newform.Name = "newform";
            this.newform.Size = new System.Drawing.Size(216, 26);
            this.newform.Text = "新增";
            this.newform.Click += new System.EventHandler(this.newform_Click);
            // 
            // openfile
            // 
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(216, 26);
            this.openfile.Text = "開啟";
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // savefile
            // 
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(216, 26);
            this.savefile.Text = "儲存";
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // save_as_new_file
            // 
            this.save_as_new_file.Name = "save_as_new_file";
            this.save_as_new_file.Size = new System.Drawing.Size(216, 26);
            this.save_as_new_file.Text = "另存新檔";
            this.save_as_new_file.Click += new System.EventHandler(this.save_as_new_file_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(216, 26);
            this.exit.Text = "離開";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontsize});
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // fontsize
            // 
            this.fontsize.Name = "fontsize";
            this.fontsize.Size = new System.Drawing.Size(216, 26);
            this.fontsize.Text = "字型大小";
            this.fontsize.Click += new System.EventHandler(this.fontsize_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "新增事項";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(776, 384);
            this.textBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 470);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newform;
        private System.Windows.Forms.ToolStripMenuItem openfile;
        private System.Windows.Forms.ToolStripMenuItem savefile;
        private System.Windows.Forms.ToolStripMenuItem save_as_new_file;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontsize;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

