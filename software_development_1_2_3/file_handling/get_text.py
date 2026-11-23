def getText(file_name):
    text = ""
    with open(file_name + ".txt", "r") as f:
        text = f.readline()

    return text 

def fullStop():
    file_name = input("Please enter the file name: " )

    line = getText(file_name)

    after_full_stop = False

    for letter in line:
        if letter == "." and not after_full_stop:
            after_full_stop = True
        elif after_full_stop and (letter.isalpha()):
            letter = letter.upper()

    with open(file_name + ".txt", "w") as f:
        f.write(line + "\n")
