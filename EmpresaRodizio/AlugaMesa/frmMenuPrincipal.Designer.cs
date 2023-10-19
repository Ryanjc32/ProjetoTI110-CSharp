
namespace AlugaMesa
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnMesas = new System.Windows.Forms.Button();
            this.bntAluguel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesas
            // 
            this.btnMesas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesas.Image = ((System.Drawing.Image)(resources.GetObject("btnMesas.Image")));
            this.btnMesas.Location = new System.Drawing.Point(112, 108);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(213, 250);
            this.btnMesas.TabIndex = 0;
            this.btnMesas.Text = "Cadastrar Mesas";
            this.btnMesas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMesas.UseVisualStyleBackColor = false;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // bntAluguel
            // 
            this.bntAluguel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAluguel.Image = ((System.Drawing.Image)(resources.GetObject("bntAluguel.Image")));
            this.bntAluguel.Location = new System.Drawing.Point(486, 108);
            this.bntAluguel.Name = "bntAluguel";
            this.bntAluguel.Size = new System.Drawing.Size(213, 250);
            this.bntAluguel.TabIndex = 1;
            this.bntAluguel.Text = "Alugar Mesas";
            this.bntAluguel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntAluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntAluguel.UseVisualStyleBackColor = false;
            this.bntAluguel.Click += new System.EventHandler(this.bntAluguel_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.bntAluguel);
            this.Controls.Add(this.btnMesas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodizío - Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Button bntAluguel;
    }
}

