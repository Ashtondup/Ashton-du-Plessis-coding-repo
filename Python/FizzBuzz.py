print("FizzBuzz\n")

n = int(input("Enter the number of terms for FizzBuzz: ")

for num in range(1,n+1):
    if num % 15 is 0:
        print("FizzBuzz")
    elif num % 3 is 0:
        print("Fizz")
    elif num % 5 is 0:
        print("Buzz")
    else:
        print(num)
    
