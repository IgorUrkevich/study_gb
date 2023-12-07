def find_indexes(arr, min_val, max_val):
    indexes = []
    for i in range(len(arr)):
        if min_val <= arr[i] <= max_val:
            indexes.append(i)
    return indexes

array = input("Введите элементы массива через пробел: ").split()
array = [int(num) for num in array]
minimum = int(input("Введите минимальное значение: "))
maximum = int(input("Введите максимальное значение: "))

result = find_indexes(array, minimum, maximum)
print(result)