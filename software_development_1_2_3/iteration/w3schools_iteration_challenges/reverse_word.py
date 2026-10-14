# a function that takes in a user string and reverses it


def reverse_word():
    user_word = input("Enter a word: ")
    print(user_word)

    new_word = ""
    for i in range(len(user_word) - 1, 0, -1):
        new_word += user_word[i]

    print(new_word)


reverse_word()