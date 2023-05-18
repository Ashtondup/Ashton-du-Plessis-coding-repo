//Ashton du Plessis 34202676

#include <iostream>
#include <math.h>
#include <stdio.h>
#include <iomanip>

using namespace std;

int main()
{
    int choice;
    float weight;
    float height;
    float BMI;

    cout << "BMI Calculator" << endl;

    cout << "\n1. Weight in pounds, height in inches" << endl;
    cout << "2. Weight in kilograms, height in meters" << endl;

    cout << "\nChoice: ";
    cin >> choice;

    if (choice == 1)
    {
        cout << "\nWeight in pounds: ";
        cin >> weight;
        cout << "\nHeight in inches: ";
        cin >> height;

        BMI = weight*703 / (height*height);

        cout << "\n\nResult.............." << endl;

        cout << "\nWeight:\t" << weight << " pounds" << endl;
        cout << "Height:\t" << height << " inches" << endl;
        cout << "BMI:\t" << fixed << setprecision(1) << BMI << endl;

    }

    else
    {
        cout << "\nWeight in kilograms: ";
        cin >> weight;
        cout << "\nHeight in meters: ";
        cin >> height;

        BMI = weight / (height*height);

        cout << "\n\nResult.............." << endl;

        cout << "\nWeight:\t" << weight << " kilograms" << endl;
        cout << "Height:\t" << height << " meters" << endl;
        cout << "BMI:\t" << fixed << setprecision(1) << BMI << endl;
    }

    if (BMI >=30)
    {
        cout << "Status:\tObese" << endl;
    }
    else if ((BMI < 30) && (BMI >=25))
    {
        cout << "Status:\tOverweight" << endl;
    }
    else if ((BMI < 25) && (BMI >=18.5))
    {
        cout << "Status:\tNormal" << endl;
    }
    else
    {
        cout << "Status:\tUnderweight" << endl;
    }
    return 0;
}
