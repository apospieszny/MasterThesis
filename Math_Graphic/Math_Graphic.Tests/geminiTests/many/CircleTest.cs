using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;


/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 * AI wygenerowało coś niepowiązanego z kodem 
 */

namespace Math_Graphic.Tests.gemini.alsoWithContext
{
    [TestFixture]
    public class CircleTests
    {
        private Circle _circle;

        [SetUp]
        public void Setup()
        {
            _circle = new Circle(new PointXy(50, 50), 20);
        }

        private static int[,] GetExpectedArray(int radius)
        {
            int size = 2 * radius + 1;
            var array = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int dx = i - radius;
                    int dy = j - radius;
                    if (dx * dx + dy * dy <= radius * radius)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }

        /* Test odrzucony
        [Test]
        public void Constructor_ThrowsArgumentException_ForNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(new PointXy(50, 50), -10));
        }*/

        [Test]
        public void Origin_CalculatesCorrectOrigin()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_circle.Origin().X, Is.EqualTo(30));
                Assert.That(_circle.Origin().Y, Is.EqualTo(30));
            });
        }
        /* Test odrzucony
        [Test]
        public void Area_CalculatesAreaCorrectly_WhenNotPreviouslyCalculated()
        {
            Assert.That(_circle.Area(), Is.EqualTo(System.Math.PI * 20 * 20)); 
        }


        [Test]
        public void DrawMe_CreatesCorrectBitmap_WithExpectedSize()
        {
            var bitmap = _circle.DrawMe();
            Assert.That(bitmap.GetSize(), Is.EqualTo(41)); 
        }*/

    }
}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

namespace Math_Graphic.Tests.Shapes
{
    [TestFixture]
    public class CircleTests
    {
        private Circle _circle;

        [SetUp]
        public void Setup()
        {
            _circle = new Circle(new PointXy(50, 50), 20);
        }

        private static int[,] GetExpectedArray(int radius)
        {
            int size = 2 * radius + 1;
            var array = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int dx = i - radius;
                    int dy = j - radius;
                    if (dx * dx + dy * dy <= radius * radius)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }

        [Test]
        public void Constructor_SetsCenterAndRadiusCorrectly()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_circle.Center.X, Is.EqualTo(50));
                Assert.That(_circle.Center.Y, Is.EqualTo(50));
                Assert.That(_circle.Radius, Is.EqualTo(20));
            });
        }

        [Test]
        を渡してコンストラクタを呼び出すとArgumentExceptionが発生すること()
        public void Constructor_ThrowsArgumentException_ForNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(new PointXy(50, 50), -10));
        }

        [Test]
        public void Origin_CalculatesCorrectOrigin()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_circle.Origin().X, Is.EqualTo(30));
                Assert.That(_circle.Origin().Y, Is.EqualTo(30));
            });
        }

        [Test]
        public void Area_CalculatesAreaCorrectly_WhenNotPreviouslyCalculated()
        {
            Assert.That(_circle.Area(), Is.EqualTo(Math.PI * 20 * 20)); 
        }

        [Test]
        public void Area_ReturnsCachedValue_IfPreviouslyCalculated()
        {
            _circle.DrawMe(); 

            var area = _circle.Area();
            Assert.That(area, Is0 * 20)); 
        }

        [Test]
        public void DrawMe_CreatesCorrectBitmap_WithExpectedSize()
        {
            var bitmap = _circle.DrawMe();
            Assert.That(bitmap.GetSize(), Is.EqualTo(41)); 
        }

        [Test]
        public void DrawMe_SetsPixelsCorrectly_ForPointsWithinCircle()
        {
            var bitmap = _circle.DrawMe();
            int centerX = _circle.Center.X;
            int centerY = _circle.Center.Y;
            int radius = _circle.Radius;

            Assert.That(bitmap.Get(centerX, centerY), Is.EqualTo(1));
            Assert.That(bitmap.Get(centerX + radius, centerY), Is.EqualTo(1));
            Assert.That(bitmap.Get(centerX - radius, centerY), Is.EqualTo(1));
            Assert.That(bitmap.Get(centerX, centerY + radius), Is.EqualTo(1));
            Assert.That(bitmap.Get(centerX, centerY - radius), Is.EqualTo(1));
        }

        [Test]
        public void DrawMe_SetsPixelsCorrectly_ForPointsOutsideCircle()
        {
            var bitmap = _circle.DrawMe();
            int centerX = _circle.Center.X;
            int centerY = _circle.Center.Y;
            int radius = _circle.Radius;

            Assert.That(bitmap.Get(centerX + radius + 1, centerY), Is.EqualTo(0));
            Assert.That(bitmap.Get(centerX - radius - 1, centerY), Is.EqualTo(0));
            Assert.That(bitmap.Get(centerX, centerY + radius + 1), Is.EqualTo(0));
            Assert.That(bitmap.Get(centerX, centerY - radius - 1), Is.EqualTo(0));
        }
    }
}
*/