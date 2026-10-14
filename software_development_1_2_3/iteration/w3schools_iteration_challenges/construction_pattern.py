# A program that outputs a diamond triangle shape

def create_pattern():
    
    for i in range(1, 5):
        print("*" * i)

    print("*" * 5)

    for i in range(4, 0, -1):
        print("*" * i)

    

create_pattern()