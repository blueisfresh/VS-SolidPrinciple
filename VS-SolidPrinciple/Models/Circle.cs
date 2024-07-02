using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_SolidPrinciple
{
    public class Circle: IShape
    {

        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double area()
        {
            return Math.PI * Math.Pow(GetRadius(), 2);
        }

        public int GetRadius()
        {
            return radius;
        }

    }
}
