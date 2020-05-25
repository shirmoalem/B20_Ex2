class GameManager
{
    private bool m_GameOn = false;
    private int m_BoardRow;
    private int m_BoardCol;
    private string m_FirstPlayerName;
    private string m_SecondPlayerName;
    private int m_NumOfPlayers;
    private MemoryGameBoardUI m_BoardUI;
    private MemoryGameBoardLogic m_BoardLogic;
    bool m_AllCardIsFlipped;
    //hash table of players list

    public void StartGame()
    {
        m_GameOn = true;

        while(m_GameOn)
        {
            newGame();
        }

        endGame();
    }

    private void newGame()
    {
        InteractionUser.GetHightOfBoard(ref m_BoardRow);// i think its better like this
        m_BoardCol = InteractionUser.GetWidthOfBoard();
        m_FirstPlayerName = InteractionUser.GetPlayerName();
        m_NumOfPlayers = InteractionUser.GetNumOfPlayers();

        if (m_NumOfPlayers == 2)
        {
            m_SecondPlayerName = InteractionUser.GetPlayerName();
        }

        m_BoardUI = new MemoryGameBoardUI(m_BoardRow, m_BoardCol);
        m_BoardLogic = new MemoryGameBoardLogic(m_BoardRow, m_BoardCol);

        while (m_GameOn || m_AllCardIsFlipped)
        {
            m_BoardUI.PrintBoard(m_BoardLogic.Board);
            //UI:we need to ask for card(valid one), back to game manager- than 
            //we go to lOGIC create the card and build the board.
            //than we go to UI and print the board with the choice
            //again
            //
        }
    }

    private bool isGameOver()
    {
        return false;
    }

    private void endGame()
    {

    }
}

