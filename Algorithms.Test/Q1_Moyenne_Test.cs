namespace Algorithms.Test;


[TestClass]
public class Q1_Moyenne_Test
{

    [TestMethod]
    public void AverageIsValid()
    {
        // Créer une liste de nombres pour tester la fonction CalculateAverage
        List<double> testNumbers = new List<double> { 10.5, 20.3, 15.7, 8.2, 12.9 };

        // Calculer la moyenne attendue
        double expectedAverage = (10.5 + 20.3 + 15.7 + 8.2 + 12.9) / 5;

        // Appeler la fonction CalculateAverage pour obtenir la moyenne calculée
        double actualAverage = Q1_Moyenne.CalculateAverage(testNumbers);

        // Vérifier si la moyenne calculée correspond à la moyenne attendue avec une marge d'erreur très petite
        double margeErreur = 0.0001;
        Assert.AreEqual(expectedAverage, actualAverage, margeErreur);


        //   Assert.IsTrue(new List<double> ({34.1, 23.5}).IsValid());
        //     Assert.IsFalse(new List<double> ("rdd", "dwdd").IsValid());

        // Q1_Moyenne list1 = new List<double> {34.1, 23.5};
        //     Point point2 = new Point(5, 3);
        //     Point res = point1.MidPointOf(point2);
        //     Assert.AreEqual(3.5, res.X(), 0.001);
        //     Assert.AreEqual(4.5, res.Y(), 0.001);
    }

}