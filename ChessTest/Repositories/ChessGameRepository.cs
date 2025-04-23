
using Microsoft.EntityFrameworkCore;

public class ChessGameRepository : IChessGameRepository
{
    private readonly ChessContext _context;

    public ChessGameRepository(ChessContext context)
    {
        _context = context;
    }

    public void AddGame(ChessGame game)
    {
        _context.Games.Add(game);
    }

    public void UpdateGame(ChessGame game)
    {
        _context.Games.Update(game);
    }

    public ChessGame GetGameById(int id)
    {
        return _context.Games.Include(g => g.Moves).FirstOrDefault(g => g.Id == id);
    }

    public IEnumerable<ChessGame> GetAllGames()
    {
        return  _context.Games.ToList();
    }

    public void DeleteGame(int id)
    {
        var game = _context.Games.Find(id);
        if (game != null)
        {
            _context.Games.Remove(game);
        }
    }
}