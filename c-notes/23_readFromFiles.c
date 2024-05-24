#include <stdio.h>
#include <stdlib.h>

int main(){

    char line[255];
    FILE * fpointer = fopen("sons.txt", "r");

    // fgets() is used to read from a file
    fgets(line, 255, fpointer);
    printf("%s", line);

    fclose(fpointer);

    return 0;
}