
namespace PPE_Salons
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_box__identifiant = new System.Windows.Forms.TextBox();
            this.txt_box__password = new System.Windows.Forms.TextBox();
            this.lbl__identifiant = new System.Windows.Forms.Label();
            this.lbl__password = new System.Windows.Forms.Label();
            this.btn__to_login = new System.Windows.Forms.Button();
            this.btn__to_cancel = new System.Windows.Forms.Button();
            this.lbl__error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_box__identifiant
            // 
            this.txt_box__identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_box__identifiant.Location = new System.Drawing.Point(382, 83);
            this.txt_box__identifiant.Name = "txt_box__identifiant";
            this.txt_box__identifiant.Size = new System.Drawing.Size(240, 35);
            this.txt_box__identifiant.TabIndex = 0;
            // 
            // txt_box__password
            // 
            this.txt_box__password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_box__password.Location = new System.Drawing.Point(382, 167);
            this.txt_box__password.Name = "txt_box__password";
            this.txt_box__password.PasswordChar = '*';
            this.txt_box__password.Size = new System.Drawing.Size(240, 35);
            this.txt_box__password.TabIndex = 2;
            // 
            // lbl__identifiant
            // 
            this.lbl__identifiant.AutoSize = true;
            this.lbl__identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl__identifiant.Location = new System.Drawing.Point(164, 86);
            this.lbl__identifiant.Name = "lbl__identifiant";
            this.lbl__identifiant.Size = new System.Drawing.Size(116, 29);
            this.lbl__identifiant.TabIndex = 3;
            this.lbl__identifiant.Text = "Identifiant";
            // 
            // lbl__password
            // 
            this.lbl__password.AutoSize = true;
            this.lbl__password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl__password.Location = new System.Drawing.Point(164, 170);
            this.lbl__password.Name = "lbl__password";
            this.lbl__password.Size = new System.Drawing.Size(158, 29);
            this.lbl__password.TabIndex = 4;
            this.lbl__password.Text = "Mot de passe";
            // 
            // btn__to_login
            // 
            this.btn__to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn__to_login.Location = new System.Drawing.Point(453, 325);
            this.btn__to_login.Name = "btn__to_login";
            this.btn__to_login.Size = new System.Drawing.Size(169, 47);
            this.btn__to_login.TabIndex = 5;
            this.btn__to_login.Text = "Se connecter";
            this.btn__to_login.UseVisualStyleBackColor = true;
            this.btn__to_login.Click += new System.EventHandler(this.click__btn__to_login);
            // 
            // btn__to_cancel
            // 
            this.btn__to_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn__to_cancel.Location = new System.Drawing.Point(169, 327);
            this.btn__to_cancel.Name = "btn__to_cancel";
            this.btn__to_cancel.Size = new System.Drawing.Size(169, 45);
            this.btn__to_cancel.TabIndex = 6;
            this.btn__to_cancel.Text = "Annuler";
            this.btn__to_cancel.UseVisualStyleBackColor = true;
            this.btn__to_cancel.Click += new System.EventHandler(this.click__btn__to_cancel);
            // 
            // lbl__error
            // 
            this.lbl__error.AutoSize = true;
            this.lbl__error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl__error.ForeColor = System.Drawing.Color.Red;
            this.lbl__error.Location = new System.Drawing.Point(291, 244);
            this.lbl__error.Name = "lbl__error";
            this.lbl__error.Size = new System.Drawing.Size(0, 29);
            this.lbl__error.TabIndex = 7;
            this.lbl__error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl__error);
            this.Controls.Add(this.btn__to_cancel);
            this.Controls.Add(this.btn__to_login);
            this.Controls.Add(this.lbl__password);
            this.Controls.Add(this.lbl__identifiant);
            this.Controls.Add(this.txt_box__password);
            this.Controls.Add(this.txt_box__identifiant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login - BelleTable";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_box__identifiant;
        private System.Windows.Forms.TextBox txt_box__password;
        private System.Windows.Forms.Label lbl__identifiant;
        private System.Windows.Forms.Label lbl__password;
        private System.Windows.Forms.Button btn__to_login;
        private System.Windows.Forms.Button btn__to_cancel;
        private System.Windows.Forms.Label lbl__error;
    }
}