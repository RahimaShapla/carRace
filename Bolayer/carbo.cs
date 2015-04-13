using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using DalLayer;

namespace Bolayer
{
    public class carbo
    {
        DataAccess b = new DataAccess();
       public int x = 320;
       public  int   y = 150;
      
        public bool saveSpeed(Car c)
        {
            return b.saveSpeed(c);
        }
        public int getCarControltoRight(int x, int y)
        {
            return x + y;
        }

        public int getCarControltoLeft(int x, int y)
        {
            return x - y;
        }
        public Car getSpeed()
        {
            return b.getSpeed();
        }
    }
}
