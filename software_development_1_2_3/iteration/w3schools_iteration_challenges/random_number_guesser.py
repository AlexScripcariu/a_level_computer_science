# A game that keeps asking a user to guess a number between 1-9 until they guess it
import random

def guessing_game():
    chosen_number = random.randint(1, 9)

    while True:
        user_choice = 0

        while True:
            try:
                user_choice = int(input("A number between 1-9 was chosen. Guess: "))
                break
            except ValueError:
                print("Please enter an integer!")

        if (user_choise == chosen_number): 
            print("Well guessed!")
            return
    

