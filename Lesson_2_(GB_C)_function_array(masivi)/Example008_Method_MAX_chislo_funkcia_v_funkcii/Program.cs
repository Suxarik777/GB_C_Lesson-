// Записываем стихийный код без функции, сравниваем числа 
// первый стихийный вариант, где тупо перебираем закоментирован (смотри внизу)
// второй вариант через функцию реализован

//функция возвращает тип данных int называется Max 
//(принимает три аргумента, тип данных int "придумываем название")
int MaxFunction(int arg1, int arg2, int arg3)
{
    int resultMax = arg1;
    if(arg2 > resultMax)
    {
        resultMax = arg2;
    }
    if(arg3 > resultMax)
    {
        resultMax = arg3;
    }
    return resultMax;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 12;
int b2 = 23123234;
int c2 = 33;

int a3 = 13;
int b3 = 23;
int c3 = 313;

//у нас есть функция которая может посчитать большее из трех чисел
// ищем максимальное 


/*
//отправляем в скобочках три параметра (число в переменной a1, b1...)
int max1 = MaxFunction(a1,b1,c1); 
//то есть мы в переменную max1 кладём функцию которая нам считает большее из трёх чисел
int max2 = MaxFunction(a2,b2,c2);
int max3 = MaxFunction(a3,b3,c3);

//ну и имея три максимальных числа, устраиваем финал
int max = MaxFunction(max1, max2, max3);
*/


//можно пойти ещё дальше и забабахать функцию в функции
//тоесть внутри функции (впараметрах передать также запускаемую функцию со своими параметрами)
int max = MaxFunction(
    MaxFunction(a1, b1, c1), 
    MaxFunction(a2, b2, c1), 
    MaxFunction(a3, b3, c3));
Console.WriteLine(max);

/*
int max = a1;
if(b1 > max)
{
    max = b1;
}
if(c1 > max)
{
    max = c1;
}

if(a2 > max)
{
    max = a2;
}
if(b2 > max)
{
    max = b2;
}
if(c2 > max)
{
    max = c2;
}

if(a3 > max)
{
    max = a3;
}
if(b3 > max)
{
    max = b3;
}
if(c3 > max)
{
    max = c3;
}

Console.WriteLine(max);
*/