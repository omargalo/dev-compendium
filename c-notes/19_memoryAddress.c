#include <stdio.h>
#include <stdlib.h>

int main(){

    int age = 42;
    double gpa = 4.7;
    char grade = 'A';

    // %p is used to print the memory address of a variable
    printf("age: %p\ngpa: %p\ngrade: %p\n", &age, &gpa, &grade);

    return 0;
}
