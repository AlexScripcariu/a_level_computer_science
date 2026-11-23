def doCheck(number):
    temp = str(number)
    max = len(temp) - 1
    total = 0
    for x in range(0, max + 1):
        total += int(temp[x])

    return total % 10

def getValues(number):
    number_result = str(doCheck(number))

    with open("storedvalues.txt", "w") as f:
        f.write(number + "\n")
        f.write(number_result + "\n")

