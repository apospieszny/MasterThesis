using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;
using System;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 * testy nie zostały napisane we frameworku NUnit
 */

namespace Math_Graphic.Tests.GPT4.alsoFirst
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void TestRectangleConstructorAndProperties()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(1, 3);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
            Assert.AreEqual(ShapeType.Rectangle, rectangle.ShapeType);
        }

        [Test]
        public void TestRectangleAreaCalculation()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(1, 3);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area); // (4-1+1)*(3-1+1) = 3*2 = 6, ale to jest 4*3=12
        }

        [Test]
        public void TestRectangleDrawMe()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(1, 3);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);
            var bitmap = rectangle.DrawMe();

            // Assert
            for (int i = rectangle.Origin().X; i <= rectangle.Origin().X + 3; i++)
            {
                for (int j = rectangle.Origin().Y; j <= rectangle.Origin().Y + 2; j++)
                {
                    Assert.AreEqual(1, bitmap.Get(i, j));
                }
            }
            Assert.AreEqual(0, bitmap.Get(0, 0)); // Sprawdzenie czy poza prostokątem jest 0
        }
    }
}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace Math_Graphic.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestRectangleConstructorAndProperties()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(1, 3);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
            Assert.AreEqual(ShapeType.Rectangle, rectangle.ShapeType);
        }

        [TestMethod]
        public void TestRectangleAreaCalculation()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(1, 3);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area); // (4-1+1)*(3-1+1) = 3*2 = 6, ale to jest 4*3=12
        }

        [TestMethod]
        public void TestRectangleDrawMe()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(1, 3);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);
            var bitmap = rectangle.DrawMe();

            // Assert
            for (int i = rectangle.Origin().X; i <= rectangle.Origin().X + 3; i++)
            {
                for (int j = rectangle.Origin().Y; j <= rectangle.Origin().Y + 2; j++)
                {
                    Assert.AreEqual(1, bitmap.Get(i, j));
                }
            }
            Assert.AreEqual(0, bitmap.Get(0, 0)); // Sprawdzenie czy poza prostokątem jest 0
        }
    }
}
*/