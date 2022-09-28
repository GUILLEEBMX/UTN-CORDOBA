
namespace RecetasSLN.presentación
{
    partial class FrmConsultarRecetas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cheff = new System.Windows.Forms.Label();
            this.txtCheff = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNamePrescription = new System.Windows.Forms.Label();
            this.lblPrescriptionType = new System.Windows.Forms.Label();
            this.cboPrescriptionTypes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvPrescription = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboIngredients = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cheff);
            this.groupBox1.Controls.Add(this.txtCheff);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblNamePrescription);
            this.groupBox1.Controls.Add(this.lblPrescriptionType);
            this.groupBox1.Controls.Add(this.cboPrescriptionTypes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // Cheff
            // 
            this.Cheff.AutoSize = true;
            this.Cheff.Location = new System.Drawing.Point(56, 70);
            this.Cheff.Name = "Cheff";
            this.Cheff.Size = new System.Drawing.Size(35, 13);
            this.Cheff.TabIndex = 5;
            this.Cheff.Text = "Cheff:";
            // 
            // txtCheff
            // 
            this.txtCheff.Location = new System.Drawing.Point(104, 67);
            this.txtCheff.Name = "txtCheff";
            this.txtCheff.Size = new System.Drawing.Size(243, 20);
            this.txtCheff.TabIndex = 2;
            this.txtCheff.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(390, 53);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblNamePrescription
            // 
            this.lblNamePrescription.AutoSize = true;
            this.lblNamePrescription.Location = new System.Drawing.Point(6, 46);
            this.lblNamePrescription.Name = "lblNamePrescription";
            this.lblNamePrescription.Size = new System.Drawing.Size(96, 13);
            this.lblNamePrescription.TabIndex = 2;
            this.lblNamePrescription.Text = "Prescription Name:";
            // 
            // lblPrescriptionType
            // 
            this.lblPrescriptionType.AutoSize = true;
            this.lblPrescriptionType.Location = new System.Drawing.Point(6, 24);
            this.lblPrescriptionType.Name = "lblPrescriptionType";
            this.lblPrescriptionType.Size = new System.Drawing.Size(92, 13);
            this.lblPrescriptionType.TabIndex = 1;
            this.lblPrescriptionType.Text = "Prescription Type:";
            // 
            // cboPrescriptionTypes
            // 
            this.cboPrescriptionTypes.FormattingEnabled = true;
            this.cboPrescriptionTypes.Location = new System.Drawing.Point(104, 16);
            this.cboPrescriptionTypes.Name = "cboPrescriptionTypes";
            this.cboPrescriptionTypes.Size = new System.Drawing.Size(176, 21);
            this.cboPrescriptionTypes.TabIndex = 0;
            this.cboPrescriptionTypes.SelectedIndexChanged += new System.EventHandler(this.cboTipoReceta_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.dgvPrescription);
            this.groupBox2.Location = new System.Drawing.Point(13, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(372, 205);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total de recetas:";
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.AllowUserToAddRows = false;
            this.dgvPrescription.AllowUserToDeleteRows = false;
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colTipo,
            this.colCheff,
            this.colBorrar});
            this.dgvPrescription.Location = new System.Drawing.Point(21, 29);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.ReadOnly = true;
            this.dgvPrescription.Size = new System.Drawing.Size(479, 165);
            this.dgvPrescription.TabIndex = 0;
            this.dgvPrescription.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo Receta";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colCheff
            // 
            this.colCheff.HeaderText = "Cheff";
            this.colCheff.Name = "colCheff";
            this.colCheff.ReadOnly = true;
            // 
            // colBorrar
            // 
            this.colBorrar.HeaderText = "";
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.ReadOnly = true;
            this.colBorrar.Text = "Eliminar";
            this.colBorrar.UseColumnTextForButtonValue = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(426, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 350);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nueva Receta";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // cboIngredients
            // 
            this.cboIngredients.FormattingEnabled = true;
            this.cboIngredients.Location = new System.Drawing.Point(116, 1);
            this.cboIngredients.Name = "cboIngredients";
            this.cboIngredients.Size = new System.Drawing.Size(176, 21);
            this.cboIngredients.TabIndex = 6;
            this.cboIngredients.SelectedIndexChanged += new System.EventHandler(this.cboIngredientes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingredients";
            // 
            // FrmConsultarRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 378);
            this.Controls.Add(this.cboIngredients);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultarRecetas";
            this.Text = "Consultar recetas";
            this.Load += new System.EventHandler(this.FrmConsultarRecetas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNamePrescription;
        private System.Windows.Forms.Label lblPrescriptionType;
        private System.Windows.Forms.ComboBox cboPrescriptionTypes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPrescription;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheff;
        private System.Windows.Forms.DataGridViewButtonColumn colBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label Cheff;
        private System.Windows.Forms.TextBox txtCheff;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboIngredients;
        private System.Windows.Forms.Label label3;
    }
}