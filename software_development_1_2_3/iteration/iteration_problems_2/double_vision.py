# This program takes in an integer and multiplies it by 3 (and again) 
# 5 times
from input_lib import get_int_input

# Outputs number doulbed + number (* 3)
def output_doubles(start: int) -> None:
    # Output 3 ^ i * start 6 times
    power_of_3 = 1

    for i in range(0, 6):
        print(start * power_of_3)
        power_of_3 *= 3



# Main function of the program
def main():
    start_number =  get_int_input("Enter the starting number: ")

    # print result
    output_doubles(start_number)


main()