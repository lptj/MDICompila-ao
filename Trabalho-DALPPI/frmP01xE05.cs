using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_DALPPI
{
    public partial class frmP01xE05 : Form
    {
        public frmP01xE05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Utilitarios objIdade = new Utilitarios();
            int idade;

            idade = objIdade.Idade(Convert.ToDateTime(mtxtData.Text));
            MessageBox.Show(Convert.ToString("Sua idade é: " + idade + " anos!"));
        }
    }
}
