using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using NUnit.Framework;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT35.first
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Test_Origin_Should_Return_Correct_Origin_Point()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(2, 5);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var origin = triangle.Origin();

            // Assert
            Assert.AreEqual(1, origin.X);
            Assert.AreEqual(1, origin.Y);
        }
        /* Test odrzucony
        [Test]
        public void Test_DrawMe_Should_Calculate_Correct_Area_And_Draw_Correct_Bitmap()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(2, 5);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();
            var area = triangle.Area();

            // Assert
            // Powierzchnia powinna być poprawnie obliczona
            Assert.AreEqual(6, area);  // Oczekiwany wynik dla tego trójkąta

            // Sprawdzamy, czy bitmapa ma wartości odpowiadające rysunkowi trójkąta
            Assert.AreEqual(1, bitmap.Get(2, 3)); // Przykładowy punkt wewnątrz trójkąta
        }

        [Test]
        public void Test_Area_Should_Return_Correct_Area()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(4, 0);
            var p3 = new PointXy(2, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var area = triangle.Area();

            // Assert
            Assert.AreEqual(8, area); // Oczekiwany wynik dla tego trójkąta
        }

        [Test]
        public void Test_DrawMe_Should_Handle_Zero_Area_Triangle()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 0);
            var p3 = new PointXy(0, 0);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();
            var area = triangle.Area();

            // Assert
            Assert.AreEqual(0, area); // Powierzchnia powinna wynosić 0
            Assert.AreEqual(0, bitmap.GetSize()); // Bitmapa powinna być pusta
        }

        [Test]
        public void Test_DrawMe_Should_Handle_Degenerate_Triangle()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(4, 0);
            var p3 = new PointXy(8, 0);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();
            var area = triangle.Area();

            // Assert
            Assert.AreEqual(0, area); // Degenerowany trójkąt ma powierzchnię 0
            Assert.AreEqual(0, bitmap.Get(0, 0)); // Nie rysujemy żadnych punktów
        }*/
    }
}

/*
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using NUnit.Framework;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Test_Origin_Should_Return_Correct_Origin_Point()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(2, 5);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var origin = triangle.Origin();

            // Assert
            Assert.AreEqual(1, origin.X);
            Assert.AreEqual(1, origin.Y);
        }

        [Test]
        public void Test_DrawMe_Should_Calculate_Correct_Area_And_Draw_Correct_Bitmap()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(2, 5);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();
            var area = triangle.Area();

            // Assert
            // Powierzchnia powinna być poprawnie obliczona
            Assert.AreEqual(6, area);  // Oczekiwany wynik dla tego trójkąta

            // Sprawdzamy, czy bitmapa ma wartości odpowiadające rysunkowi trójkąta
            Assert.AreEqual(1, bitmap.Get(2, 3)); // Przykładowy punkt wewnątrz trójkąta
        }

        [Test]
        public void Test_Area_Should_Return_Correct_Area()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(4, 0);
            var p3 = new PointXy(2, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var area = triangle.Area();

            // Assert
            Assert.AreEqual(8, area); // Oczekiwany wynik dla tego trójkąta
        }

        [Test]
        public void Test_DrawMe_Should_Handle_Zero_Area_Triangle()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 0);
            var p3 = new PointXy(0, 0);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();
            var area = triangle.Area();

            // Assert
            Assert.AreEqual(0, area); // Powierzchnia powinna wynosić 0
            Assert.AreEqual(0, bitmap.GetSize()); // Bitmapa powinna być pusta
        }

        [Test]
        public void Test_DrawMe_Should_Handle_Degenerate_Triangle()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(4, 0);
            var p3 = new PointXy(8, 0);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();
            var area = triangle.Area();

            // Assert
            Assert.AreEqual(0, area); // Degenerowany trójkąt ma powierzchnię 0
            Assert.AreEqual(0, bitmap.Get(0, 0)); // Nie rysujemy żadnych punktów
        }
    }
}
*/