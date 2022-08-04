namespace Livraria.Formularios
{
    partial class MenuEditora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadEditora = new System.Windows.Forms.Button();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.dgvEditora = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Livraria.Properties.Resources._347aae028f0896a7845b8cf502922b17;
            this.groupBox1.Controls.Add(this.btnCadEditora);
            this.groupBox1.Controls.Add(this.txtNomeEditora);
            this.groupBox1.Controls.Add(this.lblNomeEditora);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCadEditora
            // 
            this.btnCadEditora.BackgroundImage = global::Livraria.Properties.Resources.old_books_436498_960_720_Pixabay;
            this.btnCadEditora.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadEditora.ForeColor = System.Drawing.Color.White;
            this.btnCadEditora.Location = new System.Drawing.Point(160, 123);
            this.btnCadEditora.Name = "btnCadEditora";
            this.btnCadEditora.Size = new System.Drawing.Size(225, 58);
            this.btnCadEditora.TabIndex = 2;
            this.btnCadEditora.Text = "Cadastrar";
            this.btnCadEditora.UseVisualStyleBackColor = true;
            this.btnCadEditora.Click += new System.EventHandler(this.btnCadEditora_Click);
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEditora.Location = new System.Drawing.Point(235, 49);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(314, 38);
            this.txtNomeEditora.TabIndex = 1;
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.BackColor = System.Drawing.Color.Black;
            this.lblNomeEditora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomeEditora.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEditora.ForeColor = System.Drawing.Color.White;
            this.lblNomeEditora.Location = new System.Drawing.Point(6, 58);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(196, 27);
            this.lblNomeEditora.TabIndex = 0;
            this.lblNomeEditora.Text = "Nome da Editora:";
            // 
            // dgvEditora
            // 
            this.dgvEditora.BackgroundColor = System.Drawing.Color.Black;
            this.dgvEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditora.Location = new System.Drawing.Point(12, 205);
            this.dgvEditora.Name = "dgvEditora";
            this.dgvEditora.Size = new System.Drawing.Size(555, 317);
            this.dgvEditora.TabIndex = 3;
            this.dgvEditora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditora_CellContentClick);
            // 
            // MenuEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Livraria.Properties.Resources._347aae028f0896a7845b8cf502922b17;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 534);
            this.Controls.Add(this.dgvEditora);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuEditora";
            this.Text = "MenuEditora";
            this.Load += new System.EventHandler(this.MenuEditora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.DataGridView dgvEditora;
    }
}