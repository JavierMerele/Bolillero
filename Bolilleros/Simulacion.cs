using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bolilleros
{
    public class Simulacion
    {

    }

    public void simularSinHilos();

    static void Main(string[] args)
    {
        Task<long> tarea = Task<long>.Run(() => SumaAleatoria());
        tarea.Wait();
        Console.WriteLine(tarea.Result)
    }
}