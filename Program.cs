
{
    Dictionary<string, decimal> shoppingList = new Dictionary<string, decimal>();
    {
        shoppingList.Add("strawberries", 6.50m);
        shoppingList.Add("bananas", 5.50m);
        shoppingList.Add("coconut", 5.00m);
        shoppingList.Add("papaya", 8.00m);
        shoppingList.Add("kiwi", 3.00m);
        shoppingList.Add("orange", 2.75m);
        shoppingList.Add("lemon", 2.00m);
        shoppingList.Add("dragon fruit", 7.00m);
    }

    List<string> order = new List<string>();

    Console.WriteLine("Welcome to Grand Circus Food Market!");

    while (true)
    {
        Console.WriteLine(String.Format("{0,15} {1,15}", "Item", "Price"));
        Console.WriteLine(String.Format("{0,15} {1,15}", "=====", "====="));
    }
        foreach (KeyValuePair<string, decimal> kvp in shoppingList)
        {
            Console.WriteLine(String.Format("{0,15} {1,15}", $"{kvp.Key}: {kvp.Value}"));
        }
    Console.WriteLine();

    while (true)
    {
        Console.WriteLine("Enter an item name");
        string item = Console.ReadLine();
        if (menu.ContainsKey(item))
        {
            order.Add(item);
            break;
        }
        else
        {
            Console.WriteLine("Sorry we do not have that item. Please try again.");
        }
    }
    Console.WriteLine();

  static bool GetContinue();
  while (true)
         Console.WriteLine("Do you want to continue? y/n?");
         string input = Console.ReadLine().ToLower().Trim();
         if (input == "y")
         {
         return true;
         }
         else if (input == "n")
         {
         return false;
         }
         else
         {
            Console.WriteLine("Invalid. Please try again.");
         }
    Console.WriteLine("Thank you for your your purchase!");
    decimal sum = 0;
    foreach (string s in order)
    {
        Console.WriteLine($"{s}:    /t{shoppingList[s]");
    }
}
    Console.WriteLine("Your total is {sum}.");

    Console.WriteLine(shoppingList["strawberries"]);

  

//{
//    Console.WriteLine(string.Format("{0,15} {1,15}", $"{kvp.Key}: {kvp.Value}"));
//    Console.WriteLine("\t===========\t===========");
//}

//    static bool GetContinue()
//    {
//        while (true)
//        {
//            Console.WriteLine("Do you want to continue?");
//            string input = Console.ReadLine().ToLower().Trim();

//            if (input == "y")
//            {
//                return true;
//            }
//            else if (input == "n")
//            {
//                return false;
//            }
//            else
//            {
//                Console.WriteLine("Invalid. Please try again.");
//            }
//        }
//    }
//}





//    static bool GetContinue()
//    {
//        while (true)
//        {
//            Console.WriteLine("Do you want to continue(y/n)?");
//            string input = Console.ReadLine().ToLower().Trim();

//            if (input == "y")
//            {
//                return true;
//            }
//            else if (input == "n")
//            {
//                return false;
//            }
//            else
//            {
//                Console.WriteLine("Invalid input, please try again");
//            }
//        }
//    }
//}

//bool isRunning = true;
//while (isRunning)
//{
//    isRunning = GetContinue();
//}

//while (true)

//        Console.WriteLine("Enter an item name");
//    string item = Console.ReadLine();
//    double cost = shoppingList[item];
//    {
//        Console.WriteLine(String.Format("{0,15} {1,15}", "Items", "Price"));
//        Console.WriteLine("\t===========\t===========");
//        Console.WriteLine($"{cost}");
//    }
//}