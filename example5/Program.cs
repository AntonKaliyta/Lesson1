System.Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "тоха")
{
    System.Console.WriteLine("О, Тоха!");
}
else 
{
    System.Console.Write("Привет, ");
    System.Console.Write(username);
}