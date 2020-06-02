using System;
using Gtk;

namespace JuegoDeRol
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Personaje pers1 = new Personaje("Bart Simpson", "ElBarto",(int) TipoPersonaje.NiñoRata);
            pers1.rellenarAleatorio();

            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
