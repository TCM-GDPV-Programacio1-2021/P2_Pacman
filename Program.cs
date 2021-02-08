using System;
using System.Collections.Generic;
using System.Threading;

namespace Pacman
{
    
    class Program
    {
               
        // PENDENT IMPLEMENTAR : 
        // defineix una llista de fantasmas
        // defineix un objecte de la classe Taulell
        // defineix un objecte de la classe Pacman
        

        static void Main()
        {
            Console.WriteLine("Hello World!");
            String s = null;

            init();
            // PENDENT IMPLEMENTAR : crida el mètode start de la classe Hud
            
            mostrar();

            while ( s == null)
            {
                s = update();
                mostrar();
                Thread.Sleep(700);//miliseconds
            }

            // PENDENT IMPLEMENTAR : crida el mètode End de la classe Hud

        }
        private static void init()
        {
            // PENDENT IMPLEMENTAR :
            // inicialitza tots els atributs
            // l'objecte myTaulell de la classe Taulell
            // l'objecte thePacman de la classe Pacman
            // crida el mètode PacmanPosition de l'objecte myTaulell per menjar la primera galeta
            // inicialitza la llista dels fantasmes amb 4 objectes, cadascú a una cantonada del laberint i en un color diferent
        }

        private static String update()
        {

            if (Console.KeyAvailable)
            {
                // PENDENT IMPLEMENTAR :
                // moure el pacman a partir de l'entrada de l'usuari
                // utiliza els mètodes setPosition de la classe pacman
                // i els mètodes checkPosition i PacmanPosition de la classe Taulell

            }

            // PENDENT IMPLEMENTAR :
            // moure tots els fantasmes de la llista
            // si un fantasma atrapa al pacman retorna el missatge


            // PENDENT IMPLEMENTAR :
            // si pacman guanya la partida retorna el missatge

        }
        private static void mostrar()
        {
            // PENDENT IMPLEMENTAR :
            // primer mostra el taulell
            // després els fantasmes i el pacman
            // per últim el Hud
        }

    }
}
