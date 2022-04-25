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
        private string fileName;
        private char delim;

        public TextFile(string fileName, char delim)
        {
            this.fileName = fileName;
            this.delim = delim;
        }

        public List<Player> ReadList()
        {
            StreamReader file = new StreamReader(fileName);
            String line = file.ReadLine();
            List<Player> playerList = new List<Player>();
            int index = 0;

            while (line != null)
            {
                //find first comma
                int[] delimPos = {line.IndexOf(delim), 0, 0, 0, 0, 0};
                for (int i = 1; i < 6; i++)
                {
                    delimPos[i] = line.IndexOf(delim, delimPos[i - 1] + 1);
                }
                //create new player in list by name
                playerList.Add(new Player(line.Substring(0, delimPos[0])));
                playerList[index].setWins(Int32.Parse(line.Substring(delimPos[0] + 1, 1)));
                playerList[index].setLosses(Int32.Parse(line.Substring(delimPos[1] + 1, 1)));
                playerList[index].setTies(Int32.Parse(line.Substring(delimPos[2] + 1, 1)));
                playerList[index].setWinsVsAi(Int32.Parse(line.Substring(delimPos[3] + 1, 1)));
                playerList[index].setLossesVsAi(Int32.Parse(line.Substring(delimPos[4] + 1, 1)));
                playerList[index].setTiesVsAi(Int32.Parse(line.Substring(delimPos[5] + 1)));
                index++;
                line = file.ReadLine();
            }
            file.Close();
            return playerList;
        }

        public void WriteList(List<Player> playerList)
        {
            //clean text file
            File.WriteAllText(fileName, "");
            //prepare writer
            StreamWriter file = new StreamWriter(fileName);


            foreach (Player p in playerList)
            {
                file.Write(p.getName());
                file.Write(delim);
                file.Write(p.getWins());
                file.Write(delim);
                file.Write(p.getLosses());
                file.Write(delim);
                file.Write(p.getTies());
                file.Write(delim);
                file.Write(p.getWinsVsAi());
                file.Write(delim);
                file.Write(p.getLossesVsAi());
                file.Write(delim);
                file.Write(p.getTiesVsAi());
                file.WriteLine();
            }

            file.Close();

        }
    }
}
