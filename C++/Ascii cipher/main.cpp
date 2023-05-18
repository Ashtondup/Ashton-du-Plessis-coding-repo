#include <iostream>
#include <stdlib.h>
#include <string.h>

using namespace std;

int main()
{
    char text[100];
    int shiftval;

    cout << "Enter the sentence you want to encrypt: ";
    cin >> text;
    cout << "Enter the shift value: ";
    cin >> shiftval;

    cout << "Your encrypted sentence: ";

    for(int i = 0; i < strlen(text); i++)
    {
        char current = *(text + i);

        if(current == '_')
        {
            cout << "_";
        }
        else
        {
            char encrypted = current + shiftval;
            if(encrypted == '_')
            {
                encrypted +=1;
            }
            cout << encrypted;
        }
    }
    return 0;
}
