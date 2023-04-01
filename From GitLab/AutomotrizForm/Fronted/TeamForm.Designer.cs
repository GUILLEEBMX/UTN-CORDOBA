namespace AutomotrizForm.Fronted
{
    partial class TeamForm
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
            this.txtFranco = new System.Windows.Forms.TextBox();
            this.txtGuillee = new System.Windows.Forms.TextBox();
            this.txtIgnacio = new System.Windows.Forms.TextBox();
            this.txtJuan = new System.Windows.Forms.TextBox();
            this.txtAugusto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFranco);
            this.groupBox1.Controls.Add(this.txtGuillee);
            this.groupBox1.Controls.Add(this.txtIgnacio);
            this.groupBox1.Controls.Add(this.txtJuan);
            this.groupBox1.Controls.Add(this.txtAugusto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipo:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFranco
            // 
            this.txtFranco.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFranco.Location = new System.Drawing.Point(544, 22);
            this.txtFranco.Multiline = true;
            this.txtFranco.Name = "txtFranco";
            this.txtFranco.ReadOnly = true;
            this.txtFranco.Size = new System.Drawing.Size(226, 189);
            this.txtFranco.TabIndex = 4;
            // 
            // txtGuillee
            // 
            this.txtGuillee.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGuillee.Location = new System.Drawing.Point(269, 87);
            this.txtGuillee.Multiline = true;
            this.txtGuillee.Name = "txtGuillee";
            this.txtGuillee.ReadOnly = true;
            this.txtGuillee.Size = new System.Drawing.Size(260, 231);
            this.txtGuillee.TabIndex = 3;
            // 
            // txtIgnacio
            // 
            this.txtIgnacio.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIgnacio.Location = new System.Drawing.Point(544, 217);
            this.txtIgnacio.Multiline = true;
            this.txtIgnacio.Name = "txtIgnacio";
            this.txtIgnacio.ReadOnly = true;
            this.txtIgnacio.Size = new System.Drawing.Size(226, 203);
            this.txtIgnacio.TabIndex = 2;
            // 
            // txtJuan
            // 
            this.txtJuan.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJuan.Location = new System.Drawing.Point(22, 207);
            this.txtJuan.Multiline = true;
            this.txtJuan.Name = "txtJuan";
            this.txtJuan.ReadOnly = true;
            this.txtJuan.Size = new System.Drawing.Size(232, 213);
            this.txtJuan.TabIndex = 1;
            // 
            // txtAugusto
            // 
            this.txtAugusto.BackColor = System.Drawing.SystemColors.Control;
            this.txtAugusto.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAugusto.ForeColor = System.Drawing.Color.Black;
            this.txtAugusto.Location = new System.Drawing.Point(22, 22);
            this.txtAugusto.Multiline = true;
            this.txtAugusto.Name = "txtAugusto";
            this.txtAugusto.ReadOnly = true;
            this.txtAugusto.Size = new System.Drawing.Size(232, 179);
            this.txtAugusto.TabIndex = 0;
            this.txtAugusto.TextChanged += new System.EventHandler(this.txtAugusto_TextChanged);
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.Load += new System.EventHandler(this.TeamForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtFranco;
        private TextBox txtGuillee;
        private TextBox txtIgnacio;
        private TextBox txtJuan;
        private TextBox txtAugusto;
    }
}