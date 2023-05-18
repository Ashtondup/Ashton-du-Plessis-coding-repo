print("BMI Calculator")

print("\n1. Weight in pounds, hight in inches")
print("2. Weight in kilograms, height in meters")

import math

choice = input("\nChoice: ")#Preson must choose between option 1 and option 2

if choice == "1":
    weight1 = float(input("\nWeight in pounds?: "))
    height1 = float(input("\nHeihgt in inches?: "))
    bmi1 = float((weight1/(height1)**2)*703)
    print("\n")
    print("Result"+"."*14)
    print("\nWeight: "+ str(weight1) +" kilohrams")
    print("Height: "+ str(height1) +" meters")
    print("BMI: "+str(round(bmi1,1)))
    if bmi1 >= 30:
        print("Status: Obees")
    elif bmi1 <= 29 and  25:
        print("Status: Oorgewig")
    elif bmi1 < 25 and 18.5:
        print("Status: Normal")
    elif bmi1 < 18.5:
        print("Status: Ondergewig")

if choice == "2":
    weight2 = float(input("\nWeight in kilograms?: "))
    height2 = float(input("\nHeihgt in meters?: "))
    bmi2 = float(weight2/height2**2)
    print("\n")
    print("Result"+"."*14)
    print("\nWeight: "+ str(weight2) +" kilohrams")
    print("Height: "+ str(height2) +" meters")
    print("BMI: "+str(round(bmi2,1)))
    if bmi2 >= 30:
        print("Status: Obees")
    elif bmi2 <= 29 and  25:
        print("Status: Oorgewig")
    elif bmi2 < 25 and 18.5:
        print("Status: Normal")
    elif bmi2 < 18.5:
        print("Status: Ondergewig")
