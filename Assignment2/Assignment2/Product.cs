using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }

        public decimal ItemPrice {  get; set; }

        public decimal StockAmount {  get; set; }


        //Product Constructor
        public Product(int id,string name,decimal price, decimal stock)
        {

            if (id < 5 || id > 5000)
            {
                Console.WriteLine("ID must be less than 5000 and more than 5");
                return;
            }

            if (price < 5 || price > 5000)
            {
                Console.WriteLine("price must be less than 5000 and more than 5");
                return;
            }

            if (stock < 5 || stock > 5000)
            {
                Console.WriteLine("stock must be less than 5000 and more than 5");
                return;
            }




            ProdID = id;
            ProdName = name;
            ItemPrice = price;  
            StockAmount = stock;
        }
        //Method to increase stock
        public void IncreaseStock(decimal amount)
        {
            StockAmount += amount;
        }

        //Method to decrease stock

        public void DecreaseStock(decimal amount) 
        {
            StockAmount -= amount; 
        }
    }
}
