// See https://aka.ms/new-console-template for more information
using ConsoleAppHerencia;
using Validaciones;



static void Main(string[] args)
{

    Animal objetoAnimal;
    string lugar;

    objetoAnimal = null;
    objetoAnimal = new();
    lugar = string.Empty;

    Test.Run(objetoAnimal);

    Test.Show(objetoAnimal);

    Console.WriteLine("Habia una vez en algun lugar de la tierra");
    Console.WriteLine("Un " + objetoAnimal);
    Console.WriteLine("Ya que este aninmal era un " + objetoAnimal.getTipo();
    Console.WriteLine(objetoAnimal.getNombre() + "solo podía " + objetoAnimal.getMetodoDesplazamiento();
}
