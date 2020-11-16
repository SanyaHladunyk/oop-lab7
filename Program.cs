using System;
using System.Collections.Generic;

namespace oop_lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entrant> Entrant = new List<Entrant>();
            List<Student> Student = new List<Student>();
            List<Teacher> Teacher = new List<Teacher>();
            List<LibraryUser> LibraryUser = new List<LibraryUser>();
            Entrant.Add(new Entrant("Олександр", "Гладуник", new DateTime(2002, 2, 17), 120, 10.2, "Турківська ЗОШ"));
            Entrant.Add(new Entrant());
            Student.Add(new Student());
            Teacher.Add(new Teacher());
            LibraryUser.Add(new LibraryUser());
            while(true)
            {
                Console.Write("\n\n1. Переглянути масив абітурієнтів\n" +
                    "2. Переглянути масив студентів\n" +
                    "3. Переглянути масив викладачів\n" +
                    "4. Переглянути масив користувачів бібліотеки\n" +
                    "5. Додати абітурєнта\n" +
                    "6. Додати студента\n" +
                    "7. Додати викладача\n" +
                    "8. Додати користувача бібліотеки\n" +
                    "9. Вихід\n" +
                    ">>>");
                if (!Int32.TryParse(Console.ReadLine(), out int n) || n > 10 || n < 0) 
                    Console.WriteLine("\n     Введено некоректне значення! Повторіть спробу.");
                else if(n==1)
                    foreach (var item in Entrant)
                    {
                        Console.WriteLine("\n");
                        item.ShowInfo();
                    }
                else if (n == 2)
                    foreach (var item in Student)
                    {
                        Console.WriteLine("\n");
                        item.ShowInfo();
                    }
                else if (n == 3)
                    foreach (var item in Teacher)
                    {
                        Console.WriteLine("\n");
                        item.ShowInfo();
                    }
                else if (n == 4)
                    foreach (var item in LibraryUser)
                    {
                        Console.WriteLine("\n");
                        item.ShowInfo();
                    }
                else if (n == 5)
                {
                    string Name,
                        Surname,
                        SecondarySchool;
                    double PointsZNO, 
                        PointsEducation;
                    SetHuman(out Name, out Surname, out int Day, out int Month, out int Year);
                    if (Day == 0 || Day > 31)
                        Day = 1;
                    if (Month == 0 || Month > 12)
                        Month = 1;
                    if (Year == 0)
                        Year = 1;
                    Console.Write("Кількість балів сертифікатів ЗНО: ");
                    Double.TryParse(Console.ReadLine(), out PointsZNO);
                    Console.Write("Кількість балів за документ про освіту: ");
                    Double.TryParse(Console.ReadLine(), out PointsEducation);
                    Console.Write("Назва загальноосвітнього навчального закладу: ");
                    SecondarySchool = Console.ReadLine();
                    Entrant.Add(new Entrant(Name, Surname, new DateTime(Year, Month, Day), PointsZNO, PointsEducation, SecondarySchool));
                }
                else if (n == 6)
                {
                    string Name,
                        Surname,
                        Grup,
                        Faculty,
                        InstitutionOfHigherEducation;
                    int Cours;
                    SetHuman(out Name, out Surname, out int Day, out int Month, out int Year);
                    if (Day == 0 || Day > 31)
                        Day = 1;
                    if (Month == 0 || Month > 12)
                        Month = 1;
                    if (Year == 0)
                        Year = 1;
                    Console.Write("Курс: ");
                    Int32.TryParse(Console.ReadLine(), out Cours);
                    Console.Write("Група: ");
                    Grup = Console.ReadLine();
                    Console.Write("Факультет: ");
                    Faculty = Console.ReadLine(); 
                    Console.Write("Вищий навчальний заклад: ");
                    InstitutionOfHigherEducation = Console.ReadLine();
                    Student.Add(new Student(Name, Surname, new DateTime(Year, Month, Day), Cours, Grup, Faculty, InstitutionOfHigherEducation));
                }
                else if (n == 7)
                {
                    string Name,
                        Surname,
                        Position,
                        Cathedra,
                        InstitutionOfHigherEducation;
                    SetHuman(out Name, out Surname, out int Day, out int Month, out int Year);
                    if (Day == 0 || Day > 31)
                        Day = 1;
                    if (Month == 0 || Month > 12)
                        Month = 1;
                    if (Year == 0)
                        Year = 1;
                    Console.Write("Посада: ");
                    Position = Console.ReadLine();
                    Console.Write("Кафедра: ");
                    Cathedra = Console.ReadLine();
                    Console.Write("Вищий навчальний заклад: ");
                    InstitutionOfHigherEducation = Console.ReadLine();
                    Teacher.Add(new Teacher(Name, Surname, new DateTime(Year, Month, Day), Position, Cathedra, InstitutionOfHigherEducation));
                }
                else if (n == 8)
                {
                    string Name,
                        Surname;
                    int ReadersTicketNumber;
                    double MonthlyAmountReadersFee;
                    SetHuman(out Name, out Surname, out int Day, out int Month, out int Year);
                    if (Day == 0 || Day > 31) 
                        Day = 1;
                    if (Month == 0 || Month > 12) 
                        Month = 1;
                    if (Year == 0)
                        Year = 1;
                    Console.Write("Номер читацького квитка: ");
                    Int32.TryParse(Console.ReadLine(), out ReadersTicketNumber);
                    Console.Write(" Дата видачі\nДень: ");
                    Int32.TryParse(Console.ReadLine(), out int IssueDay);
                    Console.Write("Місяць: ");
                    Int32.TryParse(Console.ReadLine(), out int IssueMonth);
                    Console.Write("Рік: ");
                    Int32.TryParse(Console.ReadLine(), out int IssueYear);
                    Console.Write("Розмір щомісячного читацького внеску: ");
                    Double.TryParse(Console.ReadLine(), out MonthlyAmountReadersFee);
                    if (IssueDay == 0 || IssueDay > 31)
                        IssueDay = 1;
                    if (IssueMonth == 0 || IssueMonth > 12)
                        IssueMonth = 1;
                    if (IssueYear == 0)
                        IssueYear = 1;
                    LibraryUser.Add(new LibraryUser(Name, Surname, new DateTime(Year, Month, Year), ReadersTicketNumber, new DateTime(IssueYear, IssueMonth, IssueDay), MonthlyAmountReadersFee));
                }
                else if (n == 9)
                    break;
            }
            void SetHuman(out string name, out string surname, out int day, out int month, out int year)
            {
                Console.Write("Ім'я: ");
                name = Console.ReadLine();
                Console.Write("Прізвище: ");
                surname = Console.ReadLine();
                Console.Write(" Дата народження\nДень: ");
                Int32.TryParse(Console.ReadLine(), out day);
                Console.Write("Місяць: ");
                Int32.TryParse(Console.ReadLine(), out month);
                Console.Write("Рік: ");
                Int32.TryParse(Console.ReadLine(), out year);

            }
        }
    }
}
