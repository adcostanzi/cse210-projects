public class Address
{
    private string _streetName;

    private int _streetNumber;

    private string _suffix;

    private string _city;

    private string _stateOrProvince;

    private string _country;

    public Address()
    {

        Console.Write("What is the name of street? ");
        string streetName = Console.ReadLine();

        Console.Write("What is the street number? ");
        int streetNumber = int.Parse(Console.ReadLine());

        Console.Write("What is the street suffix (if none then press enter)? ");
        string suffix = Console.ReadLine();

        Console.Write("What is your client's city? ");
        string city = Console.ReadLine();

        Console.Write("What is your client's state or province? ");
        string stateOrProvince = Console.ReadLine();

        Console.Write("What is your client's country? ");
        string country = Console.ReadLine();

        _streetName = streetName;
        _streetNumber = streetNumber;
        _suffix = suffix;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

  

    public string GetAddress()
    {
        string suffix = "";
        if (_suffix == "")
        {
            suffix = "None";
        }
        else
        {
            suffix = _suffix;
        }
        string address = $"Street: {_streetNumber} {_streetName}\nSuffix: {suffix}\nCity: {_city}\nState or Province: {_stateOrProvince}\nCountry: {_country}";
        
        return address;
    }
}