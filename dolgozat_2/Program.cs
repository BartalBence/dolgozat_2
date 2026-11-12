using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace dolgozat_2
{
    internal class Program
    {
        static string[] huto_elemek = new string[10];
        static string[] seged = new string[10];

        static void Feladat01()
        {
            for (int i = 0; i < huto_elemek.Length - 1; i++)
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



        static void Main(string[] args)
        {
            Feladat01();
            Elhelyezes();
            Elhelyezes();
            Elhelyezes();
            Elhelyezes();
            Takarit();
        }
    }
}
