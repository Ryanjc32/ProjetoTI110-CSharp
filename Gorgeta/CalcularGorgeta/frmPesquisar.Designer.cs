﻿
namespace CalcularGorgeta
{
    partial class frmPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
            this.ltsPesquisar = new System.Windows.Forms.ListBox();
            this.gppPesquisarPor = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbbFuncionarios = new System.Windows.Forms.ComboBox();
            this.gppPesquisarPor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltsPesquisar
            // 
            this.ltsPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltsPesquisar.FormattingEnabled = true;
            this.ltsPesquisar.HorizontalExtent = 4;
            this.ltsPesquisar.ItemHeight = 20;
            this.ltsPesquisar.Location = new System.Drawing.Point(28, 323);
            this.ltsPesquisar.Name = "ltsPesquisar";
            this.ltsPesquisar.Size = new System.Drawing.Size(590, 184);
            this.ltsPesquisar.TabIndex = 10;
            // 
            // gppPesquisarPor
            // 
            this.gppPesquisarPor.Controls.Add(this.cbbFuncionarios);
            this.gppPesquisarPor.Controls.Add(this.btnPesquisar);
            this.gppPesquisarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gppPesquisarPor.Location = new System.Drawing.Point(28, 38);
            this.gppPesquisarPor.Name = "gppPesquisarPor";
            this.gppPesquisarPor.Size = new System.Drawing.Size(590, 233);
            this.gppPesquisarPor.TabIndex = 8;
            this.gppPesquisarPor.TabStop = false;
            this.gppPesquisarPor.Text = "Pesquisar por Nome";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Location = new System.Drawing.Point(661, 459);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 63);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisar.Location = new System.Drawing.Point(33, 126);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(147, 32);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(661, 333);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 63);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbbFuncionarios
            // 
            this.cbbFuncionarios.FormattingEnabled = true;
            this.cbbFuncionarios.Location = new System.Drawing.Point(33, 50);
            this.cbbFuncionarios.Name = "cbbFuncionarios";
            this.cbbFuncionarios.Size = new System.Drawing.Size(247, 28);
            this.cbbFuncionarios.TabIndex = 13;
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.ltsPesquisar);
            this.Controls.Add(this.gppPesquisarPor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisar";
            this.Text = "frmPesquisar";
            this.gppPesquisarPor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltsPesquisar;
        private System.Windows.Forms.GroupBox gppPesquisarPor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbbFuncionarios;
    }
}