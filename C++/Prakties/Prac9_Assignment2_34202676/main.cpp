//Ashton du Plessis 34202676
#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

double std_dev(double *, int);
void print_array(double *, int);
void remove_one(double *, int *);

int main()
{
  double previous_std_dev;
  double new_std_dev;

  double data[] = {11.2, 2.4, 3.13, 16.4, 5.8, 9.22, 4.9, 10.5, 6.5, 2.99};

  int N = sizeof(data) / sizeof(double);

  previous_std_dev = std_dev(data, N);
  print_array(data, N);
  remove_one(data, &N);
  print_array(data, N);
  new_std_dev = std_dev(data, N);

  printf("\nThe previous standard deviation of the array:\t %lf\n"
         "The current standard deviation of the array:\t %lf\n",
         previous_std_dev, new_std_dev);
}

void print_array(double *arr, int N)
{
  printf("\n");
  for (int i = 0; i < N; i++)
  {
    printf("%.2lf ", *(arr + i));
  }
  printf("\n");
}

double std_dev(double *arr, int N)
{
  double sum_a = 0.0;
  double sum_b = 0.0;

  for (int i = 0; i < N; i++)
  {
    sum_a += (*(arr + i) * *(arr + i));
  }
  sum_a /= N;

  for (int i = 0; i < N; i++)
  {
    sum_b += *(arr + i);
  }
  sum_b /= N;
  sum_b *= sum_b;

  return sqrt(sum_a - sum_b);
}

void remove_one(double *arr, int *N)
{
  int del = 0;
  printf("\nEnter an index to remove (0-%d): ", *N - 1);
  scanf("%d", &del);

  printf("\nRemoved the value '%.2lf'.\n", *(arr + del));

  for (int i = del; i < *N; i++)
  {
    *(arr + i) = *(arr + i + 1);
  }
  (*N)--;
}
