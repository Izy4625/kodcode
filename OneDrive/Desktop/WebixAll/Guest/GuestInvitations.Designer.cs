namespace Guest
{
    partial class GuestInvitations
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvOtherGuests;
        private System.Windows.Forms.DataGridView dgvMyChoices;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvOtherGuests = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMyChoices = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyChoices)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(580, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Categories Editor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // dgvOtherGuests
            // 
            this.dgvOtherGuests.AllowUserToAddRows = false;
            this.dgvOtherGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtherGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvOtherGuests.Location = new System.Drawing.Point(55, 33);
            this.dgvOtherGuests.Name = "dgvOtherGuests";
            this.dgvOtherGuests.ReadOnly = true;
            this.dgvOtherGuests.RowHeadersWidth = 51;
            this.dgvOtherGuests.Size = new System.Drawing.Size(515, 200);
            this.dgvOtherGuests.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Other Guests\' Choices";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dgvMyChoices
            // 
            this.dgvMyChoices.AllowUserToAddRows = false;
            this.dgvMyChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyChoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvMyChoices.Location = new System.Drawing.Point(55, 326);
            this.dgvMyChoices.Name = "dgvMyChoices";
            this.dgvMyChoices.RowHeadersWidth = 51;
            this.dgvMyChoices.Size = new System.Drawing.Size(515, 200);
            this.dgvMyChoices.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "My Choices";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(55, 264);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(118, 50);
            this.btnAddDish.TabIndex = 4;
            this.btnAddDish.Text = "Add Dish";
            // 
            // txtDishName
            // 
            this.txtDishName.ForeColor = System.Drawing.Color.Gray;
            this.txtDishName.Location = new System.Drawing.Point(221, 278);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(200, 26);
            this.txtDishName.TabIndex = 3;
            this.txtDishName.Text = "Enter dish name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(472, 264);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(98, 50);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(490, 556);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GuestInvitations
            // 
            this.ClientSize = new System.Drawing.Size(642, 610);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvOtherGuests);
            this.Controls.Add(this.dgvMyChoices);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Name = "GuestInvitations";
            this.Text = "Categories Editor";
            this.Load += new System.EventHandler(this.GuestInvitations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyChoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}