print("Vraag 1.1\n")

n = int(input("Enter the number of terms for FizzBuzz: "))

for num in range(1,n+1):
    if num % 15 == 0:
        print("FizzBuzz")
    elif num % 3 == 0:
        print("Fizz")
    elif num % 5 == 0:
        print("Buzz")
    else:
        print(num)
