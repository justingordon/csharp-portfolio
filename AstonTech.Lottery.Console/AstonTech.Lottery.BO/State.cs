using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Lottery
{
    public class State : BaseBO
    {
        //Default constructor with no parameters
        public State()
        {
            
        }
        public State(int stateId, string stateName)
        {
            this.StateId = stateId;
            this.StateName = stateName;
        }
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}