namespace Trabalho_DALPPI
{
    partial class frmP03xE01
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
            this.btnVerif = new System.Windows.Forms.Button();
            this.lsbAdicionados = new System.Windows.Forms.ListBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtNums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerif
            // 
            this.btnVerif.Location = new System.Drawing.Point(67, 224);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(75, 23);
            this.btnVerif.TabIndex = 9;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            // 
            // lsbAdicionados
            // 
            this.lsbAdicionados.FormattingEnabled = true;
            this.lsbAdicionados.Location = new System.Drawing.Point(12, 112);
            this.lsbAdicionados.Name = "lsbAdicionados";
            this.lsbAdicionados.Size = new System.Drawing.Size(195, 95);
            this.lsbAdicionados.TabIndex = 8;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(116, 74);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 7;
            this.btnADD.Text = "Adicionar";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtNums
            // 
            this.txtNums.Location = new System.Drawing.Point(102, 45);
            this.txtNums.Name = "txtNums";
            this.txtNums.Size = new System.Drawing.Size(100, 20);
            this.txtNums.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista";
            // 
            // frmP03xE01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.lsbAdicionados);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtNums);
            this.Controls.Add(this.label1);
            this.Name = "frmP03xE01";
            this.Text = "3- Exercício 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.ListBox lsbAdicionados;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtNums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}