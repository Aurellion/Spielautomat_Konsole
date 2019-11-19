using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielautomat_Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int guthaben = 5, einsatz, z1, z2, z3, gewinn;
            Random r = new Random();
            Console.WriteLine("Einarmiger Bandit");
        Spiel:
            Console.WriteLine("Ihr Guthaben beträgt: " + guthaben);
        setzen:
            Console.Write("Einsatz wählen:");
            einsatz = Convert.ToInt32(Console.ReadLine());
            if (einsatz > guthaben)
            {
                Console.WriteLine("Der gewählte Einsatz übersteigt das aktuelle Guthaben.");
                goto setzen;
            }
            guthaben -= einsatz;
            z1 = r.Next(1, 10);
            z2 = r.Next(1, 10);
            z3 = r.Next(1, 10);
            Console.WriteLine(z1+" "+z2+" "+z3);
            if (z1 == z2 || z1 == z3 || z2 == z3)
            {
                gewinn = einsatz + 3;
                guthaben += gewinn;
                Console.WriteLine("Gewonnen: " + gewinn);
            }
            else if (z1 == z2 && z2 == z3)
            {
                gewinn = einsatz * 3;
                guthaben += gewinn;
                Console.WriteLine("Hauptgewinn: " + gewinn);
            }
            else Console.WriteLine("Leider kein Gewinn.");

            if (guthaben == 0)
            {
                Console.WriteLine("Spiel vorbei...");
            }
            else goto Spiel;




        }
    }
}
