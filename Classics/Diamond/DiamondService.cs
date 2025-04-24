public static class DiamondService
{
    public static void PrintDiamond(char c)
    {
        Console.Write(BuildDiamond(c));
    }
    public static string BuildDiamond(char c)
    {
        string diamond = string.Empty;
        int n = c - 'A' + 1; // Calculate the number of rows based on the character
        int width = 2 * n - 1; // Calculate the width of the diamond
        int mid = n - 1; // Middle index for the diamond
        string backdiamond = string.Empty;
        for (int i = 0; i < n; i++)
        {  
            string crtline = string.Empty;
            // Calculate the number of spaces before the character
            int spacesBefore = mid - i;
            crtline += new string(' ', spacesBefore);
            // Add the character
            crtline += (char)('A' + i);
            // Add spaces between characters
            if (i > 0)
            {
                int spacesBetween = 2 * i - 1;
                crtline += new string(' ', spacesBetween);
                crtline += (char)('A' + i);
            }

            crtline += new string(' ', spacesBefore);
            // Move to the next line
            if(i != (n-1))
             backdiamond = crtline + Environment.NewLine+backdiamond;
            diamond +=crtline+ Environment.NewLine;
        }
        // Add the bottom half of the diamond
        return diamond +backdiamond;  
    }
}