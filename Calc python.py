while True:
    a = input()
    if a == 'stop'  or a == 's':
        break
    else:
        a = a.split(' ')
        int1 = int(a[0])
        int2 = int(a[2])
        if a[1] == '+':
            print()
            print(int1+int2)
            print()
        elif a[1] == '-':
            print()
            print(int1-int2)
            print()
        elif a[1] == '*':
            print()
            print(int1*int2)
            print()
        elif a[1] == '/':
            print()
            print(int1/int2)
            print()
        else:
            print("Error")