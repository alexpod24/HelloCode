Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "кисочка")
{
    Console.WriteLine("ура это же Кисочка" );
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}