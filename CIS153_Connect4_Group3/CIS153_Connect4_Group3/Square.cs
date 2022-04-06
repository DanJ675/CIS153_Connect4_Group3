//CIS_153_Final Project Connect 4 Group 3 
//Daniel Johnson
//Square Class


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_Connect4_Group3
{
    class Square
    {
        int playerNum = 0;
        public Square() { }
        public int getPlayerNum() { return playerNum; }
        public void setPlayerNum( int i ) { playerNum = i; }

    }
}
