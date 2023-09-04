N = int(input("Введите число N: "))

k = 0
power_of_two = 2 ** k

while power_of_two <= N:
    print((power_of_two),' - 2 в степени',(k))
    k += 1
    power_of_two = 2 ** k