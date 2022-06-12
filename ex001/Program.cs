// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int M = new Random().Next(0, 49);
int N = new Random().Next(50, 99);

Console.WriteLine($"Четные числа в промежутке от {M} до {N}: ");

void Func(){
    if (M%2 == 0){
        Console.WriteLine($"{M}");
    }
    else{
        Console.WriteLine($"{M+1}");
    }
    M = M + 2;
    if (M >= N){
        return;
    }
    Func();
}



Func();

