using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AstonTech.AstonEngineer;
using AstonTech.AstonEngineer.DAL;

namespace AstonTech.AstonEngineer.DAL
{
    public class EmployeeDAL
    {
        #region SELECT
        /// <summary>
        /// Get a single Employee object by passing in the EmployeeId. If not Employee record
        /// found, returns a null Employee object.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public static Employee GetItem(int employeeId) //Returns reference to the class Employee in the BO project. Be sure to reference the BO project in the DAL project and add the reference to the BO namespace with a "using" line at the top of the file.
        {
            Employee tempItem = null;
            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetEmployee", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@EmployeeId", employeeId);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.Read())
                        {
                            tempItem = FillDataRecord(myReader);
                        }
                        myReader.Close();
                    }

                }
                myConnection.Close();
            }
            return tempItem;
        }

        /// <summary>
        /// Get a collection of Employees. If no records to return, EmployeeCollection will be null.
        /// </summary>
        /// <returns></returns>
        public static EmployeeCollection GetCollection()
        {
            EmployeeCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetEmployee", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new EmployeeCollection();
                            while (myReader.Read())
                            {
                                tempList.Add(FillDataRecord(myReader));
                            }
                        }
                        myReader.Close();
                    }
                }
            }
            return tempList;
        }
        #endregion



        #region PRIVATE METHODS
        /// <summary>
        /// Initializes a new instance of the Employee class and fills it with the data from the IDataRecord.
        /// </summary>
        private static Employee FillDataRecord(IDataRecord myDataRecord)
        {
            Employee myObject = new Employee();

            myObject.EmployeeId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("EmployeeId"));
            myObject.PersonId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("PersonId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("PayRate")))
                myObject.PayRate = myDataRecord.GetInt32(myDataRecord.GetOrdinal("PayRate"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("FirstName")))
                myObject.FirstName = myDataRecord.GetString(myDataRecord.GetOrdinal("FirstName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("MiddleName")))
                myObject.MiddleName = myDataRecord.GetString(myDataRecord.GetOrdinal("MiddleName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("LastName")))
                myObject.LastName = myDataRecord.GetString(myDataRecord.GetOrdinal("LastName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("SocialSecurityNumber")))
                myObject.SocialSecurityNumber = myDataRecord.GetString(myDataRecord.GetOrdinal("SocialSecurityNumber"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Background")))
                myObject.Background = myDataRecord.GetString(myDataRecord.GetOrdinal("Background"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("DriversLicenseNumber")))
                myObject.DriversLicenseNumber = myDataRecord.GetString(myDataRecord.GetOrdinal("DriversLicenseNumber"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("BirthDate")))
                myObject.BirthDate = myDataRecord.GetDateTime(myDataRecord.GetOrdinal("BirthDate"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("HireDate")))
                myObject.HireDate = myDataRecord.GetDateTime(myDataRecord.GetOrdinal("HireDate"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("TermDate")))
                myObject.TermDate = myDataRecord.GetDateTime(myDataRecord.GetOrdinal("TermDate"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("DriversLicenseExpireDate")))
                myObject.DriversLicenseExpireDate = myDataRecord.GetDateTime(myDataRecord.GetOrdinal("DriversLicenseExpireDate"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Category_EntityTypeId")))
                myObject.Category = new EntityType { EntityTypeId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("Category_EntityTypeId")) };

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("TierLevel_EntityTypeId")))
                myObject.TierLevel = new EntityType { EntityTypeId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("TierLevel_EntityTypeId")) };

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Laptop_EntityTypeId")))
                myObject.Laptop = new EntityType { EntityTypeId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("Laptop_EntityTypeId")) };

            return myObject;
        }
        #endregion


    }
}
