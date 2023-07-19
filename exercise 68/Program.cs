// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return akkerman(m - 1, 1);
  else return akkerman(m - 1, akkerman(m, n - 1));
}

int m = Prompt("Input M: ");
int n = Prompt("Input N: ");

Console.WriteLine($"A({m},{n}) = {akkerman(m, n)}");