// Найти пользовательское число в массиве

int[] array = { 1, 2, 31, 14, 23, 12, 3, 234 }; //объявляем одномерный массив сразу с данными
// другие варианты объявления
// int[] array = new int[8]; - задаём что в массиве 5 индексов, 5 ячеек, Но ЗНАЧЕНИЯ ПУСТЫЕ!
// int[] array = new int[]{1,2,31,14,23,12,3,234} - не указываем сколько ячеек, но перечисляем данные
// int[] array = new int[8]{1,2,31,14,23,12,3,234} - указываем и ячейки и даные

int length = array.Length; //.Length команда для вычесления длины массива

Console.Write("Введите число: ");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0;

while(index < length)
{
    if(array[index] == find)
    {
        Console.WriteLine($"Пользовательское число {find} найдено в массиве под индексом {index}");
        break; // ВНИМАНИЕ! без этой команды будут показаны все позиции требуемого числа
        // иногда это и нужно, просто не ставь тогда break
    }
    index++;
}