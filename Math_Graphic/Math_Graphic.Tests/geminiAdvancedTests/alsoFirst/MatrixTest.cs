using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.geminiAdvanced.alsoFirst;

public class MatrixTests
{
    [Test]
    public void Constructor_WithRealMatrix_SetsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        Assert.AreEqual(realMatrix, matrix.GetRealMatrix());
    }

    [Test]
    public void Constructor_WithoutParameters_Creates3x3Matrix()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(3, matrix.GetHeight());
    }

    [Test]
    public void CreateIMatrix_ReturnsNewMatrixWithGivenRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix();
        var newMatrix = matrix.CreateIMatrix(realMatrix);

        Assert.AreEqual(realMatrix, ((Matrix)newMatrix).GetRealMatrix());
    }

    [Test]
    public void CreateIdentityMatrix_SetsRealMatrixToIdentityMatrix()
    {
        var matrix = new Matrix();
        matrix.CreateIdentityMatrix(3);

        var expected = new double[][]
        {
            new double[] { 1, 0, 0 },
            new double[] { 0, 1, 0 },
            new double[] { 0, 0, 1 }
        };

        Assert.AreEqual(expected, matrix.GetRealMatrix().GetData());
    }
    /* Test odrzucony
    [Test]
    public void Determinant_ReturnsCorrectDeterminant()
    {
        var values = new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        var determinant = matrix.Determinant();

        Assert.AreEqual(0, determinant); // Determinant of this matrix is 0
    }*/

    [Test]
    public void GetMatrixValue_ReturnsCorrectValue()
    {
        var values = new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        var value = matrix.GetMatrixValue(1, 0);

        Assert.AreEqual(3, value);
    }

    [Test]
    public void SetMatrixValue_SetsCorrectValue()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValue(0, 1, 5);

        Assert.AreEqual(5, matrix.GetRealMatrix().GetData()[0][1]);
    }

    [Test]
    public void SetMatrixValues_SetsRealMatrixToGivenValues()
    {
        var values = new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        Assert.AreEqual(values, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void GetWidth_ReturnsCorrectWidth()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetWidth());
    }

    [Test]
    public void GetHeight_ReturnsCorrectHeight()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetHeight());
    }
    /* Test odrzucony
    [Test]
    public void ToString_ReturnsFormattedMatrixString()
    {
        var values = new double[][]
        {
            new double[] { 1.123, 2.456 },
            new double[] { 3.789, 4.012 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        var expected = "<table>\n<tr>\n<td>1.1</td> <td>2.5</td> \n</tr>\n<tr>\n<td>3.8</td> <td>4.0</td> \n</tr>\n</table>";

        Assert.AreEqual(expected, matrix.ToString());
    }*/

    [Test]
    public void GetRealMatrix_ReturnsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        Assert.AreEqual(realMatrix, matrix.GetRealMatrix());
    }
}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

namespace Math_Graphic.core.math.tests.matrix;

public class MatrixTests
{
    [Test]
    public void Constructor_WithRealMatrix_SetsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        Assert.AreEqual(realMatrix, matrix.GetRealMatrix());
    }

    [Test]
    public void Constructor_WithoutParameters_Creates3x3Matrix()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(3, matrix.GetHeight());
    }

    [Test]
    public void CreateIMatrix_ReturnsNewMatrixWithGivenRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix();
        var newMatrix = matrix.CreateIMatrix(realMatrix);

        Assert.AreEqual(realMatrix, ((Matrix)newMatrix).GetRealMatrix());
    }

    [Test]
    public void CreateIdentityMatrix_SetsRealMatrixToIdentityMatrix()
    {
        var matrix = new Matrix();
        matrix.CreateIdentityMatrix(3);

        var expected = new double[][]
        {
            new double[] { 1, 0, 0 },
            new double[] { 0, 1, 0 },
            new double[] { 0, 0, 1 }
        };

        Assert.AreEqual(expected, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void Determinant_ReturnsCorrectDeterminant()
    {
        var values = new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        var determinant = matrix.Determinant();

        Assert.AreEqual(0, determinant); // Determinant of this matrix is 0
    }

    [Test]
    public void GetMatrixValue_ReturnsCorrectValue()
    {
        var values = new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        var value = matrix.GetMatrixValue(1, 0);

        Assert.AreEqual(3, value);
    }

    [Test]
    public void SetMatrixValue_SetsCorrectValue()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValue(0, 1, 5);

        Assert.AreEqual(5, matrix.GetRealMatrix().GetData()[0][1]);
    }

    [Test]
    public void SetMatrixValues_SetsRealMatrixToGivenValues()
    {
        var values = new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        Assert.AreEqual(values, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void GetWidth_ReturnsCorrectWidth()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetWidth());
    }

    [Test]
    public void GetHeight_ReturnsCorrectHeight()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetHeight());
    }

    [Test]
    public void ToString_ReturnsFormattedMatrixString()
    {
        var values = new double[][]
        {
            new double[] { 1.123, 2.456 },
            new double[] { 3.789, 4.012 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        var expected = "<table>\n<tr>\n<td>1.1</td> <td>2.5</td> \n</tr>\n<tr>\n<td>3.8</td> <td>4.0</td> \n</tr>\n</table>";

        Assert.AreEqual(expected, matrix.ToString());
    }

    [Test]
    public void GetRealMatrix_ReturnsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        Assert.AreEqual(realMatrix, matrix.GetRealMatrix());
    }
}
*/