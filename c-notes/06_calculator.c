#include <stdio.h>
#include <stdlib.h>

int main()
{
    double num1;
    double num2;

    printf("Enter the first number: ");
    // & allows us to store the value in the address of the variable
    // %lf is used for double
    scanf("%lf", &num1);
    printf("Enter the second number: ");
    scanf("%lf", &num2);

    printf("Answer is: %f\n", num1 + num2);

    return 0;
}