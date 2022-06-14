namespace PPE_Salons
{
    partial class Admin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.MaGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn__to_admin = new System.Windows.Forms.Button();
            this.lbl__nb_conn = new System.Windows.Forms.Label();
            this.lbl__last_conn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MaGrid
            // 
            this.MaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaGrid.Location = new System.Drawing.Point(34, 156);
            this.MaGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaGrid.MultiSelect = false;
            this.MaGrid.Name = "MaGrid";
            this.MaGrid.RowHeadersWidth = 62;
            this.MaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MaGrid.Size = new System.Drawing.Size(633, 507);
            this.MaGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tous les Participants";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 226);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ouvrir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(676, 300);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(82, 106);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(268, 26);
            this.tbNom.TabIndex = 5;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(30, 111);
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(42, 20);
            this.Nom.TabIndex = 6;
            this.Nom.Text = "Nom";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(362, 103);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "Rechercher";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn__to_admin
            // 
            this.btn__to_admin.Location = new System.Drawing.Point(676, 622);
            this.btn__to_admin.Name = "btn__to_admin";
            this.btn__to_admin.Size = new System.Drawing.Size(112, 41);
            this.btn__to_admin.TabIndex = 8;
            this.btn__to_admin.Text = "Admin";
            this.btn__to_admin.UseVisualStyleBackColor = true;
            this.btn__to_admin.Visible = false;
            this.btn__to_admin.Click += new System.EventHandler(this.click__btn__to_admin);
            // 
            // lbl__nb_conn
            // 
            this.lbl__nb_conn.AutoSize = true;
            this.lbl__nb_conn.Location = new System.Drawing.Point(30, 21);
            this.lbl__nb_conn.Name = "lbl__nb_conn";
            this.lbl__nb_conn.Size = new System.Drawing.Size(102, 20);
            this.lbl__nb_conn.TabIndex = 9;
            this.lbl__nb_conn.Text = "Connexion n°";
            // 
            // lbl__last_conn
            // 
            this.lbl__last_conn.AutoSize = true;
            this.lbl__last_conn.Location = new System.Drawing.Point(30, 61);
            this.lbl__last_conn.Name = "lbl__last_conn";
            this.lbl__last_conn.Size = new System.Drawing.Size(166, 20);
            this.lbl__last_conn.TabIndex = 10;
            this.lbl__last_conn.Text = "Dernière connexion le ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(814, 727);
            this.Controls.Add(this.lbl__last_conn);
            this.Controls.Add(this.lbl__nb_conn);
            this.Controls.Add(this.btn__to_admin);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.Text = "Gestion des salons";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MaGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn__to_admin;
        private System.Windows.Forms.Label lbl__nb_conn;
        private System.Windows.Forms.Label lbl__last_conn;
    }
}

