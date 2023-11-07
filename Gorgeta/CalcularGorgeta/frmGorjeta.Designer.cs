
namespace CalcularGorgeta
{
    partial class frmGorjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGorjeta));
            this.gpbCalculadoraGorjeta = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodConta = new System.Windows.Forms.Label();
            this.cbbQualidade = new System.Windows.Forms.ComboBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorGorjeta = new System.Windows.Forms.TextBox();
            this.btnCalcularGorjeta = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorDaGorjeta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorDaConta = new System.Windows.Forms.Label();
            this.txtValorDaConta = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbbNomeFunc = new System.Windows.Forms.ComboBox();
            this.gpbCalculadoraGorjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCalculadoraGorjeta
            // 
            this.gpbCalculadoraGorjeta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gpbCalculadoraGorjeta.Controls.Add(this.cbbNomeFunc);
            this.gpbCalculadoraGorjeta.Controls.Add(this.btnLimpar);
            this.gpbCalculadoraGorjeta.Controls.Add(this.lblNome);
            this.gpbCalculadoraGorjeta.Controls.Add(this.btnSalvar);
            this.gpbCalculadoraGorjeta.Controls.Add(this.txtCodigo);
            this.gpbCalculadoraGorjeta.Controls.Add(this.lblCodConta);
            this.gpbCalculadoraGorjeta.Controls.Add(this.cbbQualidade);
            this.gpbCalculadoraGorjeta.Controls.Add(this.txtValorTotal);
            this.gpbCalculadoraGorjeta.Controls.Add(this.txtValorGorjeta);
            this.gpbCalculadoraGorjeta.Controls.Add(this.btnCalcularGorjeta);
            this.gpbCalculadoraGorjeta.Controls.Add(this.lblValorTotal);
            this.gpbCalculadoraGorjeta.Controls.Add(this.lblValorDaGorjeta);
            this.gpbCalculadoraGorjeta.Controls.Add(this.label1);
            this.gpbCalculadoraGorjeta.Controls.Add(this.lblValorDaConta);
            this.gpbCalculadoraGorjeta.Controls.Add(this.txtValorDaConta);
            this.gpbCalculadoraGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCalculadoraGorjeta.Location = new System.Drawing.Point(71, 29);
            this.gpbCalculadoraGorjeta.Name = "gpbCalculadoraGorjeta";
            this.gpbCalculadoraGorjeta.Size = new System.Drawing.Size(654, 450);
            this.gpbCalculadoraGorjeta.TabIndex = 0;
            this.gpbCalculadoraGorjeta.TabStop = false;
            this.gpbCalculadoraGorjeta.Text = "Calculadora de Gorjeta";
            this.gpbCalculadoraGorjeta.Enter += new System.EventHandler(this.gpbCalculadoraGorjeta_Enter);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(453, 147);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(160, 20);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Location = new System.Drawing.Point(42, 355);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 31);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar/Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(435, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 26);
            this.txtCodigo.TabIndex = 11;
            // 
            // lblCodConta
            // 
            this.lblCodConta.AutoSize = true;
            this.lblCodConta.Location = new System.Drawing.Point(431, 36);
            this.lblCodConta.Name = "lblCodConta";
            this.lblCodConta.Size = new System.Drawing.Size(89, 20);
            this.lblCodConta.TabIndex = 10;
            this.lblCodConta.Text = "Cod. Conta";
            // 
            // cbbQualidade
            // 
            this.cbbQualidade.FormattingEnabled = true;
            this.cbbQualidade.Items.AddRange(new object[] {
            "Execelente -10%",
            "Ótimo - 8%",
            "Bom - 5%",
            "Ruim - 2%"});
            this.cbbQualidade.Location = new System.Drawing.Point(42, 123);
            this.cbbQualidade.Name = "cbbQualidade";
            this.cbbQualidade.Size = new System.Drawing.Size(336, 28);
            this.cbbQualidade.TabIndex = 9;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(42, 311);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(336, 26);
            this.txtValorTotal.TabIndex = 8;
            // 
            // txtValorGorjeta
            // 
            this.txtValorGorjeta.Location = new System.Drawing.Point(42, 230);
            this.txtValorGorjeta.Name = "txtValorGorjeta";
            this.txtValorGorjeta.Size = new System.Drawing.Size(336, 26);
            this.txtValorGorjeta.TabIndex = 7;
            // 
            // btnCalcularGorjeta
            // 
            this.btnCalcularGorjeta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcularGorjeta.Location = new System.Drawing.Point(69, 157);
            this.btnCalcularGorjeta.Name = "btnCalcularGorjeta";
            this.btnCalcularGorjeta.Size = new System.Drawing.Size(273, 34);
            this.btnCalcularGorjeta.TabIndex = 6;
            this.btnCalcularGorjeta.Text = "Calcular Gorjeta";
            this.btnCalcularGorjeta.UseVisualStyleBackColor = false;
            this.btnCalcularGorjeta.Click += new System.EventHandler(this.btnCalcularGorjeta_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(38, 277);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(85, 20);
            this.lblValorTotal.TabIndex = 4;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // lblValorDaGorjeta
            // 
            this.lblValorDaGorjeta.AutoSize = true;
            this.lblValorDaGorjeta.Location = new System.Drawing.Point(38, 207);
            this.lblValorDaGorjeta.Name = "lblValorDaGorjeta";
            this.lblValorDaGorjeta.Size = new System.Drawing.Size(121, 20);
            this.lblValorDaGorjeta.TabIndex = 3;
            this.lblValorDaGorjeta.Text = "Valor da gorjeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qualidade Do Serviço";
            // 
            // lblValorDaConta
            // 
            this.lblValorDaConta.AutoSize = true;
            this.lblValorDaConta.Location = new System.Drawing.Point(38, 36);
            this.lblValorDaConta.Name = "lblValorDaConta";
            this.lblValorDaConta.Size = new System.Drawing.Size(115, 20);
            this.lblValorDaConta.TabIndex = 1;
            this.lblValorDaConta.Text = "Valor da Conta";
            // 
            // txtValorDaConta
            // 
            this.txtValorDaConta.Location = new System.Drawing.Point(42, 71);
            this.txtValorDaConta.Name = "txtValorDaConta";
            this.txtValorDaConta.Size = new System.Drawing.Size(336, 26);
            this.txtValorDaConta.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(662, 501);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 48);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(266, 355);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 31);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbbNomeFunc
            // 
            this.cbbNomeFunc.FormattingEnabled = true;
            this.cbbNomeFunc.Location = new System.Drawing.Point(435, 183);
            this.cbbNomeFunc.Name = "cbbNomeFunc";
            this.cbbNomeFunc.Size = new System.Drawing.Size(198, 28);
            this.cbbNomeFunc.TabIndex = 17;
            this.cbbNomeFunc.SelectedIndexChanged += new System.EventHandler(this.cbbNomeFunc_SelectedIndexChanged);
            // 
            // frmGorjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbCalculadoraGorjeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGorjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGorjeta";
            this.gpbCalculadoraGorjeta.ResumeLayout(false);
            this.gpbCalculadoraGorjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCalculadoraGorjeta;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorGorjeta;
        private System.Windows.Forms.Button btnCalcularGorjeta;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorDaGorjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorDaConta;
        private System.Windows.Forms.TextBox txtValorDaConta;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cbbQualidade;
        private System.Windows.Forms.Label lblCodConta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbbNomeFunc;
    }
}