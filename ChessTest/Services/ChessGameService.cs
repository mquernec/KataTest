public class ChessGameService : IChessGameService
{

    private readonly IChessGameRepository _chessGameRepository;
    public ChessGameService(IChessGameRepository chessGameRepository)
    {
        _chessGameRepository = chessGameRepository;
    }


    public void AddGame(ChessGame game)
    {
        _chessGameRepository.AddGame(game);
    }
    public void UpdateGame(ChessGame game)
    {
        _chessGameRepository.UpdateGame(game);
    }
    public ChessGame GetGameById(int id)
    {
        return _chessGameRepository.GetGameById(id);
    }
    public IEnumerable<ChessGame> GetAllGames()
    {
        return _chessGameRepository.GetAllGames();
    }
    public void DeleteGame(int id)
    {
        _chessGameRepository.DeleteGame(id);

    }
    public bool ValidateMove(string game, string fromFen, string toFen)
    {
        string move = MoveFromFens(fromFen, toFen);
        Console.WriteLine($"Move: {move}");

        // Implement your move validation logic here
        return ValidateMove(move); // Placeholder for actual validation logic
    }
    private bool ValidateMove(string move)
    {
        switch (move.ToUpper()[0])
        {
            case 'P':
                return ValidatePawnMove(move);
            case 'R':
                return ValidateRookMove(move);
            case 'N':
                return ValidateKnightMove(move);
            case 'B':
                return ValidateBishopMove(move);
            case 'Q':
                return ValidateQueenMove(move);
            case 'K':
                return ValidateKingMove(move);
            default:
                throw new ArgumentException("Invalid move type.");
        }
        // Implement your move validation logic here
        return true; // Placeholder for actual validation logic
    }
    private bool ValidatePawnMove(string move)
    {
       return ((move[1]+1 == move[3]) || (move[1] + 2 == move[3])) && (move[2] == move[4]);
        
      
    }
    private bool ValidateRookMove(string move)
    {
        // Implement rook move validation logic here
        return true; // Placeholder for actual validation logic
    }
    private bool ValidateKnightMove(string move)
    {
        // Implement knight move validation logic here
        return true; // Placeholder for actual validation logic
    }
    private bool ValidateBishopMove(string move)
    {
        // Implement bishop move validation logic here
        return true; // Placeholder for actual validation logic
    }
    private bool ValidateQueenMove(string move)
    {
        // Implement queen move validation logic here
        return true; // Placeholder for actual validation logic
    }
    private bool ValidateKingMove(string move)
    {
        // Implement king move validation logic here
        return true; // Placeholder for actual validation logic
    }


    private string MoveFromFens(string fromFen, string toFen)
    {

        var fromMatrix = FenToMatrix(fromFen);
        var toMatrix = FenToMatrix(toFen);
        Console.WriteLine("From Matrix:");
        PrintMatrix(fromMatrix);
        Console.WriteLine("To Matrix:");
        PrintMatrix(toMatrix);
        char piece = ' ';
        var from = "";
        var to = "";
        for (int i = 0; i < fromMatrix.Length; i++)
        {
            for (int j = 0; j < fromMatrix[i].Length; j++)
            {
                if (fromMatrix[i][j] != toMatrix[i][j])
                {
                    var fromState = fromMatrix[i][j];
                    var toState = toMatrix[i][j];
                    if (toState == '.')
                    {
                        piece = fromState;
                        from = $"{ColNumToLetter(j)}{i}";
                    }
                    else
                    {
                        to = $"{ColNumToLetter(j)}{i}";
                    }

                }
            }
        }
        Console.WriteLine($"Piece: {piece}, From: {from}, To: {to}");
        string move = $"{piece}{from}{to}";
        return move;
    }

   private char ColNumToLetter(int colNum)
    {
        // Convert column number to letter (0 -> 'a', 1 -> 'b', ..., 7 -> 'h')
        return (char)('a' + colNum);
    }
    private void PrintMatrix(char[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            Console.WriteLine(string.Join(" ", matrix[i]));
        }
    }
    private char[][] FenToMatrix(string fen)
    {
        var res = new char[8][];

        var liste = fen.Split('/').ToList();
        int i = 0;
        foreach (var row in liste)
        {
            res[i] = FenLineToArray(row);
            i++;
        }
        return res;
    }
    
    private char[] FenLineToArray(string fenLine)
    {

        // Convert a FEN line to a char array
        char[] lineArray = new char[8];
        int index = 0;
        foreach (char c in fenLine)
        {
            if (char.IsDigit(c))
            {
                int emptySpaces = c - '0';
                for (int i = 0; i < emptySpaces; i++)
                {
                    lineArray[index++] = '.'; // Use '.' to represent empty squares
                }
            }
            else
            {
                lineArray[index++] = c;
            }
        }
        return lineArray;
    }
}