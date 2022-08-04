namespace Livraria.Formularios
{
    partial class MenuPrincipal
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
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnEditora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("News706 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblMenuPrincipal.Image = global::Livraria.Properties.Resources._1_722H7nWsDQ0D_ReOKoRytQ;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(54, 9);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(309, 41);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "MENU DE INICIO";
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.DimGray;
            this.btnLivros.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image__4_;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLivros.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.Black;
            this.btnLivros.Location = new System.Drawing.Point(30, 84);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(142, 61);
            this.btnLivros.TabIndex = 1;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Brown;
            this.btnCategorias.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image__4_;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategorias.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnCategorias.Image = global::Livraria.Properties.Resources.MicrosoftTeams_image__4_;
            this.btnCategorias.Location = new System.Drawing.Point(244, 84);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(142, 61);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.BackColor = System.Drawing.Color.IndianRed;
            this.btnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutor.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.Color.Black;
            this.btnAutor.Image = global::Livraria.Properties.Resources.MicrosoftTeams_image__1_;
            this.btnAutor.Location = new System.Drawing.Point(30, 186);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(142, 61);
            this.btnAutor.TabIndex = 3;
            this.btnAutor.Text = "Ver Autor";
            this.btnAutor.UseVisualStyleBackColor = false;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnEditora
            // 
            this.btnEditora.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEditora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditora.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.Image = global::Livraria.Properties.Resources.livros_que_vão_ajudar_na_sua_application_768x512;
            this.btnEditora.Location = new System.Drawing.Point(244, 186);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.Size = new System.Drawing.Size(142, 61);
            this.btnEditora.TabIndex = 4;
            this.btnEditora.Text = "Ver Editora";
            this.btnEditora.UseVisualStyleBackColor = false;
            this.btnEditora.Click += new System.EventHandler(this.btnEditora_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image;
            this.ClientSize = new System.Drawing.Size(421, 290);
            this.Controls.Add(this.btnEditora);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnLivros);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnEditora;
    }
}