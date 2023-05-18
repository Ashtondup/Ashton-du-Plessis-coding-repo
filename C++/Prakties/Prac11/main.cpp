//Ashton du Plessis 34202676
#include <iostream>
#include <bits/stdc++.h>

using namespace std;

void ReadFiles(int*, char*);
void SortArrays(int*, char*, int);
void WriteFiles(int*, char*);

int main()
{
    int intArr[50];
    char charArr[50];
    ReadFiles(intArr, charArr);

    cout << "Numbers of integers entries read: " << *(intArr) << endl;
    cout << "Numbers of characters entries read: " << *(charArr) << endl;

    int n = sizeof(*(intArr)) / sizeof(intArr);

    // Function calling
    SortArrays(intArr, charArr, n);

    WriteFiles(intArr, charArr);
    return 0;
}

void ReadFiles(int* intarr, int* chararr)
{
    int i = 0;
    int j = 0;
    FILE *INT = fopen("Data1.bin", "rb");

    if(INT == NULL)
    {
        cout << "File Data1.bin could not be read.";
        exit(1);
    }
    else
    {
        int temp1;
        while(fread(&temp1, sizeof(int), 1, INT))
        {
            if(feof(INT))
            {
                break;
            }
            else
            {
                *(intarr+i) = temp1;
                i++;
            }
        }
        fclose(INT);
    }
    //return i;

    FILE *CHAR = fopen("Data2.bin", "rb");
    if(CHAR == NULL)
    {
        cout << "File Data2.bin could not be read.";
        exit(1);
    }
    else
    {
        int temp2;
        while(fread(&temp2, sizeof(char), 1, CHAR))
        {
            if(feof(CHAR))
            {
                break;
            }
            else
            {
                *(chararr+j) = temp2;
                j++;
            }
        }
        fclose(CHAR);
    }
    //return j;
}

void SortArrays(int* intarr, char* chararr, int n)
{
    pair<int, char> pairt[n];

    for (int i = 0; i < n; i++)
    {
        pairt[i].first = *intarr;
        pairt[i].second = *chararr;
    }
    sort(pairt, pairt + n);
    for (int i = 0; i < n; i++)
    {
        *intarr = pairt[i].first;
        *chararr = pairt[i].second;
    }
}

void WriteFiles(int* intarr, char* chararr, int n)
{
    FILE* OUT = fopen("Output.bin", "wb");

    for(int i = 0; i < n; i++)
    {
        fwrite(intarr+i, sizeof(int), 1, OUT);
        fwrite(chararr+i, sizeof(char), 1, OUT);
    }
    fclose(OUT);
}
