using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dreptunghiuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int x0, y0, w, h, i;
            x0 = 200;
            y0 = 150;
            w = 200;
            h = 100;
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_albastru;
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            for (i = 1; i <= 15; i++)
            {
                Desen.DrawRectangle(Creion_albastru, x0-i*5, y0-i*5, w, h);
            }
        }
    }
}
