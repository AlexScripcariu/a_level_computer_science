from random import randint
# A program that simulates the game of blackjack.


def card_score(card_set: set[int]):
    # first gen the random suit
    suit = randint(1, 4)
    # generate number
    number = randint(1, 13)

    while (number in card_set[suit]):
        suit = randint(1, 4)
        number = randint(1, 13)

    # By now, we have generated a new card not previously picked
    # Add it to its respective set, and return the score of the card.
    card_set[suit].add(number)

    if (number == 1):
        return 11
    return max(10, number)


        

# This function repeatedly asks the user to keep picking a card
# It outputs the user score after each pick and the card that was selected
def get_score(): 
    score = 0

    cards_picked = [{}, {}, {}, {}]

    while (score < 21):
        # Ask user to keep picking cards
        keep_playing = input("Press enter to pick a card, anything else to stop: ")

        # Check input, determine if should exit
        if (keep_playing != ""):
            break

        # This means user wants to take card, so try to take a card not already picked
        # keep a set for each suit, if the number is in that set, then pick again
        score += card_score(cards_picked)

    return score


# Function that handles main gameplay
def play_game():
    game_num = 1

    while True:
        # Loop to start game
        print(f"Game {game_num}")
        print("-" * 20)

        user_score = get_score()
        computer_score = get_cpu_score()

        # Code below will handle the end game logic/ processing results




def main():
    while True:
        print("-" * 20)
        continue_playing = input("Type in N/n to stop playing, anything else to continue: ")
        if (continue_playing.lower() == "n"):
            print("Thank you for playing!")
            break
        print("-" * 20)
        play_game()



main()