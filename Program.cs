using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha23()
            {
              //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 

              int number=Convert.ToInt32(Console.ReadLine());
              
              for (int i=1;i<=number;i++) 
              {
                Console.WriteLine($"(i)^3={Math.Pow(i,3)}");
              }
            }
            Zadacha23();
        }
        
     }
    
}