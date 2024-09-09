using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.geminiAdvanced.first
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_OrdersPointsCorrectly()
        {
            // Arrange
            var p1 = new PointXy(2, 3);
            var p2 = new PointXy(1, 5);
            var p3 = new PointXy(4, 1);
            var p4 = new PointXy(3, 4);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);

            // Możesz dodać więcej asercji, aby sprawdzić, czy pozostałe punkty (_p2, _p3, _p4) są również ustawione poprawnie
        }
        /* Test odrzucony
        [Test]
        public void DrawMe_CreatesBitmapWithCorrectDimensions()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(1, 5);
            var p3 = new PointXy(4, 5);
            var p4 = new PointXy(4, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.AreEqual(1000, bitmap.GetSize()); // Zakładając, że Bitmap ma stały rozmiar 1000x1000
            // Sprawdź, czy punkty wewnątrz prostokąta mają wartość 1
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 2; j <= 4; j++)
                {
                    Assert.AreEqual(1, bitmap.Get(i, j));
                }
            }
        }*/

        [Test]
        public void Area_CalculatesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 3);
            var p3 = new PointXy(2, 3);
            var p4 = new PointXy(2, 0);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area); // (2 + 1) * (3 + 1) = 12
        }

    }
}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_OrdersPointsCorrectly()
        {
            // Arrange
            var p1 = new PointXy(2, 3);
            var p2 = new PointXy(1, 5);
            var p3 = new PointXy(4, 1);
            var p4 = new PointXy(3, 4);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);

            // Możesz dodać więcej asercji, aby sprawdzić, czy pozostałe punkty (_p2, _p3, _p4) są również ustawione poprawnie
        }

        [Test]
        public void DrawMe_CreatesBitmapWithCorrectDimensions()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(1, 5);
            var p3 = new PointXy(4, 5);
            var p4 = new PointXy(4, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.AreEqual(1000, bitmap.GetSize()); // Zakładając, że Bitmap ma stały rozmiar 1000x1000
            // Sprawdź, czy punkty wewnątrz prostokąta mają wartość 1
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 2; j <= 4; j++)
                {
                    Assert.AreEqual(1, bitmap.Get(i, j));
                }
            }
        }

        [Test]
        public void Area_CalculatesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 3);
            var p3 = new PointXy(2, 3);
            var p4 = new PointXy(2, 0);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area); // (2 + 1) * (3 + 1) = 12
        }

    }
}
*/