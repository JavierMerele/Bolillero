namespace Bolilleros;

public class Bolillero : IClonable

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
        for (int i = 0; i < Numeros; i++)
            BolillasAdentro.Add(i);
    }

    public bool Jugar(List<int> Jugadas)
    {

        for (int i = 0; i < Jugadas.Count; i++)
        {
            var bolillaRandom = SacarBolilla();
            if (bolillaRandom != Jugadas[i])
                return false;

        }
        return true;
    }


    public int JugarNveces(List<int> Jugadas, int cantidad)
    {
        var Victoria = 0;
        for (int i = 0; i <= cantidad; i++)
        {
            var JugarNveces = Jugar(Jugadas);
            if (JugarNveces == true)
                Victoria = Victoria + 1;
        }
        return Victoria;
    }


    public int SacarBolilla()
    {
        var indice = Azar.SacarIndice(this.BolillasAdentro);
        var bolilla = BolillasAdentro[indice];

        BolillasAdentro.Remove(bolilla);
        BolillasSacada.Add(bolilla);
        return bolilla;
    }

    public void ReingresarBolillas()
    {
        BolillasAdentro.AddRange(BolillasSacada);
        BolillasSacada.Clear();
    }




}