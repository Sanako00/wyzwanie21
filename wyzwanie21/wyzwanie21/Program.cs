
String name = "Sabina";
char sex = 'F';
int age = 23;

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == 'F' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex == 'F' && age >= 30)
{
    Console.WriteLine("Kobieta minimum 30 lat");
}
else if (sex != 'F')
{
    if (age >= 18)
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}