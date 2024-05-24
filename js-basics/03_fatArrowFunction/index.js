// Fat arrow function
// Tienen 2 beneficios:
// no se tiene que utilizar la palabra reservada function
// si nuestra función es de una sola linea,
// no es necesario utilizar la palabra reservada return

const miFatArrowFunction = (a, b) => a + b
// Si la función es de mas de una linea:
/*
const miFatArrowFunction = (a, b) => {
    return a + b
}
*/
const resultado = miFatArrowFunction(2, 3)
console.log(resultado);
