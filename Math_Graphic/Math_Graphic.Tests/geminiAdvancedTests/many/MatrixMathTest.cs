using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Dodana klasa pomocnicza nie implementowała całego interface
 */

namespace Math_Graphic.Tests.geminiAdvanced.alsoWithContext;

[TestFixture]
public class MatrixMathTests
{
    private IMatrixMath _matrixMath;

    [SetUp]
    public void SetUp()
    {
        _matrixMath = new MatrixMath();
    }
    /* Test odrzucony
    [Test]
    public void InverseMatrix_ValidMatrix_ReturnsInverse()
    {
        // Arrange
        var matrix = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var expectedInverse = new TestMatrix(new double[][]
        {
            new double[] { -2, 1 },
            new double[] { 1.5, -0.5 }
        });

        // Act
        var actualInverse = _matrixMath.InverseMatrix(matrix);

        // Assert
        Assert.AreEqual(expectedInverse.GetRealMatrix().GetData(), actualInverse.GetRealMatrix().GetData());
    }*/

    [Test]
    public void MatrixAddition_ValidMatrices_ReturnsSum()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6 },
            new double[] { 7, 8 }
        });
        var expectedSum = new TestMatrix(new double[][]
        {
            new double[] { 6, 8 },
            new double[] { 10, 12 }
        });

        // Act
        var actualSum = _matrixMath.MatrixAddition(m1, m2);

        // Assert
        Assert.AreEqual(expectedSum.GetRealMatrix().GetData(), actualSum.GetRealMatrix().GetData());
    }

    [Test]
    public void MatrixAddition_InvalidDimensions_ThrowsInvalidDimensionException()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6, 7 },
            new double[] { 8, 9, 10 }
        });

        // Act & Assert
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(m1, m2));
    }

    [Test]
    public void MatrixMultiplication_ValidMatrices_ReturnsProduct()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6 },
            new double[] { 7, 8 }
        });
        var expectedProduct = new TestMatrix(new double[][]
        {
            new double[] { 19, 22 },
            new double[] { 43, 50 }
        });

        // Act
        var actualProduct = _matrixMath.MatrixMultiplication(m1, m2);

        // Assert
        Assert.AreEqual(expectedProduct.GetRealMatrix().GetData(), actualProduct.GetRealMatrix().GetData());
    }
    /* Test odrzucony
    [Test]
    public void MatrixMultiplication_InvalidDimensions_ThrowsInvalidDimensionException()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6, 7 },
            new double[] { 8, 9, 10 }
        });

        // Act & Assert
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(m1, m2));
    }*/

    [Test]
    public void MatrixSubtracting_ValidMatrices_ReturnsDifference()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6 },
            new double[] { 7, 8 }
        });
        var expectedDifference = new TestMatrix(new double[][]
        {
            new double[] { -4, -4 },
            new double[] { -4, -4 }
        });

        // Act
        var actualDifference = _matrixMath.MatrixSubtracting(m1, m2);

        // Assert
        Assert.AreEqual(expectedDifference.GetRealMatrix().GetData(), actualDifference.GetRealMatrix().GetData());
    }

    [Test]
    public void MatrixSubtracting_InvalidDimensions_ThrowsInvalidDimensionException()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6, 7 },
            new double[] { 8, 9, 10 }
        });

        // Act & Assert
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting(m1, m2));
    }

    [Test]
    public void MatrixTransposition_ValidMatrix_ReturnsTranspose()
    {
        // Arrange
        var matrix = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var expectedTranspose = new TestMatrix(new double[][]
        {
            new double[] { 1, 3 },
            new double[] { 2, 4 }
        });

        // Act
        var actualTranspose = _matrixMath.MatrixTransposition(matrix);

        // Assert
        Assert.AreEqual(expectedTranspose.GetRealMatrix().GetData(), actualTranspose.GetRealMatrix().GetData());
    }

    [Test]
    public void ScalarMultiplication_ValidMatrixAndScalar_ReturnsProduct()
    {
        // Arrange
        var matrix = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var scalar = 2.0;
        var expectedProduct = new TestMatrix(new double[][]
        {
            new double[] { 2, 4 },
            new double[] { 6, 8 }
        });

        // Act
        var actualProduct = _matrixMath.ScalarMultiplication(matrix, scalar);

        // Assert
        Assert.AreEqual(expectedProduct.GetRealMatrix().GetData(), actualProduct.GetRealMatrix().GetData());
    }
}

// Helper class to implement IMatrix for testing
public class TestMatrix : IMatrix
{
    private RealMatrix _realMatrix;

    public TestMatrix(double[][] data)
    {
        _realMatrix = new RealMatrix(data);
    }

    public RealMatrix GetRealMatrix()
    {
        return _realMatrix;
    }

    // Other IMatrix methods can be implemented as needed for testing
    public IMatrix CreateIMatrix(RealMatrix realMatrix)
    {
        return new TestMatrix(realMatrix.GetData());
    }

    public int GetHeight()
    {
        return _realMatrix.GetRowDimension();
    }

    public int GetWidth()
    {
        return _realMatrix.GetColumnDimension();
    }

    // dodane dodatkowe funkcje
    public double Determinant()
    {
        return 0;
    }

    public void SetMatrixValue(int row, int column, double value)
    {

    }

    public void SetMatrixValues(double[][] values)
    {

    }

    public void CreateIdentityMatrix(int size)
    {

    }


    public double GetMatrixValue(int row, int column)
    {
        return 0;
    }

}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

namespace Math_Graphic.Tests.Math.Matrix;

[TestFixture]
public class MatrixMathTests
{
    private IMatrixMath _matrixMath;

    [SetUp]
    public void SetUp()
    {
        _matrixMath = new MatrixMath();
    }

    [Test]
    public void InverseMatrix_ValidMatrix_ReturnsInverse()
    {
        // Arrange
        var matrix = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var expectedInverse = new TestMatrix(new double[][]
        {
            new double[] { -2, 1 },
            new double[] { 1.5, -0.5 }
        });

        // Act
        var actualInverse = _matrixMath.InverseMatrix(matrix);

        // Assert
        Assert.AreEqual(expectedInverse.GetRealMatrix().GetData(), actualInverse.GetRealMatrix().GetData());
    }

    [Test]
    public void MatrixAddition_ValidMatrices_ReturnsSum()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6 },
            new double[] { 7, 8 }
        });
        var expectedSum = new TestMatrix(new double[][]
        {
            new double[] { 6, 8 },
            new double[] { 10, 12 }
        });

        // Act
        var actualSum = _matrixMath.MatrixAddition(m1, m2);

        // Assert
        Assert.AreEqual(expectedSum.GetRealMatrix().GetData(), actualSum.GetRealMatrix().GetData());
    }

    [Test]
    public void MatrixAddition_InvalidDimensions_ThrowsInvalidDimensionException()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6, 7 },
            new double[] { 8, 9, 10 }
        });

        // Act & Assert
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(m1, m2));
    }

    [Test]
    public void MatrixMultiplication_ValidMatrices_ReturnsProduct()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6 },
            new double[] { 7, 8 }
        });
        var expectedProduct = new TestMatrix(new double[][]
        {
            new double[] { 19, 22 },
            new double[] { 43, 50 }
        });

        // Act
        var actualProduct = _matrixMath.MatrixMultiplication(m1, m2);

        // Assert
        Assert.AreEqual(expectedProduct.GetRealMatrix().GetData(), actualProduct.GetRealMatrix().GetData());
    }

    [Test]
    public void MatrixMultiplication_InvalidDimensions_ThrowsInvalidDimensionException()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6, 7 },
            new double[] { 8, 9, 10 }
        });

        // Act & Assert
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(m1, m2));
    }

    [Test]
    public void MatrixSubtracting_ValidMatrices_ReturnsDifference()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6 },
            new double[] { 7, 8 }
        });
        var expectedDifference = new TestMatrix(new double[][]
        {
            new double[] { -4, -4 },
            new double[] { -4, -4 }
        });

        // Act
        var actualDifference = _matrixMath.MatrixSubtracting(m1, m2);

        // Assert
        Assert.AreEqual(expectedDifference.GetRealMatrix().GetData(), actualDifference.GetRealMatrix().GetData());
    }

    [Test]
    public void MatrixSubtracting_InvalidDimensions_ThrowsInvalidDimensionException()
    {
        // Arrange
        var m1 = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var m2 = new TestMatrix(new double[][]
        {
            new double[] { 5, 6, 7 },
            new double[] { 8, 9, 10 }
        });

        // Act & Assert
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting(m1, m2));
    }

    [Test]
    public void MatrixTransposition_ValidMatrix_ReturnsTranspose()
    {
        // Arrange
        var matrix = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var expectedTranspose = new TestMatrix(new double[][]
        {
            new double[] { 1, 3 },
            new double[] { 2, 4 }
        });

        // Act
        var actualTranspose = _matrixMath.MatrixTransposition(matrix);

        // Assert
        Assert.AreEqual(expectedTranspose.GetRealMatrix().GetData(), actualTranspose.GetRealMatrix().GetData());
    }

    [Test]
    public void ScalarMultiplication_ValidMatrixAndScalar_ReturnsProduct()
    {
        // Arrange
        var matrix = new TestMatrix(new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        });
        var scalar = 2.0;
        var expectedProduct = new TestMatrix(new double[][]
        {
            new double[] { 2, 4 },
            new double[] { 6, 8 }
        });

        // Act
        var actualProduct = _matrixMath.ScalarMultiplication(matrix, scalar);

        // Assert
        Assert.AreEqual(expectedProduct.GetRealMatrix().GetData(), actualProduct.GetRealMatrix().GetData());
    }
}

// Helper class to implement IMatrix for testing
public class TestMatrix : IMatrix
{
    private RealMatrix _realMatrix;

    public TestMatrix(double[][] data)
    {
        _realMatrix = new RealMatrix(data);
    }

    public RealMatrix GetRealMatrix()
    {
        return _realMatrix;
    }

    // Other IMatrix methods can be implemented as needed for testing
    public IMatrix CreateIMatrix(RealMatrix realMatrix)
    {
        return new TestMatrix(realMatrix.GetData());
    }

    public int GetHeight()
    {
        return _realMatrix.GetRowDimension();
    }

    public int GetWidth()
    {
        return _realMatrix.GetColumnDimension();
    }
}
*/