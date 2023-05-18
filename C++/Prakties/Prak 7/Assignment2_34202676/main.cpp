//Ashton du Pessis 34202676
#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    int val1 = 0;
    int val2 = 0;
    int *pval1 = &val1;
    int *pval2 = &val2;

    printf("Enter two integers values to swop memory.\n");
    printf("Value of number 1: ");
    scanf("%d", pval1);
    printf("Value of number 2: ");
    scanf("%d", pval2);

    printf("\nVal1 is stored at memory %#p and has a value of %d.\n", pval1, *pval1);
    printf("Val2 is stored at memory %#p and has a value of %d.\n", pval2, *pval2);

    printf("\nSwopping values ...\n");

    printf("\nVal1 is stored at memory %#p and has a value of %d.\n", pval1, *pval2);
    printf("Val2 is stored at memory %#p and has a value of %d.\n", pval2, *pval1);
    return 0;
}
