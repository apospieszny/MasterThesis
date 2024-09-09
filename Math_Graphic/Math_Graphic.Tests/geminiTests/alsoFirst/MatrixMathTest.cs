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

namespace Math_Graphic.Tests.gemini.alsoFirst
{
    public class MatrixMathTests
    {/* Test odrzucony
        [Test]
        public void InverseMatrix_ShouldReturnCorrectInverse()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
            var expectedInverse = new RealMatrix(new double[][] { new double[] { -2, 1 }, new double[] { 1.5, -0.5 } });

            // Act
            var actualInverse = new MatrixMath().InverseMatrix((IMatrix) m1);

            // Assert
            Assert.Equals(expectedInverse, actualInverse);
        }

        [Test]
        public void MatrixAddition_ShouldAddMatricesCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
            var m2 = new RealMatrix(new double[][] { new double[] { 5, 6 }, new double[] { 7, 8 } });
            var expectedResult = new RealMatrix(new double[][] { new double[] { 6, 8 }, new double[] { 10, 12 } });

            // Act
            var actualResult = new MatrixMath().MatrixAddition((IMatrix)m1, (IMatrix)m2);

            // Assert
            Assert.Equals(expectedResult, actualResult);
        }

        [Test]
        public void MatrixMultiplication_ShouldMultiplyMatricesCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
            var m2 = new RealMatrix(new double[][] { new double[] { 5, 6 },  new double[] { 7, 8 } });
            var expectedResult = new RealMatrix(new double[][] { new double[] { 19, 22 }, new double[] { 43, 50 } });

            // Act
            var actualResult = new MatrixMath().MatrixMultiplication((IMatrix)m1, (IMatrix)m2);

            // Assert
            Assert.Equals(expectedResult, actualResult);
        }

        [Test]
        public void MatrixSubtracting_ShouldSubtractMatricesCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
            var m2 = new RealMatrix(new double[][] { new double[] { 5, 6 }, new double[] { 7, 8 } });
            var expectedResult = new RealMatrix(new double[][] { new double[] { -4, -4 }, new double[] { -4, -4 } });

            // Act
            var actualResult = new MatrixMath().MatrixSubtracting((IMatrix)m1, (IMatrix)m2);

            // Assert
            Assert.Equals(expectedResult, actualResult);
        }

        [Test]
        public void MatrixTransposition_ShouldTransposeMatrixCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
            var expectedResult = new RealMatrix(new double[][] {new double[] { 1, 3 }, new double[] { 2, 4 } });

            // Act
            var actualResult = new MatrixMath().MatrixTransposition((IMatrix)m1);

            // Assert
            Assert.Equals(expectedResult, actualResult);
        }

        [Test]
        public void ScalarMultiplication_ShouldMultiplyMatrixByScalarCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] {new double[] { 1, 2 }, new double[] { 3, 4 } });
            var scalar = 2.0;
            var expectedResult = new RealMatrix(new double[][] {new double[] { 2, 4 }, new double[] { 6, 8 } });

            // Act
            var actualResult = new MatrixMath().ScalarMultiplication((IMatrix)m1, scalar);

            // Assert
            Assert.Equals(expectedResult, actualResult);
        }*/
    }
}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using Xunit;

namespace Math_Graphic.Tests.Math.Matrix
{
    public class MatrixMathTests
    {
        [Fact]
        public void InverseMatrix_ShouldReturnCorrectInverse()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
            var expectedInverse = new RealMatrix(new double[][] { { -2, 1 }, { 1.5, -0.5 } });

            // Act
            var actualInverse = new MatrixMath().InverseMatrix(m1);

            // Assert
            Assert.Equal(expectedInverse, actualInverse);
        }

        [Fact]
        public void MatrixAddition_ShouldAddMatricesCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
            var m2 = new RealMatrix(new double[][] { { 5, 6 }, { 7, 8 } });
            var expectedResult = new RealMatrix(new double[][] { { 6, 8 }, { 10, 12 } });

            // Act
            var actualResult = new MatrixMath().MatrixAddition(m1, m2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void MatrixMultiplication_ShouldMultiplyMatricesCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
            var m2 = new RealMatrix(new double[][] { { 5, 6 }, { 7, 8 } });
            var expectedResult = new RealMatrix(new double[][] { { 19, 22 }, { 43, 50 } });

            // Act
            var actualResult = new MatrixMath().MatrixMultiplication(m1, m2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void MatrixSubtracting_ShouldSubtractMatricesCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
            var m2 = new RealMatrix(new double[][] { { 5, 6 }, { 7, 8 } });
            var expectedResult = new RealMatrix(new double[][] { { -4, -4 }, { -4, -4 } });

            // Act
            var actualResult = new MatrixMath().MatrixSubtracting(m1, m2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void MatrixTransposition_ShouldTransposeMatrixCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
            var expectedResult = new RealMatrix(new double[][] { { 1, 3 }, { 2, 4 } });

            // Act
            var actualResult = new MatrixMath().MatrixTransposition(m1);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ScalarMultiplication_ShouldMultiplyMatrixByScalarCorrectly()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][] { { 1, 2 }, { 3, 4 } });
            var scalar = 2.0;
            var expectedResult = new RealMatrix(new double[][] { { 2, 4 }, { 6, 8 } });

            // Act
            var actualResult = new MatrixMath().ScalarMultiplication(m1, scalar);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
*/