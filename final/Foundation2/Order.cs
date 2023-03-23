public class Order
{
    private Customer _customer;

    private List<Product> _products = new List<Product>();

    public Order()
    {
        Customer customer = new Customer();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        Console.WriteLine("\nProduct has been added to the order.\n");
    }

    public void GetTotalCost()
    {
        float totalCost = 0;
        
        foreach (Product product in _products)
        {
           float price = product.GetPrice();
           totalCost = totalCost + price; 
        }
        
        int shippingCost = GetShippingCost();
        
        totalCost = totalCost + shippingCost;

        string total = totalCost.ToString();

        Console.WriteLine($"Total cost of the order is: ${total}.\n");
    }

    private int GetShippingCost()
    {
        int shippingCost = 0;

        bool isLocationUs = _customer.isLocationUS();

        if (isLocationUs == true)
        {
            shippingCost = 5;
            Console.WriteLine("Shipping cost is $5");
        } 
        else
        {
            shippingCost = 35;
            Console.WriteLine("Shipping cost is $35");
        }

        return shippingCost;
    }

    public void CreatePackingLabel()
    {
        Console.WriteLine("Packing Label:\n");

        foreach (Product product in _products)
        {
            product.DisplayProduct();
        }

        Console.WriteLine("");

    }

    public void CreateShippingLabel()
    {
        Console.WriteLine("Shipping Label:\n");

        string name = _customer.GetCustomerName();

        string address = _customer.GetCustomerAddress();

        Console.WriteLine($"Customer:\n{name}\nAddress:\n{address}\n");
    }

}