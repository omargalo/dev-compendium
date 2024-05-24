#include <stdio.h>
#include <stdlib.h>

int main(){

    int age = 42;
    // Create a pointer to the memory address of the variable age
    int * pAge = &age;

    // Dereferencing a pointer means getting the value of the variable that the pointer is pointing to
    printf("Dereferencing age: %d\n", *pAge);
    // Dereferencing a pointer is done by adding an asterisk (*) before the pointer variable name
    printf("%d\n", *&age);
    // Dereferencing a pointer is done by adding an asterisk (*) before the pointer variable name
    printf("%d\n", &*&age);
    printf("%d\n", *&*&age);

    return 0;
}