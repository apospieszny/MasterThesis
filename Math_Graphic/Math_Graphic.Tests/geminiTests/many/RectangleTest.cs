using NUnit.Framework;
using System.Drawing;
using Math_Graphic.core.math.shapes;
using Rectangle = Math_Graphic.core.math.shapes.Rectangle;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Wygenerowane dane są niekompletne
 */

namespace Math_Graphic.Tests.gemini.alsoWithContext
{
    [TestFixture]
    public class RectangleTests
    {/* Test odrzucony
        [Test]
        public void Constructor_ValidPoints_InitializesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(10, 0);
            var p3 = new PointXy(10, 10);
            var p4 = new PointXy(0, 10);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(p1, rectangle.Origin());
            Assert.AreEqual(100, rectangle.Area());

        }*/
    }
}
/*
using NUnit.Framework;
using System.Drawing;

namespace Math_Graphic.core.math.shapes.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_ValidPoints_InitializesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(10, 0);
            var p3 = new PointXy(10, 10);
            var p4 = new PointXy(0, 10);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(p1, rectangle.Origin());
            Assert.AreEqual(100, rectangle.Area());
        }

        [Test]
        public void Area_WithMutation_ShouldReturnIncorrectResult()
        {
            // ... (przygotowanie danych)

            // Mutacja: Zmiana operatora mnożenia na dodawanie
            var mutatedArea = (a + 1) + (b + 1);

            // Assert
            Assert.AreNotEqual(mutatedArea, rectangle.Area());
        }

        [Test]
        public void DrawMe_RandomData_ShouldProduceCorrectBitmap()
        {
            var random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var p1 = new PointXy(random.Next(-1000, 1000), random.Next(-1000, 1000));
                // ... pozostałe punkty
                var rectangle = new Rectangle(p1, p2, p3, p4);

                // Użycie biblioteki graficznej do sprawdzenia poprawności bitmapy
                var bitmap = rectangle.DrawMe();
                // ... porównanie z oczekiwanym wynikiem
            }
        }

        [Test]
        public void Area_AlwaysPositive()
        {
            // ... różne przypadki prostokątów
            Assert.GreaterOrEqual(rectangle.Area(), 0);
        }

        [Test]
        public void Area_MatchesGeometricFormula()
        {
            // ... obliczenie pola za pomocą wzoru geometrycznego
            var expectedArea = (p3.X - p1.X) * (p3.Y - p1.Y);
            Assert.AreEqual(expectedArea, rectangle.Area());
        }
    }
}
*/