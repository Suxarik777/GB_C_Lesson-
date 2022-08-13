// Алгоритм сортировки методом выбора
// или Алгоритм сортировки методом min и Max
// или выбором максимального или выбором минимального

// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные
// элементы

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}

int[] MinToMaxSelectionSort(int[] array) //от минимального к максимальному
{
    for (int i = 0; i < array.Length - 1; i++) //ВКЛЮЧАЙ МОЗГ .Length - 1 ставим, чтобы внутренний цикл не выскочил за пределы так как там j + 1
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++) //чтобы счёлкать дальше по массиву не касаясь отсортированого
        {
            if (array[j] < array[minPosition]) minPosition = j; //сохраняем именно индекс, чтобы потом по нему вызывать данные
        }
        int help = array[i];                //пузырьковая замена или swap
        array[i] = array[minPosition];
        array[minPosition] = help;
    }
    return array;
}

int[] MaxToMinSelectionSort(int[] array) // от максимального к минимальному
{
    for (int index = 0; index < array.Length - 1; index++)
    {
        int maxPosition = index;

        for (int j = index + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int help = array[index];
        array[index] = array[maxPosition];
        array[maxPosition] = help;
    }
    return array;
}

int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
PrintArray(array);

int[] minMaxArraySelection = MinToMaxSelectionSort(array);
PrintArray(minMaxArraySelection);

int[] maxMinArraySelection = MaxToMinSelectionSort(array);
PrintArray(maxMinArraySelection);