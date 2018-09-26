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
            
            for (int i = 0; i < people; i++)
                    sumOfHandShakes += i;
             
            return sumOfHandShakes;
        }
    }
}
