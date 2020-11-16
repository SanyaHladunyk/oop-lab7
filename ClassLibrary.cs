using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lab7
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public Human()
        {
            Name = "Undefined";
            Surname = "Undefined";
            DateOfBirthday = new DateTime(1, 1, 1);
        }
        public Human(string name, string surname, DateTime dateOfBirthday)
        {
            Name = name;
            Surname = surname;
            DateOfBirthday = new DateTime(dateOfBirthday.Year, dateOfBirthday.Month, dateOfBirthday.Day);
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine(Name + ' ' + Surname + "\n" +
                DateOfBirthday.Day + '.' + DateOfBirthday.Month + '.' + DateOfBirthday.Year);
        }
    }
    public class Entrant : Human
    {
        public double PointsZNO { get; set; }
        public double PointsForADocumentAboutEducation { get; set; }
        public string SecondarySchool { get; set; }
        public Entrant()
        {
            Name = "Undefined";
            Surname = "Undefined";
            DateOfBirthday = new DateTime(1, 1, 1);
            PointsZNO = 0;
            PointsForADocumentAboutEducation = 0;
            SecondarySchool = "Undefined";
        }
        public Entrant(string name, string surname, DateTime dateOfBirthday, double pointsZNO, double pointsForADocumentAboutEducation, string secondarySchool)
        {
            Name = name;
            Surname = surname;
            DateOfBirthday = new DateTime(dateOfBirthday.Year, dateOfBirthday.Month, dateOfBirthday.Day);
            PointsZNO = pointsZNO;
            PointsForADocumentAboutEducation = pointsForADocumentAboutEducation;
            SecondarySchool = secondarySchool;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Абітурієнт - {Name} {Surname}\n" +
                $"Дата народження - {DateOfBirthday.Day}.{DateOfBirthday.Month}.{DateOfBirthday.Year}\n" +
                $"Кількість балів сертифікатів ЗНО - {PointsZNO}\n" +
                $"Кількість балів за документ про освіту - {PointsForADocumentAboutEducation}\n" +
                $"Назва загально-освітнього закладу - {SecondarySchool}");
        }
    }
    public class Student:Human
    {
        public int Cours { get; set; }
        public string Grup { get; set; }
        public string Faculty { get; set; }
        public string InstitutionOfHigherEducation { get; set; }
        public Student()
        {
            Name = "Undefined";
            Surname = "Undefined";
            DateOfBirthday = new DateTime(1, 1, 1);
            Cours = 0;
            Grup = "Undefined";
            Faculty = "Undefined";
            InstitutionOfHigherEducation = "Undefined";
        }
        public Student(string name, string surname, DateTime dateOfBirthday, int cours, string grup, string faculty, string institutionOfHigherEducation)
        {
            Name = name;
            Surname = surname;
            DateOfBirthday = new DateTime(dateOfBirthday.Year, dateOfBirthday.Month, dateOfBirthday.Day);
            Cours = cours;
            Grup = grup;
            Faculty = faculty;
            InstitutionOfHigherEducation = institutionOfHigherEducation;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Студент - {Name} {Surname}\n" +
                $"Дата народження - {DateOfBirthday.Day}.{DateOfBirthday.Month}.{DateOfBirthday.Year}\n" +
                $"Курс - {Cours}\n" +
                $"Група - {Grup}\n" +
                $"Факультет - {Faculty}\n" +
                $"Вищий навчальний заклад - {InstitutionOfHigherEducation}");
        }
    }
    public class Teacher:Human
    {
        public string Position { get; set; }
        public string Cathedra { get; set; }
        public string InstitutionOfHigherEducation { get; set; }
        public Teacher()
        {
            Name = "Undefined";
            Surname = "Undefined";
            DateOfBirthday = new DateTime(1, 1, 1);
            Position = "Undefined";
            Cathedra = "Undefined";
            InstitutionOfHigherEducation = "Undefined";
        }
        public Teacher(string name, string surname, DateTime dateOfBirthday, string position, string cathedra, string institutionOfHigherEducation)
        {
            Name = name;
            Surname = surname;
            DateOfBirthday = new DateTime(dateOfBirthday.Year, dateOfBirthday.Month, dateOfBirthday.Day);
            Position = position;
            Cathedra = cathedra;
            InstitutionOfHigherEducation = institutionOfHigherEducation;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Викладач - {Name} {Surname}\n" +
                $"Дата народження - {DateOfBirthday.Day}.{DateOfBirthday.Month}.{DateOfBirthday.Year}\n" +
                $"Посада - {Position}\n" +
                $"Кафедра - {Cathedra}\n" +
                $"Вищий навчальний заклад - {InstitutionOfHigherEducation}");
        }
    }
    public class LibraryUser:Human
    {
        public int ReadersTicketNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double MonthlyAmountReadersFee { get; set; }
        public LibraryUser()
        {
            Name = "Undefined";
            Surname = "Undefined";
            DateOfBirthday = new DateTime(1, 1, 1);
            ReadersTicketNumber = 0;
            DateOfIssue = new DateTime(1, 1, 1);
            MonthlyAmountReadersFee = 0;
        }
        public LibraryUser(string name, string surname, DateTime dateOfBirthday, int readersTicketNumber, DateTime dateOfIssue, double monthlyAmountReadersFee)
        {
            Name = name;
            Surname = surname;
            DateOfBirthday = new DateTime(dateOfBirthday.Year, dateOfBirthday.Month, dateOfBirthday.Day);
            ReadersTicketNumber = readersTicketNumber;
            DateOfIssue = new DateTime(dateOfIssue.Year, dateOfIssue.Month, dateOfIssue.Day);
            MonthlyAmountReadersFee = monthlyAmountReadersFee;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Користувач бібліотеки - {Name} {Surname}\n" +
                $"Дата народження - {DateOfBirthday.Day}.{DateOfBirthday.Month}.{DateOfBirthday.Year}\n" +
                $"Номер читацького квитка - {ReadersTicketNumber}\n" +
                $"Дата видачі - {DateOfIssue.Day}.{DateOfIssue.Month}.{DateOfIssue.Year}\n" +
                $"Розмір щомісячного читацького внеску - {MonthlyAmountReadersFee}");
        }
    }
}
