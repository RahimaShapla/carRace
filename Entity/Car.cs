 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Entity
{
    public class Car
    {
        public int speed;
        public void DrawRoad(Graphics g)
        {
            Pen p = new Pen(Color.MediumAquamarine, 5);
            Pen p0 = new Pen(Color.MistyRose, 5);
            Pen p01 = new Pen(Color.Honeydew, 8);
            Pen p02 = new Pen(Color.Black, 8);
            //tree1
            g.DrawLine(p01, new Point(20, 50), new Point(20, 30));
            g.FillEllipse(Brushes.Green, 20, 30, 50, 50);//divi1
            g.FillEllipse(Brushes.Green, 10, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 0, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 20, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 10, 10, 15, 10);
            //tree2
            g.DrawLine(p01, new Point(80, 50), new Point(80, 30));
            g.FillEllipse(Brushes.Green, 80, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 80, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 60, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 70, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 70, 10, 15, 10);
            //tree3
            g.DrawLine(p01, new Point(140, 50), new Point(140, 30));
            g.FillEllipse(Brushes.Green, 150, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 140, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 130, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 120, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 130, 10, 15, 10);
            //tree4
            g.DrawLine(p01, new Point(200, 50), new Point(200, 30));
            g.FillEllipse(Brushes.Green, 200, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 200, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 190, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 180, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 190, 10, 15, 10);

            //tree5
            g.DrawLine(p01, new Point(700, 50), new Point(700, 30));
            g.FillEllipse(Brushes.Green, 700, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 700, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 690, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 680, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 690, 10, 15, 10);
            //tree6
            g.DrawLine(p01, new Point(760, 50), new Point(760, 30));
            g.FillEllipse(Brushes.Green, 760, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 760, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 750, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 740, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 750, 10, 15, 10);
            //tree7
            g.DrawLine(p01, new Point(820, 50), new Point(820, 30));
            g.FillEllipse(Brushes.Green, 820, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 820, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 810, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 800, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 810, 10, 15, 10);
            //tree8
            g.DrawLine(p01, new Point(890, 50), new Point(890, 30));
            g.FillEllipse(Brushes.Green, 890, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 890, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 880, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 870, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 880, 10, 15, 10);







        }
        public void DrawCar(Graphics g, int objId)
        {
            Pen p = new Pen(Color.OrangeRed, 5);
            Pen p01 = new Pen(Color.Yellow, 5);
            if (objId == 0)
            {
                g.DrawLine(p01, new Point(10, 140), new Point(10, 90));
                g.DrawLine(p01, new Point(10, 100), new Point(250, 100));
                g.DrawLine(p01, new Point(250, 100), new Point(270, 150));
                g.DrawLine(p01, new Point(270, 150), new Point(210, 150));
               
                g.DrawLine(p01, new Point(160, 150), new Point(110, 150));
               
               g.DrawLine(p01, new Point(60, 150), new Point(10, 150));
               // g.DrawLine(p01, new Point(60, 130), new Point(10, 130));
                g.DrawLine(p01, new Point(10, 100), new Point(40, 90));
                g.DrawLine(p01, new Point(40, 90), new Point(60, 70));
                g.DrawLine(p01, new Point(60, 70), new Point(180, 70));
                g.DrawLine(p01, new Point(180, 70), new Point(190, 80));
                g.DrawLine(p01, new Point(190, 80), new Point(250, 100));
                g.FillRectangle(Brushes.RoyalBlue, 80, 75, 18, 20);
                g.FillRectangle(Brushes.RoyalBlue, 150, 75, 18, 20);

                 g.DrawEllipse(new Pen(Color.White,5), 60, 125, 50, 50);
                g.FillEllipse(Brushes.Bisque, 68, 132, 35, 35);
                 g.FillEllipse(Brushes.White, 75, 140, 20, 20);

                 g.DrawEllipse(new Pen(Color.White, 5), 160, 125, 50, 50);
                 g.FillEllipse(Brushes.Bisque, 168, 132, 35, 35);
                 g.FillEllipse(Brushes.White, 175, 140, 20, 20);

                 g.FillRectangle(Brushes.Red, 230, 100, 18, 20);
               
               
              /*  g.Draw 
               Rectangle(p, 40, 30, 80, 60);
                g.DrawLine(p, 120, 32, 170, 50);
                g.DrawLine(p, new Point(170, 50), new Point(170, 75));
                g.DrawLine(p, new Point(120, 90), new Point(170, 75));
                g.DrawLine(p, new Point(120, 32), new Point(100, 40));
                g.DrawLine(p, new Point(100, 40), new Point(100, 70));
                g.DrawLine(p, new Point(100, 70), new Point(120, 90));
                g.DrawRectangle(p, 60, 42, 40, 35);
                g.DrawLine(p, new Point(60, 42), new Point(40, 30));
                g.DrawLine(p, new Point(60, 75), new Point(40, 90));*/
            }
            if (objId == 1)
            {
              /*  g.DrawRectangle(p, 40, 30, 80, 60);
                g.DrawLine(p, new Point(120, 32), new Point(100, 40));
                g.DrawLine(p, new Point(100, 40), new Point(100, 70));
                g.DrawLine(p, new Point(100, 70), new Point(120, 90));
                g.DrawRectangle(p, 60, 42, 40, 35);
                g.DrawLine(p, new Point(60, 42), new Point(40, 30));
                g.DrawLine(p, new Point(60, 75), new Point(40, 90));

                g.DrawLine(p, new Point(40, 30), new Point(1, 40));
                g.DrawLine(p, new Point(1, 40), new Point(1, 77));
                g.DrawLine(p, new Point(1, 77), new Point(40, 90));*/
                g.DrawLine(p01, new Point(0, 150), new Point(10, 100));
                g.DrawLine(p01, new Point(10, 100), new Point(250, 100));
                g.DrawLine(p01, new Point(250, 100), new Point(250, 150));
                g.DrawLine(p01, new Point(250, 150), new Point(210, 150));
                g.DrawLine(p01, new Point(160, 150), new Point(110, 150));
                g.DrawLine(p01, new Point(60, 150), new Point(0, 150));
                g.DrawLine(p01, new Point(10, 100), new Point(75, 80));
                g.DrawLine(p01, new Point(75, 80), new Point(80, 70));
                g.DrawLine(p01, new Point(80, 70), new Point(195, 70));
                g.DrawLine(p01, new Point(195, 70), new Point(220, 90));
                g.DrawLine(p01, new Point(220, 90), new Point(250, 100));
                g.FillRectangle(Brushes.RoyalBlue, 90, 75, 18, 20);
                g.FillRectangle(Brushes.RoyalBlue, 160, 75, 18, 20);

                g.DrawEllipse(new Pen(Color.White, 5), 60, 125, 50, 50);
                g.FillEllipse(Brushes.Bisque, 68, 132, 35, 35);
                g.FillEllipse(Brushes.White, 75, 140, 20, 20);

                g.DrawEllipse(new Pen(Color.White, 5), 160, 125, 50, 50);
                g.FillEllipse(Brushes.Bisque, 168, 132, 35, 35);
                g.FillEllipse(Brushes.White, 175, 140, 20, 20);

                g.FillRectangle(Brushes.Red, 10, 100, 18, 20);
               

            }
            if (objId == 2)
            {
                g.DrawLine(p01, new Point(100,210), new Point(190, 210));
                g.DrawLine(p01, new Point(100, 210), new Point(100, 50));
                g.DrawLine(p01, new Point(100, 50), new Point(120, 20));
                g.DrawLine(p01, new Point(120, 20), new Point(170, 20));
                g.DrawLine(p01, new Point(170, 20), new Point(190, 50));
                g.DrawLine(p01, new Point(190, 210), new Point(190, 50));
                Point[] p1 = { new Point(100, 50), new Point(150, 40), new Point(190, 50) };
                g.DrawCurve(p01, p1);
                g.DrawLine(p01, new Point(100, 50), new Point(130, 70));
                g.DrawLine(p01, new Point(130, 70), new Point(130, 180));
                g.DrawLine(p01, new Point(130, 180), new Point(100, 210));
                g.DrawLine(p01, new Point(190, 50), new Point(160, 70));
                g.DrawLine(p01, new Point(160, 70), new Point(160, 180));
                g.DrawLine(p01, new Point(160, 180), new Point(190, 210));
                g.DrawLine(p01, new Point(130, 70), new Point(160, 70));
                g.DrawLine(p01, new Point(130, 180), new Point(160, 180));

                g.FillRectangle(Brushes.Red, 120, 20, 10, 10);
                g.FillRectangle(Brushes.Red, 160, 20, 10, 10);
               
               
               
               
               
               
               
               /* g.DrawRectangle(p, 50, 20, 40, 45);
                g.DrawRectangle(p, 62, 30, 17, 20);
                g.DrawLine(p, new Point(65, 3), new Point(50, 19));
                g.DrawLine(p, new Point(65, 3), new Point(80, 3));
                g.DrawLine(p, new Point(80, 3), new Point(90, 20));
                g.DrawLine(p, new Point(50, 19), new Point(60, 30));
                g.DrawLine(p, new Point(80, 30), new Point(88, 19));
                g.DrawLine(p, new Point(60, 50), new Point(48, 68));
                g.DrawLine(p, new Point(80, 50), new Point(90, 65));*/





            }
            if (objId == 3)
            {
                g.DrawLine(p01, new Point(100, 50), new Point(190, 50));

                Point[] p1 = { new Point(100, 210), new Point(150, 218), new Point(190, 210) };
                g.DrawCurve(p01, p1);
                g.DrawLine(p01, new Point(100, 210), new Point(120, 240));
                g.DrawLine(p01, new Point(120, 240), new Point(170, 240));
                g.DrawLine(p01, new Point(170, 240), new Point(190, 210));


                g.DrawLine(p01, new Point(100, 210), new Point(100, 50));
                g.DrawLine(p01, new Point(190, 210), new Point(190, 50));
                g.DrawLine(p01, new Point(100, 50), new Point(130, 70));
                g.DrawLine(p01, new Point(130, 70), new Point(130, 180));
                g.DrawLine(p01, new Point(130, 180), new Point(100, 210));
                g.DrawLine(p01, new Point(190, 50), new Point(160, 70));
                g.DrawLine(p01, new Point(160, 70), new Point(160, 180));
                g.DrawLine(p01, new Point(160, 180), new Point(190, 210));
                g.DrawLine(p01, new Point(130, 70), new Point(160, 70));
                g.DrawLine(p01, new Point(130, 180), new Point(160, 180));
                g.FillRectangle(Brushes.Red, 120, 230, 10, 10);
                g.FillRectangle(Brushes.Red, 160, 230, 10, 10);
               
               /* g.DrawRectangle(p, 50, 20, 40, 45);
                g.DrawRectangle(p, 62, 30, 17, 20);
                g.DrawLine(p, new Point(50, 19), new Point(60, 30));
                g.DrawLine(p, new Point(80, 30), new Point(88, 19));
                g.DrawLine(p, new Point(60, 50), new Point(48, 68));
                g.DrawLine(p, new Point(80, 50), new Point(90, 65));

                g.DrawLine(p, new Point(48, 68), new Point(60, 90));
                g.DrawLine(p, new Point(60, 90), new Point(80, 90));
                g.DrawLine(p, new Point(80, 90), new Point(90, 65));*/



            }
            
        }
    }
}
