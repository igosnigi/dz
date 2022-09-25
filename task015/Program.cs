Console.Clear();

Console.WriteLine("введите цифру, обозначающую день недели: ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number == 6 ^ number == 7)
    Console.WriteLine("Ура! Это выходной!");
else if (number > 7)
    Console.WriteLine("Такого дня недели нет.");
else
    Console.WriteLine("Это будний день.");