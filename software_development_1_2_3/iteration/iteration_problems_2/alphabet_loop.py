import input_lib
# Prints all letters of the alphabet

ALPHABET = "ABCDEFGHJIKLMNOPQRSTUVWXYZ" # constant

# print out each letter of alphabet on a new line via iteration
def loop_alphabet() -> None:
    for letter in ALPHABET:
        print(letter)


def get_index() -> int:
    user_input = -1

    # keep looping until valid index range
    while not (0 <= user_input < 26):
        user_input = input_lib.get_int_input("Enter the index of the letter that you want to print: ", -1)

    return user_input

# This function returns the letter at the given index
def get_letter(index: int) -> str:
    return  ALPHABET[index]


# main function of the program
def main():
    # Call the procedure to output each letter of the alphabet
    loop_alphabet()

    letter_idx = get_index()

    letter = get_letter(letter_idx)

    print(f"At {letter_idx}, that is the letter {letter}")



main()