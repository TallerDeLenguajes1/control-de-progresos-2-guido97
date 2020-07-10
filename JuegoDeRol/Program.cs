using System;
using Gtk;
using System.Collections.Generic;

namespace JuegoDeRol
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Random RandGen= new Random();
            int CantPers = RandGen.Next(50);
            string[] OpcionesDeNombres= {"Thine","Nemy","Galah","Lathar","Grabzerg","Kodax","Konhat","Ton","Doshat","Virreb","Sydash","Zac","Ton","Thik'eh","Gahla","Prythar","Prytwi","Va","Riskai","Lastarhat"};
            string[] OpcionesDeApodos = { "Officinal","Violone","Hygrophilous","OpiPhatic","Inappetent","JubekAfreet","Confirmand","AnikZeu","Gorsoon","Spherometer","Squarson","Hieratical","ToninSpado","Theodicy","Cervisial","Cockd117","Cincture","Kinetics","Waldgrave","Semanteme","Worricow","Topophilia","Spinnbar","Canardpicx","Nephelometer","Arrantja555","Vettura","Tibneowl","Mellcann","Sedilia","Arctician"};
            Personaje pers1 = new Personaje("Bart Simpson", "ElBarto",(int) TipoPersonaje.NiñoRata);
            pers1.rellenarAleatorio();
            List<Personaje> personajes = new List<Personaje>{pers1};
            for (int i = 0; i < CantPers; i++)
            {
                Personaje persAux = new Personaje(OpcionesDeNombres[RandGen.Next(OpcionesDeNombres.Length)], OpcionesDeApodos[RandGen.Next(OpcionesDeApodos.Length)], RandGen.Next(6)+1);
                persAux.rellenarAleatorio();
                personajes.Add(persAux);
            }

            foreach (var item in personajes)
            {
                item.MostrarDatos();
            }

            while (personajes.Count > 1) { 
                Personaje perdedor= Combate(personajes[0], personajes[1]);
                personajes.Remove(perdedor);
            }

            Console.WriteLine("TENEMOS UN CAMPEÓN! MERECEDOR DEL TRONO DE HIERRO");
            Console.WriteLine("*************************************************");
            Console.WriteLine("SU NOMBRE ES {0}, MÁS CONOCIDO COMO {1}",personajes[0].Nombre, personajes[0].Apodo);
            Console.WriteLine("FELICIDADES "+ personajes[0].Apodo);

        }

        private static Personaje Combate(Personaje personaje1, Personaje personaje2)
        {
            int cantAtaques = 3;
            for (int i = 0; i < 2* cantAtaques; i++)
            {
                //turno personaje 1
                personaje1.Atacar(personaje2);
                //turno personaje 2
                personaje2.Atacar(personaje1);
            }

            return PremiarGanador(personaje1, personaje2); 

        }

        private static Personaje PremiarGanador(Personaje personaje1, Personaje personaje2)
        {
            int diferencia = personaje1.Salud - personaje2.Salud;
            if (diferencia < 0) //ganó el pers2
            {
                personaje2.Salud += 10;
                Console.WriteLine("Ganó " + personaje2.Apodo);
                return personaje1;
            }
            if(diferencia > 0) //ganó el pers1
            {
                personaje1.Salud += 10;
                Console.WriteLine("Ganó " + personaje1.Apodo);
                return personaje2;
            }
            //empate, premio de consuelo jaja
            Console.WriteLine("EMPATE!");
            personaje1.Salud += 5;
            personaje2.Salud += 5;
            return null;
        }
    }
}
