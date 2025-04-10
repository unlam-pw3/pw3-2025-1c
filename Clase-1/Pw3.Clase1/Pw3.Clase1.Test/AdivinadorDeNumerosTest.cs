using Pw3.Clase.Logica;

namespace Pw3.Clase1.Test;

public class AdivinadorDeNumerosTest
{
    [Fact]
    public void IntentoAdivinar_MayorA50_Frio()
    {
        AdivinadorDeNumeros adivinadorDeNumeros = new AdivinadorDeNumeros(0,100);
        string pista = adivinadorDeNumeros.IntentoAdivinar(51);

        Assert.Equal("Frio!", pista);
    }

    [Theory]
    [InlineData(10, 86, "Muy Frio!")]
    [InlineData(10, 61, "Frio!")]
    [InlineData(10, 36, "Tibio!")]
    [InlineData(10, 21, "Caliente!")]
    [InlineData(10, 16, "Muy Caliente!")]
    [InlineData(10, 12, "Te estas por quemar!")]
    [InlineData(10, 11, "Ya deberias estar quemandote!")]
    public void IntentoAdivinar_IncluyeTodasLasPistas(int numeroGenerado, int numeroIngresado, string pistaEsperada)
    {
        AdivinadorDeNumeros adivinadorDeNumeros = new AdivinadorDeNumeros(numeroGenerado);
        string pista = adivinadorDeNumeros.IntentoAdivinar(numeroIngresado);

        Assert.Equal(pistaEsperada, pista);
    }

    [Fact]
    public void IntentoAdivinar_IngresaNumeroNegativo_Exitoso()
    {
        AdivinadorDeNumeros adivinadorDeNumeros = new AdivinadorDeNumeros(10);
        string pista = adivinadorDeNumeros.IntentoAdivinar(-1);

        Assert.Equal("Caliente!", pista);
    }

    [Fact]
    public void IntentoAdivinar_IngresaNumeroMuyGrande_Exitoso()
    {
        AdivinadorDeNumeros adivinadorDeNumeros = new AdivinadorDeNumeros(10);
        string pista = adivinadorDeNumeros.IntentoAdivinar(5000);

        Assert.Equal("Muy Frio!", pista);
    }
}