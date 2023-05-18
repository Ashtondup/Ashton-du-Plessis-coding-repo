#include <iostream>

using namespace std;

int main()
{
    int hight;
    int fizz;
    int buzz;

    cout << "Enter the highest you want to go: ";
    cin >> hight;

    cout << "Enter the number you want to Fizz: ";
    cin >> fizz;

    cout << "Enter the number you want to Buzz: ";
    cin >> buzz;

    cout << "\n";

    for(int i = 1; i <= hight; i++)
    {
        if((i %fizz ==0) && (i %buzz ==0))
        {
            cout << "FizzBuzz\n";
        }
        else if(i %fizz ==0)
        {
            cout << "Fizz\n";
        }
        else if (i %buzz == 0)
        {
            cout << "Buzz\n";
        }
        else
        {
            cout << i << "\n";
        }
    }
    return 0;
}
