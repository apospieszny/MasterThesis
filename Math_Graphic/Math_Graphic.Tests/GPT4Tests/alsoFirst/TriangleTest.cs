using Math_Graphic.core.math.shapes;
using Math_Graphic.core.math;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 * Testy zostały wygenerowane poza klasą
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.GPT4.alsoFirst;

[TestFixture]
public class TriangleTests
{

    [Test]
    public void Constructor_ShouldCreateTriangle_WithGivenPoints()
    {
        var p1 = new PointXy(0, 0);
        var p2 = new PointXy(1, 0);
        var p3 = new PointXy(0, 1);
        var triangle = new Triangle(p1, p2, p3);
        Assert.AreEqual(ShapeType.Triangle, triangle.ShapeType);
    }
    /* Test odrzucony
    [Test]
    public void DrawMe_ShouldCalculateCorrectArea_AndDrawBitmap()
    {
        var p1 = new PointXy(0, 0);
        var p2 = new PointXy(10, 0);
        var p3 = new PointXy(0, 10);
        var triangle = new Triangle(p1, p2, p3);
        var bitmap = triangle.DrawMe();
        Assert.AreEqual(50, triangle.Area());
        Assert.IsNotNull(bitmap);
    }

    [Test]
    public void Origin_ShouldReturnCorrectPoint()
    {
        var p1 = new PointXy(2, 2);
        var p2 = new PointXy(3, 5);
        var p3 = new PointXy(1, 1);
        var triangle = new Triangle(p1, p2, p3);
        var origin = triangle.Origin();
        Assert.AreEqual(new PointXy(1, 1), origin);
    }

    [Test]
    public void Area_ShouldReturnCorrectArea_AfterDrawing()
    {
        var p1 = new PointXy(0, 0);
        var p2 = new PointXy(4, 0);
        var p3 = new PointXy(0, 3);
        var triangle = new Triangle(p1, p2, p3);
        Assert.AreEqual(-1, triangle.Area());
        triangle.DrawMe();
        Assert.AreEqual(6, triangle.Area());
    }*/
}

/*
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.math;

[Test]
public void Constructor_ShouldCreateTriangle_WithGivenPoints()
{
    var p1 = new PointXy(0, 0);
    var p2 = new PointXy(1, 0);
    var p3 = new PointXy(0, 1);
    var triangle = new Triangle(p1, p2, p3);
    Assert.AreEqual(ShapeType.Triangle, triangle.ShapeType);
    Assert.AreEqual(p1, triangle.P1);
    Assert.AreEqual(p2, triangle.P2);
    Assert.AreEqual(p3, triangle.P3);
}

[TestCase(0, 0, true)]
[TestCase(1, 1, false)]
[TestCase(0, 1, true)]
[TestCase(-1, -1, false)]
public void PointInTriangle_ShouldReturnCorrectStatus(int x, int y, bool expected)
{
    var p1 = new PointXy(0, 0);
    var p2 = new PointXy(2, 0);
    var p3 = new PointXy(1, 2);
    var triangle = new Triangle(p1, p2, p3);
    var result = triangle.PointInTriangle(x, y);
    Assert.AreEqual(expected, result);
}

[Test]
public void DrawMe_ShouldCalculateCorrectArea_AndDrawBitmap()
{
    var p1 = new PointXy(0, 0);
    var p2 = new PointXy(10, 0);
    var p3 = new PointXy(0, 10);
    var triangle = new Triangle(p1, p2, p3);
    var bitmap = triangle.DrawMe();
    Assert.AreEqual(50, triangle.Area());
    Assert.IsNotNull(bitmap);
}

[Test]
public void Origin_ShouldReturnCorrectPoint()
{
    var p1 = new PointXy(2, 2);
    var p2 = new PointXy(3, 5);
    var p3 = new PointXy(1, 1);
    var triangle = new Triangle(p1, p2, p3);
    var origin = triangle.Origin();
    Assert.AreEqual(new PointXy(1, 1), origin);
}

[Test]
public void Area_ShouldReturnCorrectArea_AfterDrawing()
{
    var p1 = new PointXy(0, 0);
    var p2 = new PointXy(4, 0);
    var p3 = new PointXy(0, 3);
    var triangle = new Triangle(p1, p2, p3);
    Assert.AreEqual(-1, triangle.Area());
    triangle.DrawMe();
    Assert.AreEqual(6, triangle.Area());
}
*/