using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.Formularios
{
    public partial class FrmGrado : Form
    {
        public FrmGrado()
        {
            InitializeComponent();
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            FormMenuPrueba f = new FormMenuPrueba();
            f.Show();
            this.Hide();
        }

        //testing
        private void btnAgregarGrado_Click(object sender, EventArgs e)
        {

        }
    }
}
