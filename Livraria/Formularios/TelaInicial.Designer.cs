namespace Livraria.Formularios
{
    partial class TelaInicial
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
            this.lblBV = new System.Windows.Forms.Label();
            this.grbTelaInicial = new System.Windows.Forms.GroupBox();
            this.lblBV4 = new System.Windows.Forms.Label();
            this.lblBV3 = new System.Windows.Forms.Label();
            this.lblBV2 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.grbTelaInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBV
            // 
            this.lblBV.AutoSize = true;
            this.lblBV.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBV.ForeColor = System.Drawing.Color.Black;
            this.lblBV.Image = global::Livraria.Properties.Resources.MicrosoftTeams_image__4_;
            this.lblBV.Location = new System.Drawing.Point(47, 9);
            this.lblBV.Name = "lblBV";
            this.lblBV.Size = new System.Drawing.Size(417, 32);
            this.lblBV.TabIndex = 0;
            this.lblBV.Text = "BEM VINDO - LIVRARIA JGD";
            // 
            // grbTelaInicial
            // 
            this.grbTelaInicial.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image__1_;
            this.grbTelaInicial.Controls.Add(this.lblBV4);
            this.grbTelaInicial.Controls.Add(this.lblBV3);
            this.grbTelaInicial.Controls.Add(this.lblBV2);
            this.grbTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbTelaInicial.Location = new System.Drawing.Point(53, 67);
            this.grbTelaInicial.Name = "grbTelaInicial";
            this.grbTelaInicial.Size = new System.Drawing.Size(411, 186);
            this.grbTelaInicial.TabIndex = 1;
            this.grbTelaInicial.TabStop = false;
            // 
            // lblBV4
            // 
            this.lblBV4.AutoSize = true;
            this.lblBV4.BackColor = System.Drawing.Color.Transparent;
            this.lblBV4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBV4.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBV4.ForeColor = System.Drawing.Color.White;
            this.lblBV4.Location = new System.Drawing.Point(32, 152);
            this.lblBV4.Name = "lblBV4";
            this.lblBV4.Size = new System.Drawing.Size(374, 31);
            this.lblBV4.TabIndex = 2;
            this.lblBV4.Text = "para você e toda a sua família!!";
            // 
            // lblBV3
            // 
            this.lblBV3.AutoSize = true;
            this.lblBV3.BackColor = System.Drawing.Color.Transparent;
            this.lblBV3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBV3.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBV3.ForeColor = System.Drawing.Color.White;
            this.lblBV3.Location = new System.Drawing.Point(6, 86);
            this.lblBV3.Name = "lblBV3";
            this.lblBV3.Size = new System.Drawing.Size(408, 31);
            this.lblBV3.TabIndex = 1;
            this.lblBV3.Text = "de todas as categorias e gêneros...";
            // 
            // lblBV2
            // 
            this.lblBV2.AutoSize = true;
            this.lblBV2.BackColor = System.Drawing.Color.Transparent;
            this.lblBV2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBV2.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBV2.ForeColor = System.Drawing.Color.White;
            this.lblBV2.Location = new System.Drawing.Point(6, 16);
            this.lblBV2.Name = "lblBV2";
            this.lblBV2.Size = new System.Drawing.Size(400, 31);
            this.lblBV2.TabIndex = 0;
            this.lblBV2.Text = "Encontre aqui os melhores livros";
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Image = global::Livraria.Properties.Resources.MicrosoftTeams_image__4_;
            this.btnEntrar.Location = new System.Drawing.Point(144, 268);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(239, 51);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image;
            this.ClientSize = new System.Drawing.Size(515, 331);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.grbTelaInicial);
            this.Controls.Add(this.lblBV);
            this.Name = "TelaInicial";
            this.Text = "Bem vindo ";
            this.grbTelaInicial.ResumeLayout(false);
            this.grbTelaInicial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBV;
        private System.Windows.Forms.GroupBox grbTelaInicial;
        private System.Windows.Forms.Label lblBV4;
        private System.Windows.Forms.Label lblBV3;
        private System.Windows.Forms.Label lblBV2;
        private System.Windows.Forms.Button btnEntrar;
    }
}