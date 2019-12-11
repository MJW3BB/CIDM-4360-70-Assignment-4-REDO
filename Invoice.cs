using System;
using System.Collections.Generic;

class Invoice
{
    int InvNum;
    string nvDate;
    float total;
    public Invoice(int number, string date)
    {
        
    }
    //  Creates a new invoice entry (InvoiceEntry object ) and add it to the invoice.
    public bool addInvEntry(int ReqQuantity) // Item
    {

    }
    // Removes invoiceEntry object from the invoice using the passed line number.
    public bool removeInvEntry(int lineNumber)
    {

    }
    // Updates the invoice total attribute using the passed newValue by adding or subtracting  the newValue to/from the current total.
    public void updateTotal(float newValue)
    {

    }
    // Used to re-number the invoice entries’ numbers after removing lines. i.e. iterate over all invoice entry objects and assign them new line numbers using the method setLineNumber(newLineNumber) 
    public void updateLineNumbers()
    {

    }
    // display the invoice to the console by printing all the voice information (invoice number, date, all invoice entries
    public void printInvoice()
    {

    }
}