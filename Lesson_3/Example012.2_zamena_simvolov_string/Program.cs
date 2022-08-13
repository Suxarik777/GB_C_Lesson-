// // Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие пруского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// как обратится к строке
// streing s = "qwerty"     если нам требуется оплатится к позиции в строке,
//              012         нам достаточно отсчитать и обратится цифрами
// s[3]   // вот таким образом мы получим конкретную букву 'r' в строке в переменной s

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //команда пустой строки
    int lenght = text.Length; //получаем длинну строки

    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К'); //заподрядное перечисление
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text: newText,  oldValue: 'С', newValue: 'с'); //присвоения данных конкретным аргументам
Console.WriteLine(newText);