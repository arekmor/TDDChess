using System;
using NUnit.Framework;

namespace TDDChess.Tests
{
    [TestFixture]
    public class BoardTests
    {
        private Pawn Piece { get; set; }
        public Board Target { get; set; }

        [SetUp]
        public void SetUp()
        {
            Piece = new Pawn();
            Target = new Board();
        }
        [Test]
        public void AddPiece_AddingPieceToUnoccupiedSquare_NotThrowingException()
        {
            //arrange
            
            //act
            Target.AddPiece(new Pawn(), new BoardCoordinate(2, 1));
            //assert
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void AddPiece_AddingPieceWhereXBeyondBoard_ThrowsArgumentException()
        {
            //arrange

            //act
            Target.AddPiece(new Pawn(), new BoardCoordinate(9, 1));
            //assert
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void AddPiece_AddingPieceWhereYBeyondBoard_ThrowsArgumentException()
        {
            //arrange

            //act
            Target.AddPiece(new Pawn(), new BoardCoordinate(1, 9));
            //assert
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void AddPiece_AddingPieceWhereXIs0_ThrowsArgumentException()
        {
            //arrange

            //act
            Target.AddPiece(new Pawn(), new BoardCoordinate(0, 1));
            //assert
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void AddPiece_AddingPieceWhereYIs0_ThrowsArgumentException()
        {
            //arrange

            //act
            Target.AddPiece(new Pawn(), new BoardCoordinate(1, 0));
            //assert
        }
        [Test]
        public void GetPiece_AddingPieceToUnoccupiedSquare_ReturningAddedPiece()
        {
            //arrange

            //act
            Target.AddPiece(Piece, new BoardCoordinate(1, 1));
            //assert
            Assert.AreEqual(Piece, Target.GetPiece(new BoardCoordinate(1, 1)));
        }
    }
}
