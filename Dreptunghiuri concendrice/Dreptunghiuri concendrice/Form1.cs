using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dreptunghiuri_concendrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i, j, h, w, d, n = 10;
            // i contor dreptunghiuri concentrice
            // n nr dreptunghiuri concentrice
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_albastru;
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            Desen.Clear(this.BackColor);
            h = this.Height - 30;	//inaltimea maxima a dreptunghiurilor
            w = this.Width;		//latimea maxima a dreptunghiului
            d = h / 2 / n;		//distanta intre doua dreptunghiuri concentrice			
            i = 0;
            while (i <= d * n)
            {
                Desen.DrawRectangle(Creion_albastru, i + 10, i + 10, (w - 30 - 2 * i), (h - 30 - 2 * i));
                i += d;
            }
        }
    }
}
