using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.AstonEngineer
{
    public class EmailAddress : BaseBO
    {

        #region CONSTRUCTOR

        public EmailAddress()
        {
            this.EmailType = new EntityType(); //This is so we don't have to instantiate the property EmailType below
        }

        #endregion CONSTRUCTOR

        #region PROPERTIES

        public int EmailId { get; set; }
        public string EmailValue { get; set; }
        public EntityType EmailType { get; set; } //It has something to do with this instantiating this property seperately

        #endregion
    }
}
