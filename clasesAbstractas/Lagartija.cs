using System;


namespace clasesAbstractas
{
    class Lagartija : Animales
    {
        private String nombre;

        public Lagartija(string nombre)
        {
            this.nombre = nombre;
        }

        public override void GetNombre()
        {
            Console.WriteLine("El nombre de la lagartija es: " + nombre);
        }
    }
}
