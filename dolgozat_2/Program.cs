using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace dolgozat_2
{
    internal class Program
    {
        static string[] huto_elemek = new string[10];
        static string[] seged = new string[10];
        static char[] betuk = ['a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű'];
        static int[] szamok = new int[10];
        static int[] novekvo = new int[10];

        static Random r = new Random();

        static void Feladat01()
        {
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                huto_elemek[i] = " ";
            }
        }

        static void Elhelyezes()
        {
            Console.Write("Add meg az elhelyezendő étel nevét: ");
            string etel = Console.ReadLine();
            Console.WriteLine("Add meg, hogy melyik rekeszbe legyen elhelyezve az étel: ");
            int hely = Convert.ToInt32(Console.ReadLine());

            if (huto_elemek[hely - 1] == " ")
            {
                huto_elemek[hely - 1] = etel;
            }
            else
            {
                Console.WriteLine("A rekesz már foglalt, kérem válasszon másik rekeszt.");
            }

            foreach (string item in huto_elemek)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static void Takarit()
        {
            int i = 0;
            for (int x = 0; x < huto_elemek.Length; x++)
            {


                if (huto_elemek[x] != " ")
                {
                    seged[i] = huto_elemek[x];
                    i++;
                }
            }

            huto_elemek = seged;


            foreach (string item in huto_elemek)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static void KeresEtel()
        {
            Console.Write("Add meg a keresett étel nevét: ");
            string etelNeve = Console.ReadLine();
            bool talalat = false;

            for (int i = 0; i < huto_elemek.Length; i++)
            {
                if (huto_elemek[i] == etelNeve)
                {
                    Console.WriteLine($"A keresett étel a(z) {i + 1}. indexen található.");
                    talalat = true;
                }
            }
            if (talalat == false)
            {
                Console.WriteLine(0);
            }
        }

        static void Maganhangzo()
        {
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                if (huto_elemek[i] != null)
                {

                    string etel = huto_elemek[i];
                    char betu = etel[0];


                    for (int x = 0; x < betuk.Length; x++)
                    {
                        if (betuk[x] == betu)
                        {
                            Console.Write(etel + ", ");
                        }
                    }
                }
            }
        }

        //2. Feladat

        

        static void FeltoltEgyediekkel(int min, int max)
        {
            int randomSzam;
            bool szam = false;
            for (int i = 0; i < szamok.Length; i++)
            {

                randomSzam = r.Next(min, max);

                while (szamok.Contains(randomSzam))
                {
                    randomSzam = r.Next(min, max);
                }
                szamok[i] = randomSzam;
            }


            foreach (int item in szamok)
            {
                Console.WriteLine(item);
            }
        }
        
        static void LeghosszabbNovekvo()
        {

            bool torles = false;
            int x = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < szamok[i+1])
                {
                    novekvo[x] = szamok[i];
                    x++;
                }


                else
                {
                    torles = true;
                }
            }
        }


        static void Main(string[] args)
        {
            //Feladat01();
            //Elhelyezes();
            //Elhelyezes();
            //Elhelyezes();
            //Elhelyezes();
            //Takarit();
            //KeresEtel();
            //Maganhangzo();

            //2. Feladat
            FeltoltEgyediekkel(1, 20);
            LeghosszabbNovekvo();
        }
    }
}
