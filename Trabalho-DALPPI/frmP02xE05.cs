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
    public partial class frmP02xE05 : Form
    {
        public frmP02xE05()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int diferença;
            Utilitarios objDiferenca = new Utilitarios();

            diferença = objDiferenca.DiferencadeDias(Convert.ToDateTime(mtxtDtFinal.Text), Convert.ToDateTime(mtxtDtInicial.Text));
            MessageBox.Show("A diferença de dias é: " + diferença);
        }
    }
}
