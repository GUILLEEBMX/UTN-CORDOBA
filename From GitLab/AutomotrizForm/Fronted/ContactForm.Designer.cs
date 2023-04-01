namespace AutomotrizForm.Fronted
{
    partial class ContactForm
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
            this.Contactese = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.Contactese.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contactese
            // 
            this.Contactese.Controls.Add(this.btnSend);
            this.Contactese.Controls.Add(this.txtMensaje);
            this.Contactese.Controls.Add(this.txtEmail);
            this.Contactese.Controls.Add(this.lblMessage);
            this.Contactese.Controls.Add(this.lblEmail);
            this.Contactese.Location = new System.Drawing.Point(25, 34);
            this.Contactese.Name = "Contactese";
            this.Contactese.Size = new System.Drawing.Size(706, 386);
            this.Contactese.TabIndex = 0;
            this.Contactese.TabStop = false;
            this.Contactese.Text = "Contacto :";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(302, 337);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(82, 80);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(578, 226);
            this.txtMensaje.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(578, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(19, 83);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(57, 15);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Mensaje :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email : ";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contactese);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.Contactese.ResumeLayout(false);
            this.Contactese.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Contactese;
        private Button btnSend;
        private TextBox txtMensaje;
        private TextBox txtEmail;
        private Label lblMessage;
        private Label lblEmail;
    }
}