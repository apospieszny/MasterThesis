using NUnit.Framework;
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT35.first
{
    [TestFixture]
    public class MatrixTests
    {
        private Matrix _matrix;
        private RealMatrix _realMatrix;

        [SetUp]
        public void SetUp()
        {
            _realMatrix = new RealMatrix(new[]
            {
                new[] { 1.0, 2.0, 3.0 },
                new[] { 4.0, 5.0, 6.0 },
                new[] { 7.0, 8.0, 9.0 }
            });
            _matrix = new Matrix(_realMatrix);
        }

        [Test]
        public void Constructor_InitializesWithRealMatrix()
        {
            Assert.AreEqual(3, _matrix.GetHeight());
            Assert.AreEqual(3, _matrix.GetWidth());
        }

        [Test]
        public void DefaultConstructor_Creates3x3Matrix()
        {
            var defaultMatrix = new Matrix();
            Assert.AreEqual(3, defaultMatrix.GetHeight());
            Assert.AreEqual(3, defaultMatrix.GetWidth());
        }

        [Test]
        public void CreateIMatrix_CreatesNewMatrixInstance()
        {
            var newMatrix = _matrix.CreateIMatrix(_realMatrix);
            Assert.IsInstanceOf<Matrix>(newMatrix);
        }

        [Test]
        public void CreateIdentityMatrix_SetsIdentityMatrix()
        {
            _matrix.CreateIdentityMatrix(3);
            var expected = new[]
            {
                new[] { 1.0, 0.0, 0.0 },
                new[] { 0.0, 1.0, 0.0 },
                new[] { 0.0, 0.0, 1.0 }
            };
            Assert.AreEqual(expected, _matrix.GetRealMatrix().GetData());
        }
        /* Test odrzucony
        [Test]
        public void Determinant_CalculatesCorrectValue()
        {
            var determinant = _matrix.Determinant();
            Assert.AreEqual(0, determinant);
        }*/

        [Test]
        public void GetMatrixValue_ReturnsCorrectValue()
        {
            var value = _matrix.GetMatrixValue(1, 1);
            Assert.AreEqual(5.0, value);
        }

        [Test]
        public void SetMatrixValue_SetsValueCorrectly()
        {
            _matrix.SetMatrixValue(1, 1, 10.0);
            Assert.AreEqual(10.0, _matrix.GetMatrixValue(1, 1));
        }

        [Test]
        public void SetMatrixValues_SetsMatrixValuesCorrectly()
        {
            var values = new[]
            {
                new[] { 1.0, 2.0, 3.0 },
                new[] { 4.0, 5.0, 6.0 },
                new[] { 7.0, 8.0, 9.0 }
            };
            _matrix.SetMatrixValues(values);
            Assert.AreEqual(values, _matrix.GetRealMatrix().GetData());
        }

        [Test]
        public void GetWidth_ReturnsMatrixWidth()
        {
            Assert.AreEqual(3, _matrix.GetWidth());
        }

        [Test]
        public void GetHeight_ReturnsMatrixHeight()
        {
            Assert.AreEqual(3, _matrix.GetHeight());
        }
        /* Test odrzucony
        [Test]
        public void ToString_ReturnsCorrectHtmlRepresentation()
        {
            var html = _matrix.ToString();
            var expectedHtml = "<table>\n<tr>\n<td>1.0</td> <td>2.0</td> <td>3.0</td> \n</tr>\n<tr>\n<td>4.0</td> <td>5.0</td> <td>6.0</td> \n</tr>\n<tr>\n<td>7.0</td> <td>8.0</td> <td>9.0</td> \n</tr>\n</table>";
            Assert.AreEqual(expectedHtml, html);
        }*/

        [Test]
        public void GetRealMatrix_ReturnsRealMatrix()
        {
            Assert.AreSame(_realMatrix, _matrix.GetRealMatrix());
        }
    }
}

/*
using NUnit.Framework;
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        private Matrix _matrix;
        private RealMatrix _realMatrix;

        [SetUp]
        public void SetUp()
        {
            _realMatrix = new RealMatrix(new[]
            {
                new[] { 1.0, 2.0, 3.0 },
                new[] { 4.0, 5.0, 6.0 },
                new[] { 7.0, 8.0, 9.0 }
            });
            _matrix = new Matrix(_realMatrix);
        }

        [Test]
        public void Constructor_InitializesWithRealMatrix()
        {
            Assert.AreEqual(3, _matrix.GetHeight());
            Assert.AreEqual(3, _matrix.GetWidth());
        }

        [Test]
        public void DefaultConstructor_Creates3x3Matrix()
        {
            var defaultMatrix = new Matrix();
            Assert.AreEqual(3, defaultMatrix.GetHeight());
            Assert.AreEqual(3, defaultMatrix.GetWidth());
        }

        [Test]
        public void CreateIMatrix_CreatesNewMatrixInstance()
        {
            var newMatrix = _matrix.CreateIMatrix(_realMatrix);
            Assert.IsInstanceOf<Matrix>(newMatrix);
        }

        [Test]
        public void CreateIdentityMatrix_SetsIdentityMatrix()
        {
            _matrix.CreateIdentityMatrix(3);
            var expected = new[]
            {
                new[] { 1.0, 0.0, 0.0 },
                new[] { 0.0, 1.0, 0.0 },
                new[] { 0.0, 0.0, 1.0 }
            };
            Assert.AreEqual(expected, _matrix.GetRealMatrix().GetData());
        }

        [Test]
        public void Determinant_CalculatesCorrectValue()
        {
            var determinant = _matrix.Determinant();
            Assert.AreEqual(0, determinant);
        }

        [Test]
        public void GetMatrixValue_ReturnsCorrectValue()
        {
            var value = _matrix.GetMatrixValue(1, 1);
            Assert.AreEqual(5.0, value);
        }

        [Test]
        public void SetMatrixValue_SetsValueCorrectly()
        {
            _matrix.SetMatrixValue(1, 1, 10.0);
            Assert.AreEqual(10.0, _matrix.GetMatrixValue(1, 1));
        }

        [Test]
        public void SetMatrixValues_SetsMatrixValuesCorrectly()
        {
            var values = new[]
            {
                new[] { 1.0, 2.0, 3.0 },
                new[] { 4.0, 5.0, 6.0 },
                new[] { 7.0, 8.0, 9.0 }
            };
            _matrix.SetMatrixValues(values);
            Assert.AreEqual(values, _matrix.GetRealMatrix().GetData());
        }

        [Test]
        public void GetWidth_ReturnsMatrixWidth()
        {
            Assert.AreEqual(3, _matrix.GetWidth());
        }

        [Test]
        public void GetHeight_ReturnsMatrixHeight()
        {
            Assert.AreEqual(3, _matrix.GetHeight());
        }

        [Test]
        public void ToString_ReturnsCorrectHtmlRepresentation()
        {
            var html = _matrix.ToString();
            var expectedHtml = "<table>\n<tr>\n<td>1.0</td> <td>2.0</td> <td>3.0</td> \n</tr>\n<tr>\n<td>4.0</td> <td>5.0</td> <td>6.0</td> \n</tr>\n<tr>\n<td>7.0</td> <td>8.0</td> <td>9.0</td> \n</tr>\n</table>";
            Assert.AreEqual(expectedHtml, html);
        }

        [Test]
        public void GetRealMatrix_ReturnsRealMatrix()
        {
            Assert.AreSame(_realMatrix, _matrix.GetRealMatrix());
        }
    }
}
*/