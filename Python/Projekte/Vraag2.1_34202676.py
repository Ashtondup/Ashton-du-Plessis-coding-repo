print("Vraag2.1\n")

import math

print("Please enter values (negative value to stop)")

count=0
min=0
max=0
average=0
flag=0
while not flag:
    val = float(input("Enter value number: "))
    if val <0:
        flag=1
    else:
        sum+=1
        count+=1
    return count

print("Number of values enterd:",count)
print("The highest value is: ",max(val))
print("The lowest value is: ",min(val))
print("The average value is: ",sum/count)
