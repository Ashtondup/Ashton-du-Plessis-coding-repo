#include <iostream>
#include <cctype>
#include <cstring>

using namespace std;

#define MAX_BOOKS 50
typedef struct Books books;

struct Books
{
    int barcode = 0;
    char title[20] = "";
    float price = 0.0;
    int stock = 0;
};

int main()
{
    struct Books books[MAX_BOOKS];

    cout << "+++++++++++++++++++++++++++++++++";
    cout << "\n+Welcome to bookstore management+";
    cout << "\n+++++++++++++++++++++++++++++++++" << endl;

    for (int i = 0; i < MAX_BOOKS; i++)
    {
        begining:
        char add;
        float average;
        char searchbook;
        char searchforbook;
        int booksstock = 0;
        float booksprice = 0.0;

        cout << "================";
        cout << "\nBook number " << i + 1;
        cout << "\n================" << endl;

        printf("Barcode: ");
        scanf("%d", &books[i].barcode);
        printf("Title: ");
        scanf("%s", &books[i].title);
        printf("Price: ");
        scanf("%f", &books[i].price);
        printf("Stock: ");
        scanf("%d", &books[i].stock);

        cout << "================" << endl;

        askTheUser:

        printf("Add another book (Y/N):? ");
        scanf(" %c", &add);


        booksstock += books[i].stock;
        booksprice += books[i].price;
        average = booksprice / (i + 1);

        if (toupper(add) == 'N')
        {
            cout << "****************";
            cout << "\nYour bookstore consists of " << i + 1 << " titles.";
            cout << "\nYour bookstore has " << booksstock << " books on the shelves.";
            cout << "\nThe total value of your books is: R" << booksprice ;
            cout << "\nThe average value of a book is: R" << average <<  endl;

            cout << "****************";
            cout << "\nEnter a barcode to search for: ";
            cin >> searchbook;
            cout << "No book found for barcode: " << searchbook;

            searchFor:

            printf("\nSearch for another book (Y/N):? ");
            scanf(" %c", &searchforbook);

            if (toupper(searchforbook) == 'N')
            {
                break;
            }

            if (toupper(searchforbook) == 'Y')
            {
                cout << "Enter a barcode to search for: ";
                cin >> searchbook;
                cout << "================";
                cout << "\nBook title: ";
                cout << "\nCopies available: ";
                cout << "\nPrice: ";
                cout << "\n================";
                goto searchFor;
            }

            else if (toupper(searchforbook) != 'Y' && toupper(searchforbook) != 'N')
            {
                cout << "Invalid choice. ";
                goto searchFor;
            }
        }

        if (toupper(add) == 'Y')
        {

        }

        else if (toupper(add) != 'Y' && toupper(add) != 'N')
        {
            cout << "Invalid choice. ";
            goto askTheUser;
        }
    }

    return 0;
}
