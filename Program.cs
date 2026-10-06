class Program
{
    static void Main(string[] args)
    {
        // Imagem 1 - Esmalte
        Esmalte esmalte = new Esmalte();

        esmalte.SetMarca("Risqué");
        esmalte.SetCor("Vermelho");
        esmalte.SetVolume(8);

        Console.WriteLine("=== ESMALTE ===");
        Console.WriteLine("Marca: " + esmalte.GetMarca());
        Console.WriteLine("Cor: " + esmalte.GetCor());
        Console.WriteLine("Volume: " + esmalte.GetVolume() + " ml");
        esmalte.Aplicar();
        esmalte.Secar();


        // Imagem 2 - Bicicleta
        Bicicleta bicicleta = new Bicicleta();

        bicicleta.SetMarca("Caloi");
        bicicleta.SetModelo("Mountain Bike");
        bicicleta.SetMarchas(21);

        Console.WriteLine("\n=== BICICLETA ===");
        Console.WriteLine("Marca: " + bicicleta.GetMarca());
        Console.WriteLine("Modelo: " + bicicleta.GetModelo());
        Console.WriteLine("Marchas: " + bicicleta.GetMarchas());
        bicicleta.Pedalar();
        bicicleta.Frear();


        // Imagem 5 - Bola
        Bola bola = new Bola();

        bola.SetMarca("Penalty");
        bola.SetCor("Branca e preta");
        bola.SetTamanho(22);

        Console.WriteLine("\n=== BOLA ===");
        Console.WriteLine("Marca: " + bola.GetMarca());
        Console.WriteLine("Cor: " + bola.GetCor());
        Console.WriteLine("Tamanho: " + bola.GetTamanho() + " cm");
        bola.Chutar();
        bola.Quicar();


        // Imagem 7 - Sapo
        Sapo sapo = new Sapo();

        sapo.SetNome("Sapinho");
        sapo.SetCor("Verde");
        sapo.SetPeso(0.3);

        Console.WriteLine("\n=== SAPO ===");
        Console.WriteLine("Nome: " + sapo.GetNome());
        Console.WriteLine("Cor: " + sapo.GetCor());
        Console.WriteLine("Peso: " + sapo.GetPeso() + " kg");
        sapo.Pular();
        sapo.Coaxar();


        // Imagem 11 - Casaco
        Casaco casaco = new Casaco();

        casaco.SetMarca("Fashion");
        casaco.SetCor("Vermelho");
        casaco.SetTamanho("M");

        Console.WriteLine("\n=== CASACO ===");
        Console.WriteLine("Marca: " + casaco.GetMarca());
        Console.WriteLine("Cor: " + casaco.GetCor());
        Console.WriteLine("Tamanho: " + casaco.GetTamanho());
        casaco.Vestir();
        casaco.Tirar();
    }
}
