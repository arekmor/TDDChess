using System.Linq;
using NUnit.Framework;

namespace TDDChess.Tests
{
    [TestFixture]
    class RookTests
    {
        private Rook Target { get; set; }
        private const int DefaultBoardSize = 8;
        private static readonly BoardCoordinate DefaultBoardCoordinate = new BoardCoordinate(2, 2);

        [SetUp]
        public void SetUp()
        {
            Target = new Rook();
        }
        [Test]
        public void GetMovesFrom_ValidCoordinate_Returns7MovesInColumn()
        {
            //arrange            
            //act
            var moves = Target.GetMovesFrom(DefaultBoardCoordinate, DefaultBoardSize);
            //assert
            Assert.AreEqual(7, moves.Count(x => x.X == 2));
        }
        [Test]
        public void GetMovesFrom_ValidCoordinate_Returns7MovesInRow()
        {
            //arrange            
            //act
            var moves = Target.GetMovesFrom(DefaultBoardCoordinate, DefaultBoardSize);
            //assert
            Assert.AreEqual(7, moves.Count(x => x.Y == 2));
        }
        [Test]
        public void GetMovesFrom_ValidCoordinate_Returns0MovesWithCoordinates0()
        {
            //arrange            
            //act
            var moves = Target.GetMovesFrom(DefaultBoardCoordinate, DefaultBoardSize);
            //assert
            Assert.AreEqual(0, moves.Count(x => x.X == 0 || x.Y == 0));
        }
    }
}
