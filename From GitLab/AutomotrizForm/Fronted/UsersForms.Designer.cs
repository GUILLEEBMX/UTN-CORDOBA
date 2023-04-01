namespace AutomotrizForm.Fronted
{
    partial class UsersForms
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreRegisterUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreRegisterUser = new System.Windows.Forms.TextBox();
            this.txtEmailAdmin = new System.Windows.Forms.TextBox();
            this.txtDeleteAdmin = new System.Windows.Forms.TextBox();
            this.txtEmailDeleteUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEsAdminRegisterUser = new System.Windows.Forms.ComboBox();
            this.lblEsAdminRegisterUser = new System.Windows.Forms.Label();
            this.lblPasswordRegisterUser = new System.Windows.Forms.Label();
            this.txtPasswordRegisterUser = new System.Windows.Forms.TextBox();
            this.AceptRegister = new System.Windows.Forms.Button();
            this.txtEmailRegisterUser = new System.Windows.Forms.TextBox();
            this.lblEmailRegisterUser = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAceptRegisterAdmin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAceptDeleteAdmin = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAceptDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.dataGridViewTextBoxColumn1});
            this.dgvUsers.Location = new System.Drawing.Point(22, 330);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(680, 150);
            this.dgvUsers.TabIndex = 0;
            // 
            // Email
            // 
            this.Email.HeaderText = "Nombre";
            this.Email.Name = "Email";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Email";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // lblNombreRegisterUser
            // 
            this.lblNombreRegisterUser.AutoSize = true;
            this.lblNombreRegisterUser.Location = new System.Drawing.Point(6, 30);
            this.lblNombreRegisterUser.Name = "lblNombreRegisterUser";
            this.lblNombreRegisterUser.Size = new System.Drawing.Size(57, 15);
            this.lblNombreRegisterUser.TabIndex = 1;
            this.lblNombreRegisterUser.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // txtNombreRegisterUser
            // 
            this.txtNombreRegisterUser.Location = new System.Drawing.Point(85, 27);
            this.txtNombreRegisterUser.Name = "txtNombreRegisterUser";
            this.txtNombreRegisterUser.Size = new System.Drawing.Size(256, 23);
            this.txtNombreRegisterUser.TabIndex = 7;
            // 
            // txtEmailAdmin
            // 
            this.txtEmailAdmin.Location = new System.Drawing.Point(85, 22);
            this.txtEmailAdmin.Name = "txtEmailAdmin";
            this.txtEmailAdmin.Size = new System.Drawing.Size(256, 23);
            this.txtEmailAdmin.TabIndex = 8;
            // 
            // txtDeleteAdmin
            // 
            this.txtDeleteAdmin.Location = new System.Drawing.Point(85, 24);
            this.txtDeleteAdmin.Name = "txtDeleteAdmin";
            this.txtDeleteAdmin.Size = new System.Drawing.Size(256, 23);
            this.txtDeleteAdmin.TabIndex = 10;
            // 
            // txtEmailDeleteUser
            // 
            this.txtEmailDeleteUser.Location = new System.Drawing.Point(51, 30);
            this.txtEmailDeleteUser.Name = "txtEmailDeleteUser";
            this.txtEmailDeleteUser.Size = new System.Drawing.Size(249, 23);
            this.txtEmailDeleteUser.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEsAdminRegisterUser);
            this.groupBox1.Controls.Add(this.lblEsAdminRegisterUser);
            this.groupBox1.Controls.Add(this.lblPasswordRegisterUser);
            this.groupBox1.Controls.Add(this.txtPasswordRegisterUser);
            this.groupBox1.Controls.Add(this.AceptRegister);
            this.groupBox1.Controls.Add(this.txtEmailRegisterUser);
            this.groupBox1.Controls.Add(this.lblEmailRegisterUser);
            this.groupBox1.Controls.Add(this.lblNombreRegisterUser);
            this.groupBox1.Controls.Add(this.txtNombreRegisterUser);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 211);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Users:";
            // 
            // cboEsAdminRegisterUser
            // 
            this.cboEsAdminRegisterUser.FormattingEnabled = true;
            this.cboEsAdminRegisterUser.Location = new System.Drawing.Point(85, 120);
            this.cboEsAdminRegisterUser.Name = "cboEsAdminRegisterUser";
            this.cboEsAdminRegisterUser.Size = new System.Drawing.Size(121, 23);
            this.cboEsAdminRegisterUser.TabIndex = 21;
            // 
            // lblEsAdminRegisterUser
            // 
            this.lblEsAdminRegisterUser.AutoSize = true;
            this.lblEsAdminRegisterUser.Location = new System.Drawing.Point(6, 123);
            this.lblEsAdminRegisterUser.Name = "lblEsAdminRegisterUser";
            this.lblEsAdminRegisterUser.Size = new System.Drawing.Size(60, 15);
            this.lblEsAdminRegisterUser.TabIndex = 20;
            this.lblEsAdminRegisterUser.Text = "EsAdmin :";
            // 
            // lblPasswordRegisterUser
            // 
            this.lblPasswordRegisterUser.AutoSize = true;
            this.lblPasswordRegisterUser.Location = new System.Drawing.Point(6, 91);
            this.lblPasswordRegisterUser.Name = "lblPasswordRegisterUser";
            this.lblPasswordRegisterUser.Size = new System.Drawing.Size(63, 15);
            this.lblPasswordRegisterUser.TabIndex = 19;
            this.lblPasswordRegisterUser.Text = "Password :";
            // 
            // txtPasswordRegisterUser
            // 
            this.txtPasswordRegisterUser.Location = new System.Drawing.Point(85, 88);
            this.txtPasswordRegisterUser.Name = "txtPasswordRegisterUser";
            this.txtPasswordRegisterUser.Size = new System.Drawing.Size(256, 23);
            this.txtPasswordRegisterUser.TabIndex = 18;
            // 
            // AceptRegister
            // 
            this.AceptRegister.Location = new System.Drawing.Point(144, 166);
            this.AceptRegister.Name = "AceptRegister";
            this.AceptRegister.Size = new System.Drawing.Size(75, 23);
            this.AceptRegister.TabIndex = 17;
            this.AceptRegister.Text = "Aceptar";
            this.AceptRegister.UseVisualStyleBackColor = true;
            this.AceptRegister.Click += new System.EventHandler(this.AceptRegister_Click);
            // 
            // txtEmailRegisterUser
            // 
            this.txtEmailRegisterUser.Location = new System.Drawing.Point(85, 59);
            this.txtEmailRegisterUser.Name = "txtEmailRegisterUser";
            this.txtEmailRegisterUser.Size = new System.Drawing.Size(256, 23);
            this.txtEmailRegisterUser.TabIndex = 9;
            // 
            // lblEmailRegisterUser
            // 
            this.lblEmailRegisterUser.AutoSize = true;
            this.lblEmailRegisterUser.Location = new System.Drawing.Point(6, 62);
            this.lblEmailRegisterUser.Name = "lblEmailRegisterUser";
            this.lblEmailRegisterUser.Size = new System.Drawing.Size(42, 15);
            this.lblEmailRegisterUser.TabIndex = 8;
            this.lblEmailRegisterUser.Text = "Email :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAceptRegisterAdmin);
            this.groupBox2.Controls.Add(this.txtEmailAdmin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 85);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register Admin";
            // 
            // btnAceptRegisterAdmin
            // 
            this.btnAceptRegisterAdmin.Location = new System.Drawing.Point(131, 53);
            this.btnAceptRegisterAdmin.Name = "btnAceptRegisterAdmin";
            this.btnAceptRegisterAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAceptRegisterAdmin.TabIndex = 22;
            this.btnAceptRegisterAdmin.Text = "Aceptar";
            this.btnAceptRegisterAdmin.UseVisualStyleBackColor = true;
            this.btnAceptRegisterAdmin.Click += new System.EventHandler(this.btnAceptRegisterAdmin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAceptDeleteAdmin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDeleteAdmin);
            this.groupBox3.Location = new System.Drawing.Point(438, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 98);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Admin";
            // 
            // btnAceptDeleteAdmin
            // 
            this.btnAceptDeleteAdmin.Location = new System.Drawing.Point(136, 69);
            this.btnAceptDeleteAdmin.Name = "btnAceptDeleteAdmin";
            this.btnAceptDeleteAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAceptDeleteAdmin.TabIndex = 18;
            this.btnAceptDeleteAdmin.Text = "Borrar";
            this.btnAceptDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnAceptDeleteAdmin.Click += new System.EventHandler(this.btnAceptDeleteAdmin_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAceptDeleteUser);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtEmailDeleteUser);
            this.groupBox4.Location = new System.Drawing.Point(438, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 105);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete User";
            // 
            // btnAceptDeleteUser
            // 
            this.btnAceptDeleteUser.Location = new System.Drawing.Point(136, 76);
            this.btnAceptDeleteUser.Name = "btnAceptDeleteUser";
            this.btnAceptDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnAceptDeleteUser.TabIndex = 18;
            this.btnAceptDeleteUser.Text = "Borrar";
            this.btnAceptDeleteUser.UseVisualStyleBackColor = true;
            this.btnAceptDeleteUser.Click += new System.EventHandler(this.btnAceptDeleteUser_Click);
            // 
            // UsersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "UsersForms";
            this.Text = "UsersForms";
            this.Load += new System.EventHandler(this.UsersForms_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvUsers;
        private Label lblNombreRegisterUser;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox txtNombreRegisterUser;
        private TextBox txtEmailAdmin;
        private TextBox txtDeleteAdmin;
        private TextBox txtEmailDeleteUser;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtEmailRegisterUser;
        private Label lblEmailRegisterUser;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button AceptRegister;
        private Label lblEsAdminRegisterUser;
        private Label lblPasswordRegisterUser;
        private TextBox txtPasswordRegisterUser;
        private ComboBox cboEsAdminRegisterUser;
        private Button btnAceptRegisterAdmin;
        private Button btnAceptDeleteAdmin;
        private Button btnAceptDeleteUser;
    }
}