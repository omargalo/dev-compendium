//In JavaScript we have to important functions to work with JSON data. These are JSON.parse() and JSON.stringify().

const str = `{
    "name": "Evelyn",
    "age": 10,
    "isAdult": false,
    "colors": ["pink", "white"]
}`;

const obj = JSON.parse(str);
console.log("Parse: This is what we get from the server");
console.log(obj);

//Stringify, this is what we want to send to the server
console.log("Stringify: This is what we want to send to the server");
console.log(JSON.stringify(obj));
