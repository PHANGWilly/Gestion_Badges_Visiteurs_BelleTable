
namespace PPE_Salons
{
    partial class AjoutEmploye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutEmploye));
            this.lbl__identifiant = new System.Windows.Forms.Label();
            this.txt_box__identifiant = new System.Windows.Forms.TextBox();
            this.lbl__password = new System.Windows.Forms.Label();
            this.txt_box__password = new System.Windows.Forms.TextBox();
            this.lbl__role = new System.Windows.Forms.Label();
            this.combo_box__level = new System.Windows.Forms.ComboBox();
            this.btn__add = new System.Windows.Forms.Button();
            this.btn__cancel = new System.Windows.Forms.Button();
            this.lbl__title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl__identifiant
            // 
            this.lbl__identifiant.AccessibleName = "";
            this.lbl__identifiant.AutoSize = true;
            this.lbl__identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl__identifiant.Location = new System.Drawing.Point(203, 120);
            this.lbl__identifiant.Name = "lbl__identifiant";
            this.lbl__identifiant.Size = new System.Drawing.Size(95, 25);
            this.lbl__identifiant.TabIndex = 0;
            this.lbl__identifiant.Text = "Identifiant";
            this.lbl__identifiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_box__identifiant
            // 
            this.txt_box__identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_box__identifiant.Location = new System.Drawing.Point(208, 148);
            this.txt_box__identifiant.Name = "txt_box__identifiant";
            this.txt_box__identifiant.Size = new System.Drawing.Size(347, 35);
            this.txt_box__identifiant.TabIndex = 1;
            // 
            // lbl__password
            // 
            this.lbl__password.AutoSize = true;
            this.lbl__password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl__password.Location = new System.Drawing.Point(203, 206);
            this.lbl__password.Name = "lbl__password";
            this.lbl__password.Size = new System.Drawing.Size(130, 25);
            this.lbl__password.TabIndex = 2;
            this.lbl__password.Text = "Mot de passe";
            this.lbl__password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl__password.UseWaitCursor = true;
            // 
            // txt_box__password
            // 
            this.txt_box__password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_box__password.Location = new System.Drawing.Point(208, 234);
            this.txt_box__password.Name = "txt_box__password";
            this.txt_box__password.PasswordChar = '*';
            this.txt_box__password.Size = new System.Drawing.Size(347, 35);
            this.txt_box__password.TabIndex = 3;
            // 
            // lbl__role
            // 
            this.lbl__role.AutoSize = true;
            this.lbl__role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl__role.Location = new System.Drawing.Point(204, 295);
            this.lbl__role.Name = "lbl__role";
            this.lbl__role.Size = new System.Drawing.Size(51, 25);
            this.lbl__role.TabIndex = 4;
            this.lbl__role.Text = "Rôle";
            this.lbl__role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_box__level
            // 
            this.combo_box__level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_box__level.FormattingEnabled = true;
            this.combo_box__level.Location = new System.Drawing.Point(208, 323);
            this.combo_box__level.Name = "combo_box__level";
            this.combo_box__level.Size = new System.Drawing.Size(347, 37);
            this.combo_box__level.TabIndex = 5;
            // 
            // btn__add
            // 
            this.btn__add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn__add.Location = new System.Drawing.Point(616, 419);
            this.btn__add.Margin = new System.Windows.Forms.Padding(5);
            this.btn__add.Name = "btn__add";
            this.btn__add.Size = new System.Drawing.Size(121, 44);
            this.btn__add.TabIndex = 6;
            this.btn__add.Text = "Ajouter";
            this.btn__add.UseVisualStyleBackColor = true;
            this.btn__add.Click += new System.EventHandler(this.click__btn_add);
            // 
            // btn__cancel
            // 
            this.btn__cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn__cancel.Location = new System.Drawing.Point(48, 419);
            this.btn__cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn__cancel.Name = "btn__cancel";
            this.btn__cancel.Size = new System.Drawing.Size(111, 44);
            this.btn__cancel.TabIndex = 7;
            this.btn__cancel.Text = "Annuler";
            this.btn__cancel.UseVisualStyleBackColor = true;
            this.btn__cancel.Click += new System.EventHandler(this.click__btn__to_retour);
            // 
            // lbl__title
            // 
            this.lbl__title.AutoSize = true;
            this.lbl__title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl__title.Location = new System.Drawing.Point(99, 32);
            this.lbl__title.Name = "lbl__title";
            this.lbl__title.Size = new System.Drawing.Size(556, 46);
            this.lbl__title.TabIndex = 8;
            this.lbl__title.Text = "AJOUTER UN.E EMPLOYÉ.E";
            // 
            // AjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.lbl__title);
            this.Controls.Add(this.btn__cancel);
            this.Controls.Add(this.btn__add);
            this.Controls.Add(this.combo_box__level);
            this.Controls.Add(this.lbl__role);
            this.Controls.Add(this.txt_box__password);
            this.Controls.Add(this.lbl__password);
            this.Controls.Add(this.txt_box__identifiant);
            this.Controls.Add(this.lbl__identifiant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutEmploye";
            this.Text = "Ajout - Employé.e";
            this.Load += new System.EventHandler(this.AjoutEmploye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl__identifiant;
        private System.Windows.Forms.TextBox txt_box__identifiant;
        private System.Windows.Forms.Label lbl__password;
        private System.Windows.Forms.TextBox txt_box__password;
        private System.Windows.Forms.Label lbl__role;
        private System.Windows.Forms.ComboBox combo_box__level;
        private System.Windows.Forms.Button btn__add;
        private System.Windows.Forms.Button btn__cancel;
        private System.Windows.Forms.Label lbl__title;
    }
}