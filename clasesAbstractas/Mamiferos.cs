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

        public sealed override void Pensar()
        {
            Console.WriteLine("Soy un humano capaz de pensar");
        }
        public int NumerosPatas()
        {
            return 2;
        }
    }

    class Adolescente : Humano
    {
        public Adolescente(string nombre) : base(nombre)
        {
        }
        public void Pensar() //con override sale error por el sealed del pensar de Humano porque no puede sobreescribirlo
        {
            Console.WriteLine("Soy un adolescente con las hormonas alborotadas");
        }

    }
    sealed class Gorila : Mamiferos, IMamiferosTerrestres
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
    //class Chimpance : Gorila
    //{
    //    public Chimpance(string nombre) : base(nombre)
    //    {
    //    }

    //}

}
