
namespace MercadoSA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ckbLivro = new System.Windows.Forms.CheckBox();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.ddtCalendario = new System.Windows.Forms.DateTimePicker();
            this.t = new System.Windows.Forms.Label();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(25, 62);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // ckbLivro
            // 
            this.ckbLivro.AutoSize = true;
            this.ckbLivro.Location = new System.Drawing.Point(20, 151);
            this.ckbLivro.Name = "ckbLivro";
            this.ckbLivro.Size = new System.Drawing.Size(49, 17);
            this.ckbLivro.TabIndex = 1;
            this.ckbLivro.Text = "Livro";
            this.ckbLivro.UseVisualStyleBackColor = true;
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(638, 52);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(121, 21);
            this.cbbProdutos.TabIndex = 2;
            this.cbbProdutos.SelectedIndexChanged += new System.EventHandler(this.cbbProdutos_SelectedIndexChanged);
            // 
            // ddtCalendario
            // 
            this.ddtCalendario.Location = new System.Drawing.Point(574, 26);
            this.ddtCalendario.Name = "ddtCalendario";
            this.ddtCalendario.Size = new System.Drawing.Size(200, 20);
            this.ddtCalendario.TabIndex = 3;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(33, 218);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(35, 13);
            this.t.TabIndex = 4;
            this.t.Text = "Nome";
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(616, 238);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(120, 95);
            this.lstProdutos.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(659, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(626, 131);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 7;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.t);
            this.Controls.Add(this.ddtCalendario);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.ckbLivro);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox ckbLivro;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.DateTimePicker ddtCalendario;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbFeminino;
    }
}

