print("Vraag 2.2\n")

name = input("Enter the name of an item: ")
price = float(input("Enter the item price: R "))
print("Item name: "+name)
if price <= 100:
    print("VAT amount: R "+str(round((price*(15/100)),2)))
    print("Total inc VAT: R "+str(round((price*(15/100)+price),2)))
elif price >= 101 and  249:
    print("VAT amount: R "+str(round((price*(10/100)),2)))
    print("Total inc VAT: R "+str(round((price*(10/100)+price),2)))
elif price >= 250:
    print("VAT amount: R "+str(round((price*(7.5/100)),2)))
    print("Total inc VAT: R "+str(round((price*(7.5/100)+price),2)))

name = input("Enter the name of another item: ")
price = float(input("Enter the item price: R "))
print("Item name: "+name)
if price <= 100:
    print("VAT amount: R "+str(round((price*(15/100)),2)))
    print("Total inc VAT: R "+str(round((price*(15/100)+price),2)))
elif price >= 101 and  249:
    print("VAT amount: R "+str(round((price*(10/100)),2)))
    print("Total inc VAT: R "+str(round((price*(10/100)+price),2)))
elif price >= 250:
    print("VAT amount: R "+str(round((price*(7.5/100)),2)))
    print("Total inc VAT: R "+str(round((price*(7.5/100)+price),2)))

name = input("Enter the name of another item: ")
price = float(input("Enter the item price: R "))
print("Item name: "+name)
if price <= 100:
    print("VAT amount: R "+str(round((price*(15/100)),2)))
    print("Total inc VAT: R "+str(round((price*(15/100)+price),2)))
elif price >= 101 and  249:
    print("VAT amount: R "+str(round((price*(10/100)),2)))
    print("Total inc VAT: R "+str(round((price*(10/100)+price),2)))
elif price >= 250:
    print("VAT amount: R "+str(round((price*(7.5/100)),2)))
    print("Total inc VAT: R "+str(round((price*(7.5/100)+price),2)))

