// Сохраняет, а затем выводит данные о человеке
string myName = "Илья Гордиенко";
string groupName = "ИСП-251";
int courseNumber = 2;
double averageGrade = 4.8;
bool isBudget = true;

Console.WriteLine("Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBudget}");

// Сохраняет параметры комнаты, вычисляет и затем выводит её периметр и площадь
Console.WriteLine();
Console.WriteLine("Ремонт: комната");
double roomWidth = 3.1415;
double roomLength = 2.04001;

double roomArea = roomWidth * roomLength;
double roomPerimeter = (roomWidth + roomLength) * 2;

Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
Console.WriteLine($"Площадь: {roomArea} кв.м");
Console.WriteLine($"Ширина: {roomPerimeter} м");

// Сохраняет стоимость ноутбука и вычисляет ежемесячную платёжку, а также итоговую цену ноутбука с процентами
Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");

int laptopPrice = 65000;
int monthsCount = 12;
double interestRate = 0.08;

double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;

Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
Console.WriteLine($"Итого в процентах: {totalWithInterest} руб.");
Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");

// Наглядно демонстрирует, почему при делении int на int следует перевести хотя бы одно из этих чисел в double
Console.WriteLine();
Console.WriteLine("Внимание: деление int");

int totalStudents = 25;
int groupsCount = 4;

int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");

// 3 способа сбора одной строки из нескольких 
Console.WriteLine();
Console.WriteLine("Способы собрать строку");

string firstName = "Илья";
string lastName = "Гордиенко";

// Сп1
string fullNameConcat = firstName + " " + lastName;

// Сп2
string fullNameInterp = $"{firstName} {lastName}";

// Сп3
string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameConcatMethod);
Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");

// Показывает, что такое константы в C#
Console.WriteLine();
Console.WriteLine("Константы");

const double VatRate = 0.20;
// VatRate = 0.18;
const string CollegeName = "ВФ ВолГУ";

double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);

Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НСД: {productPrice}, с НСД ({VatRate}): {priceWithVat}");

/*
Многострочный
комментарий
*/

// Задание 1
int scholarship = 3100;
int monthlyExpenses = 2920;
int remainder = scholarship - monthlyExpenses;
const int MonthsInSemester = 4;

// Если говорить о реальной стипендии и реальных тратах, то значение было бы примерно -3000 (минимум)
Console.WriteLine();
Console.WriteLine($"Ежемесячный остаток денег со стипендии: {remainder}");
Console.WriteLine($"Суммарный остаток со стипендии за весь семестр: {remainder * MonthsInSemester}");