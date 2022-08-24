
namespace Carpinteria.Fronted
{
    partial class FormBudget
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.detailsDgv = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.ButtonAcept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumberBudget = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(78, 79);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 2;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(78, 105);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 3;
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(15, 143);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(364, 21);
            this.cboProducts.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(398, 143);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(603, 140);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // detailsDgv
            // 
            this.detailsDgv.AllowUserToOrderColumns = true;
            this.detailsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Products,
            this.Price,
            this.Amount,
            this.Actions});
            this.detailsDgv.Location = new System.Drawing.Point(12, 170);
            this.detailsDgv.Name = "detailsDgv";
            this.detailsDgv.Size = new System.Drawing.Size(760, 188);
            this.detailsDgv.TabIndex = 7;
            this.detailsDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailsDgv_CellContentClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(17, 82);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 9;
            this.lblClient.Text = "Client";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(12, 112);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(60, 13);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "% Discount";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(659, 371);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(659, 397);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // ButtonAcept
            // 
            this.ButtonAcept.Location = new System.Drawing.Point(199, 387);
            this.ButtonAcept.Name = "ButtonAcept";
            this.ButtonAcept.Size = new System.Drawing.Size(75, 23);
            this.ButtonAcept.TabIndex = 13;
            this.ButtonAcept.Text = "ACEPT";
            this.ButtonAcept.UseVisualStyleBackColor = true;
            this.ButtonAcept.Click += new System.EventHandler(this.ButtonAcept_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(330, 388);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 14;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(600, 378);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubTotal.TabIndex = 15;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(604, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // lblNumberBudget
            // 
            this.lblNumberBudget.AutoSize = true;
            this.lblNumberBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNumberBudget.Location = new System.Drawing.Point(10, 9);
            this.lblNumberBudget.Name = "lblNumberBudget";
            this.lblNumberBudget.Size = new System.Drawing.Size(100, 25);
            this.lblNumberBudget.TabIndex = 17;
            this.lblNumberBudget.Text = "Nº Budget";
            // 
            // Products
            // 
            this.Products.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Products.Frozen = true;
            this.Products.HeaderText = "Products";
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            this.Products.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Products.Width = 74;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Amount
            // 
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Actions
            // 
            this.Actions.Frozen = true;
            this.Actions.HeaderText = "Actions";
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            // 
            // FormBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumberBudget);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAcept);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.detailsDgv);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormBudget";
            this.Text = "FormBudget";
            this.Load += new System.EventHandler(this.FormBudget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.DataGridView detailsDgv;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button ButtonAcept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumberBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
    }
}