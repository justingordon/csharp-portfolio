/* User inputs ************ */

//Option Menu - Error message on invalid entry
	String input = System.Console.ReadLine();
	int selectedOption;
	if(int.TryParse(input, out selectedOption))
	{
		  switch(selectedOption) 
		  {
			   case 1:
					 //your code here.
					 break;
			   case 2:
					//another one.
					break;
			   //. and so on, default..
		  }

	} 
	else
	{
		 //print error indicating non-numeric input is unsupported or something more meaningful.
}


//Option Menu - Error message on invalid entry and loops to beginning
	string selectedOption = System.Console.ReadLine();
	int nothing = 0; //Unused variable
	while (!int.TryParse(selectedOption, out nothing)) //Check if input is a non-number
	{
	 System.Console.WriteLine("This is not a valid number. Please enter again:"); //User is an idiot
	selectedOption =  System.Console.ReadLine();
	}

	switch (selectedOption)
	{
		case "1":
			//your code here.
			break;

		case "2":
			//another one.
			break;

		case "3":
			//..and so on, default..
			break;
	}