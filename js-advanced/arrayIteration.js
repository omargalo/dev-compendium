//Most often we use to work with arrays containing objects. Here we will see how to iterate through an array of objects.

const users = [
    {
        id: 1,
        name: 'Evelyn',
        age: 10,
    },
    {
        id: 2,
        name: 'Omar Jr',
        age: 1,
    },
    {
        id: 3,
        name: 'Alexander',
        age: 12,
    },
];


//Declarative way using Filter. Filter is a function for array filtering. It returns a new array with the elements that pass the condition of the callback function.
//The function goes trough each element and checks on predicate. Predicate means the condition that needs to be fulfilled.
const oldUsers = users.filter((user) => user.age > 10);
console.log("Using Filter: ");
console.log(oldUsers);
//Imperative way
/*
const oldUsers = [];
users.forEach((user) => {
    if (user.age > 10) {
        oldUsers.push(user);
    }
});
console.log("Old users: ");
console.log(oldUsers);
*/
//
//

//Declarative way using Map. Map is a function for array transformation. It returns a new array with the same length as the original array, but with each element transformed by the callback function.
const userNames = users.map(user => user.name);
console.log("Using Map: ");
console.log(userNames);

//Using forEach. forEach is a function for array iteration. It does not return a new array, but it does return undefined. It is used when you want to perform an action on each element of the array.
/*
const userNames =[]
users.forEach(user => {
    userNames.push(user.name);
});
*/

//Imperative way
/*
const userNames = []

for (let i = 0; i < users.length; i++) {
    userNames.push(users[i].name);
}

console.log(userNames);
*/
