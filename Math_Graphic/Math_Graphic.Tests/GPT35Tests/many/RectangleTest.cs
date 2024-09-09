using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using NUnit.Framework;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * testy nie zostały napisane we frameworku NUnit
 */

namespace Math_Graphic.Tests.GPT35.alsoWithContext
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_ShouldInitializePointsCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(5, 1);
            var p3 = new PointXy(5, 4);
            var p4 = new PointXy(1, 4);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
        }

        [Test]
        public void DrawMe_ShouldGenerateCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(1, 3);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();
            var array = bitmap.GetArray();

            // Assert
            Assert.AreEqual(1, array[1, 1]);
            Assert.AreEqual(1, array[2, 1]);
            Assert.AreEqual(1, array[3, 1]);
            Assert.AreEqual(1, array[1, 2]);
            Assert.AreEqual(1, array[2, 2]);
            Assert.AreEqual(1, array[3, 2]);
            Assert.AreEqual(1, array[1, 3]);
            Assert.AreEqual(1, array[2, 3]);
            Assert.AreEqual(1, array[3, 3]);
            Assert.AreEqual(0, array[0, 0]); // Outside the rectangle
        }
        /* Test odrzucony
        [Test]
        public void Area_ShouldCalculateCorrectArea()
        {
            // Arrange
            var p1 = new PointXy(2, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(2, 6);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(16, area); // (5 - 2 + 1) * (6 - 2 + 1) = 16
        }*/
    }
}

/*
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using NUnit.Framework;

namespace Math_Graphic.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializePointsCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(5, 1);
            var p3 = new PointXy(5, 4);
            var p4 = new PointXy(1, 4);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
        }

        [TestMethod]
        public void DrawMe_ShouldGenerateCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(1, 3);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();
            var array = bitmap.GetArray();

            // Assert
            Assert.AreEqual(1, array[1, 1]);
            Assert.AreEqual(1, array[2, 1]);
            Assert.AreEqual(1, array[3, 1]);
            Assert.AreEqual(1, array[1, 2]);
            Assert.AreEqual(1, array[2, 2]);
            Assert.AreEqual(1, array[3, 2]);
            Assert.AreEqual(1, array[1, 3]);
            Assert.AreEqual(1, array[2, 3]);
            Assert.AreEqual(1, array[3, 3]);
            Assert.AreEqual(0, array[0, 0]); // Outside the rectangle
        }

        [TestMethod]
        public void Area_ShouldCalculateCorrectArea()
        {
            // Arrange
            var p1 = new PointXy(2, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(2, 6);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(16, area); // (5 - 2 + 1) * (6 - 2 + 1) = 16
        }
    }
}
*/