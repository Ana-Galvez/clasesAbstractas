using System;


namespace clasesAbstractas
{
    class Mamiferos : Animales
    {
        private String nombre;

        public Mamiferos(string nombre)
        {
            this.nombre = nombre;
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Soy capaz de cuidar a mis crías");
        }

        public override void GetNombre()
        {
            Console.WriteLine("El nombre del mamífero es: " + nombre);
        }
    }

    class Ballena : Mamiferos 
    {
        public Ballena(string nombre) : base(nombre)
        {
        }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
    class Caballo: Mamiferos,IMamiferosTerrestres
    {
        public Caballo(string nombre) : base(nombre)
        {
        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        public int NumerosPatas()
        {
            return 4;
        }
    }
    class Humano : Mamiferos, IMamiferosTerrestres
    {
        public Humano(string nombre) : base(nombre)
        {
        }

        public override void Pensar()
        {
            Console.WriteLine("Soy un humano capaz de pensar");
        }
        public int NumerosPatas()
        {
            return 2;
        }
    }
    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombre) : base(nombre)
        {
        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public int NumerosPatas()
        {
            return 2;
        }
    }

}
