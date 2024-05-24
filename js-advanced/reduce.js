// Reduce method is used to reduce the array to a single value. It executes a provided function for each value of the array (from left-to-right) and the return value of the function is stored in an accumulator. The reduce method takes two parameters, the first is the callback function and the second is the initial value of the accumulator.

// Reduce is a safe way of looping through an array and performing operations on each element of the array. It is a safe way because it does not change the original array.

const users = [
    {id: 1, name: 'Evelyn', age: 10},
    {id: 2, name: 'Omar Jr', age: 1},
    {id: 3, name: 'Alexander', age: 11},
    {id: 4, name: 'Ender', age: 8},
];

//Declarative way: what we want to achieve, not what should be done or how it should be done

//Our code it's fully inmutable, we are not overwriting properties of the object
//We simple every time return a new accumulator

const totalAge = users.reduce((acc, user) => {
    console.log("reduce", acc, user);
    return acc + user.age; //what we want to achieve
}, 0);

console.log("Edad total: " + totalAge);

//Imperative way: what exactly we need to do but not what we want to achieve

/*
let totalAge = 0;

users.forEach((user) => {
    totalAge = totalAge + user.age; //Overwriting properties of the object
});

console.log(totalAge);
*/


