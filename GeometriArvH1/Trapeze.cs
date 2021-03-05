using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriArvH1
{
    public class Trapeze:Square
    {
        // Properties.
        #region Properties.
        private double sidec;
        private double sided;

        public double Sidec
        {
            get { return sidec; }
            set { value = sidec; }
        }
        public double Sided
        {
            get { return sided; }
            set { value = sided; }
        }
        #endregion Properties.

        // Constructor which adds to the properties inherited.
        #region Constructor.
        public Trapeze(double sidea, double sideb, double sidec, double sided):base(sidea, sideb)
        {
            this.sidec = sidec;
            this.sided = sided;
        }
        #endregion Constructor.

        // Methods.
        #region Methods.
        // Overriding the method for calculating squareCm.
        public override double GetArea()
        {
            double s = (Sidea + Sideb - sidec + sided) / 2;
            double height = (2 / (Sidea - sidec)) * Math.Sqrt((s * (s - Sidea + sidec) * (s - Sideb) * (s - sided)));
            double result = (0.5 *(Sidea + sidec) * height);
            return result;
        }
        // there should be another method for calculating the perimeter of a trapeze but it uses sin(A9 and sin(B)
        //public override double GetPerimeter()
        //{
        //    return base.GetPerimeter();
        //}
        #endregion Methods.
    }
}
