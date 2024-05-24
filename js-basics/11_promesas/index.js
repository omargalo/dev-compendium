// Promesas
// Nos permiten resolver de manera síncrona valores.
// Las promesas se resuelven en el
// ciclo siguiente del cpu
// En este caso primero se resuelve
// console.log y posteriormente la
// promesa


Promise.resolve(2)
// Aqui valor vale 2
.then(valor => valor + 1)
.then(valor => console.log(valor))
// Es recomendable usar catch para manejer posibles errores
.catch(e => console.error(e))

// Promesas de manera asíncrona
new Promise((resolve, reject) => {
    setTimeout(() => resolve(7), 1000)
})
.then(x => console.log(x))
.catch(e => console.error(e))