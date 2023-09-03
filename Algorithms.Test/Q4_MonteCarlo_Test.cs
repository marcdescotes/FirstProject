namespace Algorithms.Test;


[TestClass]
public class MathUtilsTest
{
    [TestMethod]
    public void TestPiEstimation()
    {
        // Estimation de π avec un grand nombre de points
        int numberOfPoints = 1000000;
        double estimatedPi = MathUtils.PiEstimate(numberOfPoints);

        // Valeur attendue de π avec une précision de 10^-6
        double expectedPi = 3.1415926535897932384626433832795028841971;

        // Tolérance acceptable
        double tolerance = 1e-6;

        // Vérification si l'estimation est proche de la valeur attendue avec la tolérance
        Assert.IsTrue(Math.Abs(estimatedPi - expectedPi) < tolerance);
    }
}