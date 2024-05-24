//La interfaz nos permite definir un contrato que debe ser implementado por las clases que la hereden.

using System.Runtime.InteropServices;

var sale = new Sale();
var beer = new Beer();

Something(sale);
Something(beer);

void Something(ISave save)
{
    save.Save();
}   

interface ISale
{
    decimal Total { get; set; }
}

interface ISave
{
    public void Save();
}

public class Sale : ISale, ISave
{
    public decimal Total { get; set; }

    public void Save()
    {
        Console.WriteLine("Saving in DB...");
    }
}

public class Beer : ISave
{
    public void Save()
    {
        Console.WriteLine("Saving in Services...");
    }
}