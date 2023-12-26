using CourseWork;
namespace CourseWork.Tests
{
    public class EquationTests
    {
        [Fact]
        public void CorrectLine_CallGetEquation_ReturnEquation_Success()
        {
            //Arrange
            string equation = "3x+2y=11";
            //Act
            var equat = Equation.GetEquation(equation);
            //Assert
            Assert.Equal(11, equat.RightPart);
            Assert.Equal(3, equat.Variables[0].Coeff);
            Assert.Equal(2, equat.Variables[1].Coeff);
        }
        [Theory]
        [InlineData("3+2y=11")]
        [InlineData("3x+2=11")]
        public void InCorrectLine_CallGetEquation_ReturnEquation_Throws(string line)
        {
            //Act+Arrange+Assert
            Assert.Throws<CourseWork.Exceptions.IncorrectInputException>(()=>Equation.GetEquation(line));
        }
    }
}
