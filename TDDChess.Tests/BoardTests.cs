using System;
using NUnit.Framework;

namespace TDDChess.Tests
{
    [TestFixture]
    public class BoardTests
    {        
        public Board Target { get; set; }

        [SetUp]
        public void SetUp()
        {            
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
        public void AddPiece_RookAsParameter_NotThrowingException()
        {
            //arrange

            //act
            Target.AddPiece(new Rook(), new BoardCoordinate(2, 1));
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
            Piece pawn = new Pawn();                        
            //act
            Target.AddPiece(pawn, new BoardCoordinate(1, 1));
            //assert
            Assert.AreEqual(pawn, Target.GetPiece(new BoardCoordinate(1, 1)));
        }
    }
}
