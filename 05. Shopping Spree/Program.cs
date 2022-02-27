using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Person
    {
        public Person()
        {
            this.Bag = new List<string>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> Bag { get; set; }
        public void AddProduct(string product)
        {
            Bag.Add(product);
        }

    }
    class Product
    {
        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person buyer = new Person();
            List<Person> buyers = new List<Person>();
            List<Product> products = new List<Product>();
            string[] buyersAndMoney = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int j = 0; j < buyersAndMoney.Length; j++)
            {
                List<string> currentBuyer = buyersAndMoney[j].Split("=", StringSplitOptions.RemoveEmptyEntries).ToList().ToList();
                Person buyer1 = new Person() { Name = currentBuyer[0],Money = double.Parse(currentBuyer[1])};
                buyers.Add(buyer1);

            }
            string[] productsAndPrices = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int j = 0; j < productsAndPrices.Length; j++)
            {
                List<string> currentProduct = productsAndPrices[j].Split("=", StringSplitOptions.RemoveEmptyEntries).ToList();
                products.Add(new Product(currentProduct[0], int.Parse(currentProduct[1])));
            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmd = command.Split(' ');
                string name = cmd[0];
                string productToBuy = cmd[1];
                double buyersMoney = 0;
                double productCost = 0;

                foreach (Person currenBuyer in buyers)
                {

                    if (currenBuyer.Name == name)
                    {
                        buyersMoney = currenBuyer.Money;

                        Product buyedProduct = new Product(productToBuy, productCost);
                        foreach (Product item in products)
                        {
                            if (item.Name == productToBuy)
                            {
                                productCost = item.Cost;
                            }
                        }

                        if (productCost <= buyersMoney)
                        {
                            currenBuyer.AddProduct(buyedProduct.Name);
                            currenBuyer.Money -= productCost;
                            Console.WriteLine($"{name} bought {productToBuy}");
                        }
                        else
                        {
                            Console.WriteLine($"{name} can't afford {productToBuy}");
                        }
                    }
                }
            }
            foreach (Person buyer1 in buyers)
            {
                if (buyer1.Bag.Count == 0)
                {
                    Console.WriteLine($"{buyer1.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{buyer1.Name} - {string.Join(", ", buyer1.Bag)}");
                }
            }
        }
    }
}
