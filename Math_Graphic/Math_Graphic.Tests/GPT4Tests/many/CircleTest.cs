using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using Math_Graphic.core.math;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT4.alsoWithContext
{
    [TestFixture]
    public class CircleTests
    {/* Test odrzucony
        [Test]
        public void Constructor_SetsCenterAndRadius()
        {
            var center = new PointXy(5, 5);
            int radius = 10;
            var circle = new Circle(center, radius);

            Assert.AreEqual(ShapeType.Circle, circle.ShapeType);
            Assert.AreEqual(center, circle.Origin()); // Metoda Origin powinna być publiczna do tego testu
            Assert.AreEqual(-1, circle.Area()); // Sprawdzamy, czy początkowa wartość area jest ustawiona na -1
        }*/

        [Test]
        public void DrawMe_CalculatesAreaCorrectly()
        {
            var center = new PointXy(500, 500);
            int radius = 50;
            var circle = new Circle(center, radius);

            var bitmap = circle.DrawMe();
            int expectedArea = 0;
            double pi = System.Math.PI;
            expectedArea = (int)(pi * radius * radius);

            Assert.AreEqual(expectedArea, circle.Area(), 10); // Dopuszczamy pewną tolerancję błędu
            Assert.AreEqual(1, bitmap.Get(center.X, center.Y)); // Sprawdzamy, czy środek jest zamalowany
        }

        [Test]
        public void Area_ReturnsCalculatedAreaWithoutRedrawing()
        {
            var center = new PointXy(500, 500);
            int radius = 50;
            var circle = new Circle(center, radius);

            circle.DrawMe(); // Najpierw rysujemy, aby wywołać obliczenie
            int expectedArea = circle.Area();
            int areaAfter = circle.Area(); // Wywołujemy ponownie, aby sprawdzić, czy nie jest przeliczane

            Assert.AreEqual(expectedArea, areaAfter);
        }

        [Test]
        public void Origin_CalculatesCorrectOrigin()
        {
            var center = new PointXy(500, 500);
            int radius = 100;
            var circle = new Circle(center, radius);

            var expectedOrigin = new PointXy(400, 400); // Początkowe X i Y minus promień
            var origin = circle.Origin();

            Assert.AreEqual(expectedOrigin.X, origin.X);
            Assert.AreEqual(expectedOrigin.Y, origin.Y);
        }
    }
}

/*
Wygenerowany kod:

using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Constructor_SetsCenterAndRadius()
        {
            var center = new PointXy(5, 5);
            int radius = 10;
            var circle = new Circle(center, radius);

            Assert.AreEqual(ShapeType.Circle, circle.ShapeType);
            Assert.AreEqual(center, circle.Origin()); // Metoda Origin powinna być publiczna do tego testu
            Assert.AreEqual(-1, circle.Area()); // Sprawdzamy, czy początkowa wartość area jest ustawiona na -1
        }

        [Test]
        public void DrawMe_CalculatesAreaCorrectly()
        {
            var center = new PointXy(500, 500);
            int radius = 50;
            var circle = new Circle(center, radius);

            var bitmap = circle.DrawMe();
            int expectedArea = 0;
            double pi = Math.PI;
            expectedArea = (int)(pi * radius * radius);

            Assert.AreEqual(expectedArea, circle.Area(), 10); // Dopuszczamy pewną tolerancję błędu
            Assert.AreEqual(1, bitmap.Get(center.X, center.Y)); // Sprawdzamy, czy środek jest zamalowany
        }

        [Test]
        public void Area_ReturnsCalculatedAreaWithoutRedrawing()
        {
            var center = new PointXy(500, 500);
            int radius = 50;
            var circle = new Circle(center, radius);

            circle.DrawMe(); // Najpierw rysujemy, aby wywołać obliczenie
            int expectedArea = circle.Area();
            int areaAfter = circle.Area(); // Wywołujemy ponownie, aby sprawdzić, czy nie jest przeliczane

            Assert.AreEqual(expectedArea, areaAfter);
        }

        [Test]
        public void Origin_CalculatesCorrectOrigin()
        {
            var center = new PointXy(500, 500);
            int radius = 100;
            var circle = new Circle(center, radius);

            var expectedOrigin = new PointXy(400, 400); // Początkowe X i Y minus promień
            var origin = circle.Origin();

            Assert.AreEqual(expectedOrigin.X, origin.X);
            Assert.AreEqual(expectedOrigin.Y, origin.Y);
        }
    }
}
*/