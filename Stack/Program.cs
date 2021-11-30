using DataStructures.Collections;

var array = CreateArrayView();

Console.Clear();

while (true)
{
    Console.Clear();
    int request = default;

    Console.WriteLine("Запросы:\n" +
    "1. Инвертировать вектор\n" +
    "2. Создать новый массив векторов\n" +
    "3. Выход из приложения\n");

    Console.WriteLine("Введите номер запроса");
    request = int.Parse(Console.ReadLine());

    switch (request)
    {
        case 1:
            Console.Clear();
            Array.Reverse(array);
            var stack = new ArrayStack<int>(array.Length, array);
            Console.Write("Развернутый вектор {");
            foreach (var item in stack.GetArray())
            {
                Console.Write($"{item};");
            }
            Console.Write("}");
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            array = CreateArrayView();
            stack = new ArrayStack<int>(array.Length, array);
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            break;
    }
}

static int[] CreateArrayView()
{
    Console.WriteLine("Введите размер массива вектора");
    var size = int.Parse(Console.ReadLine());
    Console.WriteLine($"Введите вектор размеров в {size} единиц");
    var data = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        data[i] = int.Parse(Console.ReadLine());
    }

    Console.Clear();
    Console.Write("Был успешно записан массив {");

    foreach (var item in data)
    {
        Console.Write($"{item};");
    }

    Console.Write("}");

    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите любую клавишу");
    Console.ReadKey();

    return data;
}