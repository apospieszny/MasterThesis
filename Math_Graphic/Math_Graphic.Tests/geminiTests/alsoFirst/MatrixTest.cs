using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * testy nie zostały napisane we frameworku NUnit
 * Zmiana konwersji w metodach
 * błędnie generowane metody
 */

namespace Math_Graphic.Tests.gemini.alsoFirst;

public class MatrixTests
{/* Test odrzucony
    [Test]
    public void CreateMatrix_ShouldCreateMatrixWithCorrectDimensions()
    {
        // Arrange
        int expectedRows = 3;
        int expectedCols = 3;

        // Act
        Matrix matrix = new Matrix();

        // Assert
        Assert.Equals(expectedRows, matrix.GetHeight());
        Assert.Equals(expectedCols, matrix.GetWidth());
    }

    [Test]
    public void CreateMatrixWithValues_ShouldCreateMatrixWithCorrectValues()
    {
        // Arrange
        double[][] expectedValues = new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 }, new double[] { 7, 8, 9 } };

        // Act
        Matrix matrix = new Matrix(new RealMatrix(expectedValues));

        // Assert
        Assert.Equals(expectedValues, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void CreateIdentityMatrix_ShouldCreateIdentityMatrixWithCorrectValues()
    {
        // Arrange
        int size = 4;
        double[][] expectedValues = new double[][] { new double[] { 1, 0, 0, 0 }, new double[] { 0, 1, 0, 0 }, new double[] { 0, 0, 1, 0 }, new double[] { 0, 0, 0, 1 } };

        // Act
        Matrix matrix = new Matrix();
        matrix.CreateIdentityMatrix(size);

        // Assert
        Assert.Equals(expectedValues, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void Determinant_ShouldCalculateDeterminantCorrectly()
    {
        // Arrange
        double[][] matrixValues = new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 }, new double[] { 7, 8, 9 } };
        double expectedDeterminant = -6;

        // Act
        Matrix matrix = new Matrix(new RealMatrix(matrixValues));
        double actualDeterminant = matrix.Determinant();

        // Assert
        Assert.Equals(expectedDeterminant, actualDeterminant);
    }

    [Test]
    public void GetMatrixValue_ShouldReturnCorrectValue()
    {
        // Arrange
        double[][] matrixValues = new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 }, new double[] { 7, 8, 9 } };
        int row = 1;
        int col = 2;
        double expectedValue = 6;

        // Act
        Matrix matrix = new Matrix(new RealMatrix(matrixValues));         
        double actualValue = matrix.GetMatrixValue(row, col);

        // Assert
        Assert.Equals(expectedValue, actualValue);
    }

    [Test]
    public void SetMatrixValue_ShouldSetCorrectValue()
    {
        // Arrange
        double[][] matrixValues = new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 }, new double[] { 7, 8, 9 } };
        int row = 1;
        int col = 2;
        double newValue = 10;

        // Act
        Matrix matrix = new Matrix(new RealMatrix(matrixValues));
        matrix.SetMatrixValue(row, col, newValue);

        // Assert
        Assert.Equals(newValue, matrix.GetMatrixValue(row, col));
    }

    [Test]
    public void SetMatrixValues_ShouldSetCorrectValues()
    {
        // Arrange
        double[][] newValues = new double[][] { new double[] { 10, 20, 30 }, new double[] { 40, 50, 60 }, new double[] { 70, 80, 90 } };

        // Act
        Matrix matrix = new Matrix();
        matrix.SetMatrixValues(newValues);

        // Assert
        Assert.Equals(newValues, matrix.GetRealMatrix().GetData());
    }

    [Test]  
    public void ToString_ShouldReturnCorrectStringRepresentation()
    {
        // Arrange
        double[][] matrixValues = new double[][] { new double[] { 1.1, 2.2, 3.3 }, new double[] { 4.4, 5.5, 6.6 }, new double[] { 7.7, 8.8, 9.9 } };
        string expectedString = "<table>\n<tr>\n<td>1.1</td> <td>2.2</td> <td>3.3</td> \n</tr>\n<tr>\n<td>4.4</td> <td>5.5</td> <td>6.6</td> \n</tr>\n<tr>\n<td>7.7</td> <td>8.8</td> <td>9.9</td> \n</tr>\n</table>";

        // Act
        Matrix matrix = new Matrix(new RealMatrix(matrixValues));
        string actualString = matrix.ToString();

        // Assert
        Assert.Equals(expectedString, actualString);
    }

    [Test]
    public void GetRealMatrix_ShouldReturnCorrectRealMatrix()
    {
        // Arrange
        double[][] matrixValues = new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 }, new double[] { 7, 8, 9 } };

        // Act
        Matrix matrix = new Matrix(new RealMatrix(matrixValues));
        RealMatrix actualRealMatrix = matrix.GetRealMatrix();

        // Assert
        Assert.Equals(matrixValues, actualRealMatrix.GetData());
    }

    */
}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using Xunit;

namespace Math_Graphic.core.math.tests;

public class MatrixTests
{
    [Fact]
    public void CreateMatrix_ShouldCreateMatrixWithCorrectDimensions()
    {
        // Arrange
        int expectedRows = 3;
        int expectedCols = 3;

        // Act
        Matrix matrix = new Matrix();

        // Assert
        Assert.Equal(expectedRows, matrix.GetHeight());
        Assert.Equal(expectedCols, matrix.GetWidth());
    }

    [Fact]
    public void CreateMatrixWithValues_ShouldCreateMatrixWithCorrectValues()
    {
        // Arrange
        double[][] expectedValues = new double[][] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        // Act
        Matrix matrix = new Matrix(expectedValues);

        // Assert
        Assert.Equal(expectedValues, matrix.GetRealMatrix().GetData());
    }

    [Fact]
    public void CreateIdentityMatrix_ShouldCreateIdentityMatrixWithCorrectValues()
    {
        // Arrange
        int size = 4;
        double[][] expectedValues = new double[][] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };

        // Act
        Matrix matrix = new Matrix();
        matrix.CreateIdentityMatrix(size);

        // Assert
        Assert.Equal(expectedValues, matrix.GetRealMatrix().GetData());
    }

    [Fact]
    public void Determinant_ShouldCalculateDeterminantCorrectly()
    {
        // Arrange
        double[][] matrixValues = new double[][] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double expectedDeterminant = -6;

        // Act
        Matrix matrix = new Matrix(matrixValues);
        double actualDeterminant = matrix.Determinant();

        // Assert
        Assert.Equal(expectedDeterminant, actualDeterminant);
    }

    [Fact]
    public void GetMatrixValue_ShouldReturnCorrectValue()
    {
        // Arrange
        double[][] matrixValues = new double[][] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int row = 1;
        int col = 2;
        double expectedValue = 6;

        // Act
        Matrix matrix = new Matrix(matrixValues);
        double actualValue = matrix.GetMatrixValue(row, col);

        // Assert
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void SetMatrixValue_ShouldSetCorrectValue()
    {
        // Arrange
        double[][] matrixValues = new double[][] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int row = 1;
        int col = 2;
        double newValue = 10;

        // Act
        Matrix matrix = new Matrix(matrixValues);
        matrix.SetMatrixValue(row, col, newValue);

        // Assert
        Assert.Equal(newValue, matrix.GetMatrixValue(row, col));
    }

    [Fact]
    public void SetMatrixValues_ShouldSetCorrectValues()
    {
        // Arrange
        double[][] newValues = new double[][] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };

        // Act
        Matrix matrix = new Matrix();
        matrix.SetMatrixValues(newValues);

        // Assert
        Assert.Equal(newValues, matrix.GetRealMatrix().GetData());
    }

    [Fact]
    public void ToString_ShouldReturnCorrectStringRepresentation()
    {
        // Arrange
        double[][] matrixValues = new double[][] { { 1.1, 2.2, 3.3 }, { 4.4, 5.5, 6.6 }, { 7.7, 8.8, 9.9 } };
        string expectedString = "<table>\n<tr>\n<td>1.1</td> <td>2.2</td> <td>3.3</td> \n</tr>\n<tr>\n<td>4.4</td> <td>5.5</td> <td>6.6</td> \n</tr>\n<tr>\n<td>7.7</td> <td>8.8</td> <td>9.9</td> \n</tr>\n</table>";

        // Act
        Matrix matrix = new Matrix(matrixValues);
        string actualString = matrix.ToString();

        // Assert
        Assert.Equal(expectedString, actualString);
    }

    [Fact]
    public void GetRealMatrix_ShouldReturnCorrectRealMatrix()
    {
        // Arrange
        double[][] matrixValues = new double[][] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        // Act
        Matrix matrix = new Matrix(matrixValues);
        RealMatrix actualRealMatrix = matrix.GetRealMatrix();

        // Assert
        Assert.Equal(matrixValues, actualRealMatrix.GetData());
    }

    // Add tests for MatrixUtils methods here
}
*/