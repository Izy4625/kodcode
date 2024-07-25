namespace VendingMachine
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbCoffee = new System.Windows.Forms.ComboBox();
            this.cmbMilk = new System.Windows.Forms.ComboBox();
            this.cmbCacao = new System.Windows.Forms.ComboBox();
            this.cmbSoger = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDreankName = new System.Windows.Forms.TextBox();
            this.lblDreankName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 244);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 50);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cacao
            // 
            this.cacao.HeaderText = "קקאו";
            this.cacao.MinimumWidth = 6;
            this.cacao.Name = "cacao";
            this.cacao.ReadOnly = true;
            this.cacao.Width = 125;
            // 
            // milk
            // 
            this.milk.HeaderText = "חלב";
            this.milk.MinimumWidth = 6;
            this.milk.Name = "milk";
            this.milk.ReadOnly = true;
            this.milk.Width = 125;
            // 
            // coffee
            // 
            this.coffee.HeaderText = "קפה";
            this.coffee.MinimumWidth = 6;
            this.coffee.Name = "coffee";
            this.coffee.ReadOnly = true;
            this.coffee.Width = 125;
            // 
            // soger
            // 
            this.soger.HeaderText = "סוכר";
            this.soger.MinimumWidth = 6;
            this.soger.Name = "soger";
            this.soger.ReadOnly = true;
            this.soger.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "שם";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "מחיר";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(336, 244);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 50);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.soger,
            this.coffee,
            this.milk,
            this.cacao,
            this.price});
            this.dgvMenu.Location = new System.Drawing.Point(311, 321);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(992, 272);
            this.dgvMenu.TabIndex = 35;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(25, 244);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 50);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "מחיקה";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 403);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 50);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "שמירה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(586, 197);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(28, 29);
            this.btnMinus.TabIndex = 32;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(586, 161);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(28, 29);
            this.btnPlus.TabIndex = 31;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(632, 180);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(66, 26);
            this.txtPrice.TabIndex = 30;
            this.txtPrice.Text = "4";
            // 
            // cmbCoffee
            // 
            this.cmbCoffee.FormattingEnabled = true;
            this.cmbCoffee.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cmbCoffee.Location = new System.Drawing.Point(998, 180);
            this.cmbCoffee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCoffee.Name = "cmbCoffee";
            this.cmbCoffee.Size = new System.Drawing.Size(69, 28);
            this.cmbCoffee.TabIndex = 29;
            this.cmbCoffee.Text = "1.0";
            // 
            // cmbMilk
            // 
            this.cmbMilk.FormattingEnabled = true;
            this.cmbMilk.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cmbMilk.Location = new System.Drawing.Point(866, 180);
            this.cmbMilk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMilk.Name = "cmbMilk";
            this.cmbMilk.Size = new System.Drawing.Size(69, 28);
            this.cmbMilk.TabIndex = 28;
            this.cmbMilk.Text = "1.0";
            // 
            // cmbCacao
            // 
            this.cmbCacao.FormattingEnabled = true;
            this.cmbCacao.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cmbCacao.Location = new System.Drawing.Point(751, 180);
            this.cmbCacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCacao.Name = "cmbCacao";
            this.cmbCacao.Size = new System.Drawing.Size(69, 28);
            this.cmbCacao.TabIndex = 27;
            this.cmbCacao.Text = "1.0";
            // 
            // cmbSoger
            // 
            this.cmbSoger.FormattingEnabled = true;
            this.cmbSoger.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cmbSoger.Location = new System.Drawing.Point(1102, 180);
            this.cmbSoger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSoger.Name = "cmbSoger";
            this.cmbSoger.Size = new System.Drawing.Size(69, 28);
            this.cmbSoger.TabIndex = 26;
            this.cmbSoger.Text = "1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "מחיר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1133, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "סוכר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1036, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "קפה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(900, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "חלב";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "קקאו";
            // 
            // txtDreankName
            // 
            this.txtDreankName.Location = new System.Drawing.Point(875, 34);
            this.txtDreankName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDreankName.Name = "txtDreankName";
            this.txtDreankName.Size = new System.Drawing.Size(182, 26);
            this.txtDreankName.TabIndex = 20;
            this.txtDreankName.TextChanged += new System.EventHandler(this.txtDreankName_TextChanged);
            // 
            // lblDreankName
            // 
            this.lblDreankName.AutoSize = true;
            this.lblDreankName.Location = new System.Drawing.Point(1097, 36);
            this.lblDreankName.Name = "lblDreankName";
            this.lblDreankName.Size = new System.Drawing.Size(77, 20);
            this.lblDreankName.TabIndex = 19;
            this.lblDreankName.Text = "שם השתיה";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 626);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbCoffee);
            this.Controls.Add(this.cmbMilk);
            this.Controls.Add(this.cmbCacao);
            this.Controls.Add(this.cmbSoger);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDreankName);
            this.Controls.Add(this.lblDreankName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn milk;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn soger;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbCoffee;
        private System.Windows.Forms.ComboBox cmbMilk;
        private System.Windows.Forms.ComboBox cmbCacao;
        private System.Windows.Forms.ComboBox cmbSoger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDreankName;
        private System.Windows.Forms.Label lblDreankName;
    }
}

