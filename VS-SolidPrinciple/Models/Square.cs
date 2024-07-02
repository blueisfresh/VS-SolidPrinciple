using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_SolidPrinciple
{
    public class Square: IShape
    {
        private int length;

        public Square(int length)
        {
            this.length = length;
        }

        public double area()
        {
            return Math.Pow(GetLength(), 2);
        }

        public int GetLength()
        {
            return length;
        }

    }
}
