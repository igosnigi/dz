Console.Clear();

Console.WriteLine("введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number>99)
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine(number);
}
else
    Console.WriteLine("нет третьей цифры");
