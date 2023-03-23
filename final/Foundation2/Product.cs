public class Product
{
    private string _name;
    private string _id;

    private float _price;

    private int _quantity;

    public Product()
    {
        Console.Write("What is your product's name? ");
        string name = Console.ReadLine();

        Console.Write("What is your product's id? ");
        string id = Console.ReadLine();

        Console.Write("What is your product's price? ");
        float price = float.Parse(Console.ReadLine());

        Console.Write("What is your product's quantity? ");
        int quantity = int.Parse(Console.ReadLine());

        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public float GetPrice()
    {
        return _price * _quantity;
    }


    public void DisplayProduct()
    {
        Console.WriteLine($"Product ID: {_id} Description: {_name}");
    }
}