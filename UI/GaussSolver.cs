using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class GaussSolver : ISolver
    {
        public double[] Solve(Equation equation1, Equation equation2)
        {
            double a1 = equation1.Variables[0].Coeff;
            double a2 = equation2.Variables[0].Coeff;
            double b1 = equation1.Variables[1].Coeff;
            double b2 = equation2.Variables[1].Coeff;
            double RP1 = equation1.RightPart;
            double RP2 = equation2.RightPart;

            double mulForZero = -(a2 / a1);
            double newA1 = a1 * mulForZero;
            double newB1 = b1 * mulForZero;
            double newRightPart1 = RP1 * mulForZero;
            double newA2 = a2 + newA1;
            double newB2 = b2 + newB1;
            double newRightPart2 = RP2 + newRightPart1;

            equation2.Variables[1].Value = Math.Round(newRightPart2 / newB2);
            equation2.Variables[0].Value = Math.Round((equation2.RightPart - equation2.Variables[1].Value * b2) / a2);
            return new double[] { equation2.Variables[0].Value, equation2.Variables[1].Value };
        }
    }
}
