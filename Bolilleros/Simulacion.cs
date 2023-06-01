using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bolilleros;

public class Simulacion

{
    public long simularSinHilos(Bolillero original, List<int> jugadas, int cantidad)
    {
        original.JugarNveces(jugadas, cantidad);
    }

    public long simularConHilos(Bolillero original, List<int> jugadas, int cantidad, int cantidadHilos);
    {
        Task<long> cantidad = new Task<long>.(cantidadHilos)
    }
    
}