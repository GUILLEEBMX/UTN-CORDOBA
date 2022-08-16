
namespace TP1_Programacion_II
{
    partial class Form1
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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtTituloCarrera = new System.Windows.Forms.TextBox();
            this.lblTituloCarrera = new System.Windows.Forms.Label();
            this.cboAsignaturas = new System.Windows.Forms.ComboBox();
            this.lblAsignaturas = new System.Windows.Forms.Label();
            this.lblAñoCursado = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.txtCuatrimestre = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnRecord = new System.Windows.Forms.Button();
            this.cboCarreras = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(12, 24);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(81, 13);
            this.lblCarrera.TabIndex = 3;
            this.lblCarrera.Text = "Nombre Carrera";
            // 
            // txtTituloCarrera
            // 
            this.txtTituloCarrera.Location = new System.Drawing.Point(99, 47);
            this.txtTituloCarrera.Name = "txtTituloCarrera";
            this.txtTituloCarrera.Size = new System.Drawing.Size(252, 20);
            this.txtTituloCarrera.TabIndex = 4;
            // 
            // lblTituloCarrera
            // 
            this.lblTituloCarrera.AutoSize = true;
            this.lblTituloCarrera.Location = new System.Drawing.Point(12, 50);
            this.lblTituloCarrera.Name = "lblTituloCarrera";
            this.lblTituloCarrera.Size = new System.Drawing.Size(71, 13);
            this.lblTituloCarrera.TabIndex = 5;
            this.lblTituloCarrera.Text = "TItulo Carrera";
            // 
            // cboAsignaturas
            // 
            this.cboAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignaturas.FormattingEnabled = true;
            this.cboAsignaturas.Location = new System.Drawing.Point(99, 161);
            this.cboAsignaturas.Name = "cboAsignaturas";
            this.cboAsignaturas.Size = new System.Drawing.Size(252, 21);
            this.cboAsignaturas.TabIndex = 6;
            this.cboAsignaturas.SelectedIndexChanged += new System.EventHandler(this.cboAsignaturas_SelectedIndexChanged);
            // 
            // lblAsignaturas
            // 
            this.lblAsignaturas.AutoSize = true;
            this.lblAsignaturas.Location = new System.Drawing.Point(12, 161);
            this.lblAsignaturas.Name = "lblAsignaturas";
            this.lblAsignaturas.Size = new System.Drawing.Size(62, 13);
            this.lblAsignaturas.TabIndex = 7;
            this.lblAsignaturas.Text = "Asignaturas";
            // 
            // lblAñoCursado
            // 
            this.lblAñoCursado.AutoSize = true;
            this.lblAñoCursado.Location = new System.Drawing.Point(12, 76);
            this.lblAñoCursado.Name = "lblAñoCursado";
            this.lblAñoCursado.Size = new System.Drawing.Size(68, 13);
            this.lblAñoCursado.TabIndex = 9;
            this.lblAñoCursado.Text = "Año Cursado";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(12, 102);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lblCuatrimestre.TabIndex = 10;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(99, 102);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(252, 20);
            this.txtCuatrimestre.TabIndex = 11;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(99, 128);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(252, 20);
            this.txtMateria.TabIndex = 12;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(12, 128);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 13;
            this.lblMateria.Text = "Materia";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(99, 76);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(252, 20);
            this.datePicker.TabIndex = 14;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(203, 249);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 15;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // cboCarreras
            // 
            this.cboCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarreras.FormattingEnabled = true;
            this.cboCarreras.Location = new System.Drawing.Point(99, 20);
            this.cboCarreras.Name = "cboCarreras";
            this.cboCarreras.Size = new System.Drawing.Size(316, 21);
            this.cboCarreras.TabIndex = 16;
            this.cboCarreras.SelectedIndexChanged += new System.EventHandler(this.cboCarreras_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.cboCarreras);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAñoCursado);
            this.Controls.Add(this.lblAsignaturas);
            this.Controls.Add(this.cboAsignaturas);
            this.Controls.Add(this.lblTituloCarrera);
            this.Controls.Add(this.txtTituloCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtTituloCarrera;
        private System.Windows.Forms.Label lblTituloCarrera;
        private System.Windows.Forms.ComboBox cboAsignaturas;
        private System.Windows.Forms.Label lblAsignaturas;
        private System.Windows.Forms.Label lblAñoCursado;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.ComboBox cboCarreras;
    }
}

