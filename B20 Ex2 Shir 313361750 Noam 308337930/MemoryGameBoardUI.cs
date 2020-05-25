using System;
using System.Collections;

class MemoryGameBoardUI
{
    private int m_BoardHigh;
    private int m_BoardWidth;

    public MemoryGameBoardUI(int i_HightSize, int i_WidthSize)
    {//c'tor
        m_BoardHigh = i_HightSize;
        m_BoardWidth = i_WidthSize;
    }

    public void PrintBoard(string[,] i_currentLogicBoard)
    {// we need to creat the matrix and than we will write the logic of the game

        for (int j = 0; j < m_BoardWidth; j++)
        {
            int num = (j + 'A');
            char c = Convert.ToChar(num);
            System.Console.Write("  ");
            System.Console.Write(c.ToString());
            System.Console.Write(" ");
        }

        Console.WriteLine();

        for (int j = 0; j < m_BoardWidth; j++)
        {
            System.Console.Write("====");
        }

        Console.WriteLine();

        for (int i = 0; i < m_BoardHigh; i++)
        {
            System.Console.WriteLine("{0} |", i+1);
            for (int j = 0; j < m_BoardWidth; j++)
            {
                System.Console.Write("====");
            }
            Console.WriteLine();
        }
    }
}

