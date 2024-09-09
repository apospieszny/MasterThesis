using NUnit.Framework;
using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT4.first
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Constructor_WithRealMatrix_SetsRealMatrixCorrectly()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);

            Assert.AreEqual(1, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(2, matrix.GetMatrixValue(0, 1));
            Assert.AreEqual(3, matrix.GetMatrixValue(1, 0));
            Assert.AreEqual(4, matrix.GetMatrixValue(1, 1));
        }

        [Test]
        public void Constructor_NoParameters_Creates3x3ZeroMatrix()
        {
            var matrix = new Matrix();
            Assert.AreEqual(0, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(0, matrix.GetMatrixValue(2, 2));
            Assert.AreEqual(3, matrix.GetWidth());
            Assert.AreEqual(3, matrix.GetHeight());
        }

        [Test]
        public void CreateIMatrix_ReturnsNewMatrixInstance()
        {
            var initialMatrix = new RealMatrix(new double[][] { new double[] { 5, 5 }, new double[] { 5, 5 } });
            var matrix = new Matrix(initialMatrix);
            var newMatrix = matrix.CreateIMatrix(new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } }));

            Assert.IsInstanceOf<Matrix>(newMatrix);
            Assert.AreNotSame(matrix, newMatrix);
        }

        [Test]
        public void CreateIdentityMatrix_CreatesProperIdentityMatrix()
        {
            var matrix = new Matrix();
            matrix.CreateIdentityMatrix(2);
            Assert.AreEqual(1, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(0, matrix.GetMatrixValue(0, 1));
            Assert.AreEqual(0, matrix.GetMatrixValue(1, 0));
            Assert.AreEqual(1, matrix.GetMatrixValue(1, 1));
        }

        [Test]
        public void Determinant_ReturnsCorrectDeterminant()
        {
            var matrix = new Matrix(new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } }));
            double det = matrix.Determinant();
            Assert.AreEqual(-2, det);
        }

        [Test]
        public void SetMatrixValue_SetsValueCorrectly()
        {
            var matrix = new Matrix();
            matrix.SetMatrixValue(0, 0, 100);
            Assert.AreEqual(100, matrix.GetMatrixValue(0, 0));
        }

        [Test]
        public void SetMatrixValues_SetsValuesCorrectly()
        {
            var matrix = new Matrix();
            matrix.SetMatrixValues(new double[][] { new double[] { 9, 9 }, new double[] { 8, 8 } });
            Assert.AreEqual(9, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(8, matrix.GetMatrixValue(1, 0));
        }

        [Test]
        public void GetRealMatrix_ReturnsCorrectRealMatrix()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 3, 4 }, new double[] { 5, 6 } });
            var matrix = new Matrix(realMatrix);

            var fetchedMatrix = matrix.GetRealMatrix();
            Assert.AreSame(realMatrix, fetchedMatrix);
        }

        /* Test odrzucony
        [Test]
        public void ToString_ReturnsCorrectHtmlTable()
        {
            var matrix = new Matrix(new RealMatrix(new double[][] { new double[] { 1.5, 2 }, new double[] { 3.1, 4.76 } }));
            var result = matrix.ToString();
            Assert.IsTrue(result.Contains("<table>"));
            Assert.IsTrue(result.Contains("<td>1.5</td>"));
            Assert.IsTrue(result.Contains("<td>4.8</td>")); // Format as F1
        }*/
    }
}

/*
using NUnit.Framework;
using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Constructor_WithRealMatrix_SetsRealMatrixCorrectly()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);

            Assert.AreEqual(1, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(2, matrix.GetMatrixValue(0, 1));
            Assert.AreEqual(3, matrix.GetMatrixValue(1, 0));
            Assert.AreEqual(4, matrix.GetMatrixValue(1, 1));
        }

        [Test]
        public void Constructor_NoParameters_Creates3x3ZeroMatrix()
        {
            var matrix = new Matrix();
            Assert.AreEqual(0, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(0, matrix.GetMatrixValue(2, 2));
            Assert.AreEqual(3, matrix.GetWidth());
            Assert.AreEqual(3, matrix.GetHeight());
        }

        [Test]
        public void CreateIMatrix_ReturnsNewMatrixInstance()
        {
            var initialMatrix = new RealMatrix(new double[][] { new double[] { 5, 5 }, new double[] { 5, 5 } });
            var matrix = new Matrix(initialMatrix);
            var newMatrix = matrix.CreateIMatrix(new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } }));

            Assert.IsInstanceOf<Matrix>(newMatrix);
            Assert.AreNotSame(matrix, newMatrix);
        }

        [Test]
        public void CreateIdentityMatrix_CreatesProperIdentityMatrix()
        {
            var matrix = new Matrix();
            matrix.CreateIdentityMatrix(2);
            Assert.AreEqual(1, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(0, matrix.GetMatrixValue(0, 1));
            Assert.AreEqual(0, matrix.GetMatrixValue(1, 0));
            Assert.AreEqual(1, matrix.GetMatrixValue(1, 1));
        }

        [Test]
        public void Determinant_ReturnsCorrectDeterminant()
        {
            var matrix = new Matrix(new RealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } }));
            double det = matrix.Determinant();
            Assert.AreEqual(-2, det);
        }

        [Test]
        public void SetMatrixValue_SetsValueCorrectly()
        {
            var matrix = new Matrix();
            matrix.SetMatrixValue(0, 0, 100);
            Assert.AreEqual(100, matrix.GetMatrixValue(0, 0));
        }

        [Test]
        public void SetMatrixValues_SetsValuesCorrectly()
        {
            var matrix = new Matrix();
            matrix.SetMatrixValues(new double[][] { new double[] { 9, 9 }, new double[] { 8, 8 } });
            Assert.AreEqual(9, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(8, matrix.GetMatrixValue(1, 0));
        }

        [Test]
        public void GetRealMatrix_ReturnsCorrectRealMatrix()
        {
            var realMatrix = new RealMatrix(new double[][] { new double[] { 3, 4 }, new double[] { 5, 6 } });
            var matrix = new Matrix(realMatrix);

            var fetchedMatrix = matrix.GetRealMatrix();
            Assert.AreSame(realMatrix, fetchedMatrix);
        }

        [Test]
        public void ToString_ReturnsCorrectHtmlTable()
        {
            var matrix = new Matrix(new RealMatrix(new double[][] { new double[] { 1.5, 2 }, new double[] { 3.1, 4.76 } }));
            var result = matrix.ToString();
            Assert.IsTrue(result.Contains("<table>"));
            Assert.IsTrue(result.Contains("<td>1.5</td>"));
            Assert.IsTrue(result.Contains("<td>4.8</td>")); // Format as F1
        }
    }
}
*/