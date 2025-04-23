public class ChessGame
{
    public int Id { get; set; }
    public string Player1 { get; set; }
    public string Player2 { get; set; }
    public IEnumerable<ChessMove> Moves { get; set; } // Store moves in a string format
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}