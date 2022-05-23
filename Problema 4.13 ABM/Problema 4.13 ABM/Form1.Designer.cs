
namespace Problema_4._13_ABM
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFallecido = new System.Windows.Forms.Label();
            this.btnNEW = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnRECORD = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.TXTApellido = new System.Windows.Forms.TextBox();
            this.TXTNombres = new System.Windows.Forms.TextBox();
            this.TXTDocumento = new System.Windows.Forms.TextBox();
            this.lstDATOS = new System.Windows.Forms.ListBox();
            this.rdnFEMENINO = new System.Windows.Forms.RadioButton();
            this.rdnMASCULINO = new System.Windows.Forms.RadioButton();
            this.ChecxBoxFallecido = new System.Windows.Forms.CheckBox();
            this.cboTIPODOCUMENTO = new System.Windows.Forms.ComboBox();
            this.cboESTADOCIVIL = new System.Windows.Forms.ComboBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.GET = new System.Windows.Forms.Button();
            this.CleanerInsert = new System.Windows.Forms.Button();
            this.CleanLst = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(33, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres:";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(33, 120);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDocumento.TabIndex = 3;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(33, 159);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(33, 194);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 5;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(33, 226);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblFallecido
            // 
            this.lblFallecido.AutoSize = true;
            this.lblFallecido.Location = new System.Drawing.Point(33, 259);
            this.lblFallecido.Name = "lblFallecido";
            this.lblFallecido.Size = new System.Drawing.Size(52, 13);
            this.lblFallecido.TabIndex = 7;
            this.lblFallecido.Text = "Fallecido:";
            this.lblFallecido.Click += new System.EventHandler(this.lblFallecido_Click);
            // 
            // btnNEW
            // 
            this.btnNEW.Location = new System.Drawing.Point(36, 415);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(75, 23);
            this.btnNEW.TabIndex = 9;
            this.btnNEW.Text = "NEW";
            this.btnNEW.UseVisualStyleBackColor = true;
            this.btnNEW.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.Location = new System.Drawing.Point(117, 415);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(75, 23);
            this.btnEDIT.TabIndex = 10;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(198, 415);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(75, 23);
            this.btnDELETE.TabIndex = 11;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnRECORD
            // 
            this.btnRECORD.Location = new System.Drawing.Point(279, 415);
            this.btnRECORD.Name = "btnRECORD";
            this.btnRECORD.Size = new System.Drawing.Size(75, 23);
            this.btnRECORD.TabIndex = 12;
            this.btnRECORD.Text = "RECORD";
            this.btnRECORD.UseVisualStyleBackColor = true;
            this.btnRECORD.Click += new System.EventHandler(this.btnRECORD_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(360, 415);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(75, 23);
            this.btnCANCEL.TabIndex = 13;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(441, 415);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(75, 23);
            this.btnEXIT.TabIndex = 14;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // TXTApellido
            // 
            this.TXTApellido.Location = new System.Drawing.Point(92, 55);
            this.TXTApellido.Name = "TXTApellido";
            this.TXTApellido.Size = new System.Drawing.Size(237, 20);
            this.TXTApellido.TabIndex = 1;
            this.TXTApellido.TextChanged += new System.EventHandler(this.TXT_APELLIDO_TextChanged);
            this.TXTApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTApellido_KeyPress);
            // 
            // TXTNombres
            // 
            this.TXTNombres.Location = new System.Drawing.Point(91, 81);
            this.TXTNombres.Name = "TXTNombres";
            this.TXTNombres.Size = new System.Drawing.Size(238, 20);
            this.TXTNombres.TabIndex = 2;
            this.TXTNombres.TextChanged += new System.EventHandler(this.TXTNombres_TextChanged);
            // 
            // TXTDocumento
            // 
            this.TXTDocumento.Location = new System.Drawing.Point(104, 152);
            this.TXTDocumento.Name = "TXTDocumento";
            this.TXTDocumento.Size = new System.Drawing.Size(225, 20);
            this.TXTDocumento.TabIndex = 4;
            // 
            // lstDATOS
            // 
            this.lstDATOS.FormattingEnabled = true;
            this.lstDATOS.Location = new System.Drawing.Point(497, 41);
            this.lstDATOS.Name = "lstDATOS";
            this.lstDATOS.Size = new System.Drawing.Size(282, 368);
            this.lstDATOS.TabIndex = 15;
            this.lstDATOS.SelectedIndexChanged += new System.EventHandler(this.ListboxDatos_SelectedIndexChanged);
            // 
            // rdnFEMENINO
            // 
            this.rdnFEMENINO.AutoSize = true;
            this.rdnFEMENINO.Location = new System.Drawing.Point(73, 224);
            this.rdnFEMENINO.Name = "rdnFEMENINO";
            this.rdnFEMENINO.Size = new System.Drawing.Size(71, 17);
            this.rdnFEMENINO.TabIndex = 6;
            this.rdnFEMENINO.TabStop = true;
            this.rdnFEMENINO.Text = "Femenino";
            this.rdnFEMENINO.UseVisualStyleBackColor = true;
            this.rdnFEMENINO.CheckedChanged += new System.EventHandler(this.rdnFEMENINO_CheckedChanged);
            // 
            // rdnMASCULINO
            // 
            this.rdnMASCULINO.AutoSize = true;
            this.rdnMASCULINO.Location = new System.Drawing.Point(150, 224);
            this.rdnMASCULINO.Name = "rdnMASCULINO";
            this.rdnMASCULINO.Size = new System.Drawing.Size(73, 17);
            this.rdnMASCULINO.TabIndex = 7;
            this.rdnMASCULINO.TabStop = true;
            this.rdnMASCULINO.Text = "Masculino";
            this.rdnMASCULINO.UseVisualStyleBackColor = true;
            // 
            // ChecxBoxFallecido
            // 
            this.ChecxBoxFallecido.AutoSize = true;
            this.ChecxBoxFallecido.Location = new System.Drawing.Point(91, 258);
            this.ChecxBoxFallecido.Name = "ChecxBoxFallecido";
            this.ChecxBoxFallecido.Size = new System.Drawing.Size(15, 14);
            this.ChecxBoxFallecido.TabIndex = 8;
            this.ChecxBoxFallecido.UseVisualStyleBackColor = true;
            this.ChecxBoxFallecido.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cboTIPODOCUMENTO
            // 
            this.cboTIPODOCUMENTO.FormattingEnabled = true;
            this.cboTIPODOCUMENTO.Location = new System.Drawing.Point(128, 117);
            this.cboTIPODOCUMENTO.Name = "cboTIPODOCUMENTO";
            this.cboTIPODOCUMENTO.Size = new System.Drawing.Size(212, 21);
            this.cboTIPODOCUMENTO.TabIndex = 3;
            this.cboTIPODOCUMENTO.SelectedIndexChanged += new System.EventHandler(this.cboTIPODOCUMENTO_SelectedIndexChanged);
            // 
            // cboESTADOCIVIL
            // 
            this.cboESTADOCIVIL.FormattingEnabled = true;
            this.cboESTADOCIVIL.Location = new System.Drawing.Point(104, 186);
            this.cboESTADOCIVIL.Name = "cboESTADOCIVIL";
            this.cboESTADOCIVIL.Size = new System.Drawing.Size(225, 21);
            this.cboESTADOCIVIL.TabIndex = 5;
            this.cboESTADOCIVIL.SelectedIndexChanged += new System.EventHandler(this.cboESTADOCIVIL_SelectedIndexChanged);
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(494, 25);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(43, 13);
            this.lblPeople.TabIndex = 29;
            this.lblPeople.Text = "People:";
            this.lblPeople.Click += new System.EventHandler(this.lblPeople_Click);
            // 
            // GET
            // 
            this.GET.Location = new System.Drawing.Point(128, 360);
            this.GET.Name = "GET";
            this.GET.Size = new System.Drawing.Size(75, 23);
            this.GET.TabIndex = 30;
            this.GET.Text = "GET ALL PEOPLE";
            this.GET.UseVisualStyleBackColor = true;
            this.GET.Click += new System.EventHandler(this.button1_Click);
            // 
            // CleanerInsert
            // 
            this.CleanerInsert.Location = new System.Drawing.Point(219, 360);
            this.CleanerInsert.Name = "CleanerInsert";
            this.CleanerInsert.Size = new System.Drawing.Size(75, 23);
            this.CleanerInsert.TabIndex = 31;
            this.CleanerInsert.Text = "CleanerInsert";
            this.CleanerInsert.UseVisualStyleBackColor = true;
            this.CleanerInsert.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CleanLst
            // 
            this.CleanLst.Location = new System.Drawing.Point(36, 360);
            this.CleanLst.Name = "CleanLst";
            this.CleanLst.Size = new System.Drawing.Size(75, 23);
            this.CleanLst.TabIndex = 32;
            this.CleanLst.Text = "CleanLst";
            this.CleanLst.UseVisualStyleBackColor = true;
            this.CleanLst.Click += new System.EventHandler(this.CleanLst_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 301);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(767, 53);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CleanLst);
            this.Controls.Add(this.CleanerInsert);
            this.Controls.Add(this.GET);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.cboESTADOCIVIL);
            this.Controls.Add(this.cboTIPODOCUMENTO);
            this.Controls.Add(this.ChecxBoxFallecido);
            this.Controls.Add(this.rdnMASCULINO);
            this.Controls.Add(this.rdnFEMENINO);
            this.Controls.Add(this.lstDATOS);
            this.Controls.Add(this.TXTDocumento);
            this.Controls.Add(this.TXTNombres);
            this.Controls.Add(this.TXTApellido);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnRECORD);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnNEW);
            this.Controls.Add(this.lblFallecido);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFallecido;
        private System.Windows.Forms.Button btnNEW;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnRECORD;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.TextBox TXTApellido;
        private System.Windows.Forms.TextBox TXTNombres;
        private System.Windows.Forms.TextBox TXTDocumento;
        private System.Windows.Forms.ListBox lstDATOS;
        private System.Windows.Forms.RadioButton rdnFEMENINO;
        private System.Windows.Forms.RadioButton rdnMASCULINO;
        private System.Windows.Forms.CheckBox ChecxBoxFallecido;
        private System.Windows.Forms.ComboBox cboTIPODOCUMENTO;
        private System.Windows.Forms.ComboBox cboESTADOCIVIL;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Button GET;
        private System.Windows.Forms.Button CleanerInsert;
        private System.Windows.Forms.Button CleanLst;
        private System.Windows.Forms.TextBox textBox1;
    }
}

