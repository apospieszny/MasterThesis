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
 */

namespace Math_Graphic.Tests.geminiAdvanced.alsoWithContext;

[TestFixture]
public class CircleTests
{

    [Test]
    public void Constructor_SetsPropertiesCorrectly()
    {
        var center = new PointXy(5, 10);
        var radius = 3;
        var circle = new Circle(center, radius);

        Assert.AreEqual(ShapeType.Circle, circle.ShapeType);

    }
    /* Test odrzucony
    [Test]
    public void DrawMe_CreatesBitmapAndCalculatesArea()
    {
        var circle = new Circle(new PointXy(5, 5), 3);
        var bitmap = circle.DrawMe();


        Assert.AreEqual(1000 * 1000, bitmap.GetSize()); 

        Assert.AreEqual(1, bitmap.Get(2, 2)); 
        Assert.AreEqual(1, bitmap.Get(5, 5)); 
        Assert.AreEqual(0, bitmap.Get(0, 0)); 

    }

    // Test metody Origin
    [Test]
    public void Origin_ReturnsCorrectPoint()
    {
        var circle = new Circle(new PointXy(5, 10), 3);
        var origin = circle.Origin();

        Assert.AreEqual(new PointXy(2, 7), origin); 
    }

    // Test metody Area
    [Test]
    public void Area_CalculatesAreaCorrectly()
    {
        var circle = new Circle(new PointXy(0, 0), 5);

        var area = circle.Area();
        
        Assert.IsTrue(System.Math.Abs(area - System.Math.PI * 5 * 5) < 5);

        var area2 = circle.Area();
        Assert.AreEqual(area, area2);
    }*/

}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

namespace Math_Graphic.core.tests.math.shapes;

[TestFixture]
public class CircleTests
{

    [Test]
    public void Constructor_SetsPropertiesCorrectly()
    {
        var center = new PointXy(5, 10);
        var radius = 3;
        var circle = new Circle(center, radius);

        Assert.AreEqual(center, circle._center); 
        Assert.AreEqual(radius, circle._r);
        Assert.AreEqual(ShapeType.Circle, circle.ShapeType);
        Assert.AreEqual(-1, circle._area); 
    }

    // Test metody DrawMe
    [Test]
    public void DrawMe_CreatesBitmapAndCalculatesArea()
    {
        var circle = new Circle(new PointXy(5, 5), 3);
        var bitmap = circle.DrawMe();


        Assert.AreEqual(1000 * 1000, bitmap.GetSize()); 

        Assert.AreEqual(1, bitmap.Get(2, 2)); 
        Assert.AreEqual(1, bitmap.Get(5, 5)); 
        Assert.AreEqual(0, bitmap.Get(0, 0)); 

        Assert.AreNotEqual(-1, circle._area); 
        Assert.IsTrue(circle._area > 0); 
    }

    // Test metody Origin
    [Test]
    public void Origin_ReturnsCorrectPoint()
    {
        var circle = new Circle(new PointXy(5, 10), 3);
        var origin = circle.Origin();

        Assert.AreEqual(new PointXy(2, 7), origin); 
    }

    // Test metody Area
    [Test]
    public void Area_CalculatesAreaCorrectly()
    {
        var circle = new Circle(new PointXy(0, 0), 5);

        var area = circle.Area();

        Assert.IsTrue(Math.Abs(area - Math.PI * 5 * 5) < 5);

        var area2 = circle.Area();
        Assert.AreEqual(area, area2);
    }

}
*/