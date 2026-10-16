namespace Tombok_szamokal
{
    internal class Program
    {
        static int[] tomb = new int[15];

        static Random r = new Random();

        static void Feltolt()
        {
            for(int  i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);
            }
            foreach(int item in tomb)
            {
                Console.Write(item + " ");
            }
        }

        static void OsszegzesTetele()
        {
            int osszeg = 0;
            foreach(int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"A számok összege: {osszeg}");
        }

        static void MegszamlalasTerele()
        {
            int db = 0;
            foreach(int item in tomb)
            {
                if (item < 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"A negatív számok db:{db}");
        }

        static void EldontesTetel()
        {
            int i = 0;
            while (i<tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("van 0 a tömbben.");
            }
        }

        static void Main(string[] args)
        {
            Feltolt();
            OsszegzesTetele();
            MegszamlalasTerele();
            EldontesTetel();
        }
    }
}
