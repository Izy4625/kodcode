﻿namespace Employee_log_in
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chngpassword = new System.Windows.Forms.Button();
            this.Timeclock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(342, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.button1_Click);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter userId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter password";
            // 
            // Chngpassword
            // 
            this.Chngpassword.Location = new System.Drawing.Point(342, 346);
            this.Chngpassword.Name = "Chngpassword";
            this.Chngpassword.Size = new System.Drawing.Size(183, 33);
            this.Chngpassword.TabIndex = 4;
            this.Chngpassword.Text = "ChangePassword";
            this.Chngpassword.UseVisualStyleBackColor = true;
            this.Chngpassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timeclock
            // 
            this.Timeclock.Location = new System.Drawing.Point(130, 351);
            this.Timeclock.Name = "Timeclock";
            this.Timeclock.Size = new System.Drawing.Size(141, 41);
            this.Timeclock.TabIndex = 5;
            this.Timeclock.Text = "View_time-clock";
            this.Timeclock.UseVisualStyleBackColor = true;
            this.Timeclock.Click += new System.EventHandler(this.Timeclock_Click);
            this.Timeclock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Timeclock_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Timeclock);
            this.Controls.Add(this.Chngpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Chngpassword;
        private System.Windows.Forms.Button Timeclock;
    }
}

