using System;

namespace ObjetosVoladores // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa...");
            Console.WriteLine("Instanciando 3 drones paps...");
            Dron miDron1 = new Dron();
            Dron miDron2 = new Dron();
            Dron miDron3 = new Dron();
            miDron1.Encender();
            Console.WriteLine( miDron1.ToString());
            Console.WriteLine( miDron2.ToString());
            Console.WriteLine( miDron3.ToString());

            Avion miAvio = new Avion();

            miAvio.despegar();
            miDron1.despegar();


            Console.ReadKey();
        }
    }
}