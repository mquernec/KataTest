
using Microsoft.EntityFrameworkCore;

    public class ChessContext : DbContext
    {
        ChessContext(DbContextOptions<ChessContext> options) : base(options)
        {
        }
        public ChessContext()
        {
        }
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ChessDb");
        }
        public DbSet<ChessGame> Games { get; set; }
        public DbSet<ChessMove> Moves { get; set; }
    }
