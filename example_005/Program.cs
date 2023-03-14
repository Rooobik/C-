Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРА ЭТО ЖЕ МАША");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}