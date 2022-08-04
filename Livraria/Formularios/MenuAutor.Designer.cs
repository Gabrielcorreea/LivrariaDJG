namespace Livraria.Formularios
{
    partial class MenuAutor
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
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.grbMenuAutor = new System.Windows.Forms.GroupBox();
            this.btnCadAutor = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.grbMenuAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomeAutor.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAutor.Location = new System.Drawing.Point(6, 58);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(175, 27);
            this.lblNomeAutor.TabIndex = 0;
            this.lblNomeAutor.Text = "Nome do Autor:";
            // 
            // grbMenuAutor
            // 
            this.grbMenuAutor.BackColor = System.Drawing.Color.Transparent;
            this.grbMenuAutor.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image;
            this.grbMenuAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbMenuAutor.Controls.Add(this.btnCadAutor);
            this.grbMenuAutor.Controls.Add(this.txtNomeAutor);
            this.grbMenuAutor.Controls.Add(this.lblNomeAutor);
            this.grbMenuAutor.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMenuAutor.ForeColor = System.Drawing.Color.White;
            this.grbMenuAutor.Location = new System.Drawing.Point(12, 12);
            this.grbMenuAutor.Name = "grbMenuAutor";
            this.grbMenuAutor.Size = new System.Drawing.Size(555, 187);
            this.grbMenuAutor.TabIndex = 1;
            this.grbMenuAutor.TabStop = false;
            this.grbMenuAutor.Text = "Menu do Autor:";
            // 
            // btnCadAutor
            // 
            this.btnCadAutor.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image__1_;
            this.btnCadAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadAutor.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadAutor.Location = new System.Drawing.Point(160, 123);
            this.btnCadAutor.Name = "btnCadAutor";
            this.btnCadAutor.Size = new System.Drawing.Size(225, 58);
            this.btnCadAutor.TabIndex = 2;
            this.btnCadAutor.Text = "Cadastrar";
            this.btnCadAutor.UseVisualStyleBackColor = true;
            this.btnCadAutor.Click += new System.EventHandler(this.btnCadAutor_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAutor.Location = new System.Drawing.Point(208, 49);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(341, 38);
            this.txtNomeAutor.TabIndex = 1;
            // 
            // dgvAutor
            // 
            this.dgvAutor.BackgroundColor = System.Drawing.Color.Black;
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Location = new System.Drawing.Point(12, 205);
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.Size = new System.Drawing.Size(555, 315);
            this.dgvAutor.TabIndex = 2;
            // 
            // MenuAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Livraria.Properties.Resources.old_books_436498_960_720_Pixabay;
            this.ClientSize = new System.Drawing.Size(579, 532);
            this.Controls.Add(this.dgvAutor);
            this.Controls.Add(this.grbMenuAutor);
            this.Name = "MenuAutor";
            this.Text = "MenuAutor";
            this.Load += new System.EventHandler(this.MenuAutor_Load);
            this.grbMenuAutor.ResumeLayout(false);
            this.grbMenuAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.GroupBox grbMenuAutor;
        private System.Windows.Forms.Button btnCadAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.DataGridView dgvAutor;
    }
}