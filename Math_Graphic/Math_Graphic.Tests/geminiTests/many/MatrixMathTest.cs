using Math_Graphic.core.math.matrix;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Testy zostały wygenerowane poza klasą
 * testy nie zostały napisane we frameworku NUnit
 * używane są metody wymyślone przez ai
 */

namespace Math_Graphic.Tests.gemini.alsoWithContext;


[TestFixture]
public class MatrixMathTests
{


}


/*
using Math_Graphic.core.math.matrix;

[TestClass]
public class MatrixMathTests
{
    [TestMethod]
    public void InverseMatrix_IdentityMatrix_ReturnsIdentity()
    {
        // Arrange
        var identityMatrix = CreateIdentityMatrix(3);
        var matrixMath = new MatrixMath();

        // Act
        var result = matrixMath.InverseMatrix(identityMatrix);

        // Assert
        Assert.AreEqual(identityMatrix, result);
    }

    [TestMethod]
    public void InverseMatrix_NonSingularMatrix_ReturnsCorrectInverse()
    {
        // Arrange
        var matrix = CreateMatrix(new[,] { { 1, 2 }, { 3, 4 } });
        var expectedInverse = CreateMatrix(new[,] { { -2, 1 }, { 1.5, -0.5 } });
        var matrixMath = new MatrixMath();

        // Act
        var result = matrixMath.InverseMatrix(matrix);

        // Assert
        Assert.AreEqual(expectedInverse, result);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void InverseMatrix_SingularMatrix_ThrowsException()
    {
        // Arrange
        var singularMatrix = CreateMatrix(new[,] { { 1, 2 }, { 2, 4 } });
        var matrixMath = new MatrixMath();

        // Act
        var result = matrixMath.InverseMatrix(singularMatrix);
    }
}
*/