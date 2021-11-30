
using DataStructures.Collections;

BinaryTree<string>? tree = new BinaryTree<string>();

#region Заполнение дерева 

tree.Add("20. Добрый день, вам пакет нужен?");
tree.Add("15. Вам большой пакет?");
tree.Add("14. Спасибо за покупку, приходите еще");
tree.Add("18. Маленький?");
tree.Add("17. Спасибо за покупку");
tree.Add("18. Хорошего вам дня");
tree.Add("30. У вас есть карточка нашего магазина?");
tree.Add("21. Вам скидка 5% спасибо за покупку");
tree.Add("31. Вы сотый покупатель, вам скидка 20%, спасибо за покупку");

#endregion
var current = tree.Root;
var listRes = new List<string>();


while (current != null)
{
    if (current.Left == null && current.Right == null)
    {
        Say(current.Data.Substring(4));
        break;
    }

    Say(current.Data.Substring(4));
    Console.Write("Покупатель (Вы): ");
    var res = Console.ReadLine();

    if (res == "Да")
        current = current.Left;
    if (res == "Нет")
        current = current.Right;

    listRes.Add(res);
}

Console.WriteLine("Пользователь отвечал");

foreach (var item in listRes)
{
    Console.Write($"{item}:");
}

static void Say(string phrase)
{
    Console.WriteLine($"Кассир: {phrase}");
}

enum DialogRes
{
    No = 0,
    Yes = 1
}

