
namespace PROBLEMA_5._3
{
    partial class Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_CODIGO = new System.Windows.Forms.TextBox();
            this.TXT_DETALLE = new System.Windows.Forms.TextBox();
            this.TXT_PRECIO = new System.Windows.Forms.TextBox();
            this.DATE_PICKER = new System.Windows.Forms.DateTimePicker();
            this.RDBT_NOTEBOOK = new System.Windows.Forms.RadioButton();
            this.RDBT_NETBOOK = new System.Windows.Forms.RadioButton();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_RECORD = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.LstProducts = new System.Windows.Forms.ListBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha:";
            // 
            // TXT_CODIGO
            // 
            this.TXT_CODIGO.Location = new System.Drawing.Point(92, 35);
            this.TXT_CODIGO.Name = "TXT_CODIGO";
            this.TXT_CODIGO.Size = new System.Drawing.Size(224, 20);
            this.TXT_CODIGO.TabIndex = 6;
            this.TXT_CODIGO.TextChanged += new System.EventHandler(this.TXT_CODIGO_TextChanged);
            this.TXT_CODIGO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_CODIGO_KeyPress);
            // 
            // TXT_DETALLE
            // 
            this.TXT_DETALLE.Location = new System.Drawing.Point(92, 61);
            this.TXT_DETALLE.Name = "TXT_DETALLE";
            this.TXT_DETALLE.Size = new System.Drawing.Size(224, 20);
            this.TXT_DETALLE.TabIndex = 7;
            // 
            // TXT_PRECIO
            // 
            this.TXT_PRECIO.Location = new System.Drawing.Point(92, 165);
            this.TXT_PRECIO.Name = "TXT_PRECIO";
            this.TXT_PRECIO.Size = new System.Drawing.Size(224, 20);
            this.TXT_PRECIO.TabIndex = 8;
            this.TXT_PRECIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PRECIO_KeyPress);
            // 
            // DATE_PICKER
            // 
            this.DATE_PICKER.Location = new System.Drawing.Point(92, 193);
            this.DATE_PICKER.Name = "DATE_PICKER";
            this.DATE_PICKER.Size = new System.Drawing.Size(224, 20);
            this.DATE_PICKER.TabIndex = 9;
            // 
            // RDBT_NOTEBOOK
            // 
            this.RDBT_NOTEBOOK.AutoSize = true;
            this.RDBT_NOTEBOOK.Location = new System.Drawing.Point(119, 132);
            this.RDBT_NOTEBOOK.Name = "RDBT_NOTEBOOK";
            this.RDBT_NOTEBOOK.Size = new System.Drawing.Size(77, 17);
            this.RDBT_NOTEBOOK.TabIndex = 11;
            this.RDBT_NOTEBOOK.TabStop = true;
            this.RDBT_NOTEBOOK.Text = "NETBOOK";
            this.RDBT_NOTEBOOK.UseVisualStyleBackColor = true;
            // 
            // RDBT_NETBOOK
            // 
            this.RDBT_NETBOOK.AutoSize = true;
            this.RDBT_NETBOOK.Location = new System.Drawing.Point(210, 132);
            this.RDBT_NETBOOK.Name = "RDBT_NETBOOK";
            this.RDBT_NETBOOK.Size = new System.Drawing.Size(85, 17);
            this.RDBT_NETBOOK.TabIndex = 12;
            this.RDBT_NETBOOK.TabStop = true;
            this.RDBT_NETBOOK.Text = "NOTEBOOK";
            this.RDBT_NETBOOK.UseVisualStyleBackColor = true;
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.Location = new System.Drawing.Point(2, 332);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(75, 23);
            this.BTN_NEW.TabIndex = 13;
            this.BTN_NEW.Text = "NEW";
            this.BTN_NEW.UseVisualStyleBackColor = true;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Location = new System.Drawing.Point(245, 332);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.BTN_CANCEL.TabIndex = 14;
            this.BTN_CANCEL.Text = "CANCEL";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_RECORD
            // 
            this.BTN_RECORD.Location = new System.Drawing.Point(83, 332);
            this.BTN_RECORD.Name = "BTN_RECORD";
            this.BTN_RECORD.Size = new System.Drawing.Size(75, 23);
            this.BTN_RECORD.TabIndex = 15;
            this.BTN_RECORD.Text = "RECORD";
            this.BTN_RECORD.UseVisualStyleBackColor = true;
            this.BTN_RECORD.Click += new System.EventHandler(this.BTN_RECORD_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.Location = new System.Drawing.Point(326, 332);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(75, 23);
            this.BTN_EXIT.TabIndex = 16;
            this.BTN_EXIT.Text = "EXIT";
            this.BTN_EXIT.UseVisualStyleBackColor = true;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // LstProducts
            // 
            this.LstProducts.FormattingEnabled = true;
            this.LstProducts.Location = new System.Drawing.Point(500, 12);
            this.LstProducts.Name = "LstProducts";
            this.LstProducts.Size = new System.Drawing.Size(262, 316);
            this.LstProducts.TabIndex = 17;
            this.LstProducts.SelectedIndexChanged += new System.EventHandler(this.Products_SelectedIndexChanged);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(92, 98);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(224, 21);
            this.cboMarca.TabIndex = 18;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "GETALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Location = new System.Drawing.Point(164, 332);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(75, 23);
            this.BTN_DELETE.TabIndex = 20;
            this.BTN_DELETE.Text = "DELETE";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.button2_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.LstProducts);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.BTN_RECORD);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_NEW);
            this.Controls.Add(this.RDBT_NETBOOK);
            this.Controls.Add(this.RDBT_NOTEBOOK);
            this.Controls.Add(this.DATE_PICKER);
            this.Controls.Add(this.TXT_PRECIO);
            this.Controls.Add(this.TXT_DETALLE);
            this.Controls.Add(this.TXT_CODIGO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_CODIGO;
        private System.Windows.Forms.TextBox TXT_DETALLE;
        private System.Windows.Forms.TextBox TXT_PRECIO;
        private System.Windows.Forms.DateTimePicker DATE_PICKER;
        private System.Windows.Forms.RadioButton RDBT_NOTEBOOK;
        private System.Windows.Forms.RadioButton RDBT_NETBOOK;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_RECORD;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.ListBox LstProducts;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_DELETE;
    }
}

