Console.Write("Введите число cоответсвущее дню недели ");
int dayweek = int.Parse(Console.ReadLine());
    switch (dayweek)
    {
        case (1):
        Console.WriteLine("День недели понедельник");
        break;
        case (2):
        Console.WriteLine("День недели вторник");
        break;
        case (3):
        Console.WriteLine("День недели среда");
        break;
        case (4):
        Console.WriteLine("День недели четверг");
        break;
        case (5):
        Console.WriteLine("День недели пятница");
        break;
        case (6):
        Console.WriteLine("День недели суббота");
        break;
        case (7):
        Console.WriteLine("День недели воскресенье");
        break;
        default:
        Console.WriteLine("Ошибка:введите число от 1 до 7");
        break;
    }
    