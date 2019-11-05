import random
# write answers
present1=”pony”
present2=”BMX bike”
present3=”lots and lots of sweets”
present4=”puppy”
present5=”socks”
present6=”chocolate”
present7=”new laptop”
present8=”Raspberry Pi”
print(“Welcome to my birthday Present Gift Suggestion Program!”)
# get the users question
name = input(“Input a name and I will generate the ideal present for them --- the press ENTER to get me thinking.\n”)
print(“thinking …\n” * 4)
# use the randint() function to select the correct answer
choice=random.randint(1, 8)
if choice==1:
	answer=present1
elif choice==2:
	answer=present2
elif choice==3:
	answer=present3
elif choice==4:
	answer=present4
elif choice==5:
	answer=present5
elif choice==6:
	answer=present6
elif choice==7:
	answer=present7
else: 
	answer=present8
# print the answer to the screen
print(”I would get”, name, ”a”, answer, ”for their birthday”)
input(“\n\nPress the ENTER key to finish.”)
