using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriArvH1
{
    public static class LogicLayer
    {
        // Methods that calls the methods from the DAL to calculates perimeter and area. 
        // To be called from Main.
        #region Perimeter.      
        public static double GetPerimeter(Square square)
        {
            return DAL.GetPerimeter(square);
        }
        #endregion Perimeter.

        #region Area.
        public static double GetArea(Square square)
        {
            return DAL.GetArea(square);
        }
        #endregion Area.
    }
}