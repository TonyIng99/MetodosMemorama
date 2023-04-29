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
    public partial class Registro : Form
    { 
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
          
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese un usuario en el campo. No puede ir vacío.");
                return;
            }
                Form1 nombre = new Form1();
                this.Visible = false;
                nombre.setNombre(textBox1.Text);
                nombre.ShowDialog();
                this.Visible = true;
                this.Close();
                      
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
