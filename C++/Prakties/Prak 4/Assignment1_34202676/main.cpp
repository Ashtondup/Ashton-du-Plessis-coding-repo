//Ashton du Plessis 34202676
#include <iostream>

using namespace std;

int main()
{
    int len;
    int total = 0;
    int max;
    int min;
    int average ;

    cout << "How many elements should be stored in the arry? ";
    cin >> len;

    cout << '\n';

    int arr[len];

    for(int i = 0; i < len; i++)
    {
        cout << "Enter value for element at index " << i << ": ";
        cin >> arr[i];

        total = total + arr[i];
    }

    cout << '\n';

    max = arr[0];
    min = arr[0];
    for(int i = 0; i < len; i++)
    {
        if (arr[i] > max)
            max = arr[i];

        if (arr[i] < min)
            min = arr[i];

        cout << arr[i] << endl;
    }

    cout << "\nMax: " << max << endl;
    cout << "Min: " << min << endl;
    average  = total / len;
    cout << "Average : " << average << endl;
    return 0;
}
