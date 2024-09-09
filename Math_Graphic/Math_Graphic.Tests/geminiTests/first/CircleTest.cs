using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * testy nie zostały napisane we frameworku NUnit
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.gemini.first
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Circle_Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var center = new PointXy(5, 3);
            int radius = 2;

            // Act
            var circle = new Circle(center, radius);

            // Assert
            Assert.AreEqual(ShapeType.Circle, circle.ShapeType);
        }
        /* Test odrzucony
        [Test]
        public void Circle_DrawMe_DrawsCircleCorrectlyForRadius1AtOrigin()
        {
            // Arrange
            var circle = new Circle(new PointXy(0, 0), 1);

            // Act
            var bitmap = circle.DrawMe();

            // Assert
            Assert.AreEqual(1000, bitmap.GetSize()); 

            Assert.AreEqual(1, bitmap.Get(0, 0));
            Assert.AreEqual(1, bitmap.Get(1, 0));
            Assert.AreEqual(1, bitmap.Get(0, 1));
            Assert.AreEqual(0, bitmap.Get(2, 0)); 
            Assert.AreEqual(0, bitmap.Get(0, 2)); 
        }


        [Test]
        public void Circle_Area_ReturnsCachedValueWithoutCallingDrawMe()
        {
            // Arrange
            var circle = new Circle(new PointXy(0, 0), 2);
            circle.DrawMe(); 

            // Act
            int area = circle.Area();

            // Assert
            Assert.IsNull(circle.DrawMe()); 
        }

        [Test]
        public void Circle_Origin_CalculatesOriginCorrectly()
        {
            // Arrange
            var center = new PointXy(3, 4);
            int radius = 2;
            var circle = new Circle(center, radius);

            // Act
            var origin = circle.Origin();

            // Assert
            Assert.AreEqual(new PointXy(1, 2), origin);
        }*/
    }
}

/*
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Math_Graphic.Tests.core.math.shapes
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var center = new PointXy(5, 3);
            int radius = 2;

            // Act
            var circle = new Circle(center, radius);

            // Assert
            Assert.AreEqual(center, circle._center);
            Assert.AreEqual(radius, circle._r);
            Assert.AreEqual(ShapeType.Circle, circle.ShapeType);
        }

        [TestMethod]
        public void Circle_DrawMe_DrawsCircleCorrectlyForRadius1AtOrigin()
        {
            // Arrange
            var circle = new Circle(new PointXy(0, 0), 1);

            // Act
            var bitmap = circle.DrawMe();

            // Assert
            Assert.AreEqual(1000, bitmap.GetSize()); // Verify bitmap size

            Assert.AreEqual(1, bitmap.Get(0, 0));
            Assert.AreEqual(1, bitmap.Get(1, 0));
            Assert.AreEqual(1, bitmap.Get(0, 1));
            Assert.AreEqual(0, bitmap.Get(2, 0)); 
            Assert.AreEqual(0, bitmap.Get(0, 2)); 
        }

        [TestMethod]
        public void Circle_DrawMe_CalculatesAreaCorrectly()
        {
            // Arrange
            var circle = new Circle(new PointXy(0, 0), 2);

            // Act
            var bitmap = circle.DrawMe();
            int area = circle.Area();

            // Assert
            Assert.AreEqual(Math.PI * Math.Pow(circle._r, 2), area, 0.01); 
        }

        [TestMethod]
        public void Circle_Area_ReturnsCachedValueWithoutCallingDrawMe()
        {
            // Arrange
            var circle = new Circle(new PointXy(0, 0), 2);
            circle.DrawMe(); 

            // Act
            int area = circle.Area();

            // Assert
            Assert.AreEqual(Math.PI * Math.Pow(circle._r, 2), area, 0.01);
            Assert.IsNull(circle.DrawMe()); 
        }

        [TestMethod]
        public void Circle_Origin_CalculatesOriginCorrectly()
        {
            // Arrange
            var center = new PointXy(3, 4);
            int radius = 2;
            var circle = new Circle(center, radius);

            // Act
            var origin = circle.Origin();

            // Assert
            Assert.AreEqual(new PointXy(1, 2), origin);
        }
    }
}
*/