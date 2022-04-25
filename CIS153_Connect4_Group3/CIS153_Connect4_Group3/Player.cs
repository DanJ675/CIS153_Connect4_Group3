//CIS_153_Final Project Connect 4 Group 3 
//Daniel Johnson
//Player Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_Connect4_Group3
{
    class Player
    {
        private string name;
        private int wins;
        private int losses;
        private int ties;
        private int winsVsAi;
        private int lossesVsAi;
        private int tiesVsAi;
        public Player(string name)
        {
            setName(name);
            wins = 0;
            losses = 0;
            ties = 0;
            winsVsAi = 0;
            lossesVsAi = 0;
            tiesVsAi = 0;
        }
        public Player(Player p)
        {
            setName(name);
            wins = 0;
            losses = 0;
            ties = 0;
            winsVsAi = 0;
            lossesVsAi = 0;
            tiesVsAi = 0;
        }
        public Player(string n, int w, int l, int t, int wa, int la, int ta)
        {
            setName(n);
            wins = 0;
            losses = 0;
            ties = 0;
            winsVsAi = 0;
            lossesVsAi = 0;
            tiesVsAi = 0;
        }
        public string outString()
        {
            string outString;

            outString = name + ',' + wins.ToString() + ',' + wins.ToString() + ',' + wins.ToString() + ',' + wins.ToString() + ',' + wins.ToString() + ',' + tiesVsAi.ToString();
            return outString;
        }
        private void setName(string setName) { name = setName; }
        private void setWins(int num) { wins = num; }
        private void setLosses(int num) { losses = num; }
        private void setTies(int num) { ties = num; }
        private void setWinsVsAi(int num) { winsVsAi = num; }
        private void setLossesVsAi(int num) { lossesVsAi = num; }
        private void setTiesVsAi(int num) { tiesVsAi = num; }
        public string getName() { return name; }
        public void addWin() { wins++; }
        public void addLoss() { losses++; }
        public void addTies() { ties++; }
        public void addWinVsAi() { winsVsAi++; }
        public void addLossVsAi() { lossesVsAi++; }
        public void addTieVsAi() { tiesVsAi++; }
        public int getWins() { return wins; }
        public int getLosses() { return losses; }
        public int getTies() { return ties; }
        public int getWinsVsAi() { return winsVsAi; }
        public int getLossesVsAi() { return lossesVsAi; }
        public int getTiesVsAi() { return tiesVsAi; }
    }
}
