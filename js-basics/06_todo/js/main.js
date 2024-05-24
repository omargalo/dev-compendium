// Para que podamos la referencia de nuestros todo's
// tenemos que guardarlos en un espacio en memoria
// para poder imprimirlos en una lista

// Creamos una costante para almacenar los todo's
// utilizando un arreglo vacio
const todos = [];

window.onload = () => {
    // Obtenemos la referencia del formulario
    const form =  document.getElementById('todo-form');
    // Reemplazamos la función que tenia form con este onsubmit
    form.onsubmit = (e) => {
        // Prevenir que el formulario refresque la pagina
        e.preventDefault();
        // Vamos al campo de todo
        const todo = document.getElementById('todo');
        // Obtenemos el valor que este tiene
        const todoText = todo.value;
        // Reemplazamos su valor con cadena vacia
        todo.value = '';
        // Agregamos el valor al array "todos"
        todos.push(todoText);
        // Imprimimos el valor en consola
        console.log(todoText);
        // Construimos un html para mostrar los datos
        // en una lista
        // Es muy importante que la referencia este fuera
        // del for para que no la vaya a buscar por la
        // cantidad de "todos" que tengamos en nuestro listado
        const todoList = document.getElementById('todo-list');
        // Limpiamos el listado
        todoList.innerHTML = '';
        for(let i = 0; i < todos.length; i++) {
            // Agregamos los elementos usando concatenacion
            todoList.innerHTML += '<li>' + todos[i] + '</li>';
        }
    }
}