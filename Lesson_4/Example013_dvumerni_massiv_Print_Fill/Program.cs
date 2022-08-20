// создаём двумерный массив
// [строки, столбцы]

string[,] table = new string [2,5]; //создание элемента мы указываем КОЛИЧЕСТВО!!!!!
                                    // как команда .Length
                                    // а вот индекс будет от 0
// расписываем
//                 столбец[i=0]    столбец[i=1]    столбец[i=2]    столбец[i=3]    столбец[i=4]     
//
//строка[i=0]  //  table [0,0]     table [0,1]     table [0,2]     table [0,3]     table [0,4]
//строка[i=1]      table [1,0]     table [1,1]     table [1,2]     table [1,3]     table [1,4]


table[1,2] = "слово"; //обращение к [первой строке, 2 столбцу] - в данном случае записали "слово"

for(int rows = 0; rows < 2; rows++) //цикл по строками
{
    for(int columns = 0; columns < 5; columns++) //цикл по столбцам
    {
        Console.WriteLine("-" + table[rows, columns] + "-");
    }
}

////////////////////////////////////////

void PrintArray(int[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} "); // выводим столбцы в одну строку
        }
    Console.WriteLine(); //после того, как внутренним циклом пробежались по столбцам, на новую строку
    }      
}

void FillArray(int[,] matrix)
{
    var random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}


int[,] matrix = new int [3,4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);