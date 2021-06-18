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
            protected internal string Name { get; set; }
            protected internal string Sex { get; set; }
            protected internal DateTime DateOfBirth;
            protected internal int Height { get; set; }    // рост, см
            protected internal int Weight { get; set; }
            protected internal bool isMaried { get; set; }

            public static int amount = 0;

            // вес. кг

            public Person(string name, string sex, DateTime dateOfBirth, int height, int weight, bool isMaried = false)
            {
                Name = name;
                Sex = sex;
                DateOfBirth = dateOfBirth;
                Height = height;
                Weight = weight;
                this.isMaried = isMaried;
                amount++;
            }
            // Метод - спой песенку
            public void Sing(int freq, int duration)
            {
                Console.Beep(freq, duration);
            }

            // Метод, печатающий сведения об объекте
            public void Passport()
            {
                switch (Name)
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
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;


                }

            }
            public int GetAge(DateTime birthDate)
            {
                DateTime n = DateTime.Now; // To avoid a race condition around midnight
                int age = n.Year - birthDate.Year;

                if (n.Month < birthDate.Month || (n.Month == birthDate.Month && n.Day < birthDate.Day))
                    age--;

                return age;
            }
            public static void WomenCount(Person[]group)
            {

                int womenCount = 0;
                foreach (Person person in group)
                {
                    if (person.Sex == "Female") womenCount++;
                }
                Console.WriteLine( $"There are {womenCount} women inda group");
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
                

                Car[] carGroup = new Car[3];
                Person[] group = new Person[3];

                carGroup[0] = new Car("Opel", "Steve", 1999, "2000$");
                carGroup[1] = new Car("BMW", "Monica", 2019, "30000$");
                carGroup[2] = new Car("Ford", "Tim", 1991, "500$");

                carGroup[0].CarOwner("Steve");
                carGroup[1].CarOwner("Monica");
                carGroup[2].CarOwner("Tim");

                group[0] = new Person("Steve", "Male", DateTime.Parse("12.01.1999"), 190, 100);
                group[1] = new Person("Monica", "Female", DateTime.Parse("22.05.1992"), 180, 70);
                group[2] = new Person("Tim", "Male", DateTime.Parse("16.01.1997"), 170, 100);

                // Печатаем сведения об объекте pers1
                group[0].Passport();
                group[1].Passport();
                group[2].Passport();

                //Calculate common group weight

                double sumWeight = 0;

                for (int i = 0; i < group.Length; i++)
                {
                    sumWeight += group[i].Weight;
                }

                Console.WriteLine($"Common group weight : {sumWeight}");

                //Youngest one
                int[] ageArr = new int[Person.amount];

                for (int i = 0; i < group.Length; i++)
                {
                    ageArr[i] = group[i].GetAge(group[i].DateOfBirth);

                }
                int youngest = ageArr.Min();
                Console.WriteLine(youngest);
                //Tallest

                int[] heightArr = new int[Person.amount];

                for (int i = 0; i < group.Length; i++)

                {
                    heightArr[i] = group[i].Height;

                }

                int tallest = heightArr.Max();
                Console.WriteLine(tallest);
                //Women Count
                Person.WomenCount(group);




                Console.ReadLine();
            }
        }
    }

}
