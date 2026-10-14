# This file acts a library for robust user input
# --------------------------------------------------------------------


# This function displays a message prompt to the user
# Then it takes in user input, and makes it go through
# a limit check, type check and a presence check
# if it passes all, then returns the value
def get_int_input(message: str, lower_limit: int=0) -> int:
    user_input = ""
    while (True):
        try:
            user_input = input(message)
            if (len(user_input) == 0):
                print("please enter a value!")
                continue
            user_input = int(user_input)

            if (user_input <= lower_limit):
                print(f"Please enter an integer greater than {lower_limit}")
                continue

            return user_input
        except ValueError:
            print("Please enter a positive integer!")
