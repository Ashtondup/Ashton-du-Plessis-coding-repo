import pyautogui as pt
import time

limit = input("Enter the limit: ")
message = input("Enter message to spam: ")
i = 0
time.sleep(10)

while i < int(limit):
    pt.typewrite(message)
    # message is written where the cursor is    
    pt.press("enter")
    
    i+=1