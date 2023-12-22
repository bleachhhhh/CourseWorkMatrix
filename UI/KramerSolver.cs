using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class KramerSolver : ISolver
    {
        public double[] Solve(Equation equation1, Equation equation2)
        {
            double a1 = equation1.Variables[0].Coeff;
            double a2 = equation2.Variables[0].Coeff;
            double b1 = equation1.Variables[1].Coeff;
            double b2 = equation2.Variables[1].Coeff;

            double mainDeterminantOfSystem = a1 * b2
                - a2 * b1;
            if (mainDeterminantOfSystem == 0)
                return new GaussSolver().Solve(equation1, equation2);

            double xDeterminant = equation1.RightPart * b2 - equation2.RightPart * b1;
            double yDeterminant = a1 * equation2.RightPart - a2 * equation1.RightPart;

            equation1.Variables[0].Value = xDeterminant / mainDeterminantOfSystem;
            equation1.Variables[1].Value = yDeterminant / mainDeterminantOfSystem;
            return new double[] { equation1.Variables[0].Value, equation1.Variables[1].Value };
        }
    }
}
