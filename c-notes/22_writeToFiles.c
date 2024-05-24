#include <stdio.h>
#include <stdlib.h>

int main(){

    // FILE is used to create a file pointer
    FILE * fpointer = fopen("sons.txt", "w");
    // "a" is used to append to the file
    //FILE * fpointer = fopen("sons.txt", "a");

    //fprintf() is used to write to a file
    fprintf(fpointer, "Evelyn, 10\nOmar Jr, 2\nAlexander, 12\nEnder, 8\n");

    fclose(fpointer);

    return 0;
}