// Retorna un valor pero no recibe parámetros
Func<int> numberRandom = () => new Random().Next(1000, 2000);
Console.WriteLine(numberRandom());

// Retorna un valor y recibe parámetros
// El último elemento es el tipo de dato que retorna
Func<int, int> numberRandomLimit = (limit) => new Random().Next(2000, limit);
//Func<int, string> numberRandomLimit = (limit) => new Random().Next(2000, limit).ToString();
Console.WriteLine(numberRandomLimit(3000));
