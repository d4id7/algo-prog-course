// Вопросы студенту
using System.Text.RegularExpressions;

Console.Write("Введите имя и фамилию: ");
string studName = Console.ReadLine();

Console.Write("Введите группу: ");
string studGroup = Console.ReadLine();

Console.Write("Введите год рождения: ");
string birthYearInput = Console.ReadLine();
int birthYearConvert = Convert.ToInt32(birthYearInput);

Console.Write("Введите средний балл: ");
string gpaInput = Console.ReadLine();
double gpaParse = double.Parse(gpaInput);

Console.Write("Введите любимую букву: ");
char fvLetter = Console.ReadLine()[0];

Console.WriteLine();
Console.WriteLine("\tАнкета");
Console.WriteLine($"{studName}, группа {studGroup}");
Console.WriteLine($"Год рождения:{birthYearConvert} (в 2030 будет {2030 - birthYearConvert} год)");
Console.WriteLine($"Средний балл: {gpaParse}");
Console.WriteLine($"Балл >= 4.0: {gpaParse >= 4.0}");
Console.WriteLine($"Любимая буква: {fvLetter}");