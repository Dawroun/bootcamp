using System;

namespace lesson2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());



            int sum = 0;
            // while(n-->0)
            // {
            //     sum+=n;
            // }
            // System.Console.WriteLine($"{sum}");

            for(int i = 0; i <= n; i++)
            {
                sum+=i;
            }
            System.Console.WriteLine($"{sum}");
        }

        static void Main_Conditionals(string[] args)
        {

            // int a = 10;
            // int b = 11;

            // System.Console.WriteLine($"{a} and {b} {1}");

            int son = int.Parse(Console.ReadLine());


            // switch(son)
            // {
            //     case 1: Console.WriteLine("Siz bir kiritdingiz"); break;
            //     case 2: Console.WriteLine("Siz ikki kiritdingiz"); break;
            //     case 3: Console.WriteLine("Siz uch kiritdingiz"); break;
            //     case 4: Console.WriteLine("Siz tort kiritdingiz"); break;
            //     default: Console.WriteLine($"Siz {son} kiritdingiz"); break;
            // }


            //  var message = son switch 
            // {
            //     1=> "Siz bir kiritdingiz",
            //     2=> "Siz ikki kiritdingiz",
            //     3=> "Siz uch kiritdingiz",
            //     4=> "Siz tort kiritdingiz",
            //     _=> $"Siz {son} kiritdingiz",   
            // };
            // System.Console.WriteLine(message);

            var message = son switch
            {
                >0 => "Siz musbat son kiritdingiz",
                (<0) => "Siz manfiy son kiritdingiz",
                _ => $"Siz {son} kiritdingiz",
            };
            System.Console.WriteLine(message);
        }
    }
}
