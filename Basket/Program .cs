using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    public class Program
    {
        public string Customer { get; set; }
        public List<string> Contents { get; set; }
        public double Price { get; set; }

        public Program (string customer, List<string> contents, double price)
        {
            this.Customer = customer;
            this.Contents = contents;
            this.Price = price;
        }

        public string returnCustomer()
        {
            return this.Customer;
        }

        public List<string> returnContents()
        {
            return this.Contents;
        }
        public double returnPrice()
        {
            return this.Price;
        }
        public void addProduct(string product, double productPrice)
        {
            this.Contents.Add(product);
            this.Price += productPrice;
        }
        public void deleteProduct (string product, double productPrice)
        {
            foreach (string item in this.Contents)
            {
                if (item == product)
                {
                    this.Contents.Remove(item);
                    this.Price -= productPrice;
                }
            }
        }

        public double calculateDiscountPrice (double percent)
        {
            double discount = percent / 100;
            return this.Price - this.Price * discount;
        }

        public double calculateAverageItemPrice()
        {
            return this.Price / this.Contents.Count;
        }
        static void Main(string[] args)
        {
        }
    }
}
