using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_SolidPrinciple;

public class ShapesPrinter
{
    private IAreaCalculator areaCalculator;
    public ShapesPrinter(IAreaCalculator areaCalculator) 
    {
        this.areaCalculator = areaCalculator;
    }
    public string Json(List<IShape> shapes)
    {
        return $"{{ \"sum\": {areaCalculator.Sum(shapes)} }}";
    }

    public string Csv(List<IShape> shapes)
    {
        return $"Sum,{areaCalculator.Sum(shapes)}";
    }

}
