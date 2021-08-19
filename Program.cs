using System;

//1. Todos los lunes, miércoles y viernes, una persona corre la misma ruta y cronometra
//los tiempos obtenidos. Determinar el tiempo promedio que la persona tarda en
//recorrer la ruta en una semana cualquiera.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Lun, Mar, Mi, total;
            Console.WriteLine("Ingrese los tiempos de recorrido en minutos");
            Console.Write("Tiempo recorrido el Lunes    : ");
            Lun = Double.Parse(Console.ReadLine());
            Console.Write("Tiempo recorrido el Martes   : ");
            Mar = Double.Parse(Console.ReadLine());
            Console.Write("Tiempo recorrido el Miércoles: ");
            Mi = Double.Parse(Console.ReadLine());
            Console.WriteLine("El promedio de tiempo es : {0}", total = (Lun + Mar + Mi) / 3);
        }
    }
}


