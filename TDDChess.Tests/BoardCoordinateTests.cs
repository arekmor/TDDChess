using NUnit.Framework;

namespace TDDChess.Tests
{
    [TestFixture]
    class BoardCoordinateTests
    {    
        [Test]
        public void IsCoordinateValidForBoard_Xis0_ReturnsFalse()
        {
            //arrange
            var coordinate = new BoardCoordinate(0, 1);
            //act
            bool result = coordinate.IsCoordinateValidForBoard(8);
            //assert
            Assert.IsFalse(result);
        }
        [Test]
        public void IsCoordinateValidForBoard_Yis0_ReturnsFalse()
        {
            //arrange
            var coordinate = new BoardCoordinate(1, 0);
            //act
            bool result = coordinate.IsCoordinateValidForBoard(8);
            //assert
            Assert.IsFalse(result);
        }
        [Test]
        public void IsCoordinateValidForBoard_XGreaterThanBoardSize_ReturnsFalse()
        {
            //arrange
            var coordinate = new BoardCoordinate(9, 1);
            //act
            bool result = coordinate.IsCoordinateValidForBoard(8);
            //assert
            Assert.IsFalse(result);
        }
        [Test]
        public void IsCoordinateValidForBoard_YGreaterThanBoardSize_ReturnsFalse()
        {
            //arrange
            var coordinate = new BoardCoordinate(1, 9);
            //act
            bool result = coordinate.IsCoordinateValidForBoard(8);
            //assert
            Assert.IsFalse(result);
        }
    }
}
