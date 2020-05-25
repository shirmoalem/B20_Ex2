using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_Ex2_Shir_313361750_Noam_308337930
{
    public class Card
    {
        bool m_isPlaced;
        bool m_IsFliped;
        char m_Value;
        int m_RowNumber;
        int m_ColumnNumber;

        public Card(int i_RowNumber, int i_ColumnNumber, char i_randomValue)
        {
            m_IsFliped = false;
            m_isPlaced = true;
            m_Value = i_randomValue;
            m_RowNumber = i_RowNumber;
            m_ColumnNumber = i_ColumnNumber;
        }

        public char Value
        {
            get
            {
                return m_Value;
            }
        }

        public int RowNumber
        {
            get
            {
                return m_RowNumber;
            }
            set
            {
                m_RowNumber = value;
            }
        }

        public int ColumnNumber
        {
            get
            {
                return m_ColumnNumber;
            }
            set
            {
                m_ColumnNumber = value;
            }
        }

        private bool isCardFliped()
        {
            return m_IsFliped;
        }
        //get of column and row number get Letter 
        
        private bool haveSameValues(Card i_Card)
        {
            return m_Value == i_Card.m_Value;
        }

        private void flipCard()
        {
            m_IsFliped = m_IsFliped ? false : true;
        }

        public bool isPlaced()
        {
            return m_isPlaced;
        }

        public void swapCards(Card cardTwo)
        {

        }
    }
}
