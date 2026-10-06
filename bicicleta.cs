public class Bicicleta
{
    private string marca;
    private string modelo;
    private int marchas;

    public string GetMarca()
    {
        return marca;
    }

    public void SetMarca(string marca)
    {
        this.marca = marca;
    }

    public string GetModelo()
    {
        return modelo;
    }

    public void SetModelo(string modelo)
    {
        this.modelo = modelo;
    }

    public int GetMarchas()
    {
        return marchas;
    }

    public void SetMarchas(int marchas)
    {
        this.marchas = marchas;
    }

    public void Pedalar()
    {
        Console.WriteLine("A bicicleta está sendo utilizada.");
    }

    public void Frear()
    {
        Console.WriteLine("A bicicleta está freando.");
    }
}s