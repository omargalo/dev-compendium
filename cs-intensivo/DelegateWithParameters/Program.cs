// Creación de los delegados y funciones estáticas

// Se guarda en la variabble mySum la función Sum de la clase Functions
Operation myFunctionality = Functions.Sum;
// Ejecución del delegado
Console.WriteLine(myFunctionality(4,3));

// Asignamos la función Multiply a la variable mySum
myFunctionality = Functions.Multiply;
Console.WriteLine(myFunctionality(4, 3));

/*
ShowMessage myShowMessage = Functions.ConsoleShow;
myShowMessage("Hola Evelyn");
*/

ShowMessage cw = Console.WriteLine;
cw += Functions.ConsoleShow;
//cw("Hola Evelyn");

Functions.SomeFunction("Evelyn", "García", cw);

#region Definición de los delegados
// Definimos los delegados
delegate int Operation(int x, int y);
// Para acceder a la función de orden superior el delegate debe ser publico
public delegate void ShowMessage(string message);
#endregion


#region Clase para funciones estáticas
// Creamos una clase para poner funciones estáticas las cuales podemos acceder sin crear objetos
public class Functions
{
    // Función estática Sum que cumpla con el primer delegado
    // Las variables pueden ser llamadas diferente a las del delegado

    // Función de primer orden
    public static int Sum(int a, int b) => a + b;
    /*
    {
        return a + b;
    }
    */

    // Función estática Multiply que cumpla con el primer delegado
    // Las variables pueden ser llamadas diferente a las del delegado

    // Función de primer orden
    public static int Multiply(int num1, int num2) => num1 * num2;

    // Función estática Show que cumpla con el segundo delegado
    // Función de primer orden
    //public static void ConsoleShow(string message) => Console.WriteLine(message);
    public static void ConsoleShow(string message) => Console.WriteLine(message.ToUpper());

    // Función de orden superior
    // Una función de orden superior es una función que recibe como parámetro otra función
    // La función que es recibida como parámetro es una función de primer orden
    public static void SomeFunction(string name, string lastName, ShowMessage fn)
    {
        // Callback es la ejecución de algo posterior a la ejecución de la función
        Console.WriteLine("Hago algo antes de la ejecución de la función");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final de la ejecución de la función");
    }
}
#endregion