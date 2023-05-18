//Ashton du Plessis 34202676
#include <iostream>
#include <stdio.h>

using namespace std;

int main(void)
{
    char letter[]= "A";
    int number = 0;
    double digit = 0.0;
    char *pchar = NULL;
    int *pnumber = NULL;
    double *pdigit = NULL;


    number = 1234;
    digit = 1234.12;

    pchar = &letter[0];
    pnumber = &number;
    pdigit = &digit;

    printf("The address of char is: %#p\n", (void*)&letter);
    printf("The address of integer is: %#p\n", (void*)&pnumber);
    printf("The address of double is: %#p\n", (void*)&pdigit);

    printf("The address of char* is: %#p\n", (void*)letter);
    printf("The address of int* is: %#p\n", (void*)pnumber);
    printf("The address of double* is: %#p\n", (void*)pdigit);

    printf("\nThe value of char is: %c\n", *pchar);
    printf("The value of integer is: %d\n", *pnumber);
    printf("The value of double is: %f\n", *pdigit);

    printf("The value char* is: %#p\n", pchar);
    printf("The value int* is: %#p\n", pnumber);
    printf("The value double* is: %#p\n", pdigit);

    printf("\nThe size of char is: %d bytes\n", sizeof(letter));
    printf("The size of integer is: %d bytes\n", sizeof(number));
    printf("The size of double is: %d bytes\n", sizeof(digit));

    printf("The size of char* is: %d bytes\n", sizeof(pchar));
    printf("The size of int* is: %d bytes\n", sizeof(pnumber));
    printf("The size of double* is: %d bytes\n", sizeof(pdigit));
    return 0;
}
