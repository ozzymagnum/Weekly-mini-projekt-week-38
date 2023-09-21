

class Program
{
    
    class Product
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Category: {Category}, Product Name: {ProductName}, Price: {Price:C}";
        }
    }

    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        decimal totalSum = 0; // Variable to store the total sum

        while (true)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("To enter a new product - follow the steps  |  To quit - enter: Q ");
            Console.ForegroundColor = ConsoleColor.White;

            string category, productName;
            decimal price;

            Console.Write("Enter a Category: ");
            category = Console.ReadLine();

            if (category.ToLower() == "q")
            {
                break;
            }

            Console.Write("Enter a Product Name: ");
            productName = Console.ReadLine();

            if (productName.ToLower() == "q")
            {
                break;
            }

            Console.Write("Enter a Price: ");
            string priceInput = Console.ReadLine();

            if (priceInput.ToLower() == "q")
            {
                break;
            }

            if (decimal.TryParse(priceInput, out price))
            {
                Product newProduct = new Product
                {
                    Category = category,
                    ProductName = productName,
                    Price = price
                };

                products.Add(newProduct);
                totalSum += price; // Update the total sum
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Product was successfully added!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid price format. Please enter a valid decimal number.");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------");
        }

        Console.WriteLine("\nList of Products Entered:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine($"\nTotal Sum of Product Prices: {totalSum:C}");
    }
}





/*

Product product1 = new Product("Electronic", "Computer", 1990);
Product product2 = new Product("Electronic", "Dishwasher", 2500);
Product product3 = new Product("Electronic", "Washingmachine", 3500);





class Product
{
public Product(string category, string productName, int price)
{
Category = category;
ProductName = productName;
Price = price;
}

public string Category { get; set; }
public string ProductName { get; set; }
public int Price { get; set; }

}
*/