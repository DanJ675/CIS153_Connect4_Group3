using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CIS153_Connect4_Group3
{
    class TextFile
    {
        private string fileName = "";
        private char delim = ',';
        

        public List<Player> ReadList()
        {
            StreamReader file = new StreamReader(fileName);
            String line = file.ReadLine();
            List<Player> playerList = new List<Player>();
            int index = 0;

            while (line != null)
            {
                //find first comma
                int[] delimPos = {line.IndexOf(delim), 0, 0, 0, 0,};
                for (int i = 1; i < 6; i++)
                {
                    delimPos[i] = line.IndexOf(delim, delimPos[i - 1]);
                }
                //create new player in list by name
                playerList.Add(new Player(line.Substring(0, delimPos[0])));
                playerList[index].setWins(Int32.Parse(line.Substring(delimPos[0], delimPos[1])));
                index++;
            }
            return playerList;
        }
    }
}
