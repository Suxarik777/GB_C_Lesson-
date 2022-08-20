//Фибоначчи - каждое следующее число задаётся через предыдущее
//1 1 2 3 5 8 13 21


// //просто цикл
// int n = 10946;
// int fibon1 = 0;
// int fibon2 = 1;
// Console.Write("0 1" + " ");
// while (fibon2 <= n - fibon1)
// {
// int temp = fibon2;
// fibon2 = fibon2 + fibon1;
// fibon1 = temp;
// Console.Write(fibon2 + " ");
// }

// ///////////////////////////////

// //через массив
// int[] fibonacci = new int[1000];
// fibonacci[0] = 1;
// fibonacci[1] = 1;
// int n = int.Parse(Console.ReadLine() ?? "0");
// Console.Write($"{fibonacci[0]} {fibonacci[1]} ");
// int index = 1;
// while(fibonacci[index]<n)
// {
//     index++;
//     fibonacci[index]=fibonacci[index-1]+fibonacci[index-2];
//     if(fibonacci[index]<n)
//         Console.Write($"{fibonacci[index]} ");
// }

/////////////////////////

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n - 2);
}

int numberFibo = 10;
for(int i = 1; i < numberFibo; i++)
{
    Console.WriteLine(Fibonacci(i));
}