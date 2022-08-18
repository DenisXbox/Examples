Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "денис")
{
    Console.WriteLine("Салют Денис");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}    