import input_lib

# this procedure takes in a word and an integer, and repeats that word
# that many time
def repeat_word(word: str, rep: int) -> None:
    print((word + '\n') * rep)


# main function of the program
def main():
    user_word = input("Enter a word to repeat: ")
    times = input_lib.get_int_input("How many times do you want to repeat it?: ", 0)

    repeat_word(user_word, times)


main()