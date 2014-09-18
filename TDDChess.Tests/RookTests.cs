using System.Linq;
using NUnit.Framework;

namespace TDDChess.Tests
{
    [TestFixture]
    class RookTests
    {
        public Rook Target { get; set; }
        [SetUp]
        public void SetUp()
        {
            Target = new Rook();
        }
        [Test]
        public void GetMovesFrom_ValidCoordinate_ReturnsEmptyCollection()
        {
            //arrange            
            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(2, 2));
            //assert
            Assert.AreEqual(Enumerable.Empty<BoardCoordinate>(), moves);
        }
    }
}
