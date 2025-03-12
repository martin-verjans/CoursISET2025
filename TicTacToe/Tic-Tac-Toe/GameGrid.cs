namespace Tic_Tac_Toe
{
    public class GameGrid
    {
        private Player[,] grid = new Player[3, 3];

        public GameGrid()
        {
            Reset();
        }

        public Player WhoseTokenIsAt(int row, int col)
        {
            return grid[row, col];
        }

        public void Reset()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    grid[row, col] = Player.Nobody;
                }
            }
        }

        public void PlaceToken(int row, int col, Player owner)
        {
            if (grid[row, col] != Player.Nobody)
            {
                throw new System.Exception("Quelqu'un a déja placé un pion ici");
            }
            grid[row, col] = owner;
        }

        public bool IsGridFull()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (grid[row, col] == Player.Nobody)
                        return false;
                }
            }
            return true;
        }

        public Player IsThereAWinner()
        {
            //on vérifie si un des deux joueurs à gagné
            if ((grid[0, 0] == Player.Player1 && grid[0, 1] == Player.Player1 && grid[0, 2] == Player.Player1) || //Horizontales
                (grid[1, 0] == Player.Player1 && grid[1, 1] == Player.Player1 && grid[1, 2] == Player.Player1) ||
                (grid[2, 0] == Player.Player1 && grid[2, 1] == Player.Player1 && grid[2, 2] == Player.Player1) ||
                (grid[0, 0] == Player.Player1 && grid[1, 0] == Player.Player1 && grid[2, 0] == Player.Player1) ||
                (grid[0, 1] == Player.Player1 && grid[1, 1] == Player.Player1 && grid[2, 1] == Player.Player1) ||//Verticales
                (grid[0, 2] == Player.Player1 && grid[1, 2] == Player.Player1 && grid[2, 2] == Player.Player1) ||
                (grid[0, 0] == Player.Player1 && grid[1, 1] == Player.Player1 && grid[2, 2] == Player.Player1) ||//Diagonales
                (grid[0, 2] == Player.Player1 && grid[1, 1] == Player.Player1 && grid[2, 0] == Player.Player1))
            {
                return Player.Player1;
            }
            if ((grid[0, 0] == Player.Player2 && grid[0, 1] == Player.Player2 && grid[0, 2] == Player.Player2) ||
                (grid[1, 0] == Player.Player2 && grid[1, 1] == Player.Player2 && grid[1, 2] == Player.Player2) ||
                (grid[2, 0] == Player.Player2 && grid[2, 1] == Player.Player2 && grid[2, 2] == Player.Player2) ||
                (grid[0, 0] == Player.Player2 && grid[1, 0] == Player.Player2 && grid[2, 0] == Player.Player2) ||
                (grid[0, 1] == Player.Player2 && grid[1, 1] == Player.Player2 && grid[2, 1] == Player.Player2) ||
                (grid[0, 2] == Player.Player2 && grid[1, 2] == Player.Player2 && grid[2, 2] == Player.Player2) ||
                (grid[0, 0] == Player.Player2 && grid[1, 1] == Player.Player2 && grid[2, 2] == Player.Player2) ||
                (grid[0, 2] == Player.Player2 && grid[1, 1] == Player.Player2 && grid[2, 0] == Player.Player2))
            {
                return Player.Player2;
            }
            return Player.Nobody;
        }
    }
}
