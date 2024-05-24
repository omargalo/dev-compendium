// Callback es una función que se va a ejecutar
// al final de una función

function sumar(a, b, cb) {
    const resultado = a + b
    cb(resultado)
}

function callback(result) {
    console.log('El resultado es:', result);
}

sumar(2, 3, callback)

// Las funciones en JS son valores que se pueden
// pasar como argumentos a otras funciones
