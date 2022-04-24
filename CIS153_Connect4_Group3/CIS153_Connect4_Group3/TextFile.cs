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


            while (line != null)
            {
                //find first comma
                int comma = line.IndexOf(delim);
            }
            return playerList;
        }
    }
}
