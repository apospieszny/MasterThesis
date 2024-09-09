using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * testy nie zostały napisane we frameworku NUnit
 */

namespace Math_Graphic.Tests.GPT4.alsoWithContext;
public class MatrixTests
{
    [Test]
    public void TestConstructorWithRealMatrix()
    {
        double[][] data = { new double[] { 1, 2 }, new double[] { 3, 4 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        Assert.AreEqual(1, matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(2, matrix.GetMatrixValue(0, 1));
        Assert.AreEqual(3, matrix.GetMatrixValue(1, 0));
        Assert.AreEqual(4, matrix.GetMatrixValue(1, 1));
    }

    [Test]
    public void TestParameterlessConstructor()
    {
        Matrix matrix = new Matrix();
        Assert.AreEqual(0, matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(3, matrix.GetHeight());
    }

    [Test]
    public void TestCreateIMatrix()
    {
        double[][] data = { new double[] { 5, 6 }, new double[] { 7, 8 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix();
        IMatrix iMatrix = matrix.CreateIMatrix(realMatrix);
        Assert.AreEqual(5, iMatrix.GetMatrixValue(0, 0));
    }

    [Test]
    public void TestCreateIdentityMatrix()
    {
        Matrix matrix = new Matrix();
        matrix.CreateIdentityMatrix(2);
        Assert.AreEqual(1, matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(0, matrix.GetMatrixValue(0, 1));
        Assert.AreEqual(0, matrix.GetMatrixValue(1, 0));
        Assert.AreEqual(1, matrix.GetMatrixValue(1, 1));
    }

    [Test]
    public void TestDeterminant()
    {
        double[][] data = { new double[] { 4, 7 }, new double[] { 2, 6 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        Assert.AreEqual(10, matrix.Determinant());
    }

    [Test]
    public void TestSetAndGetMatrixValue()
    {
        Matrix matrix = new Matrix();
        matrix.SetMatrixValue(0, 0, 5);
        Assert.AreEqual(5, matrix.GetMatrixValue(0, 0));
    }

    [Test]
    public void TestSetMatrixValues()
    {
        Matrix matrix = new Matrix();
        double[][] values = { new double[] { 9, 8 }, new double[] { 7, 6 } };
        matrix.SetMatrixValues(values);
        Assert.AreEqual(9, matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(8, matrix.GetMatrixValue(0, 1));
        Assert.AreEqual(7, matrix.GetMatrixValue(1, 0));
        Assert.AreEqual(6, matrix.GetMatrixValue(1, 1));
    }

    [Test]
    public void TestGetWidthAndHeight()
    {
        double[][] data = { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(2, matrix.GetHeight());
    }
    /* Test odrzucony
    [Test]
    public void TestToString()
    {
        double[][] data = { new double[] { 1.2, 2.3 }, new double[] { 3.4, 4.5 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        string expected = "<table>\n<tr>\n<td>1.2</td> <td>2.3</td> \n</tr>\n<tr>\n<td>3.4</td> <td>4.5</td> \n</tr>\n</table>";
        Assert.AreEqual(expected, matrix.ToString());
    }*/

    [Test]
    public void TestGetRealMatrix()
    {
        double[][] data = { new double[] { 10, 20 }, new double[] { 30, 40 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        RealMatrix fetchedMatrix = matrix.GetRealMatrix();
        Assert.AreEqual(realMatrix.GetData(), fetchedMatrix.GetData());
    }
}


/*
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

[TestClass]
public class MatrixTests
{
    [TestMethod]
    public void TestConstructorWithRealMatrix()
    {
        double[][] data = { new double[] { 1, 2 }, new double[] { 3, 4 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        Assert.AreEqual(1, matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(2, matrix.GetMatrixValue(0, 1));
        Assert.AreEqual(3, matrix.GetMatrixValue(1, 0));
        Assert.AreEqual(4, matrix.GetMatrixValue(1, 1));
    }

    [TestMethod]
    public void TestParameterlessConstructor()
    {
        Matrix matrix = new Matrix();
        Assert.AreEqual(0, matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(3, matrix.GetHeight());
    }

    [TestMethod]
    public void TestCreateIMatrix()
    {
        double[][] data = { new double[] { 5, 6 }, new double[] { 7, 8 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix();
        IMatrix iMatrix = matrix.CreateIMatrix(realMatrix);
        Assert.AreEqual(5, iMatrix.GetMatrixValue(0, 0));
    }

    [TestMethod]
    public void TestCreateIdentityMatrix()
    {
        Matrix matrix = new Matrix();
        matrix.CreateIdentityMatrix(2);
        Assert.AreEqual(1, matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(0, matrix.GetMatrixValue(0, 1));
        Assert.AreEqual(0, matrix.GetMatrixValue(1, 0));
        Assert.AreEqual(1, matrix.GetMatrixValue(1, 1));
    }

    [TestMethod]
    public void TestDeterminant()
    {
        double[][] data = { new double[] { 4, 7 }, new double[] { 2, 6 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        Assert.AreEqual(10, matrix.Determinant());
    }

    [TestMethod]
    public void TestSetAndGetMatrixValue()
    {
        Matrix matrix = new Matrix();
        matrix.SetMatrixValue(0, 0, 5);
        Assert.AreEqual(5, matrix.GetMatrixValue(0, 0));
    }

    [TestMethod]
    public void TestSetMatrixValues()
    {
        Matrix matrix = new Matrix();
        double[][] values = { new double[] { 9, 8 }, new double[] { 7, 6 } };
        matrix.SetMatrixValues(values);
        Assert.AreEqual(9, matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(8, matrix.GetMatrixValue(0, 1));
        Assert.AreEqual(7, matrix.GetMatrixValue(1, 0));
        Assert.AreEqual(6, matrix.GetMatrixValue(1, 1));
    }

    [TestMethod]
    public void TestGetWidthAndHeight()
    {
        double[][] data = { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(2, matrix.GetHeight());
    }

    [TestMethod]
    public void TestToString()
    {
        double[][] data = { new double[] { 1.2, 2.3 }, new double[] { 3.4, 4.5 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        string expected = "<table>\n<tr>\n<td>1.2</td> <td>2.3</td> \n</tr>\n<tr>\n<td>3.4</td> <td>4.5</td> \n</tr>\n</table>";
        Assert.AreEqual(expected, matrix.ToString());
    }

    [TestMethod]
    public void TestGetRealMatrix()
    {
        double[][] data = { new double[] { 10, 20 }, new double[] { 30, 40 } };
        RealMatrix realMatrix = new RealMatrix(data);
        Matrix matrix = new Matrix(realMatrix);
        RealMatrix fetchedMatrix = matrix.GetRealMatrix();
        Assert.AreEqual(realMatrix.GetData(), fetchedMatrix.GetData());
    }
}

*/