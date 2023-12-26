
namespace CourseWork.Tests
{
    public class GaussSolverTests
    {
        [Fact]
        public void TwoCorrectEquations_CallSolve_Success()
        {
            //Act
            string equation1 = "3x-4y=3";
            string equation2 = "7x-6y=17";
            GaussSolver gaussSolver = new GaussSolver();
            //Arrange
            var solves=gaussSolver.Solve(Equation.GetEquation(equation1),Equation.GetEquation(equation2));
            //Assert
            Assert.Equal(new double[] {5,3},solves);
        }

    }
}
