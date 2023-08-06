Console.Write("Введитe цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7) 
{
  Console.WriteLine( day + "-> да");
}
  else if (day < 1 || day > 7) 
  {
    Console.WriteLine("Ошибка! Введите другое число");
  }
  else Console.WriteLine( day + "-> нет");
