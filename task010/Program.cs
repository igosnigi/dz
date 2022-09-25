Console.Clear();

Console.WriteLine("введите трехзначное число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

Console.WriteLine(number / 10 % 10);
