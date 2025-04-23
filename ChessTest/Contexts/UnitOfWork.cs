public class UnitOfWork: IUnitOfWork
{
    private readonly ChessContext _context;

    public UnitOfWork(ChessContext context)
    {
        _context = context;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}