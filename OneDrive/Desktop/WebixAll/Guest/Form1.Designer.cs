namespace Guest
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtIGuest;
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtIGuest = new System.Windows.Forms.TextBox();
            this.lstGuests = new System.Windows.Forms.ListBox();
            this.btnLook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(240, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ברוכים הבאים";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.Location = new System.Drawing.Point(240, 63);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(280, 20);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "הכנס שם אורח";
            // 
            // txtIGuest
            // 
            this.txtIGuest.Location = new System.Drawing.Point(243, 111);
            this.txtIGuest.Name = "txtIGuest";
            this.txtIGuest.Size = new System.Drawing.Size(280, 26);
            this.txtIGuest.TabIndex = 2;
            // 
            // lstGuests
            // 
            this.lstGuests.FormattingEnabled = true;
            this.lstGuests.ItemHeight = 20;
            this.lstGuests.Location = new System.Drawing.Point(290, 183);
            this.lstGuests.Name = "lstGuests";
            this.lstGuests.Size = new System.Drawing.Size(180, 104);
            this.lstGuests.TabIndex = 4;
            this.lstGuests.SelectedIndexChanged += new System.EventHandler(this.lstCategorieGuests_SelectedIndexChanged);
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(311, 353);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(138, 23);
            this.btnLook.TabIndex = 6;
            this.btnLook.Text = "אישור";
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(736, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.lstGuests);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.txtIGuest);
            this.Name = "Form1";
            this.Text = "Host";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lstGuests;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button button1;
    }
}