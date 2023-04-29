using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MetodosMemorama
{
    public partial class PreguntasRespuestas : Form
    {
        private Dictionary<Image, string> imagenesYrespuestas = new Dictionary<Image, string>();
        private List<Image> listaImagenes = new List<Image>();
        public static int puntos;
        public int intentos = 0;
        public int AcumulacionPuntos;
        public int imagenesAdivinadas;
        public PreguntasRespuestas()
        {

            InitializeComponent();
            AcumulacionPuntos = Properties.Settings.Default.AcumulacionPuntos;
            lbPuntos.Text = AcumulacionPuntos.ToString();
            this.lbPuntos.Text= puntos.ToString();

            // Agregar las imágenes y sus respuestas al diccionario
            imagenesYrespuestas.Add(Properties.Resources.pregunta1, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta2, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta3, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta4, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta5, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta6, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta7, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta8, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta9, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta10, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta11, "A");
            imagenesYrespuestas.Add(Properties.Resources.pregunta12, "A");



            // Agregar las imágenes a la lista de imágenes
            foreach (var imagen in imagenesYrespuestas.Keys)
            {
                listaImagenes.Add(imagen);
            }
        }

        //private bool todasLasImagenesDescubiertas()
        //{
           // return listaImagenes.Count == 0;
        //}

        private void MostrarImagenAleatoria()
        {
            //if(todasLasImagenesDescubiertas())
            //{
              //  MessageBox.Show("Completaste el memorama" + puntos.ToString());
              //  this.Close();
               // return;
            //}

            Random rnd = new Random();
            int indiceAleatorio = rnd.Next(listaImagenes.Count);
            Image imagenAleatoria = listaImagenes[indiceAleatorio];
            pictureBox1.Image = imagenAleatoria;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PreguntasRespuestas_Load(object sender, EventArgs e)
        {
            MostrarImagenAleatoria();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string respuesta = textBox1.Text;
            Image imagenActual = pictureBox1.Image;
            intentos++;

            if (imagenesYrespuestas[imagenActual] == respuesta && intentos == 1)
            {
                // Respuesta correcta
                MessageBox.Show("¡Respuesta correcta! Ganaste 10 puntos");
                
                puntos += 10;
                lbPuntos.Text = "" + puntos.ToString();
                AcumulacionPuntos += puntos;
                lbPuntos.Text = AcumulacionPuntos.ToString();
                
                
               
               //this.Hide();

                //this.Close();

            }
            else
            {
                if (imagenesYrespuestas[imagenActual] == respuesta && intentos == 2)
                {
                    MessageBox.Show("¡Respuesta correcta! Ganaste 5 puntos");
                    puntos += 5;
                    lbPuntos.Text = "" + puntos.ToString();

                   
                   
                    //this.Hide();

                }

                else if (imagenesYrespuestas[imagenActual] == respuesta && intentos == 3)
                {
                    MessageBox.Show("¡Respuesta correcta! Ganaste 1 punto");
                    puntos += 1;
                    lbPuntos.Text = "" + puntos.ToString();

                   
                   // this.Hide();

                }

                else if (imagenesYrespuestas[imagenActual] != respuesta && intentos == 4)
                {
                    MessageBox.Show("¡Limite de Oportunidades! No ganaste puntos");

                    this.Close();

                }

            }
        }


        private void lbPuntos_Click(object sender, EventArgs e)
        {

        }

        private void PreguntasRespuestas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.AcumulacionPuntos = AcumulacionPuntos;
            Properties.Settings.Default.Save();
        }
        
}
}

