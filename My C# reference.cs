
/* ********** VARIABLES ********** */

//Declare variable without setting a value

	datatype variableName;
	
	string firstName;

//Declare multiple variables

	string middleName, lastName;

	firstName = "Danny";
	middleName = "Ethan";
	lastName = "Simmer";


//Declate a variable and set value
	
	string firstName = "Dan";
	string middleName = "Ethan", lastName = "Simmer";

//Output to console

	System.Console.WriteLine(firstName);
	System.Console.WriteLine(middleName);
	System.Console.WriteLine(lastName);

	
//System Input - This reads what is typed in and assigns it to a specific variable

	firstName = System.Console.ReadLine();
	middleName = System.Console.ReadLine();	
	lastName = System.Console.ReadLine();	
	
//Scope - Variables only exist in the specific method (codeblock) in which they were declared. 


/* ********** C# Types ********** */

//There are 2 types in the .NET framework

	//Value Types - Stored in the variable itself. (stack)
	//Reference Types - Stored in the heap. Variable has a pointer to that value in the memory.


//Primative Types - Primatives - Map  directly to types that exist in the base class library. Primative types are a value type.

	//Primatives are very efficient, very fast. They take up smaller amounts of memory and they don't require garbage collection because they don't use pointers.

	int x = 2;
	//the 'int' above is an alias that points to 'System.Int32'. That is a base class, a primitive.

	System.Int32 y = new Int32();
	y = 3;

	
	//Boolean Primitave - 'bool' is mapped to System.Boolean
	bool isTrue = false;

	isTrue = true;

	System.Boolean anotherBooleanValue = new System.Boolean();



//Example with a few C# data types

	bool myBooleanVariable; //default is false
	int myIntValue;         //default is 0
	string myStringValue;   //default is null
	DateTime myDateTime;    //default is null

	myBooleanVariable = true;
	myIntValue = 1;
	myStringValue = "Danny";
	myDateTime = DateTime.Now;

	System.Console.WriteLine(myBooleanVariable);
	System.Console.WriteLine(myIntValue);
	System.Console.WriteLine(myStringValue);
	System.Console.WriteLine(myDateTime);


	
	
//Short Circit
/*
For a short circuit to happen a conditional statement must use an AND or OR operator. When the conditional statement is being evaluated, if the first condition is true, the code in the body of the if statements is executed rather than evaluating the second condition in the conditional statement.
*/


int myInt = 2;

if (myInt = 2 && myInt > 0) //Short circuited because myInt > 0 isn't evaluated because myInt = 2 is true

     System.Console.WriteLine("You win 2 billion dollars");

else

     System.Console.WriteLine("You're going to die");
	 


//Parsing with Parse and TryParse - Used to convert String to Int

	//Parse Example
	
		int myIntValue;         //default is 0
		string myStringValue;   //default is null

		myStringValue = "99a";

		myIntValue = int.Parse(myStringValue);	//Parses (analyzes) myStringValue and assign it to myIntValue
		System.Console.WriteLine(myIntValue);	//Output to console
	
		//Since myStringValue contains a number and a character, it will throw the error "Unhandled Exception: Input string was not a correct format"

	//TryParse Example
	
		bool myBooleanVariable
		int myIntValue;
		string myStringValue;

		myStringValue = "99a";
		
		//TypeParse has built in exception handling. It tries to parse myStringVariable. It returns a boolean value (and assigns it to myBooleanVariable). If it's true, it will output the converted value of myStringValue as myIntValue.
		myBooleanVariable = int.TryParse(myStringValue, out myIntValue);

		System.Console.WriteLine(myIntValue); //Output to console
	

/* ********** STRINGS ********** */

//All 3 of these examples set string as an empty string (nothing). Use only first two.

	String myFristString = "";
	string myString = string.Empty;
	
	System.String myOtherString = new System.String();

//Strings are immutable (can't be changed). When changing the value of myString, the backend of .Net automatically creates a new object and allocates new memory for myString and sets it to the new value.

	for (int x = 0; x <= 100; x++) //Iterates though the loop
		{
			myString = "new value: " + x.ToString();
			System.Console.WriteLine(myString);
		}

//This loops through and assigns a new value to myString on each loop. This isn't very efficient. .NET has a class called StringBuilder to help with this (below).

	string myString = "This is a test string";

	StringBuilder myStringBuilder = new StringBuilder(); //Instantiates a new StringBuilder class/object in memory
		
	for (int x = 0; x <= 100; x++) //Iterates though the loop, but appends the one object in memory.
	{
		myStringBuilder.AppendLine("new value with string builder: " + x.ToString());
		System.Console.WriteLine(myString);
	}

	System.Console.WriteLine(myStringBuilder.ToString());

		
/* Searching Strings ******** */

//All indexes start with 0 and are counted from the front (ltr)

//IndexOf - Returns the index (placement) of where the first 's' is located.
	
	string myString = "This is a test string";
	int indexOf = myString.IndexOf("s");
	System.Console.WriteLine(indexOf.ToString());

//LastIndexOf - Returns the index of where the first 's' is located when searching from the back. 
	
	string myString = "This is a test string";
	int lastIndexOf = myString.LastIndexOf("s");
	System.Console.WriteLine(lastIndexOf.ToString());
	
//Substring Method - A build in method used to read certain characters or sections of a string

	string myString = "This is a test string";
	System.Console.WriteLine(myString.Substring(5, 2)); //This starts at the index of 5 and goes 2 characters. It writes "is" to the console.

//How-to enumerate a string (Break up into individual characters)
	string myString = "This is a test string";

	foreach(char myChar in myString)
	{
		System.Console.WriteLine(myChar);
	}
	

//ToString Method
//Converts one data type to a string so search methods can be used against it

	//Converts Int to String
	Int myInteger = 99;
	System.Console.WriteLine(myInteger.ToString());
	
	
	//Converts DateTime to String
	DateTime myDate = DateTime.Now;
	System.Console.WriteLine(myDate.ToString());

	
/* ********** COLLECTIONS AND ARRAYS ********** */

/* Collections ********** */

//Collection Structure
	//No need to specify how big the collection needs to be (unlike Arrays)
	List<datatype> myCollection = new List<datatype>(); //Creates a list/collection of items
	myCollection.Add(value); //adds items to the list
	myCollection.Add(value);
	myCollection.Add(value);

	foreach (datatype collectionValue in myCollection) //Iterates through the collection
	{
		System.Console.WriteLine(collectionValue); //Outputs values of the collection
	}

//Collection Example
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


/* Arrays ********** */
	
//Structure
	datatype[] myArrayName = new datatype[# of values in array] //Declares an array, sets datatype, sets array length
	myArrayName[index] = value; //adds values to the array
	myArrayName[index] = value;
	myArrayName[index] = value;
	
	foreach (datatype arrayValue in myArrayName) //Iterates through the collection
	{
		System.Console.WriteLine(arrayValue); //Outputs values of the array
	}
	
//Example 1
	string[] myStringArray = new string[4]; 
	myStringArray[0] = "1st";
	myStringArray[1] = "2nd";
	myStringArray[2] = "3rd";
	myStringArray[3] = "4th";

	foreach (string arrayValue in myStringArray) //Iterates through the collection
	{
		System.Console.WriteLine(arrayValue); //Outputs arrayValue
	}

	
/* Flow Control ********** */
	
//IF Statement
	string stringVariable = "danny";

	if (stringVariable.ToUpper() == "DANNY")
	{
		System.Console.WriteLine("Correct first name");
		System.Console.WriteLine("First Name " + stringVariable);

		if (stringVariable.Length > 5)
		{
			System.Console.WriteLine("Long first name");
		}
		else
			System.Console.WriteLine("Short first name");
	}
	else
		System.Console.WriteLine("Incorrect first name");
	
	
	
	
//Switch statement
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
		
	
	
/* Exceptions ************ */

//Unhandled Exception - An unhanded exception is an error in the program that isn't caught by a try block and catch clauses. An unhandled exception causes the program to crash.


	string firstName = null;
	firstName = "Danny";

	try
	{
		/* creates an error */
		int x = int.Parse(firstName);

		System.Console.Write("Integer Value: ");
		System.Console.WriteLine(x);
	}
	/* Catches the type error, outputs the type to 'ex', and writes the system message for that error to the screen. */
	catch (ArgumentNullException ex)
	{
		System.Console.WriteLine("Exception: " + ex.Message);
	}
	catch (FormatException ex)
	{
		System.Console.WriteLine("Exception: " + ex.Message);
	}
	catch (Exception ex)
	{
		System.Console.WriteLine("Exception: " + ex.Message);
	}
	finally //This code executes after the try block and catch clauses
	{
		System.Console.WriteLine("Program has completed regardless of exceptions.");
	}
	
	
// This type of exception handling  is used to pass exceptions to an application
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
	
	
	
	
/* ********** OBJECTS & CLASSES ********** */
/*
/* A class is a blueprint which you use to create objects. An object is an instance of a class - it's a concrete 'thing' that you made using a specific class. So, 'object' and 'instance' are the same thing, but the word 'instance' indicates the relationship of an object to its class.

This is easy to understand if you look at an example. For example, suppose you have a class House. Your own house is an object and is an instance of class House. Your sister's house is another object (another instance of class House).
*/

// Class House describes what a house is
class House {
    // ...
}

// You can use class House to create objects (instances of class House)
House myHouse = new House();
House sistersHouse = new House();

/*
The class House describes the concept of what a house is, and there are specific, concrete houses which are objects and instances of class House.
*/

	class Person : BaseBO

/*
CLASS - It encapsulates the characteristics, properties, and methods of objects. If a class shows the code above, it means Person inherets from BaseBO. BaseBO is the base class (superclass), and Person is the subclass

OBJECT - An object is basically a block of memory that has been allocated and configured according to the blueprint. A program may create many objects of the same class. Objects are also called instances, and they can be stored in either a named variable or in an array or collection.
*/

	Person myFirstPerson = new Person();

//A class becomes an object when we use it, when it becomes instantiated (assigned memory). Above, the object myFirstPerson is the instance of the class Person. We now have access to all the properties of the object.

	
/*	
Console project references BO Project, which gives us access to the Person class and BaseBO class. We have access to the Person class because we made it public and we're referencing it in the references library. In the program, we're using the namespace AstonTech.AstonEngineer by adding the using statement at the top (and because it's already referenced).

Since the class Person was instantiated, we now have access to all the properties that it inhereted from BaseBO
*/

	Person myFirstPerson = new Person();

	myFirstPerson.Id = 99; //From BaseBO
	myFirstPerson.FirstName = "Danny"; //Referenced from object Person
	myFirstPerson.LastName = "Simmer"; //Referenced from object Person

	
//How to create a base class library and base classes
/*
1.	In the solution explorer, right click on the solution for your projects (it's at the top).
2.	Choose "Add" and select "New Project".
3.	Select class library and name it with proper naming conventions.
4.	Remove the default class setup with the new project.
5.	In the solution explorer, right click on the menu "References"
6.	Choose "Add reference" and then select tab for Solutions > Projects
7.	In the solution explorer, right click on the main heading for the class library project you just created.
8.	Choose new class and name it BaseBO
9.	Remove .BO from the namespace of the new class (I'm not sure why, but it will make sense later...or so I'm told)
10.	Make it a public class by adding "public" before the class name. (e.g. public class Base80)
11.	Create a Id property in the BaseBO class to be used by all subclasses. See the example below:
*/

	public int Id ( get; set; )

/*
12. Now we need to create a new class for each database entity we are modeling the class structure after. In the solution explorer, right click on the .BO project and go to "Add"
13.	Choose new class
14.	Name it after the entity from the database you are modeling your class structure after.
15.	Remove .BO from the namespace of the new class
16.	We now need to make the class public and set it up to inherit from the BaseBO. This is done by putting "public" before the class name, and ": Base BO" after the class name. See the example below:
*/

	public class Person : BaseBO //Person is the class we're working on, and we're setting it to inherit from BaseBO
	
/*
17.	You now need to create the properties based on the entity you modeled the class after. Properties use PascalCase for the naming convention. Use the code below as a template:
*/

	public string Title { get; set; }
	public string FirstName { get; set; }

/*
18.	Since we referenced the class library project from the project with our program, we can now use it by adding the namespace we setup for class library project. To do this, add the code a new update statement to the end of the other using statements and include the namespace of the class library that was setup. Use the example below for reference:
*/

	using AstonTech.AstonEngineer;

/*
19.	We can now create a new method to test some of our newly created objects. Use the example below for reference:
*/
	private static void LessonClassObject()
	{
		
	}

/*
20.	Call the method in the "Main" method.
*/
	LessonClassObject();

/*
22.	Instantiate the class to make it an object. Once it's an object the CRL engine (common language runtime) associates memory for it. This is similar to setting a variable. See the example below:
*/

	Person myFirstPerson = new Person();
	
/*
21.	We now have access to all the properties of that object. Let's add some values to the object and test them with WriteLine statements. See the example below:	
*/

	myFirstPerson.Id = 99;
	myFirstPerson.FirstName = "Danny";
	myFirstPerson.LastName = "Simmer";

	System.Console.WriteLine(myFirstPerson.Id);
	System.Console.WriteLine(myFirstPerson.FirstName + " " + myFirstPerson.LastName);

	
		
/* ********* INHERITANCE ********* */
/*
Inheritance is where one class (child class) inherits the members of another class (parent class).

The benefit of inheritance is that the child class doesn't have to redeclare and redefine all the members which it inherits from the parent class. It is therefore a way to re-use code. 

Inheritance also enables you to write generic code which applies to all classes in an inheritance hierarchy. You can do this because you know that all child classes must contain the same members as the parent class.
*/



/* ********** PROPERTIES ********** */
/*
Properties allow you to control the accessibility of a classes variables, and is the recommended way to access variables from the outside. Get and Set methods allow the property to be read and written to. If we wish to limit the one ability or another, we can remove it from the code as the example below shows.

NOTE  - All properties should be PascalCase
*/

	public string FirstName { get; } //Only reads FirstName. It can't be written to.

//There is an old school form of writing Get/Set that must be used in older versions of .NET (.NET 1.0 - 2.0). Below is how you would write the long form Get/Set

	private int employeeId; //Must start as private

	public int EmployeeId
	{
		get { return employeeId; }
		set { employeeId = value; }
	}

	
/* ********** COLLECTIONS ********** */

//List vs. Collection (according to Microsoft)
//Collection should be used for application facing/customer facing code.
//List should be used for internal processing, away from the customer/application facing code (only used in the backend).


//This creates a collection of the type <Employee> (using the short format for creating lists)
	List<Employee> employeeList = new List<Employee>();

	employeeList.Add(new Employee { FirstName = "Dan", LastName = "Simmer" });
	employeeList.Add(new Employee { FirstName = "James", LastName = "McRoberts" });
	employeeList.Add(new Employee { FirstName = "Adrian", LastName = "Ratnayake" });

	foreach (Employee item in employeeList)
	{
		System.Console.WriteLine(item.FirstName);
	}

// A better way is to create a class just for the collection itself. The steps below will explain how to do that:
/*
01.	Create a new folder called Collections by right clicking "Add" in the solution explorer and going to "New Folder"
02.	Name the new folder "Collection"
04. Name the class "CollectionClass".
05.	Add the line of code below to the end of the using this code: 
*/
	using System.Collections.ObjectModel; //This is used because this is where the class Collection resides

/*
06.	Remove the default code block for class CollectionClass
07.	Add the code for the Collection class. This will be a container for our collection, in this case employees. See code below:
*/

	public class EmployeeCollection : Collection<Employee> { }

/*
08. Moving back to the program, we now need to create the object, add values, and iterate thought it. We do that with the block of code below:
*/

	EmployeeCollection employeeCollection = new EmployeeCollection(); //Create object employeeCollection by instantiating it
	
	//EmployeeCollection = class name
	//employeeCollection = instance/variable/object name
	  

	/* Add values to object */
	employeeCollection.Add(new Employee { FirstName = "Dan C", LastName = "Simmer" });
	employeeCollection.Add(new Employee { FirstName = "James C", LastName = "McRoberts" });
	employeeCollection.Add(new Employee { FirstName = "Adrian C", LastName = "Ratnayake" });

	/* Iterate though collection */
	foreach (Employee item in employeeCollection)
	{
		System.Console.WriteLine(item.FirstName); //Output first name
	}
	
/*
09. We then create a collection object for every object with exception to BaseBO. First we will need to add an additional class to the CollectionClass container. Use the code below as a template:
*/

	public class PersonCollection : Collection<Person> { }	

/*
10. Once that is added we can instantiate the object, add values, and iterate through them like we did in step 8
*/





/* ********** CONSTRUCTORS ********** */
/*
Constructor - A special type of method that has the same name of the class. It is the method that runs when you instantiate a class (when it turns into an object). Constructors usually initialize the data members of the new object.

In general, it's considered good practice to have a constructor require the parameters needed in order to completely setup an object, so that it's impossible to create an object in an invalid state. One way is to expose just a single constructor which requires those mandatory properties as parameters.

In that case, you cannot create your object without specifying those mandatory properties. Something like that cannot be enforced by object initializers.
*/


public class Employee : Person
    {
	//Default constructor with no parameters
	public Employee()
	{

	}

	public Employee(string firstName, string lastName) //Overloaded constructor using the paremeters for firstName and lastName from the base (parent) class
	{
		//Reminder: parameters going into methods and connectors should be camelCased!
		base.FirstName = firstName; //The base. prefix is used because it belongs to the base class (Person)
		base.LastName = lastName;
	}
}


/* ********** CUSTOM CLASS PROPERTIES ********** */
 
//01. Add a new class and name it EntityType.
//02. Add it to the same namespace as the other classes (remove .BO)
//03. Make it public and set it to inherit from BaseBO

	public class EntityType : BaseBO
	{
		
	}

//04. Setup properties for EntityType (column names and get; set;)

	public class EntityType : BaseBO
	{
		public int EntityTypeId { get; set; }
		public string EntityTypeValue { get; set; }
	}
	
//05. Group the code with region tags

	public class EntityType : BaseBO
	{
		#region PROPERTIES
		public int EntityTypeId { get; set; }
		public string EntityTypeValue { get; set; }
		#endregion PROPERTIES
	}

//06. Create constructors for EntityType and group in region tags

	public class EntityType : BaseBO
	{
		#region Constructors
			EntityType() { }
			EntityType(string entityTypeValue) //Passing in the parameter entityTypeValue
			{
				this.EntityTypeValue = entityTypeValue; //When instanciating, it will set the property EntityTypeValue with the value of entityTypeValue.
			}
			EntityType(int entityTypeId, string entityTypeValue)
			{
				this.EntityTypeId = entityTypeId;
				this.EntityTypeValue = entityTypeValue;
			}
		#endregion CONSTRUCTORS
				
		
		#region PROPERTIES
		public int EntityTypeId { get; set; }
		public string EntityTypeValue { get; set; }
		#endregion PROPERTIES
	}

//07. Create collection for EntityType in the CollectionClass container. 

	public class EntityTypeCollection : Collection<EntityType> //EntityTypeCollection inherets from the Collection<EntityType>

	
/* Setup custom properties where the type of property is a custom class */
//01. Create class named Email Address
//02. Add it to the same namespace as the other classes (remove .BO)
//03. Make it public and set it to inherit from BaseBO
//04. Setup regions and properties for the EmailAddress entity

	public class EmailAddress : BaseBO ()
	{
		#region PROPERTIES
		public int EmailId { get; set; }
		public string EmailValue { get; set; }
		public EntityType EmailType { get; set; } //The property EmailType can use the data type "EntityType" because we created the class EntityType.
		#endregion PROPERTIES
	}

	
// ******** How do we model the 1 to 1 relation ship between the email address and email type (EntityType)? ********

//We can then connect the EmailType column to EntityType.

//05. Setup region tags and constructor for EmailAddress. Now we have EntityType as a property for the class EmailAddress.

	public class EmailAddress : BaseBO ()
	{
		#region CONSTRUCTORS
		public EmailAddress()
		{
			this.EmailType = new EntityType(); //This is so we don't have to instantiate the property EmailType seperately. It's instantiated any time we create a new email address.
		}
		#endregion CONSTRUCTORS
		
		#region PROPERTIES
		public int EmailId { get; set; }
		public string EmailValue { get; set; }
		public EntityType EmailType { get; set; }
		#endregion PROPERTIES
	}

//06. Setup collection for type EmailAddress

	public class EmailAddressCollection : Collection<EmailAddress> { }

	
/* Setup 1 to many relationship where an employee is related to multiple email addresses. */
//Our employee is associated to multiple email addresses, so we can model the employee similar to the way we modeled EmailAddress that was Associated to EntityTypeId. It differs this time, because an employee can have multiple email addresses. Instead of using the email address as a single type of property. Since we created the collection EmailAddressCollection class, we can set the type to be that collection.


//01. Create property Emails for the class Employee and assign it the data type of EmailAddressCollection.

	public class Employee : Person
	{
		#region CONSTRUCTORS
		public Employee()
		{
			this.Emails = new EmailAddressCollection();
		}

		public Employee(string firstName, string lastName)
		{
			base.FirstName = firstName;
			base.LastName = lastName;
		}
		public Employee(string firstName, string lastName, DateTime hireDate)
		{
			base.FirstName = firstName;
			base.LastName = lastName;
			this.HireDate = hireDate;
		}
		#endregion CONSTRUCTORS

		#region PROPERTIES
		public int EmployeeId { get; set; }
		public DateTime HireDate {get; set; }
		public DateTime TermDate { get; set; }
		public EmailAddressCollection Emails { get; set; } //We assign the property Email the data type of EmailAddressCollection because an employee is related to multiple emaail addresses
		#endregion PROPERTIES
	}


//We associated an employee with multiple email addresses, we called the property Emails, and we added the get; and set; methods. We first had to create our email address [class??], along with a property named EmailType with an EntityType type. We added an EntityType class before [that] and added everything to a collection class. Finally in the Employee class, we have a property called EmailAddressCollection. Our constructor in Employee, just like our constructor in EmailAddress, we instantiate the EmailType...well, in the Employee [class] before we can use this property we must instantiate the EmailAddress, so

/* **** ALL CODE BELOW THIS POINT MUST BE ADDED **** */
	
	this.Emails = new EmailAddressCollection();
	
//In our console app, let's go ahead and....showcase some of this (creates call and method below in Program.cs) (11:45 in video)

	LessonClassProperties();

	private static void LessonClassProperties()
	{
		Employee myEmployee = new Employee();
	}

//Going back to our constructor, of why we instantiated new EmailAddress[Collection], because if we instanciated

	Employee my Employee = new Employee();
	
//So at this time, when new Employee(); gets called, it calls this constructor:

	this.Emails = new EmailAddressCollection(); //Already added to code
	
//so at this point, the property Emails of class Employee is instanciated to a new [Email]Address Collection. It means that

	myEmployee.Emails.Add(new EmailAddress{ EmailValue="dan@dan.com" ); //A property we can just add to it
	
//So what I did, I instanciated a new Employee, because I called this constructor (below)

	this.Emails = EmailAddressCollection();
	
//the Emails property is now instanciated with a new EmailAddressCollection, and that way we can go ahead and say this specific instance of this employee and his emails, we can go ahead and add. Let's write a foreach...

	myEmployee.Emails.Add(new EmailAddress { EmailValue = "dan@dan.com"});
	myEmployee.Emails.Add(new EmailAddress { EmailValue = "dan@simmer.com"});
	
	foreach(EmailAddress item in myEmployee.Emails)
	{
		System.Console.WriteLine(item.EmailValue); //Iterate over all email addresses and output it to the screen
	}
	
//It iterates over out EmailCollection property and outputs it to the screen.
//Quick thing, let's go back to Employee. It iterates over out EmailCollection property of Employee and outputs it to the screen.

//Now one quick thing. Let's go back to employee and say we didn't include this in our constructor...where the Emails property is already instanciated with the property EmailAddressCollection



/* ********** INSTANCE VS STATIC ********** */

//notes:    Instance class.
Person myPerson = new Person();

//notes:    static 
string stateName = StateHelper.GetStateName("IA");

/*
STATIC CLASSES
• Doesn't use the 'new' operator to instantiate the class, just called the class name and then the method name. Only one instance of a static class.
• It gets loaded into memory when we use it and we don't have to worry about garbage collection (releasing the memory). As soon as we're dont using it, it's gone. 
• No inheretance/class heiarchy. Static classes can't inheret from other classes, because it isn't allowed, it's static.
• Useful for creating helper methods/classes to get a certain function done.


INSTANCE CLASSES
• Must be created and instantiated (loaded into memory). Uses the new operator to instantiate the class

• When instantiated, it must be disposed of at some point (which is done automatically?), but for the most part we still have to dispose of it.

• Able to use inheretance
*/




/* ********** POLYMORPHISM ********** */

//Compile time polymorphism
/*
Compile time polymorphism is when methods are overloaded

An example of method overloading can be seen with the constructors/methods in the class Employee. The constructors have 3 signatures: a base with no parameters, a constructor with 2 parameters, and a constructor with 3 parameters. The constructor/method name is all the same, but the method signature is different.


//Run-time polymorphism
When a method from the base class is overridden from the subclass (at run-time).

When the keyword 'virtual' is used in a method of a parent/base class, it indicates to the child/subclass, you should override the method (although it's not required).

The subclass must use the keyword 'override' in the method to indicate we're overriding the method in the base class.

*/

/* ********** VALUE REFERENCE TYPE ********** */
/*
REFERENCE TYPES
A reference type is a type which has as its value a reference to the appropriate data rather than the data itself.

Data Types: String, arrays, Class types, interface types, delegate types
*/

	StringBuilder first = new StringBuilder();
	first.Append("hello");
	StringBuilder second = first;
	first.Append(" world");
	Console.WriteLine(second); // Prints hello world

	//They are independent variables themselves. Changing the value of first to refer to a completely different object (or indeed changing the value to a null reference) doesn't affect second at all, or the object it refers to

/*
VALUE TYPES
While reference types have a layer of indirection between the variable and the real data, value types don't. Variables of a value type directly contain the data. Assignment of a value type involves the actual data being copied.

Data Types: All numeric data types, Boolean, Char, Date, Enumerations, all struct types.
*/

	public struct IntHolder
	{
		public int i;
	}

	IntHolder first = new IntHolder();
	first.i = 5;
	IntHolder second = first;
	first.i = 6;
	Console.WriteLine (second.i); 

/* Here, second.i has the value 5, because that's the value first.i has when the assignment second = first occurs - the values in second are independent of the values in first apart from when the assignment takes place. 


IMMUTABLE Types
Many types (such as string) appear in some ways to be a value type, but are in fact reference types. These are immutable types, meaning that once an instance has been created, it can't be changed. immutable reference types act LIKE value types, they are NOT value types. This is why, for instance, the string. Replace doesn't change the string it is called on, but returns a new instance with the new string data in.


MUTABLE TYPES
Mutable types are changeable, such as ArrayList. If a method returns the ArrayList reference stored in an instance variable, the calling code could add items to the list without the instance having any say about it, which is usually a problem.



THE 4 PARAMETER TYPES
Value parameters (default), reference parameters (ref modifier), output parameters (out modifier), and parameter arrays(params modified). Any of them can be used with both Value and reference types.
*/


/* ********** METHODS PARAMETERS ********** */
/*
																Parameter name
																  (outgoing)
		Return value			Parameter    	 Return value(s)      |
	   (single value)			data type	 	(multiple allowed)    |
			|						 |				  |				  |
		  |----|				   |---|			 |--|	  |--------------|
*/	
	public void ProcessHomeRunCount(int homeRunCount, out int returnTotalCount) { }
/*
	|-----|		|-----------------|		|-----------|	 |---|
	   |				|					  |			   |
	Accessor		Method name			Parameter name	   |
										(incoming)		Parameter
														data type
			 
Methods are used to group code into logical sections. If we group our code into methods that perform specific functions or operations, we can code more efficiently. It makes our code reusable rather than having to create a wheel everytime a wheel is needed. Methods are also dynamic and powerful because we can pass parameters into them and return specific data as well.

ACCESSOR TYPES
• public - anything that instantiates the parent class has access to the methods within it.
• private - only open to classes code contained in the same class as the method
• protected - the class the contains the method has access to it (like private), but it's also available to any class that inherits it's containing class.


RETURN VALUE
void - indicates that this method returns no single value. One (or more) values can still be returned by the keyword 'out' in the method's parameters.
out - used to indicate that the method has one (or more) return parameters.


Value Type Parameter - When the value is passed in, it creates a new space in memory for that value (just like other value types).
When a reference type is needed instead, we can change the data type with the ref keyword before the datatype of both the outgoing variable name and and incoming parameter name.


/* ********** EXTENSION METHODS ********** */

//Extension methiods allow you to add new methods to existing types without using derived types. See the examples below:

	//String.ToDate
	string testDateString = "1/1/2000";
	System.Console.WriteLine(testDateString.ToDate().ToLongDateString());

	//String.ToInt
	string testIntValue = "101";
	System.Console.WriteLine(testIntValue.ToInt());

/*
CREATING EXTENSION Methods

01.	Create a new folder named "Extensions" under the AstonTech.Common project
02. Add a new class named "Extensions.cs" to the folder
03.	Keep the namespace as AstonTech.Common.Extensions
04. Change update the class to be: public static class Extensions
05.	Create your extensions
06. Add summary tags above the class declaration by typing ///
07. Add a summary to the tags so that Intellisense display the summary info to help other developers using your extensions
08.	Use the formatting example below to start writing the extension.
09.	The "this" keyword has to be the first parameter in the extension method parameter list so it can be recognized as an extension.


						 Data type			 Extends this
						 returned			  data type
							 |					 |
                          |------|			  |-----|
*/
			public static DateTime ToDate(this string s) { }
/*
								   |-----|			 |-|
									  |				  |
								  Extension		Return Variable
								 Method Name


*/


/* ********** Data Access Layer (DAL) Setup ********** */			

/* Database User Setup ********* */

//Create a new user

//Define access level

//Configure access to stored procedures


/* Setup DAL connection to DB ********* */
/*
01. Create DAL project. Use standard naming convention (e.g. AstonTech.AstonEngineer.DAL)
02. Create class in the DAL project named "AppConfiguraton.cs"
03. Copy everything over from an existing appconfiguraton.cs file to the new file
04. update the namespace on the copied over version to reflect the current project (e.g astontech.astonengineer.dal). everything else in the file is good to go.
05. In the .Console project, open the file "App.config"
06. Copy everything over from an existing App.config file to the new file
07. Update the values for keys below. Use the following details for reference:

AstonEngineerLotteryApp - The name of the connection string, name it something similar for the new project and be sure to update both instances of the default name.

Data Source=MNLT003 - This is the server name. it will likely be the same

Initial Catalog=MNLottery - This is the database name. it can be found by looking in SSMS under the databases folder.

user id=MNLotterySQL - This is the user Id that was created in one of the previous steps for DAL access.

password=sqlpwd01 - This is the user password that was created in one of the previous steps for DAL access.

*/

<appSettings>
	<add key="ConnectionStringName" value="AstonEngineerLotteryApp" />
</appSettings>
<connectionStrings>
	<add name="AstonEngineerLotteryApp" connectionString="Data Source=MNLT003; Initial Catalog=MNLottery; user id=MNLotterySQL; password=sqlpwd01;" providerName="System.Data.SqlClient" />
</connectionStrings>


/* Setup DAL for classes ********* */
/*
01. Create new class in the DAL project (it will be referencing an existing BOs). Name it using the following format based: classnameDAL.cs (e.g. employeeDAL.cs).
02. Create method that is used for stored procedure (and links to the BO with the related table name) - name similar to: public static Employee GetItem(int employeeId)
03. Add reference to DAL project for BO project
04. Add line for "using" in the top of the new DAL class that uses the same namespace as the BO object it links to.





*/


/* ********** ENUMERATION TYPE - ENUMS ********** */

//Enums are an efficient way of defining a set of named intergral constants that may be assigned to a variable. Example below

	enum Days
	{
		Sunday = 0,
		Monday = 1,
		Tuesday = 2,
		Wednesday = 3,
		Thrusday = 4,
		Friday = 5,
		Saturday = 6
	}

//Use the code below as a template for how to use enums

	private static void LessonEnum()
	{
		Days myBirthdayId = 6; //Without Enums
		Days myBirthDay = Days.Saturday; //Using Enums makes coding slightly easier
	}






								 

/* **** TASKS *** */
/*
• Do a refresher on class properties

• Do a refresher on connectors

*/


/* **** QUESTIONS *** */

Person myFirstPerson = new Person();

/*
• When we setup properties with get; set;, is this declaring the property, correct? Are parameters(variables) used to store the data, and the parameters are linked to the properties through "connectors"? Are values stored in the property name like a variable of a list?

• If Collections are only used for one to many relationships, why does EntityType have a collection?

• Does 'Is A' and 'Has A' relate to collections and custom properties/classes???
 
*/



/* ***** REVIEW ***** */
/*
DEFINE & EXPLAIN USEAGE:
Class
Object
Method
Constructor
Property
Parameter


CODE:
Class
Object
Method
Constructor
Properties
Parameters
Custom properties/custom classes


CODE BREAKDOWN
public Car() - This is a constructor


*/



