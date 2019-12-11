using System;
using System.Collections.Generic;

// Used to represent information about each item line (entry) in the invoice.
class InvoiceEntry
{ 
    // Attributes
    int LineNo;
    int Qnty;
    // Returns the line number (lineNo) of the invoice entry 
    public InvoiceEntry(int line, int quantity)
    {
        
    }
    // Methods
    // Change the line number of an invoice entry as the passed lineNum parameter
    public int getLineNumber()
    {
        return LineNo;
    }
    // Change the line number of an invoice entry as the passed lineNum parameter
    public int setLineNumber(int Num)
    {

    }
    // Returns the quantity of the item units in the invoice entry. 
    public int getQnty()
    {
        return Qnty;
    }
}