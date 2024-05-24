#region Delegado Genérico Action
// Delegado genérico Action es el que se usa para funciones que no retornan valor
Action<string> showMessage = Console.WriteLine;
//showMessage("Hola Evelyn!");
Functions.SomeAction("Evelyn", "García", showMessage);

#endregion

#region Clase para funciones estáticas
// Creamos una clase para poner funciones estáticas las cuales podemos acceder sin crear objetos
public class Functions
{
    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        // Callback es la ejecución de algo posterior a la ejecución de la función
        Console.WriteLine("Hago algo antes de la ejecución de la función");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final de la ejecución de la función");
    }
}
#endregion