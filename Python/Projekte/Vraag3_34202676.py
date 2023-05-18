print("Vraag3\n")

def Read(myList):
    count=0
    INFILE=open("Data.txt","r")
    for line in INFILE:
        myList.append(line.rstrip())
        count+=1
    INFILE.close()
    return count


def AnalyseCard(rawList,parseList):
    try:
        for entry in rawList:
            T=entry[0:3]
            J=entry[3:5]
            j=entry[5:7]
            M=entry[7:9]
            A=[9:10]
            R=[10:]
            if A==0:
                if T==01:
                    parseList.append(T+J+j+M+A+R+": Was issued by enRoute in 20"+J". The card expires on "j"/"M". The card is linkes to a Debit account with account number: "+A+R)
                elif T==02:
                    parseList.append(T+J+j+M+A+R+": Was issued by JCB in 20"+J". The card expires on "j"/"M". The card is linkes to a Debit account with account number: "+A+R)
                elif T==03:
                    parseList.append(T+J+j+M+A+R+": Was issued by Dinner's club in 20"+J". The card expires on "j"/"M". The card is linkes to a Debit account with account number: "+A+R)
                elif T==04:
                    parseList.append(T+J+j+M+A+R+": Was issued by Visa in 20"+J". The card expires on "j"/"M". The card is linkes to a Debit account with account number: "+A+R)
                elif T==05:
                    parseList.append(T+J+j+M+A+R+": Was issued by Master Card in 20"+J". The card expires on "j"/"M". The card is linkes to a Debit account with account number: "+A+R)
                elif T==06:
                    parseList.append(T+J+j+M+A+R+": Was issued by UnionPay in 20"+J". The card expires on "j"/"M". The card is linkes to a Debit account with account number: "+A+R)
                elif T==07:
                    parseList.append(T+J+j+M+A+R+": Was issued by Petroleum in 20"+J". The card expires on "j"/"M". The card is linkes to a Debit account with account number: "+A+R)
                elif T==08:
                    parseList.append(T+J+j+M+A+R+": Was issued by TeleCom in 20"+J". The card expires on "j"/"M". The card is linkes to a Debit account with account number: "+A+R)
                elif T==09:
                    parseList.append(T+J+j+M+A+R+": Was issued by National in 20"+J". The card expires on "j"/"M". The card is linkes to a Debit account with account number: "+A+R)
            else:
                if T==01:
                    parseList.append(T+J+j+M+A+R+": Was issued by enRoute in 20"+J". The card expires on "j"/"M". The card is linkes to a Credit account with account number: "+A+R)
                elif T==02:
                    parseList.append(T+J+j+M+A+R+": Was issued by JCB in 20"+J". The card expires on "j"/"M". The card is linkes to a Credit account with account number: "+A+R)
                elif T==03:
                    parseList.append(T+J+j+M+A+R+": Was issued by Dinner's club in 20"+J". The card expires on "j"/"M". The card is linkes to a Credit account with account number: "+A+R)
                elif T==04:
                    parseList.append(T+J+j+M+A+R+": Was issued by Visa in 20"+J". The card expires on "j"/"M". The card is linkes to a Credit account with account number: "+A+R)
                elif T==05:
                    parseList.append(T+J+j+M+A+R+": Was issued by Master Card in 20"+J". The card expires on "j"/"M". The card is linkes to a Credit account with account number: "+A+R)
                elif T==06:
                    parseList.append(T+J+j+M+A+R+": Was issued by UnionPay in 20"+J". The card expires on "j"/"M". The card is linkes to a Credit account with account number: "+A+R)
                elif T==07:
                    parseList.append(T+J+j+M+A+R+": Was issued by Petroleum in 20"+J". The card expires on "j"/"M". The card is linkes to a Credit account with account number: "+A+R)
                elif T==08:
                    parseList.append(T+J+j+M+A+R+": Was issued by TeleCom in 20"+J". The card expires on "j"/"M". The card is linkes to a Credit account with account number: "+A+R)
                elif T==09:
                    parseList.append(T+J+j+M+A+R+": Was issued by National in 20"+J". The card expires on "j"/"M". The card is linkes to a Credit account with account number: "+A+R)
            
    except:
          print("File could not be read.")
          exit()

def Write(outlist):
        OUTFILE=open("Output.txt","a")
        for numbers in outlist:
            OUTFILE.write(data+"\n")
        OUTFILE.close()
        

inputList = []
outputList = []
print("eading card numbers from file...")
print("Numbers of lines read: ",Read(inputList))
print("")
print("Analysing card numbers...")
AnalyseStudents(inputList,outputList)
print("See the output file for the extracted information")
Write(outputList)
