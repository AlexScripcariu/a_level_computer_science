# a program that counts the number of even and odd numbers in a list

def count_even_odd(numbers):
    odd_count = 0
    
    for num in numbers:
        if (num % 2 == 1):
            odd_count += 1

    print(f"The number of even numbers: {len(numbers) - odd_count}")
    print(f"The number of odd numbers: {odd_count}")



count_even_odd([1, 2, 3, 4, 5, 6, 7, 8, 9])