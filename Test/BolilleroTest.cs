using Bolilleros;

namespace Test;

public class BolilleroTest

{
    public BolilleroTest Bolillero1 {get; set;}
    public BolilleroTest()=> Bolillero1 = new Bolillero(2, Azar);

    [Fact]
    public void Constructor()
    {
        Assert.Equal(new List<int>{0,1,2,3,4,5,6,7,8,9},Bolillero1.BolillasAdentro);
    }
}