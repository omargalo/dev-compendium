//Funciones

function iterar(arg1) { //Argumento
    for (let i = 0; i < arg1.length; i++) {
        console.log(arg1[i]);
    }
}

const numeros = [1, 2, 'Hola', 4, 5]
const nombres = ['Evelyn', 'Omar', 'Marcela', 'Oscar', 'Alex', 'Ender']

iterar(numeros) // Parametro
iterar(nombres) // Parametro

// Todas las funciones en JS sino indicamos un valor de retorno nos va a retornar undefined
function suma (a, b) {
    console.log(a + b);
}
// Guardar el resultado para ser usado posteriormente
const resultadoSuma = suma(2,4)

console.log('El Resultado es:', resultadoSuma);

// Lo correcto es usar Return
// return va a tomar el resultado que se encuentra a la derecha
// y lo va a devolver para que pueda ser asignado a otra constante

function resta (a, b) {
    return a - b;
}
// Guardar el resultado para ser usado posteriormente
const resultadoResta = resta(7,2)

console.log('El Resultado es:', resultadoResta);

// Tambien se le pueden pasar variables
function multiplicar (a, b) {
    return a * b;
}
// Guardar el resultado para ser usado posteriormente
const resultadoMultiplicar1 = multiplicar(2,2) //4
const resultadoMultiplicar2 = multiplicar(3,2) //6
const resultadoMultiplicar3 = multiplicar(resultadoMultiplicar1, resultadoMultiplicar2) //4*6=24

console.log('El Resultado es:', resultadoMultiplicar3);
