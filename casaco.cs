public class Casaco
{
    private string marca;
    private string cor;
    private string tamanho;

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

    public string GetTamanho()
    {
        return tamanho;
    }

    public void SetTamanho(string tamanho)
    {
        this.tamanho = tamanho;
    }

    public void Vestir()
    {
        Console.WriteLine("O casaco foi vestido.");
    }

    public void Tirar()
    {
        Console.WriteLine("O casaco foi retirado.");
    }
}ss