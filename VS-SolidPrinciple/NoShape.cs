using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_SolidPrinciple;

public class NoShape : Shape
{
    public double area()
    {
        throw new InvalidOperationException("Cannot Calculate Area");
    }
}
