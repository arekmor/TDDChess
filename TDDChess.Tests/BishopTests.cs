using System.Linq;
using NUnit.Framework;

namespace TDDChess.Tests
{
    [TestFixture]
    class BishopTests
    {
        private Bishop Target { get; set; }
        private const int DefaultBoardSize = 8;
        [SetUp]
        public void SetUp()
        {
            Target = new Bishop();
        }
        [Test]
        public void GetMovesForm_ValidCoordinate_ReturnsNonEmptyCollection()
        {
            //arrange
            
            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(2, 2), DefaultBoardSize);
            //assert
            Assert.IsTrue(moves.Any());
        }
        [Test]
        public void GetMovesForm_Coordinate_1_1_Returns_2_2()
        {
            //arrange
            
            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize);
            //assert
            Assert.IsTrue(moves.Any(x => x.X == 2 && x.Y == 2));
        }
        [Test]
        public void GetMovesForm_Coordinate_2_2_Returns_1_1()
        {
            //arrange
            
            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(2, 2), DefaultBoardSize);
            //assert
            Assert.IsTrue(moves.Any(x => x.X == 1 && x.Y == 1));
        }
        [Test]
        public void GetMovesForm_Coordinate_1_2_Returns_2_1()
        {
            //arrange

            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(1, 2), DefaultBoardSize);
            //assert
            Assert.IsTrue(moves.Any(x => x.X == 2 && x.Y == 1));
        }
        [Test]
        public void GetMovesForm_ValidCoordinate_ReturnsNonNegativeCoordinates()
        {
            //arrange

            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(1, 2), DefaultBoardSize);
            //assert
            Assert.IsFalse(moves.Any(x => x.X <= 0 || x.Y <= 0));
        }
    }
}
