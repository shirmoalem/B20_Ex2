
public class InteractionUser
{

    public static void GetHightOfBoard(ref int i_size)
    {
       // int boardHight;
       // int i_size;

        System.Console.WriteLine("Please enter the high of the board, between 1 to 6 and than press 'Enter': ");
        string high = System.Console.ReadLine();
        int.TryParse(high, out i_size);

        IsValidSizeOfBoard(i_size);

        ////return boardHight;
    }

    public static int GetWidthOfBoard()
    {
        int boardWidth;

        System.Console.WriteLine("Please enter the width of the board, between 1 to 4 and than press 'Enter': ");
        string width = System.Console.ReadLine();
        int.TryParse(width, out boardWidth);

        IsValidSizeOfBoard(boardWidth);

        return boardWidth;
    }

    private static void IsValidSizeOfBoard(int i_size)
    {
        int size = i_size;

        while (size > 6 || size % 2 != 0 || size == 0)
        {//need to add min 4X4

            System.Console.WriteLine(" Invalid input");

            System.Console.WriteLine("Please number again between 1 to 6 and than press 'Enter': ");
            string size1 = System.Console.ReadLine();
            int.TryParse(size1, out size);
        }
    }

    public static int GetNumOfPlayers()
    {
        int playersNum;
        System.Console.WriteLine("Please write how many players in this game? 1 or 2 and than press 'Enter': ");
        string numOfPlayers = System.Console.ReadLine();
        int.TryParse(numOfPlayers, out playersNum);

        return playersNum;
    }

    public static string GetPlayerName()
    {
        System.Console.WriteLine("Please write your name and than press 'Enter': ");
        string playerName = System.Console.ReadLine();

        return playerName;
    }
}

