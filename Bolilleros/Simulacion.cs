using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bolilleros;

public class Simulacion

{
    public long simularSinHilos(Bolillero original, List<int> jugadas, int cantidadSimulaciones)
        => original.JugarNveces(jugadas, cantidadSimulaciones);

    public long simularConHilos(Bolillero original, List<int> jugadas, int cantidadSimulaciones, int cantidadHilos)
    {
        var hilos = GenerarProcesos(original, jugadas, cantidadSimulaciones, cantidadHilos);
        Task<long>.WaitAll(hilos);
        return hilos.Sum(s => s.Result);
    }

    private static Task<long>[] GenerarProcesos(Bolillero original, List<int> jugadas, int cantidadSimulaciones, int cantidadHilos)
    {
        Task<long>[] hilos = new Task<long>[cantidadHilos];
        var tarea = cantidadSimulaciones / cantidadHilos;

        for (int i = 0; i < cantidadHilos; i++)
        {
            var bolillero = original.clonar();
            hilos[i] = Task<long>.Run(() => (long)bolillero.JugarNveces(jugadas, tarea));
        }

        return hilos;
    }

    public async Task<long> simularConHilosAsync(Bolillero original, List<int> jugadas, int cantidadSimulaciones, int cantidadHilos)
    {
        var hilos = GenerarProcesos(original, jugadas, cantidadSimulaciones, cantidadHilos);
        await Task<long>.WhenAll(hilos);
        return hilos.Sum(s => s.Result);

    }
}