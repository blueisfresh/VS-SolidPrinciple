using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_SolidPrinciple.Models;

public class Cube : IShape, IThreeDimensionalShape
{
    public double area()
    {
        return 100;
    }

    public double volume()
    {
        throw new NotImplementedException();
    }
}
