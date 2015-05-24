using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgledniIshod4
{
    public partial class Sat : UserControl
    {
        private Pen penSata;
        private Pen penKazaljki;

        private Color bojaSata;

        public Color BojaSata
        {
            get { return bojaSata; }

            set
            {
                bojaSata = value;
                penSata = new Pen(bojaSata);
            }
        }

        private Color bojaKazaljki;

        public Color BojaKazaljki
        {
            get { return bojaKazaljki; }

            set
            {
                bojaKazaljki = value;
                penKazaljki = new Pen(bojaKazaljki);
            }
        }



        public Sat()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            InitializeStartingColors();
        }

        private void InitializeStartingColors()
        {
            BojaSata = Color.Red;
            penSata = new Pen(BojaSata);
            BojaKazaljki = Color.Black;
            penKazaljki = new Pen(BojaKazaljki);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Sredina sata
            Point center = new Point(ClientSize.Width / 2, ClientSize.Height / 2);

            // Iscrtavanje velikog kruga, tj samog sata
            e.Graphics.DrawEllipse(penSata, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            e.Graphics.FillEllipse(Brushes.White, 1, 1, ClientSize.Width - 3, ClientSize.Height - 3);

            // Duljine kazaljki
            int duljinaSat = (ClientSize.Width / 2) - 100;
            int duljinaMinuta = (ClientSize.Width / 2) - 50;
            int duljinaSekunda = (ClientSize.Width / 2) - 75;

            // Kutovi kazaljki
            double kutSat = ((double)DateTime.Now.Hour / 12) * 2 * Math.PI;
            double kutMinuta = ((double)DateTime.Now.Minute / 60) * 2 * Math.PI;
            double kutSekunda = ((double)DateTime.Now.Second / 60) * 2 * Math.PI;

            // Iscrtavanje kazaljke sata
            Point krajSat = new Point(center.X + (int)(duljinaSat * Math.Sin(kutSat)), center.Y - (int)(duljinaSat * Math.Cos(kutSat)));
            e.Graphics.DrawLine(penKazaljki, center, krajSat);

            // Iscrtavanje kazaljke minuta
            Point krajMinuta = new Point(center.X + (int)(duljinaMinuta * Math.Sin(kutMinuta)), center.Y - (int)(duljinaMinuta * Math.Cos(kutMinuta)));
            e.Graphics.DrawLine(penKazaljki, center, krajMinuta);

            // Iscrtavanja kazaljke sekunda
            Point krajSekunda = new Point(center.X + (int)(duljinaSekunda * Math.Sin(kutSekunda)), center.Y - (int)(duljinaSekunda * Math.Cos(kutSekunda)));
            e.Graphics.DrawLine(penKazaljki, center, krajSekunda);
        }
    }
}
