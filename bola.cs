public class Bola
{
    private string marca;
    private string cor;
    private double tamanho;

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

    public double GetTamanho()
    {
        return tamanho;
    }

    public void SetTamanho(double tamanho)
    {
        this.tamanho = tamanho;
    }

    public void Chutar()
    {
        Console.WriteLine("A bola foi chutada.");
    }

    public void Quicar()
    {
        Console.WriteLine("A bola está quicando.");
    }
}s