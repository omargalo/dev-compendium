#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Top\n");
    // calling a function
    sayHi();
    sayHello("Evelyn", 10);
    sayHello("Omar Jr", 1);
    sayHello("Alex", 12);
    sayHello("Ender", 8);
    printf("Bottom\n");

    return 0;
}

// function without a parameter
void sayHi()
{
    printf("Hello User\n");
}

// function with parameters
void sayHello(char name[], int age)
{
    printf("Hello %s you are %d years old\n", name, age);
}