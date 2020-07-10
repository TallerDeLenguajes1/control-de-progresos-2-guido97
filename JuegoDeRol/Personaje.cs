using System;
namespace JuegoDeRol
{

    public class Personaje
    {
        public Personaje(string Nombre,string Apodo,int Tipo)
        {
            Salud = 100;
            this.Nombre = Nombre;
            this.Apodo = Apodo;
            this.Tipo = Tipo;
        }

        int Velocidad;
        int Destreza;
        int Fuerza;
        int Nivel;

        int Armadura;
        int Tipo;
        public string Nombre;
        public string Apodo;
        DateTime FechaDeNacimiento;
        int Edad; //entre 0 a 300
        public int Salud;//100

        public void rellenarAleatorio()
        {
            Random generadorAleatorio = new Random();
            Velocidad = generadorAleatorio.Next(1,(int)Maximos.VelocidadMax);
            Destreza = generadorAleatorio.Next(1, (int)Maximos.DestrezaMax);
            Fuerza = generadorAleatorio.Next(1, (int)Maximos.FuerzaMax);
            Nivel = generadorAleatorio.Next(1, (int)Maximos.NivelMax);
            Armadura = generadorAleatorio.Next(1, (int)Maximos.ArmaduraMax);
            int anio = generadorAleatorio.Next(DateTime.Now.Year - (int) Maximos.EdadMax, DateTime.Now.Year);
            int mes = generadorAleatorio.Next(12)+1;
            int dia = 1;
            FechaDeNacimiento = new DateTime(anio, mes, dia).AddDays(generadorAleatorio.Next(365));
        }
        public void MostrarDatos()
        {
            String[] tipos = { "Enano", "Elfo", "Mago", "Guerro", "Arquero", "NiñoRata" };
            Console.WriteLine($"Velocidad={Velocidad}, Destreza={Destreza}, Fuerza={Fuerza}, " +
            	$"Nivel={Nivel}, Armadura={Armadura}, Tipo={tipos[Tipo-1]}, Nombre={Nombre}, Apodo={Apodo}" +
                $", FechaDeNacimiento={FechaDeNacimiento}, Edad={GetEdad()}, Salud={Salud}");

        }

        private int GetEdad()
        {

            int aux = DateTime.Now.Year - FechaDeNacimiento.Year;
            aux = FechaDeNacimiento.Month > DateTime.Now.Month ? aux - 1 :aux;
            return aux;
        }

        public void Atacar(Personaje personaje2)
        {
            int MDP = 50000;

            int PD =Destreza*Fuerza*Nivel;
            int ED = new Random().Next(1,100);
            int VA = PD * ED;

            int PDEF = personaje2.Armadura * personaje2.Velocidad;

            int dañoProvocado= (((VA * ED) - PDEF) / MDP)*100;

            if (dañoProvocado > MDP)
            {
                dañoProvocado = MDP;
            }
            personaje2.Salud -= dañoProvocado;
            Console.WriteLine("Daño provocado por {0}: {1}", Apodo, dañoProvocado);
        }
    }
    enum Maximos
    {
        VelocidadMax =10,
        DestrezaMax = 5,
        FuerzaMax = 10,
        NivelMax = 10,
        ArmaduraMax = 10,
        EdadMax=300
    }

    enum TipoPersonaje
    {
        Enano =1,
        Elfo =2,
        Mago=3,
        Guerrero=4,
        Arquero=5,
        NiñoRata=6
    }
}
