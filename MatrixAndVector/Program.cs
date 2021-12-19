using DataStructures.Collections;

while (true)
{
    Console.WriteLine("Выберите действие над матрицей");
    Console.WriteLine("1. Сложение\n" +
        "2.Вычитание\n" +
        "3.Умножение\n" +
        "4. Деление\n");

    Console.Write(">");
    int reques = int.Parse(Console.ReadLine());

    Console.Clear();
    switch (reques)
    {
        case 1:
            Console.WriteLine("Первая матрица");
            var matrix1 = Matrix.Create(3, 3, SpecialMatrix.RandomUnit);
            OutMatrix(matrix1);
            Console.WriteLine("Вторая матрица");
            var matrix2 = Matrix.Create(3, 3, SpecialMatrix.RandomUnit);
            OutMatrix(matrix2);
            var matrix3 = matrix1 + matrix2;
            Console.WriteLine("Результат сложения");
            OutMatrix(matrix3);
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            Console.WriteLine("Первая матрица");
            matrix1 = Matrix.Create(3, 3, SpecialMatrix.RandomUnit);
            OutMatrix(matrix1);
            Console.WriteLine("Вторая матрица");
            matrix2 = Matrix.Create(3, 3, SpecialMatrix.RandomUnit);
            OutMatrix(matrix2);
            matrix3 = matrix1 - matrix2;
            Console.WriteLine("Результат вычитания");
            OutMatrix(matrix3);
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("Первая матрица");
            matrix1 = Matrix.Create(3, 3, SpecialMatrix.RandomUnit);
            OutMatrix(matrix1);
            Console.WriteLine("Вторая матрица");
            matrix2 = Matrix.Create(3, 3, SpecialMatrix.RandomUnit);
            OutMatrix(matrix2);
            matrix3 = matrix1 * matrix2;
            Console.WriteLine("Результат умножения");
            OutMatrix(matrix3);
            Console.ReadKey();
            Console.Clear();
            break;
        case 4:
            Console.WriteLine("Первая матрица");
            matrix1 = Matrix.Create(3, 3, SpecialMatrix.RandomUnit);
            OutMatrix(matrix1);
            Console.WriteLine("Вторая матрица");
            matrix2 = Matrix.Create(3, 3, SpecialMatrix.RandomUnit);
            OutMatrix(matrix2);
            matrix3 = matrix1 / matrix2;
            Console.WriteLine("Результат деления");
            OutMatrix(matrix3);
            Console.ReadKey();
            Console.Clear();
            break;

    }
}


static void OutMatrix(Matrix matrix)
{
    for (int i = 0; i < matrix.RowCount; i++)
    {
        Console.Write("{");
        for (int j = 0; j < matrix.ColumnCount; j++)
        {

            Console.Write($" {matrix[i, j]} ");
        }
        Console.Write("}");
        Console.WriteLine("");
    }
}


