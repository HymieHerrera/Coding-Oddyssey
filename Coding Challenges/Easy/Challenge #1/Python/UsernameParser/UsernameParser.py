import datetime

loggedtimestamp = datetime.datetime.now()

#Prompt user for name, age, and github username.  Setting them as variables to reference later
name = input("What is your name?\n")
print()
age = int(input("What is your age?\n"))
print()
username = input("What is your github username?\n")
print()

#Logs variables to csv file.  Might want to expand later using a SQlite database instead.
with open("userlog.csv", "a+") as userlog:
    userlog.write(f"{name},{age},{username},{loggedtimestamp}\n")

#Outputs the user's name, age, and github username in the predefined format.
print(f"your name is {name}, you are {age} years old, and your username is {username}")
