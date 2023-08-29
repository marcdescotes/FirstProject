using Algorithms.IdCard;

namespace Algorithms.Test;


[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void TestIsValid()
    {
        Assert.IsFalse(new Name("345", "231").IsValid());
        Assert.IsTrue(new Name("rdd", "dwdd").IsValid());
    }

    [TestMethod]
    public void TestIsValid2()
    {
        Assert.IsTrue(new PostalCode("J0S 1J0").IsValid());
        Assert.IsFalse(new PostalCode("J6n 34aerfaerf0G7").IsValid());
    }

    [TestMethod]
    public void TestIsValid3()
    {
        Assert.IsTrue(new TelephonNumber("450 327-8914").IsValid());
        Assert.IsTrue(new TelephonNumber("+1 450 337-6955").IsValid());
        Assert.IsFalse(new TelephonNumber("J6n 34aerfaerf0G7").IsValid());
    }

    [TestMethod]
    public void TriangleToString()
    {
        Point point = new Point(0, 1);
        Assert.AreEqual("", point.ToString());
    }

    [TestMethod]
    public void TestMidPointOf()
    {
        Point point1 = new Point(2, 6);
        Point point2 = new Point(5, 3);
        Point res = point1.MidPointOf(point2);
        Assert.AreEqual(3.5, res.X(), 0.001);
        Assert.AreEqual(4.5, res.Y(), 0.001);
    }

}