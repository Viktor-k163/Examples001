Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "виктор")
{
   Console.WriteLine("Ура, это же Виктор!");
}
else
{
   Console.Write("Привет, ");
   Console.WriteLine(username);
}