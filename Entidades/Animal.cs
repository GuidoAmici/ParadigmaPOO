using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHerencia
{
    public class Animal
    {
        // ATRIBUTOS
        private string Nombre = null;
        private TipoAnimal Tipo = null;
        


        //METODOS
        public Animal(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = new();

        }

        public string getNombre()
        {
            return "Este animal se llama " + Nombre;
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Tipo + " de nombre " + Nombre + " que tiene " + Tipo.getCantidadPatas() + " patas";
        }
    }
}
