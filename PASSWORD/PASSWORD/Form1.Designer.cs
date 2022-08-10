namespace PASSWORD
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.lbl_VALIDARTUPASSWORD = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.btn_ACEPTAR = new System.Windows.Forms.Button();
            this.lbl_GENERARPASSWORD = new System.Windows.Forms.Label();
            this.btn_ALEATORIO = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(18, 12);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.ReadOnly = true;
            this.txt_1.Size = new System.Drawing.Size(249, 52);
            this.txt_1.TabIndex = 0;
            this.txt_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_VALIDARTUPASSWORD
            // 
            this.lbl_VALIDARTUPASSWORD.AutoSize = true;
            this.lbl_VALIDARTUPASSWORD.Location = new System.Drawing.Point(3, 114);
            this.lbl_VALIDARTUPASSWORD.Name = "lbl_VALIDARTUPASSWORD";
            this.lbl_VALIDARTUPASSWORD.Size = new System.Drawing.Size(137, 13);
            this.lbl_VALIDARTUPASSWORD.TabIndex = 1;
            this.lbl_VALIDARTUPASSWORD.Text = "VALIDAR TU PASSWORD";
            this.lbl_VALIDARTUPASSWORD.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(146, 111);
            this.txt_2.Multiline = true;
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(126, 29);
            this.txt_2.TabIndex = 2;
            this.txt_2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btn_ACEPTAR
            // 
            this.btn_ACEPTAR.Location = new System.Drawing.Point(146, 146);
            this.btn_ACEPTAR.Name = "btn_ACEPTAR";
            this.btn_ACEPTAR.Size = new System.Drawing.Size(121, 36);
            this.btn_ACEPTAR.TabIndex = 3;
            this.btn_ACEPTAR.Text = "VALIDAR";
            this.btn_ACEPTAR.UseVisualStyleBackColor = true;
            this.btn_ACEPTAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_GENERARPASSWORD
            // 
            this.lbl_GENERARPASSWORD.AutoSize = true;
            this.lbl_GENERARPASSWORD.Location = new System.Drawing.Point(3, 218);
            this.lbl_GENERARPASSWORD.Name = "lbl_GENERARPASSWORD";
            this.lbl_GENERARPASSWORD.Size = new System.Drawing.Size(126, 13);
            this.lbl_GENERARPASSWORD.TabIndex = 4;
            this.lbl_GENERARPASSWORD.Text = "GENERAR PASSWORD";
            this.lbl_GENERARPASSWORD.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_ALEATORIO
            // 
            this.btn_ALEATORIO.Location = new System.Drawing.Point(146, 195);
            this.btn_ALEATORIO.Name = "btn_ALEATORIO";
            this.btn_ALEATORIO.Size = new System.Drawing.Size(121, 36);
            this.btn_ALEATORIO.TabIndex = 5;
            this.btn_ALEATORIO.Text = "ALEATORIO";
            this.btn_ALEATORIO.UseVisualStyleBackColor = true;
            this.btn_ALEATORIO.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "EL PASSWORD ES FUERTE";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_ALEATORIO);
            this.Controls.Add(this.lbl_GENERARPASSWORD);
            this.Controls.Add(this.btn_ACEPTAR);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.lbl_VALIDARTUPASSWORD);
            this.Controls.Add(this.txt_1);
            this.Name = "Form1";
            this.Text = "PASSWORD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label lbl_VALIDARTUPASSWORD;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Button btn_ACEPTAR;
        private System.Windows.Forms.Label lbl_GENERARPASSWORD;
        private System.Windows.Forms.Button btn_ALEATORIO;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

