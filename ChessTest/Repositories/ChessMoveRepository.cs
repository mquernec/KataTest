
public class ChessMoveRepository : IChessMoveRepository
{
    private readonly ChessContext _context;
    public  ChessMoveRepository(ChessContext context)
    {
        _context = context;
    }
    public void AddMove(ChessMove move)
    {
            _context.Moves.Add(move);
    }

    public void DeleteMove(int id)
    {
         var move = _context.Moves.Find(id);
            if (move != null)
            {
                _context.Moves.Remove(move);
            }
    }

    public IEnumerable<ChessMove> GetAllMoves()
    {
      
            return _context.Moves.ToList();
       
    }

    public ChessMove GetMoveById(int id)
    {
       
     return _context.Moves.Find(id);
    }

    public void UpdateMove(ChessMove move)
    {
        var existingMove = _context.Moves.Find(move.Id);
        if (existingMove != null)
        {
            existingMove.Move = move.Move;
            existingMove.Timestamp  = move.Timestamp;
            existingMove.GameId = move.GameId;
        }
    }   

}