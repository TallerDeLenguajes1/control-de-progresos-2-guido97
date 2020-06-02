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


        }
    }
    enum Maximos
    {
        Velocidad =10,
        Destreza =5,
        Fuerza =10,
        Nivel =10,
        Armadura=10
    }
}
