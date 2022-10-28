namespace Stacking_Game
{
    partial class Form2
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
            this.win_label = new System.Windows.Forms.Label();
            this.main_button = new System.Windows.Forms.Button();
            this.choose4 = new System.Windows.Forms.Button();
            this.choose3 = new System.Windows.Forms.Button();
            this.choose2 = new System.Windows.Forms.Button();
            this.choose1 = new System.Windows.Forms.Button();
            this.stack4 = new System.Windows.Forms.TextBox();
            this.stack3 = new System.Windows.Forms.TextBox();
            this.stack2 = new System.Windows.Forms.TextBox();
            this.stack1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // win_label
            // 
            this.win_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.win_label.Location = new System.Drawing.Point(49, 382);
            this.win_label.Name = "win_label";
            this.win_label.Size = new System.Drawing.Size(126, 38);
            this.win_label.TabIndex = 32;
            this.win_label.Text = "...";
            // 
            // main_button
            // 
            this.main_button.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_button.Location = new System.Drawing.Point(229, 382);
            this.main_button.Name = "main_button";
            this.main_button.Size = new System.Drawing.Size(98, 27);
            this.main_button.TabIndex = 31;
            this.main_button.Text = "回主畫面";
            this.main_button.UseVisualStyleBackColor = true;
            this.main_button.Click += new System.EventHandler(this.main_Click);
            // 
            // choose4
            // 
            this.choose4.Font = new System.Drawing.Font("新細明體", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.choose4.Location = new System.Drawing.Point(280, 332);
            this.choose4.Name = "choose4";
            this.choose4.Size = new System.Drawing.Size(51, 26);
            this.choose4.TabIndex = 30;
            this.choose4.Text = "選取";
            this.choose4.UseVisualStyleBackColor = true;
            this.choose4.Click += new System.EventHandler(this.choose4_Click);
            // 
            // choose3
            // 
            this.choose3.Font = new System.Drawing.Font("新細明體", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.choose3.Location = new System.Drawing.Point(203, 332);
            this.choose3.Name = "choose3";
            this.choose3.Size = new System.Drawing.Size(51, 26);
            this.choose3.TabIndex = 29;
            this.choose3.Text = "選取";
            this.choose3.UseVisualStyleBackColor = true;
            this.choose3.Click += new System.EventHandler(this.choose3_Click);
            // 
            // choose2
            // 
            this.choose2.Font = new System.Drawing.Font("新細明體", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.choose2.Location = new System.Drawing.Point(124, 332);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(51, 26);
            this.choose2.TabIndex = 28;
            this.choose2.Text = "選取";
            this.choose2.UseVisualStyleBackColor = true;
            this.choose2.Click += new System.EventHandler(this.choose2_Click);
            // 
            // choose1
            // 
            this.choose1.Font = new System.Drawing.Font("新細明體", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.choose1.Location = new System.Drawing.Point(50, 332);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(51, 26);
            this.choose1.TabIndex = 27;
            this.choose1.Text = "選取";
            this.choose1.UseVisualStyleBackColor = true;
            this.choose1.Click += new System.EventHandler(this.choose1_Click);
            // 
            // stack4
            // 
            this.stack4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stack4.Location = new System.Drawing.Point(280, 62);
            this.stack4.Multiline = true;
            this.stack4.Name = "stack4";
            this.stack4.ReadOnly = true;
            this.stack4.Size = new System.Drawing.Size(51, 254);
            this.stack4.TabIndex = 26;
            // 
            // stack3
            // 
            this.stack3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stack3.Location = new System.Drawing.Point(203, 62);
            this.stack3.Multiline = true;
            this.stack3.Name = "stack3";
            this.stack3.ReadOnly = true;
            this.stack3.Size = new System.Drawing.Size(51, 254);
            this.stack3.TabIndex = 25;
            // 
            // stack2
            // 
            this.stack2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stack2.Location = new System.Drawing.Point(124, 62);
            this.stack2.Multiline = true;
            this.stack2.Name = "stack2";
            this.stack2.ReadOnly = true;
            this.stack2.Size = new System.Drawing.Size(51, 254);
            this.stack2.TabIndex = 24;
            // 
            // stack1
            // 
            this.stack1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stack1.Location = new System.Drawing.Point(49, 62);
            this.stack1.Multiline = true;
            this.stack1.Name = "stack1";
            this.stack1.ReadOnly = true;
            this.stack1.Size = new System.Drawing.Size(51, 254);
            this.stack1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(283, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "堆疊4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(205, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "堆疊3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(127, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "堆疊2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "堆疊1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.win_label);
            this.Controls.Add(this.main_button);
            this.Controls.Add(this.choose4);
            this.Controls.Add(this.choose3);
            this.Controls.Add(this.choose2);
            this.Controls.Add(this.choose1);
            this.Controls.Add(this.stack4);
            this.Controls.Add(this.stack3);
            this.Controls.Add(this.stack2);
            this.Controls.Add(this.stack1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label win_label;
        private System.Windows.Forms.Button main_button;
        private System.Windows.Forms.Button choose4;
        private System.Windows.Forms.Button choose3;
        private System.Windows.Forms.Button choose2;
        private System.Windows.Forms.Button choose1;
        private System.Windows.Forms.TextBox stack4;
        private System.Windows.Forms.TextBox stack3;
        private System.Windows.Forms.TextBox stack2;
        private System.Windows.Forms.TextBox stack1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}