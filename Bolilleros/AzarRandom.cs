namespace Bolilleros;

public class AzarRandom : IAzar
{
    private Random _random { get; set; }
    public AzarRandom()
        => _random = new Random(DateTime.Now.Millisecond);
    public int SacarIndice(List<int> BolillasAdentro)
        => _random.Next(0, BolillasAdentro.Count);

}
