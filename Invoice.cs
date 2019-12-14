using System;
using System.Collections.Generic;

class Invoice
{

    int InvNum;
    string InvDate;
    float total;
    int invNums;
    // Instanciate a list object to store inventory items.
    List<InvoiceEntry> itemList = new List<InvoiceEntry>();
    // Class constructor
    public Invoice(int invoiceNumber, string invoiceDate)
    {
        InvNum = invoiceNumber;
        InvDate = invoiceDate;
    }
    //  Creates a new invoice entry (InvoiceEntry object ) and add it to the invoice.
    public bool addInvEntry(Item sku,int AIDQnty)
    {
        if(sku.updateAvlblQty(AIDQnty) == true) // If the available quantity is >= 0, get the price and add it to the list.
        {
            InvoiceEntry num = new InvoiceEntry(sku,invNums,AIDQnty);
            updateTotal(sku.getPrice());
            itemList.Add(num);
            return true;
        }
        else
        {
            return false;
        }
    }
    // Removes invoiceEntry object from the invoice using the passed line number.
    public bool removeInvEntry(int lineNumber)
    {
        bool pass = false;
        if(itemList != null) // If the list object is empty
        {
            foreach(InvoiceEntry invNums in itemList.ToArray()) // for every entry 
            {
                if(invNums.getLineNumber() == lineNumber) // get the line number and set it equal to the value of lineNumber integer.
                {
                    int RIEQnty = invNums.getQnty(); // get the current quantity
                    itemList.RemoveAt(lineNumber-1);  // remove the specified quantity
                    updateLineNumbers(); // update the line number of the Invoice Entry
                    printInvoice(); // print it to the console
                    pass = true; // exit loop
                }
            }
            if (pass == true){return true;}else{return false;}}else{return false;}}
    // Updates the invoice total attribute using the passed newValue by adding or subtracting  the newValue to/from the current total.
    public void updateTotal(float newValue)
    {
        total = total + newValue;
    }
    // Used to re-number the invoice entries’ numbers after removing lines. i.e. iterate over all invoice entry objects and assign them new line numbers using the method setLineNumber(newLineNumber) 
    public void updateLineNumbers()
    {
        invNums=1;
        foreach(InvoiceEntry sku in itemList)
        {
            sku.setLineNumber(invNums);
        }
    }
    // display the invoice to the console by printing all the voice information (invoice number, date, all invoice entries
    public void printInvoice()
    {
        float entryTotal;
        total = 0.00f;
        Console.WriteLine($"\nInvoice #: {InvNum}\t Date: {InvDate}" );
        Console.WriteLine("  L#     Description  Quantity U.Price Total");
        Console.WriteLine("------- -------------- ------- ------- -------");
        foreach(InvoiceEntry c in itemList)
        {
            entryTotal = c.itemNumber.getPrice() * c.getQnty();
            Console.WriteLine($"{Convert.ToString(c.getLineNumber())}{c.itemNumber.getItemDescription()}\t{c.getQnty()}\t{c.itemNumber.getPrice()}    {entryTotal}");
            updateTotal(entryTotal);  
        }
        Console.WriteLine("------- -------------- ------- ------- -------");
        Console.WriteLine("------- -------------- ------- ------- "+"\t"+ total);
    }
}