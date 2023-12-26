namespace CourseWork
{
    internal class KramerSolver : ISolver
    {
        public double[] Solve(Equation equation1, Equation equation2)
        {
            double x1 = equation1.Variables[0].Coeff;
            double x2 = equation2.Variables[0].Coeff;
            double y1 = equation1.Variables[1].Coeff;
            double y2 = equation2.Variables[1].Coeff;

            double mainDeterminantOfSystem = x1 * y2
                - x2 * y1;
            if (mainDeterminantOfSystem == 0)
            {
                Console.WriteLine("Решение получено методом Гаусса, поскольку главный определитель матрицы равен нулю");
                return new GaussSolver().Solve(equation1, equation2);
            }    
                

            double xDeterminant = equation1.RightPart * y2 - equation2.RightPart * y1;
            double yDeterminant = x1 * equation2.RightPart - x2 * equation1.RightPart;

            equation1.Variables[0].Value = xDeterminant / mainDeterminantOfSystem;
            equation1.Variables[1].Value = yDeterminant / mainDeterminantOfSystem;
            Console.WriteLine("Решение получено методом Крамера");
            return new double[] { equation1.Variables[0].Value, equation1.Variables[1].Value };
        }
    }
}
