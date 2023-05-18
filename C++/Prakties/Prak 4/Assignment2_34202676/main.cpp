//Ashton du Plessis 34202676
#include <iostream>

using namespace std;

int main()
{
    int len;
    int del = 0;

    cout << "How many elements should be stored in the arry? ";
    cin >> len;

    cout << '\n';

    int arr[len];

    for(int i = 0; i < len; i++)
    {
        cout << "Enter value for element at index " << i << ": ";
        cin >> arr[i];
    }

    cout << '\n';

    cout << "Delete entry number: ";
    cin >> del;

    cout << '\n';

    for(int i = del - 1; i < len - 1; i++)
    {
        arr[i] = arr[i + 1];
    }

    cout << "New array is: ";

    for(int i = 0; i < len - 1; i++)
    {
        cout << arr[i] << " ";
    }
    return 0;
}
