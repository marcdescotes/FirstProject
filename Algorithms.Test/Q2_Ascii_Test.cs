namespace Algorithms.Test;


[TestClass]
public class Q2_Ascii_Test
{

    [TestMethod]
    public void HeightZero_ReturnsEmptyString()
    {
        int height = 0;
        int width = 3;

        string result = Q2_Ascii.CreateStaircase(height, width);

        Assert.AreEqual("", result);
    }

    [TestMethod]
    public void WidthZero_ReturnsEmptyString()
    {
        int height = 2;
        int width = 0;

        string result = Q2_Ascii.CreateStaircase(height, width);

        Assert.AreEqual("", result);
    }

    [TestMethod]
    public void NegativeHeight_ReturnsEmptyString()
    {
        int height = -2;
        int width = 3;

        string result = Q2_Ascii.CreateStaircase(height, width);

        Assert.AreEqual("", result);
    }

    [TestMethod]
    public void NegativeWidth_ReturnsEmptyString()
    {
        int height = 2;
        int width = -3;

        string result = Q2_Ascii.CreateStaircase(height, width);

        Assert.AreEqual("", result);
    }

}