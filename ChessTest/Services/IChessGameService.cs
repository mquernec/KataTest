public interface IChessGameService
{
    void AddGame(ChessGame game);
    void UpdateGame(ChessGame game);
    ChessGame GetGameById(int id);
    IEnumerable<ChessGame> GetAllGames();
    void DeleteGame(int id);
    bool ValidateMove(string game, string fromFen, string toFen);
}