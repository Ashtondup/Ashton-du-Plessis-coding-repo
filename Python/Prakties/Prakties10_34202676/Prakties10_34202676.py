def Read(myList):
    count=0
    INFILE=open("Data.txt","r")
    for line in INFILE:
        myList.append(line.rstrip())
        count+=1
    INFILE.close()
    return count


def AnalyseStudents(rawList,parseList):
    try:
        for entry in rawList:
            a=entry[0:1]
            b=entry[1:2]
            c=entry[2:3]
            d=entry[3:4]
            e=entry[4:5]
            f=entry[5:6]
            g=entry[6:7]
            h=entry[7:]
            som = (a*8)+(b*7)+(c*6)+(d*5)+(e*4)+(f*3)+(g*2)+(h*1)
            result = int(som)/11
            if result==0:
                parseList.append(a+b+c+d+e+f+g+h,'is a VALID student number')
            
    except:
          print("File could not be read.")
          exit()


def Write(outlist):
    if result==0:
        OUTFILE=open("ValidNumbers.txt","a")
        for numbers in outlist:
            OUTFILE.write(data+"\n")
        OUTFILE.close()
        
    else:
        OUTFILE=open("ValidNumbers.txt","a")
        for numbers in outlist:
            OUTFILE.write(data+"\n")
        OUTFILE.close()


inputList = []
outputList = []
print("Numbers of lines read: ",Read(inputList))
print("Analysing lines from file...")
AnalyseStudents(inputList,outputList)
print("Writinf results to files..")
Write(outputList)
