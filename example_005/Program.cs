Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРА БЛЯДЬ ЭТО ЖЕ МАША ЕБАНЕШЬСЯ");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}