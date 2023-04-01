using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Лист
            //структура от данни
            //съхранява еднотипни елементи
            //преоразмерява се

            List<int> numbers = new List<int>(); //{}

            //1. добавяме елементи в края списъка
            numbers.Add(4); //{4}
            numbers.Add(5); //{4, 5}
            numbers.Add(6); //{4, 5, 6}
                            //{4, 5, 6}

            //2. Размер на лист = брой на елементите в листа
            Console.WriteLine(numbers.Count);

            //3. достъпваме елементи в списъка
            Console.WriteLine(numbers[0]); //първия елемент в списъка -> 0 индекс
            Console.WriteLine(numbers[numbers.Count - 1]); //последния елемент в списъка -> дължина - 1 индекс

            //4. премахваме елементи от списъка
            numbers.Remove(5);  // премахва елемента 5 -> {4, 6}
            numbers.RemoveAt(0);// премахва елемента на 0 индекс -> {6}


            //{6}
            //5. вмъкване на елемент в списък
            numbers.Insert(0, 10); //{10, 6}
            numbers.Insert(0, 15); //{15, 10, 6}

            //{15, 10, 6}
            //6. проверка за елемент в списъка
            //true -> ако елемента го има в списъка
            //false -> ако елемента го няма в списъка
            Console.WriteLine(numbers.Contains(34)); //false
            Console.WriteLine(numbers.Contains(10)); //true

            //{15, 10, 6}
            //7. сортиране на списък във възходящ ред (от най-малкото към най-голямото) -> ascending order
            numbers.Sort(); //{6, 10, 15}

            //8. сортиране на списъка в низходящ ред (от най-голямото към най-малкото) -> descending order
            numbers.Sort(); //{6, 10, 15}
            numbers.Reverse(); //{15, 10, 6}

            //9. премахваме всички елементи в списъка
            numbers.Clear(); //премахва всички елементи в списъка

            //10. обхождане на списък
            // for
            for (int index = 0; index <= numbers.Count - 1; index++)
            {
                Console.WriteLine(numbers[index]);
            }

            //foreach
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //11. въвеждане на списък от цели числа от конзолата разделени с интервал
            List<int> nums = Console.ReadLine().Split(" ")   //["3", "4", "8", "5", "7", "5", "2", "1"]
                               .Select(int.Parse) // [3, 4, 8, 5, 7, 5, 2, 1]
                               .ToList();

            //12. въвеждане на списък от текстове от конзолата разделени с интервал
            List<string> names = Console.ReadLine().Split(" ") // ["Ivan", "Maria", "Dimitar", "Simona", "Petya"]
                                    .ToList(); // {"Ivan", "Maria", "Dimitar", "Simona", "Petya"}

            //13. минимален / максимален елемент в списъка
            int min = numbers.Min();
            int max = numbers.Max();

            //14. първи / последен елемент в списъка
            int firstElement = numbers.First();
            int lastElement = numbers.Last();

        }
    }
}
