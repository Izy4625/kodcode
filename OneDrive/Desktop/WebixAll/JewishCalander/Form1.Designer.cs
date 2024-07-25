namespace JewishCalander
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
            this.cbD = new System.Windows.Forms.ComboBox();
            this.cbDM = new System.Windows.Forms.ComboBox();
            this.cbM = new System.Windows.Forms.ComboBox();
            this.cbY = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbD
            // 
            this.cbD.FormattingEnabled = true;
            this.cbD.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cbD.Location = new System.Drawing.Point(613, 79);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(121, 28);
            this.cbD.TabIndex = 0;
            this.cbD.SelectedIndexChanged += new System.EventHandler(this.cbD_SelectedIndexChanged);
            // 
            // cbDM
            // 
            this.cbDM.FormattingEnabled = true;
            this.cbDM.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cbDM.Location = new System.Drawing.Point(468, 79);
            this.cbDM.Name = "cbDM";
            this.cbDM.Size = new System.Drawing.Size(121, 28);
            this.cbDM.TabIndex = 1;
            this.cbDM.SelectedIndexChanged += new System.EventHandler(this.cbDM_SelectedIndexChanged);
            // 
            // cbM
            // 
            this.cbM.FormattingEnabled = true;
            this.cbM.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            " December"});
            this.cbM.Location = new System.Drawing.Point(316, 78);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(121, 28);
            this.cbM.TabIndex = 2;
            this.cbM.SelectedIndexChanged += new System.EventHandler(this.cbM_SelectedIndexChanged);
            // 
            // cbY
            // 
            this.cbY.FormattingEnabled = true;
            this.cbY.Items.AddRange(new object[] {
            "5784",
            "5785",
            "5786",
            "5787",
            "5788",
            "5789",
            "5790",
            "5791",
            "5792",
            "5793",
            "5794"});
            this.cbY.Location = new System.Drawing.Point(141, 78);
            this.cbY.Name = "cbY";
            this.cbY.Size = new System.Drawing.Size(121, 28);
            this.cbY.TabIndex = 3;
            this.cbY.SelectedIndexChanged += new System.EventHandler(this.cbY_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbY);
            this.Controls.Add(this.cbM);
            this.Controls.Add(this.cbDM);
            this.Controls.Add(this.cbD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbD;
        private System.Windows.Forms.ComboBox cbDM;
        private System.Windows.Forms.ComboBox cbM;
        private System.Windows.Forms.ComboBox cbY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

