using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Testy zostały wygenerowane poza klasą
 */

namespace Math_Graphic.Tests.gemini.alsoWithContext;

public class MatrixTest
{


    [Test]
    public void Constructor_Default_CreatesMatrixWithGivenSize()
    {
        // Arrange
        var expectedSize = 3;

        // Act
        var matrix = new Matrix();

        // Assert
        Assert.AreEqual(expectedSize, matrix.GetWidth());
        Assert.AreEqual(expectedSize, matrix.GetHeight());
    }

    [Test]
    public void Constructor_WithRealMatrix_CreatesMatrixWithGivenValues()
    {
        // Arrange
        var expectedValues = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
    };

        // Act
        var matrix = new Matrix(new RealMatrix(expectedValues));

        // Assert
        Assert.AreEqual(expectedValues, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void CreateIMatrix_CreatesNewMatrixWithGivenValues()
    {
        // Arrange
        var expectedValues = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
    };

        // Act
        var matrix = new Matrix().CreateIMatrix(new RealMatrix(expectedValues));

        // Assert
        Assert.AreEqual(expectedValues, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void CreateIdentityMatrix_CreatesIdentityMatrixWithGivenSize()
    {
        // Arrange
        var expectedSize = 4;

        // Act
        var matrix = new Matrix();
        matrix.CreateIdentityMatrix(expectedSize);

        // Assert
        var actualValues = matrix.GetRealMatrix().GetData();
        for (int i = 0; i < expectedSize; i++)
        {
            for (int j = 0; j < expectedSize; j++)
            {
                if (i == j)
                {
                    Assert.AreEqual(1.0, actualValues[i][j]);
                }
                else
                {
                    Assert.AreEqual(0.0, actualValues[i][j]);
                }
            }
        }
    }

    [Test]
    public void GetMatrixValue_ReturnsCorrectValue()
    {
        // Arrange
        var matrix = new Matrix();
        matrix.SetMatrixValue(1, 2, 7.5);

        // Act
        var value = matrix.GetMatrixValue(1, 2);

        // Assert
        Assert.AreEqual(7.5, value);
    }

    [Test]
    public void SetMatrixValues_SetsMatrixValuesCorrectly()
    {
        // Arrange
        var expectedValues = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
    };

        // Act
        var matrix = new Matrix();
        matrix.SetMatrixValues(expectedValues);

        // Assert
        Assert.AreEqual(expectedValues, matrix.GetRealMatrix().GetData());
    }

}
/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;

[Test]
public void Constructor_Default_CreatesMatrixWithGivenSize()
{
    // Arrange
    var expectedSize = 3;

    // Act
    var matrix = new Matrix();

    // Assert
    Assert.AreEqual(expectedSize, matrix.GetWidth());
    Assert.AreEqual(expectedSize, matrix.GetHeight());
}

[Test]
public void Constructor_WithRealMatrix_CreatesMatrixWithGivenValues()
{
    // Arrange
    var expectedValues = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
    };

    // Act
    var matrix = new Matrix(new RealMatrix(expectedValues));

    // Assert
    Assert.AreEqual(expectedValues, matrix.GetRealMatrix().GetData());
}

[Test]
public void CreateIMatrix_CreatesNewMatrixWithGivenValues()
{
    // Arrange
    var expectedValues = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
    };

    // Act
    var matrix = new Matrix().CreateIMatrix(new RealMatrix(expectedValues));

    // Assert
    Assert.AreEqual(expectedValues, matrix.GetRealMatrix().GetData());
}

[Test]
public void CreateIdentityMatrix_CreatesIdentityMatrixWithGivenSize()
{
    // Arrange
    var expectedSize = 4;

    // Act
    var matrix = new Matrix();
    matrix.CreateIdentityMatrix(expectedSize);

    // Assert
    var actualValues = matrix.GetRealMatrix().GetData();
    for (int i = 0; i < expectedSize; i++)
    {
        for (int j = 0; j < expectedSize; j++)
        {
            if (i == j)
            {
                Assert.AreEqual(1.0, actualValues[i][j]);
            }
            else
            {
                Assert.AreEqual(0.0, actualValues[i][j]);
            }
        }
    }
}

[Test]
public void GetMatrixValue_ReturnsCorrectValue()
{
    // Arrange
    var matrix = new Matrix();
    matrix.SetMatrixValue(1, 2, 7.5);

    // Act
    var value = matrix.GetMatrixValue(1, 2);

    // Assert
    Assert.AreEqual(7.5, value);
}

[Test]
public void SetMatrixValues_SetsMatrixValuesCorrectly()
{
    // Arrange
    var expectedValues = new double[][] {
        new double[] { 1, 2, 3 },
        new double[] { 4, 5, 6 }
    };

    // Act
    var matrix = new Matrix();
    matrix.SetMatrixValues(expectedValues);

    // Assert
    Assert.AreEqual(expectedValues, matrix.GetRealMatrix().GetData());
}
*/