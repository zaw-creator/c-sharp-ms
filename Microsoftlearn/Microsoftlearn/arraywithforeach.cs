using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoftlearn
{
    internal class Arraywithforeach
    {
       public static void Checkingerror()
        {
            int[] inventory = { 200, 450, 700, 175, 250 };

            int sum = 0;
            int bin = 0;

            foreach (int i in inventory)
            {
                sum += i;
                bin++;
                Console.WriteLine($"Bin {bin} = {i} items (Running total: {sum})");

            }
            Console.WriteLine($"We have {sum} items in inventory.");

        }
     public static void OrderID()
        {
            string[] OrderIds = {     "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"};
            foreach (string id in OrderIds)
            {
                if (id.StartsWith("B"))
                {
                    Console.WriteLine(id);
                }
            }
        }

    public static void OrderIdGenerator()
        {
            string[] OrderID = new string[5];
            Random random = new Random();

            for (int i = 0; i < OrderID.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                // Convert the random value into a char, then a string
                string prefix = Convert.ToChar(prefixValue).ToString();
                // Create a random number, pad with zeroes
                string suffix = random.Next(1, 1000).ToString("000");
                // Combine the prefix and suffix together, then assign to current OrderID
                OrderID[i] = prefix + suffix;
            }

            foreach (var orderID in OrderID)
            {
                Console.WriteLine(orderID);
            }
        }

     
    }
}
