
using CourseWork;

namespace CourseWork.Tests
{
    public class UserWorkerTests
    {
        [Fact]
        public void IncorrectLine_CallLeadToSample_SuccessTest()
        {
            //Arrange
            string incorrectLine = "3xt&-56/^&*y=134*&";
            //Act
            string correctLine = UserWorker.LeadToSample(incorrectLine);
            //Assert
            Assert.Equal("3x-56y134", correctLine);
        }
        [Fact]
        public void CorrectLine_CallLeadToSample_SuccessTest()
        {
            //Arrange
            string incorrectLine = "3x-56y=134";
            //Act
            string correctLine = UserWorker.LeadToSample(incorrectLine);
            //Assert
            Assert.Equal("3x-56y134", correctLine);
        }
    }

}