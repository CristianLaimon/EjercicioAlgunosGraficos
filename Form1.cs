namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            Image image = Image.FromFile(@"imagen\interlude_newyear.png");
            papel = pictureBox1.CreateGraphics();
            Bitmap ima = new Bitmap(image);
            Pen lapiz = new Pen(Color.Black);
            SolidBrush pincelRelleno = new SolidBrush(Color.Purple);
            papel.DrawRectangle(lapiz, 10, 10, 100, 50);
            papel.DrawLine(lapiz, 10, 10, 110, 60);
            papel.DrawRectangle(lapiz, 10, 80, 100, 50);
            papel.DrawEllipse(lapiz, 10, 80, 100, 50);
            papel.FillEllipse(pincelRelleno, 10, 150, 100, 50);
            papel.DrawRectangle(lapiz, 130, 10, 150, 150);
            papel.DrawImage(ima, 130, 10, 150, 150);
            papel.FillEllipse(pincelRelleno, 130, 170, 75, 125);
            papel.DrawRectangle(lapiz, 330, 10, 120, 50);
            papel.DrawRectangle(lapiz, 375, 60, 30, 160);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}