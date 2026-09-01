using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante que o ponto decimal '.' seja usado como separador, e não a vírgula
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // Lê os dois valores de dupla precisão (double)
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        // Calcula a média ponderada com os pesos 3.5 e 7.5
        double media = ((A * 3.5) + (B * 7.5)) / 11.0;

        // Imprime o resultado com exatamente 5 casas decimais e fim de linha
        Console.WriteLine($"MEDIA = {media:F5}");
    }
}