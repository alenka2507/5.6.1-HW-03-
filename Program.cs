using System.ComponentModel.Design;

namespace Анкета_с_методами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = Anketa();
            Result(user);
           
        }
        static (string, string, int, bool, int, string[], int, string[]) Anketa()
        {
            string Name, Surname;
            int Age, 
            numPet = 0, favcolor;
            bool Pet;
            string[] animal = null, colors;
            Console.Write("Введите Ваше имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            Surname = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            Age = int.Parse(Console.ReadLine());
            FaceControl(ref Age);
            Console.Write("У Вас есть домашние питомцы? (true/false)");
            Pet = bool.Parse(Console.ReadLine());
            if (Pet)
            {
                Console.Write("Введите количество домашних питомцев: ");
                numPet = int.Parse(Console.ReadLine());
                FaceControl(ref numPet);
                animal = Animal(numPet);
            }
            Console.Write("Введите количество любимых цветов:");
            favcolor = int.Parse(Console.ReadLine());
            FaceControl(ref favcolor);
            colors = InsertColor(favcolor);
            return (Name, Surname, Age, Pet, numPet, animal, favcolor, colors);
        }
        static void FaceControl(ref int ID)
        {
            while (ID <= 0)
            {
                Console.Write("Введенное число некорректно. Введите значение больше 0: ");
                ID = int.Parse(Console.ReadLine());
            }
        }
        static string[] Animal(int num)
        {
            string[] name = new string[num];
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"Введите кличку питомца N {i+1}");
                    name[i] = Console.ReadLine();
                }
            return name;

            }

       static string[] InsertColor (int num)
        {
            string[] Colors = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Введите любимый цвет N {i+1}");
                Colors[i] = Console.ReadLine();
            }
            return Colors;
        }
        static void Result ((string Name, string Surname, int Age, bool Pet, int numPet, string[] animal, int favcolor, string[] colors) kortej)
        {
            Console.WriteLine($"Ваше имя: {kortej.Name}");
            Console.WriteLine($"Вашa фамилия: {kortej.Surname}");
            Console.WriteLine($"Ваш возраст: {kortej.Age}");
            Console.WriteLine($"У Вас есть питомец: {kortej.Pet}");
            if (kortej.Pet)
            {
                Console.WriteLine($"У Вас {kortej.numPet} питомцев(а), которых зовут: ");
                for (int i = 0; i< kortej.numPet; i++)
                {
                    Console.WriteLine(kortej.animal[i]);
                }
            }
            Console.WriteLine($"У Вас {kortej.favcolor} любимых цвета(ов): ");
            for (int j = 0; j < kortej.favcolor; j++)
            {
                Console.WriteLine(kortej.colors[j]);
            }

        }            
        }

    }
    
        
    

