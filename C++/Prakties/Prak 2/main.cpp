#include <iostream>

using namespace std;

int main()
{
    int len;
    float total = 0;
    float min;
    float max;
    float average;

    cout << "Assignment 1" << endl;

    cout << "\nEnter the amount of students you want to insert marks for: ";
    cin >> len;

    float arr[len];

    for (int i = 0; i < len; i++)
    {
        cout << "\nEnter mark for student " << i << ": ";
        cin >> arr[i];
        total = total + arr[i];
    }

    cout << "\n***************************************************************************************" << endl;
    cout << '\n';

    max = arr[0];
    min = arr[0];
    for(int i = 0; i < len; i++)
    {
        if (arr[i] > max)
            max = arr[i];

        if (arr[i] < min)
            min = arr[i];
    }

    cout << "The highest mark was: " << max << endl;
    cout << "\nThe lowest mark was: " << min << endl;
    average = total / len;
    cout << "\nThe average mark was: " << average << endl;

    cout << "\n***************************************************************************************" << endl;
    cout << '\n';

    cout << "Assignment 2" << endl;

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
