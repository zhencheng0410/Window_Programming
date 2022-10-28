namespace Stacking_Game
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
            this.stack4 = new System.Windows.Forms.TextBox();
            this.stack2 = new System.Windows.Forms.TextBox();
            this.stack3 = new System.Windows.Forms.TextBox();
            this.stack1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stack4
            // 
            this.stack4.Location = new System.Drawing.Point(118, 278);
            this.stack4.Name = "stack4";
            this.stack4.Size = new System.Drawing.Size(157, 25);
            this.stack4.TabIndex = 19;
            this.stack4.Text = "3 3 3 1";
            // 
            // stack2
            // 
            this.stack2.Location = new System.Drawing.Point(118, 187);
            this.stack2.Name = "stack2";
            this.stack2.Size = new System.Drawing.Size(157, 25);
            this.stack2.TabIndex = 18;
            this.stack2.Text = "2 2";
            // 
            // stack3
            // 
            this.stack3.Location = new System.Drawing.Point(118, 233);
            this.stack3.Name = "stack3";
            this.stack3.Size = new System.Drawing.Size(157, 25);
            this.stack3.TabIndex = 17;
            // 
            // stack1
            // 
            this.stack1.Location = new System.Drawing.Point(118, 142);
            this.stack1.Name = "stack1";
            this.stack1.Size = new System.Drawing.Size(157, 25);
            this.stack1.TabIndex = 16;
            this.stack1.Text = "1 1 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "開始遊戲";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(59, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "堆疊4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(59, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "堆疊3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(59, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "堆疊2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(59, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "堆疊1";
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title.Location = new System.Drawing.Point(62, 96);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(213, 24);
            this.title.TabIndex = 10;
            this.title.Text = "請輸入測資";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.stack4);
            this.Controls.Add(this.stack2);
            this.Controls.Add(this.stack3);
            this.Controls.Add(this.stack1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stack4;
        private System.Windows.Forms.TextBox stack2;
        private System.Windows.Forms.TextBox stack3;
        private System.Windows.Forms.TextBox stack1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
    }
}

