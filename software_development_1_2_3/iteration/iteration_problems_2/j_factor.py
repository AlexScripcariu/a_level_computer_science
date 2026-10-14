#Program that outputs if a number between 1-10 (inclusive) is a factor
# of some inputted number
from input_lib import get_int_input

# this function goes through the numbers 1-10 and outputs if the
# inputted number divides it (via iteration)
def output_divisors(user_number: int) -> None:
    for i in range(1, 11):
        if (user_number % i == 0):
            print(f"{user_number} is a multiple of {i}")
        else:
            print(f"{user_number} is not a mutlitple of {i}")


# Main function of the program
def main():
    user_number = get_int_input("Enter a positive number: ")

    # output result to console
    output_divisors(user_number)


# call the function
main()