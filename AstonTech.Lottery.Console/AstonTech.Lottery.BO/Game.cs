using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Lottery
{
    public class Game : BaseBO
    {
        //Default constructor with no parameters
        public Game()
        {

        }
        public Game(int gameId, string gameName)
        {
            this.GameId = gameId;
            this.GameName = gameName;
        }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public int Cost { get; set; }
        public string HowToPlay { get; set; }
        public string IsSpecial { get; set; }
    }
}
