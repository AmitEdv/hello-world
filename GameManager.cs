using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_C16
{
    public class GameManager
    {
        List<Player> m_ListOfPlayers;
        const int m_NumOfPlayers = 2;
        static int m_NumOfAutoPlayers=0;
        Board m_MainBoard= new Board();


        //METHODS
       public void runMemoryGame()
        {
            initializePlayers();
            initializeBoard();

        }

        private void initializePlayers()
        {
            m_ListOfPlayers= new List<Player>();
         
            for(int i=0; i < m_NumOfPlayers; i++)
            {
                Player player=new Player();
                if (i==0)
                {
                    player.m_IsHuman=true;
                }
                else
                {
                    player.m_IsHuman=Display.inputIsHumanPlayer();
                }
                
                player.m_Name=getPlayerName(player.m_IsHuman);
                m_ListOfPlayers.Add(player);
            }
        }

        private string getPlayerName(bool i_IsHuman)
        {
            string playerName;

            if (i_IsHuman == true)
            {
                playerName = Display.askForName();
            }
            else
            {
                m_NumOfAutoPlayers++;
                playerName = "Computer" + m_NumOfAutoPlayers.ToString();
            }
            return playerName;
        }
        
        private void initializeBoard ()
        {
            int rows, cols;

            Display.askForBoardSize(out rows, out cols);
            m_MainBoard.Rows = rows;
            m_MainBoard.Cols = cols;
            m_MainBoard.GameBoard = new Cell[rows, cols];
            /*for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    m_mainboard.gameboard[i, j] = new cell();
                    m_mainboard.gameboard[i, j].character = 'a';
                    m_mainboard.gameboard[i, j].isopen = false;
                }
            }*/

            initializeCells();
            Display.printBoard(m_MainBoard);
        }
       
        private void initializeCells()
        {
            int numOfEmptyCellsRemained = m_MainBoard.TotalSize;
            int rowToInsertTheCharTo = 0;
            int colToInsertTheCharTo = 0;
            Random randomTempNum=new Random();

            while (numOfEmptyCellsRemained>0)
            {
                rowToInsertTheCharTo = randomTempNum.Next(0, m_MainBoard.Rows - 1);
                colToInsertTheCharTo = randomTempNum.Next(0, m_MainBoard.Cols - 1);


            }
        }

        

     
    }
}