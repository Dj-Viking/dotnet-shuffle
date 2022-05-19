using System;
using System.Runtime;
namespace dotnet_shuffle
{
    public class MainClass
    {
        int[] INT_ARR = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static void Main(string[] args)
        {
            new MainClass().DoTheStuff(args);
        }

        public void DoTheStuff(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("got some args");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }

            }
            else
            {
                Console.WriteLine("got no args");
            }

            for (int i = 0; i < this.INT_ARR.Length; i++)
            {
                Console.WriteLine("arr item {0}", INT_ARR[i]);
            }
            int[] shuffled_arr = this.ShuffleArray(this.INT_ARR);

            for (int j = 0; j < shuffled_arr.Length; j++)
            {
                Console.WriteLine("random shuffled: {0} ", shuffled_arr[j]);
            }
        }

        public int[] ShuffleArray(int[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int random_index = rnd.Next(0, arr.Length - 1);
                int current_item = arr[i];
                //swap
                arr[i] = arr[random_index];
                //replace swapped random with current to avoid dupes
                arr[random_index] = current_item;
            }

            return arr;
        }
    }
}


