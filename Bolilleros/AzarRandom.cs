namespace Bolilleros;

public class AzarRandom : IAzar
{
    private Random _random { get; set; }
    public AzarRandom()
        => _random = new Random(DateTime.Now.Millisecond);
    public int SacarBolilla(List<int> numeros)
        => _random.Next(0, numeros.Count);

}
