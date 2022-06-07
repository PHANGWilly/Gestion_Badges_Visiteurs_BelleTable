
namespace PPE_Salons
{
    partial class Historique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historique));
            this.lbl__title_historique = new System.Windows.Forms.Label();
            this.btn__to_come_back = new System.Windows.Forms.Button();
            this.data_grid_view__historique = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view__historique)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl__title_historique
            // 
            this.lbl__title_historique.AutoSize = true;
            this.lbl__title_historique.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl__title_historique.Location = new System.Drawing.Point(293, 36);
            this.lbl__title_historique.Name = "lbl__title_historique";
            this.lbl__title_historique.Size = new System.Drawing.Size(198, 36);
            this.lbl__title_historique.TabIndex = 0;
            this.lbl__title_historique.Text = "HISTORIQUE";
            this.lbl__title_historique.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn__to_come_back
            // 
            this.btn__to_come_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn__to_come_back.Location = new System.Drawing.Point(33, 377);
            this.btn__to_come_back.Name = "btn__to_come_back";
            this.btn__to_come_back.Size = new System.Drawing.Size(102, 38);
            this.btn__to_come_back.TabIndex = 1;
            this.btn__to_come_back.Text = "Retour";
            this.btn__to_come_back.UseVisualStyleBackColor = true;
            this.btn__to_come_back.Click += new System.EventHandler(this.click__btn__to_come_back);
            // 
            // data_grid_view__historique
            // 
            this.data_grid_view__historique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view__historique.Location = new System.Drawing.Point(112, 87);
            this.data_grid_view__historique.Name = "data_grid_view__historique";
            this.data_grid_view__historique.RowHeadersWidth = 62;
            this.data_grid_view__historique.RowTemplate.Height = 28;
            this.data_grid_view__historique.Size = new System.Drawing.Size(580, 241);
            this.data_grid_view__historique.TabIndex = 2;
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_grid_view__historique);
            this.Controls.Add(this.btn__to_come_back);
            this.Controls.Add(this.lbl__title_historique);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Historique";
            this.Text = "Historique des connexions ";
            this.Load += new System.EventHandler(this.Historique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view__historique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl__title_historique;
        private System.Windows.Forms.Button btn__to_come_back;
        private System.Windows.Forms.DataGridView data_grid_view__historique;
    }
}