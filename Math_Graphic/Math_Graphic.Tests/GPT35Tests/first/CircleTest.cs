using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;


/* 
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * testy nie zostały napisane we frameworku NUnit
 */

namespace Math_Graphic.Tests.GPT35.first
{
    public class CircleTests
    {/* Test odrzucony
        [Test]
        public void Constructor_ShouldSetProperties()
        {
            // Arrange
            var center = new PointXy(5, 5);
            var radius = 3;

            // Act
            var circle = new Circle(center, radius);

            // Assert
            Assert.Equals(ShapeType.Circle, circle.ShapeType);
            Assert.Equals(center.X - radius, circle.Origin().X);
            Assert.Equals(center.Y - radius, circle.Origin().Y);
        }

        [Test]
        public void DrawMe_ShouldCreateBitmapWithCorrectArea()
        {
            // Arrange
            var center = new PointXy(50, 50);
            var radius = 10;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();
            var area = circle.Area();

            // Assert
            Assert.Equals(area, CountFilledPixels(bitmap)); // Liczba wypełnionych pikseli powinna odpowiadać obliczonemu polu
        }

        [Test]
        public void DrawMe_ShouldCalculateAreaCorrectly_ForSmallCircle()
        {
            // Arrange
            var center = new PointXy(10, 10);
            var radius = 1;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();
            var area = circle.Area();

            // Assert
            Assert.Equals(5, area); // Sprawdzenie, czy pole dla okręgu o promieniu 1 wynosi 5 (wartość oczekiwana)
        }*/

        [Test]
        public void Area_ShouldReturnCorrectValue_AfterDrawMeIsCalled()
        {
            // Arrange
            var center = new PointXy(30, 30);
            var radius = 5;
            var circle = new Circle(center, radius);

            // Act
            circle.DrawMe(); // Wymuszamy obliczenie obszaru
            var area = circle.Area();

            // Assert
            Assert.AreNotEqual(-1, area); // Pole nie powinno być domyślną wartością (-1)
        }

        [Test]
        public void Area_ShouldCallDrawMeIfNotAlreadyCalled()
        {
            // Arrange
            var center = new PointXy(10, 10);
            var radius = 3;
            var circle = new Circle(center, radius);

            // Act
            var area = circle.Area(); // Powinno wywołać DrawMe(), jeśli pole nie zostało wcześniej obliczone

            // Assert
            Assert.AreNotEqual(-1, area); // Sprawdzenie, czy pole zostało poprawnie obliczone
        }

        // Pomocnicza metoda do liczenia wypełnionych pikseli w bitmapie
        private int CountFilledPixels(Bitmap bitmap)
        {
            var count = 0;
            var array = bitmap.GetArray();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}


/*
Wygenerowany kod:

using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;
using Xunit;

namespace Math_Graphic.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Constructor_ShouldSetProperties()
        {
            // Arrange
            var center = new PointXy(5, 5);
            var radius = 3;

            // Act
            var circle = new Circle(center, radius);

            // Assert
            Assert.Equal(ShapeType.Circle, circle.ShapeType);
            Assert.Equal(center.X - radius, circle.Origin().X);
            Assert.Equal(center.Y - radius, circle.Origin().Y);
        }

        [Fact]
        public void DrawMe_ShouldCreateBitmapWithCorrectArea()
        {
            // Arrange
            var center = new PointXy(50, 50);
            var radius = 10;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();
            var area = circle.Area();

            // Assert
            Assert.Equal(area, CountFilledPixels(bitmap)); // Liczba wypełnionych pikseli powinna odpowiadać obliczonemu polu
        }

        [Fact]
        public void DrawMe_ShouldCalculateAreaCorrectly_ForSmallCircle()
        {
            // Arrange
            var center = new PointXy(10, 10);
            var radius = 1;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();
            var area = circle.Area();

            // Assert
            Assert.Equal(5, area); // Sprawdzenie, czy pole dla okręgu o promieniu 1 wynosi 5 (wartość oczekiwana)
        }

        [Fact]
        public void Area_ShouldReturnCorrectValue_AfterDrawMeIsCalled()
        {
            // Arrange
            var center = new PointXy(30, 30);
            var radius = 5;
            var circle = new Circle(center, radius);

            // Act
            circle.DrawMe(); // Wymuszamy obliczenie obszaru
            var area = circle.Area();

            // Assert
            Assert.NotEqual(-1, area); // Pole nie powinno być domyślną wartością (-1)
        }

        [Fact]
        public void Area_ShouldCallDrawMeIfNotAlreadyCalled()
        {
            // Arrange
            var center = new PointXy(10, 10);
            var radius = 3;
            var circle = new Circle(center, radius);

            // Act
            var area = circle.Area(); // Powinno wywołać DrawMe(), jeśli pole nie zostało wcześniej obliczone

            // Assert
            Assert.NotEqual(-1, area); // Sprawdzenie, czy pole zostało poprawnie obliczone
        }

        // Pomocnicza metoda do liczenia wypełnionych pikseli w bitmapie
        private int CountFilledPixels(Bitmap bitmap)
        {
            var count = 0;
            var array = bitmap.GetArray();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
*/

