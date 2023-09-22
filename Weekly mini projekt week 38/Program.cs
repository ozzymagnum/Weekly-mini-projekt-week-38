

class Program
{
    // Define a Product class to represent product information
    class Product
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Category: {Category}\nProduct Name: {ProductName}\nPrice: {Price:C}\n";
        }
    }

    static void Main(string[] args)
    {
        // Create a list to store product objects
        List<Product> products = new List<Product>();
        decimal totalSum = 0; 

        while (true)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("To enter a new product - follow the steps  |  To quit - enter: Q ");
            Console.ForegroundColor = ConsoleColor.White;

            //added variables
            string category, productName;
            decimal price;

            Console.Write("Enter a Category: ");
            category = Console.ReadLine();

            // Check if the user wants to quit
            if (category.ToLower() == "q")
            {
                break; // Exit the loop if "q" is entered
            }

            Console.Write("Enter a Product Name: ");
            productName = Console.ReadLine();

            // Check if the user wants to quit
            if (productName.ToLower() == "q")
            {
                break; // Exit the loop if "q" is entered
            }

          
            Console.Write("Enter a Price: ");
            string priceInput = Console.ReadLine();

            // Check if the user wants to quit
            if (priceInput.ToLower() == "q")
            {
                break; // Exit the loop if "q" is entered
            }

            if (decimal.TryParse(priceInput, out price))
            {
                // Create a new Product object and add it to the list
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

        // Display the list of entered products
        Console.WriteLine("----------------------------------------------------------------");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
        // Display the total sum of product prices
        Console.WriteLine($"\nTotal Amount: {totalSum:C}");
    }
}






