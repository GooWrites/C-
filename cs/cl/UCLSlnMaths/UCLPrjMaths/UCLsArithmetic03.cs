using System;

namespace UCLPrjMaths
{
    public partial class UCLsArithmetic
    {
        private double sq = 0.0;
        public double USquare
        {
            set
            {
                sq = value * value;
            }
            get
            {
                return sq;
            }
        }
        private static double cu = 0.0;

        public static double UCube
        {
            set
            {
                cu = value * value * value;

            }
            get
            {
                return cu;
            }
        }

    }

}
