namespace Trabalho_DALPPI
{
    partial class frmP01xE03
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.rbtnTempKelvin = new System.Windows.Forms.RadioButton();
            this.rbtnTempFahrenheit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temperatura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(13, 193);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(186, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(56, 71);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 7;
            // 
            // rbtnTempKelvin
            // 
            this.rbtnTempKelvin.AutoSize = true;
            this.rbtnTempKelvin.Checked = true;
            this.rbtnTempKelvin.Location = new System.Drawing.Point(19, 25);
            this.rbtnTempKelvin.Name = "rbtnTempKelvin";
            this.rbtnTempKelvin.Size = new System.Drawing.Size(134, 17);
            this.rbtnTempKelvin.TabIndex = 8;
            this.rbtnTempKelvin.TabStop = true;
            this.rbtnTempKelvin.Text = "Temperatura em Kelvin";
            this.rbtnTempKelvin.UseVisualStyleBackColor = true;
            // 
            // rbtnTempFahrenheit
            // 
            this.rbtnTempFahrenheit.AutoSize = true;
            this.rbtnTempFahrenheit.Location = new System.Drawing.Point(19, 48);
            this.rbtnTempFahrenheit.Name = "rbtnTempFahrenheit";
            this.rbtnTempFahrenheit.Size = new System.Drawing.Size(155, 17);
            this.rbtnTempFahrenheit.TabIndex = 9;
            this.rbtnTempFahrenheit.Text = "Temperatura em Fahrenheit";
            this.rbtnTempFahrenheit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTempKelvin);
            this.groupBox1.Controls.Add(this.rbtnTempFahrenheit);
            this.groupBox1.Location = new System.Drawing.Point(13, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 80);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha uma Opção";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Temperatura em Celsius:";
            // 
            // frmPrimPartEx3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "frmPrimPartEx3";
            this.Text = "1- Exercício 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.RadioButton rbtnTempKelvin;
        private System.Windows.Forms.RadioButton rbtnTempFahrenheit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}