
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbQualidade = new System.Windows.Forms.ComboBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorDaGorjeta = new System.Windows.Forms.TextBox();
            this.btnCalcularGorjeta = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorDaGorjeta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorDaConta = new System.Windows.Forms.Label();
            this.txtValorDaConta = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gpbCalculadoraGorjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCalculadoraGorjeta
            // 
            this.gpbCalculadoraGorjeta.Controls.Add(this.txtCodigo);
            this.gpbCalculadoraGorjeta.Controls.Add(this.label2);
            this.gpbCalculadoraGorjeta.Controls.Add(this.cbbQualidade);
            this.gpbCalculadoraGorjeta.Controls.Add(this.txtValorTotal);
            this.gpbCalculadoraGorjeta.Controls.Add(this.txtValorDaGorjeta);
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
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(535, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(103, 26);
            this.txtCodigo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código";
            // 
            // cbbQualidade
            // 
            this.cbbQualidade.FormattingEnabled = true;
            this.cbbQualidade.Items.AddRange(new object[] {
            "Execelente -10%",
            "Ótimo - 8%",
            "Bom - 5%",
            "Ruim - 2%"});
            this.cbbQualidade.Location = new System.Drawing.Point(54, 169);
            this.cbbQualidade.Name = "cbbQualidade";
            this.cbbQualidade.Size = new System.Drawing.Size(409, 28);
            this.cbbQualidade.TabIndex = 9;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(54, 381);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(409, 26);
            this.txtValorTotal.TabIndex = 8;
            // 
            // txtValorDaGorjeta
            // 
            this.txtValorDaGorjeta.Location = new System.Drawing.Point(54, 304);
            this.txtValorDaGorjeta.Name = "txtValorDaGorjeta";
            this.txtValorDaGorjeta.Size = new System.Drawing.Size(409, 26);
            this.txtValorDaGorjeta.TabIndex = 7;
            // 
            // btnCalcularGorjeta
            // 
            this.btnCalcularGorjeta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcularGorjeta.Location = new System.Drawing.Point(108, 203);
            this.btnCalcularGorjeta.Name = "btnCalcularGorjeta";
            this.btnCalcularGorjeta.Size = new System.Drawing.Size(320, 34);
            this.btnCalcularGorjeta.TabIndex = 6;
            this.btnCalcularGorjeta.Text = "Calcular Gorjeta";
            this.btnCalcularGorjeta.UseVisualStyleBackColor = false;
            this.btnCalcularGorjeta.Click += new System.EventHandler(this.btnCalcularGorjeta_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(50, 348);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(85, 20);
            this.lblValorTotal.TabIndex = 4;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // lblValorDaGorjeta
            // 
            this.lblValorDaGorjeta.AutoSize = true;
            this.lblValorDaGorjeta.Location = new System.Drawing.Point(50, 251);
            this.lblValorDaGorjeta.Name = "lblValorDaGorjeta";
            this.lblValorDaGorjeta.Size = new System.Drawing.Size(121, 20);
            this.lblValorDaGorjeta.TabIndex = 3;
            this.lblValorDaGorjeta.Text = "Valor da gorjeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qualidade Do Serviço";
            // 
            // lblValorDaConta
            // 
            this.lblValorDaConta.AutoSize = true;
            this.lblValorDaConta.Location = new System.Drawing.Point(50, 77);
            this.lblValorDaConta.Name = "lblValorDaConta";
            this.lblValorDaConta.Size = new System.Drawing.Size(115, 20);
            this.lblValorDaConta.TabIndex = 1;
            this.lblValorDaConta.Text = "Valor da Conta";
            // 
            // txtValorDaConta
            // 
            this.txtValorDaConta.Location = new System.Drawing.Point(54, 100);
            this.txtValorDaConta.Name = "txtValorDaConta";
            this.txtValorDaConta.Size = new System.Drawing.Size(409, 26);
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
        private System.Windows.Forms.TextBox txtValorDaGorjeta;
        private System.Windows.Forms.Button btnCalcularGorjeta;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorDaGorjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorDaConta;
        private System.Windows.Forms.TextBox txtValorDaConta;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cbbQualidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}