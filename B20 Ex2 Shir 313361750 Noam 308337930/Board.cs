using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_Ex2_Shir_313361750_Noam_308337930
{
    public class Board
    {
        private int m_Rows;
        private int m_Columns;
        private Card[,] m_Cards;

        public Board(int i_Rows, int i_Columns)
        {
            m_Rows = i_Rows;
            m_Columns = i_Columns;
            m_Cards = new Card[i_Rows, i_Columns];
     
        }

        public void BuildBoard(Card[] i_Cards)
        {
            for(int i=0;i<m_Rows;i++)
            {
                for (int j = 0; j < m_Columns; j++)
                {
                    m_Cards[i, j] = i_Cards[i+j];
                }
            }
        }
        private void ShuffelBoard() 
        {
            Random rng = new Random();

            int row = 0;
            int column = 0;
            int cardsCount = m_Rows * m_Columns;
            int howManyShuffels = rng.Next(cardsCount, cardsCount + 5);
            while (howManyShuffels > 1)
            {
                howManyShuffels--;
                row = rng.Next(m_Rows);
                column = rng.Next(m_Columns);
                SwapCards(ref m_Cards[row, column], ref m_Cards[rng.Next(m_Rows), rng.Next(m_Columns)]);
                
            }
        }

        private bool checkIfSlotIsEmphty(Card i_Card)
        {
            return i_Card.isPlaced();
        }

        public static void SwapCards(ref Card i_CardOne, ref Card i_CardTwo)
        {
            Card temp = i_CardOne;
            i_CardOne.RowNumber = i_CardTwo.RowNumber;
            i_CardOne.ColumnNumber = i_CardTwo.ColumnNumber;
            i_CardTwo.RowNumber = temp.RowNumber;
            i_CardOne.ColumnNumber = temp.ColumnNumber;

        }

    }
}
