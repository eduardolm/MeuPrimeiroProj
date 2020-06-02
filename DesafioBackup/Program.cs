using System;
using System.Collections.Generic;

namespace DesafioBackup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        /*public List<Player> GetBestPlayerEver(int top)
        {
            var tempList = new List<Player>();

            //Creates list of all the players in all the teams
            foreach (Team i in teamList)
            {
                if (i.playerList.Count.Equals(0))
                    return new List<Player>();
                foreach (var j in i.playerList.Where(j => !tempList.Contains(j)))
                {
                    tempList.Add(j);
                }
            }

            var idOut = new List<long>();
            // Creates a list with players Id
            foreach (var tempPlayer in tempList)
            {
                idOut.Add(tempPlayer.SkillLevel);
            }

            return tempList;
        }*/
    }
}