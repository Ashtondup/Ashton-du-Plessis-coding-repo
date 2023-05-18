#include <iostream>
#include <cctype>
#include <cstring>

using namespace std;

double add(double n1, double n2);
double subtract(double n1, double n2);
double multiply(double n1, double n2);
double divide(double n1, double n2);
int mod(int n1, int n2);

int main()
{
    begining:

    double num1, num2;
    int input;
    double ret;
    char result;

    cout << "=======================" << endl;
    cout << "\tMenu" << endl;
    cout << "=======================" << endl;

    cout << "\t1.Add\n";
    cout << "\t2.Subtract\n";
    cout << "\t3.Multiply\n";
    cout << "\t4.Divide\n";
    cout << "\t5.Modulus\n";
    cout << "=======================" << endl;

    AskInput:
    cout << "Enter your choice(1-5): ";
    cin >> input;
    cout << "Enter integer number 1: ";
    cin >> num1;
    cout << "Enter integer number 2: ";
    cin>> num2;

    switch(input)
    {
    case 1:
        ret = add(num1, num2);
        cout << "\nResult: " << ret << endl;
        break;

    case 2:
        ret = subtract(num1, num2);
        cout << "\nResult: " << ret << endl;
        break;

    case 3:
        ret = multiply(num1, num2);
        cout << "\nResult: " << ret << endl;
        break;

    case 4:
        ret = divide(num1, num2);
        cout << "\nResult: " << ret << endl;
        break;

    case 5:
        ret = mod(num1, num2);
        cout << "\nResult: " << ret << endl;
        break;

    default:
        cout << "\nPick a number between 1 and 5" << endl;
        goto AskInput;
        break;
    }

    question:

    cout << "Press y or Y to continue: ";
    cin >> result;

    if(toupper(result) == 'Y')
    {
        goto begining;
    }
    return 0;
}

// function to add two numbers
double add(double n1, double n2)
{
    return n1+n2;
}

// function to subtract two numbers
double subtract(double n1, double n2)
{
    return n1-n2;
}

// function to multiply two numbers
double multiply(double n1, double n2)
{
    return n1*n2;
}

// function to divide two numbers
double divide(double n1, double n2)
{
    return n1/n2;
}

int mod(int n1, int n2)
{
    return n1%n2;
}
