using System;

namespace Workshop5Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Task 1: Encapsulation =====");
            BankAccount account = new BankAccount("ACC123", 500);
            Console.WriteLine("Account Number: " + account.AccountNumber);
            account.Deposit(200);
            account.Withdraw(100);
            Console.WriteLine("Remaining Balance: " + account.Balance);
            Console.WriteLine();

            Console.WriteLine("===== Task 2: Inheritance =====");
            Car carInheritance = new Car() { Brand = "Toyota", Speed = 120, Seats = 5 };
            Motorcycle bikeInheritance = new Motorcycle() { Brand = "Honda", Speed = 100, Type = "Sports" };

            carInheritance.Start();
            carInheritance.DisplayInfo();
            carInheritance.Stop();

            bikeInheritance.Start();
            bikeInheritance.DisplayInfo();
            bikeInheritance.Stop();
            Console.WriteLine();

            Console.WriteLine("===== Task 3: Polymorphism =====");
            Printer printer = new Printer();
            printer.Print("Hello World");
            printer.Print(123);
            printer.Print("Repeat Message", 3);

            NepaliTeacher nepaliTeacher = new NepaliTeacher();
            EnglishTeacher englishTeacher = new EnglishTeacher();

            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();
            englishTeacher.Teaching();
            englishTeacher.SalaryInfo();
            Console.WriteLine();

            Console.WriteLine("===== Task 4: Abstraction =====");
            CarAbs carAbstraction = new CarAbs();
            BikeAbs bikeAbstraction = new BikeAbs();

            carAbstraction.Display();
            carAbstraction.StartEngine();
            carAbstraction.StopEngine();

            bikeAbstraction.Display();
            bikeAbstraction.StartEngine();
            bikeAbstraction.StopEngine();
            Console.WriteLine();

            Console.WriteLine("===== Task 5: OOP – Electronics Store =====");
            ElectronicsStore store = new ElectronicsStore();
            Laptop laptop = new Laptop("Dell", 1200);
            Smartphone phone = new Smartphone("Samsung", 800);

            store.AddDevice(laptop);
            store.AddDevice(phone);
            store.ShowAllDeviceDetails();
        }
    }
}
