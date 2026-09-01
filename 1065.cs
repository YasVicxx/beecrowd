using System; 

class URI {

        static void Main(string[]args) {

        int quantPar =0;
        for (int i =0; i <5; i ++)
        {
            int valor =int.Parse(Console.ReadLine());
            if (valor %2==0)
            {
                quantPar++;
            }
        }
        Console.WriteLine($"{quantPar} valores pares");

    }

}