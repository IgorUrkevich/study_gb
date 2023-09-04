S = int(input("Введите сумму чисел (S): "))
P = int(input("Введите произведение чисел (P): "))

found = False  

for X in range(1, S):
    if P % X == 0:
        Y = P // X  
        if X + Y == S:
            found = True
            break

if found:
    print("Задуманные числа: X =", X, "и Y =", Y)
else:
    print("Числа X и Y не найдены")