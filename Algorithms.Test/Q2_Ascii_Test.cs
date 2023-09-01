namespace Algorithms.Test;


[TestClass]
public class Q2_Ascii_Test
{

        [TestMethod]
        public void CreateStaircase_HeightZero_ReturnsEmptyString()
        {
            // Arrange
            int height = 0;
            int width = 3;

            // Act
            string result = Q2_Ascii.CreateStaircase(height, width);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void CreateStaircase_WidthZero_ReturnsEmptyString()
        {
            // Arrange
            int height = 2;
            int width = 0;

            // Act
            string result = Q2_Ascii.CreateStaircase(height, width);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void CreateStaircase_NegativeHeight_ReturnsEmptyString()
        {
            // Arrange
            int height = -2;
            int width = 3;

            // Act
            string result = Q2_Ascii.CreateStaircase(height, width);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void CreateStaircase_NegativeWidth_ReturnsEmptyString()
        {
            // Arrange
            int height = 2;
            int width = -3;

            // Act
            string result = Q2_Ascii.CreateStaircase(height, width);

            // Assert
            Assert.AreEqual("", result);
        }

}