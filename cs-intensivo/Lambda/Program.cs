int sub2(int a, int b)
{
    return a - b;
}
Console.WriteLine(sub2(12, 5));

//Func<int,int,int> sub = (int a, int b) => a - b;
Func<int, int, int> sub = (a, b) => a - b;

Console.WriteLine(sub(10, 5));

//Si solo tienes un parametro de entrada
Func<int, int> some = a => a * 2;

Console.WriteLine(some(7));

//Si son varias lineas de codigo y un parametro de entrada
Func<int, int> some2 = a =>
{
    a = a + 1;
    return a * 3;    
};
Console.WriteLine(some2(6));

//Funcion que recibe funcion como parametro (funcion de orden superior)
SomeMethod((a,b)=>a+b, 5);
void SomeMethod(Func<int, int, int> fn, int number)
{
    var result = fn(number, number);
}