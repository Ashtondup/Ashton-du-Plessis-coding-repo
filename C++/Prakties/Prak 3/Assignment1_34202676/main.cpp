//Ashton du Plessis 34202676
#include <iostream>

using namespace std;

int main()
{
    int i, j, n;

    cout << "Please enter size of multiplication table: ";
    cin >> n;

    for (i = 1; i <= n; i++)
    {
        for (j = 1; j <= n; j++)
        {
            if (j <= n -1)
            {
                cout << i * j << '\t';
            }
            else
            {
                cout << i * j;
            }
        }
        cout << endl;
    }

    return 0;
}
