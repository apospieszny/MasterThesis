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

public class MatrixMathTests
{/* Test odrzucony
    [Test]
    public void InverseMatrix_ShouldReturnCorrectInverseMatrix()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
        var expectedInverse = new RealMatrix(new double[][] {new double[] { -2, 1 }, new double[] { 1.5, -0.5 } });

        // Act
        var result = new MatrixMath().InverseMatrix((IMatrix)m1);

        // Assert
        Assert.Equals(expectedInverse, result);
    }

    [Test]                
    public void MatrixAddition_ShouldReturnCorrectMatrixAddition()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] {
        new double[] { 1, 2},
        new double[] { 3, 4}
        });
        var m2 = new RealMatrix(new double[][] {new double[] { 5, 6 }, new double[] { 7, 8 } });
        var expectedResult = new RealMatrix(new double[][] {new double[] { 6, 8 }, new double[] { 10, 12 } });

        // Act
        var result = new MatrixMath().MatrixAddition((IMatrix)m1, (IMatrix)m2);

        // Assert
        Assert.Equals(expectedResult, result);
    }

    [Test]
    public void MatrixMultiplication_ShouldReturnCorrectMatrixMultiplication()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
        var m2 = new RealMatrix(new double[][] {new double[] { 5, 6 }, new double[] { 7, 8 } });
        var expectedResult = new RealMatrix(new double[][] {new double[] { 19, 22 }, new double[] { 43, 50 } });

        // Act
        var result = new MatrixMath().MatrixMultiplication((IMatrix)m1, (IMatrix)m2);

        // Assert
        Assert.Equals(expectedResult, result);
    }

    [Test]
    public void MatrixSubtracting_ShouldReturnCorrectMatrixSubtracting()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] {new double[] { 5, 6 }, new double[] { 7, 8 } });
        var m2 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
        var expectedResult = new RealMatrix(new double[][] {new double[] { 4, 4 }, new double[] { 4, 4 } });

        // Act
        var result = new MatrixMath().MatrixSubtracting((IMatrix)m1, (IMatrix)m2);

        // Assert
        Assert.Equals(expectedResult, result);
    }

    [Test]
    public void MatrixTransposition_ShouldReturnCorrectMatrixTransposition()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] {new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } });
        var expectedResult = new RealMatrix(new double[][] { new double[] { 1, 4 }, new double[] { 2, 5 }, new double[] { 3, 6 } });

        // Act
        var result = new MatrixMath().MatrixTransposition((IMatrix)m1);

        // Assert
        Assert.Equals(expectedResult, result);
    }

    [Test]
    public void ScalarMultiplication_ShouldReturnCorrectScalarMultiplication()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
        var scalar = 2.0;
        var expectedResult = new RealMatrix(new double[][] {new double[] { 2, 4 }, new double[] { 6, 8 } });

        // Act
        var result = new MatrixMath().ScalarMultiplication((IMatrix)m1, scalar);

        // Assert
        Assert.Equals(expectedResult, result);
    }*/
}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using Xunit;

namespace Math_Graphic.Tests.core.math.matrix;

public class MatrixMathTests
{
    [Fact]
    public void InverseMatrix_ShouldReturnCorrectInverseMatrix()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
        var expectedInverse = new RealMatrix(new double[][] { { -2, 1 }, { 1.5, -0.5 } });

        // Act
        var result = new MatrixMath().InverseMatrix(m1);

        // Assert
        Assert.Equal(expectedInverse, result);
    }

    [Fact]
    public void MatrixAddition_ShouldReturnCorrectMatrixAddition()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
        var m2 = new RealMatrix(new double[][] { { 5, 6 }, { 7, 8 } });
        var expectedResult = new RealMatrix(new double[][] { { 6, 8 }, { 10, 12 } });

        // Act
        var result = new MatrixMath().MatrixAddition(m1, m2);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void MatrixMultiplication_ShouldReturnCorrectMatrixMultiplication()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
        var m2 = new RealMatrix(new double[][] { { 5, 6 }, { 7, 8 } });
        var expectedResult = new RealMatrix(new double[][] { { 19, 22 }, { 43, 50 } });

        // Act
        var result = new MatrixMath().MatrixMultiplication(m1, m2);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void MatrixSubtracting_ShouldReturnCorrectMatrixSubtracting()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] { { 5, 6 }, { 7, 8 } });
        var m2 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
        var expectedResult = new RealMatrix(new double[][] { { 4, 4 }, { 4, 4 } });

        // Act
        var result = new MatrixMath().MatrixSubtracting(m1, m2);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void MatrixTransposition_ShouldReturnCorrectMatrixTransposition()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] { { 1, 2, 3 }, { 4, 5, 6 } });
        var expectedResult = new RealMatrix(new double[][] { { 1, 4 }, { 2, 5 }, { 3, 6 } });

        // Act
        var result = new MatrixMath().MatrixTransposition(m1);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ScalarMultiplication_ShouldReturnCorrectScalarMultiplication()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
        var scalar = 2.0;
        var expectedResult = new RealMatrix(new double[][] { { 2, 4 }, { 6, 8 } });

        // Act
        var result = new MatrixMath().ScalarMultiplication(m1, scalar);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void MatrixAddition_ShouldThrowInvalidDimensionExceptionForIncompatibleMatrices()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
        var m2 = new RealMatrix(new double[][] { { 5, 6 } });

        // Act
        var action = () => new MatrixMath().MatrixAddition(m1, m2);

        // Assert
        Assert.Throws<InvalidDimensionException>(action);
    }

    [Fact]
    public void MatrixSubtracting_ShouldThrowInvalidDimensionExceptionForIncompatibleMatrices()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
        var m2 = new RealMatrix(new double[][] { { 5, 6 } });

        // Act
        var action = () => new MatrixMath().MatrixSubtracting(m1, m2);

        // Assert
        Assert.Throws<InvalidDimensionException>(action);
    }

    [Fact]
    public void MatrixMultiplication_ShouldThrowInvalidDimensionExceptionForIncompatibleMatrices()
    {
        // Arrange
        var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
        var m2 = new RealMatrix(new double[][] { { 5, 6 } });

        // Act
        var action = () => new MatrixMath().MatrixMultiplication(m1, m2);

        // Assert
        Assert.Throws<InvalidDimensionException>(action);
    }
}
*/