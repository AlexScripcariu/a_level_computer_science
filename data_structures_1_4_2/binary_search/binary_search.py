numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

l = 0
r = len(numbers) - 1
target = 8

while (l <= r):
    midpoint = (l + r) / 2

    if (numbers[midpoint] == 8): 
        print(midpoint)
        break
    elif (target > numbers[midpoint]):
        l = midpoint + 1
    else:
        r = midpoint - 1

    