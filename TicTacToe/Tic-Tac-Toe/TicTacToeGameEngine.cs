using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class TicTacToeGameEngine : ITitTacToeGameEngine
    {
        private GameGrid grid;
        private Player currentlyPlaying;
        private bool gameIsFinished = false;

        public TicTacToeGameEngine()
        {
            grid = new GameGrid();
        }
        public Player GetCurrentlyPlaying()
        {
            return currentlyPlaying;
        }

        public GameGrid GetGrid()
        {
            return grid;
        }

        public Player GetWinner()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public bool IsGameFinished()
        {
            return gameIsFinished;
        }

        public void PlaceTokenInGrid(int row, int col)
        {
            grid.PlaceToken(row, col, currentlyPlaying);
            CheckWinConditions();
        }

        private void CheckWinConditions()
        {
            Player winner = grid.IsThereAWinner();
            if (winner == Player.Nobody && !grid.IsGridFull())
            {
                TogglePlayer();
                return;
            }
            gameIsFinished = true;
        }

        private void TogglePlayer()
        {
            if (currentlyPlaying == Player.Player1)
            {
                currentlyPlaying = Player.Player2;
                return;
            }
            currentlyPlaying = Player.Player1;
        }
    }
}
