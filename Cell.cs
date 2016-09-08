using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_C16
{
    class Cell
    {
        char m_Character;
        bool m_IsOpen;
        const char m_Space = ' ';

        public char Character
        {
            get { return m_Character; }
            set { m_Character = value; }
        }

        public bool IsOpen
        {
            get { return m_IsOpen; }
            set { m_IsOpen = value; }
        }

        public char getCharToPrint()
        {
            if (m_IsOpen)
            {
                return m_Character;
            }
            else
            {
                return m_Space;
            }
        }
    }
}
