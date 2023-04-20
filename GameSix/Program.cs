using System;

namespace GameSix
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert number of enemies");
            int enemyNum = Convert.ToInt16(Console.ReadLine());
            Foe[] enemyArray = new Foe[enemyNum];

            for (int i = 0; i < enemyNum; i++)
            {
                Console.WriteLine($"Creating enemy nº{i + 1}\nEnter it's name");
                string newEnemyName = Console.ReadLine()!;

                enemyArray[i] = new Foe(newEnemyName);
            }

            foreach (var enemy in enemyArray)
            {
                Console.WriteLine(enemy.GetName());
            }
        }
    } 
}