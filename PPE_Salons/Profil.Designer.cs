
namespace PPE_Salons
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            this.lbl__hello_msg = new System.Windows.Forms.Label();
            this.lbl__nb_con_msg = new System.Windows.Forms.Label();
            this.lbl__nb_con_nb = new System.Windows.Forms.Label();
            this.lbl__date_last_conn = new System.Windows.Forms.Label();
            this.btn__come_back = new System.Windows.Forms.Button();
            this.lbl__last_date = new System.Windows.Forms.Label();
            this.lbl__identifiant_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl__hello_msg
            // 
            this.lbl__hello_msg.AutoSize = true;
            this.lbl__hello_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__hello_msg.Location = new System.Drawing.Point(270, 51);
            this.lbl__hello_msg.Name = "lbl__hello_msg";
            this.lbl__hello_msg.Size = new System.Drawing.Size(121, 32);
            this.lbl__hello_msg.TabIndex = 0;
            this.lbl__hello_msg.Text = "Bonjour ";
            // 
            // lbl__nb_con_msg
            // 
            this.lbl__nb_con_msg.AutoSize = true;
            this.lbl__nb_con_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__nb_con_msg.Location = new System.Drawing.Point(181, 156);
            this.lbl__nb_con_msg.Name = "lbl__nb_con_msg";
            this.lbl__nb_con_msg.Size = new System.Drawing.Size(251, 29);
            this.lbl__nb_con_msg.TabIndex = 1;
            this.lbl__nb_con_msg.Text = "Nombre de connexion";
            // 
            // lbl__nb_con_nb
            // 
            this.lbl__nb_con_nb.AutoSize = true;
            this.lbl__nb_con_nb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__nb_con_nb.Location = new System.Drawing.Point(497, 156);
            this.lbl__nb_con_nb.Name = "lbl__nb_con_nb";
            this.lbl__nb_con_nb.Size = new System.Drawing.Size(26, 29);
            this.lbl__nb_con_nb.TabIndex = 2;
            this.lbl__nb_con_nb.Text = "0";
            // 
            // lbl__date_last_conn
            // 
            this.lbl__date_last_conn.AutoSize = true;
            this.lbl__date_last_conn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__date_last_conn.Location = new System.Drawing.Point(182, 259);
            this.lbl__date_last_conn.Name = "lbl__date_last_conn";
            this.lbl__date_last_conn.Size = new System.Drawing.Size(261, 29);
            this.lbl__date_last_conn.TabIndex = 3;
            this.lbl__date_last_conn.Text = "Dernière connexion le :";
            // 
            // btn__come_back
            // 
            this.btn__come_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__come_back.Location = new System.Drawing.Point(318, 356);
            this.btn__come_back.Name = "btn__come_back";
            this.btn__come_back.Size = new System.Drawing.Size(161, 47);
            this.btn__come_back.TabIndex = 4;
            this.btn__come_back.Text = "Retour";
            this.btn__come_back.UseVisualStyleBackColor = true;
            this.btn__come_back.Click += new System.EventHandler(this.click__btn__come_back);
            // 
            // lbl__last_date
            // 
            this.lbl__last_date.AutoSize = true;
            this.lbl__last_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__last_date.Location = new System.Drawing.Point(482, 259);
            this.lbl__last_date.Name = "lbl__last_date";
            this.lbl__last_date.Size = new System.Drawing.Size(131, 29);
            this.lbl__last_date.TabIndex = 5;
            this.lbl__last_date.Text = "jj/mm/aaaa";
            // 
            // lbl__identifiant_user
            // 
            this.lbl__identifiant_user.AutoSize = true;
            this.lbl__identifiant_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__identifiant_user.Location = new System.Drawing.Point(383, 51);
            this.lbl__identifiant_user.Name = "lbl__identifiant_user";
            this.lbl__identifiant_user.Size = new System.Drawing.Size(140, 32);
            this.lbl__identifiant_user.TabIndex = 6;
            this.lbl__identifiant_user.Text = "Identifiant";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl__identifiant_user);
            this.Controls.Add(this.lbl__last_date);
            this.Controls.Add(this.btn__come_back);
            this.Controls.Add(this.lbl__date_last_conn);
            this.Controls.Add(this.lbl__nb_con_nb);
            this.Controls.Add(this.lbl__nb_con_msg);
            this.Controls.Add(this.lbl__hello_msg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl__hello_msg;
        private System.Windows.Forms.Label lbl__nb_con_msg;
        private System.Windows.Forms.Label lbl__nb_con_nb;
        private System.Windows.Forms.Label lbl__date_last_conn;
        private System.Windows.Forms.Button btn__come_back;
        private System.Windows.Forms.Label lbl__last_date;
        private System.Windows.Forms.Label lbl__identifiant_user;
    }
}