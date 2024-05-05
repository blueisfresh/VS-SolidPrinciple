using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_SolidPrinciple
{
    public class AreaCalculator
    {
        public double Sum(List<Object> shapes)
        {
            double sum = 0;

            for (int i = 0; i < shapes.Count; i++)
            {
                Object shape = shapes[i];

                if (shape is Square)
                {
                    sum += Math.Pow(((Square)shape).GetLength(), 2);
                }

                if (shape is Circle)
                {
                    sum += Math.PI * Math.Pow(((Circle)shape).GetRadius(), 2);

                }
            }

            return sum;
        }

    }
}
