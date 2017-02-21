using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Lottery
{
    public class Drawing : BaseBO
    {
        //Default constructor with no parameters
        public Drawing()
        {

        }
        public Drawing(int drawingId, DateTime drawingDate, int gameId)
        {
            this.DrawingId = drawingId;
            this.DrawingDate = drawingDate;
            this.GameId = gameId;
        }
        public int DrawingId { get; set; }
        public DateTime DrawingDate { get; set; }
        public int Jackpot { get; set; }
        public int GameId { get; set; }
    }
}
