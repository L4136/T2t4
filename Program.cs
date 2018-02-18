using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2t4
{
    class Program
    {
        static void Main(string[] args)
        
            {
                int nbrGrades = 8;
                int[] grades = new int[nbrGrades];
                for (int i = 0; i < nbrGrades; i++)
                {
                    Console.Write("Give grade: ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 0: grades[0]++; break;
                        case 1: grades[1]++; break;
                        case 2: grades[2]++; break;
                        case 3: grades[3]++; break;
                        case 4: grades[4]++; break;
                        case 5: grades[5]++; break;
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(i + ":");
                    starPrint(grades[i]);
                    Console.WriteLine();
                }
            }

            static void starPrint(int i)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
            }
       
    }
}
