using System;
using System.Collections.Generic;

namespace TicketPriceCalculatorApp
{
    public class Customer
    {
        public int Age { get; set; }

        public int GetTicketPrice()
        {
            return (Age <= 12 || Age >= 65) ? 7 : 10;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>();

            Console.WriteLine("Welcome to the Ticket Price Calculator!");
            Console.Write("Enter number of customers: ");

            if (int.TryParse(Console.ReadLine(), out int totalCustomers))
            {
                for (int i = 1; i <= totalCustomers; i++)
                {
                    Console.Write($"Enter age of customer {i}: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        customers.Add(new Customer { Age = age });
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Skipping this customer.");
                    }
                }

                Console.WriteLine("\nTicket Summary:");
                int grandTotal = 0;

                for (int i = 0; i < customers.Count; i++)
                {
                    int price = customers[i].GetTicketPrice();
                    Console.WriteLine($"Customer {i + 1}: Age {customers[i].Age} → GHC{price}");
                    grandTotal += price;
                }

                Console.WriteLine($"\nGrand Total: GHC{grandTotal}");
            }
            else
            {
                Console.WriteLine("Please enter a valid number of customers.");
            }

            Console.WriteLine("\nThank you for using the Ticket Price Calculator!");
        }
    }
}
