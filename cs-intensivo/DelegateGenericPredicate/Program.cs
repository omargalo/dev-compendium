// Predicate nos permite crear delegados que tengan un
// tipo de una función que reciba un parametro y devuelva un booleano

Predicate<string> hasSpace = (word) => word.Contains(" ");
Console.WriteLine(hasSpace("Hello World")); // true

Predicate<string> hasSpaceOrE = (word) => word.Contains(" ") || word.ToUpper().Contains("E");
Console.WriteLine(hasSpaceOrE("Hello World")); // true

var words = new List<string>()
{
    "dulces",
    "chocolates",
    "gansitos",
    "submarinos",
    "bombones"
};

// Para retornar lo positivo de la condición
//var result = words.FindAll(hasSpaceOrE);
// Para retornar lo negativo de la condición
var result = words.FindAll((item) => !hasSpaceOrE(item));
foreach (var item in result)
{
    Console.WriteLine(item);
}
