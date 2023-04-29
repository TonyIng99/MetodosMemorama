using System.Configuration;
using System.Diagnostics;
using System.Reflection;

namespace MetodosMemorama
{
    public partial class Form1 : Form
    {
        //Conexione
        Stopwatch oSW = new Stopwatch();
        List<icon> _icons = new List<icon>();
        Random _random = new Random();
        Panel firstSelection, secondSelection;
        Panel firstCoverSelection, secondCoverSelection;
        Dictionary<string, int> assignedPanels = new Dictionary<string, int>();
        

        public Form1()
        {
            InitializeComponent();
            LoadImagesFromFiles();
            PopulateToTable();
            ShowCardsInit(true);


        }

        public void setNombre(string nombre)
        {
            this.labeluser.Text = nombre;

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Registro usuario = new Registro();
            // usuario.ShowDialog();
            oSW.Start();
            cronometro.Enabled = true;
        }


        private void pnlCover12_Paint(object sender, PaintEventArgs e)
        {

        }

        //Muestra las imagenes de las cartas.
        private void ShowCardsInit(bool showCards)
        {
            pnlCover1.Visible = !showCards;
            pnlCover2.Visible = !showCards;
            pnlCover3.Visible = !showCards;
            pnlCover4.Visible = !showCards;
            pnlCover5.Visible = !showCards;
            pnlCover6.Visible = !showCards;
            pnlCover7.Visible = !showCards;
            pnlCover8.Visible = !showCards;
            pnlCover9.Visible = !showCards;
            pnlCover10.Visible = !showCards;
            pnlCover11.Visible = !showCards;
            pnlCover12.Visible = !showCards;
            pnlCover13.Visible = !showCards;
            pnlCover14.Visible = !showCards;
            pnlCover15.Visible = !showCards;
            pnlCover16.Visible = !showCards;
            pnlCover17.Visible = !showCards;
            pnlCover18.Visible = !showCards;
            pnlCover19.Visible = !showCards;
            pnlCover20.Visible = !showCards;
            pnlCover21.Visible = !showCards;
            pnlCover22.Visible = !showCards;
            pnlCover23.Visible = !showCards;
            pnlCover24.Visible = !showCards;

            timerinit.Start();
        }

        //Las figuras de las cartas desaparecen despues de cierto tiempo.
        private void timerinit_Tick(object sender, EventArgs e)
        {
            timerinit.Stop();
            ShowCardsInit(false);
            timerinit.Dispose();
        }

        private void LoadImagesFromFiles()
        {
            var files = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            int id = 1;

            foreach (var picture in files)
            {
                if (!picture.EndsWith(".png"))
                {
                    continue;
                }


                var Icon = new icon
                {
                    Id = id,
                    Name = picture.Replace("MetodosMemorama.Resources.", "").Replace(".png", ""),
                    Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(picture))
                };

                _icons.Add(Icon);
                _icons.Add(Icon);

                id++;
            }
        }




        //Las figuras de las cartas aparecen aleatoriamente.
        private void PopulateToTable()
        {
            Panel panel;
            int randomNumber;

            foreach (var item in this.Controls)
            {
                if (item is Panel && !((Panel)item).Name.Contains("pnlCover"))
                    panel = (Panel)item;
                else
                    continue;

                randomNumber = _random.Next(0, _icons.Count);
                panel.BackgroundImage = _icons[randomNumber].Image;

                assignedPanels.Add(panel.Name, _icons[randomNumber].Id);

                _icons.RemoveAt(randomNumber);
            }
        }


        //Metodo el cual le das click a las cartas.
        private void pnlCover_Click(object sender, EventArgs e)
        {
            //Intento++;

            if (firstSelection != null && secondSelection != null)
            {
                return;
            }


            Panel clickedPanel = (Panel)sender;



            if (clickedPanel == null)
            {
                return;
            }

            if (!clickedPanel.Visible)
            {
                return;
            }
            clickedPanel.Visible = false;


            if (firstSelection == null)
            {
                firstSelection = GetIconPanel(clickedPanel);
                firstCoverSelection = clickedPanel;
                return;
            }

            if (secondSelection == null)
            {
                secondSelection = GetIconPanel(clickedPanel);
                secondCoverSelection = clickedPanel;
            }

            if (firstSelection != null && secondSelection != null && CheckForMatch())
            {
                CleanSelections(true);
                PreguntasRespuestas pregunta = new PreguntasRespuestas();
                pregunta.ShowDialog();

                
                bool allVisible = true;
                foreach (var item in this.Controls)
                {
                    if (item is Panel && ((Panel)item).Name.Contains("pnlCover"))
                    {
                        if (((Panel)item).Visible == true)
                        {
                            allVisible = false;
                            break;
                        }
                        if (allVisible)
                        {
                            Volver_a_Jugar volverAJugar = new Volver_a_Jugar();
                            volverAJugar.Show();
                            //this.Hide();
                            return;
                        }

                    }

                }
                // Open "Volver a jugar" form if all images are visible

            }

            else
            {
                ResetUnmatched();

            }

        }

        //Relaciona los paneles
        private Panel GetIconPanel(Panel coverPanel)
        {
            Panel iconPanel = null;

            foreach (var item in this.Controls)
            {
                if (item is Panel
                    && !((Panel)item).Name.Contains("pnlCover")
                    && ((Panel)item).Tag == coverPanel.Tag)
                {
                    iconPanel = (Panel)item;
                }
            }
            return iconPanel;
        }

        //Metodo el cual se dejan las cartas que tienen el mismo par visibles.
        private bool CheckForMatch()
        {
            return 
                assignedPanels[firstSelection.Name] == assignedPanels[secondSelection.Name];


        }

        //Tiempo en donde al inicio de la partida da 5 segundos para que el usuario visualice donde
        //esta cada par y desaparecen todas las cartas en ese mismo tiempo.
        private void timer1_Tick(object sender, EventArgs e)
        {
            CleanSelections(false);
            timer1.Stop();
        }

        private void labeluser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_tick(object sender, EventArgs e)
        {

        }


        //Metodo del cronometro con su label y limite de tiempo.
        private void cronometro_Tick(object sender, EventArgs e)

        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);



            lbmin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            lbseg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();

            if (ts.Seconds == 2400 || ts.Minutes == 2400)
            {
                cronometro.Stop();
                MessageBox.Show("Tiempo agotado");
            }





        }

        private void lbmlseg_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void pnlCover1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerlimit_Tick(object sender, EventArgs e)
        {

        }

        public void lbpuntos_Click(object sender, EventArgs e)
        {

        }



        //Desaparecen la figuras si los clicks son distintos.
        private void CleanSelections(bool match)
        {
            if (!match)
            {
                firstCoverSelection.Visible = true;
                secondCoverSelection.Visible = true;
            }



           

           

            firstCoverSelection = null;
            secondCoverSelection = null;
            firstSelection = null;
            secondSelection = null;
        }


        //Desaparecen las figuras en un determinado tiempo si son distintas las cartas.
        private void ResetUnmatched()
        {
            timer1.Start();
        }
    }

}