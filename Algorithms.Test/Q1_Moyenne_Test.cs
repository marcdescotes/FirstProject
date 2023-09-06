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

        // Vérifier si la moyenne calculée correspond à la moyenne attendue avec une petite marge d'erreur
        double margeErreur = 0.0001;
        Assert.AreEqual(expectedAverage, actualAverage, margeErreur);
    }

    [TestMethod]
    public void EmptyListReturnsZero()
    {
        // Créer une liste vide
        List<double> emptyList = new List<double>();

        // Appeler la fonction CalculateAverage avec la liste vide
        double actualAverage = Q1_Moyenne.CalculateAverage(emptyList);

        // La moyenne d'une liste vide doit être égale à zéro
        double expectedAverage = 0;

        Assert.AreEqual(expectedAverage, actualAverage);
    }

}