using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace dolgozat_2
{
    internal class Program
    {
        static string[] huto_elemek = new string[10];

        static void Feladat01()
        {
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                huto_elemek[i] = "";
            }
        }

        static void elhelyezes()
        {
            Console.Write("Add meg az elhelyezendő étel nevét: ");
            string etel = Console.ReadLine();
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                if (huto_elemek[i] == "")
                {
                    huto_elemek[i] = etel;
                    Console.WriteLine($"Az étel elhelyezve a(z) {i + 1}. rekeszbe.");
                    return;
                }
            }
        }



        static void Main(string[] args)
        {
            Feladat01();

        }
    }
}
