using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja3_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operacje matematyczne

            int a = 5;
            int b = 10;
            int c = 4;

            //dodawanie
            int suma = a + b + c;
            Console.WriteLine(suma);

            //odejmowanie
            int roznica = a - b - c;
            Console.WriteLine(roznica);

            //mnożenie
            int iloczyn = a * b * c;
            Console.WriteLine(iloczyn);

            //dzielenie
            int iloraz = b / a;
            Console.WriteLine(iloraz);

            //modulo - reszta z dzielenia
            int modulo = b % c;   // 10 / 4 = 2  r2
            Console.WriteLine(modulo);

            //kolejność wykonywnia działań
            int kwd = (a + b) * c;

            //precyzja obliczeń
            double liczba1 = 5.5;
            double liczba2 = 3.25;

            double wynik = (liczba1 * liczba2) / 2.13;
            Console.WriteLine(wynik);

            //Wprowadzanie danych do programu
            //Console.WriteLine("Ile masz wzrostu w cm?");
            //int wzrost = int.Parse(Console.ReadLine());
            //Console.WriteLine("Twój wzrost wynosi: " + wzrost + "cm");

            //Console.WriteLine("Jak masz na imię?");
            //string imie = Console.ReadLine();
            //Console.WriteLine("Witaj " + imie);

            //ctrl + k + c - komentowanie     ctrl + k + u - odkomentowanie

            //Zadanie z trapezem
            // pole trapezu = (a+b)*h/2

            //double podstawa1, podstawa2, wysokosc;

            //Console.WriteLine("Podaj długość podstawy górnej");
            //podstawa1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj długość podstawy dolnej");
            //podstawa2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj wysokość trpezu");
            //wysokosc = double.Parse(Console.ReadLine());

            //double pole = (podstawa1 + podstawa2) * wysokosc / 2;
            //Console.WriteLine($"Pole trapezu wynosi {pole}cm");


            //KLASA MATEMATYCZNA

            //potęgowanie
            Console.WriteLine(Math.Pow(2, 15));

            //pierwiastki
            Console.WriteLine(Math.Sqrt(3));

            //stałe (pi)
            Console.WriteLine(Math.PI);


            //Zadanie na koniec

            //obliczamy pole koła 
            //pole koła = PI * r^2

            Console.WriteLine("Podaj promień koła");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Pole koła = " + (Math.PI * Math.Pow(r, 2)));

            Console.ReadLine();
        }
    }
}
