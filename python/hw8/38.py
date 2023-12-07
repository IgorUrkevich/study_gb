def load_contacts(filename):
    contacts = []
    try:
        with open(filename, 'r', encoding='utf-8') as file:
            for line in file:
                contact = line.strip().split(',')
                contacts.append(contact)
    except FileNotFoundError:
        print("Файл не найден!")
    return contacts

def save_contacts(filename, contacts):
    try:
        with open(filename, 'w') as file:
            for contact in contacts:
                line = ','.join(contact)
                file.write(line + '\n')
        print("Контакты сохранены в файле.")
    except IOError:
        print("Ошибка при сохранении контактов!")

def display_contacts(contacts):
    if len(contacts) == 0:
        print("Нет контактов для отображения.")
    else:
        for contact in contacts:
            print("Фамилия: {}\nИмя: {}\nОтчество: {}\nНомер телефона: {}\n".format(*contact))

def search_contacts(contacts, keyword):
    found_contacts = []
    for contact in contacts:
        if keyword in contact:
            found_contacts.append(contact)
    return found_contacts

def update_contact(contacts, keyword):
    found_contacts = search_contacts(contacts, keyword)
    if len(found_contacts) == 0:
        print("Контакт не найден.")
    elif len(found_contacts) == 1:
        contact = found_contacts[0]
        print("Найден контакт:")
        print("Фамилия: {}\nИмя: {}\nОтчество: {}\nНомер телефона: {}\n".format(*contact))
        choice = input("Выберите действие:\n1. Изменить контакт\n2. Удалить контакт\n3. Отмена\n")
        if choice == "1":
            new_contact = input("Введите новые данные контакта в формате 'Фамилия,Имя,Отчество,Номер телефона': ")
            contacts.remove(contact)
            contacts.append(new_contact.split(','))
            print("Контакт успешно изменен.")
        elif choice == "2":
            contacts.remove(contact)
            print("Контакт успешно удален.")
        elif choice == "3":
            print("Отмена.")
        else:
            print("Неверный выбор. Попробуйте еще раз.")
    else:
        print("Найдено несколько контактов. Уточните запрос.")

# Пример использования функций
filename = "contacts.txt"
contacts = load_contacts(filename)

while True:
    print("1. Вывести все контакты")
    print("2. Сохранить контакты в файл")
    print("3. Поиск контактов по имени, фамилии или номеру телефона")
    print("4. Изменить или удалить контакт")
    print("5. Выход")
    choice = input("Выберите действие: ")

    if choice == "1":
        display_contacts(contacts)
    elif choice == "2":
        save_contacts(filename, contacts)
    elif choice == "3":
        keyword = input("Введите ключевое слово для поиска: ")
        found_contacts = search_contacts(contacts, keyword)
        display_contacts(found_contacts)
    elif choice == "4":
        keyword = input("Введите имя или фамилию контакта для изменения или удаления: ")
        update_contact(contacts, keyword)
    elif choice == "5":
        break
    else:
        print("Неверный выбор. Попробуйте еще раз.")