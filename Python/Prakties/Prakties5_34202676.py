import math

value_1 = 0
value_2 = 0
value_3 = 0
value_4 = 0
value_5 = 0

print("Assignmint 1\n")

value_1 = float(input("Enter value 1: "))
value_2 = float(input("Enter value 2: "))
value_3 = float(input("Enter value 3: "))
value_4 = float(input("Enter value 4: "))
value_5 = float(input("Enter value 5: "))
fAverage = float((value_1+value_2+value_3+value_4+value_5)/5)

print("\nThe average of the values is: " + str(fAverage) + "\n")

print("Assignmint 2\n")
r = 0

r = float(input("What is the radius of the circle?: "))
diameter = float(2*r)
circumfrence = float(2*math.pi*r)
area = float(math.pi*r**2)

print("\nThe radius of the circle is: " + str(r))
print("The diameter of the circle is: " + str(diameter))
print("The circumference of the circle is: " + str(circumfrence))
print("The area of the circle is: " + str(area) + "\n")

print("Assignmint 3\n")
X1 = 0
X2 = 0
Y1 = 0
Y2 = 0

X1 = float(input("Enter coordinate 1 for point X: "))
X2 = float(input("Enter coordinate 2 for point X: "))
Y1 = float(input("Enter coordinate 1 for point Y: "))
Y2 = float(input("Enter coordinate 2 for point Y: "))
distance = float(math.sqrt(math.pow(X1-Y1,2)+math.pow(X2-Y2,2)))
print("The distance between point1 and point2 is: " + str(distance) + "\n")

print("Assignment 4\n")

test_1 = 0
test_2 = 0
test_3 = 0

test_1 = float(input("Enter marks for test 1: "))
test_2 = float(input("Enter marks for test 2: "))
test_3 = float(input("Enter marks for test 3: "))
average = float((test_1+test_2+test_3)/3)
if average > 75:
    print("\nCongratulation")
