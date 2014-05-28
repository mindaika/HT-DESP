using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class FoodTruck
{
    private List<MenuItem> _menu;
    private int _truckID;
    private Status _status;
    private CustomerInfo _customerInfo;

    public FoodTruck(int truckID)
	{
        _truckID = truckID;
	}

    public void notify(Status status)
    {
        _status = status;
    }

    public List<MenuItem> menuItemList()
    {
        return _menu;
    }
}
