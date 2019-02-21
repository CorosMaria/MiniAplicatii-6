using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dreprunghiuri_imbricate_pe_3_coloane__while_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i,j,h,w,d,m=3,n=10;
	// j contor dreptunghiuri
	// i contor dreptunghiuri concentrice
	// m nr dreptunghiuri
	// n nr dreptunghiuri concentrice
	System.Drawing.Graphics Desen;
	Desen = this.CreateGraphics();
	System.Drawing.Pen Creion_albastru;
	Creion_albastru =new System.Drawing.Pen(System.Drawing.Color.Blue);
	Desen.Clear(this.BackColor);
	h=this.Height-30;	//inaltimea maxima a dreptunghiurilor
	w=this.Width/m;	//latimea maxima a dreptunghiului
	d=w/2/n;			// distanta intre doua dreptunghiuri concentrice
	j=0;				
	while (j<=m*w){
		i=0;				
		while (i<=d*n){
				Desen.DrawRectangle(Creion_albastru, j+i+10, i+10, (w-20-2*i), (h-20-2*i));
				i+=d;
			}
		j+=w;
		}
        }
    }
}
