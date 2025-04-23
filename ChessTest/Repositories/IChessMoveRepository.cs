public interface IChessMoveRepository
{
    void AddMove(ChessMove move);
    void UpdateMove(ChessMove move);
    ChessMove GetMoveById(int id);
    IEnumerable<ChessMove> GetAllMoves();
    void DeleteMove(int id);
}