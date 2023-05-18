//Ashton du plessis 34202676
#include <iostream>

using namespace std;

int main()
{
    int len;
    int temp = 0;

    cout << "How many elements should be stored in the arry? ";
    cin >> len;

    int arr[len];
    int *ptr = arr;

    for(int i = 0; i < len; i++)
    {
        cout << "Enter value for element at index " << i << ": ";
        cin >> *(ptr + i);
    }

    for(int i = 0; i <= len; i++)
    {
        for(int j = 0; j < len; j++)
        {
            if(arr[j] > arr[j+1])
            {
                temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
        }
    }

    cout<<"\nSorted arry: ";
    for(int i = 0; i < len; i++)
    {
        cout << *(ptr + i) << " ";
    }
    return 0;
}
