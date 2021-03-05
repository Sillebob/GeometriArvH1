using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriArvH1
{
    public static class DAL
    {
        // The DataAccessLayer

        // Methods that calculates perimeter and area to be called from the logic layer.
        #region Perimeter.
        public static double GetPerimeter(Square square)
        {
            return square.GetPerimeter();
        }
        #endregion Perimeter.

        #region Area.
        public static double GetArea(Square square)
        {
            return square.GetArea();
        }
        #endregion Area.

    }
}
