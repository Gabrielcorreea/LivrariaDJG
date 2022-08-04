namespace Livraria.Formularios
{
    partial class MenuLivros
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
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.lblRemover = new System.Windows.Forms.Label();
            this.grbRemover = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.cmbEditoraCad = new System.Windows.Forms.ComboBox();
            this.cmbAutorCad = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaCad = new System.Windows.Forms.ComboBox();
            this.lblEditoraCad = new System.Windows.Forms.Label();
            this.lblISBNcad = new System.Windows.Forms.Label();
            this.lblAutorCad = new System.Windows.Forms.Label();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.lblLivroCad = new System.Windows.Forms.Label();
            this.txtISBNcad = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtLivroCad = new System.Windows.Forms.TextBox();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.cmbEditoraEdi = new System.Windows.Forms.ComboBox();
            this.cmbAutorEdi = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaEdi = new System.Windows.Forms.ComboBox();
            this.lblEditoraEdi = new System.Windows.Forms.Label();
            this.lblSBNedi = new System.Windows.Forms.Label();
            this.lblAutorEdi = new System.Windows.Forms.Label();
            this.lblCategoriaEdi = new System.Windows.Forms.Label();
            this.lblLivroEdi = new System.Windows.Forms.Label();
            this.txtISBNedi = new System.Windows.Forms.TextBox();
            this.txtLivroEdi = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.grbRemover.SuspendLayout();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLivros
            // 
            this.dgvLivros.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(483, 12);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.Size = new System.Drawing.Size(551, 677);
            this.dgvLivros.TabIndex = 0;
            this.dgvLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellContentClick);
            // 
            // lblRemover
            // 
            this.lblRemover.AutoSize = true;
            this.lblRemover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRemover.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemover.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRemover.Location = new System.Drawing.Point(6, 26);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(211, 27);
            this.lblRemover.TabIndex = 1;
            this.lblRemover.Text = "Selecione um livro:";
            // 
            // grbRemover
            // 
            this.grbRemover.BackColor = System.Drawing.Color.Black;
            this.grbRemover.Controls.Add(this.btnRemover);
            this.grbRemover.Controls.Add(this.lblRemover);
            this.grbRemover.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRemover.ForeColor = System.Drawing.Color.White;
            this.grbRemover.Location = new System.Drawing.Point(12, 621);
            this.grbRemover.Name = "grbRemover";
            this.grbRemover.Size = new System.Drawing.Size(465, 68);
            this.grbRemover.TabIndex = 2;
            this.grbRemover.TabStop = false;
            this.grbRemover.Text = "Remover:";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(265, 19);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(194, 41);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.BackColor = System.Drawing.Color.DimGray;
            this.grbCadastrar.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image;
            this.grbCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbCadastrar.Controls.Add(this.cmbEditoraCad);
            this.grbCadastrar.Controls.Add(this.cmbAutorCad);
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCad);
            this.grbCadastrar.Controls.Add(this.lblEditoraCad);
            this.grbCadastrar.Controls.Add(this.lblISBNcad);
            this.grbCadastrar.Controls.Add(this.lblAutorCad);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCad);
            this.grbCadastrar.Controls.Add(this.lblLivroCad);
            this.grbCadastrar.Controls.Add(this.txtISBNcad);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.txtLivroCad);
            this.grbCadastrar.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.ForeColor = System.Drawing.Color.White;
            this.grbCadastrar.Location = new System.Drawing.Point(12, 12);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(459, 298);
            this.grbCadastrar.TabIndex = 3;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            this.grbCadastrar.Enter += new System.EventHandler(this.grbCadastrar_Enter);
            // 
            // cmbEditoraCad
            // 
            this.cmbEditoraCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditoraCad.FormattingEnabled = true;
            this.cmbEditoraCad.Location = new System.Drawing.Point(233, 182);
            this.cmbEditoraCad.Name = "cmbEditoraCad";
            this.cmbEditoraCad.Size = new System.Drawing.Size(220, 32);
            this.cmbEditoraCad.TabIndex = 17;
            // 
            // cmbAutorCad
            // 
            this.cmbAutorCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutorCad.FormattingEnabled = true;
            this.cmbAutorCad.Location = new System.Drawing.Point(233, 104);
            this.cmbAutorCad.Name = "cmbAutorCad";
            this.cmbAutorCad.Size = new System.Drawing.Size(220, 32);
            this.cmbAutorCad.TabIndex = 16;
            this.cmbAutorCad.SelectedIndexChanged += new System.EventHandler(this.cmbAutorCad_SelectedIndexChanged);
            // 
            // cmbCategoriaCad
            // 
            this.cmbCategoriaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaCad.FormattingEnabled = true;
            this.cmbCategoriaCad.Location = new System.Drawing.Point(233, 66);
            this.cmbCategoriaCad.Name = "cmbCategoriaCad";
            this.cmbCategoriaCad.Size = new System.Drawing.Size(220, 32);
            this.cmbCategoriaCad.TabIndex = 15;
            this.cmbCategoriaCad.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaCad_SelectedIndexChanged);
            // 
            // lblEditoraCad
            // 
            this.lblEditoraCad.AutoSize = true;
            this.lblEditoraCad.BackColor = System.Drawing.Color.Transparent;
            this.lblEditoraCad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEditoraCad.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditoraCad.Location = new System.Drawing.Point(20, 191);
            this.lblEditoraCad.Name = "lblEditoraCad";
            this.lblEditoraCad.Size = new System.Drawing.Size(88, 24);
            this.lblEditoraCad.TabIndex = 14;
            this.lblEditoraCad.Text = "Editora:";
            // 
            // lblISBNcad
            // 
            this.lblISBNcad.AutoSize = true;
            this.lblISBNcad.BackColor = System.Drawing.Color.Transparent;
            this.lblISBNcad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblISBNcad.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBNcad.Location = new System.Drawing.Point(20, 152);
            this.lblISBNcad.Name = "lblISBNcad";
            this.lblISBNcad.Size = new System.Drawing.Size(67, 24);
            this.lblISBNcad.TabIndex = 13;
            this.lblISBNcad.Text = "ISBN:";
            // 
            // lblAutorCad
            // 
            this.lblAutorCad.AutoSize = true;
            this.lblAutorCad.BackColor = System.Drawing.Color.Transparent;
            this.lblAutorCad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAutorCad.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorCad.ForeColor = System.Drawing.Color.White;
            this.lblAutorCad.Location = new System.Drawing.Point(20, 113);
            this.lblAutorCad.Name = "lblAutorCad";
            this.lblAutorCad.Size = new System.Drawing.Size(97, 24);
            this.lblAutorCad.TabIndex = 12;
            this.lblAutorCad.Text = "Autor(a):";
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaCad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoriaCad.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCad.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaCad.Location = new System.Drawing.Point(20, 74);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(108, 24);
            this.lblCategoriaCad.TabIndex = 11;
            this.lblCategoriaCad.Text = "Categoria:";
            // 
            // lblLivroCad
            // 
            this.lblLivroCad.AutoSize = true;
            this.lblLivroCad.BackColor = System.Drawing.Color.Transparent;
            this.lblLivroCad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLivroCad.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivroCad.ForeColor = System.Drawing.Color.White;
            this.lblLivroCad.Location = new System.Drawing.Point(20, 35);
            this.lblLivroCad.Name = "lblLivroCad";
            this.lblLivroCad.Size = new System.Drawing.Size(155, 24);
            this.lblLivroCad.TabIndex = 10;
            this.lblLivroCad.Text = "Nome do Livro:";
            // 
            // txtISBNcad
            // 
            this.txtISBNcad.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBNcad.Location = new System.Drawing.Point(233, 143);
            this.txtISBNcad.Name = "txtISBNcad";
            this.txtISBNcad.Size = new System.Drawing.Size(220, 33);
            this.txtISBNcad.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCadastrar.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(133, 253);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(192, 39);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtLivroCad
            // 
            this.txtLivroCad.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLivroCad.Location = new System.Drawing.Point(233, 26);
            this.txtLivroCad.Name = "txtLivroCad";
            this.txtLivroCad.Size = new System.Drawing.Size(220, 33);
            this.txtLivroCad.TabIndex = 0;
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.Gray;
            this.grbEditar.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image;
            this.grbEditar.Controls.Add(this.cmbEditoraEdi);
            this.grbEditar.Controls.Add(this.cmbAutorEdi);
            this.grbEditar.Controls.Add(this.cmbCategoriaEdi);
            this.grbEditar.Controls.Add(this.lblEditoraEdi);
            this.grbEditar.Controls.Add(this.lblSBNedi);
            this.grbEditar.Controls.Add(this.lblAutorEdi);
            this.grbEditar.Controls.Add(this.lblCategoriaEdi);
            this.grbEditar.Controls.Add(this.lblLivroEdi);
            this.grbEditar.Controls.Add(this.txtISBNedi);
            this.grbEditar.Controls.Add(this.txtLivroEdi);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.ForeColor = System.Drawing.Color.White;
            this.grbEditar.Location = new System.Drawing.Point(12, 317);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(459, 298);
            this.grbEditar.TabIndex = 4;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // cmbEditoraEdi
            // 
            this.cmbEditoraEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditoraEdi.FormattingEnabled = true;
            this.cmbEditoraEdi.Location = new System.Drawing.Point(233, 182);
            this.cmbEditoraEdi.Name = "cmbEditoraEdi";
            this.cmbEditoraEdi.Size = new System.Drawing.Size(220, 32);
            this.cmbEditoraEdi.TabIndex = 19;
            // 
            // cmbAutorEdi
            // 
            this.cmbAutorEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutorEdi.FormattingEnabled = true;
            this.cmbAutorEdi.Location = new System.Drawing.Point(233, 103);
            this.cmbAutorEdi.Name = "cmbAutorEdi";
            this.cmbAutorEdi.Size = new System.Drawing.Size(220, 32);
            this.cmbAutorEdi.TabIndex = 18;
            // 
            // cmbCategoriaEdi
            // 
            this.cmbCategoriaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaEdi.FormattingEnabled = true;
            this.cmbCategoriaEdi.Location = new System.Drawing.Point(233, 65);
            this.cmbCategoriaEdi.Name = "cmbCategoriaEdi";
            this.cmbCategoriaEdi.Size = new System.Drawing.Size(220, 32);
            this.cmbCategoriaEdi.TabIndex = 17;
            // 
            // lblEditoraEdi
            // 
            this.lblEditoraEdi.AutoSize = true;
            this.lblEditoraEdi.BackColor = System.Drawing.Color.Transparent;
            this.lblEditoraEdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEditoraEdi.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditoraEdi.Location = new System.Drawing.Point(20, 191);
            this.lblEditoraEdi.Name = "lblEditoraEdi";
            this.lblEditoraEdi.Size = new System.Drawing.Size(140, 24);
            this.lblEditoraEdi.TabIndex = 16;
            this.lblEditoraEdi.Text = "Nova Editora:";
            // 
            // lblSBNedi
            // 
            this.lblSBNedi.AutoSize = true;
            this.lblSBNedi.BackColor = System.Drawing.Color.Transparent;
            this.lblSBNedi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSBNedi.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSBNedi.Location = new System.Drawing.Point(20, 152);
            this.lblSBNedi.Name = "lblSBNedi";
            this.lblSBNedi.Size = new System.Drawing.Size(119, 24);
            this.lblSBNedi.TabIndex = 15;
            this.lblSBNedi.Text = "Novo ISBN:";
            // 
            // lblAutorEdi
            // 
            this.lblAutorEdi.AutoSize = true;
            this.lblAutorEdi.BackColor = System.Drawing.Color.Transparent;
            this.lblAutorEdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAutorEdi.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorEdi.Location = new System.Drawing.Point(20, 113);
            this.lblAutorEdi.Name = "lblAutorEdi";
            this.lblAutorEdi.Size = new System.Drawing.Size(146, 24);
            this.lblAutorEdi.TabIndex = 14;
            this.lblAutorEdi.Text = "Novo autor(a):";
            // 
            // lblCategoriaEdi
            // 
            this.lblCategoriaEdi.AutoSize = true;
            this.lblCategoriaEdi.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaEdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoriaEdi.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaEdi.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaEdi.Location = new System.Drawing.Point(20, 74);
            this.lblCategoriaEdi.Name = "lblCategoriaEdi";
            this.lblCategoriaEdi.Size = new System.Drawing.Size(160, 24);
            this.lblCategoriaEdi.TabIndex = 13;
            this.lblCategoriaEdi.Text = "Nova Categoria:";
            // 
            // lblLivroEdi
            // 
            this.lblLivroEdi.AutoSize = true;
            this.lblLivroEdi.BackColor = System.Drawing.Color.Transparent;
            this.lblLivroEdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLivroEdi.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivroEdi.ForeColor = System.Drawing.Color.Transparent;
            this.lblLivroEdi.Location = new System.Drawing.Point(20, 35);
            this.lblLivroEdi.Name = "lblLivroEdi";
            this.lblLivroEdi.Size = new System.Drawing.Size(116, 24);
            this.lblLivroEdi.TabIndex = 12;
            this.lblLivroEdi.Text = "Novo nome";
            // 
            // txtISBNedi
            // 
            this.txtISBNedi.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBNedi.Location = new System.Drawing.Point(233, 143);
            this.txtISBNedi.Name = "txtISBNedi";
            this.txtISBNedi.Size = new System.Drawing.Size(220, 33);
            this.txtISBNedi.TabIndex = 10;
            // 
            // txtLivroEdi
            // 
            this.txtLivroEdi.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLivroEdi.Location = new System.Drawing.Point(233, 26);
            this.txtLivroEdi.Name = "txtLivroEdi";
            this.txtLivroEdi.Size = new System.Drawing.Size(220, 33);
            this.txtLivroEdi.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DimGray;
            this.btnEditar.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(133, 253);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(192, 39);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // MenuLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Livraria.Properties.Resources.MicrosoftTeams_image__1_;
            this.ClientSize = new System.Drawing.Size(1046, 701);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.grbRemover);
            this.Controls.Add(this.dgvLivros);
            this.Name = "MenuLivros";
            this.Text = "MenuLivros";
            this.Load += new System.EventHandler(this.MenuLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.grbRemover.ResumeLayout(false);
            this.grbRemover.PerformLayout();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.GroupBox grbRemover;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblEditoraCad;
        private System.Windows.Forms.Label lblISBNcad;
        private System.Windows.Forms.Label lblAutorCad;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.Label lblLivroCad;
        private System.Windows.Forms.TextBox txtISBNcad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblEditoraEdi;
        private System.Windows.Forms.Label lblSBNedi;
        private System.Windows.Forms.Label lblAutorEdi;
        private System.Windows.Forms.Label lblCategoriaEdi;
        private System.Windows.Forms.Label lblLivroEdi;
        private System.Windows.Forms.TextBox txtISBNedi;
        private System.Windows.Forms.TextBox txtLivroEdi;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbEditoraCad;
        private System.Windows.Forms.ComboBox cmbAutorCad;
        private System.Windows.Forms.ComboBox cmbCategoriaCad;
        private System.Windows.Forms.TextBox txtLivroCad;
        private System.Windows.Forms.ComboBox cmbEditoraEdi;
        private System.Windows.Forms.ComboBox cmbAutorEdi;
        private System.Windows.Forms.ComboBox cmbCategoriaEdi;
        private MySqlConnector.MySqlCommand mySqlCommand1;
    }
}