//Ashton du Plessis 34202676
#include <iostream>

using namespace std;

int main()
{
    int odd;

    cout << "Enter an odd number: ";
    cin >> odd;

    cout << '\n';

    if (odd % 2 ==1)
    {
        for (int i = odd; i > 1; --i)
        {
            for (int j = 1; j <= i; ++j)
            {
                cout << "*";
            }
            cout << '\n';
        }
        for (int i = 1; i <= odd; ++i)
        {
            for (int j = 1; j <= i; ++j)
            {
                cout << "*";
            }
            cout << '\n';
        }
    }
    else
    {
        cout << "This is not an odd number." << endl;
    }

    return 0;
}
