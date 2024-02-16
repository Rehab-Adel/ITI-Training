using System.Drawing.Drawing2D;

namespace Lab6
{
    public partial class Form1 : Form
    {
        // Text data
        string m_Text;
        Font m_TextFont;
        Brush m_TextBrush;
        Color m_TextColor;
        PointF m_TextLoc;

        // Line
        Color m_LineColor;
        Pen m_LinePen;
        Point m_LineStart;
        Point m_LineEnd;

        // Rectangle
        Color m_RectColor;
        Pen m_RectPen;
        Rectangle Rect;

        public Form1()
        {
            InitializeComponent();
            m_Text = "Welcome To C#";
            m_TextFont = new Font("Arial", 24);
            m_TextColor = Color.Blue;
            m_TextBrush = new SolidBrush(m_TextColor);
            m_TextLoc = new PointF(100, 100);

            // Line 
            m_LineColor = Color.Orange;
            m_LinePen = new Pen(m_LineColor, 3);
            m_LineStart = new Point(50, 50);
            m_LineEnd = new Point(200, 150);

            // Rectangle
            m_RectColor = Color.Green;
            m_RectPen = new Pen(m_RectColor, 5); 
            Rect = new Rectangle(80, 80, 100, 70);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DisplayString();
            DisplayLine();
            DisplayRect();
        }

        public void DisplayString()
        {
            Graphics g = this.CreateGraphics();
            g.DrawString(m_Text, m_TextFont, m_TextBrush, m_TextLoc);
        }

        public void DisplayLine()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(m_LinePen, m_LineStart, m_LineEnd);
        }

        public void DisplayRect()
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(m_RectPen, Rect);

            Rectangle FillRect = new Rectangle(200, 150, 120, 80);
            Brush FillBrush = new HatchBrush(HatchStyle.Cross, Color.Beige, Color.DarkBlue);
            g.FillRectangle(FillBrush, FillRect);
        }
    }
}
