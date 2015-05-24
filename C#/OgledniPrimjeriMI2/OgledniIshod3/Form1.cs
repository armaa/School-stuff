using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OgledniIshod3
{
    public partial class Form1 : Form
    {
        private uint counter;
        private Font printFont = new Font("Arial", 12);
        private SizeF size;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            counter = 0;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("1", printFont, Brushes.Black, e.MarginBounds.Right, e.MarginBounds.Bottom);
            e.Graphics.FillEllipse(Brushes.Red, e.MarginBounds.Right + 2, e.MarginBounds.Bottom - 10, 10, 10);
            foreach (string line in textBox1.Lines)
            {
                using (Graphics g = CreateGraphics())
                {
                    size = g.MeasureString(line, printFont);
                }

                if (line.Length == 0)
                {
                    e.Graphics.DrawString("\r\n", printFont, Brushes.Black, ((e.PageBounds.Width / 2) - size.Width), e.PageBounds.Height - (counter * printFont.GetHeight(e.Graphics)));
                    counter++;
                }

                else
                {
                    e.Graphics.DrawString(line, printFont, Brushes.Black, ((e.PageBounds.Width / 2) - size.Width), e.PageBounds.Height / 2 - (counter * printFont.GetHeight(e.Graphics)));
                    counter++;
                }
            }
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void btnKultura_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Lines;

            if (Thread.CurrentThread.CurrentCulture.Name == "hr")
            {
                SetThreadCulture("en");
            }

            else
            {
                SetThreadCulture("hr");
            }

            this.Controls.Clear();
            InitializeComponent();

            textBox1.Lines = lines;
        }

        private static void SetThreadCulture(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
        }
    }
}
