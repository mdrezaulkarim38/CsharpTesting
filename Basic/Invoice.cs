using System;
using System.Net.Mail;

namespace Basic;

public class Invoice {
    public long InvoiceAmount { get; set; }
    public DateTime InvoiceDate { get; set; }
    public void AddInvoice()
    {
        try{
            Console.WriteLine("this is test");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private object SendInvoiceEmail(MailMessage mailMessage)
    {
        throw new NotImplementedException();
    }
}