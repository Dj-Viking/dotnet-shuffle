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
            this.Separator("printing args");
            this.PrintArgs(args);
            this.Separator("printing current array");
            this.PrintArr(this.INT_ARR);
            this.Separator("print shuffled array");
            int[] shuffled_arr = this.ShuffleArray(this.INT_ARR);

            this.PrintArr(shuffled_arr);
        }

        public void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("arr item {0}", INT_ARR[i]);
        }

        public void PrintArgs(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("got some args");
                for (int i = 0; i < args.Length; i++)
                    Console.WriteLine(args[i]);
            }
            else
                Console.WriteLine("got no args");
        }

        public void Separator(string msg)
        {
            Console.WriteLine("----------- {0}", msg);
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


