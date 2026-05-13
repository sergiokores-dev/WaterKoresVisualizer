using Timer = System.Windows.Forms.Timer;

namespace WaterKoresVisualizer
{
    public partial class Form1 : Form
    {
        // =============================================
        // CONFIGURAÇÕES
        // =============================================
        byte[][] currentImage;
        const int VALVES = 40;
        int PIXEL_SIZE = 10;
        int HEIGHT = 0;

        // velocidade da queda
        int frameDelay = 40;

        // timer de animação
        Timer timer = new Timer();

        // linha atual
        int currentLine = 0;


        // =============================================
        // MATRIZ DA ESTRELA
        // =============================================
        void LoadDefaultImage()
        {
            currentImage = new byte[][]
          {
            new byte[]  {0b00000000,0b00000000,0b00001000,0b00000000,0b00000000},
             new byte[] {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
              new byte[]{0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
              new byte[]{0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
              new byte[] {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
              new byte[] {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
              new byte[] {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
              new byte[] {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
            new byte[]   {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
              new byte[] {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
            new byte[]   {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
            new byte[]   {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
            new byte[]   {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
            new byte[]   {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
            new byte[]   {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},
            new byte[]   {0b00000000,0b00000000,0b00000000,0b00000000,0b00000000},

              new byte[] {0b00000000,0b00000000,0b00011100,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00111110,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b01111111,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b11111111,0b10000000,0b00000000},
             new byte[]  {0b00000000,0b00000001,0b11111111,0b11000000,0b00000000},
             new byte[]  {0b00000000,0b00000011,0b11111111,0b11100000,0b00000000},
             new byte[]  {0b11111111,0b11111111,0b11111111,0b11111111,0b11111111},
             new byte[]  {0b01111111,0b11111111,0b11111111,0b11111111,0b11111110},
             new byte[]  {0b00111111,0b11111111,0b11111111,0b11111111,0b11111100},
              new byte[] {0b00011111,0b11111111,0b11111111,0b11111111,0b11111000},
             new byte[]  {0b00001111,0b11111111,0b11111111,0b11111111,0b11110000},
             new byte[]  {0b00000111,0b11111111,0b11111111,0b11111111,0b11100000},
             new byte[]  {0b00000011,0b11111111,0b11111111,0b11111111,0b11000000},
             new byte[]  {0b00000111,0b11111111,0b11111111,0b11111111,0b11100000},
             new byte[]  {0b00001111,0b11111111,0b11111111,0b11111111,0b11110000},
             new byte[]  {0b00011111,0b11111111,0b11111111,0b11111111,0b11111000},
             new byte[]  {0b00111111,0b11111111,0b11111111,0b11111111,0b11111100},
             new byte[]  {0b01111111,0b11111111,0b11111111,0b11111111,0b11111110},
             new byte[]  {0b11111111,0b11111111,0b11111111,0b11111111,0b11111111},
             new byte[]  {0b00000000,0b00000011,0b11111111,0b11100000,0b00000000},
             new byte[]  {0b00000000,0b00000001,0b11111111,0b11000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b11111111,0b10000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b01111111,0b00000000,0b00000000},
              new byte[] {0b00000000,0b00000000,0b00111110,0b00000000,0b00000000},
             new byte[]  {0b00000000,0b00000000,0b00011100,0b00000000,0b00000000},

             new byte[]  {0b00000000,0b00000000,0b00001000,0b00000000,0b00000000}
        };
            HEIGHT = currentImage.Length;
            // HEIGHT = currentImage.Length;
        }

        // =============================================
        // BUFFER VISUAL
        // =============================================

        List<bool[]> renderedLines = new List<bool[]>();


        // =============================================
        // CONSTRUTOR
        // =============================================

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            // this.Width = VALVES * PIXEL_SIZE + 40;
            //this.Height = 800;
            // HEIGHT = star.GetLength(0);
            LoadDefaultImage();

            // this.ClientSize = new Size(VALVES * PIXEL_SIZE + 40, HEIGHT);
            timer.Interval = frameDelay;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        // =============================================
        // ANIMAÇÃO
        // =============================================

        private void Timer_Tick(object? sender, EventArgs e)
        {

            // converte linha atual em pixels
            bool[] line = DecodeLoadedLine(HEIGHT - 1 - currentLine);

            int x = trackBar1.Value;

            // adiciona ao buffer visual
            for (int i = 0; i < x; i++)
            {
                renderedLines.Insert(0, line);
            }



            // limita quantidade de linhas na tela
            if (renderedLines.Count > 40)
                renderedLines.RemoveAt(renderedLines.Count - 1);


            currentLine++;

            // reinicia animação
            if (currentLine >= HEIGHT - 1)
            {
                currentLine = 0;
                renderedLines.Clear();
            }

            Invalidate();
        }

        // =============================================
        // CONVERTE BYTE -> PIXELS
        // =============================================
        bool[] DecodeLoadedLine(int lineIndex)
        {
            bool[] result = new bool[VALVES];


            for (int byteIndex = 0; byteIndex < 5; byteIndex++)
            {
                byte value =
                    currentImage[lineIndex][byteIndex];

                for (int bit = 0; bit < 8; bit++)
                {
                    bool isOn =
                        (value & (1 << (7 - bit))) != 0;

                    int pixelIndex =
                        byteIndex * 8 + bit;

                    result[pixelIndex] = isOn;
                }
            }

            return result;
        }


        // =============================================
        // RENDERIZAÇÃO
        // =============================================

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.Clear(Color.Black);

            Brush pixelOn = Brushes.Blue;
            Brush pixelOff = new SolidBrush(Color.Black);

            for (int y = 0; y < renderedLines.Count; y++)
            {
                bool[] line = renderedLines[y];

                for (int x = 0; x < VALVES; x++)
                {
                    Rectangle rect = new Rectangle(
                        x * PIXEL_SIZE + 200,
                        y * PIXEL_SIZE + 10,
                        PIXEL_SIZE - 8,
                        PIXEL_SIZE - 2
                    );

                    if (line[x])
                    {
                        g.FillRectangle(pixelOn, rect);
                    }
                    else
                    {
                        g.FillRectangle(pixelOff, rect);
                    }
                }
            }
        }

        private void trackBar1_ValueChanged(object? sender, EventArgs e)
        {

            //frameDelay = trackBar1.Value;
            // timer.Interval = frameDelay;
            lbl_vel.Text = trackBar1.Value.ToString();


        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd =
        new OpenFileDialog();

            ofd.Filter =
                "Imagens|*.png;*.jpg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // carrega bitmap
                Bitmap bmp =
                    new Bitmap(ofd.FileName);

                // preview
                // pictureBox1.Image = bmp;

                // converte imagem

                currentImage =
                    BitmapConverter.ConvertBitmap(bmp);
                HEIGHT = currentImage.Length;

                // reinicia animação
                currentLine = 0;

                // limpa histórico
                renderedLines.Clear();

                // força redraw
                Invalidate();
            }

        }

        private void btnExport_Click(
     object sender,
     EventArgs e)
        {
            // gera código
            string code =
                ArduinoExporter.Export(currentImage);

            // janela salvar
            SaveFileDialog sfd =
                new SaveFileDialog();

            // filtros
            sfd.Filter =
                "Arduino Header|*.h|" +
                "Arduino Sketch|*.ino|" +
                "Texto|*.txt";

            // nome padrão
            sfd.FileName = "waterkores_image.h";

            // abriu?
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // salva arquivo
                File.WriteAllText(
                    sfd.FileName,
                    code
                );

                MessageBox.Show(
                    "Arquivo exportado com sucesso!",
                    "WaterKores",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
    }