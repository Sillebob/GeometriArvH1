using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriArvH1
{
    public class Parallelogram:Square
    {
        // New property for this subclass
        #region Properties.
        private double degrees;
        public double Degrees
        {
            get { return degrees; }
            set { value = degrees; }
        }
        #endregion Properties.

        // Making the constructor using the properties from the Square Class adding the property for this subclass.
        #region Constructor.
        public Parallelogram(double sidea, double sideb, double degrees):base(sidea, sideb)
        {
            this.degrees = degrees;
        }
        #endregion Constructor.

        // Overriding the method for calculating area.
        #region Methods.
        public override double GetArea()
        {
            double angle = Math.PI * degrees / 180.0;
            double result = base.GetArea() * (Math.Sin(angle));
            
            return result;
        }
        #endregion Methods.
    }
}
