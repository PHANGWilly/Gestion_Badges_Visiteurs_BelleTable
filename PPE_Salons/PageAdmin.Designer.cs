
namespace PPE_Salons
{
    partial class PageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAdmin));
            this.lbl__title_users = new System.Windows.Forms.Label();
            this.btn__to_add = new System.Windows.Forms.Button();
            this.btn__to_come_back = new System.Windows.Forms.Button();
            this.btn_to_history = new System.Windows.Forms.Button();
            this.data_grid_view__employes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view__employes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl__title_users
            // 
            this.lbl__title_users.AutoSize = true;
            this.lbl__title_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl__title_users.Location = new System.Drawing.Point(293, 27);
            this.lbl__title_users.Name = "lbl__title_users";
            this.lbl__title_users.Size = new System.Drawing.Size(207, 36);
            this.lbl__title_users.TabIndex = 0;
            this.lbl__title_users.Text = "EMPLOYÉ.ES";
            // 
            // btn__to_add
            // 
            this.btn__to_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn__to_add.Location = new System.Drawing.Point(629, 442);
            this.btn__to_add.Name = "btn__to_add";
            this.btn__to_add.Size = new System.Drawing.Size(125, 42);
            this.btn__to_add.TabIndex = 1;
            this.btn__to_add.Text = "Ajouter";
            this.btn__to_add.UseVisualStyleBackColor = true;
            this.btn__to_add.Click += new System.EventHandler(this.click__btn__to_add);
            // 
            // btn__to_come_back
            // 
            this.btn__to_come_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn__to_come_back.Location = new System.Drawing.Point(50, 442);
            this.btn__to_come_back.Name = "btn__to_come_back";
            this.btn__to_come_back.Size = new System.Drawing.Size(118, 42);
            this.btn__to_come_back.TabIndex = 2;
            this.btn__to_come_back.Text = "Annuler";
            this.btn__to_come_back.UseVisualStyleBackColor = true;
            this.btn__to_come_back.Click += new System.EventHandler(this.click__btn__to_come_back);
            // 
            // btn_to_history
            // 
            this.btn_to_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_to_history.Location = new System.Drawing.Point(331, 442);
            this.btn_to_history.Name = "btn_to_history";
            this.btn_to_history.Size = new System.Drawing.Size(141, 42);
            this.btn_to_history.TabIndex = 3;
            this.btn_to_history.Text = "Historique";
            this.btn_to_history.UseVisualStyleBackColor = true;
            this.btn_to_history.Click += new System.EventHandler(this.click__btn_to_history);
            // 
            // data_grid_view__employes
            // 
            this.data_grid_view__employes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view__employes.Location = new System.Drawing.Point(50, 94);
            this.data_grid_view__employes.Name = "data_grid_view__employes";
            this.data_grid_view__employes.RowHeadersWidth = 62;
            this.data_grid_view__employes.RowTemplate.Height = 28;
            this.data_grid_view__employes.Size = new System.Drawing.Size(704, 307);
            this.data_grid_view__employes.TabIndex = 4;
            // 
            // PageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.data_grid_view__employes);
            this.Controls.Add(this.btn_to_history);
            this.Controls.Add(this.btn__to_come_back);
            this.Controls.Add(this.btn__to_add);
            this.Controls.Add(this.lbl__title_users);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PageAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.PageAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view__employes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl__title_users;
        private System.Windows.Forms.Button btn__to_add;
        private System.Windows.Forms.Button btn__to_come_back;
        private System.Windows.Forms.Button btn_to_history;
        private System.Windows.Forms.DataGridView data_grid_view__employes;
    }
}