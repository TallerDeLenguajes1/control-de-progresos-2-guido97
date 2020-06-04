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
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
