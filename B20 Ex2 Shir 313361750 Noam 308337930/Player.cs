using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_Ex2_Shir_313361750_Noam_308337930
{
    class Player
    {
        bool m_IsPC;
        string m_Name;
        int m_PlayerNumber;
        int m_Points;

        public Player(bool i_IsPC, string i_PlayerName, int i_PlayerNumber)
        {
            m_IsPC = i_IsPC;
            m_Name = i_PlayerName;
            m_PlayerNumber = i_PlayerNumber;
            m_Points = 0;
        }

        //get name get number get points 
        private bool isPC()
        {
            return m_IsPC;
        }

        private void addPoints(int i_numberOfPoints)
        {
            m_Points += i_numberOfPoints;
        }


    }
}
