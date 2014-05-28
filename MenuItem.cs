using System;

public class MenuItem
{
    private String _name;
    private String _description;
    private double _price;
    private int _itemID;

    public String Name
    {
        get { return _name; }
    }

    public String Description
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

	public MenuItem(String name, String description, double price, int itemID)
	{
        _name = name;
        _description = description;
        _price = price;
        _itemID = itemID;
	}
}
