using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split('-');

                string product = commandArgs[0];
                decimal price = decimal.Parse(commandArgs[1]);

                if(menu.ContainsKey(product) == false)
                {
                    menu.Add(product, price);
                }
                else
                {
                    menu[product] = price;
                }
            }

            List<Customer> clients = new List<Customer>();

            string command = Console.ReadLine();
            while (command != "end of clients")
            {
                string[] commandArgs = command.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string product = commandArgs[1];

                if (menu.ContainsKey(product))
                {
                    string clientName = commandArgs[0];
                    int quantity = int.Parse(commandArgs[2]);
                    decimal bill = (decimal)quantity * menu[product];

                    Customer currentCustomer = new Customer();
                    currentCustomer.Name = clientName;
                    currentCustomer.ShopList = new Dictionary<string, int>();
                    currentCustomer.ShopList.Add(product, quantity);
                    currentCustomer.Bill = bill;

                    if(clients.Any(x => x.Name == currentCustomer.Name))
                    {
                        Customer existingCustomer = clients.First(c => c.Name == currentCustomer.Name);
                        if (existingCustomer.ShopList.ContainsKey(product))
                        {
                            existingCustomer.ShopList[product] += quantity;
                            existingCustomer.Bill += bill;
                        }
                        else
                        {
                            existingCustomer.ShopList.Add(product, quantity);
                            existingCustomer.Bill += bill;
                        }
                    }
                    else
                    {
                        clients.Add(currentCustomer);
                    }
                }
                command = Console.ReadLine();
            }

            decimal totalBill = 0;
            foreach (var client in clients.OrderBy(x => x.Name))
            {
                Console.WriteLine(client.Name);
                foreach (var product in client.ShopList)
                {
                    Console.WriteLine("-- {0} - {1}", product.Key, product.Value);
                }
                Console.WriteLine("Bill: {0:F2}", client.Bill);
                totalBill += client.Bill;
            }
            Console.WriteLine("Total bill: {0:F2}", totalBill);
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList = new Dictionary<string, int>();
        public decimal Bill { get; set; }
    }
}