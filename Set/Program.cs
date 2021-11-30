using DataStructures.Collections;

Console.Title = "Работа с множествами";
Console.ForegroundColor = ConsoleColor.Green;

var setA = new ListSet<int>();
var setB = new ListSet<int>();

GeneratRandomSet(setA, setB);

while (true)
{
    StartProgram();
    Dialog();


    var listSet = new List<ListSet<int>>();
    listSet.Add(setA);
    listSet.Add(setB);

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            Add(listSet);
            break;
        case 2:
            Contains(listSet);
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
        case 9:
            break;
        case 10:
            break;
        case 11:
            break;
        case 12:
            Console.Clear();
            OutputSet(setA);
            OutputSet(setB);
            Console.ReadKey();
            Console.Clear();
            break;
        default:
            break;
    }
}

static void Add(List<ListSet<int>> set)
{
    Console.Clear();
    Console.WriteLine("Выберите множество в которое будет добавлен элемент (A или B");

    var result = int.Parse(Console.ReadLine());

    var currentSet = GetSet(set, (Set)result);

    Console.WriteLine("Введите число");

    if (currentSet.Add(int.Parse(Console.ReadLine())))
    {
        Console.WriteLine($"В множество {(Set)result} было успешно добавлен элемент\n");
        Console.Write($"Множество  {(Set)result}:");
        OutputSet(currentSet);
        ExitFromPage();
        return;
    }
    else
    {
        Console.WriteLine("Такой элемен туже есть в множестве");
        ExitFromPage();
        return;
    }
}
//2. Содержится ли элемент
static void Contains(List<ListSet<int>> set)
{
    Console.Clear();
    Console.WriteLine("Выберите множество для проверки принадлежности A или B");
    var numberSet = (Set)int.Parse(Console.ReadLine());
    var currentSet = GetSet(set, numberSet);
    Console.WriteLine("Введите число, для проверки на пренадлежность к множесту");
    var value = int.Parse(Console.ReadLine());
    if (currentSet.Contains(value))
        Console.WriteLine($"Число {value} входи в множество {numberSet }");
    else
        Console.WriteLine($"Число {value} не входи в множество {numberSet }");
    ExitFromPage();

}
//3. Удалить элементы с множества
static void Delete(List<ListSet<int>> set)
{
    Console.Clear();
    Console.WriteLine("Выберите множество из которого будут удалены элемента А или В");
    var numberSet = (Set)int.Parse(Console.ReadLine());
    var currentSet = GetSet(set, numberSet);
    Console.Clear();
    Console.Write($"Выбрали множество {numberSet}:");
    OutputSet(currentSet);
    Console.WriteLine("Введите число или коллекцию числе для удаления из множества");
    var list = new List<int>();


}
//12. Посмотреть множество
static void View(List<ListSet<int>> set)
{
    Console.Clear();
    OutputSet(set[0]);
    OutputSet(set[1]);
    ExitFromPage();
}

static ListSet<int> GetSet(List<ListSet<int>> set, Set numSet)
{
    Console.WriteLine("Выберите множество A или B");
    switch (numSet)
    {
        case Set.A:
            return set[0];
        case Set.B:
            return set[1];
    }
    return set[0];
}
static void StartProgram()
{
    Console.WriteLine("\t\t\tКонсольное приложение демонстрирующее пример работы с множествами\n\n");
    Console.WriteLine("\t\t\t\t\tВыберите дествие нам множеством");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\tПримечание: для каждого действия генерируется новое множество\n ");
    Console.ForegroundColor = ConsoleColor.Green;
}

static void Dialog()
{
    Console.WriteLine("\t\t1. Добавить элемент в множество\n" +
                      "\t\t2. Определить, содержит ли множество указаное значение\n" +
                      "\t\t3. Удалить элементы из указаного набора значений\n" +
                      "\t\t4. Вывести разность множества А и можества B\n" +
                      "\t\t5. Найти пересечения множества А и множества B\n" +
                      "\t\t6. Определить, является ли веденная коллекция подмножеством\n" +
                      "\t\t7. Определить, является ли веденная коллекция надмножеством\n" +
                      "\t\t8. Определить пересекаетется ли множество А и множество B\n" +
                      "\t\t9. Определить, содержит ли множество А одни и те же значения множества B\n" +
                      "\t\t10. Вывести симметричную разность множества А и множества В\n" +
                      "\t\t11. Объеденить множество А и множество В\n" +
                      "\t\t12. Вывести множество А и множества В");


}

static void GeneratRandomSet(ListSet<int> setA, ListSet<int> setB)
{
    var randomizer = new Random();
    for (int i = 0; i < 5; i++)
    {
        setA.Add(randomizer.Next(1, 20));
        setB.Add(randomizer.Next(1, 20));
    }
}

static void OutputSet(ListSet<int> list)
{
    Console.Write("{");
    foreach (var item in list)
    {
        Console.Write($"{item},");
    }
    Console.Write("}\n");
}
 static void ExitFromPage()
{
    Console.ReadKey();
    Console.Clear();
}

enum Set
{
    A = 1,
    B = 2
}