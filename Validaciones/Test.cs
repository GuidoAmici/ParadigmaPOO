using ConsoleAppHerencia;

namespace Validaciones
{
    public static class Test
    {
        private static Animal? Animal = null;

        public static void Run(Animal animal)
        {
            Animal = animal;
            Show(1);
        }

        public static void Show(int n)
        {
            if (Animal != null && n == 1)
            {
                //TODO Tarea 1: hacer que compile y testear que tire oraciones coherentes modificando solo entidades.
                Console.WriteLine("Habia una vez en algun lugar de la tierra");
                Console.WriteLine("Un " + Animal.ToString() + " rondaba " +  + Animal.Tipo.Ambiente);
                Console.WriteLine("Ya que este aninmal era un " + Animal.getTipo();
                Console.WriteLine(Animal.getNombre() + " solo podía " + Animal.getMetodoDesplazamiento();
            }
        }
    }
}