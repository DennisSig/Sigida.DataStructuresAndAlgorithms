using DataStructures.Collections;

while (true)
{
    Console.WriteLine("Выберите операцию над векторами\n" +
        "1. Сравнение векторов\n" +
        "2. Сложение двух векторов\n" +
        "3. Вычитание двух векторов\n" +
        "4. Скалярное произведение\n" +
        "5. Умножение на скаляр");

    var vector1 = new Vector(x: 2, y: 3);
    var vector2 = new Vector(x: 2, y: 3);

    Console.Write(">");
    int reques = int.Parse(Console.ReadLine());

    Console.Clear();
    switch (reques)
    {
        case 1:
            Console.WriteLine(vector1 == vector2);
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            Console.WriteLine(vector1 + vector2);
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.WriteLine(vector1 - vector2);
            Console.ReadKey();
            Console.Clear();
            break;
        case 4:
            Console.WriteLine(vector1 * vector2);
            Console.ReadKey();
            Console.Clear();
            break;
        case 5:
            Console.Write("Введите скаляр\n>");
            float.TryParse(Console.ReadLine(), out float scalar);
            Console.WriteLine(vector1 * scalar);
            Console.ReadKey();
            Console.Clear();
            break;

    }
}




