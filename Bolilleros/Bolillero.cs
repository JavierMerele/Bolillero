namespace Bolilleros;

public class Bolillero

{
    public int Numeros { get; set; }
    public List<int> BolillasAdentro { get; set; }
    public List<int> BolillasSacada { get; set; }
    public List<int> Jugadas { get; set; }
    public IAzar Azar { get; protected set; }

    public Bolillero(int numeros, IAzar azar)
    {
        this.Numeros = numeros;
        this.BolillasAdentro = new List<int>();
        this.BolillasSacada = new List<int>();
        this.Jugadas = new List<int>();
        this.Azar = azar;
        CrearBolillas(numeros);
    }
    private void CrearBolillas(int numeros)
        {
            for (int i = 0; i <= Numeros; i++)
            BolillasAdentro.Add(i);
        }


    public int SacarBolilla()
    {
        var bolilla = Azar.SacarBolilla(BolillasAdentro);
        BolillasAdentro.Remove(bolilla);
        BolillasSacada.Add(bolilla);
        return bolilla;
    }
    public int SacarIndice()
    {
        var indice = Azar.SacarIndice(this.BolillasAdentro);
        var Numeros = BolillasAdentro[indice];
        return indice;
    }
}