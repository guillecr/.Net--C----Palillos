using System;

namespace Palillos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contPalillos = 21;
            while (contPalillos > 1)
            {
                String palo = "";
                for (int i = 0; i < contPalillos; i++)
                {
                    palo += "|";
                }
                Console.WriteLine("\n" + palo + "  -> " + contPalillos);
                contPalillos -= QuitarPalillos();
            }
            Console.WriteLine("Has muerto");
            Console.ReadLine();
        }

        private static int QuitarPalillos()
        {
            Boolean test = true;
            int persona = 0;
            int ia = 0;
            while (test)
            {
                try
                {
                    Console.WriteLine("Cuantos palillos quieres quitar");
                    persona = int.Parse(s: Console.ReadLine());
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine("Número no válido");
                    persona = 0;
                }

                test = !(persona < 5 && persona > 0);
                Console.WriteLine((test) ? "Número no válido":"");
            }

            ia = QuitarPalillos(persona);
            Console.WriteLine("Te quito " + ia);
            return persona + ia;
        }

        private static int QuitarPalillos(int palillos)
        {
            return 5 - palillos;
        }
    }
}
