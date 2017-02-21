using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Lottery
{
    public class WinningNumber : BaseBO
    {
        //Default constructor with no parameters
        public WinningNumber()
        {

        }
        public WinningNumber(int winningNumberId, int winningNum, int ballTypeId, int drawingId)
        {
            this.WinningNumberId = winningNumberId;
            this.WinningNum = winningNum;
            this.BallTypeId = ballTypeId;
            this.DrawingId = drawingId;
        }
        public int WinningNumberId { get; set; }
        public int WinningNum { get; set; } //Refers to column 'WinningNumber' in the entity dbo.WinningNumber
        public int BallTypeId { get; set; }
        public int DrawingId { get; set; }
    }
}
