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
        Task<long>[] hilos = new Task<long>[cantidadHilos];
        var tarea = cantidadSimulaciones / cantidadHilos;

        for (int i = 0; i < cantidadHilos; i++)
        {
            var bolillero = original.clonar();
            hilos[i] = Task<long>.Run(() => (long)bolillero.JugarNveces(jugadas, tarea));
        }


    }



}