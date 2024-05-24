/*
Write a function that accepts a String as an argument

The String is supposed to be HTML, but all the div elements
are missing their closing tags.

The function should find and close all the divs in the
provided HTML String.

The function should return the entire corrected String.
*/

// Every second div needs to be closed <div> => </div>

const closeSecondDivs = (htmlString) => {

    let divCounter = 0;
    let unkownFour = "";
    let fixedHTML = "";
    for (let i = 0; i < htmlString.length; i++) {
        //console.log(htmlString[i]);
        if (htmlString[i] == "<") {
            for (let j = 1; j < 5; j++) {
                unkownFour += htmlString[i + j];
            }
            //console.log(unkownFour);
        }

        if (unkownFour == "div>") {
            //console.log("coming into the div fixer");
            divCounter++;
            if (divCounter % 2 == 0) {
                fixedHTML += htmlString[i] + "/";
                unkownFour = "";
                continue;
            }
        }

        fixedHTML += htmlString[i];
        unkownFour = "";
    }

    return fixedHTML;
};

console.log(closeSecondDivs("<div><p>Here is a <div> tag</p>"));
console.log(closeSecondDivs("<div><div><div>"));
console.log(closeSecondDivs("<div><div><p>Hello</p><div><div>"));
console.log(closeSecondDivs("<div></div><p>Hello</p><div></div>"));