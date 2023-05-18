name = input("Enter your name: ")
surname = input("Enter your surname: ")

print("\nThis program was written by: ",name,surname)


print("\nSquare")

print(" ")

for i in range(10):
    print("*" * 19)

print("\nDiamond")

print(" ")

print("       *       ")
print("      ***      ")
print("     *****     ")
print("    *******    ")
print("   *********   ")
print("  ***********  ")
print(" ************* ")
print("***************")
print(" ************* ")
print("  ***********  ")
print("   *********   ")
print("    *******    ")
print("     *****     ")
print("      ***      ")
print("       *       ")

print("\nTriangle")

print(" ")

n = 11
for a1 in range(0,n):
    for a2 in range(a1):
        print("*", end="")
    print()

for a1 in range(n,0,-1):
    for a2 in range(a1):
        print("*", end="")
    print()

print("\nHeart")

print(" ")

print("  *****     *****  ")
print(" *******   ******* ")
print("********* *********")
print("*******************")
print(" ***************** ")
print("  ***************  ")
print("   *************   ")
print("    ***********    ")
print("     *********     ")
print("      *******      ")
print("       *****       ")
print("        ***        ")
print("         *         ")
