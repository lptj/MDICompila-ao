namespace Trabalho_DALPPI
{
    partial class frmP04xE01
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
            this.btnRes = new System.Windows.Forms.Button();
            this.txtN8 = new System.Windows.Forms.TextBox();
            this.txtN7 = new System.Windows.Forms.TextBox();
            this.txtN6 = new System.Windows.Forms.TextBox();
            this.txtN5 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ano Bissexto";
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(122, 118);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 19;
            this.btnRes.Text = "Resultado";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // txtN8
            // 
            this.txtN8.Location = new System.Drawing.Point(270, 72);
            this.txtN8.Name = "txtN8";
            this.txtN8.Size = new System.Drawing.Size(31, 20);
            this.txtN8.TabIndex = 18;
            this.txtN8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN1_KeyPress);
            // 
            // txtN7
            // 
            this.txtN7.Location = new System.Drawing.Point(233, 72);
            this.txtN7.Name = "txtN7";
            this.txtN7.Size = new System.Drawing.Size(31, 20);
            this.txtN7.TabIndex = 17;
            this.txtN7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN1_KeyPress);
            // 
            // txtN6
            // 
            this.txtN6.Location = new System.Drawing.Point(196, 72);
            this.txtN6.Name = "txtN6";
            this.txtN6.Size = new System.Drawing.Size(31, 20);
            this.txtN6.TabIndex = 16;
            this.txtN6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN1_KeyPress);
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(159, 72);
            this.txtN5.Name = "txtN5";
            this.txtN5.Size = new System.Drawing.Size(31, 20);
            this.txtN5.TabIndex = 15;
            this.txtN5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN1_KeyPress);
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(122, 72);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(31, 20);
            this.txtN4.TabIndex = 14;
            this.txtN4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN1_KeyPress);
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(85, 72);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(31, 20);
            this.txtN3.TabIndex = 13;
            this.txtN3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN1_KeyPress);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(48, 72);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(31, 20);
            this.txtN2.TabIndex = 12;
            this.txtN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN1_KeyPress);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(11, 72);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(31, 20);
            this.txtN1.TabIndex = 11;
            this.txtN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digite os números:";
            // 
            // frmP04xE01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 160);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.txtN8);
            this.Controls.Add(this.txtN7);
            this.Controls.Add(this.txtN6);
            this.Controls.Add(this.txtN5);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmP04xE01";
            this.Text = "4- Exercício 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.TextBox txtN8;
        private System.Windows.Forms.TextBox txtN7;
        private System.Windows.Forms.TextBox txtN6;
        private System.Windows.Forms.TextBox txtN5;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label1;
    }
}