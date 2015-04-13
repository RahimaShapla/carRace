using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bolayer;
using Entity;



namespace UIform
{
    public partial class Animation : Form
    {
        carbo s = new carbo();
        Car v = new Car();
        enum position{
            left,Right,Up,Down,stop
        }
        int x;
        int y;
        Graphics g;
        Graphics r;
        private position objpos;
        private int objId;
        public Animation()
        {
            InitializeComponent();
            
             x = s.x;
             y = s.y;
            
            objId = 0;
            objpos = position.stop;
           
            
            
        }

       
        private void cardrawPanel_paint(object sender, PaintEventArgs e)
        {
            g = carpanel.CreateGraphics();
            carpanel.Location=new Point(x, y);
            v.DrawCar(g, objId);
           
          

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
          
            try
            {

                v.speed = Convert.ToInt32(textBox1.Text);
                if (s.saveSpeed(v))
                {

                    label3.Text = Convert.ToString(v.speed);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("unsaved");


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Car v = new Car();
            try
            {

                v.speed = Convert.ToInt32(textBox1.Text);
                s.saveSpeed(v);
            }
            catch (Exception)
            {


            }

            carpanel.Invalidate();
            if (objpos == position.Right && x<700)
            {
                x = s.getCarControltoRight(x,v.speed);
                objId = 0;
               // carpanel.Invalidate();
            }
            if (objpos == position.left && x > 0)
            {
                x =s.getCarControltoLeft(x,v.speed);
                objId = 1;
                carpanel.Invalidate();
            }
            if (objpos == position.Up && y > 90)
            {
                y=s.getCarControltoLeft(y,v.speed);
                objId = 2;
                //carpanel.Invalidate();
            }
            if (objpos == position.Down && y <150)
            {
                y =s.getCarControltoRight(y,v.speed);
                objId = 3;
                //carpanel.Invalidate();
            }
            
           // Invalidate();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            objpos = position.Right;
            carpanel.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objpos = position.left;
            carpanel.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objpos = position.Up;
            carpanel.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objpos = position.Down;
            carpanel.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            objpos = position.stop;
        }

        private void Road_dwaw(object sender, PaintEventArgs e)
        {
            r = roadPanel.CreateGraphics();
            v.DrawRoad(r);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Animation_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}