using System;

namespace HandShakeCounterAlgorithm
{
    class Program
    {
        // Задача придумать алгоритм рукопожатий - если встретились 
        //                           2 человека - 1 рукопожатие, 
        //                           3 человека - 3 рукопожатий, 
        //                           4 человека - 6 рукопожатий, 
        //                           5 человека - 10 рукопожатий, 
        //                           6 человека - 15 рукопожатий, 
        //                           7 человека - 21 рукопожатий, 
        //                           8 человека - 28 рукопожатий 
        
        static void Main(string[] args)
        {
            Console.Write("Люди которые встретились: ");
            int numberOfPeople = int.Parse(Console.ReadLine()); // вводим количество людей
            
            Console.WriteLine(HandShakeCounter(numberOfPeople) + " рукопожатий"); //показываем количество рукопожатий
        }

        static int HandShakeCounter(int people)
        {
            int sumOfHandShakes = 0; // сумма рукопожатий
            
            // проверяем количество людей на нечетность
            if (people % 2 == 1)
            {
                for (int i = 1; i <= people; i++)
                    sumOfHandShakes += i;
                sumOfHandShakes -= people;
            }
            // алгоритм выполнения для четных людей
            else
                sumOfHandShakes = people * (people / 2) - (people / 2);

            return sumOfHandShakes;
        }
    }
}
