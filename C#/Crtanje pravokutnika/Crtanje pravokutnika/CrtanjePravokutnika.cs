using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Nisam znao kako rijesiti da se tijekom iscrtavanja pravokutnici u kontroli ne trepere
namespace Crtanje_pravokutnika
{
    public partial class CrtanjePravokutnika : UserControl
    {
        // Provjera da li sam u fazi crtanja
        bool draw = false;

        // Pointi za dohvacanje start pozicije i pozicije tijekom micanja misa
        Point startPosition = new Point();
        Point currentPosition = new Point();

        // Crvena i crna boja za iscrtavanje kvadrata
        Pen drawPen = new Pen(Brushes.Red, 1);
        Pen listPen = new Pen(Brushes.Black, 1);

        // Lista kvadrata radi ponovnog iscrtavanja
        static List<Rectangle> rectangles = new List<Rectangle>();

        public CrtanjePravokutnika()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void pnlCrtanje_MouseDown(object sender, MouseEventArgs e)
        {
            startPosition = currentPosition = e.Location;
            draw = true;
        }

        private void pnlCrtanje_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && draw)
            {
                currentPosition = e.Location;
                pnlCrtanje.Refresh();
            }
        }

        private Rectangle GetNewRectangle()
        {
            return new Rectangle(startPosition.X, startPosition.Y, currentPosition.X - startPosition.X, currentPosition.Y - startPosition.Y);
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
                Rectangle r = GetNewRectangle();

                //Samo provjera da li kvadrat ima pozitivnu velicinu da ga ne spremamo bezveze u listu
                if (r.Width > 0 && r.Height > 0)
                {
                    rectangles.Add(r);
                }

                pnlCrtanje.Invalidate();
            }
        }
    }
}
