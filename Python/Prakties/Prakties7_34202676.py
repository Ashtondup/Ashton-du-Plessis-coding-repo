print("Vraag 1\n")

n = int(input("Enter the numbrt of values to display: "))

i=1
while i<=n:
    print(i)
    i+=1

print("\nVraag 2\n")

sum=0
flag=0
while not flag:
    val = float(input("Enter value number: "))
    if val <0:
        flag=1
    else:
        sum+=val

print("The sum of the values = ",sum)

print("\nVraag 3\n")

def FibRecursion(n):  
   if n <= 1:  
       return n  
   else:  
       return(FibRecursion(n-1) + FibRecursion(n-2))  
nterms = int(input("Enter the number of terms to complete: "))

if nterms <= 0:
   print("Please enter a positive integer")  
else:  
   print("Fibonacci sequence:")  
   for i in range(nterms):  
       print(FibRecursion(i))
