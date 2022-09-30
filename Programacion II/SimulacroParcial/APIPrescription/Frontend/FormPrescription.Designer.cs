
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboPrescriptionType = new System.Windows.Forms.ComboBox();
            this.cboIngredients = new System.Windows.Forms.ComboBox();
            this.cboAmounts = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCheff = new System.Windows.Forms.Label();
            this.lblPrescriptionType = new System.Windows.Forms.Label();
            this.lblTotalIngredients = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 20);
            this.textBox2.TabIndex = 2;
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
            // cboAmounts
            // 
            this.cboAmounts.FormattingEnabled = true;
            this.cboAmounts.Location = new System.Drawing.Point(354, 153);
            this.cboAmounts.Name = "cboAmounts";
            this.cboAmounts.Size = new System.Drawing.Size(220, 21);
            this.cboAmounts.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(580, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(182, 336);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 8;
            this.btnAcept.Text = "Acept";
            this.btnAcept.UseVisualStyleBackColor = true;
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
            this.lblTotalIngredients.TabIndex = 14;
            this.lblTotalIngredients.Text = "TotalIngredients:";
            // 
            // FormPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalIngredients);
            this.Controls.Add(this.lblPrescriptionType);
            this.Controls.Add(this.lblCheff);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboAmounts);
            this.Controls.Add(this.cboIngredients);
            this.Controls.Add(this.cboPrescriptionType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrescriptionNumber);
            this.Name = "FormPrescription";
            this.Text = "Prescription";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrescriptionNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboPrescriptionType;
        private System.Windows.Forms.ComboBox cboIngredients;
        private System.Windows.Forms.ComboBox cboAmounts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCheff;
        private System.Windows.Forms.Label lblPrescriptionType;
        private System.Windows.Forms.Label lblTotalIngredients;
    }
}

