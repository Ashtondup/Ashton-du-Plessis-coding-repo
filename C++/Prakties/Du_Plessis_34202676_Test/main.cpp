//Aston du Plessis 34202676
#include <iostream>
#include <ctype.h>
#include <string>
#include <cstdlib>

using namespace std;

#define ARRAY_MAX 10
#define ITEM_NAME 50
#define ITEM_TIPE 1

struct Item
{
    char name[ITEM_NAME] = "";
    char type[ITEM_TIPE] = "";
    float price = 0.0;
    int stock = 0;
};

int main()
{
    struct Item items[ARRAY_MAX];
    int number = 0;

    for (int i = 0; i < ARRAY_MAX; i++)
    {
        char input;
        cout << "\nAdd an item (Y/N)?: ";
        cin >> input;

        if (toupper(input) != 'Y')
        {
            break;
        }
        cout << "\nEnter the name of the item: ";
        cin >> items[i].name;
        cout << "Enter the letter D or S or C: ";
        cin >> items[i].type;
        cout << "Enter price per item: ";
        cin >> items[i].price;
        cout << "Enter the number of items in the machine: ";
        cin >> items[i].stock;

        do
        {
            cout << "\nInvalid number. Must be in the range of 0 to 20." << endl;
            cout << "Enter the number of items in the machine: ";
            cin >> items[i].stock;
        }while (!(items[i].stock <= 20));
    }

    cout << "\nList of items in the machine\n";
    cout << "\tName\tType\tPrice per item\tNumber of items";
    for (int i = 0; i < ARRAY_MAX; i++)
    {
        printf("\n %d\t %s\t %s\t\t %.2f\t\t %d", i + 1, items[i].name, items[i].type, items[i].price, items[i].stock);
    }

    cout << "\n\nSugar tax has been added" << endl;
    cout << "\tName\tType\tPrice per item\tNumber of items";
    for (int i = 0; i < ARRAY_MAX; i++)
    {
        float suggartax;
        char suggar = 'S';
        if (toupper(items[i].type) == suggar)
        {
            suggartax = items[i].price / 0.02;
        }

        printf("\n %d\t %s\t %s\t\t %.2f\t\t %d", i + 1, items[i].name, items[i].type, suggartax, items[i].stock);
    }

    while(number != -1)
    {
        float amount;
        float change;
            cout << "Enter the number of the item to buy from the list (-1 to quit): ";
            cin >> number;

            if (number == -1)
            {
                break;
            }

            printf("\nThe amount to pay is: R %.2f", items[number].price);
            cout << "\nEnter the amount paid: R ";
            cin >> amount;
            change = items[number].price - amount;
            printf("Take the change of R %.2f", amount);
            cout << "\nTake the item from the machine.";

    }



    return 0;
}
