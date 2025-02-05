using System;

namespace clasesAbstractas
{
    class Animales
    {
        String nombre;

        public Animales(string nombre)
        {
            this.nombre = nombre;
        }

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void getNombre()
        {
            Console.WriteLine("El nombre del animal es: "+nombre);
        }

    }
}
