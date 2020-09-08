using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserDetails;

namespace UnitTest
{
    [TestClass]
    public class UserDetailsTest
    {
        [TestMethod]
        public void Test_If_Completion_Percentage_Is_Calculated_Correctly()
        {
            //Arrange
            decimal expectedPercentage = 11.11m;
            User user = new User();

            //Act
            decimal actualPercentage = Math.Round((user.TestCompletionPercentage(1,9)),2);

            //Assert
            Assert.AreEqual(expectedPercentage, actualPercentage);
        }
        [TestMethod]
        public void Test_If_Correct_Test_Type_For_User_Is_Returned()
        {
            //Arrange
            string expectedTestTypeReturned = "Computer Science";
            User user = new User();

            //Act
            int optionNumber = 1;
            string actualTestTypeReturned = user.TestType(optionNumber);

            //Assert
            Assert.AreEqual(expectedTestTypeReturned, actualTestTypeReturned);

        }
    }
}
