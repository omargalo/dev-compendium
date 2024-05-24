#include <stdio.h>
#include <string.h>

int main(){

    int secretNumber = 7;
    int guess;
    int guessCount = 0;
    int guessLimit = 3;
    int outOfGuesses = 0;

    // while loop will run until the guess is not equal to the secret number
    while (guess != secretNumber && outOfGuesses == 0){
        if (guessCount < guessLimit){
            printf("Enter a number: ");
            scanf("%d", &guess);
            guessCount++;
        } else {
            outOfGuesses = 1;
            break;
        }
    }
    if(outOfGuesses == 1){
        printf("Out of guesses\n");
    } else {
        printf("You win!\n");
    }

    return 0;
}