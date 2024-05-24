#include <stdio.h>
#include <stdlib.h>

int main ()
{
    // input integer from user
    int age;
    printf("Enter your age: ");
    // scanf() is used to take input from the user
    // & is used to store the value in the address of the variable
    scanf("%d", &age);
    printf("You are %d years old\n", age);

    // input float from user
    double gpa;
    printf("Enter your gpa: ");
    scanf("%lf", &gpa);
    printf("Your gpa is %lf\n", gpa);

    // input character from user
    char grade;
    printf("Enter your grade: ");
    scanf(" %c", &grade);
    printf("Your grade is %c\n", grade);

    // input string from user
    char name[20];
    printf("Enter your name: ");
    // we dont use & for string because it is already an array
    // scanf() will take input until it finds a space
    //scanf("%s", name);
    // to take input with space we use fgets()
    fgets(name, 20, stdin);
    printf("Your name is %s", name);

    return 0;
}