using System;

namespace University
{
    class Student
    {
        public string FullName;
        public string GroupNumber;
        private int age;

        public Student(string fullName, string groupNumber, int age)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {FullName}, Группа: {GroupNumber}, Возраст: {age}");
        }
    }
}

namespace Library
{
    class Reader
    {
        private string fullName;
        public string ticketNumber;
        public string Faculty;
        private DateTime date;
        public string Phone;

        public Reader(string fullName, string readerTicketNumber, string faculty, DateTime date, string phone)
        {
            this.fullName = fullName;
            ticketNumber = readerTicketNumber;
            Faculty = faculty;
            this.date = date;
            Phone = phone;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Читатель: {fullName}, Номер читательского билета: {ticketNumber}, Факультет: {Faculty}, Дата рождения: {date.ToShortDateString()}, Телефон: {Phone}");
        }

        public void TakeBook(int numberOfBooks)
        {
            Console.WriteLine($"{fullName} взял {numberOfBooks} книги.");
        }

        public void TakeBook(params string[] bookNames)
        {
            Console.Write($"{fullName} взял книги:");
            foreach (var book in bookNames)
            {
                Console.Write($" {book},");
            }
            Console.WriteLine();
        }

        public void ReturnBook(int numberOfBooks)
        {
            Console.WriteLine($"{fullName} вернул {numberOfBooks} книги.");
        }

        public void ReturnBook(params string[] bookNames)
        {
            Console.Write($"{fullName} вернул книги:");
            foreach (var book in bookNames)
            {
                Console.Write($" {book},");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        University.Student[] students = new University.Student[3];
        students[0] = new University.Student("Иванов Иван Иванович", "Группа 101", 20);
        students[1] = new University.Student("Петров Петр Петрович", "Группа 102", 21);
        students[2] = new University.Student("Сидоров Сидор Сидорович", "Группа 103", 22);

        Library.Reader[] readers = new Library.Reader[3];
        readers[0] = new Library.Reader("Иванов И.И.", "123456", "Информатика", new DateTime(1990, 5, 15), "123456789");
        readers[1] = new Library.Reader("Петров П.П.", "654321", "Физика", new DateTime(1995, 8, 25), "98754321");
        readers[2] = new Library.Reader("Сидоров С.С.", "987654", "Математика", new DateTime(1992, 3, 10), "456789123");

        foreach (var student in students)
        {
            student.PrintInfo();
        }

        foreach (var reader in readers)
        {
            reader.PrintInfo();
        }

        readers[0].TakeBook(3);
        readers[1].TakeBook("Приключения", "Словарь", "Энциклопедия");
        readers[2].ReturnBook(2);
        readers[0].ReturnBook("Приключения", "Словарь");
    }
}
