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
    }
}
