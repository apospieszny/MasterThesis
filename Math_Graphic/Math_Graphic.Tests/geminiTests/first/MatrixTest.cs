using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * testy nie zostały napisane we frameworku NUnit
 * błędnie generowane metody
 */

namespace Math_Graphic.Tests.gemini.first;

public class MatrixTests
{/* Test odrzucony
    [Test]
    public void CreateMatrix_DefaultConstructor_Creates3x3Matrix()
    {
        var matrix = new Matrix();

        Assert.Equals(3, matrix.GetWidth());
        Assert.Equals(3, matrix.GetHeight());
    }

    [Test]
    public void CreateMatrix_WithRealMatrix_CreatesMatrixWithGivenValues()
    {
        var values = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
        };
        var realMatrix = new RealMatrix(values);
        var matrix = new Matrix(realMatrix);

        Assert.Equals(2, matrix.GetWidth());
        Assert.Equals(3, matrix.GetHeight());
        Assert.Equals(1, matrix.GetMatrixValue(0, 0));
        Assert.Equals(6, matrix.GetMatrixValue(1, 2));
    }

    [Test]
    public void CreateIMatrix_CreatesNewMatrixWithSameValues()
    {
        var values = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
        };
        var realMatrix = new RealMatrix(values);
        var matrix = new Matrix(realMatrix);
        var iMatrix = matrix.CreateIMatrix(realMatrix);

        Assert.AreNotEqual(matrix, iMatrix);
        Assert.Equals(matrix.ToString(), iMatrix.ToString());
    }

    [Test]
    public void CreateIdentityMatrix_CreatesIdentityMatrixOfGivenSize()
    {
        var matrix = new Matrix();
        matrix.CreateIdentityMatrix(4);

        Assert.Equals(4, matrix.GetWidth());
        Assert.Equals(4, matrix.GetHeight());
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j)
                {
                    Assert.Equals(1, matrix.GetMatrixValue(i, j));
                }
                else
                {
                    Assert.Equals(0, matrix.GetMatrixValue(i, j));
                }
            }
        }
    }

    [Test]
    public void Determinant_CalculatesDeterminantCorrectly()
    {
        var values = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
        };
        var matrix = new Matrix(new RealMatrix(values));

        Assert.Equals(0, matrix.Determinant());
    }

    [Test]
    public void GetMatrixValue_ReturnsCorrectValue()
    {
        var values = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
        };
        var matrix = new Matrix(new RealMatrix(values));

        Assert.Equals(5, matrix.GetMatrixValue(1, 1));
    }

    [Test]
    public void SetMatrixValue_SetsValueCorrectly()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValue(1, 2, 7);

        Assert.Equals(7, matrix.GetMatrixValue(1, 2));
    }

    [Test]
    public void SetMatrixValues_SetsMatrixValuesCorrectly()
    {
        var values = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        Assert.Equals(2, matrix.GetWidth());
        Assert.Equals(3, matrix.GetHeight());
        Assert.Equals(1, matrix.GetMatrixValue(0, 0));
        Assert.Equals(6, matrix.GetMatrixValue(1, 2));
    }

    [Test]
    public void GetWidth_ReturnsCorrectWidth()
    {
        var values = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
        };
        var matrix = new Matrix(new RealMatrix(values));

        Assert.Equals(3, matrix.GetWidth());
    }

    [Test]
    public void GetHeight_ReturnsCorrectHeight()
    {
        var values = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
        };
        var matrix = new Matrix(new RealMatrix(values));

        Assert.Equals(2, matrix.GetHeight());
    }

    [Test]
    public void ToString_ReturnsCorrectStringRepresentation()
    {
        var values = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
        };
        var matrix = new Matrix(new RealMatrix(values));

        var expectedString = "<table>\n<tr>\n<td>1.0</td> <td>2.0</td> <td>3.0</td> \n</tr>\n<tr>\n<td>4.0</td> <td>5.0</td> <td>6.0</td> \n</tr>\n</table>";
        Assert.Equals(expectedString, matrix.ToString());
    }*/

    // Additional tests for MatrixUtils and RealMatrix classes can be added here
}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using Xunit;

namespace Math_Graphic.core.math.tests;

public class MatrixTests
{
    [Fact]
    public void CreateMatrix_DefaultConstructor_Creates3x3Matrix()
    {
        var matrix = new Matrix();

        Assert.Equal(3, matrix.GetWidth());
        Assert.Equal(3, matrix.GetHeight());
    }

    [Fact]
    public void CreateMatrix_WithRealMatrix_CreatesMatrixWithGivenValues()
    {
        var values = new double[][] { { 1, 2, 3 }, { 4, 5, 6 } };
        var realMatrix = new RealMatrix(values);
        var matrix = new Matrix(realMatrix);

        Assert.Equal(2, matrix.GetWidth());
        Assert.Equal(3, matrix.GetHeight());
        Assert.Equal(1, matrix.GetMatrixValue(0, 0));
        Assert.Equal(6, matrix.GetMatrixValue(1, 2));
    }

    [Fact]
    public void CreateIMatrix_CreatesNewMatrixWithSameValues()
    {
        var values = new double[][] { { 1, 2, 3 }, { 4, 5, 6 } };
        var realMatrix = new RealMatrix(values);
        var matrix = new Matrix(realMatrix);
        var iMatrix = matrix.CreateIMatrix(realMatrix);

        Assert.NotSame(matrix, iMatrix);
        Assert.Equal(matrix.ToString(), iMatrix.ToString());
    }

    [Fact]
    public void CreateIdentityMatrix_CreatesIdentityMatrixOfGivenSize()
    {
        var matrix = new Matrix();
        matrix.CreateIdentityMatrix(4);

        Assert.Equal(4, matrix.GetWidth());
        Assert.Equal(4, matrix.GetHeight());
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j)
                {
                    Assert.Equal(1, matrix.GetMatrixValue(i, j));
                }
                else
                {
                    Assert.Equal(0, matrix.GetMatrixValue(i, j));
                }
            }
        }
    }

    [Fact]
    public void Determinant_CalculatesDeterminantCorrectly()
    {
        var values = new double[][] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var matrix = new Matrix(new RealMatrix(values));

        Assert.Equal(0, matrix.Determinant());
    }

    [Fact]
    public void GetMatrixValue_ReturnsCorrectValue()
    {
        var values = new double[][] { { 1, 2, 3 }, { 4, 5, 6 } };
        var matrix = new Matrix(new RealMatrix(values));

        Assert.Equal(5, matrix.GetMatrixValue(1, 1));
    }

    [Fact]
    public void SetMatrixValue_SetsValueCorrectly()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValue(1, 2, 7);

        Assert.Equal(7, matrix.GetMatrixValue(1, 2));
    }

    [Fact]
    public void SetMatrixValues_SetsMatrixValuesCorrectly()
    {
        var values = new double[][] { { 1, 2, 3 }, { 4, 5, 6 } };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        Assert.Equal(2, matrix.GetWidth());
        Assert.Equal(3, matrix.GetHeight());
        Assert.Equal(1, matrix.GetMatrixValue(0, 0));
        Assert.Equal(6, matrix.GetMatrixValue(1, 2));
    }

    [Fact]
    public void GetWidth_ReturnsCorrectWidth()
    {
        var values = new double[][] { { 1, 2, 3 }, { 4, 5, 6 } };
        var matrix = new Matrix(new RealMatrix(values));

        Assert.Equal(3, matrix.GetWidth());
    }

    [Fact]
    public void GetHeight_ReturnsCorrectHeight()
    {
        var values = new double[][] { { 1, 2, 3 }, { 4, 5, 6 } };
        var matrix = new Matrix(new RealMatrix(values));

        Assert.Equal(2, matrix.GetHeight());
    }

    [Fact]
    public void ToString_ReturnsCorrectStringRepresentation()
    {
        var values = new double[][] { { 1, 2, 3 }, { 4, 5, 6 } };
        var matrix = new Matrix(new RealMatrix(values));

        var expectedString = "<table>\n<tr>\n<td>1.0</td> <td>2.0</td> <td>3.0</td> \n</tr>\n<tr>\n<td>4.0</td> <td>5.0</td> <td>6.0</td> \n</tr>\n</table>";
        Assert.Equal(expectedString, matrix.ToString());
    }

    [Fact]
    public void GetRealMatrix_ReturnsUnderlyingRealMatrix()
    {
        var values = new double[][] { { 1, 2, 3 }, { 4, 5, 6 } };
        var matrix = new Matrix(new RealMatrix(values));
        var realMatrix = matrix.GetRealMatrix();

        Assert.Same(realMatrix, matrix._realMatrix);
    }

    // Additional tests for MatrixUtils and RealMatrix classes can be added here
}
*/