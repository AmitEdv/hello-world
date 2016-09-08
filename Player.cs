using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_C16
{
    class Player
    {
        internal string m_Name;
        internal int m_Score;
        internal bool m_IsHuman;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value;  }
        }

        public int Score
        {
            get { return m_Score; }
            set { m_Score = value; }
        }



    }
}
