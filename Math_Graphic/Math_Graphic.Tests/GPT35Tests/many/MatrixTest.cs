using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * testy nie zostały napisane we frameworku NUnit
 */

namespace Math_Graphic.Tests.GPT35.alsoWithContext
{
    public class MatrixTests
    {/* Test odrzucony
        [Test]
        public void Constructor_InitializesMatrixWithRealMatrix()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equals(realMatrix, matrix.GetRealMatrix());
        }

        [Test]
        public void Constructor_InitializesMatrixWithDefaultMatrix()
        {
            var matrix = new Matrix();
            var expectedMatrix = MatrixUtils.CreateRealMatrix(3, 3);
            Assert.Equals(expectedMatrix.GetData(), matrix.GetRealMatrix().GetData());
        }

        [Test]
        public void CreateIMatrix_CreatesMatrixFromRealMatrix()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 5, 6 }, new double[] { 7, 8 } });
            var matrix = new Matrix().CreateIMatrix(realMatrix);
            Assert.Equals(realMatrix, matrix.GetRealMatrix());
        }

        [Test]
        public void CreateIdentityMatrix_SetsIdentityMatrix()
        {
            var matrix = new Matrix();
            matrix.CreateIdentityMatrix(4);
            var expectedMatrix = MatrixUtils.CreateRealIdentityMatrix(4);
            Assert.Equals(expectedMatrix.GetData(), matrix.GetRealMatrix().GetData());
        }

        [Test]
        public void Determinant_ReturnsCorrectDeterminant()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equals(-2, matrix.Determinant());
        }

        [Test]
        public void GetMatrixValue_ReturnsCorrectValue()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equals(2, matrix.GetMatrixValue(0, 1));
        }

        [Test]
        public void SetMatrixValue_SetsCorrectValue()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            matrix.SetMatrixValue(0, 0, 5);
            Assert.Equals(5, matrix.GetMatrixValue(0, 0));
        }

        [Test]
        public void SetMatrixValues_SetsCorrectValues()
        {
            var newValues = new double[][] { new double[] { 7, 8 }, new double[] { 9, 10 } };
            var matrix = new Matrix();
            matrix.SetMatrixValues(newValues);
            var realMatrix = new RealMatrix(newValues);
            Assert.Equals(realMatrix.GetData(), matrix.GetRealMatrix().GetData());
        }

        [Test]
        public void GetWidth_ReturnsCorrectWidth()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equals(3, matrix.GetWidth());
        }

        [Test]
        public void GetHeight_ReturnsCorrectHeight()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equals(2, matrix.GetHeight());
        }

        [Test]
        public void ToString_ReturnsHtmlTableRepresentation()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            var expected = "<table>\n<tr>\n<td>1.0</td> <td>2.0</td> \n</tr>\n<tr>\n<td>3.0</td> <td>4.0</td> \n</tr>\n</table>";
            Assert.Equals(expected, matrix.ToString());
        }*/
    }
}

/*
using Xunit;
using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;

namespace Math_Graphic.Tests
{
    public class MatrixTests
    {
        [Fact]
        public void Constructor_InitializesMatrixWithRealMatrix()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equal(realMatrix, matrix.GetRealMatrix());
        }

        [Fact]
        public void Constructor_InitializesMatrixWithDefaultMatrix()
        {
            var matrix = new Matrix();
            var expectedMatrix = MatrixUtils.CreateRealMatrix(3, 3);
            Assert.Equal(expectedMatrix.GetData(), matrix.GetRealMatrix().GetData());
        }

        [Fact]
        public void CreateIMatrix_CreatesMatrixFromRealMatrix()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 5, 6 }, new double[] { 7, 8 } });
            var matrix = new Matrix().CreateIMatrix(realMatrix);
            Assert.Equal(realMatrix, matrix.GetRealMatrix());
        }

        [Fact]
        public void CreateIdentityMatrix_SetsIdentityMatrix()
        {
            var matrix = new Matrix();
            matrix.CreateIdentityMatrix(4);
            var expectedMatrix = MatrixUtils.CreateRealIdentityMatrix(4);
            Assert.Equal(expectedMatrix.GetData(), matrix.GetRealMatrix().GetData());
        }

        [Fact]
        public void Determinant_ReturnsCorrectDeterminant()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equal(-2, matrix.Determinant());
        }

        [Fact]
        public void GetMatrixValue_ReturnsCorrectValue()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equal(2, matrix.GetMatrixValue(0, 1));
        }

        [Fact]
        public void SetMatrixValue_SetsCorrectValue()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            matrix.SetMatrixValue(0, 0, 5);
            Assert.Equal(5, matrix.GetMatrixValue(0, 0));
        }

        [Fact]
        public void SetMatrixValues_SetsCorrectValues()
        {
            var newValues = new double[][] { new double[] { 7, 8 }, new double[] { 9, 10 } };
            var matrix = new Matrix();
            matrix.SetMatrixValues(newValues);
            var realMatrix = new RealMatrix(newValues);
            Assert.Equal(realMatrix.GetData(), matrix.GetRealMatrix().GetData());
        }

        [Fact]
        public void GetWidth_ReturnsCorrectWidth()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equal(3, matrix.GetWidth());
        }

        [Fact]
        public void GetHeight_ReturnsCorrectHeight()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } });
            var matrix = new Matrix(realMatrix);
            Assert.Equal(2, matrix.GetHeight());
        }

        [Fact]
        public void ToString_ReturnsHtmlTableRepresentation()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            var expected = "<table>\n<tr>\n<td>1.0</td> <td>2.0</td> \n</tr>\n<tr>\n<td>3.0</td> <td>4.0</td> \n</tr>\n</table>";
            Assert.Equal(expected, matrix.ToString());
        }
    }
}
*/