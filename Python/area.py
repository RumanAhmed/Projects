def basearea(r): # this is the funcation basearea
    pi=3.1459 #this is and input to show what value of pi is
    area=pi*r**2 #this is an input which will calculate to show what the value of area will be
    print(area) # this will print the area
    print(pi) # this will print pi
    print(r) #this will print the radius
    print(area, ' = ', pi, '*', r , '** 2') # this puts all the values together to calculate the solution to find the radius
    
r =int(input('Enter a radius')) #This enters a value in to r

basearea(r) # this calls the function basearea passing value of r
