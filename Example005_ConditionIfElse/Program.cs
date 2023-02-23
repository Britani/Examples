Console.WriteLine("Ведите свое имя");
string username = Console.ReadLine();


if (username.ToLower() == "маша") {
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
