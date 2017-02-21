using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.AstonEngineer
{
    public class Employee : Person
    {
        #region CONSTRUCTORS
        //Default constructor with no parameters
        public Employee()
        {
           this.Emails = new EmailAddressCollection();
           this.Category = new EntityType();
           this.TierLevel = new EntityType();
           this.Laptop = new EntityType();
        }

        public Employee(string firstName, string lastName)
        {
            //Reminder: parameters going into methods and connectors should be camelCased!
            this.Emails = new EmailAddressCollection();
            base.FirstName = firstName; //The base. prefix is used because it belongs to the base class (Person)
            base.LastName = lastName;
        }
        public Employee(string firstName, string lastName, DateTime hireDate)
        {
            this.Emails = new EmailAddressCollection();
            base.FirstName = firstName;
            base.LastName = lastName;
            this.HireDate = hireDate;
        }
        #endregion

        #region PROPERTIES
        private int employeeId; //This is the long form for get; set; for EmployeeId
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public int PayRate { get; set; }
        public DateTime DriversLicenseExpireDate { get; set; }
        public DateTime HireDate {get; set; }
        public DateTime TermDate { get; set; }
        public string Background { get; set; }
        public string DriversLicenseNumber { get; set; }

        public EntityType Category { get; set; }
        public EntityType TierLevel { get; set; }
        public EntityType Laptop { get; set; }
        public EmailAddressCollection Emails { get; set; } //We assign the property Email the data type of EmailAddressCollection because an employee is related to multiple emaail addresses

        #endregion

        #region METHODS

        public override string GetFullName()
        {
            if (string.IsNullOrEmpty(base.FirstName) && string.IsNullOrEmpty(base.LastName))
                return "Not Available";
            else
            {
                if (string.IsNullOrEmpty(base.LastName))
                    return base.FirstName + ": EmployeeId = " + this.EmployeeId.ToString();
                else if (string.IsNullOrEmpty(base.FirstName))
                    return base.LastName + ": EmployeeId = " + this.EmployeeId.ToString();
                else
                    return base.FirstName + " " + base.LastName + ": EmployeeId = " + this.EmployeeId.ToString();

            }
        }

        #endregion
    }
}
