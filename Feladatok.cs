using System;

namespace suli
{
    class Program
    {
        static void Main(string[] args)
        {

            int szam;
            char valasztas;
            int faktorialis = 1;
            char valasztas2;

            do {

              
            

                Console.WriteLine("Írj be egy számot!");

                szam = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Mit szeretne tenni a számmal? \n (a) gyököt vonni \n (b) megtudni hogy prím vagy sem \n (c) szám négyzetét  \n (d) A szám faktoriálisát");

                valasztas = Char.Parse(Console.ReadLine());

                if (valasztas == 'a') {

                Console.WriteLine("A szám gyöke : {0}" , Math.Sqrt(szam));
                }

                if (valasztas == 'b') {

                    if (Prim(szam)) {

                        Console.WriteLine("A {0} szám prím" , szam);
                    }

                    else {

                        Console.WriteLine("A {0} szám nem prím" , szam);

                    }
                }

                if (valasztas == 'c') {

                    Console.WriteLine("A {0} szám négyzete : {1}" , szam , Math.Pow(szam , 2));
                }

                if (valasztas == 'd') {

                    if (szam < 0) {

                        Console.WriteLine("Nem lehet negatív számot megadni faktoriálisnál");

                        
                    }

                    else {

                        for (int i = 1; i <= szam; i++) {

                            faktorialis = faktorialis * i;
                        }

                        Console.WriteLine("A {0} szám faktoriálisa: {1}" , szam , faktorialis);

                    }
                }

                Console.WriteLine("Újra akarja használni a programot? <I> Igen <N> Nem");

                valasztas2 = Char.Parse(Console.ReadLine());

                if (valasztas2 == 'N') {

                    Console.WriteLine("Ön kilépett");
                }

            } while (valasztas2 == 'I');


            int[] tomb = new int[1000];

            Random rnd = new Random();

         


            for (int i = 1; i < tomb.Length; i++) {

                tomb[i] = rnd.Next(0 , tomb.Length);

            }
            

            

            // Console.WriteLine("{0}" , tomb.Length); // Output: 1000
            

        }

        private static bool Prim(int szam) {

            for (int i = 2; i < szam /2; i++) {

                if (szam % i == 0) {

                    return false;
                }
            }

            return true;
        }
    }

}

