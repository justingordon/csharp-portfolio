using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstonTech.AstonEngineer;
using AstonTech.Common;
using AstonTech.Common.Extensions;
using AstonTech.AstonEngineer.DAL;

namespace AstonTech.AstonEngineer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //notes:    call method for examples
            LessonDataAccess();
        }
        private static void LessonDataAccess()
        {
            //Employee lessonEmployee = new Employee();

            //lessonEmployee = EmployeeDAL.GetItem(2);

            //System.Console.WriteLine(lessonEmployee.GetFullName());

            EmployeeCollection empCollection = new EmployeeCollection();

            empCollection = EmployeeDAL.GetCollection();

            foreach (Employee item in empCollection)
            {
                System.Console.WriteLine("ID:" + item.EmployeeId.ToString() + " - " + item.FirstName + " " + item.LastName);
            }
        }
        private static void LessonExtensionMethods()
        {
            //String.ToDate
            string testDateString = "1/1/2000";
            System.Console.WriteLine(testDateString.ToDate().ToLongDateString());

            //String.ToInt
            string testIntValue = "101";
            System.Console.WriteLine(testIntValue.ToInt());
        }
        private static void LessonMethodsParameters()
        {
            Lesson myLesson = new Lesson();
            int mainHomeRunCount = 20; //Set mainHomeRunCount
            int outParameter;

            myLesson.ProcessHomeRunCount(mainHomeRunCount, out outParameter); //Pass mainHomeRunCount to method myLesson.ProcessHomeRunCount, caught value returned from ProcessHomeRunCount and stored it in outParameter.

            System.Console.WriteLine(mainHomeRunCount); //Outputs value for mainHomeRunCount
            System.Console.WriteLine(outParameter); //Outputs value for mainHomeRunCount
        }
        private static void LabValueReferenceTypes()
        {
            //reference type examples
            StringBuilder sbOne = new StringBuilder();
            sbOne.Append("1st value");
            sbOne.Append(", ");
            StringBuilder sbTwo = sbOne;
            sbOne.Append("2nd value");
            System.Console.WriteLine(sbTwo); //OUTPUT: 1st value, 2nd value
            sbOne.Append(", ");
            sbTwo.Append("3rd value");
            System.Console.WriteLine(sbOne); //OUTPUT: 1st value, 2nd value, 3rd value
            System.Console.WriteLine();



            //value type examples
            int firstInt = 1;
            int secondInt = firstInt;
            secondInt += 9;
            System.Console.WriteLine(firstInt); //OUTPUT: 1
            System.Console.WriteLine(secondInt); //OUTPUT: 10
            System.Console.WriteLine();

            bool firstBool = true;
            bool secondBool = firstBool;
            secondBool = false;
            System.Console.WriteLine(firstBool); //OUTPUT: true
            System.Console.WriteLine(secondBool); //OUTPUT: false
            System.Console.WriteLine();


        }
        private static void LessonValueReference()
        {
            //notes:    reference type
            //StringBuilder firstSB = new StringBuilder();
            //firstSB.AppendLine("one");

            //StringBuilder secondSB = firstSB;
            //firstSB.AppendLine("two");

            //notes:    outputing
            //System.Console.WriteLine(secondSB);

            //notes:    value type
            int firstInt = 10;
            int secondInt = firstInt;

            //firstInt += 5;
            firstInt = firstInt + 5;

            System.Console.WriteLine(secondInt);



        }
        private static void LabCreateStaticHelper()
        {
            string stateName = StaticHelperClassLab.GetLastName("Gor");

            System.Console.WriteLine(stateName);
        }
        private static void LessonPolymorphism()
        {
            //notes:    compile time polymorphism - overloaded methods
            //Employee myEmployee = new Employee("Danny", "Simmer");



            //notes:    run-time polymorphism - overriding/override method
            Employee myEmployee = new Employee("Danny", "Simmer");

            System.Console.WriteLine(myEmployee.GetFullName());

        }
        private static void LessonInstanceVsStatic()
        {
            //notes:    instance class.
            Person myPerson = new Person();

            //notes:    static because it doesn't use the 'new' operator. Already allocated to memory
            string stateName = StateHelper.GetStateName("IA");

            System.Console.WriteLine(stateName);
        }
        private static void LessonClassProperties()
        {   
            Employee myEmployee = new Employee();

            myEmployee.Emails = new EmailAddressCollection();

            myEmployee.Emails.Add(new EmailAddress() { EmailValue = "dan@dan.com" });
            myEmployee.Emails.Add(new EmailAddress() { EmailValue = "dan@simmer.com" });
            myEmployee.Emails.Add(new EmailAddress() { EmailValue = "yea@simmer.com" });

            foreach(EmailAddress item in myEmployee.Emails)
            {
                System.Console.WriteLine(item.EmailValue);
            }
        }
        private static void LessonConstructor()
        {
            //Employee employeeDan = new Employee();
            //employeeDan.FirstName = "Justin";
            //employeeDan.LastName = "Dan";

            //System.Console.WriteLine(employeeDan.FirstName + " " + employeeDan.LastName);

            ////notes:    using class constructor
            //Employee employeeJames = new Employee("James", "McRoberts");
            //System.Console.WriteLine(employeeJames.FirstName + " " + employeeJames.LastName);


            ////notes:    using overloaded constructor
            //Employee employeeAdrian = new Employee("Adrian", "Ratnayke", DateTime.Now);
            //System.Console.WriteLine(employeeAdrian.FirstName + " " + employeeAdrian.LastName + " " + employeeAdrian.HireDate.ToShortDateString());

            //notes:    call class method
            Employee employeeMethod = new Employee("Dan", "Jones");
            System.Console.WriteLine(employeeMethod.GetFullName());
        }
        private static void LessonCollections()
        {
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee { FirstName = "Dan", LastName = "Simmer" });
            employeeList.Add(new Employee { FirstName = "James", LastName = "McRoberts" });
            employeeList.Add(new Employee { FirstName = "Adrian", LastName = "Ratnayake" });

            foreach (Employee item in employeeList)
            {
                System.Console.WriteLine(item.FirstName);
            }


            EmployeeCollection employeeCollection = new EmployeeCollection(); //Create object EmployeeCollection

            /* Add values to object */
            employeeCollection.Add(new Employee { FirstName = "Dan C", LastName = "Simmer" });
            employeeCollection.Add(new Employee { FirstName = "James C", LastName = "McRoberts" });
            employeeCollection.Add(new Employee { FirstName = "Adrian C", LastName = "Ratnayake" });

            /* Iterate though collection */
            foreach (Employee item in employeeCollection)
            {
                System.Console.WriteLine(item.FirstName); //Output first name
            }

        }
        private static void LessonInheritance()
        {
            Employee employeeDan = new Employee();

            employeeDan.FirstName = "Danny";
            employeeDan.LastName = "Simmer";

            System.Console.WriteLine(employeeDan.FirstName + " " + employeeDan.LastName);


            Employee employeeAdrian = new Employee();

            employeeAdrian.FirstName = "Adrian";
            employeeAdrian.LastName = "Ratnayake";

            System.Console.WriteLine(employeeAdrian.FirstName + " " + employeeAdrian.LastName);


            Person personAdrian = new Person(); //This example works because we instanciated the person class, and personAdrian now becomes an object. The properties of the Person class are inherited by the Employee class

            personAdrian.FirstName = "Adrian";
            personAdrian.LastName = "Ratnayake";

            System.Console.WriteLine(personAdrian.FirstName + " " + personAdrian.LastName);
        }
        private static void LessonClassObject()
        {
            Person myFirstPerson = new Person();

            myFirstPerson.Id = 99;
            myFirstPerson.FirstName = "Danny";
            myFirstPerson.LastName = "Simmer";

            System.Console.WriteLine(myFirstPerson.Id);
            System.Console.WriteLine(myFirstPerson.FirstName + " " + myFirstPerson.LastName);


            myFirstPerson = new Person();

            myFirstPerson.Id = 100;
            myFirstPerson.FirstName = "Michael";
            myFirstPerson.LastName = "Jones";

            System.Console.WriteLine(myFirstPerson.Id);
            System.Console.WriteLine(myFirstPerson.FirstName + " " + myFirstPerson.LastName);

        }
        private static void LessonExceptions()
        {
            //string firstName = null;
            //firstName = "Danny";

            //try
            //{
            //    int x = int.Parse(firstName);

            //    System.Console.Write("Integer Value: ");
            //    System.Console.WriteLine(x);
            //}
            //catch (ArgumentNullException ex)
            //{ 
            //    System.Console.WriteLine("Exception: " + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    System.Console.WriteLine("Exception: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    System.Console.WriteLine("Exception: " + ex.Message);
            //}
            //finally
            //{
            //    System.Console.WriteLine("Program has completed regardless of exceptions.");
            //}


            string firstName;
            firstName = "Danny";

            try
            {
                int x = int.Parse(firstName);

                System.Console.Write("Integer Value: ");
                System.Console.WriteLine(x);
            }
            catch (Exception ex)
            {
                throw new Exception("Friendly exception message to user of system.", ex);
            }

        }
        private static void LessonFlowControl()
        {
            //notes:    IF statement
            string stringVariable = "danny";

            switch (stringVariable)
            {
                case "fred":
                    System.Console.WriteLine("First name is fred.");
                    break;

                case "dan":
                case "danny":
                    System.Console.WriteLine("Cool first name.");
                    break;

                default:
                    System.Console.WriteLine("Somedefault name.");
                    break;
            }

        }
        private static void LessonOperators() 
        {
            //notes:    mod

            int initialValue = 10;

            System.Console.WriteLine(++initialValue);
            System.Console.WriteLine(++initialValue);
        }
        private static void LessonLists()
        {
            /*
            List<string> myStringCollection = new List<string>();
            myStringCollection.Add("1st string value");
            myStringCollection.Add("2st string value");
            myStringCollection.Add("3st string value");
            myStringCollection.Add("4st string value");
            myStringCollection.Add("5st string value");

            foreach (string stringValue in myStringCollection)
            {
                System.Console.WriteLine(stringValue);
            }
            */

            /*
            List<int> myIntCollection = new List<int>();
            myIntCollection.Add(10);
            myIntCollection.Add(20);
            myIntCollection.Add(30);
            myIntCollection.Add(40);
            myIntCollection.Add(50);

            foreach (int intValue in myIntCollection)
            {
                System.Console.WriteLine(intValue);
            }
            */
            /*
            string[] myStringArray = new string[4];
            myStringArray[0] = "1st";
            myStringArray[1] = "2nd";
            myStringArray[2] = "3rd";
            myStringArray[3] = "4th";
            myStringArray[4] = "5th";

            foreach (string arrayValue in myStringArray)
            {
                System.Console.WriteLine(arrayValue);
            }
            */

            int[] myIntArray = new int[5]; //declares array, set int dataype
	
	        myIntArray[0] = 10;
	        myIntArray[1] = 20;
	        myIntArray[2] = 30;
	        myIntArray[3] = 40;
	        myIntArray[4] = 50;

            foreach (int intValue in myIntArray)
            {
                System.Console.WriteLine(intValue);
            }
        }
        private static void LessonStrings()
        {
            //int myInteger = 99;
            DateTime myDate = DateTime.Now;

            System.Console.WriteLine(myDate.ToString()); //Did I finish this lesson???

        }
        private static void LessonDataTypes()
        {
            bool myBooleanVariable; // default is false
            int myIntValue;         //default is 0
            string myStringValue;   //default is null
            //DateTime myDateTime;    //default is null

            myStringValue = "23";

            myBooleanVariable = int.TryParse(myStringValue, out myIntValue);


            //notes:    output to console
            System.Console.WriteLine(myBooleanVariable);
            System.Console.WriteLine(myIntValue);



        }
        private static void LessonVariables()
        {
            /*
            //notes:    declare variable without setting a value
            string firstName;

            //notes:    declare multiple variables
            string middleName, lastName;

            firstName = "Danny";
            middleName = "Ethan";
            lastName = "Simmer";
            */

            //notes:    declate a variable and set value
            /*
            string firstName = "Dan";
            string middleName = "Ethan", lastName = "Simmer";
            */

            //notes:    output to console
            /*
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(middleName);
            System.Console.WriteLine(lastName);
            */

            //notes:    declare variable without setting a value
            string firstName;

            //notes:    declare multiple variables
            string middleName, lastName;

            firstName = "Default First";
            middleName = "Default Middle";
            lastName = "Default Last";


            System.Console.WriteLine(firstName);
            System.Console.WriteLine(middleName);
            System.Console.WriteLine(lastName);

            firstName = System.Console.ReadLine();
            middleName = System.Console.ReadLine();
            lastName = System.Console.ReadLine();

            System.Console.WriteLine(firstName);
            System.Console.WriteLine(middleName);
            System.Console.WriteLine(lastName);
        }

    }
}
