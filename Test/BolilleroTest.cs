using Bolilleros;
using Xunit;

namespace Test;

public class BolilleroTest

{
    public Bolillero Bolillero1 { get; protected set; }
    public BolilleroTest() => Bolillero1 = new Bolillero(10, new AzarPrimero());


    [Fact]
    public void SacarBolillaTest()
    {
        var numero = Bolillero1.SacarBolillas();
        var bolilla = 0;
        var bolilla1 = 9;
        var bolilla2 = 1;

        Assert.Equal(numero, bolilla);
        Assert.Equal(bolilla1, Bolillero1.BolillasAdentro.Count);
        Assert.Equal(bolilla2, Bolillero1.BolillasSacada.Count);
    }


    [Fact]
    public void ReingresarBolillaTest()
    {
        Bolillero1.SacarBolillas();
        Bolillero1.SacarBolillas();
        var esperado = 10;
        var esperado1 = 0;

        Assert.Equal(esperado, Bolillero1.BolillasAdentro.Count);
        Assert.Equal(esperado1, Bolillero1.BolillasSacada.Count);
    }


    [Fact]
    public void JugarGana()
    {
        var jugada = new List<int>() { 0, 1, 2, 3 };
        var intentoGana = Bolillero1.Jugar(jugada);

        Assert.True(intentoGana);
    }




    [Fact]
    public void JugarPierde()
    {
        var intentoPierde = Bolillero1.Jugar(Jugadas: new List<int> { 4, 2, 1 });

        Assert.False(intentoPierde);
    }





    [Fact]
    public void JugarNVecesGana()
    {
        var jugada = Bolillero1.JugarNveces(Jugadas: new List<int> { 0, 1 }, 1);

        Assert.Equal(1, jugada);
    }



}