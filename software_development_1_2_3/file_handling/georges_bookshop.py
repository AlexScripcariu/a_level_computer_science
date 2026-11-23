def salesAnalysis():
    total_days = 0
    total_sales = 0
    with open("Sales.txt", "r") as f:
        line = f.readline()
        while (line):
            total_days += 1
            total_sales += float(line)
            line = f.readline()

    total_average = total_sales / total_days
    print(total_average)