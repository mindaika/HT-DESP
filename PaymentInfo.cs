using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class PaymentInfo
{
    private string _name;
    private string _address;
    private string _city;
    private string _state;
    private string _zip;
    private string _creditCard;

    //Copy constuctor
    public PaymentInfo(PaymentInfo previousPaymentInfo)
    {
        _name = previousPaymentInfo.Name;
        _address = previousPaymentInfo.Address;
        _city = previousPaymentInfo.City;
        _state = previousPaymentInfo.State;
        _zip = previousPaymentInfo.Zip;
        _creditCard = previousPaymentInfo.CreditCard;
    }

	public PaymentInfo(string name, string address, string city, string state, string zip, string creditCard)
	{
		_name = name;
        _address = address;
        _city = city;
        _state = state;
        _zip = zip;
        _creditCard = creditCard;
	}

    public string Name { get; }
    public string Address { get; }
    public string City { get; }
    public string State { get; }
    public string Zip { get; }
    public string CreditCard { get; }
}
