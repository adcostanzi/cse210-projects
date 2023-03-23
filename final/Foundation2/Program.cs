using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;

        int answer2 = 0;

        OrderManager manager = new OrderManager();

        do
        {
            Console.WriteLine("Please Complete the following information: ");

            Order newOrder = new Order();

            do
            {
                Console.WriteLine("");

                Product newProduct = new Product();

                newOrder.AddProduct(newProduct);

                Console.Write("Would you like to add another product to the order (yes=1/ no=2)? ");
                answer2 = int.Parse(Console.ReadLine());

            } while (answer2 != 2);
            
            manager.AddOrder(newOrder);

            Console.Write("Would you like to add another order (yes=1/no=2)? ");
            answer = int.Parse(Console.ReadLine());

            Console.WriteLine("");

        } while (answer != 2);
        
        manager.DisplayOrders();
    }
}