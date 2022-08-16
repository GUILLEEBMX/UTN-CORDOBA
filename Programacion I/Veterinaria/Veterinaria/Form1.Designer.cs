
namespace Veterinaria
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
            this.LBL_Codigo = new System.Windows.Forms.Label();
            this.LBL_Sexo = new System.Windows.Forms.Label();
            this.LBL_Especie = new System.Windows.Forms.Label();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.TXT_Codigo = new System.Windows.Forms.TextBox();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.CBO_Especie = new System.Windows.Forms.ComboBox();
            this.RDBT_Macho = new System.Windows.Forms.RadioButton();
            this.RDBT_Hembra = new System.Windows.Forms.RadioButton();
            this.LST_Mascotas = new System.Windows.Forms.ListBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DT_Picker = new System.Windows.Forms.Label();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.BTN_Record = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Codigo
            // 
            this.LBL_Codigo.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.LBL_Codigo.AutoSize = true;
            this.LBL_Codigo.Location = new System.Drawing.Point(22, 45);
            this.LBL_Codigo.Name = "LBL_Codigo";
            this.LBL_Codigo.Size = new System.Drawing.Size(43, 13);
            this.LBL_Codigo.TabIndex = 0;
            this.LBL_Codigo.Text = "Codigo:";
            // 
            // LBL_Sexo
            // 
            this.LBL_Sexo.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.LBL_Sexo.AutoSize = true;
            this.LBL_Sexo.Location = new System.Drawing.Point(22, 144);
            this.LBL_Sexo.Name = "LBL_Sexo";
            this.LBL_Sexo.Size = new System.Drawing.Size(34, 13);
            this.LBL_Sexo.TabIndex = 2;
            this.LBL_Sexo.Text = "Sexo:";
            // 
            // LBL_Especie
            // 
            this.LBL_Especie.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.LBL_Especie.AutoSize = true;
            this.LBL_Especie.Location = new System.Drawing.Point(17, 108);
            this.LBL_Especie.Name = "LBL_Especie";
            this.LBL_Especie.Size = new System.Drawing.Size(48, 13);
            this.LBL_Especie.TabIndex = 3;
            this.LBL_Especie.Text = "Especie:";
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(22, 73);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(47, 13);
            this.LBL_Nombre.TabIndex = 4;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // TXT_Codigo
            // 
            this.TXT_Codigo.Location = new System.Drawing.Point(94, 38);
            this.TXT_Codigo.Name = "TXT_Codigo";
            this.TXT_Codigo.Size = new System.Drawing.Size(162, 20);
            this.TXT_Codigo.TabIndex = 5;
            this.TXT_Codigo.TextChanged += new System.EventHandler(this.TXT_Codigo_TextChanged);
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(94, 70);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(162, 20);
            this.TXT_Name.TabIndex = 6;
            // 
            // CBO_Especie
            // 
            this.CBO_Especie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_Especie.FormattingEnabled = true;
            this.CBO_Especie.Location = new System.Drawing.Point(94, 100);
            this.CBO_Especie.Name = "CBO_Especie";
            this.CBO_Especie.Size = new System.Drawing.Size(162, 21);
            this.CBO_Especie.TabIndex = 7;
            this.CBO_Especie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RDBT_Macho
            // 
            this.RDBT_Macho.AutoSize = true;
            this.RDBT_Macho.Location = new System.Drawing.Point(94, 142);
            this.RDBT_Macho.Name = "RDBT_Macho";
            this.RDBT_Macho.Size = new System.Drawing.Size(67, 17);
            this.RDBT_Macho.TabIndex = 8;
            this.RDBT_Macho.TabStop = true;
            this.RDBT_Macho.Text = "1-Macho";
            this.RDBT_Macho.UseVisualStyleBackColor = true;
            // 
            // RDBT_Hembra
            // 
            this.RDBT_Hembra.AutoSize = true;
            this.RDBT_Hembra.Location = new System.Drawing.Point(185, 142);
            this.RDBT_Hembra.Name = "RDBT_Hembra";
            this.RDBT_Hembra.Size = new System.Drawing.Size(71, 17);
            this.RDBT_Hembra.TabIndex = 9;
            this.RDBT_Hembra.TabStop = true;
            this.RDBT_Hembra.Text = "2-Hembra";
            this.RDBT_Hembra.UseVisualStyleBackColor = true;
            // 
            // LST_Mascotas
            // 
            this.LST_Mascotas.FormattingEnabled = true;
            this.LST_Mascotas.Location = new System.Drawing.Point(550, 38);
            this.LST_Mascotas.Name = "LST_Mascotas";
            this.LST_Mascotas.Size = new System.Drawing.Size(221, 368);
            this.LST_Mascotas.TabIndex = 10;
            this.LST_Mascotas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(68, 176);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 11;
            // 
            // DT_Picker
            // 
            this.DT_Picker.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.DT_Picker.AutoSize = true;
            this.DT_Picker.Location = new System.Drawing.Point(22, 176);
            this.DT_Picker.Name = "DT_Picker";
            this.DT_Picker.Size = new System.Drawing.Size(40, 13);
            this.DT_Picker.TabIndex = 12;
            this.DT_Picker.Text = "Fecha:";
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.Location = new System.Drawing.Point(25, 323);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(75, 23);
            this.BTN_NEW.TabIndex = 13;
            this.BTN_NEW.Text = "NEW";
            this.BTN_NEW.UseVisualStyleBackColor = true;
            // 
            // BTN_Record
            // 
            this.BTN_Record.Location = new System.Drawing.Point(129, 323);
            this.BTN_Record.Name = "BTN_Record";
            this.BTN_Record.Size = new System.Drawing.Size(75, 23);
            this.BTN_Record.TabIndex = 14;
            this.BTN_Record.Text = "RECORD";
            this.BTN_Record.UseVisualStyleBackColor = true;
            this.BTN_Record.Click += new System.EventHandler(this.BTN_Record_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Location = new System.Drawing.Point(223, 323);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Exit.TabIndex = 15;
            this.BTN_Exit.Text = "EXIT";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Record);
            this.Controls.Add(this.BTN_NEW);
            this.Controls.Add(this.DT_Picker);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.LST_Mascotas);
            this.Controls.Add(this.RDBT_Hembra);
            this.Controls.Add(this.RDBT_Macho);
            this.Controls.Add(this.CBO_Especie);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.TXT_Codigo);
            this.Controls.Add(this.LBL_Nombre);
            this.Controls.Add(this.LBL_Especie);
            this.Controls.Add(this.LBL_Sexo);
            this.Controls.Add(this.LBL_Codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Codigo;
        private System.Windows.Forms.Label LBL_Sexo;
        private System.Windows.Forms.Label LBL_Especie;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TXT_Codigo;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.ComboBox CBO_Especie;
        private System.Windows.Forms.RadioButton RDBT_Macho;
        private System.Windows.Forms.RadioButton RDBT_Hembra;
        private System.Windows.Forms.ListBox LST_Mascotas;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label DT_Picker;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.Button BTN_Record;
        private System.Windows.Forms.Button BTN_Exit;
    }
}

