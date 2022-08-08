// Создать и заполнить массив при помощи фнукции
// + находим требуемый элемент в массиве


//создаём метод для заполнения массива
void FillArray(int[] array) // принимаемый аргумент можно назвать по разному array сейчас для удобства
{
    int length = array.Length; //записываем в придуманную переменную длину массива при помощи .Length
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(1,10);
        index++;
    }
}

//пшем функцию печати массива (вывода на экран элементов)
void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0; 
    while(index < length)
    {
        Console.WriteLine(array[index]);
        index++;
    }
}

int IndexOf(int[] array, int find)
{
    int length = array.Length;
    int index = 0;
    int positionArray = -1; //переменная в которую мы сохраним позицию
                            // индекс требуемого числа
                            // кладём сюда -1 чтобы если числа нет был не 0
                            // (потому что 0 это вообщето первый элемент массива по индексу)

    while(index < length)
    {
        if(array[index] == find)
        {
            positionArray = index; //мы в переменую позиции записываем наш index
            break; //при помощи этого оператора мы найдя нужную нам позицию тормозим работу функции
                //в противном случае без этого оператора фнкция будет работать по всему массиву
                //и в итоге в переменную запишется индекс-позиция последнего элемента
        }
        index++;
    }
    return positionArray;
}



int[] array = new int[10]; 


FillArray(array); //вызываем функцию(метод) и отправляем туда параментр наш массив с 10 ячеками
PrintArray(array); //отправляем наш массив на печать (параметр массив)

Console.WriteLine(); //пустая строчка для удобства

Console.Write("Введите число индекс которого мы будем искать по массиву: ");
int find = Convert.ToInt32(Console.ReadLine());

int posIndex = IndexOf(array, find); //в переменную позицию индексв = записываем
                                    // функцию которая ищет позицию числа которую мы ищем.

Console.WriteLine($"Индекс позиции числа {find} в массиве: {posIndex}");