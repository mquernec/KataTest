public interface IChessGameRepository
{
    void AddGame(ChessGame game);
    void UpdateGame(ChessGame game);
    ChessGame GetGameById(int id);
    IEnumerable<ChessGame> GetAllGames();
    void DeleteGame(int id);
}