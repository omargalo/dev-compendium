var sale = new SaleWithTax(15, 1.16m);

var message = sale.GetInfo();

Console.WriteLine(message);

//Herencia
class SaleWithTax : Sale
{
    public decimal Tax { get; set; }
    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        this.Tax = tax;
    }

    //Child method
    public override string GetInfo()
    {
        return $"Total: {this.Total} Tax: {this.Tax}";
    }

    //Overloading
    public string GetInfo(string message)
    {
        return $"Total: {this.Total} Tax: {this.Tax} {message}";
    }

    //Overloading
    public string GetInfo(int a)
    {
        return a.ToString();
    }
}
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

    public virtual string GetInfo()     //virtual: can be overriden on the child
    {
        return $"Total: {this.Total}";
    }
}
