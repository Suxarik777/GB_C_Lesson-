// Виды метода

// 1 вид - ничего не принимает и не возвращает

    void Method1() //сама функция
    {
        Console.WriteLine("Автор Suxarik777");
    }

    Method1(); // вызов функции



// 2 вид - ничего не возвращает но принимает
    void Method2(string msg)
    {
    Console.WriteLine(msg);
    }

    Method2(msg: "Текс сообщения"); //ИМЕНОВАННЫЙ аргумент //<аргумент>: "текст" или переменная
                                    //то есть АГНУМЕНТ: ПАРАМЕТР

// 2.1 вид - ничего не возвращает но принимает
    void Method21(string msg, int count) //например переменная текста и для счётчика
    {
        int i = 0;
        while(i < count)
        {
            Console.WriteLine(msg);
            i++;
        }

    }

    Method21("Текс сообщения", 4); //параметры четко по порядку в соответсвии через запятую
    // или
    Method21(msg: "Текс сообщения", count: 4); //хочеш по порядку
    // и даже так
    Method21(count: 4, msg: "Текс сообщения"); //а хочеш нет



//3 вид методов - ничего не принемает, но что-то возвращает

    int Method3()
    {
        return DateTime.Now.Year;  //выводит текущий год.
    }

    int year = Method3(); //то есть возвращаемое значение нужно куда-то записать
    Console.WriteLine(year);


//4 вид методов - что то принимаем и возвращаем
    string Method4(int count, string text)
    {
        string result = String.Empty; // пустая строка " "
        for(int i = 0; i < count; i++)
        {
            result = result + text;
        }
        return result;
    }

    string res = Method4(text: "qwerty", count: 10); //специально применил вариант с вызовом аргументов
    Console.WriteLine(res);
    