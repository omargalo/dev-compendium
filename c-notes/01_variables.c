#include <stdio.h>
#include <stdlib.h>

int main() {

    char personName[] = "Evelyn";
    int personAge = 10;

    // %s is a format specifier for strings
    // %d is a format specifier for integers

    printf("Hello, my name is %s and I am %d years old.\n", personName, personAge);

    return 0;
}