public class ChessMove
{
    public int Id { get; set; }
    public string? Move { get; set; } // e.g., "e4", "Nf3"
    public DateTime Timestamp { get; set; }
    public int GameId { get; set; } // Foreign key to ChessGame
}