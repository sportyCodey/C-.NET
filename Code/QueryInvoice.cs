//This program uses LINQ to query

using System;
using System.Linq;

class QueryInvoice
{
    static void Main()
    {
        var items = new[] { new Invoice(34, "Cool", 10, 34.56M),
        new Invoice(12, "Bad", 1, 2.00M), new Invoice(100, "Super", 50, 205.67M),
        new Invoice(67, "Okay", 3, 10.56M), new Invoice(50, "Average", 90, 67.89M)};

        var sortPartDescrition =
            from value in items
            orderby value.PartDescription
            select value;

        Console.WriteLine("Sorting the Invoice objects by PartDescrition: ");
        if (sortPartDescrition.Any())
        {
            foreach (var item in sortPartDescrition)
            {
                Console.WriteLine($"{item} ");
            }
        }

        var sortByPrice =
            from value in items
            orderby value.Price
            select value;

        Console.WriteLine("\nSorting the Invoice objects by Price: ");
        if (sortByPrice.Any())
        {
            foreach (var item in sortByPrice)
            {
                Console.WriteLine($"{item} ");
            }
        }

        var sortByQuantity =
            from value in items
            orderby value.Quantity
            select new { value.PartDescription, value.Quantity };

        Console.WriteLine("\nSelecting PartDescription and Quantity and " +
            "sorting the results by Quantity: ");
        if (sortByQuantity.Any())
        {
            foreach (var item in sortByQuantity)
            {
                Console.WriteLine($"{item} ");
            }
        }

        var invoiceTotal =
            from value in items
            let total = value.Quantity * value.Price
            orderby total descending
            select new { value.PartDescription, total };

        Console.WriteLine("\nSelecting PartDescription and InvoiceTotal: ");
        if (invoiceTotal.Any())
        {
            foreach (var item in invoiceTotal)
            {
                Console.WriteLine($"{item} ");
            }
        }

        var filterInvoiceTotal =
            from value in invoiceTotal
            where value.total <= 500M && value.total >= 20M
            select value.total;

        Console.WriteLine("\nSelecting InvoiceTotal from the range $50 - $100");
        if (filterInvoiceTotal.Any())
        {
            foreach (var item in filterInvoiceTotal)
            {
                Console.WriteLine($"{item} ");
            }
        }
        
    }
}
