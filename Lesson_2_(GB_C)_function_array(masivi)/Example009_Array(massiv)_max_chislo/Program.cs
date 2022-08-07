// поиск максимального числа в массиве

// в начале пропишем варианты объявления массива
// int[] array = { 0, 0, 0, 0, 0 } - задаём данные
// int[] array = new int[5]; - задаём что в массиве 5 индексов, 5 ячеек
// int[] array = new int[]{ 0, 0, 0, 0, 0 } - не указываем сколько ячеек, но перечисляем данные
// int[] array = new int[5]{ 1, 0, 2, 0, 3 } - указываем и ячейки и даные

int MaxFunction(int arg1, int arg2, int arg3)
{
    int resultMax = arg1;
    if (arg2 > resultMax)
    {
        resultMax = arg2;
    }
    if (arg3 > resultMax)
    {
        resultMax = arg3;
    }
    return resultMax;
}

int[] array = { 11, 232, 23, 564, 55, 62, 71, 84, 93 };
array[0] = 12; //ячейки 0 присвоить новое данное 12
Console.WriteLine(array[0]); // так обращаемся к массиву чтобы получить данные 0 ячейки

// как запустить функцию?
// например пойти по пути предыдущего примера функции функции
int max = MaxFunction(
    MaxFunction(array[0], array[1], array[2]), 
    MaxFunction(array[3], array[4], array[5]), 
    MaxFunction(array[6], array[7], array[8]));
Console.WriteLine(max);

//в общем то в таком решении много проблем, но разбор будет позже