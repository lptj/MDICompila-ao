namespace Trabalho_DALPPI
{
    partial class frmP02xE05
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
            this.mtxtDtInicial = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDtFinal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtDtInicial
            // 
            this.mtxtDtInicial.Location = new System.Drawing.Point(96, 50);
            this.mtxtDtInicial.Mask = "00/00/0000";
            this.mtxtDtInicial.Name = "mtxtDtInicial";
            this.mtxtDtInicial.Size = new System.Drawing.Size(70, 20);
            this.mtxtDtInicial.TabIndex = 9;
            this.mtxtDtInicial.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDtFinal
            // 
            this.mtxtDtFinal.Location = new System.Drawing.Point(96, 89);
            this.mtxtDtFinal.Mask = "00/00/0000";
            this.mtxtDtFinal.Name = "mtxtDtFinal";
            this.mtxtDtFinal.Size = new System.Drawing.Size(70, 20);
            this.mtxtDtFinal.TabIndex = 10;
            this.mtxtDtFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data Final:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(52, 121);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Diferença de Dias";
            // 
            // frmP02xE05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 156);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtDtFinal);
            this.Controls.Add(this.mtxtDtInicial);
            this.Controls.Add(this.label1);
            this.Name = "frmP02xE05";
            this.Text = "2- Exercício 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtDtInicial;
        private System.Windows.Forms.MaskedTextBox mtxtDtFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
    }
}