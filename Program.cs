//Вывести последнее число из трёхзначного
Console.WriteLine("Введите трёхзначное число");
int Number = int.Parse(Console.ReadLine());
Number = Number % 10;
Console.WriteLine(Number);