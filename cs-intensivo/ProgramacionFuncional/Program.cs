//función de primera clase
var show = Show;

Something(show, "Hola ¿Como estas?");

string Show(string message)
{
    return message.ToUpper();
}

//función que recibe elementos pero no retorna nada utiliza Action
//void Something(Action<string> fn, string message)

//Si la función recibe un elemento y retorna un elemento utiliza Func
void Something(Func<string, string> fn, string message)
{
    Console.WriteLine("Hace algo al inicio");
    Console.WriteLine(fn(message));
    Console.WriteLine("Hace algo al final");
}

//función pura

Console.WriteLine(Sub(2,1));
int Sub(int a, int b)
{
    return a - b;
}

//función pura
DateTime date = new DateTime(2024, 1, 7);

Console.WriteLine(GetTomorrow(date));
DateTime GetTomorrow(DateTime date)
{
    return date.AddDays(1);
}

//función pura

var beer = new Beer()
{
    Name = "indio"
};

Console.WriteLine(ToUpper(beer).Name);
Console.WriteLine(beer.Name);

Beer ToUpper(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name?.ToUpper()
    };      
    return beer2;
}
class Beer
{
    public string? Name { get; set; }
}
