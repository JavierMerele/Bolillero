namespace Bolilleros;

public class Bolillero

{
    public int Numeros { get; set; }
    public List <int> BolillasAdentro { get; set; }
    public List <int> BolillasSacada { get; set; }
    public List <int> Jugadas { get; set; }
    public IAzar Azar { get; protected set; }

    public Bolillero()
    {
        this.Numeros = Numeros;
        this.BolillasAdentro = new List<int>();
        this.BolillasSacada = new List<int>();
        this.Jugadas = new List<int>();
    }


    public void SacarBolilla()
    {
        Azar.SacarBolilla(BolillasAdentro);
    }




}
