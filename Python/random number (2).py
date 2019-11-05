import random # this is importing the random function that the code will perform

print("What is your name?")# this will print what is written within the brackets

myname = input()#This allows the user to input their name when prompted

print("Hello " + myname + " nice to meet you.")# this will print hello and the name the user has inputed in the previous prompt

print(myname + ',' + ' I am thinking of a number between 1 and 50.')# this will print what is within the brackets

mynum=random.randint(1,50) # i am setting the funtion of 'mynum',this is the input used to generate the random number, the computer will chose a number from 1 to 50

t =int (input("Take a guess and enter a number between 1 and 50 - "))# This will ask a question and command the user to enter a value

print (mynum)# this puts the values together to generate and print a random number

mylives = int(10)# This is setting the function for 'mylives', it now has a value of 10
while mylives > 0:# 
    if t > mynum:
        print('The number is higher')# this will print waht is in the brackets
        print('Number of lives remaining:', mylives)
        mylives = (mylives - 1)# This is the code which deducts a live by minusing 1 from 10 each time you get the answer wrong
        print('Take another guess')# this will print what is in the brackets
        mynum = input()# this code allows the user to enter another number
        mynum = int(mynum)# this code will take the number that the user input and try to match it up with the number the computer is guessing
    elif t < mynum:
        print('The number is lower')
        print('Number of lives remaining:', mylives)
        mylives = (mylives - 1)# this will deduct a life from the 10 lives if the answer is incorrect
        print('Take another guess')
        mynum = input() # The user can reenter a number
        mynum = int(mynum) # this code will take the number that the user input and try to match it up with the number that the computer is guessing
    if t == mynum:
        print('Correct ' + myname + '!') # this will print the text in the brackets
      
