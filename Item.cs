using System;
using System.Collections.Generic;

// Used to track information of each item in the store.
class Item
{
    // Attributes
    int ID;
    string Description;
    float AvailableQty;
    float UnitPrice;
    // Main Constructor.
    public Item()
    {

    }
    // Updates the current available quantity by adding/subtracting the passed value, and returns the new quantity.
    public bool updateAvlblQty()// Passed value
    {

    }
    // Returns the item’s unit price.
    public float getPrice()
    {
        return UnitPrice;
    }
    // Returns the item’s description.
    public string getItemDescription()
    {
        return Description;
    }
    // Returns the item’s id. 
    public int getItemID()
    {
        return ID;
    }
    // Displays the item information to the console (id, description, price, available.
    public void displayItem()
    {
        Console.WriteLine($"\t{Convert.ToString(ID)}   {Description}\t {UnitPrice}\t {AvailableQty}");
    }
}