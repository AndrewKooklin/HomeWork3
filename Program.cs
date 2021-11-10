using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание 1

            string fullName = "Kuklin Andrey Vladimirovich";
            int age = 49;
            string e_mail = "andykook@yandex.ru";
            double progr = 3.52D;
            float maths = 4.36F;
            decimal physics = 5.25M;

            string ageFormat = Convert.ToString(age);
            string progrFormat = progr.ToString();
            string mathFormat = maths.ToString();
            string physicsFormat = physics.ToString();

            string output = $" FullName : {fullName}. age : {ageFormat}. e-mail : {e_mail}.\n " +
                $"Scores : programming : {progrFormat}. mathematics : {mathFormat}. physics : {physicsFormat}";


            Console.WriteLine(output);

            Console.ReadKey();

            // Домашнее задание 2

            double sum_scores = progr + maths + (double)physics;
            string sum = $" Sum scores : {sum_scores:##.##}";
            Console.WriteLine(sum);
            Console.ReadKey();

            double average_scores = sum_scores / 3;
            string average = $" Average scores : {average_scores:##.##}";
            Console.WriteLine(average);
            Console.ReadKey();

        }
    }
}
