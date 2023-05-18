print("Vraag1.2\n")

message = str(input("Enter a messade: "))
n = int(input("Enter the distance value: "))
encrypted = ""

for letter in message:
    encrypted += chr(ord(letter) + n)

print("The encoded message is: " +encrypted)
