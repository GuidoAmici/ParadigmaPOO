using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoAnimal
    {
        private string NombreTipo = null;
        private int CantidadPatas = -1;

        public void setTipo(string tipo)
        {
            NombreTipo = tipo;
        }

        public void setPatas(int patas)
        {
            CantidadPatas = patas;
        }

        public string getTipo()
        {
            return NombreTipo;
        }

        public int getCantidadPatas()
        {
            return CantidadPatas;
        }
    }
}
