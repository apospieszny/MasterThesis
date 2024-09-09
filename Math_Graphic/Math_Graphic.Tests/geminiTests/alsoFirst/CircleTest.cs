using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;
using System;

/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 * Testy zostały wygenerowane poza klasą
 */

namespace Math_Graphic.Tests.gemini.alsoFirst
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

        private static Bitmap CreateExpectedBitmap(int[,] expectedArray)
        {
            return new Bitmap(expectedArray);
        }
        /* Test odrzucony
        [Test]
        public void Circle_DrawMe_EmptyCircle()
        {
            // Test case for radius 0
            var circle = new Circle(new PointXy(50, 50), 0);
            var expectedArray = new int[1000, 1000];

            // Call DrawMe and compare with expected empty array
            var actualBitmap = circle.DrawMe();
            Assert.AreEqual(expectedArray, actualBitmap.GetArray());
        }

        [Test]
        public void Circle_DrawMe_SmallCircle()
        {
            // Test case for small radius
            var circle = new Circle(new PointXy(50, 50), 2);
            var expectedArray = new int[1000, 1000];

            // Set expected values for a 2x2 circle
            expectedArray[51, 50] = 1;
            expectedArray[51, 51] = 1;
            expectedArray[50, 50] = 1;
            expectedArray[50, 51] = 1;

            // Call DrawMe and compare with expected array
            var actualBitmap = circle.DrawMe();
            Assert.AreEqual(expectedArray, actualBitmap.GetArray());
        }

        [Test]
        public void Circle_DrawMe_LargeCircle()
        {
            var circle = new Circle(new PointXy(250, 250), 100);

            var actualBitmap = circle.DrawMe();

            Assert.AreEqual(System.Math.PI * System.Math.Pow(100, 2), circle.Area());
        }

        [Test]
        public void Circle_Origin_ReturnsCorrectOrigin()
        {
            Assert.AreEqual(new PointXy(30, 30), _circle.Origin());
        }

        [Test]
        public void Circle_Area_CalculatesAreaCorrectly()
        {
            _circle.DrawMe();

            Assert.AreEqual(System.Math.PI * System.Math.Pow(20, 2), _circle.Area());
        }*/
    }
}


/*
using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

namespace Math_Graphic.Tests.core.math.shapes
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

        private static Bitmap CreateExpectedBitmap(int[,] expectedArray)
        {
            return new Bitmap(expectedArray);
        }
    }

    [Test]
    public void Circle_Constructor_SetsPropertiesCorrectly()
    {     
        Assert.AreEqual(new PointXy(50, 50), _circle._center);
        Assert.AreEqual(20, _circle._r);
        Assert.AreEqual(ShapeType.Circle, _circle.ShapeType);
    }

    [Test]
    public void Circle_DrawMe_EmptyCircle()
    {        
        var circle = new Circle(new PointXy(50, 50), 0);
        var expectedArray = new int[1000, 1000];
        
        var actualBitmap = circle.DrawMe();
        Assert.AreEqual(expectedArray, actualBitmap.GetArray());
    }

    [Test]
    public void Circle_DrawMe_SmallCircle()
    {        
        var circle = new Circle(new PointXy(50, 50), 2);
        var expectedArray = new int[1000, 1000];
       
        expectedArray[51, 50] = 1;
        expectedArray[51, 51] = 1;
        expectedArray[50, 50] = 1;
        expectedArray[50, 51] = 1;
        
        var actualBitmap = circle.DrawMe();
        Assert.AreEqual(expectedArray, actualBitmap.GetArray());
    }

    [Test]
    public void Circle_DrawMe_LargeCircle()
    {        
        var circle = new Circle(new PointXy(250, 250), 100);
        
        var actualBitmap = circle.DrawMe();

        Assert.AreEqual(Math.PI * Math.Pow(100, 2), circle.Area());
    }

    [Test]
    public void Circle_Origin_ReturnsCorrectOrigin()
    {
        Assert.AreEqual(new PointXy(30, 30), _circle.Origin());
    }

    [Test]
    public void Circle_Area_CalculatesAreaCorrectly()
    {
        _circle.DrawMe();

        Assert.AreEqual(Math.PI * Math.Pow(20, 2), _circle.Area());
    }
}
*/