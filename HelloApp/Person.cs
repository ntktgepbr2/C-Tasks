using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    namespace Person0
    {
        class Person
        // Пока это плохо сделанный класс, т.е.
        // 1) все поля (атрибуты) открытые - public;
        // 2) используется конструктор по умолчанию - Person();
        {
            private string Name { get; set; }
            private string Sex { get; set; }
            private DateTime DateOfBirth;
            private double Height { get; set; }    // рост, см
            private double Weight { get; set; }
            private bool isMaried { get; set; }

            // вес. кг

            public Person(string name, string sex, DateTime dateOfBirth, double height, double weight, bool isMaried = false)
            {
                Name = name;
                Sex = sex;
                DateOfBirth = dateOfBirth;
                Height = height;
                Weight = weight;
                this.isMaried = isMaried;

            }
            // Метод - спой песенку
            public void Sing(int freq, int duration)
            {
                Console.Beep(freq, duration);
            }

            // Метод, печатающий сведения об объекте
            public void Passport()
            {
                switch (this.Name)
                {
                    case "Steve":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("имя: {0}  пол: {1},   дата рожд: {2},  рост: {3},  вес: {4} , в браке:{5}",
                    Name, Sex, DateOfBirth.ToShortDateString(), Height, Weight, isMaried);
                        
                        break;
                    case "Monica":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("имя: {0}  пол: {1},   дата рожд: {2},  рост: {3},  вес: {4} , в браке:{5}",
                    Name, Sex, DateOfBirth.ToShortDateString(), Height, Weight, isMaried);
                        
                        break;
                    case "Tim":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("имя: {0}  пол: {1},   дата рожд: {2},  рост: {3},  вес: {4} , в браке:{5}",
                    Name, Sex, DateOfBirth.ToShortDateString(), Height, Weight, isMaried);
                        
                        break;
                }

            }
        }

        class Car
        {
            private string Model { get; set; }
            private string Owner { get; set; }
            private int Year { get; set; }
            private string Cost { get; set; }

            public Car(string model, string owner, int year, string cost)
            {
                Model = model;
                Owner = owner;
                Year = year;
                Cost = cost;
            }


            public void CarOwner(string owner)
            {
                Console.WriteLine($"My owner is : {owner}");
            }

        }

        class Program
        {
            // Этот метод служит для тестирования класса Person
            static void Main(string[] args)
            {
                Car car1 = new Car("Opel", "Steve", 1999, "2000$");
                Car car2 = new Car("BMW", "Monica", 2019, "30000$");
                Car car3 = new Car("Ford", "Tim", 1991, "500$");

                car1.CarOwner("Steve");
                car2.CarOwner("Monica");
                car3.CarOwner("Tim");
                // Создаем  объект pers1 типа Person
                Person pers1 = new Person("Steve", "Male", DateTime.Parse("12.01.1991"), 190, 100);


                // Создаем  объект pers2 типа Person
                Person pers2 = new Person("Monica", "Female", DateTime.Parse("22.05.1992"), 180, 70);


                Person pers3 = new Person("Tim", "Male", DateTime.Parse("16.01.1997"), 170, 100);

                // Печатаем сведения об объекте pers1
                pers1.Passport();
                pers2.Passport();
                pers3.Passport();


                Console.ReadLine();
            }
        }
    }

}
