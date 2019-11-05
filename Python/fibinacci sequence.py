def fibonacci(n): # This is the function
    a = 0 # this is setting the funcion of 'a'
    b = 1 # this is setting the function of 'b'
    for i in range(0, n): # this is the range in i
        temp = a # this is a temporary variable, this stores the previous value for later use
        a = b # this is making the value 'a' turn into value 'b' 
        b = temp + b # this is creating the sequence so each time the next number will add to the next number in the sequence
    return a # this is setting the function
for c in range(0, 10): # this is the range in C, this is how many times the sequence will occur
    print(fibonacci(c)) #this will put the all vaulues together and display the first 15 numbers of the fibonacci sequence
