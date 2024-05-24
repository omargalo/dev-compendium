// Simplificando usando map

const todos = [];

window.onload = () => {
    const form =  document.getElementById('todo-form');
    form.onsubmit = (e) => {
        e.preventDefault();
        const todo = document.getElementById('todo');
        const todoText = todo.value;
        todo.value = '';
        todos.push(todoText);
        const todoList = document.getElementById('todo-list');
        // Aplicando map
        const todosTemplate = todos.map(t => '<li>' + t + '</li>');
        console.log(todosTemplate);
        /*
        const todosTemplate = todos.map(tarea => {
            return '<li>' + tarea + '</li>';
        })
        */
       // Lo agregamos al listado
       todoList.innerHTML = todosTemplate.join('');
       // Seleccionar los elementos de la lista
       const elementos = document.querySelectorAll('#todo-list li')
       // lo asignamos a una constante
       elementos.forEach((elemento, i) => {
        // Agregamos un evento al elemento
        elemento.addEventListener('click', () => {
            // Eliminamos un elemento de nuestro html
            elemento.parentNode.removeChild(elemento)
            // Ahora eliminamos el elemento del array "todos"
            todos.splice(i, 1)
        })
       })
    }
}