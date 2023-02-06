Console.Write ("Введите любое число: ");
int Rn = Convert.ToInt32(Console.ReadLine());
if (Rn / 100 > 0)
{

  while (Rn > 1000)
  {
  Rn = Rn / 10;
  
   }

   Rn = Rn % 10;
   Console.WriteLine ("Третье число: " + Rn);
}
else {
  Console.WriteLine ("Третьей цифры нет.");
}