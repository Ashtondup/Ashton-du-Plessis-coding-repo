name = input("Enter your name: ")
surname = input("Enter your surname: ")

print("\nWelcome, " + name + " " + surname + ".")

result = input("\nDo you want to play a game? ")
if result == "Yes" or result =="yes":
    print("Come and play.") #As persoon "Yes" of "yes" in tik.
else:
    print("Okay, bye.") #As persoon nie "Yes" of "yes" in tik nie.
n = 11
print("")

if result == "Yes" or result == "yes":
    for a1 in range(1, (n+1)//2 + 1): #from row 1 to 5
        for a2 in range((n+1)//2 - a1):
            print(" ", end = "")
        for a3 in range((a1*2)-1):
            print("*", end = "")
        print()
    for a1 in range((n+1)//2 + 1, n + 1): #from row 6 to 9
        for a2 in range(a1 - (n+1)//2):
            print(" ", end = "")
        for a3 in range((n+1 - a1)*2 - 1):
            print("*", end = "")
        print() #diamand

