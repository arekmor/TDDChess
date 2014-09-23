using System.Linq;
using NUnit.Framework;

namespace TDDChess.Tests
{
    [TestFixture]
    class KingTests
    {
        King Target { get; set; }
        private readonly int DefaultBoardSize = 8;

        [SetUp]
        public void SetUp()
        {
            Target = new King();
        }
        [Test]
        public void GetMovesFrom_Coordinate_2_1_Returns_1_2()
        {
            //arrange
            
            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(2, 1), DefaultBoardSize);
            //assert
            Assert.IsTrue(moves.Any(bc => bc.X == 1 && bc.Y == 2));
        }
        [Test]
        public void GetMovesFrom_Coordinate_2_2_Returns_1_1()
        {
            //arrange
            
            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(2, 2), DefaultBoardSize);
            //assert
            Assert.IsTrue(moves.Any(bc => bc.X == 1 && bc.Y == 1));
        }
        [Test]
        public void GetMovesFrom_Coordinate_3_3_Returns_3_4()
        {
            //arrange
            
            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(3, 3), DefaultBoardSize);
            //assert
            Assert.IsTrue(moves.Any(bc => bc.X == 3 && bc.Y == 4));
        }
        [Test]
        public void GetMovesFrom_Coordinate_3_3_Returns_3_2()
        {
            //arrange

            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(3, 3), DefaultBoardSize);
            //assert
            Assert.IsTrue(moves.Any(bc => bc.X == 3 && bc.Y == 2));
        }
        [Test]
        public void GetMovesFrom_Coordinate_3_3_Returns_2_3()
        {
            //arrange

            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(3, 3), DefaultBoardSize);
            //assert
            Assert.IsTrue(moves.Any(bc => bc.X == 2 && bc.Y == 3));
        }
        [Test]
        public void GetMovesFrom_Coordinate_1_1_DoesNotReturn_0_0()
        {
            //arrange

            //act
            var moves = Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize);
            //assert
            Assert.IsFalse(moves.Any(bc => bc.X == 0 && bc.Y == 0));
        }
    }
}
