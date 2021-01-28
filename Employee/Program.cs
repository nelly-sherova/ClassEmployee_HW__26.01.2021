using System;

namespace Employeee
{
    class Employee 
    {
        public string firstName;
        public string lastName;
        Employee(){}
        Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string position;
        public int experience;
        public double salary;
        public double oklad;
        public double Tax()
        {
            return (13 * salary) / 100;
        }
        public double PensionTax()
        {
            return (salary / 100);
        }
        public double SalaryIncludingTaxes()
        {
            return (salary - Tax() - PensionTax());
        }
        public void getInfo()
        {
            if (position == "программист")
            {
                oklad = 2000;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = oklad - SalaryIncludingTaxes();
            }
            if (position == "учитель")
            {
                oklad = 1000;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = oklad - SalaryIncludingTaxes();
            }
            if (position == "юрист")
            {
                oklad = 2500;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = oklad - SalaryIncludingTaxes();
            }
            if (position == "мененджер")
            {
                oklad = 2300;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = oklad - SalaryIncludingTaxes();
            }
            if (position == "директор")
            {
                oklad = 5000;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = oklad - SalaryIncludingTaxes();
            }
            Console.WriteLine("Ваш сотрудник: ");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Cтаж: {experience}");
            Console.WriteLine($"Оклад: {oklad}");
            Console.WriteLine($"Налог 13% от заработной платы: {Tax()}");
            Console.WriteLine($"Пенсионный налог 1% от заработной платы: {PensionTax()}");
            Console.WriteLine($"Заработная плата с учетом всех налогов: {salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegrounColor = ConsoleColor.Green;
            Console.WriteLine("Вас приветствует класс Employee");
            Console.ForegrounColor = ConsoleColor.White;
            string[] name = {"Ник", "Лейтон", "Юми", "Коннор", "Зельда", "Алия", "Герберт", "Гунтер"};
            string[] lastName1 = {"Альто", "Секемото", "Секемото", "Грей", "Май", "Ландграаб","Ландграаб", "Гот"};
            string[] posiTion = {"Директор", "Программист", "Учитель", "Юрист", "Менеджер", "Юрист", "Менеджер", "Программист"};
            
        }
    }
}
