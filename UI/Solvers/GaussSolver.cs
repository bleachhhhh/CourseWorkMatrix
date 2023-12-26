namespace CourseWork
{
    public class GaussSolver : ISolver
    {
        public double[] Solve(Equation equation1, Equation equation2)
        {
            double x1 = equation1.Variables[0].Coeff;
            double x2 = equation2.Variables[0].Coeff;
            double y1 = equation1.Variables[1].Coeff;
            double y2 = equation2.Variables[1].Coeff;
            double RP1 = equation1.RightPart;
            double RP2 = equation2.RightPart;

            double mulForZero = -(x2 / x1);
            double newY2 = y2 + y1 * mulForZero;
            if (newY2 == 0)
            {
                equation2.Variables[1].Value = RP1 / x1;
                equation2.Variables[0].Value = equation2.Variables[1].Value;
                return new double[] { equation2.Variables[0].Value, equation2.Variables[1].Value };
            }
           
            double newRightPart1 = RP1 * mulForZero;
            double newRightPart2 = RP2 + newRightPart1;
            

            equation2.Variables[1].Value = Math.Round(newRightPart2 / newY2,2);
            equation2.Variables[0].Value = Math.Round((equation2.RightPart - equation2.Variables[1].Value * y2) / x2,2);
            Console.WriteLine("Решение получено методом Гаусса");
            return new double[] { equation2.Variables[0].Value, equation2.Variables[1].Value };
        }
    }
}
