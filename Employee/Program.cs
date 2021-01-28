using System;

namespace Employeee
{
    class Employee 
    {
        public string firstName;
        public string lastName;
        public Employee(){}
        public Employee(string firstName, string lastName)
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
            return (13 * oklad) / 100;
        }
        public double PensionTax()
        {
            return (oklad / 100);
        }
        public double SalaryIncludingTaxes()
        {
            return (oklad - Tax() - PensionTax());
        }
        public void getInfo()
        {
            if (position == "Программист")
            {
                oklad = 2000;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = SalaryIncludingTaxes();
            }
            if (position == "Учитель")
            {
                oklad = 1000;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = SalaryIncludingTaxes();
            }
            if (position == "Юрист")
            {
                oklad = 2500;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = SalaryIncludingTaxes();
            }
            if (position == "Менеджер")
            {
                oklad = 2300;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = SalaryIncludingTaxes();
            }
            if (position == "Директор")
            {
                oklad = 5000;
                if (experience > 2 && experience <= 5) oklad = 5 * oklad / 100 + oklad;
                if (experience > 5) oklad = 10 * oklad / 100 + oklad;
                salary = SalaryIncludingTaxes();
            }
            Console.WriteLine("Ваш сотрудник: ");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Cтаж: {experience}");
            Console.WriteLine($"Оклад: {oklad}");
            Console.WriteLine($"Налог 13% от заработной платы: {Math.Round(Tax(),3)}");
            Console.WriteLine($"Пенсионный налог 1% от заработной платы: {Math.Round(PensionTax(), 3)}");
            Console.WriteLine($"Заработная плата с учетом всех налогов: {Math.Round(salary, 3)}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вас приветствует класс Employee");
            Console.ForegroundColor = ConsoleColor.White;
            string[] name = {"Ник", "Лейтон", "Юми", "Коннор", "Зельда", "Алия", "Герберт", "Гунтер"};
            string[] lastName1 = {"Альто", "Секемото", "Секемото", "Грей", "Май", "Ландграаб","Ландграаб", "Гот"};
            string[] posiTion = {"Директор", "Программист", "Учитель", "Юрист", "Менеджер", "Юрист", "Менеджер", "Программист"};
            int[] experience1 = {10, 4, 25, 7, 3, 15, 12, 9};
            for (int i = 0; i < name.Length; i++)
            {
                Employee emp = new Employee(name[i], lastName1[i]);
                emp.position = posiTion[i];
                emp.experience = experience1[i];
                emp.getInfo();
            }
        }
    }
}
