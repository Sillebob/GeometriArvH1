using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriArvH1
{
    public class Triangle:Square
    {
        // No properties besides the ones inherited.

        // Constructor which uses the properties inherited.
        #region Constructor.
        public Triangle(double sidea, double sideb) : base(sidea, sideb)
        {
          
        }
        #endregion Constructor.

        // Methods.
        #region Methods.
        public override double GetArea()
        {
           // Using the method from the inherited class and modifying it.
            double result = base.GetArea()*0.5;
            return result;
        }
        public override double GetPerimeter()
        {
            double getC = (Sidea * Sidea) + (Sideb * Sideb);
            double sidec = Math.Sqrt(getC);
            return (base.GetPerimeter()/2 + sidec);          
        }
        #endregion Methods.
    }
}
