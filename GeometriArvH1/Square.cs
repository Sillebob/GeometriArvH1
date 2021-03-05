using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriArvH1
{
    public class Square
    {
        // Properties.
        #region Properties.
        private double sidea;
        private double sideb;

        public double Sidea 
        {
            // Everybody can see the value of side.
            get
            {
                return this.sidea;
            }
            // Everybody can set the value of side
            set
            {
                this.sidea = value; 
            }
        }
        public double Sideb
        {
            get { return sideb; }
            set { value = sideb; }
        }
        #endregion Properties.

        // Constructors
        #region Constructors.
        // Constructor which takes in the properties.
        public Square(double sidea, double sideb) 
        {
            this.sidea = sidea;
            this.sideb = sideb;
        }
        #endregion Constructors.

        // Methods, making them virtual so it is possible to override them in subclassses.
        #region Methods.
        // Perimeter.
        public virtual double GetPerimeter()
        {
            double result = (sidea+sideb)*2; 
            return result;
        }
        // SquareCm.
        public virtual double GetArea()
        {
            double result = sidea * sideb;
            return result;
        }
        #endregion Methods.
    }
}
