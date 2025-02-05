using System;

namespace clasesAbstractas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lagartija lagartija1 = new Lagartija("Juancho");
            lagartija1.GetNombre();
            Caballo caballo1 = new Caballo("Bucéfalo");
            caballo1.GetNombre();
        }
    }
}
