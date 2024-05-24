#include <stdio.h>

int main() {
    // Integer data types
    int myInt = 10;
    short myShort = 20;
    long myLong = 30;
    long long myLongLong = 40;

    // Floating-point data types
    float myFloat = 3.14;
    double myDouble = 3.1415;
    long double myLongDouble = 3.14159265359;

    // Character data type
    char myChar = 'A';

    // String data type
    char myString[] = "Hello, World!";

    // Boolean data type
    _Bool myBool = 1;

    // Output the values
    printf("Integer: %d\n", myInt);
    printf("Short: %hd\n", myShort);
    printf("Long: %ld\n", myLong);
    printf("Long Long: %lld\n", myLongLong);
    printf("Float: %f\n", myFloat);
    printf("Double: %lf\n", myDouble);
    printf("Long Double: %Lf\n", myLongDouble);
    printf("Character: %c\n", myChar);
    printf("String: %s\n", myString);
    printf("Boolean: %d\n", myBool);

    return 0;
}