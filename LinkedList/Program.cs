using LinkedList;

var linkedList = new DataStructures.Collections.LinkedList<Student>();
linkedList.Add(new Student(1, "Денис", "Сигида", Convert.ToDateTime("13.06.2002")));
linkedList.Add(new Student(2, "Влад", "Поталаха", Convert.ToDateTime("13.06.2002")));
linkedList.Add(new Student(3, "Миша", "Редько", Convert.ToDateTime("13.06.2002")));

while (true)
{
    Console.Clear();
    Console.WriteLine("Выберите запрос которые хотите осуществить");
    Console.WriteLine("1. Добавить студента в список\n 2. Вывести количество студентов в списке\n 3. Запрос на поиск студента в списке\n 4. Вывести всех студентов");

    var requestNumber = int.Parse(Console.ReadLine());

    switch (requestNumber)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Введите Имя студента");
            var name = Console.ReadLine();

            Console.WriteLine("Введите Фамилию студента");
            var surname = Console.ReadLine();

            Console.WriteLine("Введите год рождения");
            var birthday = Console.ReadLine();

            linkedList.Add(new Student(linkedList.Count + 1, name, surname, Convert.ToDateTime(birthday)));

            Console.ReadKey();
            continue;
        case 2:
            Console.Clear();
            Console.WriteLine($"Количество элементов в списке = {linkedList.Count}");
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine($"Введите ID студента для поиска");
            var id = Console.ReadLine();

            foreach (var item in linkedList)
            {
                if (item.ToString().StartsWith(id))
                    Console.WriteLine(item);
            }

            Console.ReadKey();
            break;
        case 4:
            Console.Clear();
            if (linkedList != null)
            {
                foreach (var item in linkedList)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("В списке нету студентов");
            Console.ReadKey();
            continue;
        default:
            break;
    }
}
