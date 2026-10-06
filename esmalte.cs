public class Esmalte
{
    private string marca;
    private string cor;
    private double volume;

    public string GetMarca()
    {
        return marca;
    }

    public void SetMarca(string marca)
    {
        this.marca = marca;
    }

    public string GetCor()
    {
        return cor;
    }

    public void SetCor(string cor)
    {
        this.cor = cor;
    }

    public double GetVolume()
    {
        return volume;
    }

    public void SetVolume(double volume)
    {
        this.volume = volume;
    }

    public void Aplicar()
    {
        Console.WriteLine("O esmalte está sendo aplicado.");
    }

    public void Secar()
    {
        Console.WriteLine("O esmalte está secando.");
    }
}