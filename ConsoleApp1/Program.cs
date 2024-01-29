using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Autovetture auto1 = new Autovetture();  // istanzio classe
            
            auto1.Marca = "BMW";   // set

            Autovetture auto2 = new Autovetture();
            auto2.Marca = "Ford";   // set

            Console.WriteLine("Auto1: " + auto1.Marca); // get
            Console.WriteLine("\n");    // new line

            Console.WriteLine("Auto2: " + auto2.Marca);

            Console.WriteLine("\n");
            auto1.Marca = "Ferrari";

            Console.WriteLine("Auto1 Aggiornata: " + auto1.Marca);
            Console.WriteLine("\n");

            string Messaggio = auto1.kmTagliando(500);  // richiamo metodo passando valore
            Console.WriteLine(Messaggio);
            Console.WriteLine("\n");

            string altroMessaggio = auto2.kmTagliando(15000);
            Console.WriteLine(altroMessaggio);
            Console.WriteLine("\n");
            // Console.ReadLine(); // attendo un input

            //////////////////////////////////////////////////////////////////

            Atleta atl1 = new Atleta();
            atl1.Sport = "100metri";
            Console.WriteLine("Atleta1 pratica: " + atl1.Sport + "\n");
            string messaggio = atl1.vittorie(7);
            Console.WriteLine(messaggio + "\n");
            atl1.Sport = "Salto in alto";
            Console.WriteLine("Atleta1 pratica: " + atl1.Sport + "\n");

            Atleta atl2 = new Atleta();
            atl2.Sport = "Lancio del peso";
            Console.WriteLine("Atleta2 pratica: " + atl2.Sport + "\n");
            string messaggio2 = atl2.vittorie(3);
            Console.WriteLine(messaggio2 + "\n");
            // Console.ReadLine();



            Dipendente dpn1 = new Dipendente();
            dpn1.Azienda = "Epicode";
            string message = dpn1.anniEsperienza(8);
            Console.WriteLine("Dipendente1 lavora presso: " + dpn1.Azienda + "\n");
            Console.WriteLine(message + "\n");

            Dipendente dpn2 = new Dipendente();
            dpn2.Azienda = "Boolean";
            string message2 = dpn2.anniEsperienza(3);
            Console.WriteLine("Dipendente2 lavora presso: " + dpn2.Azienda + "\n");
            Console.WriteLine(message2 + "\n");
            // Console.ReadLine();



            Animale animale1 = new Animale();
            animale1.Genere = "rettile";
            animale1.Razza = "tartaruga dalle orecchie rosse";
            animale1.Terrirorio = "stagno e/o lago";
            Console.WriteLine("animale1 e' un: " + animale1.Genere + " specificatamente un/a " + animale1.Razza + " e vive nel" + animale1.Terrirorio);

            Animale animale2 = new Animale();
            animale2.Genere = "mammifero";
            animale2.Razza = "balena della Groenlandia";
            animale2.Terrirorio = "oceano";
            Console.WriteLine("animale2 e' un: " + animale2.Genere + " specificatamente un/a " + animale2.Razza + " e vive nel" + animale2.Terrirorio);

            Animale animale3 = new Animale();
            animale3.Genere = "uccello";
            animale3.Razza = "aquila reale";
            animale3.Terrirorio = "montagna";
            Console.WriteLine("animale3 e' un: " + animale3.Genere + " specificatamente un/a " + animale3.Razza + " e vive nel" + animale3.Terrirorio);
            // Console.ReadLine();


            Veicolo macchina1 = new Veicolo();
            macchina1.Marca = "mercedes";
            macchina1.Modello = "classe A";
            Console.WriteLine("la macchina1 e' una: " + macchina1.Modello + " della " + macchina1.Marca);
            string msg = macchina1.kmAlLitro(42);

            Veicolo macchina2 = new Veicolo();
            macchina2.Marca = "fiat";
            macchina2.Modello = "panda";
            Console.WriteLine("la macchina2 e' una: " + macchina2.Modello + " della " + macchina2.Marca);
            string msg2 = macchina2.kmAlLitro(78);
            Console.ReadLine();
        }
    }
}
