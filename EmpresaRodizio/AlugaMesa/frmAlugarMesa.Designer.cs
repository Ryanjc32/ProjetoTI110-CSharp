
namespace AlugaMesa
{
    partial class frmAlugarMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlugarMesa));
            this.btnAlugar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblCodMesa = new System.Windows.Forms.Label();
            this.lblStatusDoAluguel = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.txtCodMesa = new System.Windows.Forms.TextBox();
            this.txtStatusDoAluguel = new System.Windows.Forms.TextBox();
            this.gpbPesquisarMesas = new System.Windows.Forms.GroupBox();
            this.lstPesquisar = new System.Windows.Forms.ListBox();
            this.rdbIndisponivel = new System.Windows.Forms.RadioButton();
            this.rdbDisponivel = new System.Windows.Forms.RadioButton();
            this.gpbPesquisarMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlugar
            // 
            this.btnAlugar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlugar.Image")));
            this.btnAlugar.Location = new System.Drawing.Point(176, 392);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(115, 57);
            this.btnAlugar.TabIndex = 6;
            this.btnAlugar.Text = "&Alugar";
            this.btnAlugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlugar.UseVisualStyleBackColor = true;
            // 
            // btnLiberar
            // 
            this.btnLiberar.Image = ((System.Drawing.Image)(resources.GetObject("btnLiberar.Image")));
            this.btnLiberar.Location = new System.Drawing.Point(310, 392);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(115, 57);
            this.btnLiberar.TabIndex = 7;
            this.btnLiberar.Text = "&Liberar";
            this.btnLiberar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLiberar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(448, 392);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 57);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(585, 392);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 57);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(76, 254);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(159, 38);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(66, 65);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(126, 20);
            this.lblNomeCli.TabIndex = 11;
            this.lblNomeCli.Text = "Nome do Cliente";
            // 
            // lblCodMesa
            // 
            this.lblCodMesa.AutoSize = true;
            this.lblCodMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMesa.Location = new System.Drawing.Point(66, 121);
            this.lblCodMesa.Name = "lblCodMesa";
            this.lblCodMesa.Size = new System.Drawing.Size(124, 20);
            this.lblCodMesa.TabIndex = 12;
            this.lblCodMesa.Text = "Código da Mesa";
            // 
            // lblStatusDoAluguel
            // 
            this.lblStatusDoAluguel.AutoSize = true;
            this.lblStatusDoAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDoAluguel.Location = new System.Drawing.Point(66, 172);
            this.lblStatusDoAluguel.Name = "lblStatusDoAluguel";
            this.lblStatusDoAluguel.Size = new System.Drawing.Size(135, 20);
            this.lblStatusDoAluguel.TabIndex = 13;
            this.lblStatusDoAluguel.Text = "Status do Aluguel";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(212, 67);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(115, 20);
            this.txtNomeCli.TabIndex = 15;
            // 
            // txtCodMesa
            // 
            this.txtCodMesa.Location = new System.Drawing.Point(212, 121);
            this.txtCodMesa.Name = "txtCodMesa";
            this.txtCodMesa.Size = new System.Drawing.Size(115, 20);
            this.txtCodMesa.TabIndex = 16;
            // 
            // txtStatusDoAluguel
            // 
            this.txtStatusDoAluguel.Location = new System.Drawing.Point(212, 172);
            this.txtStatusDoAluguel.Name = "txtStatusDoAluguel";
            this.txtStatusDoAluguel.Size = new System.Drawing.Size(115, 20);
            this.txtStatusDoAluguel.TabIndex = 17;
            // 
            // gpbPesquisarMesas
            // 
            this.gpbPesquisarMesas.Controls.Add(this.lstPesquisar);
            this.gpbPesquisarMesas.Controls.Add(this.rdbIndisponivel);
            this.gpbPesquisarMesas.Controls.Add(this.rdbDisponivel);
            this.gpbPesquisarMesas.Controls.Add(this.btnPesquisar);
            this.gpbPesquisarMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarMesas.Location = new System.Drawing.Point(434, 23);
            this.gpbPesquisarMesas.Name = "gpbPesquisarMesas";
            this.gpbPesquisarMesas.Size = new System.Drawing.Size(316, 298);
            this.gpbPesquisarMesas.TabIndex = 18;
            this.gpbPesquisarMesas.TabStop = false;
            this.gpbPesquisarMesas.Text = "Pesquisar Mesas";
            // 
            // lstPesquisar
            // 
            this.lstPesquisar.FormattingEnabled = true;
            this.lstPesquisar.ItemHeight = 20;
            this.lstPesquisar.Location = new System.Drawing.Point(49, 88);
            this.lstPesquisar.Name = "lstPesquisar";
            this.lstPesquisar.Size = new System.Drawing.Size(212, 144);
            this.lstPesquisar.TabIndex = 11;
            // 
            // rdbIndisponivel
            // 
            this.rdbIndisponivel.AutoSize = true;
            this.rdbIndisponivel.Location = new System.Drawing.Point(151, 38);
            this.rdbIndisponivel.Name = "rdbIndisponivel";
            this.rdbIndisponivel.Size = new System.Drawing.Size(110, 24);
            this.rdbIndisponivel.TabIndex = 1;
            this.rdbIndisponivel.TabStop = true;
            this.rdbIndisponivel.Text = "Indisponível";
            this.rdbIndisponivel.UseVisualStyleBackColor = true;
            // 
            // rdbDisponivel
            // 
            this.rdbDisponivel.AutoSize = true;
            this.rdbDisponivel.Location = new System.Drawing.Point(10, 36);
            this.rdbDisponivel.Name = "rdbDisponivel";
            this.rdbDisponivel.Size = new System.Drawing.Size(99, 24);
            this.rdbDisponivel.TabIndex = 0;
            this.rdbDisponivel.TabStop = true;
            this.rdbDisponivel.Text = "Disponível";
            this.rdbDisponivel.UseVisualStyleBackColor = true;
            // 
            // frmAlugarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gpbPesquisarMesas);
            this.Controls.Add(this.txtStatusDoAluguel);
            this.Controls.Add(this.txtCodMesa);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.lblStatusDoAluguel);
            this.Controls.Add(this.lblCodMesa);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.btnAlugar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAlugarMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodizío - Alugar Mesa";
            this.gpbPesquisarMesas.ResumeLayout(false);
            this.gpbPesquisarMesas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblCodMesa;
        private System.Windows.Forms.Label lblStatusDoAluguel;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.TextBox txtCodMesa;
        private System.Windows.Forms.TextBox txtStatusDoAluguel;
        private System.Windows.Forms.GroupBox gpbPesquisarMesas;
        private System.Windows.Forms.ListBox lstPesquisar;
        private System.Windows.Forms.RadioButton rdbIndisponivel;
        private System.Windows.Forms.RadioButton rdbDisponivel;
    }
}