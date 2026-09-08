// Визитка для студента

string studName = "Гордиенко Илья Андреевич";
string studGroup = "ИСП-251";
int studCourse = 2;
string date = "08.09.2026";

// Вычисляем средний балл за 3 работы
int ftMark = 5;
int scMark = 3;
int tdMark = 5;
double gpa = ((double)ftMark + scMark + tdMark) / 3;

// Проверяем положена ли стипендию по среднему баллу
bool isGrant = gpa >= 4.0;

// Выводим всю информацию
Console.WriteLine("  ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
Console.WriteLine($"ФИО:    {studName}");
Console.WriteLine($"Группа: {studGroup}");
Console.WriteLine($"Курс:   {studCourse}");
Console.WriteLine($"Дата:   {date}");
Console.WriteLine();
Console.WriteLine($"Средний балл за 3 работы: {gpa}");
Console.WriteLine($"Стипендия положена (>= 4.0): {isGrant}");