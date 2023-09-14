
namespace MercadoSA
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblVariavel1 = new System.Windows.Forms.Label();
            this.lblVariavel2 = new System.Windows.Forms.Label();
            this.lbtTitResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpOperador = new System.Windows.Forms.GroupBox();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtVariavel1 = new System.Windows.Forms.TextBox();
            this.txtVariavel2 = new System.Windows.Forms.TextBox();
            this.gpOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVariavel1
            // 
            this.lblVariavel1.AutoSize = true;
            this.lblVariavel1.Location = new System.Drawing.Point(78, 53);
            this.lblVariavel1.Name = "lblVariavel1";
            this.lblVariavel1.Size = new System.Drawing.Size(54, 13);
            this.lblVariavel1.TabIndex = 0;
            this.lblVariavel1.Text = "Variável 1";
            // 
            // lblVariavel2
            // 
            this.lblVariavel2.AutoSize = true;
            this.lblVariavel2.Location = new System.Drawing.Point(78, 181);
            this.lblVariavel2.Name = "lblVariavel2";
            this.lblVariavel2.Size = new System.Drawing.Size(54, 13);
            this.lblVariavel2.TabIndex = 1;
            this.lblVariavel2.Text = "Variável 2";
            // 
            // lbtTitResultado
            // 
            this.lbtTitResultado.AutoSize = true;
            this.lbtTitResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbtTitResultado.Location = new System.Drawing.Point(646, 53);
            this.lbtTitResultado.Name = "lbtTitResultado";
            this.lbtTitResultado.Size = new System.Drawing.Size(55, 13);
            this.lbtTitResultado.TabIndex = 2;
            this.lbtTitResultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalcular.Location = new System.Drawing.Point(605, 191);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 66);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpar.Location = new System.Drawing.Point(605, 279);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 66);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSair.Location = new System.Drawing.Point(605, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 66);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpOperador
            // 
            this.gpOperador.Controls.Add(this.rdbDivisao);
            this.gpOperador.Controls.Add(this.rdbMultiplicacao);
            this.gpOperador.Controls.Add(this.rdbSubtracao);
            this.gpOperador.Controls.Add(this.rdbAdicao);
            this.gpOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpOperador.Location = new System.Drawing.Point(278, 147);
            this.gpOperador.Name = "gpOperador";
            this.gpOperador.Size = new System.Drawing.Size(223, 274);
            this.gpOperador.TabIndex = 6;
            this.gpOperador.TabStop = false;
            this.gpOperador.Text = "Operadorações";
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAdicao.Location = new System.Drawing.Point(15, 28);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(94, 22);
            this.rdbAdicao.TabIndex = 2;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "Adição (+)";
            this.rdbAdicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbSubtracao.Location = new System.Drawing.Point(15, 75);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(113, 22);
            this.rdbSubtracao.TabIndex = 3;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração (-)";
            this.rdbSubtracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(15, 117);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(135, 22);
            this.rdbMultiplicacao.TabIndex = 4;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multipilicação (*)";
            this.rdbMultiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(16, 159);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(93, 22);
            this.rdbDivisao.TabIndex = 5;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão (/)";
            this.rdbDivisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Location = new System.Drawing.Point(626, 98);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 33);
            this.lblResultado.TabIndex = 6;
            // 
            // txtVariavel1
            // 
            this.txtVariavel1.Location = new System.Drawing.Point(138, 50);
            this.txtVariavel1.MaxLength = 50;
            this.txtVariavel1.Name = "txtVariavel1";
            this.txtVariavel1.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel1.TabIndex = 0;
            // 
            // txtVariavel2
            // 
            this.txtVariavel2.Location = new System.Drawing.Point(138, 178);
            this.txtVariavel2.MaxLength = 50;
            this.txtVariavel2.Name = "txtVariavel2";
            this.txtVariavel2.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel2.TabIndex = 1;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.txtVariavel2);
            this.Controls.Add(this.txtVariavel1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpOperador);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbtTitResultado);
            this.Controls.Add(this.lblVariavel2);
            this.Controls.Add(this.lblVariavel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalculadora";
            this.gpOperador.ResumeLayout(false);
            this.gpOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariavel1;
        private System.Windows.Forms.Label lblVariavel2;
        private System.Windows.Forms.Label lbtTitResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpOperador;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtVariavel1;
        private System.Windows.Forms.TextBox txtVariavel2;
    }
}