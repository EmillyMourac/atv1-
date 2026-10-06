public class Sapo
{
    private string nome;
    private string cor;
    private double peso;

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetCor()
    {
        return cor;
    }

    public void SetCor(string cor)
    {
        this.cor = cor;
    }

    public double GetPeso()
    {
        return peso;
    }

    public void SetPeso(double peso)
    {
        this.peso = peso;
    }

    public void Pular()
    {
        Console.WriteLine("O sapo pulou.");
    }

    public void Coaxar()
    {
        Console.WriteLine("O sapo coaxou.");
    }
}s