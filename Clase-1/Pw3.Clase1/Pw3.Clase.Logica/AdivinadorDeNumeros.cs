namespace Pw3.Clase.Logica;

public class AdivinadorDeNumeros
{
    private int _numeroGenerado { get; set; }
   
    public AdivinadorDeNumeros(int numeroGenerado)
    {
        _numeroGenerado = numeroGenerado;
    }

    public AdivinadorDeNumeros(int numeroMin, int numeroMax)
    {
        GenerarNumeroAleatorio(numeroMin, numeroMax);
    }

    public void GenerarNumeroAleatorio(int numeroMin, int numeroMax)
    {
        Random rnd = new Random();
        _numeroGenerado = rnd.Next(numeroMin, numeroMax);
    }

    public string IntentoAdivinar(int numeroIngresado)
    {
        int distancia = Math.Abs(_numeroGenerado - numeroIngresado);

        if (distancia == 0)
        {
            return "Correcto!";
        }
        if (distancia > 75)
        {
            return "Muy Frio!";
        }
        if (distancia > 50)
        {
            return "Frio!";
        }
        if (distancia > 25)
        {
            return "Tibio!";
        }
        if (distancia > 10)
        {
            return "Caliente!";
        }
        if (distancia > 5)
        {
            return "Muy Caliente!";
        }
        if (distancia > 1)
        {
            return "Te estas por quemar!";
        }
        if (distancia > 0)
        {
            return "Ya deberias estar quemandote!";
        }


        return "Helado!";
    }
}
