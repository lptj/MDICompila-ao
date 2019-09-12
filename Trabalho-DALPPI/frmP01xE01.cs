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
    public partial class frmP01xE01 : Form
    {
        public frmP01xE01()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Utilitarios objClasse = new Utilitarios();
            var retorno = objClasse.Segundos(Convert.ToInt32(txtSegundos.Text));
            
            MessageBox.Show("Hora: "+retorno.Item3 + " Minuto: "+retorno.Item2+" Segundo: "+retorno.Item1);
        }
    }
}
