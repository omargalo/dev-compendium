#include <stdio.h>
#include <stdlib.h>

int main(){

    // while loop
    printf("While loop\n");
    int i = 1;
    while(i <= 5){
        printf("%d\n", i);
        i++;
    }

    // for loop
    printf("For loop\n");
    for(int i = 1; i <= 5; i++){
        printf("%d\n", i);
    }

    // for loop with arrays
    printf("For loop with arrays\n");
    int luckyNumbers[] = {7, 12, 13, 19, 25, 42};
    for(int i = 0; i < 6; i++){
        printf("%d\n", luckyNumbers[i]);
    }

    return 0;
}
