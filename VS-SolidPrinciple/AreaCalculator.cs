using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VS_SolidPrinciple.Models;

namespace VS_SolidPrinciple
{
    public class AreaCalculator : IAreaCalculator
    {
        public double Sum(List<IShape> shapes)
        {
            double sum = 0;

            for (int i = 0; i < shapes.Count; i++)
            {

                sum += shapes[i].area();
            }

            return sum;
        }

        int nummm = 0;


    }
}
