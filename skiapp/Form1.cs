using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace skiapp
{
    public partial class Form1 : Form
    {
        //place vars here :)
        float xCoord1, yCoord1, radius1; // ball 1
        float vx1, vy1;
        
        float xCoord2, yCoord2, radius2; // ball 2
        float vx2, vy2;
        
        float xCoord3, yCoord3, radius3; // ball 3
        float vx3, vy3;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // put change in velocity here
            xCoord1 += vx1;
            yCoord1 += vy1;

            xCoord2 += vx2;
            yCoord2 += vy2;

            xCoord3 += vx3;
            yCoord3 += vy3;

            if ((xCoord1 > Size.Width - radius1) || (xCoord1 < radius1)) vx1 = -vx1;
            if ((yCoord1 > Size.Height - radius1) || (yCoord1 < radius1)) vy1 = -vy1;
            if ((xCoord2 > Size.Width - radius2) || (xCoord2 < radius2)) vx2 = -vx2;
            if ((yCoord2 > Size.Height - radius2) || (yCoord2 < radius2)) vy2 = -vy2;
            if ((xCoord3 > Size.Width - radius3) || (xCoord3 < radius3)) vx3 = -vx3;
            if ((yCoord3 > Size.Height - radius3) || (yCoord3 < radius3)) vy3 = -vy3;

            skControl1.Refresh();
        }


        public Form1()
        {
            // set vars here :)
            InitializeComponent();

            xCoord1 = 600; // ball 1
            yCoord1 = 100;
            radius1 = 30;
            vx1 = 10f; vy1 = 7f;
            
            xCoord2 = 300; // ball 2
            yCoord2 = 200;
            radius2 = 60;
            vx2 = 5f; vy2 = 4f;

            xCoord3 = 100; // ball 3
            yCoord3 = 100;
            radius3 = 10;
            vx3 = 13f; vy3 = 10f;

        }

        private void skControl1_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            // I double clicked on the name of the event and it created this implementation method
            // This is a method - it's a function, but inside a class. Those are called methods.

            var canvas = e.Surface.Canvas; // everything must go below this so you can call canvas :)
            
            canvas.Clear(SKColors.Gray); // must go first so that things can draw over it

            SKPaint p = new SKPaint();
            p.Color = SKColors.LightSkyBlue;
            SKPaint k = new SKPaint();
            k.Color = SKColors.Purple;
            SKPaint l = new SKPaint();
            l.Color = SKColors.LightSalmon;
            canvas.DrawCircle(xCoord1, yCoord1, radius1, k);
            canvas.DrawCircle(xCoord2, yCoord2, radius2, p);
            canvas.DrawCircle(xCoord3, yCoord3, radius3, l);

            
        }
    }
}
