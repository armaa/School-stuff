using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Nisam znao kako rijesiti da se tijekom iscrtavanja pravokutnici u kontroli ne trepere.
namespace Crtanje_pravokutnika
{
    public partial class CrtanjePravokutnika : UserControl
    {
        bool draw = false;
        Point start = new Point();
        Point current = new Point();
        Rectangle rect;
        public Pen drawPen = new Pen(Brushes.Red, 1);
        public Pen listPen = new Pen(Brushes.Black, 1);
        List<Rectangle> rectangles = new List<Rectangle>();

        public CrtanjePravokutnika()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void pnlCrtanje_MouseDown(object sender, MouseEventArgs e)
        {
            start = current = e.Location;
            draw = true;
        }

        private void pnlCrtanje_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;

                if (draw)
                {
                    pnlCrtanje.Refresh();
                }
            }
        }

        private Rectangle GetNewRectangle()
        {
            return new Rectangle(start.X, start.Y, current.X - start.X, current.Y - start.Y);
        }

        private void pnlCrtanje_Paint(object sender, PaintEventArgs e)
        {
            if (rectangles.Count > 0)
            {
                e.Graphics.DrawRectangles(listPen, rectangles.ToArray());
            }

            if (draw)
            {
                e.Graphics.DrawRectangle(drawPen, GetNewRectangle());
            }
        }

        private void pnlCrtanje_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                draw = false;
                rect = GetNewRectangle();

                if (rect.Width > 0 && rect.Height > 0)
                {
                    rectangles.Add(rect);
                }

                pnlCrtanje.Invalidate();
            }
        }
    }
}
