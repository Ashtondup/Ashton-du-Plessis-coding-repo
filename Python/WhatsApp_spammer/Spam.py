import pyautogui as pt
import time

f = open("Spam_message.txt", "r")
time.sleep(5)
while f:
    line = f.readline()
    # message is written where the cursor is    
    pt.press("enter")
    if line == "":
        break
    
