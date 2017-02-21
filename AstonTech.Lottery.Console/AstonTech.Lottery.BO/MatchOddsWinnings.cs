using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Lottery
{
    public class MatchOddsWinnings : BaseBO
    {
        //Default constructor with no parameters
        public MatchOddsWinnings()
        {

        }
        public MatchOddsWinnings(int matchOddsWinningId, int gameId)
        {
            this.MatchOddsWinningId = matchOddsWinningId;
            this.GameId = gameId;
        }
        public int MatchOddsWinningId { get; set; }
        public string Match { get; set; }
        public string Odds { get; set; }
        public string Winnings { get; set; }
        public int GameId { get; set; }
    }
}
