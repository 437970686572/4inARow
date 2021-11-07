using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4inARow
{
    class Board
    {
        private List<List<int>> Stones = new();

        public Board(int lenght, int hight)
        {
            for (int i = 0; i < hight; i++)
            {
                List<int> tmp = new();
                for (int j = 0; j < lenght; j++)
                {
                    tmp.Add(0);
                }
                Stones.Add(tmp);
            }
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < Stones.Count; i++)
            {
                for (int j = 0; j < Stones[i].Count; j++)
                {
                    output += Stones[i][j] + "\t";
                }
                output += "\n";
            }

            return output;
        }

        public bool AddStone(int row, int player)
        {
            for (int i = Stones.Count - 1; i > 0; i--)
            {
                if(Stones[i][row] == 0)
                {
                    Stones[i][row] = player;
                    return true;
                }
            }
            return false;
        }

        public bool CheckForWin()
        {
            return false;
        }
    }
}
