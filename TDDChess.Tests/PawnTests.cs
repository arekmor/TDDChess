using System;
using NUnit.Framework;

namespace TDDChess.Tests
{
    [TestFixture]
    class PawnTests
    {
        [Test]
        public void GetMovesFrom_PawnAt2_2_PawnAt2_3()
        {
            //arrange
            var pawn = new Pawn();
            //act
            Tuple<int, int> possibleMoves = pawn.GetMovesFrom(2, 2);
            //assert
            Assert.AreEqual(2, possibleMoves.Item1);
            Assert.AreEqual(3, possibleMoves.Item2);
        }
    }
}
