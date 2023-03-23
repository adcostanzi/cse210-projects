public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {
        Console.Write("What is the name of your client? ");
        string customerName = Console.ReadLine();

        Address address = new Address();

        _name = customerName;
        _address = address;
    }

    public bool isLocationUS()
    {
        bool isIn = _address.IsInUS();
        return isIn;
    }

    public string GetCustomerAddress()
    {
        string address = _address.GetAddress();

        return address;
    }

    public string GetCustomerName()
    {
        return _name;
    }

}