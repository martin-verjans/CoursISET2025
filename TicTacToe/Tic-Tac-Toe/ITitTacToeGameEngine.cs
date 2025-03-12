namespace Tic_Tac_Toe
{
    public interface ITitTacToeGameEngine
    {
        void Init();
        void PlaceTokenInGrid(int row, int col);
        Player GetCurrentlyPlaying();
        bool IsGameFinished();
        Player GetWinner();
        GameGrid GetGrid();
    }
}
