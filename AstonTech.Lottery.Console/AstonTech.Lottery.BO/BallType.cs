using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Lottery
{
    public class BallType : BaseBO
    {

        //Default constructor with no parameters
        public BallType()
        {
            
        }
        public BallType(int ballTypeId, string ballName )
        {
            this.BallTypeId = ballTypeId;
            this.BallName = ballName;
        }
        public int BallTypeId { get; set; }
        public string BallName { get; set; }
    }
}