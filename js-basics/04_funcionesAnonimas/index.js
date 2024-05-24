// Funciones Anonimas
// Es una función que no tiene nombre
// No es tan bueno utilizarla ya que
// no nos permite reutilizar código

function sumar(a, b, cb) {
    const resultado = a +b
    cb(resultado)
}

function callback(result) {
    console.log('El resultado es:', result);
}

const miFatArrowFunction = (a, b) => a + b

sumar(2, 3, function (resultado) {
    console.log('Soy una funcion anonima y mi resultado es:', resultado);
})

