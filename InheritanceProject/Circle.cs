using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class Circle:MyPoint
    {
        private double radius;

        public Circle(double x, double y,double r) : base(x, y)
        {
            this.Radius = r;
        }
        public double Radius 
        { 
            get { return radius; }
            set { if(value>0) radius = value; }
        }
        public bool InCircle()
        {
            if(X*X+Y*Y<=radius*radius) return true;
            return false;
        }
    }
}
