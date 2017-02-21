using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.AstonEngineer
{
    public class Lesson
    {
        #region METHODS

        public void ProcessHomeRunCount(int homeRunCount, out int returnTotalCount) //Method sets parameter homeRunCount to the same object as mainHomeRunCount (which is passed in)
        {
            homeRunCount += 5; //Adds 5 to homeRunCount
            returnTotalCount = homeRunCount;
        }
        #endregion
    }
}