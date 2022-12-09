using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class MyPoint
    {
        private double x;
        private double y;

        public MyPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X 
        { 
            get {return x;}
            set {x = value;} 
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Dlina()
        {
            return Math.Sqrt(x*x+y*y);
        }
    }
}
