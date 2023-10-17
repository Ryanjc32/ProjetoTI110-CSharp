
namespace MercadoSA
{
    partial class PesquisarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarUsuarios));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ltbPesquisar = new System.Windows.Forms.ListBox();
            this.gppPesquisarPor = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.gppPesquisarPor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(608, 285);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 212);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(608, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(165, 233);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ltbPesquisar
            // 
            this.ltbPesquisar.FormattingEnabled = true;
            this.ltbPesquisar.HorizontalExtent = 4;
            this.ltbPesquisar.Location = new System.Drawing.Point(28, 285);
            this.ltbPesquisar.Name = "ltbPesquisar";
            this.ltbPesquisar.Size = new System.Drawing.Size(574, 212);
            this.ltbPesquisar.TabIndex = 10;
            this.ltbPesquisar.SelectedIndexChanged += new System.EventHandler(this.ltbPesquisar_SelectedIndexChanged);
            // 
            // gppPesquisarPor
            // 
            this.gppPesquisarPor.Controls.Add(this.txtDescricao);
            this.gppPesquisarPor.Controls.Add(this.lblDescricao);
            this.gppPesquisarPor.Controls.Add(this.rdbNome);
            this.gppPesquisarPor.Controls.Add(this.rdbCodigo);
            this.gppPesquisarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gppPesquisarPor.Location = new System.Drawing.Point(28, 5);
            this.gppPesquisarPor.Name = "gppPesquisarPor";
            this.gppPesquisarPor.Size = new System.Drawing.Size(574, 240);
            this.gppPesquisarPor.TabIndex = 8;
            this.gppPesquisarPor.TabStop = false;
            this.gppPesquisarPor.Text = "Pesquisar por";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(172, 96);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(303, 24);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(81, 96);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(76, 18);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(242, 37);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(67, 22);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(84, 37);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(74, 22);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // PesquisarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.ltbPesquisar);
            this.Controls.Add(this.gppPesquisarPor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PesquisarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisarUsuarios";
            this.gppPesquisarPor.ResumeLayout(false);
            this.gppPesquisarPor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListBox ltbPesquisar;
        private System.Windows.Forms.GroupBox gppPesquisarPor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
    }
}