# Kodluyoruz_SummerChallenge2023

KODLUYORUZ YAZ CAHLLENGE

PROJELER:

Challenge 1:

*EASY : Write an algorithm to find how old the user is by taking their date of birth.

Algorithm: 

-Get year of birth from user(birthDate)

-Get input from user in which year(year)

-Find the user's age by subtracting the birthdate variable from the year variable.

-Print to screen.

*MEDIUM : Get a text from the user. You must find the most repeated letter in this text and show how many times it is repeated.

Algorithm: 

-Get a text input from the user.

-Create a dictionary (dictionary). This dictionary will store how many times each letter is repeated.

-Cycle through each character in the text:
    
    If the character is a letter:
        
        Convert it to lowercase (to ignore the difference between upper and lower case).
        
        Check the dictionary:
            
            If the character is not in the dictionary, add it to the dictionary and set the value to 1.
            
            If the character is in the dictionary, increase the value by one.

-Find the letter with the highest value in the dictionary.

-Report the result to the user.


Optional
*HARD : Construct an array of integers. In line with the target number you receive from the user, select numbers from the number sequence and add them to reach the target number.
! It is important to reach the target number with different combinations.

Challenge 2 :

*EASY : Get a number from the user and tell the user if that number is prime.

Algorithm :

-Get number input from user

-If the number is greater than 0
    
    if the number is 2
        
        print the number is prime to the screen.
    
    if the number is 1
        
        print the number is not prime to the screen.
    
    else
        
        Define count variable, equal to 2
        
        Define isPrime variable, equal to true
        
        Until count = number
            
            Divide number by count , 
                
                if equal to 0 break the loop and set isprime value to false
                
                else increase the count by one, continue the loop.
    
    if isPrime equal to the true 
        
        The number is prime number, print it to the screen.
    
    else
        
        The number is not prime number, print it to the screen.

-else
    
    Enter the new value , print it to the screen.


