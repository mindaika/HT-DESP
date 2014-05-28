using System;

public class MenuItem
{
    private string _name;
    private string _description;
    private double _price;
    private int _itemID;

    public string Name
    {
        get { return _name; }
    }

    public string Description
    {
        get { return _description; }
    }

    public double Price
    {
        get { _price; }
    }

    public int ItemID
    {
        get { _itemID; }
    }

	public MenuItem(string name, string description, double price, int itemID)
	{
        _name = name;
        _description = description;
        _price = price;
        _itemID = itemID;
	}
}
