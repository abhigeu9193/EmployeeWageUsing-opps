// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace oops
{
    public class Employeewage
    {
        public static int IS_FULL_TIME=1;

    }
    public static int Employeewage()
    {
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        while(empCheck == 1)
        {
            Console.WriteLine("Employee is persent");
        }
        else
        {
            Console.WriteLine("Employee is not persent");
        }
    }

     public static class Main(string[] args){
         Employeewage();

  

}

    