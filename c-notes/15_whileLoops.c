#include <stdio.h>
#include <string.h>

int main(){

    // index is a variable that will be used to iterate through the loop
    int index = 1;
    while (index <= 7){
        printf("%d\n", index);
        //index = index + 1;
        index++;
    }

    int index2 = 9;
    // do while loop will run at least once
    do {
        printf("%d\n", index2);
        index2++;
    } while (index2 <= 7);

    return 0;
}