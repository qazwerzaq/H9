Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input command: ");
        switch (Console.ReadLine())
        {
            case "H1": H1(); break;
            case "H2": H2(); break;
            case "H3": H3(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

void H1()//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
{
Console.WriteLine ("Введите число : ");
int num = int.Parse(Console.ReadLine());

string NumbersRec(int a, int b)
{
    if (a <= num) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, num));
}

void H2()
{
    Console.WriteLine ("Введите число от : ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите число до : ");
int b = int.Parse(Console.ReadLine());

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(a, b));
}

void H3()
{
int n = InputNumbers("Введите n: ");
int m = InputNumbers("Введите m: ");

int functionAkkerman = Ack(n, m);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int n, int m)
{
  if (n == 0) return m + 1;
  else if (m == 0) return Ack(n - 1, 1);
  else return Ack(n - 1, Ack(n, m - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
}