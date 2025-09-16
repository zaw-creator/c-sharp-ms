//int first = 2;
//string second = "4";
//int result = first + second;
//Console.WriteLine(result);


//string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//decimal total = 0;
//string words = "";

//foreach (string value in values)
//{
//    if (decimal.TryParse(value, out decimal data1))
//    {
//        total += data1;
//    }
//    else
//    {
//        words += value;
//    }
//}

//Console.WriteLine($"Total: {total}");
//Console.WriteLine($"Words: {words}");

//for(int i  = 0; i < values.Length; i++)
//{
//    Console.WriteLine(values[i]);
//}

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)

//decimal result = Convert.ToDecimal(value1) / value2;

//int result1 = Convert.ToInt32(result);

int result1 = Convert.ToInt32(value1)/Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = Convert.ToDecimal(value2) / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;

Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");




