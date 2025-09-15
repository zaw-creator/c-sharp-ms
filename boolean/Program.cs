//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine( 1 == 2);


//String myvalue = "a";
//Console.WriteLine(myvalue == "a");

//string value1 = " a";
//string value2 = "A ";

//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);


//String myvalue = "a";
//Console.WriteLine(myvalue != "a");

//Console.WriteLine(1>2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);


//string text = "nay kg lr hehe";

//Console.WriteLine(text.Contains("HEHE", StringComparison.OrdinalIgnoreCase));

//int salesamount = 1001;
////int discount = salesamount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {(salesamount > 1000 ? 100:50)}");

//Random rdn = new Random();

//int rdnnumber = rdn.Next(1, 10);
//Console.WriteLine(rdnnumber);

//string head = "Head";

//string tail = "tail";

//string result = rdnnumber >5 ? head : tail;



//Console.WriteLine(result);

string permission = "Manager";
int level = 21;


string admin = permission.Contains("Admin") && level >= 55 ? "Welcome, Super Admin user." :
    (permission.Contains("Admin") && level <= 55) ? "Welcome, Admin user." :
    (permission.Contains("Manager") && level >= 20) ? "Contact an Admin for access." :
    (permission.Contains("Manager") && level < 20) ? "You do not have sufficient privileges." :
    "You do not have sufficient privileges.";

Console.WriteLine(admin);