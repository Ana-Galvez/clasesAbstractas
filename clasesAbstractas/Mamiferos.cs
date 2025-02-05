using System;


namespace clasesAbstractas
{
    class Mamiferos
    {
        public virtual void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Soy capaz de cuidar a mis crías");
        }
    }

    class Ballena : Mamiferos 
    {
        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
    class Caballo: Mamiferos,IMamiferosTerrestres
    {
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
