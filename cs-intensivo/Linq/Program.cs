//Origen de datos
var names = new List<string>()
{
    "Evelyn",
    "Omar Jr",
    "Alexander",
    "Ender"
};

//Consulta LINQ
var namesResult = from n in names
                  where n.Length > 3 && n.Length < 8
                  orderby n descending
                  select n;

//var namesResult = (from n in names
//                  orderby n descending
//                  select n).ToList();     //Ejecución de la consulta (Afecta el rendimiento)

//Consulta con funciones encadenadas
var namesResult2 = names.Where(n => n.Length > 3 && n.Length < 15)
                        .OrderByDescending(n => n)
                        .Select(d => d); //funcion anonima

//Ejecución de la consulta
foreach (var name in namesResult2)
{
    Console.WriteLine(name);
}
