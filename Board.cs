using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_C16
{
    class Board
    {
        int m_Rows=0;
        int m_Cols=0;
        int m_TotalSize = 0;
        Cell[,] m_GameBoard;
        public const int m_MaxSizeOfBoard = (m_CharOptionsForCell.Length) * 2; // two of each char
        public const Char[] m_CharOptionsForCell = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                                    'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        
        public int Rows
        {
            get { return m_Rows; }
            set { 
                m_Rows = value;
                m_TotalSize = m_Cols * m_Rows;
                }
        }

        public int Cols
        {
            get { return m_Cols; }
            set { 
                  m_Cols = value;
                  m_TotalSize = m_Cols * m_Rows;
                }
        }

        public Cell[,] GameBoard
        {
            get { return m_GameBoard; }
            set { m_GameBoard = value; }
        }

        public int TotalSize
        {
            get { return m_TotalSize; }
        }
       
    }
}
