using System;
using System.Linq;
namespace _02._The_Lift
{
    internal class Program
    {
        static void Main()
        {
            int queue = int.Parse(Console.ReadLine());
            if (queue < 0)
            {
                return;
            }
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] > 4)
                {
                    return;
                }
            }
            int liftWagons = lift.Length * 4;
            int liftPeopleCounter = 0;
            for (int i = 0; i < lift.Length; i++)
            {
                liftPeopleCounter += lift[i];
            }  

            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (lift[i] < 4 && queue > 0)
                    {
                        lift[i]++;
                        liftPeopleCounter++;
                        queue--;
                    }
                    if (lift[i] >= 4 && queue > 0)
                    {
                        break;
                    }
                    if (queue <= 0 && liftPeopleCounter < liftWagons)
                    {
                        Console.WriteLine("The lift has empty spots!");
                        for (int y = 0; y < lift.Length; y++)
                        {
                            Console.Write(lift[y] + " ");
                        }
                        return;
                    }
                    if (queue <= 0 && liftPeopleCounter == liftWagons)
                    {
                        for (int y = 0; y < lift.Length; y++)
                        {
                            Console.Write(lift[y] + " ");
                        }
                        return;
                    }
                }
            }
            Console.WriteLine($"There isn't enough space! {queue} people in a queue!");
            for (int i = 0; i < lift.Length; i++)
            {
                Console.Write(lift[i] + " ");
            }
        }
    }
}