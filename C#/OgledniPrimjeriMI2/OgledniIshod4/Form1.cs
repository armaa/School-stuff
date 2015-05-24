using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgledniIshod4
{
    public partial class Form1 : Form
    {
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
            btnPrekini.Enabled = false;
            lblInfo.Text = "";
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 200000000; i++)
            {
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                if (isPrime(i))
                {
                    counter++;
                    bgWorker.ReportProgress(100, i);
                }
            }

            e.Result = counter;
        }

        private bool isPrime(int i)
        {
            if (i == 1) return true;
            if (i == 2) return true;

            for (int j = 3; j < i; j++)
            {
                if (bgWorker.CancellationPending) return false;
                if (i % j == 0) return false;
            }

            return true;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblZadnji.Text = e.UserState.ToString();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblInfo.Text = "Proces prekinut!";
                lblPronadjeno.Text = counter.ToString();
            }

            else
            {
                lblInfo.Text = "Proces gotov!";
                lblPronadjeno.Text = e.Result.ToString();
            }

            btnStart.Enabled = true;
            btnPrekini.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            counter = 0;
            btnStart.Enabled = false;
            btnPrekini.Enabled = true;
            lblInfo.Text = "";
            lblPronadjeno.Text = "";
            bgWorker.RunWorkerAsync();
        }

        private void btnPrekini_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPrekini.Enabled = false;
            bgWorker.CancelAsync();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.Location);
            }
        }
    }
}
