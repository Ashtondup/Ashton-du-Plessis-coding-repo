//Ashton du Plessis 34202676
#include <iostream>

using namespace std;

const int MAX_LEN = 10;

int main()
{
    int *val;
    int searchval;


    cout << "Hello world!" << endl;

    for (int i = 0; i < MAX_LEN; i++)
    {
        cout << "Enter value " << i + 1 << ": ";
        cin >> *(val+i);
    }

    cout << "Enter value to search for in the array: ";
    cin >> searchval;

    int *ptr = val;
    for(int i = 0; i < MAX_LEN; i++)
    {
        if (*(val+i) == searchval)
        {
            cout << "Value " << searchval << " was found at index: "<< i <<" with address: " << &ptr << ", containing: " << searchval << '\n';
        }
    }

    return 0;
}
