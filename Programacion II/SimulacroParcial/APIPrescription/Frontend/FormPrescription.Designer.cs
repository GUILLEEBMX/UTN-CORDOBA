
namespace APIPrescription
{
    partial class FormPrescription
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrescriptionNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCheff = new System.Windows.Forms.TextBox();
            this.cboPrescriptionType = new System.Windows.Forms.ComboBox();
            this.cboIngredients = new System.Windows.Forms.ComboBox();
            this.dgvPrescription = new System.Windows.Forms.DataGridView();
            this.Ingredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCheff = new System.Windows.Forms.Label();
            this.lblPrescriptionType = new System.Windows.Forms.Label();
            this.lblTotalIngredients = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrescriptionNumber
            // 
            this.lblPrescriptionNumber.AutoSize = true;
            this.lblPrescriptionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionNumber.Location = new System.Drawing.Point(50, 9);
            this.lblPrescriptionNumber.Name = "lblPrescriptionNumber";
            this.lblPrescriptionNumber.Size = new System.Drawing.Size(172, 25);
            this.lblPrescriptionNumber.TabIndex = 0;
            this.lblPrescriptionNumber.Text = "Prescription # :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtCheff
            // 
            this.txtCheff.Location = new System.Drawing.Point(126, 73);
            this.txtCheff.Name = "txtCheff";
            this.txtCheff.Size = new System.Drawing.Size(319, 20);
            this.txtCheff.TabIndex = 2;
            // 
            // cboPrescriptionType
            // 
            this.cboPrescriptionType.FormattingEnabled = true;
            this.cboPrescriptionType.Location = new System.Drawing.Point(157, 107);
            this.cboPrescriptionType.Name = "cboPrescriptionType";
            this.cboPrescriptionType.Size = new System.Drawing.Size(288, 21);
            this.cboPrescriptionType.TabIndex = 3;
            // 
            // cboIngredients
            // 
            this.cboIngredients.FormattingEnabled = true;
            this.cboIngredients.Location = new System.Drawing.Point(65, 151);
            this.cboIngredients.Name = "cboIngredients";
            this.cboIngredients.Size = new System.Drawing.Size(283, 21);
            this.cboIngredients.TabIndex = 4;
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredients,
            this.Amount,
            this.Actions,
            this.ID});
            this.dgvPrescription.Location = new System.Drawing.Point(65, 180);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.Size = new System.Drawing.Size(590, 150);
            this.dgvPrescription.TabIndex = 7;
            // 
            // Ingredients
            // 
            this.Ingredients.HeaderText = "ID";
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Visible = false;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Ingredient";
            this.Amount.Name = "Amount";
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Amount";
            this.Actions.Name = "Actions";
            // 
            // ID
            // 
            this.ID.HeaderText = "Actions";
            this.ID.Name = "ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(580, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(182, 336);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 8;
            this.btnAcept.Text = "Acept";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(62, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // lblCheff
            // 
            this.lblCheff.AutoSize = true;
            this.lblCheff.Location = new System.Drawing.Point(62, 83);
            this.lblCheff.Name = "lblCheff";
            this.lblCheff.Size = new System.Drawing.Size(35, 13);
            this.lblCheff.TabIndex = 12;
            this.lblCheff.Text = "Cheff:";
            // 
            // lblPrescriptionType
            // 
            this.lblPrescriptionType.AutoSize = true;
            this.lblPrescriptionType.Location = new System.Drawing.Point(62, 110);
            this.lblPrescriptionType.Name = "lblPrescriptionType";
            this.lblPrescriptionType.Size = new System.Drawing.Size(89, 13);
            this.lblPrescriptionType.TabIndex = 13;
            this.lblPrescriptionType.Text = "PrescriptionType:";
            // 
            // lblTotalIngredients
            // 
            this.lblTotalIngredients.AutoSize = true;
            this.lblTotalIngredients.Location = new System.Drawing.Point(457, 341);
            this.lblTotalIngredients.Name = "lblTotalIngredients";
            this.lblTotalIngredients.Size = new System.Drawing.Size(86, 13);
            this.lblTotalIngredients.TabIndex = 10;
            this.lblTotalIngredients.Text = "TotalIngredients:";
            this.lblTotalIngredients.Click += new System.EventHandler(this.lblTotalIngredients_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(354, 153);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(220, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // FormPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblTotalIngredients);
            this.Controls.Add(this.lblPrescriptionType);
            this.Controls.Add(this.lblCheff);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPrescription);
            this.Controls.Add(this.cboIngredients);
            this.Controls.Add(this.cboPrescriptionType);
            this.Controls.Add(this.txtCheff);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrescriptionNumber);
            this.Name = "FormPrescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.FormPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrescriptionNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCheff;
        private System.Windows.Forms.ComboBox cboPrescriptionType;
        private System.Windows.Forms.ComboBox cboIngredients;
        private System.Windows.Forms.DataGridView dgvPrescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCheff;
        private System.Windows.Forms.Label lblPrescriptionType;
        private System.Windows.Forms.Label lblTotalIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TextBox txtAmount;
    }
}

