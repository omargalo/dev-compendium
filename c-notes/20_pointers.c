#include <stdio.h>
#include <stdlib.h>

// A pointer a type of data that stores the memory address of another variable

int main (){

    int age = 42;
    int * pAge = &age;
    double gpa = 4.7;
    double * pGpa = &gpa;
    char grade = 'A';
    char * pGrade = &grade;

    // &age is the pointer to the memory address of the variable age
    printf("age's memory address: %p\n", &age);

    return 0;
}