namespace MetodosMemorama
{
    partial class PreguntasRespuestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreguntasRespuestas));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btnEnviar = new Button();
            lbPuntos = new Label();
            lbtextpuntos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1100, 600);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.OldLace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(817, 328);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 40);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.MidnightBlue;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.Yellow;
            btnEnviar.Location = new Point(942, 414);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(89, 43);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lbPuntos
            // 
            lbPuntos.AutoSize = true;
            lbPuntos.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lbPuntos.ForeColor = SystemColors.ControlLightLight;
            lbPuntos.Location = new Point(1198, 353);
            lbPuntos.Name = "lbPuntos";
            lbPuntos.Size = new Size(92, 112);
            lbPuntos.TabIndex = 3;
            lbPuntos.Text = "0";
            lbPuntos.Click += lbPuntos_Click;
            // 
            // lbtextpuntos
            // 
            lbtextpuntos.AutoSize = true;
            lbtextpuntos.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lbtextpuntos.ForeColor = SystemColors.ButtonHighlight;
            lbtextpuntos.Location = new Point(1152, 271);
            lbtextpuntos.Name = "lbtextpuntos";
            lbtextpuntos.Size = new Size(180, 67);
            lbtextpuntos.TabIndex = 4;
            lbtextpuntos.Text = "Puntos";
            // 
            // PreguntasRespuestas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1370, 596);
            Controls.Add(lbtextpuntos);
            Controls.Add(lbPuntos);
            Controls.Add(btnEnviar);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "PreguntasRespuestas";
            Text = "PreguntasRespuestas";
            Load += PreguntasRespuestas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnEnviar;
        private Label lbPuntos;
        private Label lbtextpuntos;
    }
}