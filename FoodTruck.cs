using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class FoodTruck
{
    private List<MenuItem> _menu;
    private int _truckID;
    private int _status;
    private CustomerInfo _customerInfo;

    public FoodTruck(int truckID)
	{
        _truckID = truckID;
        _menu = new List<MenuItem>();
	}

    public void notify(int status)
    {
        _status = status;
    }

    public List<MenuItem> menuItemList()
    {
        _menu.Add(new MenuItem("A burrito", "A taco", 4.50, 1));
        _menu.Add(new MenuItem("A taccito", "Flat", 0.99, 2));
        _menu.Add(new MenuItem("Mexican pancake", "A type of soda", 4.00, 3));
        _menu.Add(new MenuItem("Soda", "A type of Mexican pancake", 3.00, 4));
        _menu.Add(new MenuItem("Despair", "An order of spair", 14.90, 5));
        return _menu;
    }
}
