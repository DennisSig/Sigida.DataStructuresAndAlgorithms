using DataStructures.Collections;
using DoublyLinkedList.Controller;
using DoublyLinkedList.Model;

var busDepot = new DepotController(new Depot("ЛугАвто"));

//Инициализация объектов в депо 
busDepot.AddBus(new Bus(1, $"Денис Петрович", 104));
busDepot.AddBus(new Bus(2, $"Михаил Круг", 156));
busDepot.AddBus(new Bus(3, $"Роберт Ловкович", 104));
busDepot.AddBus(new Bus(4, $"Влад Поталахич", 104));
busDepot.AddBus(new Bus(5, $"Вова Титков", 104));

while (true)
{
    #region
    Console.WriteLine("\t\t\t\tДобро пожаловать в систему управленяи транспортом\n" +
    $"\t\t\t\t\t\tКомпания ЛугАвто");
    Console.WriteLine("");
    Console.WriteLine("\t\t\t\tДоступные запросы");
    Console.WriteLine("\t\t\t\t1. Добавить новый автобус в парк\n" +
        "\t\t\t\t2. Поиск автобуса в списке по ID\n" +
        "\t\t\t\t3. Отправить автобус на маршрут\n" +
        "\t\t\t\t4. Вернуть автобус в парк\n" +
        "\t\t\t\t5. Вывести список автобусов в парке\n" +
        "\t\t\t\t6. Вывести список автобусов на маршруте\n" +
        "\t\t\t\t7. Вывести информацию о всех автобусах\n");
    #endregion Меню

    Console.WriteLine("");
    Console.WriteLine("\t\t\t\tВведите номер запроса");

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            Console.Clear();
            try
            {
                Console.WriteLine("\t\t\t\tВведите ID автобуса");
                var busId = int.Parse(Console.ReadLine());
                Console.WriteLine("\t\t\t\tВведите ФИО водителя");
                var fullName = Console.ReadLine();
                Console.WriteLine("\t\t\t\tВведите номер маршрута");
                var routeId = int.Parse(Console.ReadLine());

                Console.Clear();
                busDepot.AddBus(new Bus(busId, fullName, routeId));
                Console.WriteLine("Новый водитель успешно добавлен ");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверные данные");
            }
            break;
        case 2:
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("\t\t\t\tВведите ID автобуса который будет отправлен на маршрут");
            try
            {
                busDepot.TransferTheBusToTheRoute(int.Parse(Console.ReadLine()));

                Console.Clear();
                Console.WriteLine("Автобус успешно отправлен");
            }
            catch (Exception)
            {
                throw;
            }
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("\t\t\t\tВведите ID автобуса который требуется вернуть в парк");
            try
            {
                busDepot.TransferTheBusToDepot(int.Parse(Console.ReadLine()));

                Console.Clear();
                Console.WriteLine("Автобус успешно отправлен");
            }
            catch (Exception)
            {
                throw;
            }
            break;
        case 5:
            Console.Clear();
            OutputData(busDepot.InfoAboutBusesAtTheDepo);
            Console.ReadLine();
            Console.Clear();
            break;
        case 6:
            Console.Clear();
            OutputData(busDepot.InfoAboutBusesOnTheRoute);
            Console.ReadLine();
            Console.Clear();
            break;
        case 7:
            Console.Clear();
            OutputData(busDepot.InfoAboutBusesAtTheDepo);
            OutputData(busDepot.InfoAboutBusesOnTheRoute);
            Console.ReadLine();
            Console.Clear();
            break;
    }
}

static void OutputData(DoublyLinkedList<Bus> obj)
{
    foreach (var item in obj)
    {
        Console.WriteLine(item);
    }
}