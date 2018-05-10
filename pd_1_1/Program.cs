using System;

namespace pd_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("ka tevi sauc");

            string ievade = Console.ReadLine();

            Console.WriteLine("sveiki," + ievade);

            //2

            Console.WriteLine("kura gada esi dzimis");

            string dzimsanas_datums = Console.ReadLine();

            int mainiagais;

            mainiagais = Convert.ToInt16(dzimsanas_datums);

            Console.WriteLine("kurs gads ir sogad");

            string gads = Console.ReadLine();

            int mainigais1;

            mainigais1 = Convert.ToInt16(gads);

            Console.WriteLine(mainigais1-mainiagais);

            //3
            Console.WriteLine("ievadit rinka linijas radiusu");

            string radius = Console.ReadLine();

            int mainigais2;

            mainigais2 = Convert.ToInt16(radius);//radius ir 3.14

            Console.WriteLine();

            int mainigais3;

            mainigais3 = 2* mainigais2;

            double  mainigais4;

            mainigais4 = 2*3.14 * mainigais2;

            Console.WriteLine("diametrs ir " + mainigais3);
            Console.WriteLine("laukums ir " + mainigais4);







            Console.ReadLine();
        }

    }
}
