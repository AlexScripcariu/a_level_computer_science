# A program that outputs all multiples of 35 between 1500, 2700 (inclusive)

def get_multples_of_35():
    multiples_of_35 = []
    
    for num in range(1500, 2701):
        if num % 35 == 0:
            multiples_of_35.append(num)
            print(num)


get_multiples_of_35()


    