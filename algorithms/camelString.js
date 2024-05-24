/*
Write a function that accepts a string as an argument

The function should convert the first letter of each word to uppercase

The function should return the new string
*/

// Edge cases
// "" => ""
// letter => character
// Starting caps at letter 0
// "hello" => "HeLlO"
// "hello world" => "HeLlO wOrLd"
// "hello???" => "HeLlO???"

const camelLetters = (string) => {
    // loop through string
    let newString = "";

    for (let i = 0; i < string.length; i++) {
        // change the even indices to uppercase
        if (i % 2 == 0) {
            newString += string[i].toUpperCase();
        } else {
            newString += string[i].toLowerCase();
        }
    }

    return newString;
};

console.log(camelLetters("hello"));
console.log(camelLetters("hello evelyn"));
console.log(camelLetters("hello???"));
console.log(camelLetters("EVELYN"));