// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии

int M = new Random().Next(0, 49);
int N = new Random().Next(50, 99);
//int y = (M + N)*(N - M + 1)/2;
int summ = 0;

Console.Write($"Сумма числе от {M} до {N}");

void Func(){
    if (M > N){
        return;
    }
    summ = summ + M;
    M = M + 1;
    Func();
}

Func();


Console.Write($" равна {summ}");
//Console.WriteLine($"{y}");
