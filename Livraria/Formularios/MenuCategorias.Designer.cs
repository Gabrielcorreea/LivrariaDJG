namespace Livraria.Formularios
{
    partial class MenuCategorias
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
            this.lblSeleCate = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleCate
            // 
            this.lblSeleCate.AutoSize = true;
            this.lblSeleCate.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleCate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeleCate.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleCate.ForeColor = System.Drawing.Color.White;
            this.lblSeleCate.Location = new System.Drawing.Point(12, 41);
            this.lblSeleCate.Name = "lblSeleCate";
            this.lblSeleCate.Size = new System.Drawing.Size(272, 27);
            this.lblSeleCate.TabIndex = 0;
            this.lblSeleCate.Text = "Selecione uma categoria:";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(305, 32);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(262, 40);
            this.cmbCategorias.TabIndex = 1;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(17, 97);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(550, 423);
            this.dgvCategoria.TabIndex = 2;
            // 
            // MenuCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Livraria.Properties.Resources._347aae028f0896a7845b8cf502922b17;
            this.ClientSize = new System.Drawing.Size(579, 532);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.lblSeleCate);
            this.Name = "MenuCategorias";
            this.Text = "MenuCategorias";
            this.Load += new System.EventHandler(this.MenuCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleCate;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.DataGridView dgvCategoria;
    }
}