using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string s;
        Font font;
        Brush brush;
        Point pts;

        Pen pen;
        Point pt1;
        Point pt2;

        Pen pen2;
        Rectangle rect;
        Brush brush2;
        public Form1()
        {
            InitializeComponent();
            s = "Rehab Adel";
            font = new Font("Arial", 20);
            brush = new SolidBrush(Color.Black);
            pts = new Point(this.Width / 3, this.Height / 5);

            pen = new Pen(Color.Red, 5);
            pt1 = new Point(200, 150);
            pt2 = new Point(300, 300);

            pen2 = new Pen(Color.Blue, 10);
            rect = new Rectangle(300, 300, 100, 100);
            brush2 = new SolidBrush(Color.Blue);
            this.KeyDown += new KeyEventHandler(KeyDown_1);
        }
        public void DrawString()
        {
            Graphics g = this.CreateGraphics();
            g.DrawString(s, font, brush, pts);
        }
        public void DrawLine()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(pen, pt1, pt2);
        }
        public void DrawRectangle()
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(pen2, rect);
        }
        public void FillRectangle()
        {
            Graphics g = this.CreateGraphics();
            g.FillRectangle(brush2, rect);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawString();
            DrawLine();
            DrawRectangle();
            FillRectangle();
            DrawTable();
        }
        private void KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                brush = new SolidBrush(Color.Red);
                Invalidate();
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                brush = new SolidBrush(Color.Blue);
                Invalidate();
            }
            if (e.Control && e.KeyCode == Keys.G)
            {
                brush = new SolidBrush(Color.Green);
                Invalidate();
            }
        }
        public void DrawTable()
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            for (int i = 0; i <= 5; i++)
            {
                g.DrawLine(pen, 0, i * 50, 250, i * 50);
                g.DrawLine(pen, i * 50, 0, i * 50, 250);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
