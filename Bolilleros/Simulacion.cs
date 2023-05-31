using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bolilleros;

public class simulaciones

{
    public static long simularSinHilos (Bolillero bolillero1, List<int> jugadas, int simulaciones)
    {
        bolillero1.JugarNveces(jugadas, simulaciones);
    }   

}