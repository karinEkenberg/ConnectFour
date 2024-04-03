using ConnectFour;
using Xunit;

namespace TestConnectFour.Tests
{
    public class GameStateTest
    {
        private GameState _gameState;

        public GameStateTest() 
        {
            _gameState = new GameState();
        }

        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            //arrange
            _gameState.ResetBoard();

            //act
            var result = _gameState.CheckForWin();

            //assert
            Assert.Equal(GameState.WinState.No_Winner, result);
            Assert.False(_gameState.CheckForWin() != GameState.WinState.No_Winner);
            Assert.True(_gameState.TheBoard.All(cell => cell == 0));
        }

        [Fact]
        public void CheckForWin_TieGame()
        {
            //arrange
            for (int i = 0; i < 42; i++)
            {
                _gameState.TheBoard[i] = i % 2 + 1;
            }

            //act
            var result = _gameState.CheckForWin();

            //assert
            Assert.Equal(GameState.WinState.Tie, result);
            Assert.False(_gameState.CheckForWin() != GameState.WinState.Tie);
            Assert.False(_gameState.CheckForWin() == GameState.WinState.Player1_Wins);
            Assert.False(_gameState.CheckForWin() == GameState.WinState.Player2_Wins);
        }
    }
}