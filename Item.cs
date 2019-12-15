/*
Matthew Webb
Gabriela Valenzuela
CIDM 4360-70
Assignment 4 REDO
*/

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
    public Item(int itemID, string itemDesc, float itemPrice, float itemQty)
    {
        ID = itemID;
        Description = itemDesc;
        UnitPrice = itemPrice;
        AvailableQty = itemQty;
    }
    // Updates the current available quantity by adding/subtracting the passed value, and returns the new quantity.
    public bool updateAvlblQty(float updateAvlblQtyPrivValue)
    {
        float num = updateAvlblQtyPrivValue;
        if(AvailableQty - updateAvlblQtyPrivValue >= 0)
        {
            Console.WriteLine("The new quantity of this item is " + num);
            return true;
        }
        else
        {
            return false;
        }
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
        Console.WriteLine($"\t{Convert.ToString(ID)}  {Description}\t {UnitPrice}\t {AvailableQty}");
    }
}