var queue = new DataStructures.Collections.Queue<char>();
var stack = new DataStructures.Collections.Stack<char>();

while (true)
{
    Console.Clear();
    Console.WriteLine("Выберите запрос которые хотите осуществить");
    Console.WriteLine("1. Ввод слова для проверка\n " +
       "2. Выход с приложения");


    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Введите слово");
            var input = Console.ReadLine();

            var array = input.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                queue.Enqueue(array[i]);
                stack.Push(array[i]);
            }


            while (queue.IsEmpty)
            {
                if (queue.Front.Data == stack.Top.Data)
                {
                    queue.Dequeue();
                    stack.Pop();
                    continue;
                }
                else
                {
                    Console.WriteLine($"Буква {queue.Front.Data} и {stack.Top.Data} не равны, слово не палиндром");
                    break;
                }
            }

            if (!queue.IsEmpty)
                Console.WriteLine($"Словов '{input}' палиндром");

            queue.Clear();
            stack.Clear();
            Console.ReadKey();

            break;
        case 2:
            Environment.Exit(0);
            break;

    }
}