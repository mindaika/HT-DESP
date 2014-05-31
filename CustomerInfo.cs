using System;

/// <summary>
/// Summary description for CustomerInfo
/// </summary>
public class CustomerInfo
{
    private string _name;
    private string _address;
    private string _city;
    private string _zip;

    //Copy constructor
    public CustomerInfo(CustomerInfo previousCustomerInfo)
    {
        _name = previousCustomerInfo.Name;
        _address = previousCustomerInfo.Address;
        _city = previousCustomerInfo.City;
        _zip = previousCustomerInfo.Zip;
    }
    public CustomerInfo(string name, string address, string city, string zip)
	{
        _name = name;
        _address = address;
        _city = city;
        _zip = zip;
	}

    public string Name { get; }
    public string Address { get; }
    public string City { get; }
    public string Zip { get; }
}
