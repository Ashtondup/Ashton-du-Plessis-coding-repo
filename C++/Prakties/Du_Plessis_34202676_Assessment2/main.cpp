//Ashton du Plessis 34202676
#include<iostream>
#include<fstream>
#include<stdio.h>

using namespace std;

#define MAX_LEN 80

int ReadFile(char*, char*);
void Decode(char*, char*, int);
void WriteFile();

int main()
{

    char x[MAX_LEN];
    char y[MAX_LEN];
    int n = ReadFile(x, y);
    Decode(x, y, n);
    FILE *message = fopen("Message.txt", "r");
    if(message == NULL)
    {
        cout << "Encrypted message not found.";
    }
    else
    {
        cout << "String to be decoded:\n" << endl;
        char mesge[80], c;
        int count = 0;
        while(!message.eof())
        {
            message.get(c);
            cout << c;
        }
    }
    fclose(message);
    WriteFile()
    return 0;
}

int ReadFile(char *x, char *y)
{
  FILE *file = fopen("Data.txt", "r");
  if (!file)
  {
    cout << "File not found";
    return 0;
  }
  else
  {
    int temp_x, temp_y, count = 0;

    for (int i = 0; i < MAX_LEN; i++)
    {
      if (fscanf(file, "%c,%c", &temp_x, &temp_y) != EOF)
      {
        *(x + i) = temp_x;
        *(y + i) = temp_y;
        count++;
      }
    }
    fclose(file);
    return count;
  }
}

void Decode(char *x, char *y, int n)
{
    for(int i = 0; i < MAX_LEN; i++)
    {
        *(y + i) == *(x + i);
    }
}

void WriteFile()
{
    FILE* file = fopen ("Output.txt", "a");
    for(int i = 0; i < MAX_LEN; i++)
    {
        fprint(file,"%c", c);
    }
    fclose(file);
}
