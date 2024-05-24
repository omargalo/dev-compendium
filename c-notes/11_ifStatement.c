#include <stdio.h>
#include <stdlib.h>

int max2Number(int num1, int num2){
    int result;
    if(num1 > num2){
        result = num1;
    } else {
        result = num2;
    }
}

int max3Number(int num1, int num2, int num3){
    int result;
    if(num1 > num2 && num1 > num3){
        result = num1;
    } else if(num2 > num1 && num2 > num3){
        result = num2;
    } else {
        result = num3;
    }
}

int main()
{
    printf("%d\n", max2Number(10, 5));
    printf("%d\n", max3Number(10, 5, 20));

    return 0;
}