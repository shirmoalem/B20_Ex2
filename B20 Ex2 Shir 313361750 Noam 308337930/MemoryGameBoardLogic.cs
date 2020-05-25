using B20_Ex2_Shir_313361750_Noam_308337930;

class MemoryGameBoardLogic
{
    private string[,] m_GameBoard;
    private int m_BoardHight;
    private int m_BoardWidth;
    Player m_PlayerTurn;
    //char[] LettersArray = new char[m_BoardWidth * m_BoardHight / 2] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R' };


    public MemoryGameBoardLogic(int i_HighInput, int i_WidthInput)
    {
        m_BoardHight = i_HighInput;
        m_BoardWidth = i_WidthInput;
        buildGameBoard();
       
    }

    public string[,] Board
    {
        get
        {
            return m_GameBoard;
        }
    }


    private void nextPlayer()
    {

    }

    private void buildGameBoard()
    {
        m_GameBoard = new string[m_BoardHight, m_BoardWidth];
        int howmanyletters = m_BoardWidth * m_BoardHight / 2;
        char[] LettersArray = new char[18] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R' };

    }

    private int howManyPoints()
    {
        return 2;
    }
    
}

