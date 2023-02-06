int Number()
{
  Console.Write ("Введите трехзначное число: ");
int Rn = Convert.ToInt32(Console.ReadLine());
  int num1 = Rn / 10;
  int num2 = num1 % 10;
  return num2;
}
int res = Number();
Console.WriteLine("Вторая цифра числа: " + res);
