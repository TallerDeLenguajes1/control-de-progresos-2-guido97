using System;
namespace JuegoDeRol
{

    public class Personaje
    {
        public Personaje()
        {
            int Velocidad;
            int Destreza;
            int Fuerza;
            int Nivel;
            int Armadura;

            int Tipo;
            string Nombre;
            string Apodo;
            DateTime FechaDeNacimiento;
            int Edad; //entre 0 a 300
            int Salud;//100

            Random generadorAleatorio = new Random();
            Velocidad = generadorAleatorio.Next((int)Maximos.VelocidadMax);

        }
    }
    enum Maximos
    {
        VelocidadMax =10,
        DestrezaMax = 5,
        FuerzaMax = 10,
        NivelMax = 10,
        ArmaduraMax = 10
    }
}
