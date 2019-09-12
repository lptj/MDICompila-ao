namespace Trabalho_DALPPI
{
    partial class frmP03xE04
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerif = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ano Bissexto";
            // 
            // btnVerif
            // 
            this.btnVerif.Location = new System.Drawing.Point(56, 99);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(75, 23);
            this.btnVerif.TabIndex = 6;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(80, 60);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 5;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o ano:";
            // 
            // frmP03xE04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 137);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label1);
            this.Name = "frmP03xE04";
            this.Text = "3- Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label1;
    }
}