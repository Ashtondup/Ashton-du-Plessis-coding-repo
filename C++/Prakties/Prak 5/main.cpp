//Ashton du Plessis 34202676
#include <iostream>
#include <cctype>
#include <cstring>

using namespace std;

#define MAX_HORSES 4

struct Horse
{
  char name[20] = "";
  int age = 0;
  int height = 0;
  float time = 0.0;
};

int main()
{
  struct Horse horses[MAX_HORSES];

  float minimum = 0;
  int fastest_horse = 0;

  printf("    -= Welcome to the Durban July =-    \n");

  for (int i = 0; i < MAX_HORSES; i++)
  {
    printf("============================================\n");
    printf("Enter details for horse #%d:\n", i + 1);
    printf("============================================\n");

    printf("Horse #%d - Name: ", i + 1);
    cin >> horses[i].name;
    printf("Horse #%d - Age: ", i + 1);
    scanf("%d", &horses[i].age);
    printf("Horse #%d - Height: ", i + 1);
    scanf("%d", &horses[i].height);
    printf("Horse #%d - Time for last race: ", i + 1);
    scanf("%f", &horses[i].time);

    if (i == 0 || horses[i].time < minimum)
    {
      minimum = horses[i].time;
      fastest_horse = i;
    }
  }

  printf("\n*************************************************************************************************\n");
  printf("                                      Roster For Next Race                                       \n");
  printf("*************************************************************************************************\n");
  for (int i = 0; i < MAX_HORSES; i++)
  {
    printf("%d.\tName: %-20s Age: %d years\t Height: %2d hands \t Last run: %6.2f seconds\n", i + 1, horses[i].name, horses[i].age, horses[i].height, horses[i].time);
  }

  printf("*************************************************************************************************\n");
  printf("Race favourite: %s, with a time of: %.2f\n", horses[fastest_horse].name, horses[fastest_horse].time);
  printf("*************************************************************************************************\n");

  return 0;
}
