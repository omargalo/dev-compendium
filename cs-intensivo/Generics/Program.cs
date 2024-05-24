var numbers = new MyList<int>(5);
var names = new MyList<string>(5);
var beers = new MyList<Beer>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);

names.Add("Evelyn");
names.Add("Omar");
names.Add("Alexander");
names.Add("Ender");
names.Add("Oscar");
names.Add("Vicky");

beers.Add(new Beer()
{
    Name = "Erdinger",
    Price = 5m
});

beers.Add(new Beer()
{
    Name = "Delirium",
    Price = 7.5m
});

beers.Add(new Beer()
{
    Name = "Victoria",
    Price = 8m
});

beers.Add(new Beer()
{
    Name = "Pacifico",
    Price = 9.5m
});

Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(beers.GetContent());
public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    //Constructor
    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
        /* else
        {
            throw new Exception("List is full");
        } */
    }

    public string GetContent()
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element + ", ";
        }
        return content;
    }
}

public class Beer
{
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Nombre: " +Name+ " Price: " + Price;
    }
}
