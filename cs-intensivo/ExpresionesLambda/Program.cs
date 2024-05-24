// Funciones Lambda, es una manera de escribir una función anónima de manera práctica y sencilla.
// La función lambda puede acceder a elementos externos

string greeting = "Hello";

Action<string, string> showMessage1 = (a, b) =>
{ 
    Console.WriteLine($"{greeting} {a} {b}");
};

Action<string, string, string> showMessage2 = (a, b, c) =>
{
    Console.WriteLine($"{greeting} {a} {b} {c}");
};

showMessage1("Evelyn", "García");
showMessage2("Evelyn", "García", "Aragón");
Functions.SomeAction("Evelyn", "García", (a) =>
{
    Console.WriteLine("Soy una expresión Lambda " + a);
});

public class Functions
{
    public static void SomeAction(string name, string lastName, Action<string> fn)
    {        
        Console.WriteLine("Hago algo antes de la ejecución de la función");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final de la ejecución de la función");
    }
}