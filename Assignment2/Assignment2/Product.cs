using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }

        public double ItemPrice {  get; set; }

        public double StockAmount {  get; set; }


        //Product Constructor
        public Product(int id,string name,double price, double stock)
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
        public void IncreaseStock(double amount)
        {
            StockAmount += amount;
        }

        //Method to decrease stock

        public void DecreaseStock(double amount) 
        {
            if (StockAmount - amount > 5)
            {
                StockAmount -= amount;
            }
        }
    }
}
