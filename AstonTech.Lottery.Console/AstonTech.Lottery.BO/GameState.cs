using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Lottery
{
    public class GameState : BaseBO
    {
        //Default constructor with no parameters
        public GameState()
        {

        }
        public GameState(int gameStateId, int gameId, int stateId)
        {
            this.GameStateId = gameStateId;
            this.GameId = gameId;
            this.StateId = stateId;
        }
        public int GameStateId { get; set; }
        public int GameId { get; set; }
        public int StateId { get; set; }
    }
}
