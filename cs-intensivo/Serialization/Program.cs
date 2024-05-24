using System.Text.Json;

//Seralize
var omar = new People()
{
    Name = "Omar", 
    Age = 25
};

People.Get();

string json = JsonSerializer.Serialize(omar);

Console.WriteLine(json);

//Desaralize
string json2 = @"{
""Name"":""Evelyn"",
""Age"":10
}";

People? evelyn = JsonSerializer.Deserialize<People>(json2);
Console.WriteLine(evelyn?.Name);
Console.WriteLine(evelyn?.Age);

public class People
{
    public string? Name { get; set; }
    public int Age { get; set; }

    //public static string Get() { return "Hola"; }
    public static string Get() => "Hola";
}
