using System;
using System.Linq;
using System.Collections.Generic;

namespace Coffee;

public static class Coffee
{
    public static void Main()
    {

        int choose;
        Dictionary<String, double> Menu = new Dictionary<String, double>();
        int i;

        Dictionary<string, double> order = new Dictionary<string, double>();


        while (true)
        {

            Console.Write("Welcome to the Coffee Shop!\n1. Add Menu\n2. View Menu\n3. Place Order\n4. View Order\n5. Calculate Total\n6. Exit\nSelect an option: ");
            choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 1)
            {
                String[] itemName = new String[1];
                double[] itemPrice = new double[1];
                for (i = 0; i < 1; i++)
                {
                    Console.Write("Enter Item Name: ");
                    itemName[i] = Convert.ToString(Console.ReadLine());
                }
                for (i = 0; i < 1; i++)
                {
                    Console.Write("Enter Item Price: ");
                    itemPrice[i] = Convert.ToDouble(Console.ReadLine());
                }
                for (i = 0; i < 1; i++)
                    Menu.Add(itemName[i], itemPrice[i]);
                Console.WriteLine("Item added successfully! ");
                Console.WriteLine();

            }

            else if (choose == 2)
            {
                Console.WriteLine("Menu:");
                i = 0;
                foreach (var item in Menu)
                {
                    i++;
                    Console.WriteLine($"{i}. {item.Key} - {item.Value}");
                }
                Console.WriteLine();
            }

            else if (choose == 3)
            {
                Console.WriteLine("Menu: ");
                i = 0;
                foreach (var item in Menu)
                {
                    i++;
                    Console.WriteLine($"{i}. {item.Key} - {item.Value}");
                }
                Console.WriteLine("Enter the item number to order: ");
                if (int.TryParse(Console.ReadLine(), out int orderNo) && orderNo >= 1 && orderNo <= Menu.Count)
                {
                    string itemToAdd = Menu.Keys.ElementAt(orderNo - 1);
                    if (order.ContainsKey(itemToAdd))
                    {
                        Console.WriteLine("Item already in the order. Updating quantity...");
                        Console.WriteLine();
                    }
                    order[itemToAdd] = Menu[itemToAdd];
                    Console.WriteLine("Item added to order!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid Order number.");
                    Console.WriteLine();
                }
            }

            else if (choose == 4)
            {

                Console.WriteLine("Your Order:");
                if (order.Count > 0)
                {
                    foreach (var item in order)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No items in the order.");
                    Console.WriteLine();
                }
            }
        } Console.ReadKey();
    }
}


