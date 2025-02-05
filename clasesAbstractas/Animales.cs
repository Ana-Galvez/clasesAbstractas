using System;

namespace clasesAbstractas
{
    abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public abstract void GetNombre();

    }

}
