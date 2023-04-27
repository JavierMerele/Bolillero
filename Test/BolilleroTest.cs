using Bolilleros;

namespace Test;

public class BolilleroTest

{
    public Bolillero bolillero1 { get; protected set; }
    public BolilleroTest() => bolillero1 = new Bolillero(10, new AzarPrimero);
    public void SacarBolillaTest()
    {
        var numero = bolillero1.SacarBolillas();
        var esperado = 0;
        var esperado1 = 9;
        var esperado2 = 1;

        Assert.Equal(numero, esperado);
        Assert.Equal(esperado1, bolillero1.BolillasAdentro.Count);
        Assert.Equal(esperado2, bolillero1.BolillasSacada.Count);
    }
}