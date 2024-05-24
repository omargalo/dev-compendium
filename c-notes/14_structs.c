#include <stdio.h>
#include <string.h>

// Structs are used to create custom data types
struct Student{
        char name[50];
        char major[50];
        int age;
        double gpa;
    };

int main(){

    struct Student student1;
    // Assigning values to the struct
    // strcpy is used to copy a string to a char array
    strcpy(student1.name, "Evelyn");
    strcpy(student1.major, "Medicine");
    student1.age = 10;
    student1.gpa = 4.5;

    struct Student student2;
    // Assigning values to the struct
    // strcpy is used to copy a string to a char array
    strcpy(student2.name, "Ender");
    strcpy(student2.major, "Business");
    student2.age = 8;
    student2.gpa = 4.5;

    printf("%s\n", student1.name);
    printf("%s\n", student1.major);
    printf("%d\n", student1.age);
    printf("%f\n", student1.gpa);

    return 0;
}