﻿using NUnit.Framework;

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
            Target.AddPiece(new Pawn(), 2, 1);
            //assert
        }
        [Test]
        public void GetPiece_AddingPieceToUnoccupiedSquare_ReturningAddedPiece()
        {
            //arrange

            //act
            Target.AddPiece(Piece, 1, 1);
            //assert
            Assert.AreEqual(Piece, Target.GetPiece(1, 1));
        }
    }
}