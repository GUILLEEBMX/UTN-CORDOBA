namespace AutomotrizForm.Fronted
{
    partial class QueriesListForm
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
            this.txtEnunciados = new System.Windows.Forms.TextBox();
            this.dgvQueries = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThirthQueryFranco = new System.Windows.Forms.Button();
            this.btnSecondQueryFranco = new System.Windows.Forms.Button();
            this.btnFirstQueryFranco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEnunciados
            // 
            this.txtEnunciados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEnunciados.Location = new System.Drawing.Point(6, 22);
            this.txtEnunciados.Multiline = true;
            this.txtEnunciados.Name = "txtEnunciados";
            this.txtEnunciados.ReadOnly = true;
            this.txtEnunciados.Size = new System.Drawing.Size(496, 205);
            this.txtEnunciados.TabIndex = 0;
            // 
            // dgvQueries
            // 
            this.dgvQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueries.Location = new System.Drawing.Point(12, 281);
            this.dgvQueries.Name = "dgvQueries";
            this.dgvQueries.RowTemplate.Height = 25;
            this.dgvQueries.Size = new System.Drawing.Size(762, 157);
            this.dgvQueries.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThirthQueryFranco);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnSecondQueryFranco);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnFirstQueryFranco);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Consultas:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Tercera";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Segunda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Primera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEnunciados);
            this.groupBox2.Location = new System.Drawing.Point(257, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enunciados :";
            // 
            // btnThirthQueryFranco
            // 
            this.btnThirthQueryFranco.Location = new System.Drawing.Point(6, 167);
            this.btnThirthQueryFranco.Name = "btnThirthQueryFranco";
            this.btnThirthQueryFranco.Size = new System.Drawing.Size(75, 23);
            this.btnThirthQueryFranco.TabIndex = 7;
            this.btnThirthQueryFranco.Text = "Sexta";
            this.btnThirthQueryFranco.UseVisualStyleBackColor = true;
            // 
            // btnSecondQueryFranco
            // 
            this.btnSecondQueryFranco.Location = new System.Drawing.Point(6, 138);
            this.btnSecondQueryFranco.Name = "btnSecondQueryFranco";
            this.btnSecondQueryFranco.Size = new System.Drawing.Size(75, 23);
            this.btnSecondQueryFranco.TabIndex = 6;
            this.btnSecondQueryFranco.Text = "Quinta";
            this.btnSecondQueryFranco.UseVisualStyleBackColor = true;
            // 
            // btnFirstQueryFranco
            // 
            this.btnFirstQueryFranco.Location = new System.Drawing.Point(6, 109);
            this.btnFirstQueryFranco.Name = "btnFirstQueryFranco";
            this.btnFirstQueryFranco.Size = new System.Drawing.Size(75, 23);
            this.btnFirstQueryFranco.TabIndex = 5;
            this.btnFirstQueryFranco.Text = "Cuarta";
            this.btnFirstQueryFranco.UseVisualStyleBackColor = true;
            // 
            // QueriesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvQueries);
            this.Name = "QueriesListForm";
            this.Text = "QueriesListForm";
            this.Load += new System.EventHandler(this.QueriesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtEnunciados;
        private DataGridView dgvQueries;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnThirthQueryFranco;
        private Button btnSecondQueryFranco;
        private Button btnFirstQueryFranco;
    }
}