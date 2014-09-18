using System.Linq;
using NUnit.Framework;

namespace TDDChess.Tests
{
    [TestFixture]
    class PawnTests
    {
        [Test]
        public void GetMovesFrom_PawnAt2_2_OneResultPawnAt2_3()
        {
            //arrange
            var pawn = new Pawn();
            //act
            var possibleMoves = pawn.GetMovesFrom(new BoardCoordinate(2, 2));
            //assert                     
            Assert.IsTrue(possibleMoves.Any(bc => bc.X == 2 && bc.Y == 3));
        }
        [Test]
        public void GetMovesFrom_FirstMoveOfPawnAt2_2_ResultPawnAt2_4()
        {
            //arrange
            var pawn = new Pawn {HasMoved = false};
            //act
            var possibleMoves = pawn.GetMovesFrom(new BoardCoordinate(2, 2));
            //assert                     
            Assert.IsTrue(possibleMoves.Any(bc => bc.X == 2 && bc.Y == 4));
        }
        [Test]
        public void GetMovesFrom_NotFirstMoveOfPawnAt2_2_DoesntResultPawnAt2_4()
        {
            //arrange
            var pawn = new Pawn {HasMoved = true};
            //act
            var possibleMoves = pawn.GetMovesFrom(new BoardCoordinate(2, 2));
            //assert                     
            Assert.IsFalse(possibleMoves.Any(bc => bc.X == 2 && bc.Y == 4));
        }
    }
}
