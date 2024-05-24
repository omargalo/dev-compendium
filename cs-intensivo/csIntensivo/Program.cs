//Sale sale = new Sale();
var sale = new Sale(15);
//sale.Total = 15;
var message = sale.GetInfo();

Console.WriteLine(message);

class Sale
{
    public decimal Total { get; set; }
    private decimal _something;
    //protected decimal _something; //Only accessible from this class and its children

    //Constructor
    public Sale(decimal total)
    {
        this.Total = total;
        this._something = 7;
    }

    public string GetInfo()
    {
        return $"Total: {this.Total}";
    }
}
