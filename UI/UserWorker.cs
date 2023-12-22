﻿
using System.Threading.Channels;

namespace UI
{
    internal class UserWorker
    {
        public void StartWork()
        {
            Equation[] equations = new Equation[2];
            Console.WriteLine($"{new string('*',5)}Добро пожаловать!{new string('*',5)}");
            Console.WriteLine("Введите два уравнения:\nОбразец: Ax+By=C");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ввод {0}-го ур.",i+1);
                string line= Console.ReadLine();
                equations[i] = Equation.GetEquation(line);
                
            }
            Console.WriteLine("Выберите метод решения\nДля выбора используйте соответствующие цифры");
            Console.WriteLine("1)Метод Крамера\n2)Метод Гаусса");
            GetSolution(Console.ReadLine(), equations);
           
        }
        private static void GetSolution(string choise, Equation[] equations)
        {
            var solves = new double[] { };
            switch (choise)
            {
                case "1":
                    solves = new KramerSolver().Solve(equations[0], equations[1]);
                    Console.WriteLine($"X:{solves[0]}\tY:{solves[1]}");
                    break;
                case "2":
                    solves = new GaussSolver().Solve(equations[0], equations[1]);
                    Console.WriteLine($"X:{solves[0]}\tY:{solves[1]}");
                    break;
                default:
                    Console.WriteLine("Выбран неверный вариант.");
                    break;
            }
        }
       
    }
}