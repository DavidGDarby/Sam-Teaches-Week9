using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;

namespace Sam_Teaches_week_9
{
    class Program
    {
        static List<List<string>> Orders;
        static List<decimal> Totals;
        static void Main(string[] args)
        {
            Orders = new List<List<string>>();
            Totals = new List<decimal>();
            bool orderContinue = true;

            Console.WriteLine("Welcome to Darby-O Pizzaria.\n");

            while (orderContinue == true)
            {
                Console.WriteLine("Please make a selection.");
                Console.WriteLine("1. Place an Order\n2. View Order History\n3. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        OrderPizza();
                        break;
                    case "2":
                        Console.Clear();  
                        OrderHistory();
                        break;
                    case "3":
                        orderContinue = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please make a selection from the list.\n");
                        break;
                }
            }
        }
        private static void OrderPizza()
        {
            List<string> pizza = new List<string>();
            List<decimal> cost = new List<decimal>();
            bool orderContinue = true;

            Console.Clear();
            Console.WriteLine("Please select a size.\n");
            while (orderContinue)
            {
                Console.WriteLine("1. Small $5.99\n2. Medium $6.99\n3. Large $8.99");
                switch (Console.ReadLine())
                {
                    case "1":
                        pizza.Add("small");
                        cost.Add(5.99m);
                        orderContinue = false;
                        break;
                    case "2":
                        pizza.Add("medium");
                        cost.Add(6.99m);
                        orderContinue = false;
                        break;
                    case "3":
                        pizza.Add("large");
                        cost.Add(8.99m);
                        orderContinue = false;
                        break;
                    default:
                        Console.WriteLine("Please make a selection from the list.\n");
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Choose a crust\n");
            orderContinue = true;
            while (orderContinue)
            {
                Console.WriteLine("1. Regular\n2. Garlic\n3. Parmesan\n4. Thin Crust\n5. Stuffed (Extra cost of $1.99)");
                switch (Console.ReadLine())
                {
                    case "1":
                        pizza.Add("regular crust");
                        orderContinue = false;
                        break;
                    case "2":
                        pizza.Add("garlic crust");
                        orderContinue = false;
                        break;
                    case "3":
                        pizza.Add("parmesan crust");
                        orderContinue = false;
                        break;
                    case "4":
                        pizza.Add("thin crust");
                        orderContinue = false;
                        break;
                    case "5":
                        pizza.Add("stuffed crust");
                        cost.Add(1.99m);
                        orderContinue = false;
                        break;
                    default:
                        Console.WriteLine("Please make a selection from the list.\n");
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Choose a sauce.\n");
            orderContinue = true;
            while (orderContinue)
            {
                Console.WriteLine("1. Classic\n2. Marinara\n3. Alfredo\n4. Garlic Parmesan");
                switch (Console.ReadLine())
                {
                    case "1":
                        pizza.Add("classic sauce");
                        orderContinue = false;
                        break;
                    case "2":
                        pizza.Add("marinara sauce");
                        orderContinue = false;
                        break;
                    case "3":
                        pizza.Add("alfredo sauce");
                        orderContinue = false;
                        break;
                    case "4":
                        pizza.Add("garlic parmesan sauce");
                        orderContinue = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please make a selection from the list.\n");
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Choose two free toppings.\n");
            int count = 0;
            bool toppings = true;

            while (count < 2)
            {
                if (count == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Choose a second topping.\n");
                }

                Console.WriteLine("1. Pepperoni\n2. Sausage\n3. Canadian Bacon\n4. Chicken\n5. Pineapple\n6. Spinach\n7. Jalapeno\n8. Bell Pepper\n9. Onions\nN. No toppings.");

                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        pizza.Add("pepperoni");
                        count++;
                        break;
                    case "2":
                        pizza.Add("sausage");
                        count++;
                        break;
                    case "3":
                        pizza.Add("canadian bacon");
                        count++;
                        break;
                    case "4":
                        pizza.Add("chicken");
                        count++;
                        break;
                    case "5":
                        pizza.Add("pineapple");
                        count++;
                        break;
                    case "6":
                        pizza.Add("spinach");
                        count++;
                        break;
                    case "7":
                        pizza.Add("jalapeno");
                        count++;
                        break;
                    case "8":
                        pizza.Add("bell pepper");
                        count++;
                        break;
                    case "9":
                        pizza.Add("onion");
                        count++;
                        break;
                    case "n":
                        toppings = false;
                        count += 2;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please make a selection from the list.\n");
                        break;
                }
            }
            orderContinue = true;
            Console.Clear();


            if (toppings)
            {   
                while (orderContinue)
                {
                    Console.Clear();
                    Console.WriteLine("Choosing any additional toppings costs $0.75.\n");
                    Console.WriteLine("1. Pepperoni\n2. Sausage\n3. Canadian Bacon\n4. Chicken\n5. Pineapple\n6. Spinach\n7. Jalapeno\n8. Bell Pepper\n9. Onions\nN. Finished");

                    switch (Console.ReadLine().ToLower())
                    {
                        case "1":
                            pizza.Add("pepperoni");
                            cost.Add(0.75m);
                            break;
                        case "2":
                            pizza.Add("sausage");
                            cost.Add(0.75m);
                            break;
                        case "3":
                            pizza.Add("canadian bacon");
                            cost.Add(0.75m);
                            break;
                        case "4":
                            pizza.Add("chicken");
                            cost.Add(0.75m);
                            break;
                        case "5":
                            pizza.Add("pineapple");
                            cost.Add(0.75m);
                            break;
                        case "6":
                            pizza.Add("spinach");
                            cost.Add(0.75m);
                            break;
                        case "7":
                            pizza.Add("jalapeno");
                            cost.Add(0.75m);
                            break;
                        case "8":
                            pizza.Add("bell pepper");
                            cost.Add(0.75m);
                            break;
                        case "9":
                            pizza.Add("onion");
                            cost.Add(0.75m);
                            break;
                        case "n":
                            orderContinue = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please make a selection from the list.");
                            break;
                    }
                }
                    
            }
            Console.Clear();
            decimal subTotal = ListSum(cost);
            decimal tax = 0.0995m;
            Console.Write("You have ordered a ");
            for (int i = 0; i < pizza.Count; i++)
            {
                if (i < pizza.Count - 1)
                {
                    Console.Write($"{pizza[i]}, ");
                }
                else if (i == pizza.Count - 1)
                {
                    Console.Write($"{pizza[i]}");
                }
            }
            Console.WriteLine(" pizza.\n");
            Console.WriteLine($"The total amount of this order is ${TotalCost(subTotal, tax).ToString("0.00")}.\n");
            Console.WriteLine("This pizza will be prepared and delivered to you soon. Thank you for ordering from Darby-O Pizzaria.\nPress any key to return to the main menu.");

            Orders.Add(pizza);
            Totals.Add(TotalCost(subTotal, tax));
            Console.ReadLine();
            Console.Clear();

        }
        public static decimal ListSum(List<decimal> cost)
        {
            decimal sum = 0;
            for (int i = 0; i < cost.Count; i++)
            {
                sum += cost[i];
            }
            return sum;
        }
        private static void OrderHistory()
        {
            int orderNumber = 1;
            if (!Orders.Any())
                Console.WriteLine("You have not placed any orders yet.\n");
            else
            {
                foreach (List<string> list in Orders)
                {
                    Console.Write($"{orderNumber}. ");
                    orderNumber++;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i < list.Count - 1)
                        {
                            Console.Write($"{list[i]}, ");
                        }
                        else if (i == list.Count - 1)
                        {
                            Console.Write($"{list[i]}\n");
                            //Console.Write($" -- ${Totals[i].ToString("0.00")}\n");
                        }
                    }
                }
            }
        }
        private static decimal TotalCost(decimal subTotal, decimal tax)
        {
            return subTotal + subTotal * tax;
        }
    }
}
