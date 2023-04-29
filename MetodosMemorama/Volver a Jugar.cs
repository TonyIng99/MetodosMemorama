using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosMemorama
{
    public partial class Volver_a_Jugar : Form
    {
        public Volver_a_Jugar()
        {
            InitializeComponent();
        }

        private void lbPlayAgain_Click(object sender, EventArgs e)
        {

        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
