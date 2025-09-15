//Random random = new Random();
//int herohealth = 10;
//int monsterhealth = 10;
//int herodamage = 0;
//int monsterdamage = 0;
//do
//{
//    herodamage = random.Next(1, 10);
//    monsterdamage = random.Next(1, 10);

//    if (herodamage % 2 != 0)
//    {
//        monsterhealth -= herodamage;
//        Console.WriteLine($"You hit the monster for {herodamage} damage. Monster health is now {monsterhealth}");
//    }
//    else if (monsterdamage % 2 != 0)
//    {
//        herohealth -= monsterdamage;
//        Console.WriteLine($"The monster hits you for {monsterdamage} damage. Your health is now {herohealth}");
//    }
//    else
//    {
//        Console.WriteLine("Both attacks missed!");
//    }
//    if (herohealth <= 0)
//    {
//        Console.WriteLine("You have been defeated by the monster!");
//        break;
//    }
//    else if (monsterhealth <= 0)
//    {
//        Console.WriteLine("You have defeated the monster!");
//        break;
//    }
//}
//while (herohealth > 0 && monsterhealth > 0);



//int number;
//bool numberIsValid = false;
//Console.WriteLine("Enter a number");

//do
//{
//    string? input = Console.ReadLine();


//    if (!int.TryParse(input, out number))
//    {
//        Console.WriteLine("Sorry, you entered an invalid number, please try again");
//    }else if(number < 5 || number >10)
//    {
//        Console.WriteLine("Sorry, the number must be between 5 and 10, please try again");
//    }else
//    {
//        Console.WriteLine($"Thank you, you entered {number}");
//        numberIsValid = true;
//    }
//}while (numberIsValid == false);


//string input;
//string userinput;
//bool isValid = false;
//Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

//do
//{
//    input = Console.ReadLine() ?? "";
//    userinput = input.Trim().ToLower();

//    if (userinput == "adminstrator" || userinput == "manager" || userinput == "user")
//    {
//        Console.WriteLine($"({userinput}) has been accepted.");
//        isValid = true;

//        break;

//    }
//    else
//    {
//        Console.WriteLine($"The role name that you entered {input.Trim()}, is not valid. please enter Administrator, Manager, or User");
//    }
//}
//while (isValid == false);

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };




foreach (string myString in myStrings)
{
    int periodLocation = myString.IndexOf('.');
    string remaining = myString;

    while (periodLocation != -1)
    {
        string mySentence = remaining.Remove(periodLocation);

        Console.WriteLine(mySentence);

        // the remainder of myString is the string value to the right of the location
        remaining = remaining.Substring(periodLocation + 1);

        // remove any leading white-space
        remaining = remaining.TrimStart();

        // update the period location
        periodLocation = remaining.IndexOf('.');
    }

    // print whatever is left after the last period
    string finalSentence = remaining.Trim();
    if (!string.IsNullOrEmpty(finalSentence))
    {
        Console.WriteLine(finalSentence);
    }
}



