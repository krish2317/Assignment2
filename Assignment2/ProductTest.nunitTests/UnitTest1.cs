using Assignment2;

namespace ProductTest.nunitTests
{
    public class Tests
    {
        private Product product { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            product = new Product(6, "Laptop", 500.00, 20.00);
        }


        //Test case for ProdID - Krish Chaudhary
        //The reason for choosing this test case is check max and min value for ProdID

        [Test]
        [TestCase(5, "Iphone", 1500.00, 6.00)]
        [TestCase(5000,"Iphone15",2000.00,7.00)]
        [TestCase(17,"Iphone16",2500.00,8.00)]

        public void ProductID_ShouldBeValid(int id, string name, double price, double stock)
        {
            // Arrange & Act
            var product = new Product(id, name, price, stock);

            // Assert
            Assert.That(product.ProdID, Is.EqualTo(id));
        }


        //Test Case for ItemPrice - Marco Parenti
        //I choose this test case to check because it hase lowest and highest value and additionally took one value in middle

        [TestCase(10,"Iphone",5.00,7.00)]
        [TestCase(7,"Iphone15",5000.00,10.00)]
        [TestCase(11,"Iphone16",19.00,90.00)]
        public void ItemPrice_ShouldBeValid(int id,string name, double price, double stock)
        {
            //Arrange & Act
            var product= new Product(id, name, price,stock);

            //Assert
            Assert.That(product.ItemPrice, Is.EqualTo(price));
        }

       
        //Test Case for StockAmount - Ansh Patel
        //The reason to choose this test case is to check min and max value for thie stockamount


        [TestCase(10, "Iphone", 5.00, 5.00)]
        [TestCase(7, "Iphone15", 5000.00, 5000.00)]
        [TestCase(11, "Iphone16", 19.00, 90.00)]
        public void StockAmount_ShouldBeValid(int id,string name,double price, double stock)
        {
            //Arrange &Act
            var product= new Product(id,name,price,stock);

            //Assert
            Assert.That(product.StockAmount, Is.EqualTo(stock));
        }


        //Test cases for StockAmount Increase method 

        //Krish Chaudhary - I choose this test case just to check weather its passing or not for the sake of assignment 
        [TestCase(23)]
        [TestCase(24)]
        [TestCase(0)]

        //Marco Parenti - The reason to choose this values is to check above min and below max value
        [TestCase(4999)]
        [TestCase(4)]
        [TestCase(3888)]

        //Ansh Patel - The reason to choose this value is to check weather it pass when average or random values are take 

        [TestCase(3678)]
        [TestCase(100)]
        [TestCase(1234)]

        public void StockAmount_Increase_Method_Test(double amount)
        {
            // Arrange & Act
            var increasedStock = product.StockAmount + amount;
            product.IncreaseStock(amount); 
            
            // Assert
            Assert.That(increasedStock, Is.EqualTo(product.StockAmount));
        }


    }
}