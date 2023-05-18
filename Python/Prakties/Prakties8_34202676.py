V1=0
V2=0
r=0

V1 = int(input("Enter decimal number to convert to base: "))
V2 = int(input("Enter base for conversion: "))
print("  ___")
print(str(V2)+"|"+ str(V1))
bs=''
while V1 !=0:
    bs=bs+str(V1%V2)
    V1=V1//V2
print("Base",str(V2),"value of 123 = ")
for i in range(len(bs)-1,-1,-1):
    print(bs[i],end='')
print(" ")

V1 = int(input("\nEnter decimal number to convert to base: "))
V2 = int(input("Enter base for conversion: "))
print("  ___")
print(str(V2)+"|"+str(V1))
bs=''
while V1 !=0:
    bs=bs+str(V1%V2)
    V1=V1//V2
print("Base "+str(V2) +" value of 123 = ")
for i in range(len(bs)-1,-1,-1):
    print(bs[i],end='')
print(" ")

V1 = int(input("\nEnter decimal number to convert to base: "))
V2 = int(input("Enter base for conversion: "))
print("   ___")
print(str(V2)+"|"+str(V1))
bs=''
while V1 !=0:
    r=str(V1%V2)
    if int(r)==10:
        bs+='A'
    elif int(r)==11:
        bs+='B'
    elif int(r)==12:
        bs+='C'
    elif int(r)==13:
        bs+='D'
    elif int(r)==14:
        bs+='E'
    elif int(r)==15:
        bs+='F'
    else:
        bs+=str(r)
    V1=V1//16
print("Base "+str(V2) +" value of 123 = ")
for i in range(len(bs)-1,-1,-1):
    print(bs[i],end='')
