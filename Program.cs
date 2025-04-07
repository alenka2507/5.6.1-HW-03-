using System.ComponentModel;
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
            Age = FaceControl("Введите Ваш возраст: ");
            Pet = BoolConvert("У Вас есть домашние питомцы? (да/нет)", out Pet);
            if (Pet)
            {
                numPet = FaceControl("Введите количество домашних питомцев: ");
               animal = Animal(numPet);
            }
            favcolor = FaceControl("Введите количество любимых цветов: ");
           colors = InsertColor(favcolor);
            return (Name, Surname, Age, Pet, numPet, animal, favcolor, colors);
        }
        static int FaceControl(string control)
        {
            Console.Write(control);
            int ID;
            while (!int.TryParse(Console.ReadLine(), out ID)|| ID <= 0)
            {
                Console.Write("Введенное число некорректно. Введите значение больше 0: ");
            }
            return ID;
        }
        static string[] Animal(int num)
        {
            string[] name = new string[num];
                for (int i = 0; i < num; i++)
                {
                    Console.Write($"Введите кличку питомца N {i+1}: ");
                    name[i] = Console.ReadLine();
                }
            return name;

            }

       static string[] InsertColor (int num)
        {
            string[] Colors = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Введите любимый цвет N {i+1}: ");
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
       static bool BoolConvert(string message, out bool pet)
        {
            Console.Write(message);
            string temp = Console.ReadLine().ToLower();

            if (temp == "да")
            {
                pet = true;
                return true;
            }
            if (temp == "нет")
            {
                pet = false;
                return false;
            }
            else
            {
                Console.WriteLine("Некорректное значение");
                return BoolConvert(message, out pet);

            }
        }
        }

    }
    
        
    

