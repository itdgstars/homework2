Console.Write ("Введите любое число: ");
int Rn = Convert.ToInt32(Console.ReadLine());


if (Rn > 0 & Rn < 8)
{
  if (Rn > 5 & Rn <8)
  {
    Console.WriteLine ("Да, это выходной день");
  }
  else {
    Console.WriteLine ("Нет, это будний день!");
  }
}
else {
  Console.WriteLine ("Ваше число не является днем недели.");
}
