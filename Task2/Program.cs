Console.Write("Введитe число ");
int a = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(a);
if (str.Length > 2)
{
  Console.WriteLine("третья цифра = " + str[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}
