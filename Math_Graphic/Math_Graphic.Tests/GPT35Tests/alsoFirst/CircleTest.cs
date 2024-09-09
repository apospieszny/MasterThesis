using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT35.alsoFirst
{
    [TestFixture]
    public class CircleTests
    {/* Test odrzucony
        [Test]
        public void Circle_DrawMe_ReturnsCorrectBitmap()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            var bitmap = circle.DrawMe();

            // Assert
            Assert.AreEqual(21 * 21, bitmap.GetSize()); 
            Assert.AreEqual(1, bitmap.Get(510, 510));  
        }*/

        [Test]
        public void Circle_Origin_ReturnsCorrectOrigin()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            var origin = circle.Origin();

            // Assert
            Assert.AreEqual(490, origin.X); 
            Assert.AreEqual(490, origin.Y);
        }

        [Test]
        public void Circle_Area_CalculatesCorrectArea_AfterDrawMe()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            circle.DrawMe(); 
            var area = circle.Area();

            // Assert
            Assert.AreEqual(317, area); 
        }

        [Test]
        public void Circle_Area_CalculatesCorrectArea_WithoutDrawMe()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            var area = circle.Area(); 

            // Assert
            Assert.AreEqual(317, area); 
        }

        [Test]
        public void Circle_DrawMe_SetsArea()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            circle.DrawMe(); 
            var area = circle.Area();

            // Assert
            Assert.AreEqual(317, area); 
        }
    }
}


/*
using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;


namespace Math_Graphic.Tests.GPT35.alsoFirst
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Circle_DrawMe_ReturnsCorrectBitmap()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            var bitmap = circle.DrawMe();

            // Assert
            Assert.AreEqual(21 * 21, bitmap.GetSize()); 
            Assert.AreEqual(1, bitmap.Get(510, 510));  
        }

        [Test]
        public void Circle_Origin_ReturnsCorrectOrigin()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            var origin = circle.Origin();

            // Assert
            Assert.AreEqual(490, origin.X); 
            Assert.AreEqual(490, origin.Y);
        }

        [Test]
        public void Circle_Area_CalculatesCorrectArea_AfterDrawMe()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            circle.DrawMe(); 
            var area = circle.Area();

            // Assert
            Assert.AreEqual(317, area); 
        }

        [Test]
        public void Circle_Area_CalculatesCorrectArea_WithoutDrawMe()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            var area = circle.Area(); 

            // Assert
            Assert.AreEqual(317, area); 
        }

        [Test]
        public void Circle_DrawMe_SetsArea()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var circle = new Circle(center, 10);

            // Act
            circle.DrawMe(); 
            var area = circle.Area();

            // Assert
            Assert.AreEqual(317, area); 
        }
    }
}


*/